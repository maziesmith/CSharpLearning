//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _07_MvcOA.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class R_UserInfo_ActionInfo
    {
        public int ID { get; set; }
        public int UserInfoID { get; set; }
        public int ActionInfoID { get; set; }
        public bool IsPass { get; set; }
    
        public virtual UserInfo UserInfo { get; set; }
        public virtual ActionInfo ActionInfo { get; set; }
    }
}