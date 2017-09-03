﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using ItcastCater.Model;

namespace ItcastCater.DAL
{
    public class OrderInfoDAL
    {
        /// <summary>
        /// 通过餐桌id获得OrderInfo的id
        /// </summary>
        /// <param name="deskId"></param>
        /// <returns>OrderId</returns>
        public object GetOrderIdByDeskId(int deskId)
        {
            //string sql = "select OrderInfo.OrderId from R_Order_Desk inner join OrderInfo on R_Order_Desk.OrderId=OrderInfo.OrderId where OrderInfo.OrderState=1 and DeskId=" + deskId;
            var sql = "select OrderInfo.OrderId from R_Order_Desk inner join OrderInfo on R_Order_Desk.OrderId=OrderInfo.OrderId where OrderInfo.OrderState=1 and DeskId=" + deskId;
            return SqliteHelper.ExecuteScalar(sql);
        }

        /// <summary>
        /// 添加一个新订单
        /// </summary>
        public object AddOrderInfo(OrderInfo order)
        {
            var sql = "insert into OrderInfo(SubTime, Remark, OrderState, DelFlag, SubBy) values(@SubTime, @Remark, @OrderState, @DelFlag, @SubBy);select last_insert_rowid();";
            var ps = new SQLiteParameter[] {
                new SQLiteParameter("@SubTime",order.SubTime),
                new SQLiteParameter("@Remark",order.Remark),
                new SQLiteParameter("@OrderState",order.OrderState),
                new SQLiteParameter("@DelFlag",order.DelFlag),
                new SQLiteParameter("@SubBy",order.SubBy)
            };

            return SqliteHelper.ExecuteScalar(sql, ps);
        }
    }
}
