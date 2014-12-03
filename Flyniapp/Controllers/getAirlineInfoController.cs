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
        /// Este metodo obtiene la informacion de las Aerolineas.
        /// url: api/getAirlineInfo
        /// </summary>
        /// <returns></returns>
        public IQueryable<AirlineDTO> getAllFlight()
        {
            try
            {
                
                FLYNIDBEntities ent = new FLYNIDBEntities();
                var ResultSet = from b in ent.Airline
                            select new AirlineDTO()
                            {
                                id_airline = b.id_airline,
                                airline_name =b.airline_name,
                                address = b.address,
                                description = b.description,
                                office_phone =b.office_phone,
                                office_fax = b.office_fax,
                                reservation_phone = b.reservation_phone,
                                reservation_fax = b.reservation_fax,
                                hours_care = b.hours_care,
                                airline_url = b.airline_url,
                                image_url = b.image_url
                            };

                return ResultSet;
            }
            catch (Exception ex)
            {
                throw new System.ArgumentException("Exception Error: " + ex.Message);
            }

        }
    }
}
