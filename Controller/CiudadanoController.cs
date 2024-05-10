using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SistemaEastview.Modelo;
using SistemaEastview.Repository;
using System.Data;

namespace SistemaEastview.Controller
{
    public class CiudadanoController
    {
        public List<Ciudadano> ListaCiudadanos()
        {
            List<Ciudadano> lCiudadano = new List<Ciudadano>();
            CiudadanoRepository ciudadanoRepository = new CiudadanoRepository();
            DataTable dt = ciudadanoRepository.ListarCiudadanos();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Ciudadano obj_ciudadano = new Ciudadano();
                obj_ciudadano.Id_Ciudadano = Convert.ToInt32(dt.Rows[i]["ID_CIUDADANO"]);
                obj_ciudadano.Nombre = dt.Rows[i]["NOMBRE"].ToString();
                obj_ciudadano.Apellido = dt.Rows[i]["APELLIDO"].ToString();
                obj_ciudadano.Comuna = dt.Rows[i]["COMUNA"].ToString();
                obj_ciudadano.Estado = Convert.ToBoolean(dt.Rows[i]["ESTADO"]);
                lCiudadano.Add(obj_ciudadano);
            }

            return lCiudadano;

        }

        public List<Ciudadano> ListaDropDownCiudadanos()
        {
            List<Ciudadano> lCiudadano = new List<Ciudadano>();
            CiudadanoRepository ciudadanoRepository = new CiudadanoRepository();
            DataTable dt = ciudadanoRepository.ListarDropDownCuidadanos();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Ciudadano obj_ciudadano = new Ciudadano();
                obj_ciudadano.Id_Ciudadano = Convert.ToInt32(dt.Rows[i]["ID_CIUDADANO"]);
                obj_ciudadano.Nombre = dt.Rows[i]["NOMBRE"].ToString();
                lCiudadano.Add(obj_ciudadano);
            }

            return lCiudadano;

        }

        public void GuardarCiudadano(Ciudadano obj_ciudadano)
        {
            CiudadanoRepository ciudadanoRepository = new CiudadanoRepository();
            ciudadanoRepository.GuardarCidadano(obj_ciudadano);
        }

        public void ActualizarCiudadano(Ciudadano obj_ciudadano)
        {
            CiudadanoRepository ciudadanoRepository = new CiudadanoRepository();
            ciudadanoRepository.ActualizarCiudadano(obj_ciudadano);
        }

        public void EliminarCiudadano(int id)
        {
            CiudadanoRepository ciudadanoRepository = new CiudadanoRepository();
            ciudadanoRepository.EliminarCiudadano(id);
        }

        public Ciudadano BuscarDatosCiudadanoById(int id)
        {
            CiudadanoRepository ciudadanoRepository = new CiudadanoRepository();
            return ciudadanoRepository.BuscarDatosCiudadanoById(id);
        }
    }
}