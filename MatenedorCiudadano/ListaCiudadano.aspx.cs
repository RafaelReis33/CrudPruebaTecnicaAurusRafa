using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaEastview.Controller;

namespace SistemaEastview.MatenedorCiudadano
{
    public partial class ListaCiudadano : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargaRepeaterCiudadano();
            }
        }

        public void CargaRepeaterCiudadano()
        {
            rpCiudadano.DataSource = new CiudadanoController().ListaCiudadanos();
            rpCiudadano.DataBind();
        }

        protected void btnNuevoCiudadano_Click(object sender, EventArgs e)
        {
            Session["ID_CIUDADANO"] = null;
            Response.Redirect("AgregarEditarCiudadano.aspx");
        }

        protected void btnEditarCiudadano_Click(object sender, EventArgs e)
        {
            var buttonEditar = sender as LinkButton;
            int codigo = Convert.ToInt32(buttonEditar.CommandArgument);
            Session["ID_CIUDADANO"] = codigo;
            Response.Redirect("AgregarEditarCiudadano.aspx");
        }

        protected void btnEliminarCiudadano_Click(object sender, EventArgs e)
        {
            var buttonEditar = sender as LinkButton;
            int codigo = Convert.ToInt32(buttonEditar.CommandArgument);
            Session["ELIMINAR_CIUDADANO"] = codigo;
            Response.Redirect("EliminarCiudadano.aspx");
        }
    }
}