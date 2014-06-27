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
            return usuariodal.ValidateUsers(nombre, pass);
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
        public bool Modificar()
        {
            bool isComplete = false;

            try
            {
                Usuario update = (from upd in db.Usuarios
                                  where upd.ID_Usuario == IDusuario
                                  select upd).First();

                update.ID_Rol = IDrol;
                update.Nombre_Usuario = nomusuario;
                update.Contrasena = contrasena;
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
        /// Borra un usuario.
        /// </summary>
        /// <returns>bool isComplete</returns>
        public bool Borrar()
        {
            bool isComplete = false;

            try
            {
                Usuario borrar = (from bor in db.Usuarios
                                  where bor.ID_Usuario == IDusuario
                                  select bor).FirstOrDefault();

                db.Usuarios.DeleteObject(borrar);
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
        /// Lista de todos los usuarios.
        /// </summary>
        /// <returns>List select</returns>
        public List<Usuario> BuscarTodos()
        {
            var selec = (from s in db.Usuarios
                         select s).ToList();
            return selec;
        }

        /// <summary>
        /// Busqueda por ID.
        /// </summary>
        /// <returns>List</returns>
        public List<Usuario> BuscarxID()
        {
            List<Usuario> busc = (from b in db.Usuarios
                                  where b.ID_Usuario == IDusuario
                                  select b).ToList();
            if (busc != null)
            {
                if (busc.Count != 0)
                {
                    foreach (var item in busc)
                    {
                        IDrol = Convert.ToInt32(item.ID_Rol);
                        nomusuario = item.Nombre_Usuario;
                        contrasena = item.Contrasena;
                    }

                }
            }

            return busc;
        }

        /// <summary>
        /// Buscar por nombre.
        /// </summary>
        /// <param name="nombre">nombre del cliente.</param>
        /// <returns>List</returns>
        public List<Usuario> BuscarxNombre(string nombre)
        {

            List<Usuario> busc = (from b in db.Usuarios
                                  where b.Nombre_Usuario == nombre
                                  select b).ToList();
            if (busc != null)
            {
                foreach (var item in busc)
                {
                    IDrol = Convert.ToInt32(item.ID_Rol);
                    nomusuario = item.Nombre_Usuario;
                    contrasena = item.Contrasena;
                }
            }
            return busc;
        }
    }
}
