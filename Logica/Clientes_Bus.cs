using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Datos;



namespace Logica
{
    public class Clientes_Bus
    {

        public static string Cedula { get; set; }
        public static string Nombre { get; set; }
        public static string Telefono { get; set; }
        public static string Celular { get; set; }
        public static string Direccion { get; set; }
      
        Clientes_DAL clientesD = new Clientes_DAL();

        public bool Guardar()
        {
            bool isComplete = false;
            
            try
            {
                Clientes_DAL.Cedula = Clientes_Bus.Cedula;
                Clientes_DAL.Nombre = Clientes_Bus.Nombre;
                Clientes_DAL.Telefono = Clientes_Bus.Telefono;
                Clientes_DAL.Celular = Clientes_Bus.Celular;
                Clientes_DAL.Direccion = Clientes_Bus.Direccion;
                clientesD.Guardar();
                isComplete = true;
            }
            catch (Exception)
            {
                
                throw;
            }

            return isComplete;
        }

        public bool Modificar(string cedula)
        {       
            bool isComplete = false;
            
            try
            {
                Clientes_DAL.Cedula = Clientes_Bus.Cedula;
                Clientes_DAL.Nombre = Clientes_Bus.Nombre;
                Clientes_DAL.Telefono = Clientes_Bus.Telefono;
                Clientes_DAL.Celular = Clientes_Bus.Celular;
                Clientes_DAL.Direccion = Clientes_Bus.Direccion;
                clientesD.Modificar(cedula);
                isComplete = true;
            }
            catch (Exception)
            {

                throw;
            }

            return isComplete;
        }

        public bool Borrar(string cedula)
        {
            bool isComplete = false;

            try
            {
                clientesD.Borrar(cedula);
                isComplete = true;
            }
            catch (Exception)
            {

                throw;
            }

            return isComplete;
        }


        /// <summary>
        /// Lista los ultimos 15 clientes.
        /// </summary>
        /// <returns>List select</returns>
        public List<Cliente> BuscarUltimosClientes()
        {
            var selec = clientesD.BuscarUltimosClientes();
            return selec;
        }

        /// <summary>
        /// Buscar por Nombre.
        /// </summary>
        /// <param name="nombre">nombre del cliente.</param>
        /// <returns>List</returns>
        public List<Cliente> BuscarxNombre(string nombre)
        {
            var busc = clientesD.BuscarxNombre(nombre); 
            return busc;
        }

        /// <summary>
        /// Buscar por Cedula.
        /// </summary>
        /// <param name="nombre">Cedula del cliente.</param>
        /// <returns>List</returns>
        public List<Cliente> BuscarxCedula(string cedula)
        {
            return clientesD.BuscarxCedula(cedula);
        }

        public Dictionary<string, string> BuscarxCedulaKey(string cedula)
        {
            return clientesD.BuscarxCedulaKey(cedula);
        }

    }
}
