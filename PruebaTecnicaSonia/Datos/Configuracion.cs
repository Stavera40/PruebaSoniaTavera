using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Datos
{
    public class Configuracion
    {
        static string cadenaConexion = ConfigurationManager.ConnectionStrings["Myconexion"].ToString();
        public static string CadenaConexion
        {
            get { return cadenaConexion; }
        }
    }
}
