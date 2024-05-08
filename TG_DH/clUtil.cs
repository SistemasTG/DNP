using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using EeekSoft.Web;
using System.IO;
using System.Configuration;
using System.DirectoryServices;
using System.Web.Configuration;


namespace DNP
{
    public class clUtil
    {
        internal SqlConnection ADOS_DH = null;
        string title = "";
        internal SqlCommand cmdWH = null;
        public clUtil()
        {
            try
            {
                /*string sCNX = ConfigurationSettings.AppSettings["CNXWH"];*/
                /*string sxServ = WebConfigurationManager.AppSettings["SServ"].ToString();
                string sxCat = WebConfigurationManager.AppSettings["SCat"].ToString();
                string sxUsr = WebConfigurationManager.AppSettings["SUsr"].ToString();
                string sxPwd = WebConfigurationManager.AppSettings["SPwd"].ToString();*/

                string sCNX = WebConfigurationManager.ConnectionStrings["CNXSTR"].ToString();
                //ADOSWET_HELP = new ADOUtilities08.SQLAccess(sCNX);

                /* ADOSWET_HELP = new ADOUtilities08.SQLAccess(sxServ, sxCat, sxUsr, sxPwd); */

                ADOS_DH = new SqlConnection(sCNX);
                ADOS_DH.Open();
                // Define Comando 
                cmdWH = new SqlCommand();
                cmdWH.Connection = ADOS_DH;




            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }

        }
        internal string setTitle(int index, string prod)
        {
            if (index == 0)
            {
                title = "BUSCAR";
            }
            else if (index == 1)
            {
                title = "CABECERA - " + prod;
            }
            else if (index == 2)
            {
                title = "1.0 PRODUCTO A DESARROLLAR - " + prod;
            }
            else if (index == 3)
            {
                title = "2.0 ESPECIFICACIONES FÍSICO-QUÍMICAS - " + prod;
            }
            else if (index ==4)
            {
                title = "3.0 ESPECIFICACIONES SENSORIALES - " + prod;
            }
            else if (index == 5)
            {
                title = "5.0 ESPECIFICACIONES DE EMPAQUE - " + prod;
            }
            else if (index == 6)
            {
                title = "6.0 CODIGO DE BARRAS - " + prod;
            }
            else if (index == 7)
            {
                title = "7.0 EMBALAJE - " + prod;
            }
            else if (index == 8)
            {
                title = "IMAGENES - " + prod;
            }
            else if (index == 8)
            {
                title = "OBSERVACIONES - " + prod;
            }
            else if (index == 8)
            {
                title = "FIRMAS - " + prod;
            }
            else if (index == 11)
            {
                title = "4.0 EQUIPO DE FORMULACIÓN " + prod;
            }
            else if (index == 12)
            {
                title = "8.0 EQUIPO DE ENVASADO: " + prod;
            }
            return title;
        }

        internal void CargaCombo(ref DropDownList Combo, string sSql, string sFieldBound, string sFielddisplay)
        {
            CargaCombo(ref Combo, sSql, sFieldBound, sFielddisplay, "");
        }

        internal void CargaCombo(ref DropDownList Combo, string sSql, string sFieldBound, string sFieldDisplay, string sValorExtra)
        {
            cmdWH.CommandType = CommandType.Text;
            cmdWH.CommandText = sSql;
            SqlDataReader dr = cmdWH.ExecuteReader();
            /*SqlDataReader dr = ADOSWET_HELP.ObtenerDataReader(sSql);*/

            AsignaDatosCombo(ref Combo, ref dr, sFieldBound, sFieldDisplay);

            dr.Close();

            if (sValorExtra != "")
            {
                ListItem li = new ListItem(sValorExtra, "0");
                Combo.Items.Insert(0, li);
            }
        }

        internal void AsignaDatosCombo(ref DropDownList Combo, ref SqlDataReader dr, string sFieldBound, string sFieldDisplay)
        {
            Combo.Items.Clear();
            Combo.DataSource = dr;
            Combo.DataValueField = sFieldBound;
            Combo.DataTextField = sFieldDisplay;
            Combo.DataBind();
        }
    }
    public class WebUtil : clUtil
    {

        public WebUtil()
        {
         }

        public static void MostrarPopUp(ref EeekSoft.Web.PopupWin PopUp, string sMensaje, string sTitulo, string sText)
        {
            PopUp.Message = sMensaje;
            PopUp.Title = sTitulo;
            PopUp.AutoShow = true;
            PopUp.Text = sText;
        }
    }    
}