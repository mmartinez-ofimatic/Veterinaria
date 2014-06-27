using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;

namespace Logica
{
    public class Rol_Bus
    {
        public int ID { get; set; }
        public string rol { get; set; }
        public int permisos { get; set; }

        Rol_DAL rol_dal = new Rol_DAL();

        /// <summary>
        /// Guarda un rol en la base de datos.
        /// </summary>
        public bool Guardar()
        {         
            rol_dal.rol = rol;
            rol_dal.permisos = permisos;

            return rol_dal.Guardar();
        }

        /// <summary>
        /// Modifica un rol.
        /// </summary>
        public bool Modificar(int id)
        {
            rol_dal.rol = rol;
            rol_dal.permisos = permisos;

            return rol_dal.Modificar(id);
        }

        /// <summary>
        /// Borra un rol.
        /// </summary>
        /// <returns>bool isComplete</returns>
        public bool Borrar(int id)
        {
            return rol_dal.Borrar(id);
        }

        /// <summary>
        /// Lista de todos los roles.
        /// </summary>
        /// <returns>List select</returns>
        public List<Role> BuscarTodos()
        {    
            return rol_dal.BuscarTodos();
        }

        /// <summary>
        /// Busqueda por ID.
        /// </summary>
        /// <returns>List</returns>
        public List<Role> BuscarxID(int id)
        {
            return rol_dal.BuscarxID(id);
        }

        /// <summary>
        /// Buscar por nombre.
        /// </summary>
        /// <param name="nombre">nombre del cliente.</param>
        /// <returns>List</returns>s
        public List<Role> BuscarxNombre(string nombre)
        {
            return rol_dal.BuscarxNombre(nombre);
        }

        public int GetPermisos(int ID)
        {
            try
            {
                return rol_dal.GetPermisos(ID);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string GetNombreRol(int id)
        {
            try
            {
                return rol_dal.GetNombreRol(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
