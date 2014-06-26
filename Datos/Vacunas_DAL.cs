using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos
{
   public class Vacunas_DAL
    {
        /*
         [ID_Vacuna]
       ,[ID_Animal]
       ,[Nombre_Vacuna]
       ,[Veterinario]
       ,[Fecha_Vacuna]
         */

       public static int ID_Animal { get; set; }
       public static string Nombre_Vacuna { get; set; }
       public static string Veterinario { get; set; }

       veterinariaDBEntities dbEntities = new veterinariaDBEntities();

        /// <summary>
        /// Guarda una vacuna en la base de datos.
        /// </summary>
        public bool Guardar()
        {
            bool isComplete = false;
            try
            {
                veterinariaDBEntities db = new veterinariaDBEntities();

                Vacuna vacuna = new Vacuna();
                vacuna.ID_Animal = ID_Animal;
                vacuna.Nombre_Vacuna = Nombre_Vacuna;
                vacuna.Veterinario = Veterinario;
                vacuna.Fecha_Vacuna = DateTime.Now;

                db.Vacunas.AddObject(vacuna);
                db.SaveChanges();
                isComplete = true;
            }
            catch (Exception)
            {

                throw;
            }

            return isComplete;

        }

        /// <summary>
        /// Modifica una vacuna.
        /// </summary>
        public bool Modificar(int ID)
        {
            bool isComplete = false;
            try
            {
                Vacuna update = (from upd in dbEntities.Vacunas
                                  where upd.ID_Vacuna == ID
                                  select upd).First();

                update.ID_Animal = ID_Animal;
                update.Nombre_Vacuna = Nombre_Vacuna;
                update.Veterinario = Veterinario;

                dbEntities.SaveChanges();

                isComplete = true;
            }
            catch (Exception)
            {
                throw;
            }

            return isComplete;
        }

        /// <summary>
        /// Borra una vacuna.
        /// </summary>
        /// <returns>bool isComplete</returns>
        public bool Borrar(int ID)
        {
            bool isComplete = false;

            try
            {
                Vacuna borrar = (from bor in dbEntities.Vacunas
                                  where bor.ID_Vacuna == ID
                                  select bor).FirstOrDefault();

                dbEntities.Vacunas.DeleteObject(borrar);
                dbEntities.SaveChanges();

                isComplete = true;
            }
            catch (Exception)
            {
                throw;
            }

            return isComplete;
        }

        /// <summary>
        /// Lista las ultimas 15 vacunas.
        /// </summary>
        /// <returns>List select</returns>
        public List<vacunaJoin> BuscarUltimasVacunas()
        {
            var selec = (from s in dbEntities.Vacunas
                         join a in dbEntities.Animales
                        on s.ID_Animal equals a.ID_Animal
                         select new vacunaJoin() 
                         { 
                           ID_vacunas = s.ID_Vacuna,
                           ID_Animal =  s.ID_Animal, 
                           Nombre = a.Nombre, 
                           Nombre_Vacuna = s.Nombre_Vacuna,
                           Veterinario = s.Veterinario, 
                           Fecha = s.Fecha_Vacuna
                         }).Take(15).OrderByDescending(x => x.ID_vacunas).ToList();
            return selec;
        }

        /// <summary>
        /// Buscar por vacuna.
        /// </summary>
        /// <param name="nombre">Nombre de la vacuna.</param>
        /// <returns>List</returns>
        public List<vacunaJoin> BuscarxNombre(string nombre)
        {

            List<vacunaJoin> busc = (from s in dbEntities.Vacunas
                                    join a in dbEntities.Animales
                                    on s.ID_Animal equals a.ID_Animal
                                    where s.Nombre_Vacuna.Contains(nombre)
                                    select new vacunaJoin() 
                                     {
                                         ID_vacunas = s.ID_Vacuna,
                                         ID_Animal = s.ID_Animal,
                                         Nombre = a.Nombre,
                                         Nombre_Vacuna = s.Nombre_Vacuna,
                                         Veterinario = s.Veterinario,
                                         Fecha = s.Fecha_Vacuna
                                     }).Take(15).OrderByDescending(x => x.ID_vacunas).ToList();

            if (busc != null)
            {
                foreach (var item in busc)
                {
                    ID_Animal = Convert.ToInt32(item.ID_Animal);
                    Nombre_Vacuna = item.Nombre_Vacuna;
                    Veterinario = item.Veterinario;
                }
            }
            return busc;
        }

        /// <summary>
        /// Buscar por ID del Animal.
        /// </summary>
        /// <param name="nombre">ID Animal.</param>
        /// <returns>List</returns>
        public List<vacunaJoin> BuscarxNombreAnimal(string nombre)
        {
                         var busc = (from s in dbEntities.Vacunas
                                    join a in dbEntities.Animales
                                    on s.ID_Animal equals a.ID_Animal
                                    where a.Nombre.Contains(nombre)
                                    select new vacunaJoin()
                                    {
                                        ID_vacunas = s.ID_Vacuna,
                                        ID_Animal = s.ID_Animal,
                                        Nombre = a.Nombre,
                                        Nombre_Vacuna = s.Nombre_Vacuna,
                                        Veterinario = s.Veterinario,
                                        Fecha = s.Fecha_Vacuna
                                    }).Take(15).OrderByDescending(x => x.ID_vacunas).ToList();

            if (busc != null)
            {
                foreach (var item in busc)
                {
                    ID_Animal = Convert.ToInt32(item.ID_Animal);
                    Nombre_Vacuna = item.Nombre_Vacuna;
                    Veterinario = item.Veterinario;
                }
            }
            return busc;
        }

    }

      public class vacunaJoin 
       {
           public int ID_vacunas { get; set; }  
           public int ID_Animal { get; set; }
           public string Nombre_Vacuna { get; set; }
           public string Veterinario { get; set; }
           public DateTime Fecha { get; set; }
           public string Nombre { get; set; }
       }


       
   
}
