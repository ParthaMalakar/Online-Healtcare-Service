//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Token_Admin
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public System.DateTime Token_CreatedAt { get; set; }
        public Nullable<System.DateTime> Token_ExpiredAt { get; set; }
        public int A_Id { get; set; }
    
        public virtual Admin Admin { get; set; }
    }
}
