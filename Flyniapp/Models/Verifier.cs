using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Flyniapp.Models;

namespace Flyniapp.Models
{
    public class Verifier
    {
        private FLYNIDBEntities context = new FLYNIDBEntities();
        
        /// <summary>
        /// Este metodo devuelve la concurrencia de columnas que coinciden con la fecha actual.
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public int verifierDateDd(DateTime date)
        {


            int datecount = (from acc in context.Flight
                             where acc.fecha_reg.Year == date.Year &&
                             acc.fecha_reg.Month == date.Month &&
                             acc.fecha_reg.Day == date.Day
                             select acc).Count();            
            
            return datecount;
        }

        /// <summary>
        /// Este metodo devuelve la concurrencia de columnas que coinciden con la hora actual.
        /// </summary>
        /// <param name="hour"></param>
        /// <returns></returns>
        public int verifierTimeDd(int hour)
        {

                    

            int hourcount = (from acc in context.Flight
                             where acc.fecha_reg.Hour == hour
                             select acc).Count();
            return hourcount;
        }
    }
}