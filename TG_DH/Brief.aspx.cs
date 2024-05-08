using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web;
using TG_DNP;
using System.IO;
using System.Configuration;

namespace DNP
{
    public partial class Brief : System.Web.UI.Page
    {
        internal static string formabotella, materialbotella, colorbotella, tipoMaquila, tipotapa, materialtapa, colortapa, terminadotapa, linnertapa, MatEtiqueta, TerminadoEtiqueta, MatFunda, TermiFunda, impresionFunda, MatTubo, TermiTubo, MatCorrugado, terminadoCorr, pzasCorru,formula, terminadosf, colorf, bloqueadores;
        char req_legal;


        cIdentificacion clIdent = new cIdentificacion();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                MultiView1.ActiveViewIndex = 0;
                cargaCombo();
                obtieneProyectos();
            }
        }

        protected void chColorVerde_CheckedChanged(object sender, EventArgs e)
        {
                    }

        protected void visualizarImagen(object sender, EventArgs e)
        {
            if (fuIImagen.HasFile)
            {
                try
                {

                    MemoryStream str = new MemoryStream(fuIImagen.FileBytes);
                    System.Drawing.Image bmp = System.Drawing.Image.FromStream(str);

                    if (bmp.Width > 400 || bmp.Height > 400)
                    {
                        WebUtil.MostrarPopUp(ref pop, "Favor de elegir otra imagen MAX(400 x 400 mpx)", "", "");
                    }
                    else
                    {
                        string folderPath = Server.MapPath("~/Files/brief/");
                        if (!Directory.Exists(folderPath))
                        {
                            //If Directory (Folder) does not exists Create it.
                            Directory.CreateDirectory(folderPath);
                        }

                        if (!string.IsNullOrEmpty(Path.GetFileName(fuIImagen.FileName)))
                        {
                            if (Convert.ToInt32(fuIImagen.PostedFile.ContentLength) > 1048576) lblimagen.Text = "Error, el tamaño de la foto debe ser menor a un MB";
                            else
                            {
                                fuIImagen.SaveAs(Server.MapPath("Files/Brief") + "/" + lblProyectoCotiza.Text + "Brief.jpg");
                                imgFormula.ImageUrl = ("../Files/Brief/" + lblProyectoCotiza.Text + "Brief.jpg");
                                lblimagen.Text = lblProyectoCotiza.Text + "Brief.jpg";

                            }
                        }
                      
                    }
                }
                catch (Exception ex)
                {
                    
                }
            }
        }
        protected void BorrarImagen(object sender, EventArgs e)
        {
            borraArchivo(lblProyectoCotiza.Text, lblimagen);

            using (DNPEntities5 db = new DNPEntities5())
            {
                db.sp_BorrarImagen(lblProyectoCotiza.Text);
                WebUtil.MostrarPopUp(ref pop, "Imagen borrada", "", "");
            }

        }

    

        public void cargaCombo()
        {
            using (DNPEntities5 db = new DNPEntities5())
            {
                dpSolicitaCoti.Items.Clear();
                dpSolicitaCoti.DataSource = db.dnp_Clientes.OrderBy(d => d.NOMBRE).ToList();
                dpSolicitaCoti.DataValueField = "ID_CLIENTE";
                dpSolicitaCoti.DataTextField = "NOMBRE";
                dpSolicitaCoti.DataBind();
            }
            
        }
        public void obtieneProyectos()
        {
            using (DNPEntities5 db = new DNPEntities5())
            {
                string search = "";
                if (txtBusqueda.Text == "")
                    search = "TODO";
                else
                    search = txtBusqueda.Text;

                dgBrief.DataSource = db.view_dnp_proyectosBrief.OrderByDescending(x => x.OTRO).Select(x => new { x.NO_PROYECTO, x.CLIENTE, x.PRODUCTO, x.OTRO }).Where(x => x.OTRO == "NUEVO" || x.OTRO == "FIRMAS").ToList();
                dgBrief.DataBind();
                dgBrief.SelectedIndex = -1;
             }
        }

        public void FiltraProyectos() {
            using(DNPEntities5 db = new DNPEntities5())
            {
                string Filtro = DropFiltroB.SelectedValue;
                if(Filtro != "SELECCIONE")
                {
                    dgBrief.DataSource = db.sp_ObtenerProyectosBrief(Filtro).ToList();
                    dgBrief.DataBind();
                    dgBrief.SelectedIndex = -1;
                }else
                {
                    dgBrief.DataSource = db.sp_ObtenerProyectosBrief("NUEVO").ToList();
                    dgBrief.DataBind();
                    dgBrief.SelectedIndex = -1;
                }
            }
        }

        public void FiltraProyectosB(string proyecto)
        {
            using (DNPEntities5 db = new DNPEntities5())
            {
                
                if (proyecto != "")
                {
                    dgBrief.DataSource = db.sp_ObtenerProyectosBrief(proyecto).ToList();
                    dgBrief.DataBind();
                    dgBrief.SelectedIndex = -1;
                }
                else 
                {
                    dgBrief.DataSource = db.sp_ObtenerProyectosBrief("NUEVO").ToList();
                    dgBrief.DataBind();
                    dgBrief.SelectedIndex = -1;
                }
            }
        }
        protected void btn13_Click(object sender, EventArgs e)
        {

        }

        protected void ActualizaCabecera(object sender, EventArgs e)
        {
            if(FULLSERVICE.Checked)
            {
                tipoMaquila = FULLSERVICE.ID;
            }
            else if (TOLLING.Checked)
            {
                tipoMaquila = TOLLING.ID;
            }
            else if (PROCESO.Checked)
            {
                tipoMaquila = PROCESO.ID;
            }
            else if (OTROMAQUILA.Checked)
            {
                tipoMaquila = OTROMAQUILA.ID;
            }

            if (tipoMaquila == null || dpSolicitaCoti.Text == "" || txtprodCoti.Text == "" || txtcajasCoti.Text == "" || DropTP.Text == "" || DropTP.Text == "SELECCIONE")
            {

                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Favor de llenar todos los datos.');</script>");
            }
            else
            {
                using (DNPEntities5 db = new DNPEntities5())
                {
                    string tipo_proyecto;
                    tipo_proyecto = DropTP.SelectedValue;
                    db.sp_ActualizaCabeceraBrief(lblProyectoCotiza.Text, Convert.ToInt32(dpSolicitaCoti.SelectedValue), txtprodCoti.Text, Convert.ToInt32(txtcajasCoti.Text), tipoMaquila, "NUEVO", tipo_proyecto);
                    WebUtil.MostrarPopUp(ref pop, "Guardado", "", "");
                }
            }
        }
        protected void ActualizaLegales(object sender, EventArgs e)
        {
            if (txtlegal.Text == "" || txtotrosobs.Text == "" || req_legal.ToString() == "") {

                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Favor de llenar todos los datos.');</script>");
            }          
            else {
                if (radbtn_si.Checked)
                {
                    if (txtlegal.Text == "" || txtotrosobs.Text == "" || req_legal.ToString() == "" || txtEsp.Text == "")
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Favor de llenar todos los datos.');</script>");
                    }
                    else
                        using (DNPEntities5 db = new DNPEntities5())
                        {
                            db.sp_ActualizaLegalBrief(lblProyectoCotiza.Text, txtlegal.Text, txtotrosobs.Text, req_legal.ToString(), txtEsp.Text);
                            WebUtil.MostrarPopUp(ref pop, "Guardado", "", "");
                        }
                }
                else if (radbtn_no.Checked)
                {
                    if (txtlegal.Text == "" || txtotrosobs.Text == "" || req_legal.ToString() == "")
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Favor de llenar todos los datos.');</script>");
                    }
                    else
                        using (DNPEntities5 db = new DNPEntities5())
                        {
                            db.sp_ActualizaLegalBrief(lblProyectoCotiza.Text, txtlegal.Text, txtotrosobs.Text, req_legal.ToString(), txtEsp.Text);
                            WebUtil.MostrarPopUp(ref pop, "Guardado", "", "");
                        }
                }
            }
        }
     
        
        protected void ActualizaFirmas(object sender, EventArgs e)
        {
            String NomUser = this.GetUserbyuser();

            if (NomUser != "")
            {
                using (DNPEntities5 db = new DNPEntities5())
                {
                    string ventas, costos, desarrollo, dir,val;

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
                    //
                    if (chval.Checked)
                        val= lblval.Text;
                    else
                        val = "";
                    db.sp_ActualizaFirmasBrief(lblProyectoCotiza.Text, ventas, costos, desarrollo, dir, val);                   
                    obtenerProyectoFirmado(lblProyectoCotiza.Text);
                    WebUtil.MostrarPopUp(ref pop, "Guardado", "", "");
                }
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
            
            oDE = new DirectoryEntry("LDAP://SWL020", "usistemas", "Carb0LinXtreme", AuthenticationTypes.Secure);
            return oDE;
        }

        protected void btn11_Click(object sender, EventArgs e)
        {

        }

        protected void btnBusca_Click(object sender, EventArgs e)
        {

        }

        protected void Menu3_MenuItemClick(object sender, MenuEventArgs e)
        {
            MenuItem item = e.Item;
            if (item.Value == "0")
            {
                MultiView1.ActiveViewIndex = 0;
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
               
                MultiView1.ActiveViewIndex =3;
            }
            else if (item.Value == "4")
            {
                using (DNPEntities5 db = new DNPEntities5())
                {
                    var Botella = db.dnp_Botella_Brief.Where(x => x.NO_PROYECTO == lblProyectoCotiza.Text).Select(x => x.FORMA).First();
                    if (Botella == "SACHET")
                    {
                       
                    }else
                        MultiView1.ActiveViewIndex = 4;
                }
              
            }
            else if (item.Value == "5")
            {
                MultiView1.ActiveViewIndex = 5;
            }
            else if (item.Value == "6")
            {
               
                using (DNPEntities5 db = new DNPEntities5())
                {
                    var Proyecto = db.view_dnp_proyectosBrief.Where( x => x.NO_PROYECTO == lblProyectoCotiza.Text).Select(x => x.TIPO_PROYECTO).First();
                    if (Proyecto == "GEL" || Proyecto == "CERA GEL" || Proyecto == "AFTER SUN")
                    {
                        CONTRATIPOF.Enabled = true;
                        LINEAF.Enabled = true;
                        OTROSLINEAF.Enabled = true;
                        txtdescF.Enabled = true;
                        txtingredientes.Enabled = true;
                        TRANSPARENTE.Enabled = true;
                        AZUL.Enabled = true;
                        VERDE.Enabled = true;
                        chColorF.Enabled = true;
                        txtOtroColorf.Enabled = true;
                        txtCLAIMS.Enabled = true;
                        MODELADORA.Enabled = true;
                        FIRME.Enabled = true;
                        EXTRAFIRME.Enabled = true;
                        ULTRAFIRME.Enabled = true;
                        NA.Enabled = false;
                        RB30.Enabled = false;
                        RB50.Enabled = false;
                        RBM50.Enabled = false;
                        RBOtros.Enabled = false;
                        RBNA.Checked = true;
                        txtotros.Enabled = false;
                        txtApariencia.Enabled = true;
                        TXTOTROSFORMF.Enabled = true;
                        MultiView1.ActiveViewIndex = 6;
                    }
                    else if (Proyecto == "CERA" || Proyecto == "CREMAS")
                    {
                        CONTRATIPOF.Enabled = true;
                        LINEAF.Enabled = true;
                        OTROSLINEAF.Enabled = true;
                        txtdescF.Enabled = true;
                        txtingredientes.Enabled = true;
                        TRANSPARENTE.Enabled = true;
                        AZUL.Enabled = true;
                        VERDE.Enabled = true;
                        chColorF.Enabled = true;
                        txtOtroColorf.Enabled = true;
                        txtCLAIMS.Enabled = true;
                        MODELADORA.Enabled = true;
                        FIRME.Enabled = true;
                        EXTRAFIRME.Enabled = true;
                        ULTRAFIRME.Enabled = true;
                        NA.Enabled = false;
                        RB30.Enabled = false;
                        RB50.Enabled = false;
                        RBM50.Enabled = false;
                        RBOtros.Enabled = false;
                        RBNA.Checked = true;
                        txtotros.Enabled = false;
                        txtApariencia.Enabled = true;
                        TXTOTROSFORMF.Enabled = true;
                        MultiView1.ActiveViewIndex = 6;

                    }
                    else if (Proyecto == "BLOQUEADOR")
                    {
                        CONTRATIPOF.Enabled = true;
                        LINEAF.Enabled = true;
                        OTROSLINEAF.Enabled = true;
                        txtdescF.Enabled = true;
                        txtingredientes.Enabled = true;
                        TRANSPARENTE.Enabled = true;
                        AZUL.Enabled = true;
                        VERDE.Enabled = true;
                        chColorF.Enabled = true;
                        txtOtroColorf.Enabled = true;
                        txtCLAIMS.Enabled = true;
                        MODELADORA.Enabled = false;
                        FIRME.Enabled = false;
                        EXTRAFIRME.Enabled = false;
                        ULTRAFIRME.Enabled = false;
                        NA.Checked = true;
                        RB30.Enabled = true;
                        RB50.Enabled = true;
                        RBM50.Enabled = true;
                        RBOtros.Enabled = true;
                        RBNA.Enabled = false;
                        txtotros.Enabled = true;
                        txtApariencia.Enabled = true;
                        TXTOTROSFORMF.Enabled = true;
                        MultiView1.ActiveViewIndex = 6;
                    }
                    else
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Regresar al apartado PROYECTO y seleccionar tipo.');</script>");
                        MultiView1.ActiveViewIndex = 1;
                    }
                }
            }
            else if (item.Value == "7")
            {
                MultiView1.ActiveViewIndex = 7;
            }
            else if (item.Value == "8")
            {
                MultiView1.ActiveViewIndex = 8;
               
            }
            else if (item.Value == "9")
            {
                MultiView1.ActiveViewIndex = 9;
            }
            else if (item.Value == "10")
            {
                MultiView1.ActiveViewIndex = 10;            
            }
        }

        protected void MuestraReporte(object sender, EventArgs e)
        {
            ReportViewer1.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Remote;
            
            CustomReportCredentials credentials = new CustomReportCredentials("usistemas", "Carb0LinXtreme", "WET-LINE");
            this.ReportViewer1.ServerReport.ReportServerCredentials = credentials;
            
            ReportViewer1.ServerReport.ReportServerUrl = new Uri("http://swl024/ReportServer");
            ReportViewer1.ServerReport.ReportPath = "/DH_Reports/DNP_REPORTEBRIEF_ANEXO";
            ReportViewer1.ShowParameterPrompts = false;
            ReportViewer1.ShowPrintButton = true;

            Microsoft.Reporting.WebForms.ReportParameter[] reportParameterCollection = new Microsoft.Reporting.WebForms.ReportParameter[1];
            reportParameterCollection[0] = new Microsoft.Reporting.WebForms.ReportParameter();
            reportParameterCollection[0].Name = "CODIGO";
            reportParameterCollection[0].Values.Add(lblProyectoReporte.Text);

            ReportViewer1.ServerReport.SetParameters(reportParameterCollection);
            ReportViewer1.ServerReport.Refresh();
        }

        protected void CargaProyectosBrief(object sender, EventArgs e)
        {
            FiltraProyectosB(txtBusqueda.Text);

        }

        protected void dgBrief_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            string proyecto = e.Item.Cells[0].Text.Trim();
            string desc = e.Item.Cells[2].Text.Trim();
            switch (e.CommandName)
            {
                case "SELECT":
                    {
                        limpiar();
                        obtenerFirmas(proyecto);
                        obtenerCabecera(proyecto);
                        obtenerBotella(proyecto);
                        obtenerTapa(proyecto);
                        obtenerFunda(proyecto);
                        obtenerCorrugado(proyecto);
                        obtenerFormula(proyecto);
                        obtenerLegales(proyecto);
                        obtenerProyectoFirmado(proyecto);
                        setTitle(proyecto,desc);
                        lblProyectoB.Text = proyecto;                       
                        break;
                    }
            }
        }

        protected void materialtipoEti_CheckedChanged(object sender, EventArgs e)
        {
            if (materialtipoEti.Checked)
            {
                BOPPBCO.Enabled = true;
                BOPPTRANSP.Enabled = true;
                BOPPMET.Enabled = true;
                MATEETI.Enabled = true;
                BRILLANTEETI.Enabled = true;
                PVC.Enabled = false;
                PETG.Enabled = false;
                OtroFunda.Enabled= false;
                txtOtrosFunda.Enabled = false;
                MATEF.Enabled = false;
                BRILLANTEF.Enabled = false;
                MONOCAPA.Enabled = false;
                BICAPA.Enabled = false;
                COEXTRUIDO.Enabled = false;
                MATETU.Enabled = false;
                BRILLANTETU.Enabled = false;

            }
            
        }

        protected void BOPPBCO1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialtipofunda.Checked)
            {
                PVC.Enabled = true;
                PETG.Enabled = true;
                OtroFunda.Enabled = true;
                txtOtrosFunda.Enabled = true;
                MATEF.Enabled = true;
                BRILLANTEF.Enabled = true;
                BOPPBCO.Enabled = false;
                BOPPTRANSP.Enabled = false;
                BOPPMET.Enabled = false;
                MATEETI.Enabled = false;
                BRILLANTEETI.Enabled = false;                
                MONOCAPA.Enabled = false;
                BICAPA.Enabled = false;
                COEXTRUIDO.Enabled = false;
                MATETU.Enabled = false;
                BRILLANTETU.Enabled = false;
            }
        }
        protected void materialtipotubo_CheckedChanged(object sender, EventArgs e)
        {
            PVC.Enabled = false;
            PETG.Enabled = false;
            OtroFunda.Enabled = false;
            txtOtrosFunda.Enabled = false;
            MATEF.Enabled = false;
            BRILLANTEF.Enabled = false;
            BOPPBCO.Enabled = false;
            BOPPTRANSP.Enabled = false;
            BOPPMET.Enabled = false;
            MATEETI.Enabled = false;
            BRILLANTEETI.Enabled = false;
            MONOCAPA.Enabled = true;
            BICAPA.Enabled = true;
            COEXTRUIDO.Enabled = true;
            MATETU.Enabled = true;
            BRILLANTETU.Enabled = true;
        }
        private void obtenerCabecera(string noProyecto)
        {
            Panel pnl = Panel1;
            using (DNPEntities5 db = new DNPEntities5())
            {
                view_dnp_proyectosBrief cabecera = db.view_dnp_proyectosBrief.Where(d => d.NO_PROYECTO == noProyecto).First();
                lblProyectoCotiza.Text = cabecera.NO_PROYECTO;
                dpSolicitaCoti.ClearSelection();
                dpSolicitaCoti.Items.FindByText(cabecera.CLIENTE).Selected = true;
                txtprodCoti.Text = cabecera.PRODUCTO;
                txtcajasCoti.Text = Convert.ToString(cabecera.CAJAS);
                DropTP.Text = cabecera.TIPO_PROYECTO;

                foreach (Control ctrl in pnl.Controls)
                {
                    if (ctrl is RadioButton)
                    {
                        RadioButton rb = (RadioButton)ctrl;
                        if (rb.ID == cabecera.ID_MAQUILA)
                            rb.Checked = true;
                    }
                }
            }
                
        }     

        protected void btnFiltro_Click(object sender, EventArgs e)
        {
            FiltraProyectos();
        }

        protected void radbtn_si_CheckedChanged(object sender, EventArgs e)
        {
            txtEsp.Enabled = true;
            req_legal = 'Y';
        }

        protected void radbtn_no_CheckedChanged(object sender, EventArgs e)
        {
            req_legal = 'N';
        }

        protected void btn13_Command(object sender, CommandEventArgs e)
        {

        }

        protected void btnActualizaEstatus_Click(object sender, EventArgs e)
        {
           
        }

        protected void RBotros_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        protected void btnActualizaEstatus_Click1(object sender, EventArgs e)
        {
            using (DNPEntities5 db = new DNPEntities5())
            {
                db.ActualizaStatusBrief(lblProyectoB.Text, ACTESTATUS.Text);

            }
        }

        public void setTitle(string proy, string desc)
        {
            lbltitulo.Text = "BRIEF" + " - " + proy + "  " + desc;
            lblProyectoReporte.Text = proy;
            lblProyectoReporte1.Text = " - "+desc;
        }

        

        protected void ActualizaBotella(object sender, EventArgs e)
        {
            
            string forma = "";
            string material = "";
            string color = "";


            if(TARRO.Checked)
            {
                forma = TARRO.ID;
            }
            else if (BOTELLA.Checked)
            {
                forma = BOTELLA.ID;
            }
            else if (TUBO.Checked)
            {
                forma = TUBO.ID;
            }
            else if (SACHET.Checked)
            {
                forma = SACHET.ID;
            }
            else if (SQUIZ.Checked)
            {
                forma = SQUIZ.ID;
            }


            if (PET.Checked)
            {
                material = PET.ID;
            }
            else if (POLIPROPILENO.Checked)
            {
                material = POLIPROPILENO.ID;
            }
            else if (POLIETILENO.Checked)
            {
                material = POLIETILENO.ID;
            }
            else if (OTROSMAT.Checked)
            {
                material = OTROSMAT.ID;
            }

            if (TRANSPARENTE.Checked)
            {
                color = TRANSPARENTE.ID;
            }
            else if (BLANCO.Checked)
            {
                color = BLANCO.ID;
            }
            else if (NEGRO.Checked)
            {
                color = NEGRO.ID;
            }
            else if (OTROS.Checked)
            {
                color = OTROS.ID;
            }

            if (txtgramaje.Text == "" || forma == "" || material == ""|| color == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Favor de llenar todos los datos.');</script>");
            }
            else
            {

                using (DNPEntities5 db = new DNPEntities5())
                {
                    db.sp_ActualizaBotellaBrief(lblProyectoCotiza.Text, txtgramaje.Text, forma, material, color, txtOtrosColor.Text, txtOtrosMat.Text);
                    WebUtil.MostrarPopUp(ref pop, "Guardado", "", "");
                }
            }
        }
        protected void ActualizaTapa(object sender, EventArgs e)
        {
            if (LINEA.Checked)
            {
                tipotapa = LINEA.ID;
            } 
            else if (ASA.Checked)
            {
                tipotapa = ASA.ID;
            }
            else if (FLITTOP.Checked)
            {
                tipotapa = FLITTOP.ID;
            }
            else if (DISCTOP.Checked)
            {
                tipotapa = DISCTOP.ID;
            }
            else if (CHUPON.Checked)
            {
                tipotapa = CHUPON.ID;
            }
            else if (SPRAYER.Checked)
            {
                tipotapa = SPRAYER.ID;
            }
            else if (OTROSTIPO.Checked)
            {
                tipotapa = OTROSTIPO.ID;
            }


            if (PETTAPA.Checked)
            {
                materialtapa = PETTAPA.ID;
            }
            else if (POLIPROPILENOTAPA.Checked)
            {
                materialtapa = POLIPROPILENOTAPA.ID;
            }
            else if (POLIETILENOTAPA.Checked)
            {
                materialtapa = POLIETILENOTAPA.ID;
            }
            else if (OTROSM.Checked)
            {
                materialtapa = OTROSM.ID;
            }

            if (NATURALTAPA.Checked)
            {
                colortapa = NATURALTAPA.ID;
            }
            else if (COLOR.Checked)
            {
                colortapa = COLOR.ID;
            }


            if (GRABADO.Checked)
            {
                terminadotapa = GRABADO.ID;
            }
            else if (BRILLANTE.Checked)
            {
                terminadotapa = BRILLANTE.ID;
            }
            else if (MATE.Checked)
            {
                terminadotapa = MATE.ID;
            }
            else if (LISA.Checked)
            {
                terminadotapa = LISA.ID;
            }
            else if (ESTRIADA.Checked)
            {
                terminadotapa = ESTRIADA.ID;
            }
            else if (OTROSTERM.Checked)
            {
                terminadotapa = OTROSTERM.ID;
            }

            if (CONLINNER.Checked)
            {
                linnertapa = CONLINNER.ID;
            }
            else if (SINLINNER.Checked)
            {
                linnertapa = SINLINNER.ID;
            }

            if (tipotapa == null|| materialtapa == null || colortapa == null || tipotapa == null || linnertapa == null)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Favor de llenar todos los datos.');</script>");
            }
            else
            {

                using (DNPEntities5 db = new DNPEntities5())
                {
                    db.sp_ActualizaTapaBrief(lblProyectoCotiza.Text, tipotapa, materialtapa, colortapa, terminadotapa, linnertapa, txtotrostipo.Text, txtOtrosMatTapa.Text, txtterminadolinner.Text, txtColorTapa.Text);
                    WebUtil.MostrarPopUp(ref pop, "Guardado", "", "");
                }
            }
        }
        protected void ActualizaFunda(object sender, EventArgs e)
        {

            if (BOPPBCO.Checked)
            {
                MatEtiqueta = BOPPBCO.ID;
            }
            else if (BOPPTRANSP.Checked)
            {
                MatEtiqueta = BOPPTRANSP.ID;
            }
            else if (BOPPMET.Checked)
            {
                MatEtiqueta = BOPPMET.ID;
            }
            else
            {
                MatEtiqueta = null;
            }


            if (MATEETI.Checked)
            {
                TerminadoEtiqueta = MATEETI.ID;
            }
            else if (BRILLANTEETI.Checked)
            {
                TerminadoEtiqueta = BRILLANTEETI.ID;
            }
            else
            {
                TerminadoEtiqueta = null;
            }

            if (PVC.Checked)
            {
                MatFunda = PVC.ID;
            }
            else if (PETG.Checked)
            {
                MatFunda = PETG.ID;
            }
            else if (OtroFunda.Checked)
            {
                MatFunda = OtroFunda.ID;
            }
            else
            {
                MatFunda = null;
            }

            if (MATEF.Checked)
            {
                TermiFunda = MATEF.ID;
            }
            else if (BRILLANTEF.Checked)
            {
                TermiFunda = BRILLANTEF.ID;
            }
            else
            {
                TermiFunda = null;
            }

            if (ROTOGRABADO.Checked)
            {
                impresionFunda = ROTOGRABADO.ID;
            }
            else if (FLEXOGRAFIA.Checked)
            {
                impresionFunda = FLEXOGRAFIA.ID;
            }
            else if (SERIGRAFIA.Checked)
            {
                impresionFunda = SERIGRAFIA.ID;
            }

            if (MONOCAPA.Checked)
            {
                MatTubo = MONOCAPA.ID;
            } else if (BICAPA.Checked)
            {
                MatTubo = BICAPA.ID;
            } else if (COEXTRUIDO.Checked)
            {
                MatTubo = COEXTRUIDO.ID;
            }
            else
            {
                MatTubo = null;
            }
            if (MATETU.Checked)
            {
                TermiTubo = MATETU.ID;
            } else if (BRILLANTETU.Checked)
            {
                TermiTubo = BRILLANTETU.ID;
            }
            else
            {
                TermiTubo = null;

            }
            if (materialtipoEti.Checked == false && materialtipofunda.Checked == false && materialtipotubo.Checked == false)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Favor de seleccionar un tipo de material.');</script>");
            }else
            if (materialtipoEti.Checked){
                if(MatEtiqueta == null || TerminadoEtiqueta == null || impresionFunda == null)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Favor de llenar todos los datos.');</script>");
                }
                else
                {
                    using (DNPEntities5 db = new DNPEntities5())
                    {
                        db.sp_ActualizaFundaBrief(lblProyectoCotiza.Text, MatEtiqueta, TerminadoEtiqueta, MatFunda, TermiFunda, impresionFunda, txtOtrosFunda.Text, MatTubo, TermiTubo);
                        WebUtil.MostrarPopUp(ref pop, "Guardado", "", "");
                    }
                }
            }else if (materialtipofunda.Checked){

                if(MatFunda == null || TermiFunda == null || impresionFunda == null)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Favor de llenar todos los datos.');</script>");
                }
                else
                {
                    using (DNPEntities5 db = new DNPEntities5())
                    {
                        db.sp_ActualizaFundaBrief(lblProyectoCotiza.Text, MatEtiqueta, TerminadoEtiqueta, MatFunda, TermiFunda, impresionFunda, txtOtrosFunda.Text, MatTubo, TermiTubo);
                        WebUtil.MostrarPopUp(ref pop, "Guardado", "", "");
                    }
                }
            }else if (materialtipotubo.Checked){
                if (MatTubo == null || TermiTubo == null || impresionFunda == null){
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Favor de llenar todos los datos.');</script>");
                }
                else{
                    using (DNPEntities5 db = new DNPEntities5())
                    {
                        db.sp_ActualizaFundaBrief(lblProyectoCotiza.Text, MatEtiqueta, TerminadoEtiqueta, MatFunda, TermiFunda, impresionFunda, txtOtrosFunda.Text, MatTubo, TermiTubo);
                        WebUtil.MostrarPopUp(ref pop, "Guardado", "", "");
                    }
                }
            }          
        }
     
        protected void ActualizaCorrugado(object sender, EventArgs e)
        {
            if(KRAFT.Checked)
            {
                MatCorrugado = KRAFT.ID;
            }else if (MICROCORRUGADO.Checked)
            {
                MatCorrugado = MICROCORRUGADO.ID;
            }
            else if (OTROSMATCORRU.Checked)
            {
                MatCorrugado = OTROSMATCORRU.ID;
            }
            else if (BLAN.Checked)
            {
                MatCorrugado = OTROSMATCORRU.ID;
            }


            if (CONIMPRESION.Checked)
            {
                terminadoCorr = CONIMPRESION.ID;
            }
            else if (SINIMPRESION.Checked)
            {
                terminadoCorr = SINIMPRESION.ID;
            }
            else if (ETIQUETA.Checked)
            {
                terminadoCorr = ETIQUETA.ID;
            }


            if (PZAS8.Checked)
            {
                pzasCorru = PZAS8.ID;
            }
            else if (PZAS12.Checked)
            {
                pzasCorru = PZAS12.ID;
            }
            else if (PZAS24.Checked)
            {
                pzasCorru = PZAS24.ID;
            }
            else if (OTROSPZAS.Checked)
            {
                pzasCorru = OTROSPZAS.ID;
            }
            if (MatCorrugado == null || terminadoCorr == null || pzasCorru == null)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Favor de llenar todos los datos.');</script>");
            }
            else
            {
                using (DNPEntities5 db = new DNPEntities5())
                {
                    db.sp_ActualizaCorrugadoBrief(lblProyectoCotiza.Text, MatCorrugado, terminadoCorr, pzasCorru, txtotrospzas.Text);
                    WebUtil.MostrarPopUp(ref pop, "Guardado", "", "");
                }
            }
        }
        public void asingaValor(RadioButton rad)
        {

        }
        protected void ActualizaFormula(object sender, EventArgs e)
        {
            if(CONTRATIPOF.Checked)
            {
                formula = CONTRATIPOF.ID;
            }
            else if (LINEAF.Checked)
            {
                formula = LINEAF.ID;
            }
            else if (OTROSLINEAF.Checked)
            {
                formula = OTROSLINEAF.ID;
            }

            if (TRASNPARENTE.Checked)
            {
                colorf = TRASNPARENTE.ID;
            }
            else if (AZUL.Checked)
            {
                colorf = AZUL.ID;
            }
            else if (VERDE.Checked)
            {
                colorf = VERDE.ID;
            }
            else if (chColorF.Checked)
            {
                colorf = chColorF.ID;
            }

            if (MODELADORA.Checked)
            {
                terminadosf = MODELADORA.ID;
            }
            else if (FIRME.Checked)
            {
                terminadosf = FIRME.ID;
            }
            else if (EXTRAFIRME.Checked)
            {
                terminadosf = EXTRAFIRME.ID;
            }
            else if (ULTRAFIRME.Checked)
            {
                terminadosf = ULTRAFIRME.ID;
            } else if (NA.Checked) {
                terminadosf = NA.ID;
            } if (RB30.Checked)
            {
                bloqueadores = RB30.ID;
            } else if (RB50.Checked)
            {
                bloqueadores = RB50.ID;
            } else if(RBM50.Checked){
                
                bloqueadores = RBM50.ID;
            }
            else if (RBOtros.Checked)
            {
                bloqueadores = RBOtros.ID;
            } else if (RBNA.Checked)
            {
                bloqueadores = RBNA.ID;
            }

            using (DNPEntities5 db = new DNPEntities5())
            {
                var Proyect = db.view_dnp_proyectosBrief.Where(x => x.NO_PROYECTO == lblProyectoCotiza.Text).Select(x => x.TIPO_PROYECTO).First();
                if(Proyect == "GEL" || Proyect == "CERA GEL" || Proyect == "AFTER SUN " || Proyect == "CERA" || Proyect =="CREMAS")
                {
                    if(formula ==null || txtingredientes.Text =="" || colorf == null || txtCLAIMS.Text == "" || terminadosf == null || txtApariencia.Text == "" || TXTOTROSFORMF.Text == "")
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Favor de llenar todos los datos.');</script>");
                    }
                    else
                    {
                         db.sp_ActualizaFromulaBrief(lblProyectoCotiza.Text, formula,txtdescF.Text,txtingredientes.Text, colorf,txtOtroColorf.Text, txtCLAIMS.Text,terminadosf, txtApariencia.Text, TXTOTROSFORMF.Text,lblimagen.Text, bloqueadores, txtotros.Text);
                         WebUtil.MostrarPopUp(ref pop, "Guardado", "", "");
                    }
                }else if(Proyect == "BLOQUEADOR")
                {
                    if (formula == null || txtingredientes.Text == ""|| colorf == null || txtCLAIMS.Text == null || bloqueadores == null || txtApariencia.Text == "" || TXTOTROSFORMF.Text == "")
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Favor de llenar todos los datos.');</script>");
                    }
                    else
                    {
                        db.sp_ActualizaFromulaBrief(lblProyectoCotiza.Text, formula, txtdescF.Text, txtingredientes.Text, colorf, txtOtroColorf.Text, txtCLAIMS.Text, terminadosf, txtApariencia.Text, TXTOTROSFORMF.Text, lblimagen.Text, bloqueadores, txtotros.Text);
                        WebUtil.MostrarPopUp(ref pop, "Guardado", "", "");
                    }
                }



            }
        }
        protected void ActualizaImagen(object sender, EventArgs e)
        {
            using (DNPEntities5 db = new DNPEntities5())
            {
                db.sp_ActualizaImagenBrief(lblProyectoCotiza.Text, lblimagen.Text);
                WebUtil.MostrarPopUp(ref pop, "Guardado", "", "");
            }
        }
        
        private void obtenerBotella(string noProyecto)
        {
            using (DNPEntities5 db = new DNPEntities5())
            {
                dnp_Botella_Brief botella = db.dnp_Botella_Brief.Where(d => d.NO_PROYECTO == noProyecto).FirstOrDefault();
                if (botella != null)
                {
                    txtgramaje.Text = botella.GRAMAJE;
                    Panel pnl = Panel2;
                    foreach (Control ctrl in pnl.Controls)
                    {
                        if (ctrl is RadioButton)
                        {
                            RadioButton rb = (RadioButton)ctrl;
                            if (rb.ID == botella.FORMA && rb.GroupName == "forma")
                                rb.Checked = true;
                            else if (rb.ID == botella.MATERIAL && rb.GroupName == "material")
                                rb.Checked = true;
                            else if (rb.ID == botella.COLOR && rb.GroupName == "color")
                                rb.Checked = true;
                        }
                    }
                    txtOtrosMat.Text = botella.OTROSFORMA;
                    txtOtrosColor.Text = botella.OTROSMATERIAL;
                }
            }

            }
        private void obtenerTapa(string noProyecto)
        {
            using (DNPEntities5 db = new DNPEntities5())
            {
                dnp_TapaBrief tapa = db.dnp_TapaBrief.Where(d => d.NO_PROYECTO == noProyecto).FirstOrDefault();
                if (tapa != null)
                {
                    Panel pnl = Panel3;
                    foreach (Control ctrl in pnl.Controls)
                    {
                        if (ctrl is RadioButton)
                        {
                            RadioButton rb = (RadioButton)ctrl;
                            if (rb.ID == tapa.TIPO && rb.GroupName == "tipo")
                                rb.Checked = true;
                            else if (rb.ID == tapa.MATERIAL && rb.GroupName == "materialtapa")
                                rb.Checked = true;
                            else if (rb.ID == tapa.COLOR && rb.GroupName == "colortapa")
                                rb.Checked = true;
                            else if (rb.ID == tapa.TERMINADO && rb.GroupName == "terminadotapa")
                                rb.Checked = true;
                            else if (rb.ID == tapa.LINNER && rb.GroupName == "linner")
                                rb.Checked = true;
                        }
                    }
                    txtotrostipo.Text = tapa.OTROSTIPO;
                    txtOtrosMatTapa.Text = tapa.OTROSMATERIAL;
                    txtColorTapa.Text = tapa.COLORTEXT;
                   txtterminadolinner.Text = tapa.OTROLINNER;
                }
            }

        }
        private void obtenerFunda(string noProyecto)
        {
            using (DNPEntities5 db = new DNPEntities5())
            {
                dnp_FundaBrief funda = db.dnp_FundaBrief.Where(d => d.NO_PROYECTO == noProyecto).FirstOrDefault();
                if (funda != null)
                {
                    Panel pnl = Panel4;
                    foreach (Control ctrl in pnl.Controls)
                    {
                        if (ctrl is RadioButton)
                        {
                            RadioButton rb = (RadioButton)ctrl;
                            if (rb.ID == funda.MATETI && rb.GroupName == "MatEtiq")
                                rb.Checked = true;
                            else if (rb.ID == funda.TERMINADOETI && rb.GroupName == "TerminadoEti")
                                rb.Checked = true;
                            else if (rb.ID == funda.MATFUNDA && rb.GroupName == "MaterialFunda")
                                rb.Checked = true;
                            else if (rb.ID == funda.TERMINADOFUNDA && rb.GroupName == "TerminadoFunda")
                                rb.Checked = true;
                            else if (rb.ID == funda.IMPRESION && rb.GroupName == "Impresion")
                                rb.Checked = true;
                            else if (rb.ID == funda.MATTUBO && rb.GroupName == "MaterialTubo")
                                rb.Checked = true;
                            else if (rb.ID == funda.TERMINADOTUBO && rb.GroupName == "TerminadoTubo")
                                rb.Checked = true;
                        }
                    }
                    txtOtrosFunda.Text = funda.OTROFUNDA;
                }
            }

        }
        private void obtenerCorrugado(string noProyecto)
        {
            using (DNPEntities5 db = new DNPEntities5())
            {
                dnp_CorrugadoBrief corrugado = db.dnp_CorrugadoBrief.Where(d => d.NO_PROYECTO == noProyecto).FirstOrDefault();
                if (corrugado != null)
                {
                    Panel pnl = Panel5;
                    foreach (Control ctrl in pnl.Controls)
                    {
                        if (ctrl is RadioButton)
                        {
                            RadioButton rb = (RadioButton)ctrl;
                            if (rb.ID == corrugado.MATERIAL && rb.GroupName == "MatCorru")
                                rb.Checked = true;
                            else if (rb.ID == corrugado.TERMINADO && rb.GroupName == "TermiCorr")
                                rb.Checked = true;
                            else if (rb.ID == corrugado.PZAS && rb.GroupName == "pzas")
                                rb.Checked = true;
                        }
                    }
                    txtotrospzas.Text = corrugado.OTROSCORR;
                }
            }

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


        private void obtenerLegales(string noProyecto)
        {
            using (DNPEntities5 db = new DNPEntities5())
            {
                dnp_LegalesBrief legal = db.dnp_LegalesBrief.Where(d => d.NO_PROYECTO == noProyecto).FirstOrDefault();
                if (legal != null)
                {
                    txtlegal.Text = legal.LEGAL;
                    txtotrosobs.Text = legal.OTROS;
                    if (legal.REQUIS_LEGAL == "Y")
                    {
                        radbtn_no.Checked = false;
                        radbtn_si.Checked = true; }
                    else if (legal.REQUIS_LEGAL == "N")
                    {
                        radbtn_si.Checked = false;
                        radbtn_no.Checked = true;                   
                    }
                }
            }

        }
        private void obtenerFormula(string noProyecto)
        {
            using (DNPEntities5 db = new DNPEntities5())
            {
                dnp_FormulaBrief formula = db.dnp_FormulaBrief.Where(d => d.NO_PROYECTO == noProyecto).FirstOrDefault();
                if (formula != null)
                {
                    Panel pnl = Panel6;
                    foreach (Control ctrl in pnl.Controls)
                    {
                        if (ctrl is RadioButton)
                        {
                            RadioButton rb = (RadioButton)ctrl;
                            if (rb.ID == formula.TIPO && rb.GroupName == "formula")
                                rb.Checked = true;
                            else if (rb.ID == formula.COLOR && rb.GroupName == "colorf")
                                rb.Checked = true;
                            else if (rb.ID == formula.TERMINADOS && rb.GroupName == "terminadosf")
                                rb.Checked = true;
                            else if(rb.ID == formula.FPS && rb.GroupName == "bloqueadores")                           
                                rb.Checked = true;
                            
                        }
                    }

                    txtdescF.Text = formula.DESC_TIPO;
                    txtingredientes.Text = formula.INGREDIENTES;
                    txtOtroColorf.Text = formula.COLOROTROS;
                    txtCLAIMS.Text = formula.CLAIMS;
                    txtApariencia.Text = formula.APARIENCIA;
                    lblimagen.Text = formula.IMAGENREFERENCIA;
                    TXTOTROSFORMF.Text = formula.OTROSFORMULA;
                    imgFormula.ImageUrl = ("../Files/brief/" + lblimagen.Text);
                    txtotros.Text = formula.OTROSFPS;
                }else
                {
                    imgFormula.ImageUrl = ("../Files/brief/" + "405");
                }
            }

        }
        private void obtenerProyectoFirmado(string noProyecto)
        {
            string usr = Convert.ToString(Session["User"]);

            using (DNPEntities5 db = new DNPEntities5())
            {
                //ventas
                dnp_ProyectoBrief_Firma firmas = db.dnp_ProyectoBrief_Firma.Where(d => d.NO_PROYECTO == noProyecto).FirstOrDefault();
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
                    if (firmas.VALIDACION != null && firmas.VALIDACION != "")
                    {
                        lblval.Text = firmas.VALIDACION;
                        chval.Checked = true;
                        chval.Enabled = false;
                    }
                    else if (lblval.Text == usr)
                    {
                        chval.Enabled = true;
                        chval.Checked = false;
                    }
                    else
                    {
                        chval.Enabled = false;
                        chval.Checked = false;
                    }
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
        private void obtenerFirmas(string proyecto)
        {
            string usr = Convert.ToString(Session["User"]);

            using (DNPEntities5 db = new DNPEntities5())
            {
                //ventas
                view_dnp_FirmasVentasBrief ventas = db.view_dnp_FirmasVentasBrief.Where(d => d.AREA=="VENTAS" && d.NO_PROYECTO == proyecto).FirstOrDefault();
                if (ventas != null)
                    lblventas.Text = ventas.FIRMA;
                else
                {
                    dnp_FirmasBrief ventas2 = db.dnp_FirmasBrief.Where(d => d.AREA == "VENTAS").FirstOrDefault();
                    lblventas.Text = ventas2.USR;
                }

                //costos
                view_dnp_FirmasVentasBrief costos = db.view_dnp_FirmasVentasBrief.Where(d => d.AREA == "COSTOS" && d.NO_PROYECTO == proyecto).FirstOrDefault();
                if (costos != null)
                    lblcostos.Text = costos.FIRMA;
                else
                {
                    dnp_FirmasBrief costos2 = db.dnp_FirmasBrief.Where(d => d.AREA == "COSTOS").FirstOrDefault();
                    lblcostos.Text = costos2.USR;
                }

                //desarrollo
                view_dnp_FirmasVentasBrief desarrollo = db.view_dnp_FirmasVentasBrief.Where(d =>  d.AREA == "DESARROLLO" && d.NO_PROYECTO == proyecto).FirstOrDefault();
                if (desarrollo != null)
                    lbldesarrollo.Text = desarrollo.FIRMA;
                else
                {
                    dnp_FirmasBrief desarrollo2 = db.dnp_FirmasBrief.Where(d => d.AREA == "DESARROLLO" ).FirstOrDefault();
                    lbldesarrollo.Text = desarrollo2.USR;
                }

                //direccion
                view_dnp_FirmasVentasBrief direccion = db.view_dnp_FirmasVentasBrief.Where(d =>  d.AREA == "DIRECCION" && d.NO_PROYECTO == proyecto).FirstOrDefault();
                if (direccion != null)
                    lbldir.Text = direccion.FIRMA;
                else
                {
                    dnp_FirmasBrief dir = db.dnp_FirmasBrief.Where(d => d.AREA == "DIRECCION").FirstOrDefault();
                    lbldir.Text = dir.USR;
                }
                //validacion
                view_dnp_FirmasVentasBrief validacion = db.view_dnp_FirmasVentasBrief.Where(d => d.AREA == "VALIDACION" && d.NO_PROYECTO == proyecto).FirstOrDefault();
                if (direccion != null)
                    lblval.Text = validacion.FIRMA;
                else
                {
                    dnp_FirmasBrief VAL = db.dnp_FirmasBrief.Where(d => d.AREA == "VALIDACION").FirstOrDefault();
                    lblval.Text = VAL.USR;
                }

            }

        }
        protected void GetCheckedRB(object sender, EventArgs e)
        {
            RadioButton cbSeleccionado = (RadioButton)sender;
            bool valor = cbSeleccionado.Checked;
            if (cbSeleccionado.GroupName == "maquila" && cbSeleccionado.Checked)
            {
                tipoMaquila = cbSeleccionado.ID;
            }
            else if (cbSeleccionado.GroupName == "color" && cbSeleccionado.Checked)
            {
                colorbotella = cbSeleccionado.ID;                
            }
            else if (cbSeleccionado.GroupName == "material" && cbSeleccionado.Checked)
            {
                materialbotella = cbSeleccionado.ID;
               
            }
            else if (cbSeleccionado.GroupName == "forma" && cbSeleccionado.Checked)
            {
                formabotella = cbSeleccionado.ID;
            }
            else if (cbSeleccionado.GroupName == "tipo" && cbSeleccionado.Checked)
            {
                tipotapa = cbSeleccionado.ID;
             
            }
            else if (cbSeleccionado.GroupName == "materialtapa" && cbSeleccionado.Checked)
            {
                materialtapa = cbSeleccionado.ID;
            }
            else if (cbSeleccionado.GroupName == "colortapa" && cbSeleccionado.Checked)
            {
                colortapa = cbSeleccionado.ID;
            }
            else if (cbSeleccionado.GroupName == "terminadotapa" && cbSeleccionado.Checked)
            {
                terminadotapa = cbSeleccionado.ID;
            }
            else if (cbSeleccionado.GroupName == "linner" && cbSeleccionado.Checked)
            {
                linnertapa = cbSeleccionado.ID;
            }
            else if (cbSeleccionado.GroupName == "MatEtiq" && cbSeleccionado.Checked)
            {
                MatEtiqueta = cbSeleccionado.ID;
                materialtipoEti.Checked = true;
                materialtipofunda.Checked = false;
                txtOtrosFunda.Text = "";
                PVC.Checked = false;
                PETG.Checked = false;
                OtroFunda.Checked = false;
                txtOtrosFunda.Text = "";
                MATEF.Checked = false;
                BRILLANTEF.Checked = false;

            }
            else if (cbSeleccionado.GroupName == "TerminadoEti" && cbSeleccionado.Checked)
            {
                TerminadoEtiqueta = cbSeleccionado.ID;
                materialtipoEti.Checked = true;
                materialtipofunda.Checked = false;
                txtOtrosFunda.Text = "";
                PVC.Checked = false;
                PETG.Checked = false;
                OtroFunda.Checked = false;
                txtOtrosFunda.Text = "";
                MATEF.Checked = false;
                BRILLANTEF.Checked = false;
            }
            else if (cbSeleccionado.GroupName == "MaterialFunda" && cbSeleccionado.Checked)
            {
                MatFunda = cbSeleccionado.ID;
                materialtipoEti.Checked = false;
                materialtipofunda.Checked = true;
                BOPPBCO.Checked = false;
                BOPPTRANSP.Checked = false;
                BOPPMET.Checked = false;
                MATEETI.Checked = false;
                BRILLANTEETI.Checked = false;
            }
            else if (cbSeleccionado.GroupName == "TerminadoFunda" && cbSeleccionado.Checked)
            {
                TermiFunda = cbSeleccionado.ID;
                materialtipoEti.Checked = false;
                materialtipofunda.Checked = true;
                BOPPBCO.Checked = false;
                BOPPTRANSP.Checked = false;
                BOPPMET.Checked = false;
                MATEETI.Checked = false;
                BRILLANTEETI.Checked = false;
            }
            else if (cbSeleccionado.GroupName == "Impresion" && cbSeleccionado.Checked)
            {
                impresionFunda = cbSeleccionado.ID;
            }
            else if (cbSeleccionado.GroupName == "MatCorru" && cbSeleccionado.Checked)
            {
                MatCorrugado = cbSeleccionado.ID;
            }
            else if (cbSeleccionado.GroupName == "TermiCorr" && cbSeleccionado.Checked)
            {
                terminadoCorr = cbSeleccionado.ID;
            }
            else if (cbSeleccionado.GroupName == "pzas" && cbSeleccionado.Checked)
            {
                pzasCorru = cbSeleccionado.ID;
            }
            else if (cbSeleccionado.GroupName == "formula" && cbSeleccionado.Checked)
            {
                formula = cbSeleccionado.ID;
            }
            else if (cbSeleccionado.GroupName == "colorf" && cbSeleccionado.Checked)
            {
                colorf = cbSeleccionado.ID;
                if (cbSeleccionado.ID == "chColorF")
                {
                    txtOtroColorf.Enabled = true;
                    txtOtroColorf.Text = "";
                }
                else
                {
                    txtOtroColorf.Enabled = false;
                    txtOtroColorf.Text = "";
                }
            }
            else if (cbSeleccionado.GroupName == "terminadosf" && cbSeleccionado.Checked)
            {
                terminadosf = cbSeleccionado.ID;
           
            }else if(cbSeleccionado.GroupName == "bloqueadores" && RBOtros.Checked == true)
            {
                bloqueadores = cbSeleccionado.ID;
            }
            else if (cbSeleccionado.GroupName == "TerminadoTubo" && cbSeleccionado.Checked)
            {
                TermiTubo = cbSeleccionado.ID;

            }
            else if (cbSeleccionado.GroupName == "MaterialTubo" && cbSeleccionado.Checked)
            {
                MatTubo = cbSeleccionado.ID;

            }

        }


        public void limpiar()
        {
            lblProyectoCotiza.Text = "";
            txtprodCoti.Text = "";
            txtcajasCoti.Text = "";
            FULLSERVICE.Checked = false;
            TOLLING.Checked = false;
            PROCESO.Checked = false;
            OTROMAQUILA.Checked = false;
            txtgramaje.Text = "";
            txtOtrosMat.Text = "";
            txtOtrosColor.Text = "";
            TARRO.Checked = false;
            PET.Checked = false;
            TRANSPARENTE.Checked = false;
            BOTELLA.Checked = false;
            TUBO.Checked = false;
            SACHET.Checked = false;
            SQUIZ.Checked = false;
            POLIPROPILENO.Checked = false;
            POLIETILENO.Checked = false;
            OTROSMAT.Checked = false;
            //chOtrosMat.Checked = false;
            BLANCO.Checked = false;
            NEGRO.Checked = false;
            OTROS.Checked = false;
            LINEA.Checked = false;
            ASA.Checked = false;
            FLITTOP.Checked = false;
            CHUPON.Checked = false;
            SPRAYER.Checked = false;
            OTROSTIPO.Checked = false;
            PETTAPA.Checked = false;
            POLIPROPILENO.Checked = false;
            POLIETILENOTAPA.Checked = false;
            OTROSM.Checked = false;
            txtOtrosMatTapa.Text = "";
            NATURALTAPA.Checked = false;
            COLOR.Checked = false;
            txtColorTapa.Text = "";
            GRABADO.Checked = false;
            BRILLANTE.Checked = false;
            MATE.Checked = false;
            LISA.Checked = false;
            ESTRIADA.Checked = false;
            OTROSTERM.Checked = false;
            txtterminadolinner.Text = "";
            CONLINNER.Checked = false;
            SINLINNER.Checked = false;
            BOPPBCO.Checked = false;
            BOPPTRANSP.Checked = false;
            BOPPMET.Checked = false;
            MATEETI.Checked = false;
            BRILLANTEETI.Checked = false;
            PVC.Checked = false;
            PETG.Checked = false;
            OtroFunda.Checked = false;
            MATEF.Checked = false;
            BRILLANTEF.Checked = false;
            ROTOGRABADO.Checked = false;
            FLEXOGRAFIA.Checked = false;
            KRAFT.Checked = false;
            OTROSMATCORRU.Checked = false;
            CONIMPRESION.Checked = false;
            SINIMPRESION.Checked = false;
            ETIQUETA.Checked = false;
            PZAS8.Checked = false;
            PZAS12.Checked = false;
            PZAS24.Checked = false;
            OTROSPZAS.Checked = false;
            txtotrospzas.Text = "";
            CONTRATIPOF.Checked = false;
            LINEAF.Checked = false;
            OTROSLINEAF.Checked = false;
            txtingredientes.Text = "";
            TRANSPARENTE.Checked = false;
            AZUL.Checked = false;
            VERDE.Checked = false;
            chColorF.Checked = false;
            txtCLAIMS.Text = "";
            MODELADORA.Checked = false;
            FIRME.Checked = false;
            EXTRAFIRME.Checked = false;
            ULTRAFIRME.Checked = false;
            txtApariencia.Text = "";
            TXTOTROSFORMF.Text="";
            imgFormula.ImageUrl = ("../Files/brief/" + "405");
            chventas.Checked = false;
            chcostos.Checked = false;
            chdesarrollo.Checked = false;
            chdir.Checked = false;
            txtpass.Text = "";
            lblProyectoReporte.Text = "";
            lblProyectoReporte1.Text = "";
            txtlegal.Text = "";
            txtotrosobs.Text = "";
        }
        

    }
}