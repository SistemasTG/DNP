using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web.UI;
using System.Web;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.DirectoryServices;
using System.Web.Security;//FormsAuthenticationTicket
using System.Net;
using System.IO;
using System.Web.Configuration;
using System.Globalization;
using TG_DNP;

namespace DNP
{
    public partial class Lanzamientos : System.Web.UI.Page
    {
        string valorUSR = "";
        cIdentificacion clIdent = new cIdentificacion();
        string email_responsable, correojefe,perfil_name;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                MultiView1.ActiveViewIndex = 0;
                CargarCombos();
                string menu = Convert.ToString(Session["User"]);
                string quimico =Request.QueryString.Get("valorUSR");
                MuestraMenu(Session["Seccion"].ToString(), true);
                cargaProyectos();
                obtenerFirmas();
            }
        }
        public void MuestraMenu(string seccion, bool status)
        {

            txtobs.Enabled = status;
            if (seccion == "0")
            {
                seccion0(status);
            }
            else if (seccion == "1")
            {
                seccion1(status);
            } 
            else if (seccion == "2")
            {
                seccion2(status);
            } 
            else if (seccion == "3")
            {
                seccion3(status);
            }
            else if (seccion == "4")
            {
                seccion4(status);
            }
            else if (seccion == "5")
            {
                seccion4(status);
            }
            else if (seccion == "6")
            {
                seccion6(status);
            }
        }
        public void seccion0(bool status)
        {
            dpClientes.Enabled = status;
            txtnoti.Enabled = status;
            txtlanza.Enabled = status;
            txtnoti.Enabled = status;
            chpropia.Enabled = status;
            chmaquila.Enabled = status;
            txtProdDes.Enabled = status;
            txtCajasFab.Enabled = status;
            txtEan13.Enabled = status;
            txtEan14.Enabled = status;
            fuIProd.Enabled = status;
            fuILotificado.Enabled = status;
            fuICorrugado.Enabled = status;
            txtCodAdici.Enabled = status;
            btnVisualiza1.Enabled = status;
            btnVisualiza2.Enabled = status;
            btnVisualiza3.Enabled = status;
            btnBI1.Enabled = status;
            btnBI2.Enabled = status;
            btnBI3.Enabled = status;

            dpClientes.BorderColor = Color.Green;
            txtnoti.BorderColor = Color.Green;
            txtlanza.BorderColor = Color.Green;
            txtnoti.BorderColor = Color.Green;
            chpropia.BorderColor = Color.Green;
            chmaquila.BorderColor = Color.Green;
            txtProdDes.BorderColor = Color.Green;
            txtCajasFab.BorderColor = Color.Green;
            txtEan13.BorderColor = Color.Green;
            txtEan14.BorderColor = Color.Green;
            fuIProd.BorderColor = Color.Green;
            fuILotificado.BorderColor = Color.Green;
            fuICorrugado.BorderColor = Color.Green;
            txtCodAdici.BorderColor = Color.Green;
            btnVisualiza1.BorderColor = Color.Green;
            btnVisualiza2.BorderColor = Color.Green;
            btnVisualiza3.BorderColor = Color.Green;
            btnBI1.BorderColor = Color.Green;
            btnBI2.BorderColor = Color.Green;
            btnBI3.BorderColor = Color.Green;  

            txtCodCliente.Enabled = status;
            txtCodCliente.BorderColor = Color.Green;
            txtcodRoss.Enabled = status;
            txtcodRoss.BorderColor = Color.Green;
            txtRegSan.Enabled = status;
            txtRegSan.BorderColor = Color.Green;
            txtTipoTarima.Enabled = status;
            txtTipoTarima.BorderColor = Color.Green;
            txtPeso.Enabled = status;
            txtPeso.BorderColor = Color.Green;
            txtAlturaEstiba.Enabled = status;
            txtAlturaEstiba.BorderColor = Color.Green;

            txtCad.Enabled = status;
            txtFormula.Enabled = status;
            txtNeto.Enabled = status;
            txtElab.Enabled = status;
            txtDensi.Enabled = status;
            txtPH.Enabled = status;
            txtVisc.Enabled = status;
            txtText.Enabled = status;
            txtColor.Enabled = status;
            txtFrag.Enabled = status;
            txtFijacion.Enabled = status;
            txtOtros.Enabled = status;

            txtCad.BorderColor = Color.Green;
            txtFormula.BorderColor = Color.Green;
            txtNeto.BorderColor = Color.Green;
            txtElab.BorderColor = Color.Green;
            txtDensi.BorderColor = Color.Green;
            txtPH.BorderColor = Color.Green;
            txtVisc.BorderColor = Color.Green;
            txtText.BorderColor = Color.Green;
            txtColor.BorderColor = Color.Green;
            txtFrag.BorderColor = Color.Green;
            txtFijacion.BorderColor = Color.Green;
            txtOtros.BorderColor = Color.Green;

            txtEnvDes.Enabled = status;
            txtEnvDes.BorderColor = Color.Green;

            txtEnvCodigo.Enabled = status;
            txtEnvCodigo.BorderColor = Color.Green;


            txtEnvMat.Enabled = status;

            txtEnvColor.Enabled = status;

            txtUniCorr.Enabled = status;
            txtCorrCama.Enabled = status;
            txtCamasTarimas.Enabled = status;
            txtCajasTarimas.Enabled = status;
            fuILotificado.Enabled = status;
            btnVisualiza2.Enabled = status;

            txtEnvMat.BorderColor = Color.Green;

            txtEnvColor.BorderColor = Color.Green;

            txtUniCorr.BorderColor = Color.Green;
            txtCorrCama.BorderColor = Color.Green;
            txtCamasTarimas.BorderColor = Color.Green;
            txtCajasTarimas.BorderColor = Color.Green;
            fuILotificado.BorderColor = Color.Green;

            txtEspEquiTanq.BorderColor = Color.Green;
            txtEECap.BorderColor = Color.Green;
            txtCE.BorderColor = Color.Green;

        }
        public void seccion1(bool status)
        {
            txtCodCliente.Enabled = status;
            txtCodCliente.BorderColor = Color.Green;         
            txtcodRoss.Enabled = status;
            txtcodRoss.BorderColor = Color.Green;   
            txtRegSan.Enabled = status;
            txtRegSan.BorderColor = Color.Green;   
            txtTipoTarima.Enabled = status;
            txtTipoTarima.BorderColor = Color.Green;
            txtPeso.Enabled = status;
            txtPeso.BorderColor = Color.Green;   
            txtAlturaEstiba.Enabled = status;
            txtAlturaEstiba.BorderColor = Color.Green;   
        }
        public void seccion2(bool status)
        {
            txtCad.Enabled = status;
            txtFormula.Enabled = status;
            txtNeto.Enabled = status;
            txtElab.Enabled = status;
            txtDensi.Enabled = status;
            txtPH.Enabled = status;
            txtVisc.Enabled = status;
            txtText.Enabled = status;
            txtColor.Enabled = status;
            txtFrag.Enabled = status;
            txtFijacion.Enabled = status;
            txtOtros.Enabled = status;

            txtCad.BorderColor = Color.Green;
            txtFormula.BorderColor = Color.Green;
            txtNeto.BorderColor = Color.Green;
            txtElab.BorderColor = Color.Green;
            txtDensi.BorderColor = Color.Green;
            txtPH.BorderColor = Color.Green;
            txtVisc.BorderColor = Color.Green;
            txtText.BorderColor = Color.Green;
            txtColor.BorderColor = Color.Green;
            txtFrag.BorderColor = Color.Green;
            txtFijacion.BorderColor = Color.Green;
            txtOtros.BorderColor = Color.Green;


            fuICorrugado.Enabled = status;
            btnVisualiza3.Enabled = status;
            fuILotificado.Enabled = status;
            btnVisualiza2.Enabled = status;
            Button6.Enabled = status;
        }
        public void seccion3(bool status)
        {
            txtEnvDes.Enabled = status;            
            txtEnvDes.BorderColor = Color.Green;

            txtEnvCodigo.Enabled = status;
            txtEnvCodigo.BorderColor = Color.Green;
            
        }
        public void seccion4(bool status)
        {
            txtEnvMat.Enabled = status;

            txtEnvColor.Enabled = status;

            txtUniCorr.Enabled = status;
            txtCorrCama.Enabled = status;
            txtCamasTarimas.Enabled = status;
            txtCajasTarimas.Enabled = status;
            txtPeso.Enabled = status;
            txtAlturaEstiba.Enabled = status;
            txtPeso.BorderColor = Color.Green;
            fuILotificado.Enabled = status;
            btnVisualiza2.Enabled = status;
            txtEnvMat.BorderColor = Color.Green;

            txtEnvColor.BorderColor = Color.Green;

            txtUniCorr.BorderColor = Color.Green;
            txtCorrCama.BorderColor = Color.Green;
            txtCamasTarimas.BorderColor = Color.Green;
            txtCajasTarimas.BorderColor = Color.Green;
            fuILotificado.BorderColor = Color.Green;
            txtAlturaEstiba.BorderColor = Color.Green;   
        }
        public void seccion6(bool status)
        {
            fuICorrugado.Enabled = status;
            btnVisualiza3.Enabled = status;
            fuILotificado.Enabled = status;
            btnVisualiza2.Enabled = status;
            Button6.Enabled = status;
        }
        public void seccion5(bool status)
        {
            string usr = Session["User"].ToString();
            chventas.Enabled = false;
            if (usr == lblsol.Text)
            {
                chsolicita.Enabled = status;
            }
            if (usr == lbldnp.Text)
            {
                chdnp.Enabled = status;
            }
            if (usr  == lblcostos.Text)
            {
                chcostos.Enabled = status;
            }
            if (usr == lblid.Text)
            {
                chid.Enabled = status;
            }
            if (usr == lblRoss.Text)
            {
                cherp.Enabled = status;
            }
            if (usr == lblmat.Text)
            {
                chmat.Enabled = status;
            }
            if (usr == lbldir.Text)
            {
                chdir.Enabled = status;
            }
            if (usr == lblmat2.Text)
            {
                chmat2.Enabled = status;
            }
            if (usr == lblhac.Text)
            {
                chhac.Enabled = status;
            }
            if (usr == lblventas.Text)
            {
                chventas.Enabled = status;
            }
        }
         
        private void CargarCombos()
         {
             cIdentificacion Ident = new cIdentificacion();

             /*Clientes?
            */
             string sSqlDepto = "SELECT ID_CLIENTE, NOMBRE FROM dnp_Clientes ORDER BY NOMBRE";
             Ident.CargarCombos(ref dpClientes, sSqlDepto, "ID_CLIENTE", "NOMBRE");



             string sSqlEstatus = "SELECT ID_STATUS, DESCRIPCION FROM dnp_Estatus ORDER BY ID_STATUS";
             Ident.CargarCombos(ref dpEstatus, sSqlEstatus, "ID_STATUS", "DESCRIPCION");

            
        }

        public void obtenerCabecera()
        {
            DataTable datos = new DataTable();
            cIdentificacion clIdent = new cIdentificacion();
            string consulta = "SELECT T1.*,T2.NOMBRE FROM dnp_Cabecera T1 INNER JOIN dnp_Clientes T2 ON T1.ID_CLIENTE = T2.ID_CLIENTE WHERE NO_PROYECTO = '" + lblFolioProyecto.Text + "'";
            //datos = clIdent.obtenerObtenerCampos(consulta, txtNoQuimico.Text);
            string conex = ConfigurationManager.ConnectionStrings["CNXSTR"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(conex))
            {
                SqlCommand cmd = new SqlCommand(consulta, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(datos);
                if (datos.Rows.Count > 0 && datos != null)
                {
                    /*lblFolioProyecto.Text = datos.Rows[0].ItemArray[0].ToString();*/
                    dpClientes.ClearSelection();
                    dpClientes.Items.FindByText(datos.Rows[0].ItemArray[9].ToString()).Selected = true;
                    txtnoti.Text = datos.Rows[0].ItemArray[3].ToString();
                    txtlanza.Text = datos.Rows[0].ItemArray[4].ToString();
                    if (datos.Rows[0].ItemArray[5].ToString() == "MAQUILA")
                    {
                        chmaquila.Checked = true;
                    }
                    else if (datos.Rows[0].ItemArray[5].ToString() == "MARCA PROPIA")
                    {
                        chpropia.Checked = true;
                    }
                    txtCodCliente.Text = datos.Rows[0].ItemArray[6].ToString();
                }
                //else
                //{
                //    WebUtil.MostrarPopUp(ref pop, "Quimico no encontrado", "", "");
                //}

            }
            }
        public void obtenerFirmasVentas()
        {
            DataTable datos = new DataTable();
            cIdentificacion clIdent = new cIdentificacion();
            string consulta = "SELECT FIRMA FROM view_dnp_FirmasVentas WHERE NO_PROYECTO = '" + lblFolioProyecto.Text + "'";
            //datos = clIdent.obtenerObtenerCampos(consulta, txtNoQuimico.Text);
            string conex = ConfigurationManager.ConnectionStrings["CNXSTR"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(conex))
            {
                SqlCommand cmd = new SqlCommand(consulta, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(datos);
                if (datos.Rows.Count > 0 && datos != null)
                {
                    lblventas.Text = datos.Rows[0].ItemArray[0].ToString();
                }

            }
        }
        public void obtenerProducto()
        {
            DataTable datos = new DataTable();
            cIdentificacion clIdent = new cIdentificacion();
            string consulta = "SELECT * FROM dnp_Producto WHERE NO_PROYECTO = '" + lblFolioProyecto.Text + "'";
            //datos = clIdent.obtenerObtenerCampos(consulta, txtNoQuimico.Text);
            string conex = ConfigurationManager.ConnectionStrings["CNXSTR"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(conex))
            {
                SqlCommand cmd = new SqlCommand(consulta, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(datos);
                if (datos.Rows.Count > 0 && datos != null)
                {
                    txtProdDes.Text = datos.Rows[0].ItemArray[2].ToString();
                    txtcodRoss.Text = datos.Rows[0].ItemArray[3].ToString();
                    txtCajasFab.Text = datos.Rows[0].ItemArray[4].ToString();
                    txtRegSan.Text = datos.Rows[0].ItemArray[5].ToString();
                    txtCad.Text = datos.Rows[0].ItemArray[6].ToString();
                }
               
            }
        }

        public void obtener_ESP_FORM()
        {
            DataTable datos = new DataTable();
            cIdentificacion clIdent = new cIdentificacion();
            string consulta = "SELECT * FROM ESPECIFICACIONES_EQUI_FORM WHERE NUMERO_PROYECTO = '" + lblFolioProyecto.Text + "'";
            //datos = clIdent.obtenerObtenerCampos(consulta, txtNoQuimico.Text);
            string conex = ConfigurationManager.ConnectionStrings["CNXSTR"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(conex))
            {
                SqlCommand cmd = new SqlCommand(consulta, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(datos);
                if (datos.Rows.Count > 0 && datos != null)
                {
                    txtEspEquiTanq.Text = datos.Rows[0].ItemArray[2].ToString();
                    txtEECap.Text = datos.Rows[0].ItemArray[3].ToString();                   
                }

            }
        }


        public void obtener_Esp_Equip_Env()
        {
            DataTable datos = new DataTable();
            cIdentificacion clIdent = new cIdentificacion();
            string consulta = "SELECT * FROM ESPECIFICACIONES_CENT_ENV WHERE NUMERO_PROYECTO = '" + lblFolioProyecto.Text + "'";
            //datos = clIdent.obtenerObtenerCampos(consulta, txtNoQuimico.Text);
            string conex = ConfigurationManager.ConnectionStrings["CNXSTR"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(conex))
            {
                SqlCommand cmd = new SqlCommand(consulta, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(datos);
                if (datos.Rows.Count > 0 && datos != null)
                {
                    txtCE.Text = datos.Rows[0].ItemArray[2].ToString();                  
                }

            }

        }

        public void obtenerImagenes()
        {
            DataTable datos = new DataTable();
            cIdentificacion clIdent = new cIdentificacion();
            string consulta = "SELECT * FROM dnp_Imagenes WHERE NO_PROYECTO = '" + lblFolioProyecto.Text + "'";
            //datos = clIdent.obtenerObtenerCampos(consulta, txtNoQuimico.Text);
            string conex = ConfigurationManager.ConnectionStrings["CNXSTR"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(conex))
            {
                SqlCommand cmd = new SqlCommand(consulta, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(datos);
                if (datos.Rows.Count > 0 && datos != null)
                {
                    lblproducto.Text = datos.Rows[0].ItemArray[2].ToString();
                    lbllotificado.Text = datos.Rows[0].ItemArray[3].ToString();
                    lblcorrugado.Text = datos.Rows[0].ItemArray[4].ToString();

                    imgProd.ImageUrl = ("../Files/" + lblproducto.Text);
                    imgLotificado.ImageUrl = ("../Files/" + lbllotificado.Text);
                    imgCorrugado.ImageUrl = ("../Files/" + lblcorrugado.Text);
                }

            }
        }
        public void obtenerFisico()
        {
            DataTable datos = new DataTable();
            cIdentificacion clIdent = new cIdentificacion();
            string consulta = "SELECT * FROM dnp_Fisicoquimicas WHERE NO_PROYECTO = '" + lblFolioProyecto.Text + "'";
            //datos = clIdent.obtenerObtenerCampos(consulta, txtNoQuimico.Text);
            string conex = ConfigurationManager.ConnectionStrings["CNXSTR"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(conex))
            {
                SqlCommand cmd = new SqlCommand(consulta, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(datos);
                if (datos.Rows.Count > 0 && datos != null)
                {
                    txtFormula.Text = datos.Rows[0].ItemArray[2].ToString();
                    txtNeto.Text = datos.Rows[0].ItemArray[3].ToString();
                    txtElab.Text = datos.Rows[0].ItemArray[4].ToString();
                    txtDensi.Text = datos.Rows[0].ItemArray[5].ToString();
                    txtPH.Text = datos.Rows[0].ItemArray[6].ToString();
                    txtVisc.Text = datos.Rows[0].ItemArray[7].ToString();
                    txtText.Text = datos.Rows[0].ItemArray[8].ToString();
                }
                //else
                //{
                //    WebUtil.MostrarPopUp(ref pop, "Quimico no encontrado", "", "");
                //}

            }
        }

        public void obtenerSenso()
        {
            DataTable datos = new DataTable();
            cIdentificacion clIdent = new cIdentificacion();
            string consulta = "SELECT * FROM dnp_Sensoriales WHERE NO_PROYECTO = '" + lblFolioProyecto.Text + "'";
            //datos = clIdent.obtenerObtenerCampos(consulta, txtNoQuimico.Text);
            string conex = ConfigurationManager.ConnectionStrings["CNXSTR"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(conex))
            {
                SqlCommand cmd = new SqlCommand(consulta, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(datos);
                if (datos.Rows.Count > 0 && datos != null)
                {
                    txtColor.Text = datos.Rows[0].ItemArray[2].ToString();
                    txtFrag.Text = datos.Rows[0].ItemArray[3].ToString();
                    txtFijacion.Text = datos.Rows[0].ItemArray[4].ToString();
                    txtOtros.Text = datos.Rows[0].ItemArray[5].ToString();
                    //else
                    //{
                    //    WebUtil.MostrarPopUp(ref pop, "Quimico no encontrado", "", "");
                    //}

                }
            }
        }
        public void obtenerObs()
        {
            DataTable datos = new DataTable();
            cIdentificacion clIdent = new cIdentificacion();
            string consulta = "SELECT * FROM dnp_Obs WHERE NO_PROYECTO = '" + lblFolioProyecto.Text + "'";
            //datos = clIdent.obtenerObtenerCampos(consulta, txtNoQuimico.Text);
            string conex = ConfigurationManager.ConnectionStrings["CNXSTR"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(conex))
            {
                SqlCommand cmd = new SqlCommand(consulta, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(datos);
                if (datos.Rows.Count > 0 && datos != null)
                {
                    txtobs.Text = datos.Rows[0].ItemArray[2].ToString();

                }
            }
        }
        public bool obtenerFirmasProyecto(string USR,int columna)
        {
            bool status=false;
            DataTable datos = new DataTable();
            cIdentificacion clIdent = new cIdentificacion();
            string consulta = "SELECT * FROM dnp_Proyecto_Firma WHERE NO_PROYECTO = '" + lblFolioProyecto.Text + "'";
            //datos = clIdent.obtenerObtenerCampos(consulta, txtNoQuimico.Text);
            string conex = ConfigurationManager.ConnectionStrings["CNXSTR"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(conex))
            {
                SqlCommand cmd = new SqlCommand(consulta, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(datos);
                if (datos.Rows.Count > 0 && datos != null)
                {
                    if (datos.Rows[0].ItemArray[columna].ToString()!="")
                    status =true;

                }
            }
            return status;
        }
        public void obtenerCodigos()
        {
            DataTable datos = new DataTable();
            cIdentificacion clIdent = new cIdentificacion();
            string consulta = "SELECT * FROM dnp_Codigo_barras WHERE NO_PROYECTO = '" + lblFolioProyecto.Text + "'";
            //datos = clIdent.obtenerObtenerCampos(consulta, txtNoQuimico.Text);
            string conex = ConfigurationManager.ConnectionStrings["CNXSTR"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(conex))
            {
                SqlCommand cmd = new SqlCommand(consulta, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(datos);
                if (datos.Rows.Count > 0 && datos != null)
                {
                    txtEan13.Text = datos.Rows[0].ItemArray[2].ToString();
                    txtEan14.Text = datos.Rows[0].ItemArray[3].ToString();
                    txtCodAdici.Text = datos.Rows[0].ItemArray[4].ToString();
                    //else
                    //{
                    //    WebUtil.MostrarPopUp(ref pop, "Quimico no encontrado", "", "");
                    //}

                }
            }
        }
        public void obtenerEmbalaje()
        {
            DataTable datos = new DataTable();
            cIdentificacion clIdent = new cIdentificacion();
            string consulta = "SELECT * FROM dnp_Embalaje WHERE NO_PROYECTO = '" + lblFolioProyecto.Text + "'";
            //datos = clIdent.obtenerObtenerCampos(consulta, txtNoQuimico.Text);
            string conex = ConfigurationManager.ConnectionStrings["CNXSTR"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(conex))
            {
                SqlCommand cmd = new SqlCommand(consulta, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(datos);
                if (datos.Rows.Count > 0 && datos != null)
                {
                    txtUniCorr.Text = datos.Rows[0].ItemArray[2].ToString();
                    txtCorrCama.Text = datos.Rows[0].ItemArray[3].ToString();
                    txtCamasTarimas.Text = datos.Rows[0].ItemArray[4].ToString();
                    txtCajasTarimas.Text = datos.Rows[0].ItemArray[5].ToString();
                    txtTipoTarima.Text = datos.Rows[0].ItemArray[6].ToString();
                    txtAlturaEstiba.Text = datos.Rows[0].ItemArray[7].ToString();
                    txtPeso.Text = datos.Rows[0].ItemArray[9].ToString();
                    //else
                    //{
                    //    WebUtil.MostrarPopUp(ref pop, "Quimico no encontrado", "", "");
                    //}

                }
            }
        }

        public void obtenerFirmas()
        {
            DataTable datos = new DataTable();
            cIdentificacion clIdent = new cIdentificacion();
            string consulta = "SELECT * FROM dnp_Firma";
            //datos = clIdent.obtenerObtenerCampos(consulta, txtNoQuimico.Text);
            string conex = ConfigurationManager.ConnectionStrings["CNXSTR"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(conex))
            {
                SqlCommand cmd = new SqlCommand(consulta, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(datos);
                if (datos.Rows.Count > 0 && datos != null)
                {
                    for (int i = 0; i < datos.Rows.Count; i++)
                    {
                        if (datos.Rows[i].ItemArray[2].ToString() == "SOLICITÓ")
                        {
                            lblsol.Text = datos.Rows[i].ItemArray[1].ToString();
                        }
                        else if (datos.Rows[i].ItemArray[2].ToString() == "DNP")
                        {
                            lbldnp.Text = datos.Rows[i].ItemArray[1].ToString();
                        } 
                        else if (datos.Rows[i].ItemArray[2].ToString() == "COSTOS")
                        {
                            lblcostos.Text = datos.Rows[i].ItemArray[1].ToString();
                        }
                        else if (datos.Rows[i].ItemArray[2].ToString() == "I&D")
                        {
                            lblid.Text = datos.Rows[i].ItemArray[1].ToString();
                        }
                        else if (datos.Rows[i].ItemArray[2].ToString() == "ROSS-ERP")
                        {
                            lblRoss.Text = datos.Rows[i].ItemArray[1].ToString();
                        }
                        else if (datos.Rows[i].ItemArray[2].ToString() == "PRODUCCION")
                        {
                            lblmat.Text = datos.Rows[i].ItemArray[1].ToString();
                        }
                        else if (datos.Rows[i].ItemArray[2].ToString() == "DPLANTA")
                        {
                            lbldir.Text = datos.Rows[i].ItemArray[1].ToString();
                        }
                        else if (datos.Rows[i].ItemArray[2].ToString() == "CALIDAD")
                        {
                            lblmat2.Text = datos.Rows[i].ItemArray[1].ToString();
                        }
                        else if (datos.Rows[i].ItemArray[2].ToString() == "HACCP")
                        {
                            lblhac.Text = datos.Rows[i].ItemArray[1].ToString();
                        }
                    }

                    for (int i = 0; i < datos.Rows.Count; i++)
                    {
                        string usr = Session["User"].ToString();

                        if (datos.Rows[i].ItemArray[2].ToString() == "SOLICITÓ" &&  datos.Rows[i].ItemArray[1].ToString() == usr)
                        {
                            lblsol.Text = datos.Rows[i].ItemArray[1].ToString();
                        }
                        else if (datos.Rows[i].ItemArray[2].ToString() == "DNP" && datos.Rows[i].ItemArray[1].ToString() == usr)
                        {
                            lbldnp.Text = datos.Rows[i].ItemArray[1].ToString();
                        }
                        else if (datos.Rows[i].ItemArray[2].ToString() == "COSTOS" &&  datos.Rows[i].ItemArray[1].ToString() == usr)
                        {
                            lblcostos.Text = datos.Rows[i].ItemArray[1].ToString();
                        }
                        else if (datos.Rows[i].ItemArray[2].ToString() == "I&D" &&  datos.Rows[i].ItemArray[1].ToString() == usr)
                        {
                            lblid.Text = datos.Rows[i].ItemArray[1].ToString();
                        }
                        else if (datos.Rows[i].ItemArray[2].ToString() == "ROSS-ERP" &&  datos.Rows[i].ItemArray[1].ToString() == usr)
                        {
                            lblRoss.Text = datos.Rows[i].ItemArray[1].ToString();
                        }
                        else if (datos.Rows[i].ItemArray[2].ToString() == "PRODUCCION" &&  datos.Rows[i].ItemArray[1].ToString() == usr)
                        {
                            lblmat.Text = datos.Rows[i].ItemArray[1].ToString();
                        }
                        else if (datos.Rows[i].ItemArray[2].ToString() == "DPLANTA" &&  datos.Rows[i].ItemArray[1].ToString() == usr)
                        {
                            lbldir.Text = datos.Rows[i].ItemArray[1].ToString();
                        }
                        else if (datos.Rows[i].ItemArray[2].ToString() == "CALIDAD" &&  datos.Rows[i].ItemArray[1].ToString() == usr)
                        {
                            lblmat2.Text = datos.Rows[i].ItemArray[1].ToString();
                        }
                        else if (datos.Rows[i].ItemArray[2].ToString() == "HACCP" && datos.Rows[i].ItemArray[1].ToString() == usr)
                        {
                            lblhac.Text = datos.Rows[i].ItemArray[1].ToString();
                        }
                    }
                }
            }
        }
        public void obtenerEmpaque(string mat)
        {
            DataTable datos = new DataTable();
            cIdentificacion clIdent = new cIdentificacion();
            string consulta = "SELECT * FROM dnp_Empaque WHERE NO_PROYECTO = '" + lblFolioProyecto.Text + "' AND MATERIAL = '"+mat+"'";
            //datos = clIdent.obtenerObtenerCampos(consulta, txtNoQuimico.Text);
            string conex = ConfigurationManager.ConnectionStrings["CNXSTR"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(conex))
            {
                SqlCommand cmd = new SqlCommand(consulta, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(datos);
                if (datos.Rows.Count > 0 && datos != null)
                {
                    if (mat == "ENVASE")
                    {
                        txtEnvDes.Text = datos.Rows[0].ItemArray[3].ToString();
                        txtEnvMat.Text = datos.Rows[0].ItemArray[4].ToString();
                        txtEnvColor.Text = datos.Rows[0].ItemArray[5].ToString();
                        txtEnvCodigo.Text = datos.Rows[0].ItemArray[6].ToString();
                    }                  
                    
                }
            }
        }
           
      
       
        public void InsertaDatos(string sSql)
        {
            clUtil oUtil = new clUtil();
                SqlConnection cnx = oUtil.ADOS_DH;
                SqlTransaction trx = cnx.BeginTransaction();
                try
                {
                    //string sSql = "INSERT INTO dh_PerfilCodigos (CodigoPerfil, Descripcion, IdDepto,Perfil,IdPuesto)" +
                    // "VALUES('" + txtCodigo0.Text + "'," + "'" + txtDesPerf1.Text.ToUpper() + "'" + "," + "" + dpDepto.SelectedValue.ToString().Trim() +",'N','" + dpPuesto.SelectedValue.ToString().Trim()+ "')";

                    oUtil.cmdWH.CommandType = CommandType.Text;
                    oUtil.cmdWH.CommandText = sSql;
                    oUtil.cmdWH.Transaction = trx;
                    oUtil.cmdWH.ExecuteNonQuery();
                    sSql = "SELECT @@IDENTITY";
                    oUtil.cmdWH.CommandType = CommandType.Text;
                    oUtil.cmdWH.CommandText = sSql;
                    oUtil.cmdWH.Transaction = trx;
                    trx.Commit();
                }
                catch (Exception ex)
                {
                    trx.Dispose();
                }
                finally
                {
                    trx.Dispose();
                    cnx.Close();
                    cnx.Dispose();                 
                    //dpPerfiles.SelectedIndex = -1;
                }
            
            }
        public bool ActualizaProducto()
        {
            bool Str = true;
            if (lblFolioProyecto.Text == "NUEVO")
            {
                ActualizaCabecera();    
            }
            else
            {
               

                clUtil oUtil = new clUtil();
                oUtil.cmdWH.CommandType = CommandType.StoredProcedure;

                oUtil.cmdWH.CommandText = "sp_ActualizaProducto";
                oUtil.cmdWH.Parameters.Add("@CodProy", SqlDbType.VarChar);
                oUtil.cmdWH.Parameters["@CodProy"].Value = lblFolioProyecto.Text;

                oUtil.cmdWH.Parameters.Add("@Producto", SqlDbType.VarChar);
                oUtil.cmdWH.Parameters["@Producto"].Value = txtProdDes.Text;

                oUtil.cmdWH.Parameters.Add("@CodRoss", SqlDbType.VarChar);
                oUtil.cmdWH.Parameters["@CodRoss"].Value = txtcodRoss.Text;

                oUtil.cmdWH.Parameters.Add("@CajasFab", SqlDbType.VarChar);
                oUtil.cmdWH.Parameters["@CajasFab"].Value = txtCajasFab.Text;

                oUtil.cmdWH.Parameters.Add("@RegSan", SqlDbType.VarChar);
                oUtil.cmdWH.Parameters["@RegSan"].Value = txtRegSan.Text;

                oUtil.cmdWH.Parameters.Add("@Cad", SqlDbType.VarChar);
                oUtil.cmdWH.Parameters["@Cad"].Value = txtCad.Text;

                //oUtil.cmdWH.ExecuteReader();

                //Envia notificacion de correo

                bool proc = Convert.ToBoolean(oUtil.cmdWH.ExecuteNonQuery());

                if (proc)
                {
                    Str = true;
                    WebUtil.MostrarPopUp(ref pop, "Guardado", "", "");
                    //limpia();
                }
                else
                {
                    Str = false;
                }
            }
                return Str;
            
        }
        public bool ActualizaCabecera()
        {
            bool Str = true;

            clUtil oUtil = new clUtil();
            oUtil.cmdWH.CommandType = CommandType.StoredProcedure;


                oUtil.cmdWH.CommandText = "sp_ActualizaCabecera";
                oUtil.cmdWH.Parameters.Add("@CodProy", SqlDbType.VarChar);
                oUtil.cmdWH.Parameters["@CodProy"].Value =lblFolioProyecto.Text;

                oUtil.cmdWH.Parameters.Add("@Cliente", SqlDbType.Int);
                oUtil.cmdWH.Parameters["@Cliente"].Value = dpClientes.SelectedValue;


                oUtil.cmdWH.Parameters.Add("@fnoti", SqlDbType.VarChar);                
                oUtil.cmdWH.Parameters["@fnoti"].Value = txtnoti.Text;

                oUtil.cmdWH.Parameters.Add("@flanza", SqlDbType.VarChar);
                oUtil.cmdWH.Parameters["@flanza"].Value =txtlanza.Text;

                if (chpropia.Checked)
                {
                    oUtil.cmdWH.Parameters.Add("@tipoProy", SqlDbType.VarChar);
                    oUtil.cmdWH.Parameters["@tipoProy"].Value = "MARCA PROPIA";
                }
                else if (chmaquila.Checked)
                {
                    oUtil.cmdWH.Parameters.Add("@tipoProy", SqlDbType.VarChar);
                    oUtil.cmdWH.Parameters["@tipoProy"].Value = "MAQUILA";
                }
                else
                {
                    oUtil.cmdWH.Parameters.Add("@tipoProy", SqlDbType.VarChar);
                    oUtil.cmdWH.Parameters["@tipoProy"].Value = "MAQUILA";
                }


                oUtil.cmdWH.Parameters.Add("@CodCliente", SqlDbType.VarChar);
                oUtil.cmdWH.Parameters["@CodCliente"].Value = txtCodCliente.Text;

             
            //Envia notificacion de correo

            bool proc = Convert.ToBoolean(oUtil.cmdWH.ExecuteNonQuery());

            if (proc)
            {
                Str = true;
                WebUtil.MostrarPopUp(ref pop, "Guardado", "", "");
                //limpiarDNP();
                //limpia();
            }
            else
            {
                Str = false;
            }
            return Str;
        }
        public bool ActualizaFisico()
        {
            bool Str = true;

            clUtil oUtil = new clUtil();
            oUtil.cmdWH.CommandType = CommandType.StoredProcedure;


            oUtil.cmdWH.CommandText = "sp_ActualizaFisico";
            oUtil.cmdWH.Parameters.Add("@CodProy", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@CodProy"].Value = lblFolioProyecto.Text;

            oUtil.cmdWH.Parameters.Add("@formula", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@formula"].Value = txtFormula.Text;

            oUtil.cmdWH.Parameters.Add("@contenido", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@contenido"].Value = txtNeto.Text;

            oUtil.cmdWH.Parameters.Add("@codRossElab", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@codRossElab"].Value = txtElab.Text;

            oUtil.cmdWH.Parameters.Add("@densidad", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@densidad"].Value = txtDensi.Text;
            
            oUtil.cmdWH.Parameters.Add("@ph", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@ph"].Value = txtPH.Text;

            oUtil.cmdWH.Parameters.Add("@viscocidad", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@viscocidad"].Value = txtVisc.Text;

            oUtil.cmdWH.Parameters.Add("@textura", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@textura"].Value = txtText.Text;
            //Envia notificacion de correo

            bool proc = Convert.ToBoolean(oUtil.cmdWH.ExecuteNonQuery());

            if (proc)
            {
                Str = true;
                WebUtil.MostrarPopUp(ref pop, "Guardado", "", "");
                //limpia();
            }
            else
            {
                Str = false;
            }
            return Str;
        }
        public bool ActualizaSenso()
        {
            bool Str = true;

            clUtil oUtil = new clUtil();
            oUtil.cmdWH.CommandType = CommandType.StoredProcedure;


            oUtil.cmdWH.CommandText = "sp_ActualizaSensoriales";
            oUtil.cmdWH.Parameters.Add("@CodProy", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@CodProy"].Value = lblFolioProyecto.Text;

            oUtil.cmdWH.Parameters.Add("@color", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@color"].Value = txtColor.Text;

            oUtil.cmdWH.Parameters.Add("@fragancia", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@fragancia"].Value = txtFrag.Text;

            oUtil.cmdWH.Parameters.Add("@fijacion", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@fijacion"].Value = txtFijacion.Text;

            oUtil.cmdWH.Parameters.Add("@otros", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@otros"].Value = txtOtros.Text;

            
            //Envia notificacion de correo

            bool proc = Convert.ToBoolean(oUtil.cmdWH.ExecuteNonQuery());

            if (proc)
            {
                Str = true;
                WebUtil.MostrarPopUp(ref pop, "Guardado", "", "");
                limpia();
            }
            else
            {
                Str = false;
            }
            return Str;
        }
        public bool ActualizaFirma(int estatus)
        {
            bool Str = true;

            clUtil oUtil = new clUtil();
            oUtil.cmdWH.CommandType = CommandType.StoredProcedure;


            oUtil.cmdWH.CommandText = "sp_ActualizaFirma";
            oUtil.cmdWH.Parameters.Add("@CodProy", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@CodProy"].Value = lblFolioProyecto.Text;

            //SOLICITA
            if (chsolicita.Checked)
            {
                oUtil.cmdWH.Parameters.Add("@SOL", SqlDbType.VarChar);
                oUtil.cmdWH.Parameters["@SOL"].Value = lblsol.Text;
            }
            else
            {
                oUtil.cmdWH.Parameters.Add("@SOL", SqlDbType.VarChar);
                oUtil.cmdWH.Parameters["@SOL"].Value = "";
            }
            //DNP
            if (chdnp.Checked)
            {
                oUtil.cmdWH.Parameters.Add("@DNP", SqlDbType.VarChar);
                oUtil.cmdWH.Parameters["@DNP"].Value = lbldnp.Text;
            }
            else
            {
                oUtil.cmdWH.Parameters.Add("@DNP", SqlDbType.VarChar);
                oUtil.cmdWH.Parameters["@DNP"].Value = "";
            }
            //COSTOS
            if (chcostos.Checked)
            {
                oUtil.cmdWH.Parameters.Add("@COSTOS", SqlDbType.VarChar);
                oUtil.cmdWH.Parameters["@COSTOS"].Value = lblcostos.Text;
            }
            else
            {
                oUtil.cmdWH.Parameters.Add("@COSTOS", SqlDbType.VarChar);
                oUtil.cmdWH.Parameters["@COSTOS"].Value = "";
            }

            //INNOVACION
            if (chid.Checked)
            {
                oUtil.cmdWH.Parameters.Add("@INV", SqlDbType.VarChar);
                oUtil.cmdWH.Parameters["@INV"].Value = lblid.Text;
            }
            else
            {
                oUtil.cmdWH.Parameters.Add("@INV", SqlDbType.VarChar);
                oUtil.cmdWH.Parameters["@INV"].Value = "";
            }
            //ROSS
            if (cherp.Checked)
            {
                oUtil.cmdWH.Parameters.Add("@ROSS", SqlDbType.VarChar);
                oUtil.cmdWH.Parameters["@ROSS"].Value = lblRoss.Text;
            }
            else
            {
                oUtil.cmdWH.Parameters.Add("@ROSS", SqlDbType.VarChar);
                oUtil.cmdWH.Parameters["@ROSS"].Value = "";
            }

            //MAT
            if (chmat.Checked)
            {
                oUtil.cmdWH.Parameters.Add("@MAT", SqlDbType.VarChar);
                oUtil.cmdWH.Parameters["@MAT"].Value = lblmat.Text;
            }
            else
            {
                oUtil.cmdWH.Parameters.Add("@MAT", SqlDbType.VarChar);
                oUtil.cmdWH.Parameters["@MAT"].Value = "";
            }

            //CAL
            if (chmat2.Checked)
            {
                oUtil.cmdWH.Parameters.Add("@CAL", SqlDbType.VarChar);
                oUtil.cmdWH.Parameters["@CAL"].Value = lblmat2.Text;
            }
            else
            {
                oUtil.cmdWH.Parameters.Add("@CAL", SqlDbType.VarChar);
                oUtil.cmdWH.Parameters["@CAL"].Value = "";
            }

            //DIR
            if (chdir.Checked)
            {
                oUtil.cmdWH.Parameters.Add("@PLANTA", SqlDbType.VarChar);
                oUtil.cmdWH.Parameters["@PLANTA"].Value = lbldir.Text;
            }
            else
            {
                oUtil.cmdWH.Parameters.Add("@PLANTA", SqlDbType.VarChar);
                oUtil.cmdWH.Parameters["@PLANTA"].Value = "";
            }


            //HAC
            if (chhac.Checked)
            {
                oUtil.cmdWH.Parameters.Add("@HAC", SqlDbType.VarChar);
                oUtil.cmdWH.Parameters["@HAC"].Value = lblhac.Text;
            }
            else
            {
                oUtil.cmdWH.Parameters.Add("@HAC", SqlDbType.VarChar);
                oUtil.cmdWH.Parameters["@HAC"].Value = "";
            }

            //HAC
            if (chventas.Checked)
            {
                oUtil.cmdWH.Parameters.Add("@VENTAS", SqlDbType.VarChar);
                oUtil.cmdWH.Parameters["@VENTAS"].Value = lblventas.Text;
            }
            else
            {
                oUtil.cmdWH.Parameters.Add("@VENTAS", SqlDbType.VarChar);
                oUtil.cmdWH.Parameters["@VENTAS"].Value = "";
            }

            oUtil.cmdWH.Parameters.Add("@estatus", SqlDbType.Bit);
            oUtil.cmdWH.Parameters["@estatus"].Value = estatus;

            bool proc = Convert.ToBoolean(oUtil.cmdWH.ExecuteNonQuery());

            if (proc)
            {
                Str = true;
                WebUtil.MostrarPopUp(ref pop, "Proyecto firmado", "", "");
                limpia();
            }
            else
            {
                Str = false;
            }
            return Str;
        }
        public bool ActualizaObs()
        {
            bool Str = true;

            clUtil oUtil = new clUtil();
            oUtil.cmdWH.CommandType = CommandType.StoredProcedure;


            oUtil.cmdWH.CommandText = "sp_ActualizaObs";
            oUtil.cmdWH.Parameters.Add("@CodProy", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@CodProy"].Value = lblFolioProyecto.Text;

            oUtil.cmdWH.Parameters.Add("@obs", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@obs"].Value = txtobs.Text;

            bool proc = Convert.ToBoolean(oUtil.cmdWH.ExecuteNonQuery());

            if (proc)
            {
                Str = true;
                WebUtil.MostrarPopUp(ref pop, "Guardado", "", "");
                limpia();
            }
            else
            {
                Str = false;
            }
            return Str;
        }
        public bool ActualizaEmpque(string mat, string desc, string mat2, string color, string codigo)
        {
            bool Str = true;

            clUtil oUtil = new clUtil();
            oUtil.cmdWH.CommandType = CommandType.StoredProcedure;


            oUtil.cmdWH.CommandText = "sp_ActualizaEmpaque";
            oUtil.cmdWH.Parameters.Add("@CodProy", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@CodProy"].Value = lblFolioProyecto.Text;

            oUtil.cmdWH.Parameters.Add("@material", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@material"].Value = mat;

            oUtil.cmdWH.Parameters.Add("@desc", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@desc"].Value =desc;

            oUtil.cmdWH.Parameters.Add("@material2", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@material2"].Value = mat2;

            oUtil.cmdWH.Parameters.Add("@color", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@color"].Value = color;

            oUtil.cmdWH.Parameters.Add("@codigo", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@codigo"].Value = codigo;
            //Envia notificacion de correo

            bool proc = Convert.ToBoolean(oUtil.cmdWH.ExecuteNonQuery());

            if (proc)
            {
                Str = true;
                WebUtil.MostrarPopUp(ref pop, "Guardado", "", "");
                limpia();
            }
            else
            {
                Str = false;
            }
            return Str;
        }
        public bool ActualizaCodigos()
        {
            bool Str = true;

            clUtil oUtil = new clUtil();
            oUtil.cmdWH.CommandType = CommandType.StoredProcedure;


            oUtil.cmdWH.CommandText = "sp_ActualizaCodigos";
            oUtil.cmdWH.Parameters.Add("@CodProy", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@CodProy"].Value = lblFolioProyecto.Text;

            oUtil.cmdWH.Parameters.Add("@ean13", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@ean13"].Value = txtEan13.Text;

            oUtil.cmdWH.Parameters.Add("@ean14", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@ean14"].Value = txtEan14.Text;

            oUtil.cmdWH.Parameters.Add("@codAdic", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@codAdic"].Value = txtCodAdici.Text;

            //Envia notificacion de correo

            bool proc = Convert.ToBoolean(oUtil.cmdWH.ExecuteNonQuery());

            if (proc)
            {
                Str = true;
                WebUtil.MostrarPopUp(ref pop, "Guardado", "", "");
                limpia();
            }
            else
            {
                Str = false;
            }
            return Str;
        }
        public bool ActualizaEmbalaje()
        {
            bool Str = true;

            clUtil oUtil = new clUtil();
            oUtil.cmdWH.CommandType = CommandType.StoredProcedure;


            oUtil.cmdWH.CommandText = "sp_ActualizaEmbalaje";
            oUtil.cmdWH.Parameters.Add("@CodProy", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@CodProy"].Value = lblFolioProyecto.Text;

            oUtil.cmdWH.Parameters.Add("@uni", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@uni"].Value = txtUniCorr.Text;

            oUtil.cmdWH.Parameters.Add("@corr", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@corr"].Value = txtCorrCama.Text;

            oUtil.cmdWH.Parameters.Add("@cama", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@cama"].Value = txtCamasTarimas.Text;

            oUtil.cmdWH.Parameters.Add("@cajas", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@cajas"].Value = txtCajasTarimas.Text;

            oUtil.cmdWH.Parameters.Add("@tarima", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@tarima"].Value = txtTipoTarima.Text;

            oUtil.cmdWH.Parameters.Add("@altura", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@altura"].Value = txtAlturaEstiba.Text;

            oUtil.cmdWH.Parameters.Add("@peso", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@peso"].Value = txtPeso.Text;
          
            //Envia notificacion de correo
            bool proc = Convert.ToBoolean(oUtil.cmdWH.ExecuteNonQuery());

            if (proc)
            {
                Str = true;
                WebUtil.MostrarPopUp(ref pop, "Guardado", "", "");
                limpia();
            }
            else
            {
                Str = false;
            }
            return Str;
        }
        public bool ActualizaImagenes()
        {
            bool Str = true;

            clUtil oUtil = new clUtil();
            oUtil.cmdWH.CommandType = CommandType.StoredProcedure;


            oUtil.cmdWH.CommandText = "sp_ActualizaImagenes";
            oUtil.cmdWH.Parameters.Add("@CodProy", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@CodProy"].Value = lblFolioProyecto.Text;

            oUtil.cmdWH.Parameters.Add("@prod", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@prod"].Value = lblproducto.Text;

            oUtil.cmdWH.Parameters.Add("@lot", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@lot"].Value = lbllotificado.Text;

            oUtil.cmdWH.Parameters.Add("@corr", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@corr"].Value = lblcorrugado.Text;

       
            //Envia notificacion de correo

            bool proc = Convert.ToBoolean(oUtil.cmdWH.ExecuteNonQuery());

            if (proc)
            {
                Str = true;
                WebUtil.MostrarPopUp(ref pop, "Guardado", "", "");
                limpia();
            }
            else
            {
                Str = false;
            }
            return Str;
        }
       
        public void FiltraProyectos()
        {
            string filtro = DropFiltro.SelectedValue;
            if( DropFiltro.SelectedValue != "")
            {
                clUtil oUtil = new clUtil();
                SqlCommand cmdWH = new SqlCommand();
                using (cmdWH)
                {
                    cmdWH.Connection = oUtil.ADOS_DH;
                    cmdWH.CommandType = CommandType.StoredProcedure;
                    cmdWH.CommandText = "sp_FiltraProyectos";
                    cmdWH.Parameters.Add("@filtro", SqlDbType.VarChar);
                    cmdWH.Parameters["@filtro"].Value = filtro;

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

      

        private void EnviarCorreoP(string  tipo)
        {
            clUtil oUtil = new clUtil();
            SqlConnection cnx = oUtil.ADOS_DH;
            using (cnx)
            {

                try
                {
                    string EmailDestino = "";
                    string EmailFrom = "";
                    string EmailFromDH = "";
                    string EmailFromG = "";
                    string Url = "http://swl024/DNP/Default.aspx";
                    

                    email_responsable = Session["Correo"].ToString();

                    MailAddress SendFrom = new MailAddress(email_responsable);
                    MailAddress SendTo = new MailAddress(email_responsable);
                    MailMessage MyMessage = new MailMessage(SendFrom, SendTo);

                    string correollenado = "";
                    string query = "SELECT Correo FROM dnp_Llenado where Correo <> ''";
                    SqlCommand comando = new SqlCommand(query, cnx);
                    SqlDataReader registros = comando.ExecuteReader();

                    while (registros.Read())
                    {
                        correollenado = registros["Correo"].ToString();
                        MyMessage.To.Add(correollenado);
                    }
                    registros.Close();

                    if (tipo == "NUEVO")
                    {
                        MyMessage.Subject = "Nuevo lanzamiento " + txtProdDes.Text+" (DNP).";
                        MyMessage.Body = "Nuevo lanzamiento "+txtProdDes.Text+" (" + dpClientes.SelectedItem + ") ha sido dado de alta y esta disponible para ser llenado." + "\r\n" + "\r\n" + Url.ToString();
                    }
                    else
                    {
                        MyMessage.Subject = "Lanzamiento " + txtProdDes.Text + " (DNP) disponible para firmas.";
                        MyMessage.Body = "El lanzamiento " +  txtProdDes.Text + " (" +dpClientes.SelectedItem+") esta disponible para firmas." + "\r\n" + "\r\n" + Url.ToString();
                    }

                    SmtpClient emailClient = new SmtpClient("box2308.bluehost.com", 26);
                    emailClient.Credentials = new System.Net.NetworkCredential("helpdesk@tecnoglobal.mx", "TGhd2525");
                    emailClient.Send(MyMessage);
                    cnx.Close();

                }
                catch (Exception ex)
                {
                    string sEx = ex.Message;
                    WebUtil.MostrarPopUp(ref pop, ". No se pudo enviar el Mensaje", "cuenta de correo incorrecta o no existe", "Enviar Mensaje");
                }
            }
            oUtil = null;
        }
        

      
        
        public void setTitle(string index)
        {
            int noIndex = Convert.ToInt32(index);
            clUtil oUtil = new clUtil();
            lbltitulo.Text = oUtil.setTitle(noIndex, "LANZAMIENTOS"+ "-" +lblFolioProyecto.Text +" "+ txtProdDes.Text );
        }
        protected void Menu3_MenuItemClick(object sender, MenuEventArgs e)
        {           
            
            MenuItem item = e.Item;
            setTitle(item.Value);
            if (item.Value == "0")
            {
                MultiView1.ActiveViewIndex = 0;
                cargaProyectos();
                limpiarDNP();
                MuestraMenu(Session["Seccion"].ToString(), true);
            }
            else if (item.Value == "1")
            {          
                    
                  MultiView1.ActiveViewIndex = 1;
            }
            else if (item.Value == "2")
            {
                MultiView1.ActiveViewIndex = 2;
            }
            else if (item.Value == "3")
            {
                MultiView1.ActiveViewIndex =4;
            }
            else if (item.Value == "4")
            {
                MultiView1.ActiveViewIndex = 5;
            }
            else if (item.Value == "5")
            {
                MultiView1.ActiveViewIndex = 6;
            }
            else if (item.Value == "6")
            {
                MultiView1.ActiveViewIndex = 7;
            }
            else if (item.Value == "7")
            {
                MultiView1.ActiveViewIndex = 8;
            }
            else if (item.Value == "8")
            {
                MultiView1.ActiveViewIndex = 10;
            }
            else if (item.Value == "9")
            {
                MultiView1.ActiveViewIndex = 11;
            }
            else if (item.Value == "10")
            {
                MultiView1.ActiveViewIndex = 12;
            }
            else if (item.Value == "11")
            {
                MultiView1.ActiveViewIndex = 3;
            }
            else if (item.Value == "12")
            {
                MultiView1.ActiveViewIndex = 9;
            }
        }
      
        public void CargarDataGridPalabras(ref GridView dg, string NoQuimico, string tipo, string sp)
        {
            //dg.CurrentPageIndex = 0;
            clUtil oUtil = new clUtil();
            SqlCommand cmdWH = new SqlCommand();
            cmdWH.Connection = oUtil.ADOS_DH;
            cmdWH.CommandType = CommandType.StoredProcedure;
            cmdWH.CommandText = sp;
            cmdWH.Parameters.Add("@NoQuimico", SqlDbType.VarChar);
            cmdWH.Parameters["@NoQuimico"].Value = NoQuimico;
            cmdWH.Parameters.Add("@tipo", SqlDbType.VarChar);
            cmdWH.Parameters["@tipo"].Value = tipo;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdWH);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dg.DataSource = dataSet.Tables[0].DefaultView;
            dg.DataBind();

        }
        public void buscaDatos()
        {
            //if (txtNoQuimico.Text != "")
            //{
            //    obtenerQuimico();
            //    obtenerRombo();
            //    obtenerPictograma();
            //    obtenerEPP();
            //    CargarDataGridPalabras(ref dgCono, txtNoQuimico.Text, "P", "siq_spObtenerPalabrasPH");
            //    CargarDataGridPalabras(ref dgCono2, txtNoQuimico.Text, "H", "siq_spObtenerPalabrasPH");
            //}
            //else
            //{
            //    limpia();
            //}
        }

        protected void txtNoQuimico_TextChanged(object sender, EventArgs e)
        {
            buscaDatos();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //ActualizaQuimico();
        }

        public void limpia()
        {

        }
        public void muestraReporte(string codigo)
        {
        //    ReportViewer1.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Remote;
        //    //NetworkCredential myCred = new NetworkCredential("usistemas", "Carb0LinXtreme");
        //    CustomReportCredentials credentials = new CustomReportCredentials("usistemas", "Carb0LinXtreme", "WET-LINE");
        //    this.ReportViewer1.ServerReport.ReportServerCredentials = credentials;
        //    //ReportViewer1.ServerReport.ReportServerCredentials.NetworkCredentials = myCred;
        //    //ReportViewer1.ServerReport.ReportServerCredentials.NetworkCredentials = new ReportServerNetworkCredentials("", "");
        //    ReportViewer1.ServerReport.ReportServerUrl = new Uri("http://swl024/ReportServer");
        //    ReportViewer1.ServerReport.ReportPath = "/SSyMA/SIQ_Etiqueta";
        //    ReportViewer1.ShowParameterPrompts = false;
        //    ReportViewer1.ShowPrintButton = true;

        //    Microsoft.Reporting.WebForms.ReportParameter[] reportParameterCollection = new Microsoft.Reporting.WebForms.ReportParameter[1];
        //    reportParameterCollection[0] = new Microsoft.Reporting.WebForms.ReportParameter();
        //    reportParameterCollection[0].Name = "NoQuimico";
        //    reportParameterCollection[0].Values.Add(codigo);

        //    ReportViewer1.ServerReport.SetParameters(reportParameterCollection);
        //    ReportViewer1.ServerReport.Refresh();
        }

        protected void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        protected void chpropia_CheckedChanged(object sender, EventArgs e)
        {
            if (chpropia.Checked)
            {
                chmaquila.Checked = false;
            }
            else
            {
                chmaquila.Checked = true;
            }
        }

        protected void chmaquila_CheckedChanged(object sender, EventArgs e)
        {
            if (chmaquila.Checked)
            {
                chpropia.Checked = false;
            }
            else
            {
                chpropia.Checked = true;
            }
        }

        protected void btnGuardar1_Click(object sender, EventArgs e)
        {
            ActualizaCabecera();
        }

        protected void dgPerfil_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "SELECT":
                    {
                      lblFolioProyecto.Text = e.Item.Cells[0].Text;
                        if (e.Item.Cells[3].Text == "LLENADO")
                        {
                            MuestraMenu(Session["Seccion"].ToString(), true);
                            lblFolioProyecto.Text = e.Item.Cells[0].Text;
                            obtenerCabecera();
                            obtenerProducto();
                            obtenerFisico();
                            obtenerSenso();
                            clIdent.CargarDataGrid(ref dgFunciones, lblFolioProyecto.Text, "sp_ObtenerEmpaques");
                            obtenerCodigos();
                            obtenerEmbalaje();
                            obtenerImagenes();
                            obtenerObs();
                            obtener_ESP_FORM();
                            obtener_Esp_Equip_Env();
                            btn11.Enabled = false;
                            

                        }
                        else if (e.Item.Cells[3].Text == "FIRMAS")
                        {
                            MuestraMenu(Session["Seccion"].ToString(),false);
                            lblFolioProyecto.Text = e.Item.Cells[0].Text;
                            obtenerFirmasVentas();
                            obtenerCabecera();
                            obtenerProducto();
                            obtenerFisico();
                            obtenerSenso();
                            clIdent.CargarDataGrid(ref dgFunciones, lblFolioProyecto.Text, "sp_ObtenerEmpaques");
                            obtenerCodigos();
                            obtenerEmbalaje();
                            obtenerImagenes();
                            obtenerObs();
                            seccion5(true);
                            cargaCheck();
                            obtener_Esp_Equip_Env();
                            obtener_ESP_FORM();
                            txtEspEquiTanq.Enabled = false;
                            txtEECap.Enabled = false;
                            txtCE.Enabled = false;

                        }
                        else if (e.Item.Cells[3].Text == "CANCELADO")
                        {
                            MuestraMenu(Session["Seccion"].ToString(),false);
                        }
                        break;
                    }
            }
        }
        public void cargaCheck()
        {
            btn11.Enabled = true;
            if (obtenerFirmasProyecto(lblsol.Text,1))
            {
                chsolicita.Checked = obtenerFirmasProyecto(lblsol.Text,1);
                chsolicita.Enabled = false;
            }
            if (obtenerFirmasProyecto(lbldnp.Text,2))
            {
                chdnp.Enabled = false;
                chdnp.Checked = obtenerFirmasProyecto(lbldnp.Text,2);
            }
            if (obtenerFirmasProyecto(lblcostos.Text,3))
            {
                chcostos.Checked = obtenerFirmasProyecto(lblcostos.Text,3);
                chcostos.Enabled = false;
            }
            if (obtenerFirmasProyecto(lblid.Text,4))
            {
                chid.Checked = obtenerFirmasProyecto(lblid.Text,4);
                chid.Enabled = false;
            }
            if (obtenerFirmasProyecto(lblRoss.Text,5))
            {
                cherp.Checked = obtenerFirmasProyecto(lblRoss.Text,5);
                cherp.Enabled = false;
            }
            if (obtenerFirmasProyecto(lblmat.Text,6))
            {
                chmat.Checked = obtenerFirmasProyecto(lblmat.Text,6);
                chmat.Enabled = false;
            }
            if (obtenerFirmasProyecto(lbldir.Text,7))
            {
                chdir.Checked = obtenerFirmasProyecto(lbldir.Text,7);
                chdir.Enabled = false;
            }

            if (obtenerFirmasProyecto(lblmat2.Text, 8))
            {
                chmat2.Checked = obtenerFirmasProyecto(lblmat2.Text, 8);
                chmat2.Enabled = false;
            }
            if (obtenerFirmasProyecto(lblhac.Text, 9))
            {
                chhac.Checked = obtenerFirmasProyecto(lblhac.Text, 9);
                chhac.Enabled = false;
            }
            if (obtenerFirmasProyecto(lblventas.Text, 10))
            {
                chventas.Checked = obtenerFirmasProyecto(lblventas.Text, 10);
                chventas.Enabled = false;
            }
            //if (obtenerFirmasProyecto(Session["User"].ToString()))
            //{
            //    btn11.Enabled = false;
            //    txtText.Enabled = false;
            //}
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if(lblFolioProyecto.Text=="NUEVO")
                WebUtil.MostrarPopUp(ref pop, "Favor de seleccionar un lanzamiento", "", "");             
            else
                ActualizaProducto();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            if (lblFolioProyecto.Text == "NUEVO")
                WebUtil.MostrarPopUp(ref pop, "Favor de seleccionar un lanzamiento", "", "");
            else
                ActualizaFisico();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (lblFolioProyecto.Text == "NUEVO")
                WebUtil.MostrarPopUp(ref pop, "Favor de seleccionar un lanzamiento", "", "");
            else
                ActualizaSenso();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (lblFolioProyecto.Text == "NUEVO")
                WebUtil.MostrarPopUp(ref pop, "Favor de seleccionar un lanzamiento", "", "");
            else
            {

            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (lblFolioProyecto.Text == "NUEVO")
                WebUtil.MostrarPopUp(ref pop, "Favor de seleccionar un lanzamiento", "", "");
            else
                ActualizaCodigos();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (lblFolioProyecto.Text == "NUEVO")
                WebUtil.MostrarPopUp(ref pop, "Favor de seleccionar un lanzamiento", "", "");
            else
                ActualizaEmbalaje();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            ActualizaImagenes();
        }

        public void visualizarProducto() 
        {
            if (fuIProd.HasFile)
            {
                try
                {

                    MemoryStream str = new MemoryStream(fuIProd.FileBytes);
                    System.Drawing.Image bmp = System.Drawing.Image.FromStream(str);

                    if (bmp.Width > 400 || bmp.Height > 400)
                    {
                        WebUtil.MostrarPopUp(ref pop, "Favor de elegir otra imagen MAX(400 x 400 mpx)", "", "");
                    }
                    else
                    {
                        string folderPath = Server.MapPath("~/Files/");
                        if (!Directory.Exists(folderPath))
                        {
                            //If Directory (Folder) does not exists Create it.
                            Directory.CreateDirectory(folderPath);
                        }

                        if (!string.IsNullOrEmpty(Path.GetFileName(fuIProd.FileName)))
                        {
                            if (Convert.ToInt32(fuIProd.PostedFile.ContentLength) > 1048576) lblproducto.Text = "Error, el tamaño de la foto debe ser menor a un megabyte";
                            else
                            {
                                fuIProd.SaveAs(Server.MapPath("Files") + "/" + lblFolioProyecto.Text + "Producto.jpg");
                                imgProd.ImageUrl = ("../Files/" + lblFolioProyecto.Text + "Producto.jpg");
                                lblproducto.Text = lblFolioProyecto.Text + "Producto.jpg";

                            }
                        }
                        ////StatusLabel.Text = "Upload status: File uploaded!";
                    }
                }
                catch (Exception ex)
                {
                    //StatusLabel.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                }
            }
        }
        public void visualizarLotificado()
        {
            if (fuILotificado.HasFile)
            {
                try
                {

                    MemoryStream str = new MemoryStream(fuILotificado.FileBytes);
                    System.Drawing.Image bmp = System.Drawing.Image.FromStream(str);

                    if (bmp.Width > 400 || bmp.Height > 400)
                    {
                        WebUtil.MostrarPopUp(ref pop, "Favor de elegir otra imagen MAX(400 x 400 mpx)", "", "");
                    }
                    else
                    {
                        string folderPath = Server.MapPath("~/Files/");
                        if (!Directory.Exists(folderPath))
                        {
                            //If Directory (Folder) does not exists Create it.
                            Directory.CreateDirectory(folderPath);
                        }

                        if (!string.IsNullOrEmpty(Path.GetFileName(fuILotificado.FileName)))
                        {
                            if (Convert.ToInt32(fuILotificado.PostedFile.ContentLength) > 1048576) lblproducto.Text = "Error, el tamaño de la foto debe ser menor a un megabyte";
                            else
                            {
                                fuILotificado.SaveAs(Server.MapPath("Files") + "/" + lblFolioProyecto.Text + "Lotificado.jpg");
                                imgLotificado.ImageUrl = ("../Files/" + lblFolioProyecto.Text + "Lotificado.jpg");
                                lbllotificado.Text = lblFolioProyecto.Text + "Lotificado.jpg";
                            }
                        }
                        ////StatusLabel.Text = "Upload status: File uploaded!";
                    }
                }
                catch (Exception ex)
                {
                    //StatusLabel.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                }
            }
        }
        public void visualizarCorrugado()
        {
            if (fuICorrugado.HasFile)
            {
                try
                {

                    MemoryStream str = new MemoryStream(fuICorrugado.FileBytes);
                    System.Drawing.Image bmp = System.Drawing.Image.FromStream(str);

                    if (bmp.Width > 400 || bmp.Height > 400)
                    {
                        WebUtil.MostrarPopUp(ref pop, "Favor de elegir otra imagen MAX(400 x 400 mpx)", "", "");
                    }
                    else
                    {
                        string folderPath = Server.MapPath("~/Files/");
                        if (!Directory.Exists(folderPath))
                        {
                            //If Directory (Folder) does not exists Create it.
                            Directory.CreateDirectory(folderPath);
                        }

                        if (!string.IsNullOrEmpty(Path.GetFileName(fuICorrugado.FileName)))
                        {
                            if (Convert.ToInt32(fuICorrugado.PostedFile.ContentLength) > 1048576) lblproducto.Text = "Error, el tamaño de la foto debe ser menor a un megabyte";
                            else
                            {
                                fuICorrugado.SaveAs(Server.MapPath("Files") + "/" + lblFolioProyecto.Text + "Corrugado.jpg");
                                imgCorrugado.ImageUrl = ("../Files/" + lblFolioProyecto.Text + "Corrugado.jpg");
                                lblcorrugado.Text = lblFolioProyecto.Text + "Corrugado.jpg";

                            }
                        }
                        ////StatusLabel.Text = "Upload status: File uploaded!";
                    }
                }
                catch (Exception ex)
                {
                    //StatusLabel.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                }
            }
        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            cargaProyectos();
        }

        protected void btnBusca_Click(object sender, EventArgs e)
        {
            cargaProyectos();
        }

        protected void btnVisualiza2_Command(object sender, CommandEventArgs e)
        {

        }

        protected void btnVisualiza2_Click(object sender, EventArgs e)
        {
            visualizarCorrugado();
        }

        protected void btnVisualiza2_Click1(object sender, EventArgs e)
        {
            visualizarLotificado();
        }

        protected void btnVisualiza3_Click(object sender, EventArgs e)
        {
            visualizarCorrugado();
        }

        protected void btnVisualiza1_Click(object sender, EventArgs e)
        {
            visualizarProducto();

        }

        protected void btnVisualiza2_Click2(object sender, EventArgs e)
        {
            visualizarLotificado();
        }
        public void limpiarDNP()
        {
            lblFolioProyecto.Text = "NUEVO";
            dpClientes.SelectedIndex = 0;
            txtnoti.Text = "";
            txtlanza.Text = "";
            chmaquila.Checked = false;
            chpropia.Checked = false;
            txtCodCliente.Text = "";

            txtProdDes.Text = "";
            txtcodRoss.Text = "";
            txtCajasFab.Text = "";
            txtRegSan.Text = "";
            txtCad.Text = "";

            txtFormula.Text = "";
            txtNeto.Text = "";
            txtElab.Text = "";
            txtDensi.Text = "";
            txtPH.Text = "";
            txtVisc.Text = "";
            txtText.Text = "";

            txtColor.Text = "";
            txtFrag.Text = "";
            txtFijacion.Text = "";
            txtOtros.Text = "";

            txtEnvDes.Text = "";            
            txtEnvMat.Text = "";
            txtEnvColor.Text = "";
            txtEnvCodigo.Text = "";

            txtEan13.Text = "";
            txtEan14.Text = "";

            txtUniCorr.Text = "";
            txtCorrCama.Text = "";
            txtCajasTarimas.Text = "";
            txtCamasTarimas.Text = "";
            txtTipoTarima.Text = "";
            txtPeso.Text = "";
            txtAlturaEstiba.Text = "";

            imgProd.ImageUrl="";
            imgLotificado.ImageUrl="";
            imgCorrugado.ImageUrl="";

            lblproducto.Text="";
            lbllotificado.Text ="";
            lblcorrugado.Text="";

            chsolicita.Checked = false;
            chdnp.Checked = false;
            chcostos.Checked = false;
            chid.Checked = false;
            cherp.Checked = false;
            chmat.Checked = false;
            chmat2.Checked = false;
            chdir.Checked = false;
            chhac.Checked = false;
            chventas.Checked = false;



        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (lblFolioProyecto.Text != "NUEVO")
            {
                ActualizaEstatus();
                if(dpEstatus.SelectedItem.ToString()=="LLENADO")
                {
                    ActualizaFirma(0);
                }
            }
            else
            {
                WebUtil.MostrarPopUp(ref pop, "Favor de seleccionar un lanzamiento", "", "");             
            }
            
        }
        public bool ActualizaEstatus()
        {
            bool Str = true;

            clUtil oUtil = new clUtil();
            oUtil.cmdWH.CommandType = CommandType.StoredProcedure;


            oUtil.cmdWH.CommandText = "sp_ActualizaEstatus";
            oUtil.cmdWH.Parameters.Add("@CodProy", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@CodProy"].Value = lblFolioProyecto.Text;

            oUtil.cmdWH.Parameters.Add("@Estatus", SqlDbType.Int);
            oUtil.cmdWH.Parameters["@Estatus"].Value = dpEstatus.SelectedValue;

            bool proc = Convert.ToBoolean(oUtil.cmdWH.ExecuteNonQuery());

            if (proc)
            {
                Str = true;
                cargaProyectos();
                EnviarCorreoP(lblFolioProyecto.Text);
                limpia();
            }
            else
            {
                Str = false;
            }
            return Str;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            ActualizaObs();
        }

        protected void btn11_Click(object sender, EventArgs e)
        {
            String NomUser = this.GetUserbyuser();
            string nameuser = Session["User"].ToString();

                if (NomUser != "")
                {
                    ActualizaFirma(1);
                    cargaCheck();
                    //ingresa();
                }
            
        }
 
        private String GetUserbyuser()
        {
            try
            {
                String Str = "";
                DirectoryEntry de = GetDirectoryObject();

                de.Username = Session["User"].ToString(); 
                de.Password = txtpass.Text;

                //,this.txtUsuario.Text
                DirectorySearcher deSearch = new DirectorySearcher(de);
                deSearch.SearchRoot = de;

                deSearch.Filter = "(&(objectClass=user)(SAMAccountName=" + Session["User"].ToString() +"))";
                deSearch.SearchScope = SearchScope.Subtree;
                SearchResult results = deSearch.FindOne();

                if (!(results == null))
                {
                    DirectoryEntry dey = results.GetDirectoryEntry();
                    Str = (String)dey.Properties["displayName"].Value;
                }
                else
                {
                    return "";
                }
                return Str;
            }
            catch (Exception ex)
            {
                string sEx = ex.Message;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Usuario o contraseña incorrecta');</script>");
                //WebUtil.MostrarPopUp(ref pop, "Usuario o contraseña incorrecta", "Inicio Sesion");
                this.txtpass.Focus();
                return "";
            }
        }
        private DirectoryEntry GetDirectoryObject()
        {
            DirectoryEntry oDE;
            //oDE = new DirectoryEntry("LDAP://SWL003", "urespaldo", "Geles500", AuthenticationTypes.Secure);
            oDE = new DirectoryEntry("LDAP://SWL020", "usistemas", "Carb0LinXtreme", AuthenticationTypes.Secure);
            return oDE;
        }
        public void obtenerSeccion(string usr)
        {
            DataTable datos = new DataTable();
            cIdentificacion clIdent = new cIdentificacion();
            string consulta = "SELECT * FROM dnp_Llenado WHERE Usuario =  '" + usr + "'";
            //datos = clIdent.obtenerObtenerCampos(consulta, txtNoQuimico.Text);
            string conex = ConfigurationManager.ConnectionStrings["CNXSTR"].ConnectionString;
            string query = "";

            datos = clIdent.obtenerObtenerCampos(consulta, usr);
            if (datos.Rows.Count > 0 && datos != null)
            {

                Session["Seccion"] = datos.Rows[0].ItemArray[2].ToString();
                Session["Correo"] = datos.Rows[0].ItemArray[3].ToString();
            }
            else
            {
                //WebUtil.MostrarPopUp(ref pop, "Quimico no encontrado", "", "");
            }

        }

        protected void btnAgr3_Click(object sender, EventArgs e)
        {
            if (btnAgr3.Text == "AGREGAR") 
            {
                string consulta = "INSERT INTO dnp_Empaque (NO_PROYECTO, MATERIAL, DESCRIPCION,MATERIAL2,COLOR,CODIGO) VALUES('" + lblFolioProyecto.Text + "','" + dpFrecuencia.SelectedItem.ToString() + "','" + txtEnvDes.Text + "','" + txtEnvMat.Text + "','" + txtEnvColor.Text + "','" + txtEnvCodigo.Text + "')";
                InsertaDatos(consulta);
                clIdent.CargarDataGrid(ref dgFunciones, lblFolioProyecto.Text, "sp_ObtenerEmpaques");
                dpFrecuencia.SelectedIndex = -1;
                txtEnvDes.Text = "";
                txtEnvMat.Text = "";
                txtEnvColor.Text = "";
                txtEnvCodigo.Text = "";

            }
            else if (btnAgr3.Text == "GUARDAR")
            {
                string consulta = "UPDATE dnp_Empaque SET MATERIAL = '" + dpFrecuencia.SelectedItem.ToString() + "', DESCRIPCION= '" + txtEnvDes.Text + "' , MATERIAL2= '" + txtEnvMat.Text + "' , COLOR= '" + txtEnvColor.Text + "' , CODIGO= '" + txtEnvCodigo.Text + "'  WHERE id_Empaque = '" + lblidm.Text + "'";
                InsertaDatos(consulta);

                clIdent.CargarDataGrid(ref dgFunciones, lblFolioProyecto.Text, "sp_ObtenerEmpaques");
                btnAgr3.Text = "AGREGAR";
                dpFrecuencia.SelectedIndex = -1;
                txtEnvDes.Text = "";
                txtEnvMat.Text = "";
                txtEnvColor.Text = "";
                txtEnvCodigo.Text = "";
            }
        }

        protected void btnBI1_Click(object sender, EventArgs e)
        {
            borraArchivo(lblproducto.Text, lblproducto);
            ActualizaImagenes();
        }

        protected void btnBI2_Click(object sender, EventArgs e)
        {
            borraArchivo(lbllotificado.Text,lbllotificado);
            ActualizaImagenes();
        }
        public void borraArchivo(string archivo, Label eti)
        {
            string folderPath = Server.MapPath("~/Files/");
            string ruta = folderPath + archivo;
            try
            {
                File.Delete(ruta);
                if (File.Exists(ruta))
                {
                    Console.WriteLine("El archivo sigue existiendo.");
                }
                else
                {
                    Console.WriteLine("El archivo ya no existe.");
                    eti.Text = "";
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al borrar archivo: {0}", e.ToString());
            }
        }

        protected void btnBI3_Click(object sender, EventArgs e)
        {
            borraArchivo(lblcorrugado.Text, lblcorrugado);
            ActualizaImagenes();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            FiltraProyectos();
        }

        protected void btnGEspForm_Click(object sender, EventArgs e)
        {
            var db = new DNPEntities5();         
            db.Actualiza_Equipo_formulacion(lblFolioProyecto.Text, txtEspEquiTanq.Text, txtEECap.Text);
            db.SaveChanges();
            WebUtil.MostrarPopUp(ref pop, "Guardado", "", "");
        }

        protected void btnGEquiEnv_Click(object sender, EventArgs e)
        {
            var db = new DNPEntities5();      
          
            db.Actualiza_Especificacion_EquiEnv(lblFolioProyecto.Text, txtCE.Text);
            db.SaveChanges();
            WebUtil.MostrarPopUp(ref pop, "Guardado", "", "");

        }

        protected void dgFunciones_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "EDITA":
                    lblidm.Text = e.Item.Cells[0].Text.Trim();   
                    dpFrecuencia.ClearSelection();
                    dpFrecuencia.Items.FindByText(e.Item.Cells[1].Text.Trim()).Selected = true;
                    txtEnvDes.Text = e.Item.Cells[2].Text.Trim();
                    txtEnvMat.Text = e.Item.Cells[3].Text.Trim();
                    txtEnvColor.Text = e.Item.Cells[4].Text.Trim();
                    txtEnvCodigo.Text = e.Item.Cells[5].Text.Trim();
                    btnAgr3.Text = "GUARDAR";
                    break;
                case "ELIMINA":
                    lblidm.Text = e.Item.Cells[0].Text.Trim();
                    string sSql = "DELETE FROM dnp_Empaque WHERE id_Empaque= '" + lblidm.Text + "'";
                    eliminaDato(sSql);
                    clIdent.CargarDataGrid(ref dgFunciones, lblFolioProyecto.Text, "sp_ObtenerEmpaques");
                    break;
            }
        }
        public void eliminaDato(string sSql)
        {
            clUtil oUtil = new clUtil();
            SqlConnection cnx = oUtil.ADOS_DH;
            SqlTransaction trx = cnx.BeginTransaction();
            using (cnx)
            {
                try
                {
                    oUtil.cmdWH.CommandType = CommandType.Text;
                    oUtil.cmdWH.CommandText = sSql;
                    oUtil.cmdWH.Transaction = trx;
                    oUtil.cmdWH.ExecuteNonQuery();
                    sSql = "SELECT @@IDENTITY";
                    trx.Commit();
                }
                catch (Exception ex)
                {
                    trx.Dispose();
                }
                finally
                {
                    trx.Dispose();
                    cnx.Close();
                    cnx.Dispose();

                }
            }
            oUtil = null;
        }
    }
}