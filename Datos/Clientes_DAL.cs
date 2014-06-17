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
    }
}
