using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace SistemaEastview.Repository
{
    public class VisualizarTareaRepository
    {
        ConfigRepository configRepository = new ConfigRepository();
        SqlConnection coneccion = null;

        public DataTable VisualizarTareasByDia(int id_dia)
        {

            try
            {
                coneccion = new SqlConnection(configRepository.Coneccion);
                SqlCommand sql = new SqlCommand("SELECT C.NOMBRE, C.APELLIDO, TC.NOMBRE_TAREA, D.NOMBRE_DIA as DIA_TAREA " +
                                                 "FROM TB_TAREA_CIUDADANO AS TC INNER JOIN TB_CIUDADANO AS C " +
                                                 "ON C.ID_CIUDADANO = TC.ID_CIUDADANO INNER JOIN TB_DIA AS D " +
                                                 "ON D.ID_DIA = TC.ID_DIA_TAREA " +
                                                 "WHERE TC.ESTADO = 1 AND TC.ID_DIA_TAREA = @ID_DIA_TAREA", coneccion);
                sql.Parameters.AddWithValue("@ID_DIA_TAREA", id_dia);
                SqlDataAdapter daVisualizarTarea = new SqlDataAdapter();
                daVisualizarTarea.SelectCommand = sql;
                DataTable dt = new DataTable();
                daVisualizarTarea.Fill(dt);

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