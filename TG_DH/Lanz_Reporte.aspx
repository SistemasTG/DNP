<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Lanz_Reporte.aspx.cs" Inherits="DNP.Lanz_Reporte" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc2" %>
<%@ Register assembly="EeekSoft.Web.PopupWin" namespace="EeekSoft.Web" tagprefix="Web" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <link rel="stylesheet" href="Css/stylePerfil.css" type="text/css" media="screen"/>
    
   <table style="width: 100%;">
       <tr>
            <td>
                <Center>
                       <table style="width: 80%;">
                       <tr>
                           <td class="auto-style11"></td>
                           <td class="auto-style10"><hr /></td>
                           <td class="auto-style10"></td>
                       </tr>
                       <tr>
                           <td class="auto-style12">&nbsp;</td>
                           <td aling="center">
                              <center> <div class="divTitulo">
                                    <asp:Label ID="lbltitulo" runat="server" Text="REPORTE LANZAMIENTO" Font-Names="Arial" Font-Strikeout="False" ForeColor="White" Font-Bold="True" Font-Size="Medium"></asp:Label>
                                </div>
                                  </center>
                           </td>
                           <td>&nbsp;</td>
                       </tr>
                            <tr>
                           <td class="auto-style12">&nbsp;</td>
                           <td>
                                 <asp:MultiView ID="MultiView1" runat="server">
                                 <asp:View ID="View1" runat="server">    
                                <table style="width:100%;">
                                         <tr>                                             <td class="auto-style841"></td>
                                             <td align="center">
                                                 <asp:Label ID="Label92" runat="server" Font-Names="Arial Narrow" Text="BUSQUEDA:"></asp:Label>
                                                 <asp:TextBox ID="txtBusqueda" runat="server" Font-Size="Small" Height="17px" OnTextChanged="txtBusqueda_TextChanged" Style="text-transform: uppercase" Width="310px"></asp:TextBox>
                                                 <asp:Label ID="Label15" runat="server" Font-Names="Arial" Font-Size="X-Small" Text="Ej. PROYECTO, CLIENTE, PRODCUTO."></asp:Label>
                                                 <asp:CheckBox ID="chArchivado" runat="server" Font-Names="Arial Narrow" Text="Archivo" />
                                                 <asp:Button ID="btnBusca" runat="server" OnClick="btnMostrar_Click" Text="BUSCAR" CssClass="btn-Pasos" Font-Bold="True" Font-Names="Arial" Font-Size="10pt" Height="21px" Width="88px" />
                                             </td>
                                             <td class="auto-style840"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style845">&nbsp;</td>
                                             <td ALIGN ="center">
                                                 <div style="height: 250px; width: 743px; overflow: scroll;">
                                                 <asp:DataGrid ID="dgPerfil" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Font-Names="Arial" Font-Size="Small" ForeColor="#003366" GridLines="Vertical" Height="226px" PageSize="4" Width="700px" OnItemCommand="dgPerfil_ItemCommand">
                                                     <Columns>
                                                         <asp:BoundColumn DataField="NO_PROYECTO" HeaderText="PROYECTO"></asp:BoundColumn>
                                                         <asp:BoundColumn DataField="PRODUCTO_DES" HeaderText="PRODUCTO"></asp:BoundColumn>
                                                         <asp:BoundColumn DataField="NOMBRE" HeaderText="CLIENTE"></asp:BoundColumn>
                                                         <asp:BoundColumn DataField="DESCRIPCION" HeaderText="ESTATUS"></asp:BoundColumn>
                                                         <asp:ButtonColumn CommandName="SELECT" HeaderText="REPORTE" Text="REPORTE"></asp:ButtonColumn>
                                                         
                                                     </Columns>
                                                     <FooterStyle BackColor="#000066" Font-Bold="True" ForeColor="White" />
                                                     <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                                                     <ItemStyle ForeColor="#000066" />
                                                     <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" Mode="NumericPages" />
                                                     <SelectedItemStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                                 </asp:DataGrid>
                                                 </div>
                                             </td>
                                             <td>
                                                 &nbsp;</td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style845">&nbsp;</td>
                                             <td class="auto-style844">&nbsp;</td>
                                             <td>&nbsp;</td>
                                         </tr>
                                     </table>
                                     </asp:View>
                                     <asp:View ID="View2" runat="server"> 
                                            <table style="width: 100%;">
                                   <tr>
                                       <td class="auto-style5">
                                        <Web:PopupWin ID="pop" runat="server" AutoShow="False" style="top: 0px; left: 0px; height: 154px; width: 216px" />
                                       </td>
                                       <td class="auto-style4">
                                           &nbsp;</td>
                                       <td class="auto-style6">
                                           &nbsp;</td>
                                       <td class="auto-style9">
                                           &nbsp;</td>
                                       <td>&nbsp;</td>
                                   </tr>
                               </table> 
                                         </asp:View>
                                     </asp:MultiView>                       
                           </td>
                           <td>&nbsp;</td>
                       </tr>
                           <tr>
                           <td class="auto-style12">&nbsp;</td>
                           <td>
                               <table style="width: 100%;">
                                   <tr>
                                       <td class="auto-style7"> &nbsp;</td>
                                       <td class="auto-style8">
                                           <rsweb:ReportViewer ID="ReportViewer1" runat="server" Height="540px" Width="807px">
                                           </rsweb:ReportViewer>
                                       </td>
                                       <td>&nbsp;</td>
                                   </tr>
                                   <tr>
                                       <td class="auto-style7">&nbsp;</td>
                                       <td class="auto-style8">

                                            <asp:ScriptManager ID="ScriptManager1" runat="server">
                                        </asp:ScriptManager>
                                       </td>
     <td>

                                            &nbsp;</td>
                                   </tr>
                                   <tr>
                                       <td class="auto-style7">&nbsp;</td>
                                       <td class="auto-style8">&nbsp;</td>
                                       <td>&nbsp;</td>
                                   </tr>
                               </table>  
                               </td>
                               </tr>
                               </Center>        
                  </td>
            </tr>
        </table>          
    </asp:Content>
