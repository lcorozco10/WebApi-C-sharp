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
    
    public partial class Flight
    {
        public int id_reg { get; set; }
        public int id_flight_type { get; set; }
        public int id_airline { get; set; }
        public int flight_number { get; set; }
        public int id_city { get; set; }
        public System.TimeSpan time_dep_arri { get; set; }
        public int id_status { get; set; }
        public System.DateTime fecha_reg { get; set; }
    
        public virtual Airline Airline { get; set; }
        public virtual City City { get; set; }
        public virtual Flight_type Flight_type { get; set; }
        public virtual Status Status { get; set; }
    }
}