using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaEastview.Controller;
using SistemaEastview.Modelo;

namespace SistemaEastview.MantenedorTareaCiudadano
{
    public partial class AgregarEditarTarea : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LimpiarCampos();
                CargaDropDias();
                CargaDropCiudadano();

                if (Session["ID_TAREA_CIUDADANO"] != null)
                {
                    int codigo = Convert.ToInt32(Session["ID_TAREA_CIUDADANO"]);
                    TareaCiudadano obj_tarea_ciudadano = new TareaCiudadano();
                    TareaCiudadanoController operacion = new TareaCiudadanoController();
                    obj_tarea_ciudadano = operacion.BuscarDatosTareaCiudadanoById(codigo);

                    dpCuidadano.SelectedValue = obj_tarea_ciudadano.Id_Ciudadano.ToString();
                    txtNombreTarea.Text = obj_tarea_ciudadano.Nombre_Tarea;
                    dpDiaTarea.SelectedValue = obj_tarea_ciudadano.Id_Dia_Tarea.ToString();
                    hdCodigoTareaCiudadano.Value = obj_tarea_ciudadano.Id_Tarea_Ciudadano.ToString();
                }
            }
        }

        public void CargaDropDias()
        {
            dpDiaTarea.DataSource = new DiaTareaController().ListaDias();
            dpDiaTarea.DataTextField = "Nombre_Dia";
            dpDiaTarea.DataValueField = "Id_Dia";
            dpDiaTarea.DataBind();
            dpDiaTarea.Items.Insert(0, new ListItem("Seleccione el dia", "0"));
        }

        public void CargaDropCiudadano()
        {
            dpCuidadano.DataSource = new CiudadanoController().ListaDropDownCiudadanos();
            dpCuidadano.DataTextField = "Nombre";
            dpCuidadano.DataValueField = "Id_Ciudadano";
            dpCuidadano.DataBind();
            dpCuidadano.Items.Insert(0, new ListItem("Seleccione el Ciudadano", "0"));
        }

        protected void btnGuardarTareaCiudadano_Click(object sender, EventArgs e)
        {
            if (Session["ID_TAREA_CIUDADANO"] == null)
            {
                if (!string.IsNullOrEmpty(txtNombreTarea.Text) && dpDiaTarea.SelectedValue != "0" && dpCuidadano.SelectedValue != "0")
                {
                    TareaCiudadanoController operacion = new TareaCiudadanoController();

                    int verificaRegistroBase = operacion.BuscarTareaIngresada(Convert.ToInt32(dpCuidadano.SelectedValue), Convert.ToInt32(dpDiaTarea.SelectedValue));

                    if (verificaRegistroBase == 0 || verificaRegistroBase == null)
                    {



                        TareaCiudadano obj_tarea_ciudadano = new TareaCiudadano();
                        obj_tarea_ciudadano.Id_Ciudadano = Convert.ToInt32(dpCuidadano.SelectedValue);
                        obj_tarea_ciudadano.Nombre_Tarea = txtNombreTarea.Text;
                        obj_tarea_ciudadano.DiaTarea = dpDiaTarea.SelectedItem.Text;
                        obj_tarea_ciudadano.Id_Dia_Tarea = Convert.ToInt32(dpDiaTarea.SelectedValue);
                        obj_tarea_ciudadano.Estado = true;

                        operacion.GuardarTareaCiudadano(obj_tarea_ciudadano);
                        ErrorDataIngresada.Visible = false;
                        Response.Redirect("ListarTareaCiudadano.aspx");
                    }
                    else
                    {
                        ErrorDataIngresada.Text = "¡Ya existe una tarea para este ciudadano, en este dia!";
                        ErrorDataIngresada.Visible = true;
                    }


                }
                else
                {
                    ValidaCamposVacios();
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtNombreTarea.Text) && dpDiaTarea.SelectedValue != "0" && dpCuidadano.SelectedValue != "0")
                {
                    TareaCiudadano obj_tarea_ciudadano = new TareaCiudadano();
                    int codigo = Convert.ToInt32(Session["ID_TAREA_CIUDADANO"]);
                    obj_tarea_ciudadano.Id_Ciudadano = Convert.ToInt32(dpCuidadano.SelectedValue);
                    obj_tarea_ciudadano.Nombre_Tarea = txtNombreTarea.Text;
                    obj_tarea_ciudadano.DiaTarea = dpDiaTarea.SelectedItem.Text;
                    obj_tarea_ciudadano.Id_Dia_Tarea = Convert.ToInt32(dpDiaTarea.SelectedValue);
                    obj_tarea_ciudadano.Estado = true;
                    obj_tarea_ciudadano.Id_Tarea_Ciudadano = codigo;
                    TareaCiudadanoController operacion = new TareaCiudadanoController();
                    operacion.ActualizarTareaCiudadano(obj_tarea_ciudadano);
                    Response.Redirect("ListarTareaCiudadano.aspx");
                }
                else
                {
                    ValidaCamposVacios();
                }
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListarTareaCiudadano.aspx");
        }

        public void LimpiarCampos()
        {
            txtNombreTarea.Text = string.Empty;
            ErrorCiudadano.Visible = false;
            ErrorNombreTarea.Visible = false;
            ErrorDiaTarea.Visible = false;
            ErrorDataIngresada.Visible = false;
        }

        public void ValidaCamposVacios()
        {
            if (dpCuidadano.SelectedValue == "0")
            {
                ErrorCiudadano.Text = "Por Favor, Seleccione un ciudadano";
                ErrorCiudadano.Visible = true;
            }
            else
            {
                ErrorCiudadano.Visible = false;
            }

            if (string.IsNullOrEmpty(txtNombreTarea.Text))
            {
                ErrorNombreTarea.Text = "Por Favor, escriba alguna tarea";
                ErrorNombreTarea.Visible = true;
            }
            else
            {
                ErrorNombreTarea.Visible = false;
            }

            if (dpDiaTarea.SelectedValue == "0")
            {
                ErrorDiaTarea.Text = "Por Favor, Seleccione un dia";
                ErrorDiaTarea.Visible = true;
            }
            else
            {
                ErrorDiaTarea.Visible = false;
            }
        }


    }
}