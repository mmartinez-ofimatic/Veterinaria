using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;

namespace Logica
{
   public class Ventas_Bus
    {
       TransationsVentas transation = new TransationsVentas();
       ventaDetalles venta = new ventaDetalles();
       Ventas_DAL ventas_dal = new Ventas_DAL();

       public int idventa { get; set; }
       public string cedula { get; set; }
       public int iDproducto { get; set; }
       public int idusuario { get; set; }
       public decimal precio { get; set; }
       public int cantidad { get; set; }
       public decimal descuento { get; set; }
       public string observacion { get; set; }
       public DateTime fecha { get; set; }

       public bool transationsVentas(List<AgregarVentaNueva> listaVentaNueva)
       {
           try
           {

               List<AgregarVentas> listaVenta = new List<AgregarVentas>();
               listaVenta.AddRange(listaVentaNueva.Cast<AgregarVentas>());
               idventa = TransationsVentas.idventa;
               return transation.transationsVentas(listaVenta);
           }
           catch (Exception)
           {
               throw;
           }
       }




       /// <summary>
       /// Lista de las Ultimas Ventas vwVentas.
       /// </summary>
       /// <returns>List</returns>
       public List<vwVenta> BuscarUltimasVentasVista()
       {
           return ventas_dal.BuscarUltimasVentasVista();
       }

       /// <summary>
       /// Busqueda por ID Vista ventas.
       /// </summary>
       /// <returns>List</returns>
       public List<vwVenta> BuscarxIDVista(int idvent)
       {
           return ventas_dal.BuscarxIDVista(idvent);
       }

       /// <summary>
       /// Buscar por nombre Vista.
       /// </summary>
       /// <param name="nombre">nombre del cliente.</param>
       /// <returns>List</returns>
       public List<vwVenta> BuscarxNombreClienteVista(string nombre)
       {
           return ventas_dal.BuscarxNombreClienteVista(nombre);
       }


       /// <summary>
       /// Lista de Detalles de Ventas.
       /// </summary>
       /// <returns>List</returns>
       public List<vwVentasDetalle> BuscarDetallesVentas(int id)
       {
           return ventas_dal.BuscarDetallesVentas(id);
       }

       /// <summary>
       /// Lista de las Ultimas Ventas.
       /// </summary>
       /// <returns>List</returns>
       public List<vwVentasDetalle> BuscarUltimasVentas()
       {
           return ventas_dal.BuscarUltimasVentas();
       }

       /// <summary>
       /// Busqueda por ID.
       /// </summary>
       /// <returns>List</returns>
       public List<vwVentasDetalle> BuscarxID(int idvent)
       {
           return ventas_dal.BuscarxID(idvent);
       }

       /// <summary>
       /// Buscar por nombre.
       /// </summary>
       /// <param name="nombre">nombre del cliente.</param>
       /// <returns>List</returns>
       public List<vwVentasDetalle> BuscarxNombreCliente(string nombre)
       {
           return ventas_dal.BuscarxNombreCliente(nombre);
       }

       /// <summary>
       /// Buscar por nombre del producto.
       /// </summary>
       /// <param name="nombre">nombre del producto.</param>
       /// <returns>List</returns>
       public List<vwVentasDetalle> BuscarxNombreProducto(string nom)
       {

           return ventas_dal.BuscarxNombreProducto(nom);
       }



       //Busquedas
       /*
       /// <summary>
       /// Lista de todas las ventas.
       /// </summary>
       /// <returns>List select</returns>
       public List<Venta_Detalle> BuscarTodos()
       {        
           return venta.BuscarTodos();
       }

       /// <summary>
       /// Busqueda por ID.
       /// </summary>
       /// <returns>List</returns>
       public List<Venta_Detalle> BuscarxIDVenta(int id)
       {
           return venta.BuscarxIDVenta(id);
       }

       /// <summary>
       /// Buscar por ID del Detalle.
       /// </summary>
       /// <param name="nombre">ID del Detalle.</param>
       /// <returns>List</returns>
       public List<Venta_Detalle> BuscarxIDDetalle(int id)
       {
          return venta.BuscarxIDDetalle(id);
*/
    }


       

   public class AgregarVentaNueva
   {
       AgregarVentas addventas = new AgregarVentas();
       public TransationsVentas transVenta = new TransationsVentas();

       public Dictionary<int, string> Producto { get; set; }
       public decimal Precio { get; set; }
       public int Cantidad { get; set; }
       public double Descuento { get; set; }
       public decimal PrecioNeto { get; set; }

       List<AgregarVentas> Lista = new List<AgregarVentas>();

       public List<AgregarVentaNueva> addList(Dictionary<int, string> fproducto, decimal fprecio, int fcantidad, double fdescuento)
       {
          List<AgregarVentas> vvv = addventas.addList(fproducto, fprecio, fcantidad, fdescuento);
       
           List<AgregarVentaNueva> listaVentaNueva = new List<AgregarVentaNueva>();

        //foreach (var item in vvv)
        //{
        //    foreach (var itemm in listaVentaNueva)
        //    {
        //        itemm.Producto = item.Producto;

        //    }
        //}

        listaVentaNueva.AddRange(vvv.Cast<AgregarVentaNueva>());

         //listaVentaNueva.AddRange(addventas.addList(fproducto, fprecio, fcantidad, fdescuento).Cast<AgregarVentaNueva>());

         return listaVentaNueva;
       }

       public void listaGuardar(List<AgregarVentas> lista)
       {
          addventas.listaGuardar(lista);
       }

       public List<AgregarVentas> RemoveList(int index)
       {
           return addventas.RemoveList(index);
       }

       public List<AgregarVentas> UpdateList(Dictionary<int, string> idproducto, string id, decimal fprecio, int fcantidad, double fdescuento)
       {
           return addventas.UpdateList(idproducto, id, fprecio, fcantidad, fdescuento);
       }

       public bool ExistProductList(int idproducto)
       {
           return addventas.ExistProductList(idproducto);
       }

       public void EraserList()
       {
           addventas.EraserList();
       }

   }
}
