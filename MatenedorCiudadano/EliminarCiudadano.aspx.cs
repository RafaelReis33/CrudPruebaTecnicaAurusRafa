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
    public partial class EliminarCiudadano : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["ELIMINAR_CIUDADANO"] != null)
                {
                    int codigo = Convert.ToInt32(Session["ELIMINAR_CIUDADANO"]);
                    Ciudadano obj_ciudadano = new Ciudadano();
                    CiudadanoController operacion = new CiudadanoController();
                    obj_ciudadano = operacion.BuscarDatosCiudadanoById(codigo);

                    lblCiudadano.Text = obj_ciudadano.Nombre + " " + obj_ciudadano.Apellido;

                }
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListaCiudadano.aspx");
        }

        protected void btnEliminarCiudadano_Click(object sender, EventArgs e)
        {
            if (Session["ELIMINAR_CIUDADANO"] != null)
            {
                int codigo = Convert.ToInt32(Session["ELIMINAR_CIUDADANO"]);
                CiudadanoController operacion = new CiudadanoController();
                operacion.EliminarCiudadano(codigo);
                Response.Redirect("ListaCiudadano.aspx");
            }
        }
    }
}