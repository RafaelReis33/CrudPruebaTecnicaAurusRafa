using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace SistemaEastview.Repository
{
    public class ConfigRepository
    {
        public static string conexionServidor = ConfigurationManager.ConnectionStrings["conectionServidor"].ToString();

        public string Coneccion
        {
            get { return conexionServidor; }
        }
    }
}