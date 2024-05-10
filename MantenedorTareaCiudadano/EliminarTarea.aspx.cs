using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaEastview.Modelo;
using SistemaEastview.Controller;

namespace SistemaEastview.MantenedorTareaCiudadano
{
    public partial class EliminarTarea : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["ELIMINAR_TAREA"] != null)
                {
                    int codigo = Convert.ToInt32(Session["ELIMINAR_TAREA"]);
                    TareaCiudadano obj_tarea_ciudadano = new TareaCiudadano();
                    TareaCiudadanoController operacion = new TareaCiudadanoController();
                    obj_tarea_ciudadano = operacion.BuscarDatosTareaCiudadanoById(codigo);

                    lblCiudadano.Text = obj_tarea_ciudadano.Nombre_Ciudadano;

                }
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListarTareaCiudadano.aspx");
        }

        protected void btnEliminarCiudadano_Click(object sender, EventArgs e)
        {
            if (Session["ELIMINAR_TAREA"] != null)
            {
                int codigo = Convert.ToInt32(Session["ELIMINAR_TAREA"]);
                TareaCiudadanoController operacion = new TareaCiudadanoController();
                operacion.EliminarTareaCiudadano(codigo);
                Response.Redirect("ListarTareaCiudadano.aspx");
            }
        }
    }
}