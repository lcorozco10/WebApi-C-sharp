using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Flyniapp.Models;
using System.Data.Entity;

namespace Flyniapp.Controllers
{
    /// <summary>
    /// Api que contiene el recurso de Salidas Internacionales
    /// </summary>
    public class getIDepartureController : ApiController
    {

        private FLYNIDBEntities context = new FLYNIDBEntities();
        /// <summary>
        /// Este metodo obtiene la lista de los Vuelos de salidas Internacionales
        /// url: api/getIDeparture
        /// </summary>
        /// <returns>sp_getAllFlight_Result</returns>
        public IEnumerable<sp_getAllFlight_Result> getAllFlight()
        {

            Verifier vf = new Verifier();

            int datecount = vf.verifierDateDd(DateTime.Now);

            if (datecount == 0)
            {
                ///1-ejecutar scraping
                ///2-insertar en la base de datos
                ///3-enviar resultado
                var obj = context.sp_getAllFlight(3);
                return obj;
            }
            else
            {
                int hourcount = vf.verifierTimeDd(DateTime.Now.Hour);
                if(hourcount == 0)
                {
                    ///1-ejecutar scraping
                    ///2-actualizar base de datos
                    ///3-enviar resulado
                    var obj = context.sp_getAllFlight(3);
                    return obj;
                }
                else
                {
                    ///1-enviar resulado
                    var obj = context.sp_getAllFlight(3);
                    return obj;
                }

            }

           
           

           

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
