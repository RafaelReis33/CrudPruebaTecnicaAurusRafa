using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaEastview.Modelo
{
    public class Ciudadano
    {
        private int _Id_Ciudadano;
        private string _Nombre;
        private string _Apellido;
        private string _Comuna;
        private bool _Estado;

        public int Id_Ciudadano
        {
            get { return _Id_Ciudadano; }
            set { _Id_Ciudadano = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        public string Comuna
        {
            get { return _Comuna; }
            set { _Comuna = value; }
        }

        public bool Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }
    }
}