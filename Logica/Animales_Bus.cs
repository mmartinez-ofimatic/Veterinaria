using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;

namespace Logica
{
   public class Animales_Bus
    {
        public static string Cedula { get; set; }
        public static string Nombre { get; set; }
        public static string Raza { get; set; }
        public static string Especie { get; set; }
        public static string Sexo { get; set; }
        public static string Color { get; set; }
        public static DateTime Fecha_Nac { get; set; }

        Animales_DAL animales = new Animales_DAL();

        public bool Guardar()
        {
            bool isComplete = false;

            try
            {
                Animales_DAL.Cedula = Cedula;
                Animales_DAL.Nombre = Nombre;
                Animales_DAL.Raza = Raza ;
                Animales_DAL.Especie = Especie;
                Animales_DAL.Sexo = Sexo;
                Animales_DAL.Color = Color;
                Animales_DAL.Fecha_Nac = Fecha_Nac;

                animales.Guardar();
                isComplete = true;
            }
            catch (Exception)
            {

                throw;
            }

            return isComplete;
        }

        public bool Modificar(int ID)
        {
            bool isComplete = false;

            try
            {
                Animales_DAL.Cedula = Cedula;
                Animales_DAL.Nombre = Nombre;
                Animales_DAL.Raza = Raza;
                Animales_DAL.Especie = Especie;
                Animales_DAL.Sexo = Sexo;
                Animales_DAL.Color = Color;
                Animales_DAL.Fecha_Nac = Fecha_Nac;

                animales.Modificar(ID);
                isComplete = true;
            }
            catch (Exception)
            {

                throw;
            }

            return isComplete;
        }

        public bool Borrar(int ID)
        {
            bool isComplete = false;

            try
            {
                animales.Borrar(ID);
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
            var selec = animales.BuscarUltimosAnimales();
            return selec;
        }

        /// <summary>
        /// Buscar por Nombre.
        /// </summary>
        /// <param name="nombre">nombre del animal.</param>
        /// <returns>List</returns>
        public List<Animale> BuscarxNombre(string nombre)
        {
            var busc = animales.BuscarxNombre(nombre);
            return busc;
        }

        /// <summary>
        /// Buscar por Cedula.
        /// </summary>
        /// <param name="nombre">Cedula del dueño del animal.</param>
        /// <returns>List</returns>
        public List<Animale> BuscarxCedula(string cedula)
        {
            var busc = animales.BuscarxCedula(cedula);
            return busc;
        }

    }
}
