using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using TG_DNP;

namespace DNP
{
    public partial class Site1 : System.Web.UI.MasterPage 
    {
        SqlConnection cnx;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                menu();
            }

        }
      

        private void menu()
        {
            ////if (Session["User"] == null)
            ////{
            ////    Page.Response.redirect("Default.aspx");
            ////}

            //string User = Session["User"].ToString();
            //cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CNXSTR"].ConnectionString);
            //string cmdSQL = "SELECT Id_Seccion FROM dbo.dnp_LlenadoCoti  WHERE dbo.dnp_LlenadoCoti.Usuario = '" + User + "'";
            //SqlDataAdapter da = new SqlDataAdapter(cmdSQL, cnx);
            //DataSet ds = new DataSet();
            //DataTable dt = new DataTable();
            //try
            //{
            //    cnx.Open();
            //    da.Fill(ds);
            //    dt = ds.Tables[0];
            //    if (dt != null && dt.Rows.Count == 0)
            //    {
            //                MenuItem mnuItem = Menu1.FindItem("COTIZACIONES");
            //                Menu1.Items.Remove(mnuItem);

                       
            //    }
                
            //}
            //catch (Exception ex)
            //{
            //    Response.Write(ex.Message.ToString());
            //}
            //finally
            //{
            //    cnx.Close();
            //    da.Dispose();
            //    ds.Dispose();
            //    dt.Dispose();
            //}


        }
        public void menu2()
        {
            //using (DNPEntityfm db = new DNPEntityfm())
            //{
            //    string User = Session["User"].ToString();
            //    var cotizaciones = db.dnp_LlenadoCoti.Where(b => b.Usuario == User && b.Id_Seccion == 1);
               
            //    if (cotizaciones == null)
            //    {
            //        MenuItem mnuItem = Menu1.FindItem("COTIZACIONES");
            //        Menu1.Items.Remove(mnuItem);
            //    }

            //    var brief = db.dnp_LlenadoCoti.Where(b => b.Usuario == User && b.Id_Seccion == 2);

            //    if (brief == null)
            //    {
            //        MenuItem mnuItem = Menu1.FindItem("BRIEF");
            //        Menu1.Items.Remove(mnuItem);
            //    }
            //}
        }
    protected void AddChildItem(ref MenuItem miMenuItem, DataTable dt)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToInt32(dr[1]) == Convert.ToInt32(miMenuItem.Value) && Convert.ToInt32(dr[0]) != Convert.ToInt32(dr[1]))
                {
                    MenuItem miMenuItemChild = new MenuItem(Convert.ToString(dr[2]), Convert.ToString(dr[0]), String.Empty, Convert.ToString(dr[4]));
                    miMenuItem.ChildItems.Add(miMenuItemChild);
                    AddChildItem(ref miMenuItemChild, dt);
                }
            }
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void Menu1_MenuItemClick(object sender, System.Web.UI.WebControls.MenuEventArgs e)
        {
            menu2();
        }

        protected void Menu1_DataBinding(object sender, EventArgs e)
        {
         //   paginas.Attributes["src"] = Menu1.Target.ToString();
        }

        protected void Menu1_MenuItemClick1(object sender, MenuEventArgs e)
        {
            if (Menu1.SelectedValue == "FORMULARIO LANZAMIENTOS")
            {
                //Session.Abandon();
                //Session.Clear();
                Page.Response.Redirect("Lanzamientos.aspx");
            }
            else if (Menu1.SelectedValue == "REPORTE LANZAMIENTOS")
            {
                //string FilePath = Server.MapPath("MANUAL.pdf");
                //WebClient User = new WebClient();
                //Byte[] FileBuffer = User.DownloadData(FilePath);
                //if (FileBuffer != null)
                //{
                //    Response.ContentType = "application/pdf";
                //    Response.AddHeader("content-length", FileBuffer.Length.ToString());
                //    Response.BinaryWrite(FileBuffer);
                //}
                Page.Response.Redirect("Lanz_Reporte.aspx");
            }
            else if (Menu1.SelectedValue == "COTIZACIONES")
            {
                Page.Response.Redirect("Cotizaciones.aspx");
            }
            else if (Menu1.SelectedValue == "FORMULARIO BRIEF")
            {
                Page.Response.Redirect("Brief.aspx");
            }
            else if (Menu1.SelectedValue == "INICIO")
            {
                Page.Response.Redirect("Principal.aspx");
            }
        }


        protected void Menu2_MenuItemClick(object sender, MenuEventArgs e)
        {
            if (Menu2.SelectedValue == "SALIR")
            {
                Session.Abandon();
                Session.Clear();
                Page.Response.Redirect("Default.aspx");
            }
            //else if (Menu2.SelectedValue == "EDICIÓN")
            //{
            //    //string FilePath = Server.MapPath("MANUAL.pdf");
            //    //WebClient User = new WebClient();
            //    //Byte[] FileBuffer = User.DownloadData(FilePath);
            //    //if (FileBuffer != null)
            //    //{
            //    //    Response.ContentType = "application/pdf";
            //    //    Response.AddHeader("content-length", FileBuffer.Length.ToString());
            //    //    Response.BinaryWrite(FileBuffer);
            //    //}
            //    Page.Response.Redirect("Default.aspx");
            //}

        }
    }
}