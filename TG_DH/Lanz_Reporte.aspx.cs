using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;
using System.Data.SqlClient;
using System.Data;



namespace DNP
{
    public partial class Lanz_Reporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                MultiView1.ActiveViewIndex = 0;
                CargarCombos();
                cargaProyectos();
            }
            
        }

        public void cargaProyectos()
        {
            string buscar = "TODO";

            if (txtBusqueda.Text != "")
                buscar = txtBusqueda.Text;

            clUtil oUtil = new clUtil();
            SqlCommand cmdWH = new SqlCommand();
            using (cmdWH)
            {
                cmdWH.Connection = oUtil.ADOS_DH;
                cmdWH.CommandType = CommandType.StoredProcedure;
                cmdWH.CommandText = "sp_ObtenerProyectos";
                cmdWH.Parameters.Add("@busqueda", SqlDbType.VarChar);
                cmdWH.Parameters["@busqueda"].Value = buscar;

                cmdWH.Parameters.Add("@archivo", SqlDbType.Bit);
                cmdWH.Parameters["@archivo"].Value = chArchivado.Checked;


                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdWH);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                dgPerfil.DataSource = dataSet.Tables[0].DefaultView;
                dgPerfil.DataBind();
                cmdWH.Connection.Close();
                oUtil = null;

                //dgPerfil.SelectedIndex = 0;
                dgPerfil.SelectedIndex = -1;
            }
        }
        private void CargarCombos()
        {
            cIdentificacion Ident = new cIdentificacion();
            string sSqlExp = "SELECT T1.NO_PROYECTO,CONCAT(T1.NO_PROYECTO,' -  ',T2.PRODUCTO_DES,' -  ', T3.NOMBRE) AS NOMBRE FROM dnp_Cabecera T1 INNER JOIN dnp_Producto T2 ON T1.NO_PROYECTO= T2.NO_PROYECTO INNER JOIN dnp_Clientes T3 ON T1.ID_CLIENTE = T3.ID_CLIENTE WHERE T1.ID_ESTATUS IN(1,2) ORDER BY T1.NO_PROYECTO DESC ";
           // Ident.CargarCombos(ref dpPerfiles, sSqlExp, "NO_PROYECTO", "NOMBRE");
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            cargaProyectos();
            //if (this.dpPerfiles.SelectedValue.ToString() != "SELECCIONE")
            //{
            //    string codigo = this.dpPerfiles.SelectedValue.ToString();
            //    muestraReporte(codigo);
            //}
            //else
            //{
            //    WebUtil.MostrarPopUp(ref pop, "POR FAVOR SELECCIONA UN PERFIL", "PERFIL", "PARA PODER CONTINUAR ES NECESARIO SELECCIONAR UN PERFIL");
            //}
        }

        public void muestraReporte(string codigo)
        {
            ReportViewer1.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Remote;
            //NetworkCredential myCred = new NetworkCredential("usistemas", "Carb0LinXtreme");
            CustomReportCredentials credentials = new CustomReportCredentials("usistemas", "Carb0LinXtreme", "WET-LINE");
            this.ReportViewer1.ServerReport.ReportServerCredentials = credentials;
            //ReportViewer1.ServerReport.ReportServerCredentials.NetworkCredentials = myCred;
            //ReportViewer1.ServerReport.ReportServerCredentials.NetworkCredentials = new ReportServerNetworkCredentials("", "");
            ReportViewer1.ServerReport.ReportServerUrl = new Uri("http://swl024/ReportServer");
            ReportViewer1.ServerReport.ReportPath = "/DH_Reports/DNP_REPORTE";
            ReportViewer1.ShowParameterPrompts = false;
            ReportViewer1.ShowPrintButton = true;

            Microsoft.Reporting.WebForms.ReportParameter[] reportParameterCollection = new Microsoft.Reporting.WebForms.ReportParameter[1];
            reportParameterCollection[0] = new Microsoft.Reporting.WebForms.ReportParameter();
            reportParameterCollection[0].Name = "CODIGO";
            reportParameterCollection[0].Values.Add(codigo);

            ReportViewer1.ServerReport.SetParameters(reportParameterCollection);
            ReportViewer1.ServerReport.Refresh();
            
        }

        protected void btnBusca_Click(object sender, EventArgs e)
        {
            cargaProyectos();
        }

        protected void dgPerfil_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "SELECT":
                    MultiView1.ActiveViewIndex = 1;
                    muestraReporte(e.Item.Cells[0].Text);
                    break;
            }
        }

        protected void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}