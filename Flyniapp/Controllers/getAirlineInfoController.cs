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
    /// Api que contiene el recurso de las listas Aerolineas.
    /// </summary>
    public class getAirlineInfoController : ApiController
    {
        /// <summary>
        /// Controlador que la informacion de las Aerolineas.
        /// url: api/getAirlineInfo
        /// </summary>
        /// <returns></returns>
        public IQueryable<AirlineDTO> getAllAirline()
        {
            queryClass q = new queryClass();
            return q.getAllAirline();

        }
    }
}
