﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _07_MvcOA.BLL;
using _07_MvcOA.IBLL;
using _07_MvcOA.Model;
using _07_MvcOA.Common;

namespace _07_MvcOA.WebApp.Controllers
{
    public class UserInfoController : BaseController
    {
        // GET: UserInfo
        private IUserInfoBLL UserInfoBll { get; set; }
        private IRoleInfoBLL RoleInfoBll { get; set; }
        private IActionInfoBLL ActionInfoBll { get; set; }
        private IR_UserInfo_ActionInfoBLL R_UserInfo_ActionInfoBll { get; set; }
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <returns></returns>
        public ActionResult GetUserInfo()
        {
            var pageIndex = Request["page"] != null ? int.Parse(Request["page"]) : 1;
            var pageSize = Request["rows"] != null ? int.Parse(Request["rows"]) : 5;
            var name = Request["name"];
            var remark = Request["remark"];
            //构建搜索条件
            int totalCount = 0;
            var userInfoParam = new UserInfoParam()
            {
                UserName = name,
                Remark = remark,
                PageIndex = pageIndex,
                PageSize = pageSize,
                TotalCount = totalCount
            };

            //short delFlag = (short)DelFlagEnum.Normal;
            //var userInfoList = UserInfoBll.LoadPageEntities(pageIndex, pageSize, out totalCount,
            //    c => c.DelFlag == delFlag,
            //    c => c.UserID, true);

            var temp = UserInfoBll.LoadSearchEntities(userInfoParam)
                .Select(u => new
                {
                    ID = u.UserID,
                    UserName = u.UserName,
                    UserPass = u.UserPwd,
                    Remark = u.Remark,
                    RegTime = u.SubTime,
                });

            return Json(new
            {
                rows = temp,
                total = userInfoParam.TotalCount
            }, JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 删除用户信息
        /// </summary>
        /// <returns></returns>
        public ActionResult DeleteUserInfo()
        {
            string strId = Request["strId"];
            var strIds = strId.Split(',');
            var list = new List<int>();
            foreach (var id in strIds)
            {
                list.Add(int.Parse(id));
            }

            if (UserInfoBll.DeleteEntities(list))
            {
                return Content("ok");
            }
            else
            {
                return Content("no");
            }
        }
        /// <summary>
        /// 添加用户信息
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public ActionResult AddUserInfo(UserInfo userInfo)
        {
            userInfo.DelFlag = 0;
            userInfo.SubTime = DateTime.Now;
            userInfo.ModifiedOn = DateTime.Now;
            UserInfoBll.AddEntity(userInfo);

            return Json("ok");
        }
        /// <summary>
        /// 通过ID查询用户信息
        /// </summary>
        /// <returns></returns>
        public ActionResult GetUserInfoModel()
        {
            int id = int.Parse(Request["id"]);
            var userInfo = UserInfoBll.LoadEntities(c => c.UserID == id).FirstOrDefault();

            if (userInfo != null)
            {
                //存在Json序列化时，循环引用的问题。
                //return Json(new { serverData = userInfo, msg = "ok" }, JsonRequestBehavior.AllowGet);
                //Newtonsoft.Json，先序列化成字符串，在返回该字符串。
                return Content(SerializerHelper.SerializerToString(new { serverData = userInfo, msg = "ok" }));
            }
            else
            {
                //return Json(new { msg = "no" }, JsonRequestBehavior.AllowGet);
                return Content(SerializerHelper.SerializerToString(new { msg = "no" }));
            }
        }
        /// <summary>
        /// 编辑用户信息
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public ActionResult EditUserInfo(UserInfo userInfo)
        {
            userInfo.ModifiedOn = DateTime.Now;
            if (UserInfoBll.EditEntity(userInfo))
            {
                return Content("ok");
            }
            else
            {
                return Content("no");
            }
        }
        /// <summary>
        /// 为用户分配角色
        /// </summary>
        /// <returns></returns>
        public ActionResult SetUserRoleInfo()
        {
            var id = int.Parse(Request["userId"]);
            var userInfo = UserInfoBll.LoadEntities(u => u.UserID == id).FirstOrDefault();
            ViewBag.userInfo = userInfo;
            //查询所有的角色信息
            var delFlag = (short)DelFlagEnum.Normal;
            var roleInfoList = RoleInfoBll.LoadEntities(r => r.DelFlag == delFlag).ToList();
            //找出用户已经有的角色编号
            var userRoleIdList = userInfo.RoleInfo.Select(u => u.ID).ToList();

            ViewBag.AllRoleInfo = roleInfoList;
            ViewBag.AllExtRoleId = userRoleIdList;

            return View();
        }
        //完成对用户角色的分配
        public ActionResult SetUserRole()
        {
            var userId = int.Parse(Request["userId"]);

            //Post请求中的表单元素以键值对表示
            //[name,value]，key是name;所以要递交的表单元素必须要有name.
            var allKeys = Request.Form.AllKeys;//获取Post请求中Form表单元素所有的键(name)
            var idList = new List<int>();
            foreach (string key in allKeys)
            {
                if (key.StartsWith("cba_"))
                {
                    var id = int.Parse(key.Replace("cba_", ""));
                    idList.Add(id);
                }
            }

            var result = "";
            if (UserInfoBll.SetUserOrderInfo(userId, idList))
                result = "ok";
            else
                result = "no";

            return Content(result);
        }
        /// <summary>
        /// 为用户分配权限
        /// </summary>
        /// <returns></returns>
        public ActionResult SetUserActionInfo()
        {
            var userId = int.Parse(Request["userId"]);
            //查询要分配权限的用户信息
            var userInfo = UserInfoBll.LoadEntities(u => u.UserID == userId).FirstOrDefault();
            ViewBag.UserInfo = userInfo;
            //获取所有的权限信息
            var delFlag = (short)DelFlagEnum.Normal;
            var allActionList = ActionInfoBll.LoadEntities(a => a.DelFlag == delFlag).ToList();
            ViewBag.ActionList = allActionList;
            //获取所有用户已经有的权限
            var allActionIdList = userInfo.R_UserInfo_ActionInfo.ToList();
            ViewBag.ActionIdList = allActionIdList;

            return View();
        }
        /// <summary>
        /// 设置用户权限的值
        /// </summary>
        /// <returns></returns>
        public ActionResult SetActionUser()
        {
            var userId = int.Parse(Request["userId"]);
            var actionId = int.Parse(Request["actionId"]);
            var isPass = Request["value"] == "true" ? true : false;
            if (UserInfoBll.SetUserActionInfo(userId, actionId, isPass))
            {
                return Content("ok");
            }
            else
            {
                return Content("no");
            }
        }
        /// <summary>
        /// 删除特殊用户的权限
        /// </summary>
        /// <returns></returns>
        public ActionResult ClearUserAction()
        {
            var result = "";

            #region 方法一
            //var userId = int.Parse(Request["userId"]);
            //var actionId = int.Parse(Request["actionId"]);
            //if (UserInfoBll.DeleteUserActionInfo(userId, actionId))
            //{
            //    return Content("ok");
            //}
            //else
            //{
            //    return Content("no");
            //}
            #endregion

            #region 教程的方法
            var userId = int.Parse(Request["userId"]);
            var actionId = int.Parse(Request["actionId"]);
            var r_userInfo_actionInfo = R_UserInfo_ActionInfoBll.LoadEntities(r => r.UserInfoID == userId && r.ActionInfoID == actionId).FirstOrDefault();
            
            if (r_userInfo_actionInfo!=null)
            {
                result = R_UserInfo_ActionInfoBll.DeleteEntity(r_userInfo_actionInfo) ? "ok" : "no";
            }
            else
            {
                result = "no";
            }
            #endregion

            return Content(result);
        }
    }
}