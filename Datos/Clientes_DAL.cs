using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Entidades;

namespace Datos
{
    public class Clientes_DAL
    {
        veterinariaDBEntities dbEntities = new veterinariaDBEntities();

        /// <summary>
        /// Guarda un cliente en la base de datos.
        /// </summary>
        public bool Guardar()
        {
            bool isComplete = false;
            try
            {

            veterinariaDBEntities db = new veterinariaDBEntities();

            Cliente clientes = new Cliente();
            clientes.Cedula = Clientes_Entity.Cedula;
            clientes.Nombre = Clientes_Entity.Nombre;        
            clientes.Telefono = Clientes_Entity.Telefono;
            clientes.Celular = Clientes_Entity.Celular;
            clientes.Direccion = Clientes_Entity.Direccion;
            clientes.Fecha_Creacion = DateTime.Now;

            db.Clientes.AddObject(clientes);
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
        /// Modifica un cliente.
        /// </summary>
        public bool Modificar(string cedula)
        {
            bool isComplete = false;
            try
            {
                Cliente update = (from upd in dbEntities.Clientes
                                  where upd.Cedula == cedula
                                  select upd).First();

                update.Nombre = Clientes_Entity.Nombre;
                update.Telefono = Clientes_Entity.Telefono;
                update.Celular = Clientes_Entity.Celular;
                update.Direccion = Clientes_Entity.Direccion;

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
        public bool Borrar(string cedula)
        {
            bool isComplete = false;

            try
            {
                Cliente borrar = (from bor in dbEntities.Clientes
                                  where bor.Cedula == cedula
                                  select bor).FirstOrDefault();

                dbEntities.Clientes.DeleteObject(borrar);
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
        /// Lista los ultimos 15 clientes.
        /// </summary>
        /// <returns>List select</returns>
        public List<Cliente> BuscarUltimosClientes()
        {
            var selec = (from s in dbEntities.Clientes
                         select s).Take(15).OrderByDescending(x => x.Cedula).ToList();
            return selec;
        }


        /// <summary>
        /// Buscar por Nombre.
        /// </summary>
        /// <param name="nombre">Nombre del cliente.</param>
        /// <returns>List</returns>
        public List<Cliente> BuscarxNombre(string nombre)
        {

            List<Cliente> busc = (from b in dbEntities.Clientes
                                  where b.Nombre.Contains(nombre)
                                  select b).OrderByDescending(x => x.Cedula).ToList();

            if (busc != null)
            {
                foreach (var item in busc)
                {
                    Clientes_Entity.Cedula = item.Cedula;
                    Clientes_Entity.Nombre = item.Nombre;
                    Clientes_Entity.Telefono = item.Telefono;
                    Clientes_Entity.Celular = item.Celular;
                    Clientes_Entity.Direccion = item.Direccion;
                }
            }
            return busc;
        }

        /// <summary>
        /// Buscar por cedula.
        /// </summary>
        /// <param name="nombre">cedula del cliente.</param>
        /// <returns>List</returns>
        public List<Cliente> BuscarxCedula(string cedula)
        {
            List<Cliente> busc = (from b in dbEntities.Clientes
                                  where b.Cedula.Contains(cedula)
                                  select b).OrderByDescending(x => x.Cedula).ToList();
            if (busc != null)
            {
                foreach (var item in busc)
                {
                    Clientes_Entity.Nombre = item.Nombre;
                    Clientes_Entity.Cedula = item.Cedula;
                    Clientes_Entity.Telefono = item.Telefono;
                    Clientes_Entity.Celular = item.Celular;
                    Clientes_Entity.Direccion = item.Direccion;
                }
            }
            return busc;
        }

    }
}
