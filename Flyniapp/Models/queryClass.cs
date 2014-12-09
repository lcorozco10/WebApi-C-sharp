using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Flyniapp.Models;

namespace Flyniapp.Models
{
    public class queryClass
    {
        /// <summary>
        ///Instancia DataContext que contiene el objeto las tablas de las Base de Datos FLYNIDB 
        /// </summary>
        private FLYNIDBEntities context = new FLYNIDBEntities();

        /// <summary>
        /// Este metodo obtiene la lista de los Vuelos
        /// </summary>
        /// <param name="id_flight_type">
        ///     Este parametro especifica el tipo de vuelo que devuelve.
        ///     El tipo de valor puede ser tipo de vuelo(el valor puede ser:
        ///     1(Salida Nacional), 2(Llegada Nacional), 3(Salida Internacional), 4(Llegada Internacional)
        /// </param> 
        /// <param name="dateServer">Fecha y hora del Servidor</param>
        /// <returns></returns>
        public IEnumerable<FlightDTO> getAllFlight(int id_flight_type, DateTime dateServer)
        {
            try
            {


                var q = context.Flight.Where(
                        fl =>
                            id_flight_type == fl.id_flight_type &&
                            dateServer.Year == fl.fecha_reg.Year &&
                            dateServer.Month == fl.fecha_reg.Month &&
                            dateServer.Day == fl.fecha_reg.Day
                        ).
                        Select(model => new FlightDTO
                        {
                            id = model.id_reg,
                            Registro = model.fecha_reg,
                            category_name = model.Flight_type.Flight_category.category_name,
                            type_name = model.Flight_type.type_name,
                            airline_name = model.Airline.airline_name,
                            flight_number = model.flight_number,
                            city_name = model.City.city_name,
                            time = model.time_dep_arri,
                            status_name = model.Status.status_name

                        });

                return q;
            }
            catch (Exception ex)
            {
                throw new System.ArgumentException("Exception Error: " + ex.Message);
            }
        
        }


        /// <summary>
        /// Este metodo obtiene la lista de los Vuelos segun una lista de ID de los vuelos pasados por parametros
        /// </summary>
        /// <param name="id_reg">ID de Vuelo</param>
        /// <returns></returns>
        public IEnumerable<FlightDTO> getFlightList(List<int> id_reg)
        {
            try
            {


                var q = context.Flight.Where(fl => id_reg.Contains(fl.id_reg)).Select(model => new FlightDTO
                {
                    id = model.id_reg,
                    Registro = model.fecha_reg,
                    category_name = model.Flight_type.Flight_category.category_name,
                    type_name = model.Flight_type.type_name,
                    airline_name = model.Airline.airline_name,
                    flight_number = model.flight_number,
                    city_name = model.City.city_name,
                    time = model.time_dep_arri,
                    status_name = model.Status.status_name

                });

                return q;
            }
            catch (Exception ex)
            {
                throw new System.ArgumentException("Exception Error: " + ex.Message);
            }

        }


        /// <summary>
        /// Este metodo busca la informacion de un vuelo mediante el ID del vuelo
        /// </summary>
        /// <param name="id_reg"></param>
        /// <returns></returns>
        public IEnumerable<FlightDTO> getFlight(int id_reg)
        {
            try
            {


                var q = context.Flight.Where(fl => id_reg == fl.id_reg
                ).Select(model => new FlightDTO
                {
                    id = model.id_reg,
                    Registro = model.fecha_reg,
                    category_name = model.Flight_type.Flight_category.category_name,
                    type_name = model.Flight_type.type_name,
                    airline_name = model.Airline.airline_name,
                    flight_number = model.flight_number,
                    city_name = model.City.city_name,
                    time = model.time_dep_arri,
                    status_name = model.Status.status_name

                });

                return q;
            }
            catch (Exception ex)
            {
                throw new System.ArgumentException("Exception Error: " + ex.Message);
            }

        }


        

        /// <summary>
        /// Este metodo obtiene la informacion de las Aerolineas.
        /// </summary>
        /// <returns></returns>
        public IQueryable<AirlineDTO> getAllAirline(){
            try
            {

                FLYNIDBEntities ent = new FLYNIDBEntities();
                var ResultSet = from b in ent.Airline
                                select new AirlineDTO()
                                {
                                    id_airline = b.id_airline,
                                    airline_name = b.airline_name,
                                    address = b.address,
                                    description = b.description,
                                    office_phone = b.office_phone,
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