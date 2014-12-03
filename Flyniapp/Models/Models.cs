using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Flyniapp.Models
{
    public class FlightDTO
    {
        public int id { get; set; }
        public System.DateTime Registro { get; set; }
        public string category_name { get; set; }
        public string type_name { get; set; }
        public string airline_name { get; set; }
        public int flight_number { get; set; }
        public string city_name { get; set; }
        public TimeSpan time { get; set; }
        public string status_name { get; set; }

    }

    public class AirlineDTO
    {
        public int id_airline { get; set; }
        public string airline_name { get; set; }
        public string address { get; set; }
        public string description { get; set; }
        public string office_phone { get; set; }
        public string office_fax { get; set; }
        public string reservation_phone { get; set; }
        public string reservation_fax { get; set; }
        public string hours_care { get; set; }
        public string airline_url { get; set; }
        public string image_url { get; set; }
    }
}