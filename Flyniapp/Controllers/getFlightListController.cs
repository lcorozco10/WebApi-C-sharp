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
        /// Controlador que devuelve una lista de vuelos mediante, segun una lista de ID
        /// url: api/getFlightList
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<FlightDTO> Post([FromBody] List<int> id)
        {
            queryClass q = new queryClass();
            return q.getFlightList(id);
           
        }
    }

   

}
