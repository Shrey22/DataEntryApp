//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataEntryApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_Address
    {
        public int Address_id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public Nullable<int> User_id { get; set; }
    
        public virtual T_User T_User { get; set; }
    }
}