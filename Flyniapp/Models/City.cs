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
    
    public partial class City
    {
        public City()
        {
            this.Flight = new HashSet<Flight>();
        }
    
        public int id_city { get; set; }
        public string city_name { get; set; }
    
        public virtual ICollection<Flight> Flight { get; set; }
    }
}
