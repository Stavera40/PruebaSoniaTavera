using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;
using System.Data;
namespace PruebaTecnicaSonia
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = EmpleadoBI.ConsultarEmpleado(Convert.ToInt32(txt_Documento.Text));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                txt_tipoDoc.Text = dt.Rows[i]["TipoDocumento"].ToString();
                txt_NDocumento.Text = dt.Rows[i]["numerodocumento"].ToString();
                txt_Nombre.Text = dt.Rows[i]["Nombre"].ToString();
                txt_Contrato.Text = dt.Rows[i]["idcontrato"].ToString();
                txt_cargo.Text = dt.Rows[i]["Cargo"].ToString();
                txt_Arl.Text = dt.Rows[i]["ARL"].ToString();
                txt_fechaIni.Text = dt.Rows[i]["fechainicio"].ToString();
                txt_fechaFin.Text = dt.Rows[i]["fechafin"].ToString();
                txt_salario.Text = dt.Rows[i]["salario"].ToString();
            }
        }

        
    }
}