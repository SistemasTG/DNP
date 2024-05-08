using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Net;

namespace DNP
{
    public class cIdentificacion
    {

        public void CargarDataGrid(ref DataGrid dg, string parametro, string sp)
        {
           
            dg.CurrentPageIndex = 0;
            clUtil oUtil = new clUtil();
            SqlCommand cmdWH = new SqlCommand();
            cmdWH.Connection = oUtil.ADOS_DH;
            cmdWH.CommandType = CommandType.StoredProcedure;
            cmdWH.CommandText = sp;
            cmdWH.Parameters.Add("@busqueda", SqlDbType.VarChar);
            cmdWH.Parameters["@busqueda"].Value = parametro;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdWH);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dg.DataSource = dataSet.Tables[0].DefaultView;
            dg.DataBind();

        }
        public void CargarGridView(ref GridView dg, string parametro, string sp)
        {
            //dg.CurrentPageIndex = 0;
            clUtil oUtil = new clUtil();
            SqlCommand cmdWH = new SqlCommand();
            cmdWH.Connection = oUtil.ADOS_DH;
            cmdWH.CommandType = CommandType.StoredProcedure;
            cmdWH.CommandText = sp;
            cmdWH.Parameters.Add("@busqueda", SqlDbType.VarChar);
            cmdWH.Parameters["@busqueda"].Value = parametro;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdWH);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dg.DataSource = dataSet.Tables[0].DefaultView;
            dg.DataBind();

        }
        public DataSet CargarGridViewFilaNueva(string parametro, string sp)
        {
            //dg.CurrentPageIndex = 0;
            clUtil oUtil = new clUtil();
            SqlCommand cmdWH = new SqlCommand();
            cmdWH.Connection = oUtil.ADOS_DH;
            cmdWH.CommandType = CommandType.StoredProcedure;
            cmdWH.CommandText = sp;
            cmdWH.Parameters.Add("@busqueda", SqlDbType.VarChar);
            cmdWH.Parameters["@busqueda"].Value = parametro;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdWH);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet;
            //dg.DataSource = dataSet.Tables[0].DefaultView;
            //dg.DataBind();

        }
        public void CargarDataGridPerfiles(ref DataGrid dg, string parametro, string sp)
        {
            dg.CurrentPageIndex = 0;
            clUtil oUtil = new clUtil();
            SqlCommand cmdWH = new SqlCommand();
            cmdWH.Connection = oUtil.ADOS_DH;
            cmdWH.CommandType = CommandType.StoredProcedure;
            cmdWH.CommandText = sp;
            cmdWH.Parameters.Add("@busqueda", SqlDbType.VarChar);
            cmdWH.Parameters["@busqueda"].Value = parametro;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdWH);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dg.DataSource = dataSet.Tables[0].DefaultView;
            dg.DataBind();

        }
        public void CargarDataGridConocimientos(ref GridView dg, int parametro1, string parametro2, string sp)
        {
            //dg.CurrentPageIndex = 0;
            clUtil oUtil = new clUtil();
            SqlCommand cmdWH = new SqlCommand();
            cmdWH.Connection = oUtil.ADOS_DH;
            cmdWH.CommandType = CommandType.StoredProcedure;
            cmdWH.CommandText = sp;
            cmdWH.Parameters.Add("@idDepto", SqlDbType.Int);
            cmdWH.Parameters["@idDepto"].Value = parametro1;
            cmdWH.Parameters.Add("@busqueda", SqlDbType.VarChar);
            cmdWH.Parameters["@busqueda"].Value = parametro2;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdWH);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dg.DataSource = dataSet.Tables[0].DefaultView;
            dg.DataBind();

        }
        public DataTable obtenerObtenerCamposLogin(string Consulta, string Parametro, string Parametro2)
        {
            string conex = ConfigurationManager.ConnectionStrings["CNXSTR"].ConnectionString;
            string query = "";

            query = Consulta;
            using (SqlConnection conn = new SqlConnection(conex))
            {

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@busqueda", Parametro);
                cmd.Parameters.AddWithValue("@busqueda2", Parametro2);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return dt;
                }
                else
                {
                    //dt = null;
                    return dt;
                }

            }
        }
        public DataTable GuardarCamposLogin(string Consulta,string usr, string Parametro, string Parametro2)
        {
            string conex = ConfigurationManager.ConnectionStrings["CNXSTR"].ConnectionString;
            string query = "";

            query = Consulta;
            using (SqlConnection conn = new SqlConnection(conex))
            {

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@busqueda", Parametro);
                cmd.Parameters.AddWithValue("@busqueda2", Parametro2);
                cmd.Parameters.AddWithValue("@usr", usr);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return dt;
                }
                else
                {
                    //dt = null;
                    return dt;
                }

            }
        }
        public DataTable obtenerObtenerCampos(string Consulta,string Parametro)
        {
            string conex = ConfigurationManager.ConnectionStrings["CNXSTR"].ConnectionString;
            string query = "";
       
            query = Consulta;
            using (SqlConnection conn = new SqlConnection(conex))
            {

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@busqueda", Parametro);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return dt;
                }
                else
                {
                    //dt = null;
                    return dt;
                }

            }
        }

        public void CargarCombos(ref DropDownList dg, string sSql, string value, string display)
        {

            clUtil oUtil = new clUtil();
            SqlCommand cmdWH2 = new SqlCommand();
            cmdWH2.Connection = oUtil.ADOS_DH;
            cmdWH2.CommandType = CommandType.Text;
            cmdWH2.CommandText = sSql;
            SqlDataReader dr = cmdWH2.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                oUtil.CargaCombo(ref dg, sSql, value, display, "SELECCIONE");
            }
            else
            {
                //WebUtil.MostrarPopUp(ref pop, "El Departamento no existe en el sistema", "Modifcar Departamento");
            }
            dr.Close();
            oUtil = null;

        }
    }
}