using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaEastview.Controller;
using SistemaEastview.Modelo;

namespace SistemaEastview.VistaTarea
{
    public partial class VerTareas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargaDropDia();
            }
        }

        public void CargaRepeaterVisualizaconTareas(int id_dia)
        {
            if (id_dia == 0)
            {
                rpTareas.DataSource = null;
                rpTareas.DataBind();
                rpTareas.Visible = false;
                lblMensajeDatos.Text = "Por favor, Seleccione un dia";
                lblMensajeDatos.Visible = true;
            }
            else
            {
                List<VisualizarTarea> lVistaTarea = new VisualizarTareaController().VisualizarTareasByDia(id_dia);

                if (lVistaTarea.Count == 0 || lVistaTarea == null)
                {
                    rpTareas.DataSource = null;
                    rpTareas.DataBind();
                    rpTareas.Visible = false;
                    lblMensajeDatos.Text = "No existe ninguna tarea en este dia";
                    lblMensajeDatos.Visible = true;
                }
                else
                {
                    rpTareas.DataSource = lVistaTarea;
                    rpTareas.DataBind();
                    rpTareas.Visible = true;
                    lblMensajeDatos.Visible = false;
                }


            }

        }

        protected void dpListaDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_dia = Convert.ToInt32(dpListaDia.SelectedValue);
            CargaRepeaterVisualizaconTareas(id_dia);
        }

        public void CargaDropDia()
        {
            dpListaDia.DataSource = new DiaTareaController().ListaDias();
            dpListaDia.DataTextField = "Nombre_Dia";
            dpListaDia.DataValueField = "Id_Dia";
            dpListaDia.DataBind();
            dpListaDia.Items.Insert(0, new ListItem("Seleccione el dia", "0"));
        }

    }
}