//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Flyniapp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Flight_type
    {
        public Flight_type()
        {
            this.Flight = new HashSet<Flight>();
        }
    
        public int id_flight_type { get; set; }
        public int id_category_flight { get; set; }
        public string type_name { get; set; }
    
        public virtual ICollection<Flight> Flight { get; set; }
        public virtual Flight_category Flight_category { get; set; }
    }
}