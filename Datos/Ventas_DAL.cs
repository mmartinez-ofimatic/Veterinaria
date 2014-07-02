using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;

namespace Datos
{
    public class Ventas_DAL
    {

        /// <summary>
        /// Hacer Vista de las ventas con los clientes y el detalle
        /// </summary>
        /// 
            public int idventa { get; set; }
            public string cedula { get; set; }
            public int iDproducto { get; set; }
            public int idusuario { get; set; }
            public decimal precio { get; set; }
            public int cantidad { get; set; }
            public decimal descuento { get; set; }
            public string observacion { get; set; }
            public DateTime fecha { get; set; }

            veterinariaDBEntities dbEntities = new veterinariaDBEntities();

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
                    Venta_Factura ventas = new Venta_Factura();
                    ventas.Cedula = cedula;
                    //falata el id de usuario
                    ventas.ID_Usuario = null;
                    ventas.Observacion = observacion;
                    ventas.Fecha_Venta = DateTime.Now;

                    db.AddToVenta_Factura(ventas);
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
            /// Lista de las Ultimas Ventas vwVentas.
            /// </summary>
            /// <returns>List</returns>
            public List<vwVenta> BuscarUltimasVentasVista()
            {
                var selec = (from s in dbEntities.vwVentas
                             select s).Take(15).OrderByDescending(x => x.ID_Factura).ToList();
                return selec;
            }

            /// <summary>
            /// Busqueda por ID Vista ventas.
            /// </summary>
            /// <returns>List</returns>
            public List<vwVenta> BuscarxIDVista(int idvent)
            {

                List<vwVenta> busc = (from b in dbEntities.vwVentas
                                      where b.ID_Factura == idvent
                                      select b).ToList();

                return busc;
            }

            /// <summary>
            /// Buscar por nombre Vista.
            /// </summary>
            /// <param name="nombre">nombre del cliente.</param>
            /// <returns>List</returns>
            public List<vwVenta> BuscarxNombreClienteVista(string nombre)
            {

                List<vwVenta> busc = (from b in dbEntities.vwVentas
                                      where b.Nombre.Contains(nombre)
                                      select b).OrderByDescending(x => x.ID_Factura).ToList();

                return busc;


            }


            /// <summary>
            /// Lista de Detalles de Ventas.
            /// </summary>
            /// <returns>List</returns>
            public List<vwVentasDetalle> BuscarDetallesVentas(int id)
            {
                veterinariaDBEntities dbent = new veterinariaDBEntities();

                var selec = (from s in dbent.vwVentasDetalles
                             where s.ID_Detalle == id
                             select s).ToList();

                return selec;
            }

            /// <summary>
            /// Lista de las Ultimas Ventas.
            /// </summary>
            /// <returns>List</returns>
            public List<vwVentasDetalle> BuscarUltimasVentas()
            {
                var selec = (from s in dbEntities.vwVentasDetalles
                             select s).Take(15).OrderByDescending(x => x.ID_Factura).ToList();
                return selec;
            }

            /// <summary>
            /// Busqueda por ID.
            /// </summary>
            /// <returns>List</returns>
            public List<vwVentasDetalle> BuscarxID(int idvent)
            {

                List<vwVentasDetalle> busc = (from b in dbEntities.vwVentasDetalles
                                        where b.ID_Factura == idvent
                                        select b).ToList();

                return busc;
            }

            /// <summary>
            /// Buscar por nombre.
            /// </summary>
            /// <param name="nombre">nombre del cliente.</param>
            /// <returns>List</returns>
            public List<vwVentasDetalle> BuscarxNombreCliente(string nombre)
            {

                List<vwVentasDetalle> busc = (from b in dbEntities.vwVentasDetalles
                                        where b.Nombre.Contains(nombre)
                                        select b).OrderByDescending(x => x.ID_Factura).ToList();

                return busc;


            }

