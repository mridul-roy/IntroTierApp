//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zero_Hunger.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SignUp
    {
        public SignUp()
        {
            this.Admins = new HashSet<Admin>();
            this.Employees = new HashSet<Employee>();
            this.Restaurants = new HashSet<Restaurant>();
        }
    
        public int id { get; set; }
        public string usertype { get; set; }
        public string username { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string phone_No { get; set; }
    
        public virtual ICollection<Admin> Admins { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Restaurant> Restaurants { get; set; }
    }
}
