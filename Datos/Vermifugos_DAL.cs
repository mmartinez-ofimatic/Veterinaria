using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos
{
   public class Vermifugos_DAL
    {

        public static int ID_Animal { get; set; }
        public static string Vermifugo { get; set; }
        public static string Resultados { get; set; }
        //public static string Fecha { get; set; }


        veterinariaDBEntities dbEntities = new veterinariaDBEntities();

        /// <summary>
        /// Guarda un vermifugo en la base de datos.
        /// </summary>
        public bool Guardar()
        {
            bool isComplete = false;
            try
            {

                veterinariaDBEntities db = new veterinariaDBEntities();

                Vermifugo vermifugo = new Vermifugo();
                vermifugo.ID_Animal = ID_Animal;
                vermifugo.Vermifugo1 = Vermifugo;
                vermifugo.Resultados = Resultados;
                vermifugo.Fecha = DateTime.Now;

                db.Vermifugos.AddObject(vermifugo);
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
        /// Modifica un vermifugo.
        /// </summary>
        public bool Modificar(int ID)
        {
            bool isComplete = false;
            try
            {
                Vermifugo update = (from upd in dbEntities.Vermifugos
                                  where upd.ID_Vermifugos == ID
                                  select upd).First();

                update.ID_Animal = ID_Animal;
                update.Vermifugo1 = Vermifugo;
                update.Resultados = Resultados;

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
        /// Borra un vermifugo.
        /// </summary>
        /// <returns>bool isComplete</returns>
        public bool Borrar(int ID)
        {
            bool isComplete = false;

            try
            {
                Vermifugo borrar = (from bor in dbEntities.Vermifugos
                                  where bor.ID_Vermifugos == ID
                                  select bor).FirstOrDefault();

                dbEntities.Vermifugos.DeleteObject(borrar);
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
        /// Lista los ultimos 15 vermifugos.
        /// </summary>
        /// <returns>List select</returns>
        public List<Vermifugo> BuscarUltimosVermifugos()
        {
            var selec = (from s in dbEntities.Vermifugos
                         select s).Take(15).OrderByDescending(x => x.ID_Vermifugos).ToList();
            return selec;
        }

        /// <summary>
        /// Buscar por Vermifugo.
        /// </summary>
        /// <param name="nombre">Nombre del vermifugo.</param>
        /// <returns>List</returns>
        public List<Vermifugo> BuscarxNombre(string nombre)
        {

            List<Vermifugo> busc = (from b in dbEntities.Vermifugos
                                  where b.Vermifugo1.Contains(nombre)
                                  select b).OrderByDescending(x => x.Vermifugo1).ToList();

            if (busc != null)
            {
                foreach (var item in busc)
                {
                    ID_Animal = Convert.ToInt32(item.ID_Animal);
                    Vermifugo = item.Vermifugo1;
                    Resultados = item.Resultados;
                }
            }
            return busc;
        }

        /// <summary>
        /// Buscar por ID del Animal.
        /// </summary>
        /// <param name="nombre">ID Animal.</param>
        /// <returns>List</returns>
        public List<Vermifugo> BuscarxNombreAnimal(string nombre)
        {
            var busc = (from b in dbEntities.Vermifugos
                                    join a in dbEntities.Animales
                                    on b.ID_Animal equals a.ID_Animal
                                    where a.Nombre.Contains(nombre)
                                    select b).ToList();
            if (busc != null)
            {
                foreach (var item in busc)
                {
                    ID_Animal = Convert.ToInt32(item.ID_Animal);
                    Vermifugo = item.Vermifugo1;
                    Resultados = item.Resultados;
                }
            }
            return busc;
        }


    }
}
