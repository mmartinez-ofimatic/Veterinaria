using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos
{
   public class Animales_DAL
    {
       public static string Cedula { get; set; }
       public static string Nombre { get; set; }
       public static string Raza { get; set; }
       public static string Especie { get; set; }
       public static string Sexo { get; set; }
       public static string Color { get; set; }
       public static DateTime Fecha_Nac { get; set; }

       veterinariaDBEntities dbEntities = new veterinariaDBEntities();

       /// <summary>
       /// Guarda un animal en la base de datos.
       /// </summary>
       public bool Guardar()
       {
           bool isComplete = false;
           try
           {

               veterinariaDBEntities db = new veterinariaDBEntities();

               Animale animale = new Animale();
               animale.Cedula = Cedula;
               animale.Nombre = Nombre;
               animale.Raza = Raza;
               animale.Especie = Especie;
               animale.Sexo = Sexo;
               animale.Color = Color;
               animale.Fecha_Nac = Fecha_Nac;

               db.Animales.AddObject(animale);
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
       /// Modifica un animal.
       /// </summary>
       public bool Modificar(int ID)
       {
           bool isComplete = false;
           try
           {
               Animale update = (from upd in dbEntities.Animales
                                 where upd.ID_Animal == ID
                                 select upd).First();

               update.Cedula = Cedula;
               update.Nombre = Nombre;
               update.Raza = Raza;
               update.Especie = Especie;
               update.Sexo = Sexo;
               update.Color = Color;
               update.Fecha_Nac = Fecha_Nac;

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
       /// Borra un animal.
       /// </summary>
       /// <returns>bool isComplete</returns>
       public bool Borrar(int ID)
       {
           bool isComplete = false;

           try
           {
               Animale borrar = (from bor in dbEntities.Animales
                                 where bor.ID_Animal == ID
                                 select bor).FirstOrDefault();

               dbEntities.Animales.DeleteObject(borrar);
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
       /// Lista los ultimos 15 animales.
       /// </summary>
       /// <returns>List select</returns>
       public List<Animale> BuscarUltimosAnimales()
       {
           var selec = (from s in dbEntities.Animales
                        select s).Take(15).OrderByDescending(x => x.ID_Animal).ToList();
           return selec;
       }


       /// <summary>
       /// Buscar por Nombre.
       /// </summary>
       /// <param name="nombre">Nombre del animal.</param>
       /// <returns>List</returns>
       public List<Animale> BuscarxNombre(string nombre)
       {

           List<Animale> busc = (from b in dbEntities.Animales
                                 where b.Nombre.Contains(nombre)
                                 select b).OrderByDescending(x => x.Nombre).ToList();

           if (busc != null)
           {
               foreach (var item in busc)
               {
                   Cedula = item.Cedula;
                   Nombre = item.Nombre;
                   Raza = item.Raza;
                   Especie = item.Especie;
                   Sexo = item.Sexo;
                   Color = item.Color;
                   Fecha_Nac = Convert.ToDateTime(item.Fecha_Nac);    
               }
           }
           return busc;
       }

       /// <summary>
       /// Buscar por Cedula.
       /// </summary>
       /// <param name="nombre">cedula del dueño del animal.</param>
       /// <returns>List</returns>
       public List<Animale> BuscarxCedula(string cedula)
       {
           List<Animale> busc = (from b in dbEntities.Animales
                                 where b.Cedula.Contains(cedula)
                                 select b).OrderByDescending(x => x.Cedula).ToList();
           if (busc != null)
           {
               foreach (var item in busc)
               {
                   Cedula = item.Cedula;
                   Nombre = item.Nombre;
                   Raza = item.Raza;
                   Especie = item.Especie;
                   Sexo = item.Sexo;
                   Color = item.Color;
                   Fecha_Nac = Convert.ToDateTime(item.Fecha_Nac);  
               }
           }
           return busc;
       }

    }
}
