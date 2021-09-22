using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.GAP
{
    public class SeguridadBL
    {
        public bool autorizar(string usuario, string contrasena)
        {


            if (usuario == "user" && contrasena == "123")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}