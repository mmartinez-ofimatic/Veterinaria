using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;

namespace Logica
{
   public class Usuarios_Bus
    {
        public static int IDusuario { get; set; }
        public int IDrol { get; set; }
        public string nomusuario { get; set; }
        public string contrasena { get; set; }

        Usuarios_DAL usuariodal = new Usuarios_DAL();
       
        public bool ValidateUsers(string nombre, string pass)
        {
            bool valido;

            valido = usuariodal.ValidateUsers(nombre, pass);

            if (valido)
            {

                IDrol = usuariodal.IDrol;
                nomusuario = usuariodal.nomusuario;
                IDusuario = Usuarios_DAL.IDusuario;
            }
           
           return valido;
        }

        public static int Get_Rol(string nom, string pass)
        {

            return Usuarios_DAL.Get_Rol(nom, pass);
        }

        /// <summary>
        /// Guarda un usuario en la base de datos.
        /// </summary>
        public bool Guardar()
        {
            usuariodal.IDrol = IDrol;
            usuariodal.nomusuario = nomusuario;
            usuariodal.contrasena = contrasena;


            return usuariodal.Guardar();
        }

        /// <summary>
        /// Modifica un usuario.
        /// </summary>
        public bool Modificar(int id)
        {
            usuariodal.IDrol = IDrol;
            usuariodal.nomusuario = nomusuario;
            usuariodal.contrasena = contrasena;

            return usuariodal.Modificar(id);
        }

        /// <summary>
        /// Borra un usuario.
        /// </summary>
        /// <returns>bool isComplete</returns>
        public bool Borrar(int id)
        {
            return usuariodal.Borrar(id) ;
        }

        /// <summary>
        /// Lista de todos los usuarios.
        /// </summary>
        /// <returns>List select</returns>
        public List<Usuario> BuscarTodos()
        {
            return usuariodal.BuscarTodos();
        }

        /// <summary>
        /// Busqueda por ID.
        /// </summary>
        /// <returns>List</returns>
        public List<Usuario> BuscarxID(int id)
        {
            return usuariodal.BuscarxID(id);
        }

        /// <summary>
        /// Buscar por nombre.
        /// </summary>
        /// <param name="nombre">nombre de usuario.</param>
        /// <returns>List</returns>
        public List<Usuario> BuscarxNombre(string nombre)
        {
            return usuariodal.BuscarxNombre(nombre);
        }
    }
}
