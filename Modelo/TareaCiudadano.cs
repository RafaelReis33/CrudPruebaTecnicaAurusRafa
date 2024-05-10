using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaEastview.Modelo
{
    public class TareaCiudadano
    {
        private int _Id_Tarea_Ciudadano;
        private int _Id_Ciudadano;
        private string _Nombre_Ciudadano;
        private string _Nombre_Tarea;
        private string _DiaTarea;
        private int _Id_Dia_Tarea;
        private bool _Estado;

        public int Id_Tarea_Ciudadano
        {
            get { return _Id_Tarea_Ciudadano; }
            set { _Id_Tarea_Ciudadano = value; }
        }

        public int Id_Ciudadano
        {
            get { return _Id_Ciudadano; }
            set { _Id_Ciudadano = value; }
        }

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

        public int Id_Dia_Tarea
        {
            get { return _Id_Dia_Tarea; }
            set { _Id_Dia_Tarea = value; }
        }

        public bool Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }
    }
}