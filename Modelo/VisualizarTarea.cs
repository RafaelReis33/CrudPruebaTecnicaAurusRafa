using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaEastview.Modelo
{
    public class VisualizarTarea
    {
        
        private string _Nombre_Ciudadano;
        private string _Nombre_Tarea;
        private string _DiaTarea;

        public string Nombre_Ciudadano
        {
            get { return _Nombre_Ciudadano; }
            set { _Nombre_Ciudadano = value; }
        }

        public string Nombre_Tarea
        {
            get { return _Nombre_Tarea; }
            set { _Nombre_Tarea = value; }
        }

        public string DiaTarea
        {
            get { return _DiaTarea; }
            set { _DiaTarea = value; }
        }
    }
}