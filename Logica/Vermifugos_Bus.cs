using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;

namespace Logica
{
   public class Vermifugos_Bus
    {
        public static int ID_Animal { get; set; }
        public static string Vermifugo { get; set; }
        public static string Resultados { get; set; }
        public static DateTime Fecha { get; set; }


        Vermifugos_DAL vermifugos = new Vermifugos_DAL();

        public bool Guardar()
        {
            bool isComplete = false;

            try
            {
                Vermifugos_DAL.ID_Animal = ID_Animal;
                Vermifugos_DAL.Vermifugo = Vermifugo;
                Vermifugos_DAL.Resultados = Resultados;

                vermifugos.Guardar();
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
                Vermifugos_DAL.ID_Animal = ID_Animal;
                Vermifugos_DAL.Vermifugo = Vermifugo;
                Vermifugos_DAL.Resultados = Resultados;

                vermifugos.Modificar(ID);
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
                vermifugos.Borrar(ID);
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
        public List<Vermifugo> BuscarUltimosVermifugos()
        {
            var selec = vermifugos.BuscarUltimosVermifugos();
            return selec;
        }

        /// <summary>
        /// Buscar por Nombre.
        /// </summary>
        /// <param name="nombre">nombre del animal.</param>
        /// <returns>List</returns>
        public List<Vermifugo> BuscarxNombre(string nombre)
        {
            var busc = vermifugos.BuscarxNombre(nombre);
            return busc;
        }

        /// <summary>
        /// Buscar por Cedula.
        /// </summary>
        /// <param name="nombre">Cedula del dueño del animal.</param>
        /// <returns>List</returns>
        public List<Vermifugo> BuscarxNombreAnimal(string nombre)
        {
            var busc = vermifugos.BuscarxNombreAnimal(nombre);
            return busc;
        }


    }
}
