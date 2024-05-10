using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using SistemaEastview.Modelo;

namespace SistemaEastview.Repository
{
    public class TareaCiudadanoRepository
    {
        ConfigRepository configRepository = new ConfigRepository();
        SqlConnection coneccion = null;

        public DataTable ListarTareasCiudadanos()
        {

            try
            {
                coneccion = new SqlConnection(configRepository.Coneccion);
                SqlCommand sql = new SqlCommand("SELECT TC.ID_TAREA_CIUDADANO, C.ID_CIUDADANO, C.NOMBRE, C.APELLIDO, TC.NOMBRE_TAREA, " +
                                                 "D.NOMBRE_DIA as DIA_TAREA, D.ID_DIA as ID_DIA_TAREA, TC.ESTADO FROM TB_TAREA_CIUDADANO AS TC INNER JOIN TB_CIUDADANO AS C " +
                                                 "ON C.ID_CIUDADANO = TC.ID_CIUDADANO INNER JOIN TB_DIA AS D " +
                                                 "ON D.ID_DIA = TC.ID_DIA_TAREA "+
                                                 "WHERE TC.ESTADO = 1", coneccion);
                SqlDataAdapter daTareasCiudadanos = new SqlDataAdapter();
                daTareasCiudadanos.SelectCommand = sql;
                DataTable dt = new DataTable();
                daTareasCiudadanos.Fill(dt);

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

        public void GuardarTareaCidadano(TareaCiudadano obj_tarea_ciudadano)
        {

            try
            {
                coneccion = new SqlConnection(configRepository.Coneccion);
                SqlCommand sql = new SqlCommand("INSERT INTO TB_TAREA_CIUDADANO(ID_CIUDADANO, NOMBRE_TAREA, DIA_TAREA, ID_DIA_TAREA, ESTADO) " +
                                                "VALUES(@ID_CIUDADANO, @NOMBRE_TAREA, @DIA_TAREA, @ID_DIA_TAREA, @ESTADO)", coneccion);
                coneccion.Open();
                sql.Parameters.AddWithValue("@ID_CIUDADANO", obj_tarea_ciudadano.Id_Ciudadano);
                sql.Parameters.AddWithValue("@NOMBRE_TAREA", obj_tarea_ciudadano.Nombre_Tarea);
                sql.Parameters.AddWithValue("@DIA_TAREA", obj_tarea_ciudadano.DiaTarea);
                sql.Parameters.AddWithValue("@ID_DIA_TAREA", obj_tarea_ciudadano.Id_Dia_Tarea);
                sql.Parameters.AddWithValue("@ESTADO", obj_tarea_ciudadano.Estado);
                sql.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                coneccion.Close();
            }
        }

        public void ActualizarTareaCiudadano(TareaCiudadano obj_tarea_ciudadano)
        {

            try
            {
                coneccion = new SqlConnection(configRepository.Coneccion);
                SqlCommand sql = new SqlCommand("UPDATE TB_TAREA_CIUDADANO SET ID_CIUDADANO = @ID_CIUDADANO, NOMBRE_TAREA = @NOMBRE_TAREA, " +
                                                "DIA_TAREA = @DIA_TAREA, ID_DIA_TAREA = @ID_DIA_TAREA,  ESTADO = @ESTADO "+ 
                                                "WHERE ID_TAREA_CIUDADANO = @ID_TAREA_CIUDADANO", coneccion);
                sql.Parameters.AddWithValue("@ID_CIUDADANO", obj_tarea_ciudadano.Id_Ciudadano);
                sql.Parameters.AddWithValue("@NOMBRE_TAREA", obj_tarea_ciudadano.Nombre_Tarea);
                sql.Parameters.AddWithValue("@DIA_TAREA", obj_tarea_ciudadano.DiaTarea);
                sql.Parameters.AddWithValue("@ID_DIA_TAREA", obj_tarea_ciudadano.Id_Dia_Tarea);
                sql.Parameters.AddWithValue("@ESTADO", obj_tarea_ciudadano.Estado);
                sql.Parameters.AddWithValue("@ID_TAREA_CIUDADANO", obj_tarea_ciudadano.Id_Tarea_Ciudadano);
                coneccion.Open();
                sql.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                coneccion.Close();
            }
        }

        public void EliminarTareaCiudadano(int id)
        {
            try
            {
                coneccion = new SqlConnection(configRepository.Coneccion);
                SqlCommand sql = new SqlCommand("UPDATE TB_TAREA_CIUDADANO SET ESTADO = 0 WHERE ID_TAREA_CIUDADANO = @ID_TAREA_CIUDADANO", coneccion);
                sql.Parameters.AddWithValue("@ID_TAREA_CIUDADANO", id);
                coneccion.Open();
                sql.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                coneccion.Close();
            }
        }
        public TareaCiudadano BuscarDatosTareaCiudadanoById(int id)
        {
            try
            {
                coneccion = new SqlConnection(configRepository.Coneccion);
                SqlCommand sql = new SqlCommand("SELECT TC.ID_TAREA_CIUDADANO, C.ID_CIUDADANO, C.NOMBRE, C.APELLIDO, TC.NOMBRE_TAREA, " +
                                                 "D.NOMBRE_DIA as DIA_TAREA, D.ID_DIA as ID_DIA_TAREA, TC.ESTADO FROM TB_TAREA_CIUDADANO AS TC INNER JOIN TB_CIUDADANO AS C " +
                                                 "ON C.ID_CIUDADANO = TC.ID_CIUDADANO INNER JOIN TB_DIA AS D " +
                                                 "ON D.ID_DIA = TC.ID_DIA_TAREA "+
                                                 "WHERE TC.ESTADO = 1 " +
                                                 "AND ID_TAREA_CIUDADANO = @ID_TAREA_CIUDADANO", coneccion);
                sql.Parameters.AddWithValue("@ID_TAREA_CIUDADANO", id);
                coneccion.Open();
                SqlDataReader datareader;
                TareaCiudadano obj_tarea_ciudadano = new TareaCiudadano();
                datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);
                while (datareader.Read())
                {
                    obj_tarea_ciudadano.Id_Tarea_Ciudadano = Convert.ToInt32(datareader["ID_TAREA_CIUDADANO"]);
                    obj_tarea_ciudadano.Id_Ciudadano = Convert.ToInt32(datareader["ID_CIUDADANO"]);
                    obj_tarea_ciudadano.Nombre_Ciudadano = datareader["NOMBRE"].ToString() + " " + datareader["APELLIDO"].ToString();
                    obj_tarea_ciudadano.Nombre_Tarea = datareader["NOMBRE_TAREA"].ToString();
                    obj_tarea_ciudadano.DiaTarea = datareader["DIA_TAREA"].ToString();
                    obj_tarea_ciudadano.Id_Dia_Tarea = Convert.ToInt32(datareader["ID_DIA_TAREA"]);
                    obj_tarea_ciudadano.Estado = Convert.ToBoolean(datareader["ESTADO"]);
                }

                return obj_tarea_ciudadano;
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                coneccion.Close();
            }
        }

        

      public int BuscarTareaIngresada(int id_ciudano, int id_dia_tarea)
        {
            try
            {
                coneccion = new SqlConnection(configRepository.Coneccion);
                SqlCommand sql = new SqlCommand("SELECT ID_DIA_TAREA, ID_CIUDADANO FROM TB_TAREA_CIUDADANO " +
                                                 "WHERE ID_CIUDADANO = @ID_CIUDADANO AND ID_DIA_TAREA = @ID_DIA_TAREA", coneccion);
                sql.Parameters.AddWithValue("@ID_CIUDADANO", id_ciudano);
                sql.Parameters.AddWithValue("@ID_DIA_TAREA", id_dia_tarea);
                coneccion.Open();
                SqlDataReader datareader;
                int var_dia_tarea = 0;
                datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);
                while (datareader.Read())
                {
                    var_dia_tarea = Convert.ToInt32(datareader["ID_DIA_TAREA"]);
                }

                return var_dia_tarea;
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                coneccion.Close();
            }
        }
    }
}