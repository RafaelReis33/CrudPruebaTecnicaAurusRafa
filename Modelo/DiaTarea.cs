using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaEastview.Modelo
{
    public class DiaTarea
    {
        private int _Id_Dia;
        private string _Nombre_Dia;

        public int Id_Dia
        {
            get { return _Id_Dia; }
            set { _Id_Dia = value; }
        }

        public string Nombre_Dia
        {
            get { return _Nombre_Dia; }
            set { _Nombre_Dia = value; }
        }
    }
}