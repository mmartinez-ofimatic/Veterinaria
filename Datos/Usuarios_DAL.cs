using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos
{
   public class Usuarios_DAL
    {
        public static int IDusuario { get; set; }
        public int IDrol { get; set; }
        public string nomusuario { get; set; }
        public string contrasena { get; set; }

        veterinariaDBEntities db = new veterinariaDBEntities();

        public bool ValidateUsers(string nombre, string pass)
        {
            bool valido = false;

            Usuario usuario = db.Usuarios.FirstOrDefault(x => x.Nombre_Usuario == nombre && x.Contrasena == pass);

            if (usuario != null)
            {
                IDrol = Get_Rol(nombre, pass);
                nomusuario = nombre;
                valido = true;

                IDusuario = usuario.ID_Usuario;
            }

            return valido;
        }

        public static int Get_Rol(string nom, string pass)
        {

            veterinariaDBEntities db = new veterinariaDBEntities();

            var selec = (from s in db.Usuarios
                         where s.Nombre_Usuario == nom && s.Contrasena == pass
                         select s.ID_Rol).First();

            return Convert.ToInt32(selec);
        }

        /// <summary>
        /// Guarda un usuario en la base de datos.
        /// </summary>
        public bool Guardar()
        {
            bool isComplete = false;

            Usuario usuario = new Usuario();

            try
            {
                usuario.ID_Rol = IDrol;
                usuario.Nombre_Usuario = nomusuario;
                usuario.Contrasena = contrasena;
                db.AddToUsuarios(usuario);
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
        /// Modifica un usuario.
        /// </summary>
        public bool Modificar(int id)
        {
            bool isComplete = false;

            try
            {
                Usuario update = (from upd in db.Usuarios
                                  where upd.ID_Usuario == id
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
        public bool Borrar(int id)
        {
            bool isComplete = false;

            try
            {
                Usuario borrar = (from bor in db.Usuarios
                                  where bor.ID_Usuario == id
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
        public List<Usuario> BuscarxID( int id)
        {
            List<Usuario> busc = (from b in db.Usuarios
                                  where b.ID_Usuario == id
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
        /// <param name="nombre">nombre del usuario.</param>
        /// <returns>List</returns>
        public List<Usuario> BuscarxNombre(string nombre)
        {

            List<Usuario> busc = (from b in db.Usuarios
                                  where b.Nombre_Usuario.Contains(nombre)
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
