using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.EntityClient;
using System.Transactions;
using System.Data.Objects;


namespace Datos
{
  public  class TransationsVentas
    {


        veterinariaDBEntities dbEntities = new veterinariaDBEntities();
        //VentasInv venta = new VentasInv();
        ventaDetalles ventaDetalle = new ventaDetalles();

        public static int idventa { get; set; }
        public string cedula { get; set; }
        public string idproducto { get; set; }
        public int idusuario { get; set; }
        public decimal precio { get; set; }
        public int cantidad { get; set; }
        public decimal descuento { get; set; }
        public string observacion { get; set; }
        public DateTime fecha { get; set; }

        veterinariaDBEntities db = new veterinariaDBEntities();
        veterinariaDBEntities db1 = new veterinariaDBEntities();
        Productos_DAL almacen = new Productos_DAL();

        public TransactionScope transScope;


        public bool transationsVentas(List<AgregarVentas> listaVenta)
        {
            bool savecommit = false;

            using (transScope = new TransactionScope())
            {

                try
                {
                    //Guardar Venta
                    Venta_Factura ventas = new Venta_Factura();
                    ventas.Cedula = cedula;

                    ventas.ID_Usuario = null;// UsuarioInv.IDusuario;
                    ventas.Observacion = observacion;
                    ventas.Fecha_Venta = DateTime.Now;

                    db.AddToVenta_Factura(ventas);
                    db.SaveChanges(SaveOptions.DetectChangesBeforeSave);

                    var filtro = (from c in listaVenta
                                  select new
                                  {
                                      idProducto = c.Producto.Select(x => x.Key).Single(),
                                      Producto = c.Producto.Select(x => x.Value).Single(),
                                      c.Precio,
                                      c.Cantidad,
                                      c.Descuento,
                                      c.PrecioNeto
                                  }).ToList();

                    //Guardar Venta detalle
                    Venta_Detalle ventasDetalle = new Venta_Detalle();

                    foreach (var item in filtro)
                    {
                        idventa = ventas.ID_Factura;
                        ventasDetalle.ID_Factura = ventas.ID_Factura;
                        ventasDetalle.ID_Producto = Convert.ToInt32(item.idProducto);
                        ventasDetalle.Precio = item.Precio;
                        ventasDetalle.Cantidad = item.Cantidad;
                        ventasDetalle.Descuento = Convert.ToInt32(item.Descuento);
                        ventasDetalle.Total = item.PrecioNeto;

                        //Sacar productos del almacen
                        Concepto update = (from upd in dbEntities.Conceptos
                                          where upd.ID_Producto == item.idProducto
                                          select upd).First();


                        if (update.Estatus == "SI")
                        {
                            update.Cantidad_Existente = update.Cantidad_Existente - item.Cantidad;   
                        }


                        db1.AddToVenta_Detalle(ventasDetalle);
                        db1.SaveChanges(SaveOptions.DetectChangesBeforeSave);
                        dbEntities.SaveChanges();
                    }



                    dbEntities.SaveChanges();

                    idventa = ventas.ID_Factura;

                    transScope.Complete();
                    db.AcceptAllChanges();
                    db1.AcceptAllChanges();
                    dbEntities.AcceptAllChanges();
                    savecommit = true;

                }
                catch (Exception)
                {

                    //rollback
                }

            }

            return savecommit;
        }



    }
}
