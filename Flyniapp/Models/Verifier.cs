using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Flyniapp.Models;

namespace Flyniapp.Models
{
    public class Verifier
    {
        

        /// <summary>
        /// Este metodo devuelve la concurrencia de columnas que coinciden con la fecha actual.
        /// </summary>
        /// <param name="id_flight_type">Identificador de tipo de vuelo(el valor puede ser 1(Salida Nacional), 2(Llegada Nacional), 3(Salida Internacional), 4(Llegada Internacional)</param>
        /// <param name="date">Fecha actual del Servidor</param>
        /// <returns>Cantidad de concurrencia</returns>
        public static DateTime verifierDateDd(int id_flight_type, DateTime date)
        {
            try
            {

                FLYNIDBEntities context = new FLYNIDBEntities();        

                DateTime datedb = (from acc in context.Flight
                                   where acc.fecha_reg.Year == date.Year &&
                                      acc.fecha_reg.Month == date.Month &&
                                      acc.fecha_reg.Day == date.Day &&
                                      acc.id_flight_type == 3
                                  orderby acc.fecha_reg descending
                                  select acc.fecha_reg).FirstOrDefault();
                return datedb;
            }
            catch (Exception ex)
            {
                throw new System.ArgumentException("Exception Error: " + ex.Message);
            }
            
        }
      
    }
}