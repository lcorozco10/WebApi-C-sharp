using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Flyniapp.Models;

namespace Flyniapp.Controllers
{
    /// <summary>
    /// Api que contiene el recurso de Salidas Nacionales
    /// </summary>
    public class getNDepartureController : ApiController
    {

        private FLYNIDBEntities context = new FLYNIDBEntities();
        /// <summary>
        /// Este metodo obtiene la lista de los Vuelos de Salidas Nacionales
        /// url: api/getNDeparture
        /// </summary>
        /// <returns>sp_getAllFlight_Result</returns>
        public IEnumerable<sp_getAllFlight_Result> getAllFlight()
        {
          
                                              
            var obj = context.sp_getAllFlight(1);

            return obj;

        }

        /// <summary>
        /// Este metodo busca la informacion de un vuelo mediante el ID del vuelo
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<sp_getFlight_Result> getFlight(int id)
        {

                               
            var obj = context.sp_getFlight(id);

            return obj;

        }
    }
}
