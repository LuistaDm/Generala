using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class GestorBitacora
    {
        private BitacoraDAL bitacoraDAL = new BitacoraDAL();

        public void RegistrarAccion(int idUsuario, string accion)
        {
            bitacoraDAL.Insertar(idUsuario, accion, DateTime.Now);
        }
    }
}
