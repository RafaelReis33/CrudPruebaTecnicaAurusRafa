using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SistemaEastview.Modelo;
using System.Data;
using SistemaEastview.Repository;

namespace SistemaEastview.Controller
{
    public class TareaCiudadanoController
    {
        public List<TareaCiudadano> ListarTareaCuidadano()
        {
            List<TareaCiudadano> lTareaCiudadano = new List<TareaCiudadano>();
            TareaCiudadanoRepository tareaCiudadanoRepository = new TareaCiudadanoRepository();
            DataTable dt = tareaCiudadanoRepository.ListarTareasCiudadanos();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TareaCiudadano obj_tarea_ciudadano = new TareaCiudadano();
                obj_tarea_ciudadano.Id_Tarea_Ciudadano = Convert.ToInt32(dt.Rows[i]["ID_TAREA_CIUDADANO"]);
                obj_tarea_ciudadano.Id_Ciudadano = Convert.ToInt32(dt.Rows[i]["ID_CIUDADANO"]);
                obj_tarea_ciudadano.Nombre_Ciudadano = dt.Rows[i]["NOMBRE"].ToString() + " " + dt.Rows[i]["APELLIDO"].ToString();
                obj_tarea_ciudadano.Nombre_Tarea = dt.Rows[i]["NOMBRE_TAREA"].ToString();
                obj_tarea_ciudadano.DiaTarea = dt.Rows[i]["DIA_TAREA"].ToString();
                obj_tarea_ciudadano.Id_Dia_Tarea = Convert.ToInt32(dt.Rows[i]["ID_DIA_TAREA"]);
                obj_tarea_ciudadano.Estado = Convert.ToBoolean(dt.Rows[i]["ESTADO"]);
                lTareaCiudadano.Add(obj_tarea_ciudadano);
            }

            return lTareaCiudadano;

        }

        public void GuardarTareaCiudadano(TareaCiudadano obj_tareaciudadano)
        {
            TareaCiudadanoRepository tareaCiudadanoRepository = new TareaCiudadanoRepository();
            tareaCiudadanoRepository.GuardarTareaCidadano(obj_tareaciudadano);
        }

        public void ActualizarTareaCiudadano(TareaCiudadano obj_tareaciudadano)
        {
            TareaCiudadanoRepository tareaCiudadanoRepository = new TareaCiudadanoRepository();
            tareaCiudadanoRepository.ActualizarTareaCiudadano(obj_tareaciudadano);
        }

        public void EliminarTareaCiudadano(int id)
        {
            TareaCiudadanoRepository tareaCiudadanoRepository = new TareaCiudadanoRepository();
            tareaCiudadanoRepository.EliminarTareaCiudadano(id);
        }

        public TareaCiudadano BuscarDatosTareaCiudadanoById(int id)
        {
            TareaCiudadanoRepository tareaCiudadanoRepository = new TareaCiudadanoRepository();
            return tareaCiudadanoRepository.BuscarDatosTareaCiudadanoById(id);
        }

        public int BuscarTareaIngresada(int id_ciudano, int id_dia_tarea)
        {

            TareaCiudadanoRepository tareaCiudadanoRepository = new TareaCiudadanoRepository();
            return tareaCiudadanoRepository.BuscarTareaIngresada(id_ciudano, id_dia_tarea);
        }
    }
}