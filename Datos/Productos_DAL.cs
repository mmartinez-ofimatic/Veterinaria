using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos
{
  public  class Productos_DAL
    {


        veterinariaDBEntities dbEntities = new veterinariaDBEntities();


        public static string Producto { get; set; }
        public static decimal Precio { get; set; }
        public static int Cantidad { get; set; }
        public static string Estatus { get; set; } 


        /// <summary>
        /// Guarda un producto en la base de datos.
        /// </summary>
        public bool Guardar()
        {
            bool isComplete = false;
            try
            {
                veterinariaDBEntities db = new veterinariaDBEntities();

                Concepto productos = new Concepto();
                productos.Producto = Producto;
                productos.Precio = Precio;
                productos.Cantidad_Existente = Cantidad;
                productos.Estatus = Estatus;
                productos.Fecha = DateTime.Now;

                db.Conceptos.AddObject(productos);
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
        /// Modifica un producto.
        /// </summary>
        public bool Modificar(int id)
        {
            bool isComplete = false;
            try
            {
                Concepto update = (from upd in dbEntities.Conceptos
                                   where upd.ID_Producto == id
                                  select upd).First();

                update.Producto = Producto;
                update.Precio = Precio;
                update.Cantidad_Existente = Cantidad;
                update.Estatus = Estatus;

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
        /// Borra un cliente.
        /// </summary>
        /// <returns>bool isComplete</returns>
        public bool Borrar(int id)
        {
            bool isComplete = false;

            try
            {
                Concepto borrar = (from bor in dbEntities.Conceptos
                                   where bor.ID_Producto == id
                                  select bor).FirstOrDefault();

                dbEntities.Conceptos.DeleteObject(borrar);
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
        /// Lista los ultimos 15 productos.
        /// </summary>
        /// <returns>List select</returns>
        public List<Concepto> BuscarUltimosProductos()
        {
            var selec = (from s in dbEntities.Conceptos
                         select s).Take(15).OrderByDescending(x => x.ID_Producto).ToList();
            return selec;
        }


        /// <summary>
        /// Buscar por Nombre.
        /// </summary>
        /// <param name="nombre">Nombre del producto.</param>
        /// <returns>List</returns>
        public List<Concepto> BuscarxNombre(string nombre)
        {

            List<Concepto> busc = (from b in dbEntities.Conceptos
                                  where b.Producto.Contains(nombre)
                                  select b).OrderByDescending(x => x.ID_Producto).ToList();

            if (busc != null)
            {
                foreach (var item in busc)
                {
                   Producto = item.Producto;
                    Precio = Convert.ToDecimal(item.Precio);
                    Cantidad = Convert.ToInt32 (item.Cantidad_Existente);
                    Estatus = item.Estatus;
                }
            }
            return busc;
        }

        /// <summary>
        /// Buscar por ID.
        /// </summary>
        /// <param name="nombre">ID del Producto.</param>
        /// <returns>List</returns>
        public List<Concepto> BuscarxID(int id)
        {
            List<Concepto> busc = (from b in dbEntities.Conceptos
                                  where b.ID_Producto==id
                                  select b).OrderByDescending(x => x.ID_Producto).ToList();
            if (busc != null)
            {
                foreach (var item in busc)
                {
                    Producto = item.Producto;
                    Precio = Convert.ToDecimal(item.Precio);
                    Cantidad = Convert.ToInt32(item.Cantidad_Existente);
                    Estatus = item.Estatus;
                }
            }
            return busc;
        }

    }
}
