using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;

namespace Logica
{
  public  class Productos_Bus
    {

        public static string Producto { get; set; }
        public static decimal Precio { get; set; }
        public static int Cantidad { get; set; }
        public static string Estatus { get; set; }


        Productos_DAL productoD = new Productos_DAL();

        public bool Guardar()
        {
            bool isComplete = false;

            try
            {
                Productos_DAL.Producto = Producto;
                Productos_DAL.Precio = Precio;
                Productos_DAL.Cantidad = Cantidad;
                Productos_DAL.Estatus = Estatus;

                productoD.Guardar();
                isComplete = true;
            }
            catch (Exception)
            {
                throw;
            }

            return isComplete;
        }

        public bool Modificar(int id)
        {
            bool isComplete = false;

            try
            {
                Productos_DAL.Producto = Producto;
                Productos_DAL.Precio = Precio;
                Productos_DAL.Cantidad = Cantidad;
                Productos_DAL.Estatus = Estatus;

                productoD.Modificar(id);
                isComplete = true;
            }
            catch (Exception)
            {

                throw;
            }

            return isComplete;
        }

        public bool Borrar(int id)
        {
            bool isComplete = false;

            try
            {
                productoD.Borrar(id);
                isComplete = true;
            }
            catch (Exception)
            {

                throw;
            }

            return isComplete;
        }


        /// <summary>
        /// Lista los ultimos 15 Productos.
        /// </summary>
        /// <returns>List select</returns>
        public List<Concepto> BuscarUltimosProductos()
        {
            var selec = productoD.BuscarUltimosProductos();
            return selec;
        }

        /// <summary>
        /// Buscar por Nombre.
        /// </summary>
        /// <param name="nombre">nombre del producto.</param>
        /// <returns>List</returns>
        public List<Concepto> BuscarxNombre(string nombre)
        {
            var busc = productoD.BuscarxNombre(nombre);
            return busc;
        }

        /// <summary>
        /// Buscar por ID.
        /// </summary>
        /// <param name="nombre">ID del Producto.</param>
        /// <returns>List</returns>
        public List<Concepto> BuscarxID(int id)
        {
            var busc = productoD.BuscarxID(id);
            return busc;
        }

    }
}
