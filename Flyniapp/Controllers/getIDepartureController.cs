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
        private queryClass q = new queryClass();
        /// <summary>
        /// Este metodo obtiene la lista de los Vuelos de salidas Internacionales
        /// url: api/getIDeparture
        /// </summary>
        /// <returns>sp_getAllFlight_Result</returns>
        public IEnumerable<FlightDTO> getAllFlight()
        {
            
            DateTime dateServer = new DateTime(2014,12,3,18,21,33);

            DateTime dateDB = Verifier.verifierDateDd(3,dateServer ); ///Asigna a la variable dateDB la ultima fecha y hora registrada en un vuelo.


            //Si la el año es 0001 el registro quiere decir que no encontro ningua coinsidencia.
            if (dateDB.Year != 0001)
            {
                //Si la hora del servidor es igual a la ultima hora registrada en la base de datos.
                //Realiza lo siguiente..
                if (dateDB.Hour == DateTime.Now.Hour)
                {

                    ///1-enviar resulado

                    
                    return q.getAllFlight(3, dateServer);
                    //var obj = context.sp_getAllFlight(3);
                    //return obj;

                }
                else
                {
                    ///1-ejecutar scraping
                    ///2-actualizar base de datos
                    ///3-enviar resulado

                    
                    return q.getAllFlight(3, dateServer);

                  
                }

            }
            else
            {

                ///1-ejecutar scraping
                //2-insertar en la base de datos
                ///3-enviar resultado
               
                return q.getAllFlight(3, dateServer);

               
            }

        }



        /// <summary>
        /// Este metodo busca la informacion de un vuelo mediante el ID del vuelo
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<FlightDTO> getFlight(int id)
        {
            return q.getFlight(id);

        }

    }
}
