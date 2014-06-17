using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Datos;

namespace Logica
{
    public class Clientes_Bus
    {
        Clientes_DAL clientesD = new Clientes_DAL();

        public bool Guardar()
        {
            bool isComplete = false;
            
            try
            {
                clientesD.Guardar();
            }
            catch (Exception)
            {
                
                throw;
            }

            return isComplete;
        }


   
    }
}
