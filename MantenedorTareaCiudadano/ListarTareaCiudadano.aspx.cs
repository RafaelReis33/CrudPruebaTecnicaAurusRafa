using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaEastview.Controller;

namespace SistemaEastview.MantenedorTareaCiudadano
{
    public partial class ListarTareaCiudadano : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargaRepeaterTareaCuidadano();
            }
        }

        protected void btnNuevaTarea_Click(object sender, EventArgs e)
        {
            Session["ID_TAREA_CIUDADANO"] = null;
            Response.Redirect("AgregarEditarTarea.aspx");
        }

        public void CargaRepeaterTareaCuidadano()
        {
            rpTareaCiudadano.DataSource = new TareaCiudadanoController().ListarTareaCuidadano();
            rpTareaCiudadano.DataBind();
        }

        protected void btnEditarTareaCiudadano_Click(object sender, EventArgs e)
        {
            var buttonEditar = sender as LinkButton;
            int codigo = Convert.ToInt32(buttonEditar.CommandArgument);
            Session["ID_TAREA_CIUDADANO"] = codigo;
            Response.Redirect("AgregarEditarTarea.aspx");
        }

        protected void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            var buttonEditar = sender as LinkButton;
            int codigo = Convert.ToInt32(buttonEditar.CommandArgument);
            Session["ELIMINAR_TAREA"] = codigo;
            Response.Redirect("EliminarTarea.aspx");
        }

       
    }
}