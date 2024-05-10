using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SistemaEastview.Modelo;
using SistemaEastview.Repository;
using System.Data;

namespace SistemaEastview.Controller
{
    public class DiaTareaController
    {
        public List<DiaTarea> ListaDias()
        {
            List<DiaTarea> lDiaTarea = new List<DiaTarea>();
            DiaTareaRepository diaTareaRepository = new DiaTareaRepository();
            DataTable dt = diaTareaRepository.ListarDias();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DiaTarea obj_dia_tarea = new DiaTarea();
                obj_dia_tarea.Id_Dia = Convert.ToInt32(dt.Rows[i]["ID_DIA"]);
                obj_dia_tarea.Nombre_Dia = dt.Rows[i]["NOMBRE_DIA"].ToString();
                lDiaTarea.Add(obj_dia_tarea);
            }

            return lDiaTarea;

        }
    }
}