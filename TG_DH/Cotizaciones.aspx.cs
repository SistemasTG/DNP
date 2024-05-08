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
    public partial class Cotizaciones : System.Web.UI.Page
    {
        string valorUSR = "";
        cIdentificacion clIdent = new cIdentificacion();
        string email_responsable, correojefe, perfil_name;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                MultiView1.ActiveViewIndex = 0;
                CargarCombosC();
                string menu = Convert.ToString(Session["User"]);
                string quimico = Request.QueryString.Get("valorUSR");
                //MuestraMenu(Session["Seccion"].ToString(), true);
                cargaProyectos();
                //obtenerFirmas();
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
                cmdWH.CommandText = "sp_ObtenerProyectosCoti";
                cmdWH.Parameters.Add("@busqueda", SqlDbType.VarChar);
                cmdWH.Parameters["@busqueda"].Value = buscar;



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

            /*Clientes?
           */
            string sSqlDepto = "SELECT ID_CLIENTE, NOMBRE FROM dnp_Clientes ORDER BY NOMBRE";
            //Ident.CargarCombos(ref dpClientes, sSqlDepto, "ID_CLIENTE", "NOMBRE");





        }
        public void obtenerProducto()
        {
            DataTable datos = new DataTable();
            cIdentificacion clIdent = new cIdentificacion();

            string conex = ConfigurationManager.ConnectionStrings["CNXSTR"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(conex))
            {

                if (datos.Rows.Count > 0 && datos != null)
                {

                }

            }
        }

        private void EnviarCorreoP(string tipo)
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
                        // MyMessage.Subject = "Nuevo lanzamiento " + txtProdDes.Text+" (DNP).";
                        //   MyMessage.Body = "Nuevo lanzamiento "+txtProdDes.Text+" (" + dpClientes.SelectedItem + ") ha sido dado de alta y esta disponible para ser llenado." + "\r\n" + "\r\n" + Url.ToString();
                    }
                    else
                    {
                        // MyMessage.Subject = "Lanzamiento " + txtProdDes.Text + " (DNP) disponible para firmas.";
                        // MyMessage.Body = "El lanzamiento " +  txtProdDes.Text + " (" +dpClientes.SelectedItem+") esta disponible para firmas." + "\r\n" + "\r\n" + Url.ToString();
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



        public void setTitle(string proy, string desc)
        {
            lbltitulo.Text = "COTIZACIÓN" + "-" + proy + " " + desc;

        }
        protected void Menu3_MenuItemClick(object sender, MenuEventArgs e)
        {


            MenuItem item = e.Item;
            // setTitle(item.Value);
            if (item.Value == "0")
            {
                MultiView1.ActiveViewIndex = 0;
                cargaProyectos();
                limpiarDNP();
                //MuestraMenu(Session["Seccion"].ToString(), true);
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
                MultiView1.ActiveViewIndex = 3;
            }
            else if (item.Value == "4")
            {
                MultiView1.ActiveViewIndex = 4;
            }
            else if (item.Value == "5")
            {
                MultiView1.ActiveViewIndex = 5;
            }
            else if (item.Value == "6")
            {
                MultiView1.ActiveViewIndex = 6;
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
            
        }

        protected void txtNoQuimico_TextChanged(object sender, EventArgs e)
        {
            buscaDatos();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
           
        }

        public void limpia()
        {

        }
        public void muestraReporte(string codigo)
        {
        
        }

        protected void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        protected void chpropia_CheckedChanged(object sender, EventArgs e)
        {
        }

        protected void chmaquila_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        protected void btnGuardar1_Click(object sender, EventArgs e)
        {
            ActualizaCabecera();

        }
        public void limpiaCabecera()
        {
            txtClienteCoti.Text = "";
            txtprodCoti.Text = "";
            txtcajasCoti.Text = "";
            txtLineaCoti.Text = "";
            txtpersonalCoti.Text = "";
            txtcajasturno.Text = "";
            txtFormula.Text = "";
            txtcontenidon.Text = "";
            txtcodFormula.Text = "";
            txtEquipo.Text = "";
        }
        public bool ActualizaCabecera()
        {
            bool Str = true;
            string usr = Session["User"].ToString();
            clUtil oUtil = new clUtil();
            oUtil.cmdWH.CommandType = CommandType.StoredProcedure;


            oUtil.cmdWH.CommandText = "sp_ActualizaCabeceraCotiza";
            oUtil.cmdWH.Parameters.Add("@CodProy", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@CodProy"].Value = lblProyectoCotiza.Text;

            oUtil.cmdWH.Parameters.Add("@solicita", SqlDbType.Int);
            oUtil.cmdWH.Parameters["@solicita"].Value = dpSolicitaCoti.SelectedValue;

            oUtil.cmdWH.Parameters.Add("@cliente", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@cliente"].Value = txtClienteCoti.Text;

            oUtil.cmdWH.Parameters.Add("@producto", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@producto"].Value = txtprodCoti.Text;

            oUtil.cmdWH.Parameters.Add("@cajas", SqlDbType.Int);
            oUtil.cmdWH.Parameters["@cajas"].Value =Convert.ToInt32(txtcajasCoti.Text);

            oUtil.cmdWH.Parameters.Add("@linea", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@linea"].Value = txtLineaCoti.Text;

            oUtil.cmdWH.Parameters.Add("@personas", SqlDbType.Int);
            oUtil.cmdWH.Parameters["@personas"].Value = Convert.ToInt32(txtpersonalCoti.Text);

            oUtil.cmdWH.Parameters.Add("@cajasturno", SqlDbType.Int);
            oUtil.cmdWH.Parameters["@cajasturno"].Value = Convert.ToInt32(txtcajasturno.Text);

            oUtil.cmdWH.Parameters.Add("@formula", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@formula"].Value = txtFormula.Text;

            oUtil.cmdWH.Parameters.Add("@contenido", SqlDbType.Int);
            oUtil.cmdWH.Parameters["@contenido"].Value = Convert.ToInt32(txtcontenidon.Text);

            oUtil.cmdWH.Parameters.Add("@codFormula", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@codFormula"].Value = txtcodFormula.Text;

            oUtil.cmdWH.Parameters.Add("@equipo", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@equipo"].Value = txtEquipo.Text;

            oUtil.cmdWH.Parameters.Add("@usr", SqlDbType.VarChar);
            oUtil.cmdWH.Parameters["@usr"].Value = usr;

            //Envia notificacion de correo

            bool proc = Convert.ToBoolean(oUtil.cmdWH.ExecuteNonQuery());

            if (proc)
            {
                Str = true;
                WebUtil.MostrarPopUp(ref pop, "Guardado", "", "");
                //limpiarDNP();
                //limpia();
                limpiaCabecera();
            }
            else
            {
                Str = false;
            }
            return Str;
        }
        private void CargarCombosC()
        {
            cIdentificacion Ident = new cIdentificacion();

            /*Clientes?
           */
            string sSqlDepto = "SELECT ID_CLIENTE, NOMBRE FROM dnp_Clientes ORDER BY NOMBRE";
            Ident.CargarCombos(ref dpSolicitaCoti, sSqlDepto, "ID_CLIENTE", "NOMBRE");





        }
      
        protected void dgPerfil_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            string proyecto = e.Item.Cells[0].Text.Trim();
            string desc = e.Item.Cells[3].Text.Trim();
            switch (e.CommandName)
            {
           
                case "SELECT":
                    {
                      lblProyectoCotiza.Text = e.Item.Cells[0].Text;
                                                   
                            obtenerCabecera(proyecto);
                            clIdent.CargarDataGrid(ref dgFunciones, lblProyectoCotiza.Text, "sp_ObtenerEmpaquesCotiza");
                            obtenerEmbalaje();
                            obtenerFirmasCoti(proyecto);
                            setTitle(proyecto, desc);
                            obtenerProyectoFirmado(proyecto);
                            obtenerCostoCot();
                        break;
                    }
            }
        }
        public void obtenerEmbalaje()
        {
            DataTable datos = new DataTable();
            cIdentificacion clIdent = new cIdentificacion();
            string consulta = "SELECT * FROM dnp_EmbalajeCotiza WHERE NO_PROYECTO = '" + lblProyectoCotiza.Text + "'";
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
                    txtobs.Text = datos.Rows[0].ItemArray[4].ToString();
                

                }
            }
        }
        //SE OBTIENEN LOS CAMPOS DEL COSTO DE LANZAMIENTO
        public void obtenerCostoCot()
        {
            DataTable datos = new DataTable();
            cIdentificacion clIdent = new cIdentificacion();
            string consulta = "SELECT * FROM dnp_CostoCot WHERE NO_PROYECTO = '" + lblProyectoCotiza.Text + "'";          
            string conex = ConfigurationManager.ConnectionStrings["CNXSTR"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(conex))
            {
                SqlCommand cmd = new SqlCommand(consulta, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(datos);
                if (datos.Rows.Count > 0 && datos != null)
                {
                    txtcostpieza.Text = datos.Rows[0].ItemArray[2].ToString();
                    txtcostcaja.Text = datos.Rows[0].ItemArray[3].ToString();
                    txtincoterm.Text = datos.Rows[0].ItemArray[4].ToString();
                    txtcotVig.Text = datos.Rows[0].ItemArray[5].ToString();
                    txtMOQ.Text = datos.Rows[0].ItemArray[6].ToString();

                    txtcostpieza.BorderColor = Color.Green;
                    txtcostcaja.BorderColor = Color.Green;
                    txtincoterm.BorderColor = Color.Green;
                    txtcotVig.BorderColor = Color.Green;
                    txtMOQ.BorderColor = Color.Green;


                }
            }
        }
        public void obtenerCabecera(string proyecto)
        {
            DataTable datos = new DataTable();
            cIdentificacion clIdent = new cIdentificacion();
            string consulta = "SELECT T1.*,T2.NOMBRE FROM dnp_Cabecera_Cotiza T1 INNER JOIN dnp_Clientes T2 ON T1.SOLICITA = T2.ID_CLIENTE WHERE NO_PROYECTO = '" + lblProyectoCotiza.Text + "'";
            //datos = clIdent.obtenerObtenerCampos(consulta, txtNoQuimico.Text);
            string conex = ConfigurationManager.ConnectionStrings["CNXSTR"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(conex))
            {
                SqlCommand cmd = new SqlCommand(consulta, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(datos);
                if (datos.Rows.Count > 0 && datos != null)
                {
                    lblProyectoCotiza.Text = datos.Rows[0].ItemArray[1].ToString();
                    dpSolicitaCoti.ClearSelection();
                    dpSolicitaCoti.Items.FindByText(datos.Rows[0].ItemArray[15].ToString()).Selected = true;
                    txtClienteCoti.Text = datos.Rows[0].ItemArray[3].ToString();
                    txtprodCoti.Text = datos.Rows[0].ItemArray[4].ToString();
                    txtcajasCoti.Text = datos.Rows[0].ItemArray[5].ToString();
                    txtLineaCoti.Text = datos.Rows[0].ItemArray[6].ToString();
                    txtpersonalCoti.Text = datos.Rows[0].ItemArray[7].ToString();
                    txtcajasturno.Text = datos.Rows[0].ItemArray[8].ToString();
                    txtFormula.Text = datos.Rows[0].ItemArray[9].ToString();
                    txtcontenidon.Text = datos.Rows[0].ItemArray[10].ToString();
                    txtcodFormula.Text = datos.Rows[0].ItemArray[11].ToString();
                    txtEquipo.Text = datos.Rows[0].ItemArray[12].ToString();
                }
              

            }
            }
        public void cargaCheck()
        {
           
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
       
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
     
        }



        protected void Button6_Click(object sender, EventArgs e)
        {
           
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
            
        }

        protected void btnVisualiza2_Click1(object sender, EventArgs e)
        {
          
        }

        protected void btnVisualiza3_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnVisualiza1_Click(object sender, EventArgs e)
        {
          

        }

        protected void btnVisualiza2_Click2(object sender, EventArgs e)
        {
            
        }
        public void limpiarDNP()
        {
            
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
        
            
        }
     

        protected void Button8_Click(object sender, EventArgs e)
        {
            //ActualizaObs();
        }

        protected void btn11_Click(object sender, EventArgs e)
        {
            String NomUser = this.GetUserbyuser();
            string nameuser = Session["User"].ToString();

                if (NomUser != "")
                {
                   // ActualizaFirma(1);
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

                deSearch.Filter = "(&(objectClass=user)(SAMAccountName=" + Session["User"].ToString() + "))";
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
            if(lbltitulo.Text == "BUSCAR")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Favor de llenar la cabecera del proyecto, ir al apartado BUSCAR  y seleccionarlo, para poder guardar MATERIALES');</script>");

            }else

            if (btnAgr3.Text == "AGREGAR")
            {
                string consulta = "INSERT INTO dnp_EmpaqueCotiza (NO_PROYECTO, MATERIAL, DESCRIPCION,MATERIAL2,COLOR,CODIGO,SYSTEM_DATE) VALUES('" + lblProyectoCotiza.Text + "','" + dpFrecuencia.SelectedItem.ToString() + "','" + txtEnvDes.Text + "','" + txtEnvMat.Text + "','" + txtEnvColor.Text + "','" + txtEnvCodigo.Text + "',GETDATE())";
                InsertaDatos(consulta);
                clIdent.CargarDataGrid(ref dgFunciones, lblProyectoCotiza.Text, "sp_ObtenerEmpaquesCotiza ");
                dpFrecuencia.SelectedIndex = -1;
                txtEnvDes.Text = "";
                txtEnvMat.Text = "";
                txtEnvColor.Text = "";
                txtEnvCodigo.Text = "";

            }
            else if (btnAgr3.Text == "GUARDAR")
            {
                string consulta = "UPDATE dnp_EmpaqueCotiza SET MATERIAL = '" + dpFrecuencia.SelectedItem.ToString() + "', DESCRIPCION= '" + txtEnvDes.Text + "' , MATERIAL2= '" + txtEnvMat.Text + "' , COLOR= '" + txtEnvColor.Text + "' , CODIGO= '" + txtEnvCodigo.Text + "'  WHERE id_Empaque = '" + lblidm.Text + "'";
                InsertaDatos(consulta);

                clIdent.CargarDataGrid(ref dgFunciones, lblProyectoCotiza.Text, "sp_ObtenerEmpaquesCotiza");
                btnAgr3.Text = "AGREGAR";
                dpFrecuencia.SelectedIndex = -1;
                txtEnvDes.Text = "";
                txtEnvMat.Text = "";
                txtEnvColor.Text = "";
                txtEnvCodigo.Text = "";
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
                    string sSql = "DELETE FROM dnp_EmpaqueCotiza WHERE id_Empaque= '" + lblidm.Text + "'";
                    eliminaDato(sSql);
                    clIdent.CargarDataGrid(ref dgFunciones, lblProyectoCotiza.Text, "sp_ObtenerEmpaquesCotiza");
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

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnGuardar2_Click(object sender, EventArgs e)
        {
            ActualizaEmbalaje();
        }
        public void ActualizaEmbalaje()
        {
            bool Str = true;
            if (lbltitulo.Text == "BUSCAR")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Favor de llenar la cabecera del proyecto, ir al apartado BUSCAR  y seleccionarlo, para poder guardar EMBALAJE');</script>");
            }
            else
            {
                using (DNPEntities5 db = new DNPEntities5())
                {
                    db.sp_ActualizaEmbalajeCotiza(lblProyectoCotiza.Text, txtUniCorr.Text, txtCorrCama.Text, txtobs.Text);
                    WebUtil.MostrarPopUp(ref pop, "Guardado", "", "");
                }

            }
           
        }

        protected void ActualizaFirmasCotiza(object sender, EventArgs e)
        {
            String NomUser = this.GetUserbyuser();
            if(lbltitulo.Text == "BUSCAR")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Favor de llenar la cabecera del proyecto, ir al apartado BUSCAR  y seleccionarlo, para poder guardar FIRMAS');</script>");

            }else
            if (NomUser != "")
            {
                using (DNPEntities5 db = new DNPEntities5())
                {
                    string ventas, costos, desarrollo, dir;

                    if (chventas.Checked)
                        ventas = lblventas.Text;
                    else
                        ventas = "";

                    if (chcostos.Checked)
                        costos = lblcostos.Text;
                    else
                        costos = "";

                    if (chdesarrollo.Checked)
                        desarrollo = lbldesarrollo.Text;
                    else
                        desarrollo = "";

                    if (chdir.Checked)
                        dir = lbldir.Text;
                    else
                        dir = "";                
                    db.sp_ActualizaFirmasCotiza(lblProyectoCotiza.Text, ventas, costos, desarrollo, dir);
                    obtenerProyectoFirmado(lblProyectoCotiza.Text);
                    WebUtil.MostrarPopUp(ref pop, "Guardado", "", "");
                }
            }
        }

        protected void ActualizaCosto(object sender, EventArgs e)
        {
            if(lbltitulo.Text == "BUSCAR")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Favor de llenar la cabecera del proyecto, ir al apartado BUSCAR  y seleccionarlo, para poder guardar COSTOS ');</script>");

            }
            else
            using (DNPEntities5 db = new DNPEntities5())
            {
                db.sp_ActualizaCosto_Cot(lblProyectoCotiza.Text, txtcostpieza.Text, txtcostcaja.Text, txtincoterm.Text, txtcotVig.Text, txtMOQ.Text);
                WebUtil.MostrarPopUp(ref pop, "Guardado", "", "");
            }   
        }

        // se agrega el visualizador del reporte de cotizaciones
        protected void Viualizar_reporte(object sender, EventArgs e)
        {
            ReportViewer2.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Remote;

            CustomReportCredentials credentials = new CustomReportCredentials("usistemas", "Carb0LinXtreme", "WET-LINE");
            this.ReportViewer2.ServerReport.ReportServerCredentials = credentials;

            ReportViewer2.ServerReport.ReportServerUrl = new Uri("http://swl024/ReportServer");
            ReportViewer2.ServerReport.ReportPath = "/DH_Reports/dnp_Cotizaciones";
            ReportViewer2.ShowParameterPrompts = false;
            ReportViewer2.ShowPrintButton = true;

            Microsoft.Reporting.WebForms.ReportParameter[] reportParameterCollection = new Microsoft.Reporting.WebForms.ReportParameter[1];
            reportParameterCollection[0] = new Microsoft.Reporting.WebForms.ReportParameter();
            reportParameterCollection[0].Name = "N_PROYECTO";
            reportParameterCollection[0].Values.Add(lblProyectoCotiza.Text);

            ReportViewer2.ServerReport.SetParameters(reportParameterCollection);
            ReportViewer2.ServerReport.Refresh();


        }

        // OBTIENE FIRMAS DE COTIZACIONES 
        private void obtenerFirmasCoti(string proyecto)
        {
            string usr = Convert.ToString(Session["User"]);

            using ( DNPEntities5  db = new DNPEntities5())
            {
                //ventas
                view_dnpFirmasVentasCotiza ventas = db.view_dnpFirmasVentasCotiza.Where(d => d.AREA == "VENTAS" && d.NO_PROYECTO == proyecto).FirstOrDefault();
                if (ventas != null)
                    lblventas.Text = ventas.FIRMA;
                else
                {
                    FirmasCotizaciones ventas2 = db.FirmasCotizaciones.Where(d => d.AREA == "VENTAS").FirstOrDefault();
                    lblventas.Text = ventas2.USR;
                }

                //costos
                view_dnpFirmasVentasCotiza costos = db.view_dnpFirmasVentasCotiza.Where(d => d.AREA == "COSTOS" && d.NO_PROYECTO == proyecto).FirstOrDefault();
                if (costos != null)
                    lblcostos.Text = costos.FIRMA;
                else
                {
                    FirmasCotizaciones costos2 = db.FirmasCotizaciones.Where(d => d.AREA == "COSTOS").FirstOrDefault();
                    lblcostos.Text = costos2.USR;
                }

                //desarrollo
                view_dnpFirmasVentasCotiza desarrollo = db.view_dnpFirmasVentasCotiza.Where(d => d.AREA == "DESARROLLO" && d.NO_PROYECTO == proyecto).FirstOrDefault();
                if (desarrollo != null)
                    lbldesarrollo.Text = desarrollo.FIRMA;
                else
                {
                    FirmasCotizaciones desarrollo2 = db.FirmasCotizaciones.Where(d => d.AREA == "DESARROLLO").FirstOrDefault();
                    lbldesarrollo.Text = desarrollo2.USR;
                }

                //direccion
                view_dnpFirmasVentasCotiza direccion = db.view_dnpFirmasVentasCotiza.Where(d => d.AREA == "DIRECCION" && d.NO_PROYECTO == proyecto).FirstOrDefault();
                if (direccion != null)
                    lbldir.Text = direccion.FIRMA;
                else
                {
                    FirmasCotizaciones dir = db.FirmasCotizaciones.Where(d => d.AREA == "DIRECCION").FirstOrDefault();
                    lbldir.Text = dir.USR;
                }
               
            }

        }

        //OBTIENE PROYECTOS FIRMADOS DE COTIZACIONES!!
        private void obtenerProyectoFirmado(string noProyecto)
        {
            string usr = Convert.ToString(Session["User"]);

            using (DNPEntities5 db = new DNPEntities5())
            {
                //ventas
                dnp_ProyectoCot_Firma firmas = db.dnp_ProyectoCot_Firma.Where(d => d.NO_PROYECTO == noProyecto).FirstOrDefault();
                if (firmas != null)
                {
                    if (firmas.VENTAS != null && firmas.VENTAS != "")
                    {
                        lblventas.Text = firmas.VENTAS;
                        chventas.Checked = true;
                        chventas.Enabled = false;
                    }
                    else if (lblventas.Text == usr)
                    {
                        chventas.Enabled = true;
                        chventas.Checked = false;
                    }
                    else
                    {
                        chventas.Enabled = false;
                        chventas.Checked = false;
                    }

                    if (firmas.COSTOS != null && firmas.COSTOS != "")
                    {
                        lblcostos.Text = firmas.COSTOS;
                        chcostos.Checked = true;
                        chcostos.Enabled = false;
                    }
                    else if (lblcostos.Text == usr)
                    {
                        chcostos.Enabled = true;
                        chcostos.Checked = false;
                    }
                    else
                    {
                        chcostos.Enabled = false;
                        chcostos.Checked = false;
                    }

                    if (firmas.DESARROLLO != null && firmas.DESARROLLO != "")
                    {
                        lbldesarrollo.Text = firmas.DESARROLLO;
                        chdesarrollo.Checked = true;
                        chdesarrollo.Enabled = false;
                    }
                    else if (lbldesarrollo.Text == usr)
                    {
                        chdesarrollo.Enabled = true;
                        chdesarrollo.Checked = false;
                    }
                    else
                    {
                        chdesarrollo.Enabled = false;
                        chdesarrollo.Checked = false;
                    }
                    //                   
                    //
                    if (firmas.DIRECCION != null && firmas.DIRECCION != "")
                    {
                        lbldir.Text = firmas.DIRECCION;
                        chdir.Checked = true;
                        chdir.Enabled = false;
                    }
                    else if (lbldir.Text == usr)
                    {
                        chdir.Enabled = true;
                        chdir.Checked = false;
                    }
                    else
                    {
                        chdir.Enabled = false;
                        chdir.Checked = false;
                    }

                }
                else
                {
                    if (lblventas.Text == usr)
                    {
                        chventas.Enabled = true;
                        chventas.Checked = false;
                    }


                    if (lblcostos.Text == usr)
                    {
                        chcostos.Enabled = true;
                        chcostos.Checked = false;
                    }



                    if (lbldesarrollo.Text == usr)
                    {
                        chdesarrollo.Enabled = true;
                        chdesarrollo.Checked = false;
                    }


                    if (lbldir.Text == usr)
                    {
                        chdir.Enabled = true;
                        chdir.Checked = false;
                    }
                }

            }

        }



    }

}