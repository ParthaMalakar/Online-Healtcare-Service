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
    
    public partial class User_Table
    {
        public User_Table()
        {
            this.Tokens = new HashSet<Token>();
        }
    
        public int Id { get; set; }
        public string Email { get; set; }
        public string User_Type { get; set; }
        public string Admin_Name { get; set; }
        public string Patient_Name { get; set; }
        public string Doctor_Name { get; set; }
        public string Password { get; set; }
    
        public virtual ICollection<Token> Tokens { get; set; }
    }
}