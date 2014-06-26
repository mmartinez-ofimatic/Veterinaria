using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;

namespace Logica
{
   public class Vacunas_Bus
    {
        public static int ID_Animal { get; set; }
        public static string Nombre_Vacuna { get; set; }
        public static string Veterinario { get; set; }


        Vacunas_DAL vacuna = new Vacunas_DAL();

        public bool Guardar()
        {
            bool isComplete = false;

            try
            {
                Vacunas_DAL.ID_Animal = ID_Animal;
                Vacunas_DAL.Nombre_Vacuna = Nombre_Vacuna;
                Vacunas_DAL.Veterinario = Veterinario;

                vacuna.Guardar();
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
                Vacunas_DAL.ID_Animal = ID_Animal;
                Vacunas_DAL.Nombre_Vacuna = Nombre_Vacuna;
                Vacunas_DAL.Veterinario = Veterinario;

                vacuna.Modificar(ID);
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
                vacuna.Borrar(ID);
                isComplete = true;
            }
            catch (Exception)
            {

                throw;
            }

            return isComplete;
        }

        /// <summary>
        ///  Lista las ultimas 15 vacunas.
        /// </summary>
        /// <returns>List select</returns>
        public List<vacunaJoin> BuscarUltimasVacunas()
        {
            var selec = vacuna.BuscarUltimasVacunas();
            return selec;
        }

        /// <summary>
        /// Buscar por vacuna.
        /// </summary>
        /// <param name="nombre">Nombre de la vacuna.</param>
        /// <returns>List</returns>
        public List<vacunaJoin> BuscarxNombre(string nombre)
        {
            var busc = vacuna.BuscarxNombre(nombre);
            return busc;
        }

        /// <summary>
        /// Buscar por ID del Animal.
        /// </summary>
        /// <param name="nombre">ID del Animal.</param>
        /// <returns>List</returns>
        public List<vacunaJoin> BuscarxNombreAnimal(string nombre)
        {
            var busc = vacuna.BuscarxNombreAnimal(nombre);
            return busc;
        }

    }
}
