﻿ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07_MvcOA.Model;

namespace _07_MvcOA.IDAL
{
	
	public partial interface IActionInfoDal :IBaseDal<ActionInfo>
    {
      
    }
	
	public partial interface IBookDal :IBaseDal<Book>
    {
      
    }
	
	public partial interface IDepartmentDal :IBaseDal<Department>
    {
      
    }
	
	public partial interface IKeywordsRankDal :IBaseDal<KeywordsRank>
    {
      
    }
	
	public partial interface IR_UserInfo_ActionInfoDal :IBaseDal<R_UserInfo_ActionInfo>
    {
      
    }
	
	public partial interface IRoleInfoDal :IBaseDal<RoleInfo>
    {
      
    }
	
	public partial interface ISearchDetailsDal :IBaseDal<SearchDetails>
    {
      
    }
	
	public partial interface IUserInfoDal :IBaseDal<UserInfo>
    {
      
    }
	
}