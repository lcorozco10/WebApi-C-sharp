using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Flyniapp.Models;
using System.Collections;


namespace Flyniapp.Controllers
{
    /// <summary>
    /// Api que contiene el recurso de las listas de vuelos.
    /// </summary>
    public class getFlightListController : ApiController
    {

        private FLYNIDBEntities context = new FLYNIDBEntities();
        /// <summary>
        /// Este metodo obtiene la lista de los Vuelos mediante una lista de ID
        /// url: api/getFlightList
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<FlightDTO> Post([FromBody] List<int> id)
        {
            try
            {


                var q = context.Flight.Where(fl => id.Contains(fl.id_reg)).Select(model => new FlightDTO
                {
                    id  = model.id_reg,
                    Registro = model.fecha_reg,
                    category_name = model.Flight_type.Flight_category.category_name,
                    type_name = model.Flight_type.type_name,
                    airline_name = model.Airline.airline_name,
                    flight_number = model.flight_number,
                    city_name  = model.City.city_name,
                    time = model.time_dep_arri,
                    status_name = model.Status.status_name
                
                });
            
                return q;
            }
            catch (Exception ex)
            {
                throw new System.ArgumentException("Exception Error: "+ex.Message);
            }
           
        }
    }

   

}
