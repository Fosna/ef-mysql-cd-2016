//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EfFirstContact
{
    using System;
    using System.Collections.Generic;
    
    public partial class todoitem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public System.DateTime TimeCreated { get; set; }
        public Nullable<System.DateTime> TimeSetToDone { get; set; }
        public Nullable<System.DateTime> TimeDeactivated { get; set; }
    }
}