            /// <summary>
            /// Buscar por nombre del producto.
            /// </summary>
            /// <param name="nombre">nombre del producto.</param>
            /// <returns>List</returns>
            public List<vwVentasDetalle> BuscarxNombreProducto(string nom)
            {

                List<vwVentasDetalle> busc = (from b in dbEntities.vwVentasDetalles
                                        where b.Producto.Contains(nom)
                                        select b).OrderByDescending(x => x.ID_Factura).ToList();

                return busc;
            }




            List<AgregarVentas> agregarVentasList = new List<AgregarVentas>();
            /// <summary>
            /// Agregar Productos a la venta.
            /// </summary>
            /// <returns>List select</returns>
            public List<AgregarVentas> AgregarProductos(int clientes, int productos, decimal precio, int cantidad, int desc, string obs)
            {
                // Tipo anonimo 

                // agregarVentasList.Add(new AgregarVentas{ Producto = productos, Precio = precio, Cantidad = cantidad, Descuento = desc });

                // selec.
                return agregarVentasList;
            }
}

        public class AgregarVentas
        {
            public Dictionary<int, string> Producto { get; set; }
            public decimal Precio { get; set; }
            public int Cantidad { get; set; }
            public double Descuento { get; set; }
            public decimal PrecioNeto { get; set; }

            List<AgregarVentas> Lista = new List<AgregarVentas>();

            public List<AgregarVentas> addList(Dictionary<int, string> fproducto, decimal fprecio, int fcantidad, double fdescuento)
            {
                decimal fprecioBruto = fprecio * fcantidad;
                double fdescuentoNeto = (double)fprecioBruto * (fdescuento / 100.00);

                Lista.Add(new AgregarVentas
                {
                    Producto = fproducto,
                    Precio = fprecio,
                    Cantidad = fcantidad,
                    Descuento = fdescuento,
                    PrecioNeto = fprecioBruto - (decimal)fdescuentoNeto
                });

                return Lista;
            }

            public TransationsVentas transVenta = new TransationsVentas();

            public void listaGuardar(List<AgregarVentas> lista)
            {

                var filtro = (from c in lista
                              select new
                              {
                                  IDProducto = c.Producto.Select(x => x.Key).Single(),
                                  Producto = c.Producto.Select(x => x.Value).Single(),
                                  c.Precio,
                                  c.Cantidad,
                                  c.Descuento,
                                  c.PrecioNeto
                              }).ToList();

                foreach (var item in filtro)
                {
                    transVenta.idproducto = item.IDProducto.ToString();
                    transVenta.precio = item.Precio;
                    transVenta.cantidad = item.Cantidad;
                    transVenta.descuento = Convert.ToDecimal(item.Descuento);

                    //transVenta.transationsVentas();
                }
            }

            public List<AgregarVentas> RemoveList(int index)
            {

                try
                {
                    Lista.RemoveAt(index);

                }
                catch (Exception)
                {
                    throw;
                }

                return Lista;
            }

            public List<AgregarVentas> UpdateList(Dictionary<int, string> idproducto, string id, decimal fprecio, int fcantidad, double fdescuento)
            {

                var buscar = from b in Lista
                             where b.Producto.Keys.Equals(idproducto)//idproducto.Select(y => y.Key).Single()
                             select b;
                //var buscar = from b in Lista
                //             where b.Producto.Select(x => x.Key).Single() == idproducto.Select(y=> y.Key).Single()
                //             select b;

                decimal fprecioBruto = fprecio * fcantidad;
                double fdescuentoNeto = (double)fprecioBruto * (fdescuento / 100.00);

                foreach (var l in buscar)
                {
                    //l.Producto = idproducto;
                    l.Precio = fprecio;
                    l.Cantidad = fcantidad;
                    l.Descuento = fdescuento;
                    l.PrecioNeto = fprecioBruto - (decimal)fdescuentoNeto;
                }

                return Lista;

            }

            public bool ExistProductList(int idproducto)
            {
                Lista.Exists(x => x.Producto.Keys.Equals(idproducto));
                return Lista.Exists(x => x.Producto.Keys.Equals(idproducto));
            }

            public void EraserList()
            {
                Lista.Clear();

                if (Producto != null)
                {
                    Producto.Clear();
                }

            }

        }
}
    

