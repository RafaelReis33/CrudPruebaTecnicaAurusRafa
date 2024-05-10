using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace SistemaEastview.Repository
{
    public class DiaTareaRepository
    {
        ConfigRepository configRepository = new ConfigRepository();
        SqlConnection coneccion = null;

        public DataTable ListarDias()
        {

            try
            {
                coneccion = new SqlConnection(configRepository.Coneccion);
                SqlCommand sql = new SqlCommand("SELECT ID_DIA, NOMBRE_DIA FROM TB_DIA WHERE ESTADO = 1", coneccion);
                SqlDataAdapter daCiudadano = new SqlDataAdapter();
                daCiudadano.SelectCommand = sql;
                DataTable dt = new DataTable();
                daCiudadano.Fill(dt);

                return dt;
            }
            catch (Exception error)
            {

                throw error;
            }
            finally
            {
                coneccion.Close();
            }



        }
    }
}