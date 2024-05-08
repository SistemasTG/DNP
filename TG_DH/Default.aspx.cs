using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.DirectoryServices;
using System.Data;//DataBase
using System.Data.SqlClient;//DataBase
using System.Web.Security;
using DNP;
using System.Configuration;//FormsAuthenticationTicket


namespace DNP
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
            }
        }
        protected void ingresa()
        {
            Session["User"] = txtUser.Text.ToUpper();
            Page.Response.Redirect("Principal.aspx");
        }
        public void noEmp()
        {
            if (txtUser.Text.Length == 4)
            {
                txtUser.Text = "0" + txtUser.Text;
            } else if (txtUser.Text.Length == 3)
            {
                txtUser.Text = "00" + txtUser.Text;
            }
            else if (txtUser.Text.Length == 2)
            {
                txtUser.Text = "000" + txtUser.Text;
            }
            else if (txtUser.Text.Length == 1)
            {
                txtUser.Text = "0000" + txtUser.Text;
            }
        }
            

        protected void Button1_Click(object sender, EventArgs e)
        {
            String NomUser = this.GetUserbyuser();
            string nameuser = txtUser.Text.ToUpper();
            Session["User"] = nameuser.ToUpper();
            obtenerSeccion(txtUser.Text.ToUpper());
            if (Session["User"].ToString() != "" && Session["User"] != null && Session["Seccion"].ToString() != "" && Session["Seccion"].ToString() != null)
            {
                if (NomUser != "")
                {
                    ingresa();
                }
            }
        }
        private String GetUserbyuser()
        {
            try
            {
                String Str = "";
                DirectoryEntry de = GetDirectoryObject();

                de.Username = txtUser.Text;
                de.Password = txtpass.Text;

                //,this.txtUsuario.Text
                DirectorySearcher deSearch = new DirectorySearcher(de);
                deSearch.SearchRoot = de;

                deSearch.Filter = "(&(objectClass=user)(SAMAccountName=" + this.txtUser.Text + "))";
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
                Page.ClientScript.RegisterStartupScript(this.GetType(),"Scripts","<script>alert('Usuario o contraseña incorrecta');</script>");
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
            string consulta = "SELECT * FROM dnp_Llenado WHERE Usuario =  '"+usr+"'";
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

    }
}