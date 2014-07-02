using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;

namespace Datos
{
   public class ventaDetalles
    {
       veterinariaDBEntities dbEntities = new veterinariaDBEntities();

        public int idventa { get; set; }
        public int idproducto { get; set; }
        public decimal precio { get; set; }
        public int cantidad { get; set; }
        public int descuento { get; set; }

        /// <summary>
        /// Guarda una venta.
        /// </summary>
        /// <returns>bool isComplete</returns>
        public bool Guardar()
        {
            bool isComplete = false;
            try
            {
                veterinariaDBEntities db = new veterinariaDBEntities();
                Venta_Detalle ventasDetalle = new Venta_Detalle();
                ventasDetalle.ID_Factura = idventa;
                ventasDetalle.ID_Producto = idproducto;
                ventasDetalle.Precio = precio;
                ventasDetalle.Cantidad = cantidad;
                ventasDetalle.Descuento = descuento;

                db.AddToVenta_Detalle(ventasDetalle);
                db.SaveChanges(SaveOptions.DetectChangesBeforeSave);
                isComplete = true;
            }
            catch (Exception)
            {
                throw;
            }

            return isComplete;
        }

        /// <summary>
        /// Lista de todas las ventas.
        /// </summary>
        /// <returns>List select</returns>
        public List<Venta_Detalle> BuscarTodos()
        {
            var selec = (from s in dbEntities.Venta_Detalle
                         select s).ToList();
            return selec;
        }

        /// <summary>
        /// Busqueda por ID.
        /// </summary>
        /// <returns>List</returns>
        public List<Venta_Detalle> BuscarxIDVenta(int id)
        {

            List<Venta_Detalle> busc = (from b in dbEntities.Venta_Detalle
                                       where b.ID_Factura == id
                                       select b).ToList();
            if (busc != null)
            {
                if (busc.Count != 0)
                {
                    foreach (var item in busc)
                    {
                        idventa = Convert.ToInt32(item.ID_Factura);

                        idproducto = Convert.ToInt32(item.ID_Producto);
                        precio = Convert.ToDecimal(item.Precio);
                        cantidad = Convert.ToInt32(item.Cantidad);
                        descuento = Convert.ToInt32(item.Descuento);

                    }
                }
            }

            return busc;
        }

        /// <summary>
        /// Buscar por ID del Detalle.
        /// </summary>
        /// <param name="nombre">ID del Detalle.</param>
        /// <returns>List</returns>
        public List<Venta_Detalle> BuscarxIDDetalle(int id)
        {
            List<Venta_Detalle> busc = (from b in dbEntities.Venta_Detalle
                                       where b.ID_Detalle == id
                                       select b).ToList();
            if (busc != null)
            {
                foreach (var item in busc)
                {
                    idventa = Convert.ToInt32(item.ID_Factura);
                    idproducto =  Convert.ToInt32( item.ID_Producto);
                    precio = Convert.ToDecimal(item.Precio);
                    cantidad = Convert.ToInt32(item.Cantidad);
                    descuento = Convert.ToInt32(item.Descuento);
                }
            }
            return busc;
        }
    }
}
