using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaEastview.Modelo;
using SistemaEastview.Controller;

namespace SistemaEastview.MatenedorCiudadano
{
    public partial class AgregarEditarCiudadano : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                LimpiarCampos();

                if (Session["ID_CIUDADANO"] != null)
                {
                    int codigo = Convert.ToInt32(Session["ID_CIUDADANO"]);
                    Ciudadano obj_ciudadano = new Ciudadano();
                    CiudadanoController operacion = new CiudadanoController();
                    obj_ciudadano = operacion.BuscarDatosCiudadanoById(codigo);

                    txtNombre.Text = obj_ciudadano.Nombre;
                    txtApellido.Text = obj_ciudadano.Apellido;
                    txtComuna.Text = obj_ciudadano.Comuna;
                    hdCodigoCiudadano.Value = obj_ciudadano.Id_Ciudadano.ToString();
                }

            }
        }

        protected void btnGuardarCiudadano_Click(object sender, EventArgs e)
        {
            if (Session["ID_CIUDADANO"] == null)
            {
                if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellido.Text) && !string.IsNullOrEmpty(txtComuna.Text))
                {
                    Ciudadano obj_ciudadano = new Ciudadano();
                    obj_ciudadano.Nombre = txtNombre.Text;
                    obj_ciudadano.Apellido = txtApellido.Text;
                    obj_ciudadano.Comuna = txtComuna.Text;
                    obj_ciudadano.Estado = true;
                    CiudadanoController operacion = new CiudadanoController();
                    operacion.GuardarCiudadano(obj_ciudadano);
                    Response.Redirect("ListaCiudadano.aspx");
                }
                else
                {
                    ValidaCamposVacios();
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellido.Text) && !string.IsNullOrEmpty(txtComuna.Text))
                {
                    Ciudadano obj_ciudadano = new Ciudadano();
                    int codigo = Convert.ToInt32(Session["ID_CIUDADANO"]);
                    obj_ciudadano.Nombre = txtNombre.Text;
                    obj_ciudadano.Apellido = txtApellido.Text;
                    obj_ciudadano.Comuna = txtComuna.Text;
                    obj_ciudadano.Id_Ciudadano = codigo;
                    obj_ciudadano.Estado = true;
                    CiudadanoController operacion = new CiudadanoController();
                    operacion.ActualizarCiudadano(obj_ciudadano);
                    Response.Redirect("ListaCiudadano.aspx");
                }
                else
                {
                    ValidaCamposVacios();
                }
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListaCiudadano.aspx");
        }

        public void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtComuna.Text = string.Empty;
            ErrorNombre.Visible = false;
            ErrorApellido.Visible = false;
            ErrorComuna.Visible = false;
        }

        public void ValidaCamposVacios()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                ErrorNombre.Text = "Por Favor, Escriba un ciudadano";
                ErrorNombre.Visible = true;
            }
            else
            {
                ErrorNombre.Visible = false;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                ErrorApellido.Text = "Por Favor, escriba un apellido";
                ErrorApellido.Visible = true;
            }
            else
            {
                ErrorApellido.Visible = false;
            }
            if (string.IsNullOrEmpty(txtComuna.Text))
            {
                ErrorComuna.Text = "Por Favor, escriba una comuna";
                ErrorComuna.Visible = true;
            }
            else
            {
                ErrorComuna.Visible = false;
            }
        }
    }
}