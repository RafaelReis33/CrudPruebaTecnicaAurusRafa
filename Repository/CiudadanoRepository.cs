using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using SistemaEastview.Modelo;

namespace SistemaEastview.Repository
{
    public class CiudadanoRepository
    {
        ConfigRepository configRepository = new ConfigRepository();
        SqlConnection coneccion = null;

        public DataTable ListarCiudadanos()
        {

            try
            {
                coneccion = new SqlConnection(configRepository.Coneccion);
                SqlCommand sql = new SqlCommand("SELECT * FROM TB_CIUDADANO WHERE ESTADO = 1", coneccion);
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

        public DataTable ListarDropDownCuidadanos()
        {

            try
            {
                coneccion = new SqlConnection(configRepository.Coneccion);
                SqlCommand sql = new SqlCommand("SELECT ID_CIUDADANO, NOMBRE FROM TB_CIUDADANO WHERE ESTADO = 1", coneccion);
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

        public void GuardarCidadano(Ciudadano obj_ciudadano)
        {

            try
            {
                coneccion = new SqlConnection(configRepository.Coneccion);
                SqlCommand sql = new SqlCommand("INSERT INTO TB_CIUDADANO(NOMBRE, APELLIDO, COMUNA, ESTADO) " +
                                                "VALUES(@NOMBRE, @APELLIDO, @COMUNA, @ESTADO)", coneccion);
                sql.Parameters.AddWithValue("@NOMBRE", obj_ciudadano.Nombre);
                sql.Parameters.AddWithValue("@APELLIDO", obj_ciudadano.Apellido);
                sql.Parameters.AddWithValue("@COMUNA", obj_ciudadano.Comuna);
                sql.Parameters.AddWithValue("@ESTADO", obj_ciudadano.Estado);
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

        public void ActualizarCiudadano(Ciudadano obj_ciudadano)
        {

            try
            {
                coneccion = new SqlConnection(configRepository.Coneccion);
                SqlCommand sql = new SqlCommand("UPDATE TB_CIUDADANO SET NOMBRE = @NOMBRE, APELLIDO = @APELLIDO, COMUNA = @COMUNA, " +
                                                "ESTADO = @ESTADO WHERE ID_CIUDADANO = @ID_CIUDADANO", coneccion);
                sql.Parameters.AddWithValue("@NOMBRE", obj_ciudadano.Nombre);
                sql.Parameters.AddWithValue("@APELLIDO", obj_ciudadano.Apellido);
                sql.Parameters.AddWithValue("@COMUNA", obj_ciudadano.Comuna);
                sql.Parameters.AddWithValue("@ESTADO", obj_ciudadano.Estado);
                sql.Parameters.AddWithValue("@ID_CIUDADANO", obj_ciudadano.Id_Ciudadano);
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

        public void EliminarCiudadano(int id)
        {
            try
            {
                coneccion = new SqlConnection(configRepository.Coneccion);
                SqlCommand sql = new SqlCommand("UPDATE TB_CIUDADANO SET ESTADO = 0 WHERE ID_CIUDADANO = @ID_CIUDADANO", coneccion);
                sql.Parameters.AddWithValue("@ID_CIUDADANO", id);
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
        public Ciudadano BuscarDatosCiudadanoById(int id)
        {
            try
            {
                coneccion = new SqlConnection(configRepository.Coneccion);
                SqlCommand sql = new SqlCommand("select * from TB_CIUDADANO WHERE ID_CIUDADANO = @ID_CIUDADANO ", coneccion);
                sql.Parameters.AddWithValue("@ID_CIUDADANO", id);
                coneccion.Open();
                SqlDataReader datareader;
                Ciudadano obj_ciudadano = new Ciudadano();
                datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);
                while (datareader.Read())
                {
                    obj_ciudadano.Id_Ciudadano = Convert.ToInt32(datareader["ID_CIUDADANO"]);
                    obj_ciudadano.Nombre = datareader["NOMBRE"].ToString();
                    obj_ciudadano.Apellido = datareader["APELLIDO"].ToString();
                    obj_ciudadano.Comuna = datareader["COMUNA"].ToString();
                    obj_ciudadano.Estado = Convert.ToBoolean(datareader["ESTADO"]);
                }

                return obj_ciudadano;
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