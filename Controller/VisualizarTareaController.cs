using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SistemaEastview.Modelo;
using SistemaEastview.Repository;
using System.Data;

namespace SistemaEastview.Controller
{
    public class VisualizarTareaController
    {

        public List<VisualizarTarea> VisualizarTareasByDia(int id_dia_tarea){

        List<VisualizarTarea> lVisualizarTarea = new List<VisualizarTarea>();
            VisualizarTareaRepository visualizarTareaRepository = new VisualizarTareaRepository();
            DataTable dt = visualizarTareaRepository.VisualizarTareasByDia(id_dia_tarea);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                VisualizarTarea obj_tarea = new VisualizarTarea();
                obj_tarea.Nombre_Ciudadano = dt.Rows[i]["NOMBRE"].ToString() + " " + dt.Rows[i]["APELLIDO"].ToString();
                obj_tarea.Nombre_Tarea = dt.Rows[i]["NOMBRE_TAREA"].ToString();
                obj_tarea.DiaTarea = dt.Rows[i]["DIA_TAREA"].ToString();
                lVisualizarTarea.Add(obj_tarea);
            }

            return lVisualizarTarea;

        }
    }
}