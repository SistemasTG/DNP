<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Cotizaciones.aspx.cs" Inherits="DNP.Cotizaciones" %>
<%@ Register assembly="EeekSoft.Web.PopupWin" namespace="EeekSoft.Web" tagprefix="Web" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        
        .btn-login {
            padding: 7px 7px;
            cursor: pointer;
            color: #fff;
            border-radius: 4px;
            border: none;
            background-color: #2ECC71;
            border-bottom: 5px solid #27AE60;
            margin-bottom: 5px;
        }

               
        .auto-style607 {
            width: 1255px;
        }

       
        .auto-style840 {
            height: 23px;
        }

       
        .auto-style841 {
            height: 23px;
            width: 84px;
        }
        .auto-style844 {
            width: 703px;
        }
                                
       
        .auto-style889 {
            width: 1036px;
            height: 32px;
        }
                
       
        .auto-style925 {
            height: 32px;
            width: 1008px;
        }
        
       
        .auto-style939 {
            width: 965px;
            height: 32px;
        }
                
       
        .auto-style942 {
            width: 993px;
            height: 32px;
        }
        .auto-style952 {
            height: 32px;
            width: 1176px;
        }
        
       
        .auto-style955 {
            width: 657px;
            height: 32px;
        }

       
        .auto-style963 {
            height: 32px;
            width: 1313px;
        }
        .auto-style965 {
            height: 32px;
            width: 725px;
        }

       
        .auto-style973 {
            width: 1769px;
            height: 32px;
        }
        .auto-style977 {
            width: 578px;
            height: 32px;
        }
        .auto-style979 {
            width: 1176px;
        }
        .auto-style981 {
            height: 32px;
            width: 1066px;
        }
        
       
        .auto-style984 {
            width: 649px;
            height: 32px;
        }

       
        .auto-style987 {
            width: 1066px;
        }
        .auto-style988 {
            width: 965px;
        }
        .auto-style989 {
            width: 1008px;
        }
        .auto-style994 {
            width: 993px;
        }
        .auto-style996 {
            width: 1769px;
        }
        .auto-style998 {
            width: 1031px;
            height: 32px;
        }
        .auto-style999 {
            height: 32px;
            width: 1150px;
        }

       
        .auto-style1000 {
            width: 133px;
        }
        .auto-style1002 {
            width: 135px;
        }
        .auto-style1004 {
            width: 194px;
        }
        .auto-style1005 {
            width: 111px;
        }
        .auto-style1009 {
            width: 93px;
        }
        .auto-style1010 {
            width: 629px;
        }
        .auto-style1013 {
            width: 238px;
        }
        
       
        .auto-style1015 {
            width: 124px;
        }

       
        .auto-style1016 {
            width: 1031px;
        }
        .auto-style1017 {
            width: 578px;
        }

       
        .auto-style1018 {
            height: 23px;
            width: 168px;
        }
        .auto-style1019 {
            width: 168px;
        }

       
        .auto-style1020 {
            width: 84px;
        }

       
        .auto-style1021 {
            width: 672px;
        }
        .auto-style1022 {
            width: 133px;
            height: 118px;
        }
        .auto-style1023 {
            width: 629px;
            height: 118px;
        }
        .auto-style1024 {
            height: 118px;
        }

       
        .auto-style1025 {
            width: 100%;
        }

       
        </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <script>
        function solonumeros(e) {

            var key;

            if (window.event) // IE
            {
                key = e.keyCode;
            }
            else if (e.which) // Netscape/Firefox/Opera
            {
                key = e.which;
            }

            if (key < 48 || key > 57) {
                return false;
            }

            return true;
        }

    </script>
    <link rel="stylesheet" href="Css/stylePerfil.css" type="text/css" media="screen"/>
    <link href="Content/bootstrap-grid.min.css" rel="stylesheet" />
    <script src="scripts/jquery-1.5.2.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
       <div style="text-align:center; width: 100%; height: 100%">
           <table style="width: 100%;">
           <Web:PopupWin ID="pop" runat="server" AutoShow="False" style="top: 0px; left: 0px; height: 154px; width: 216px" />
               <tr>
                    <td class="auto-style607">
                    <div id="div1" class="container">
                         <center>  <table style="width: 10%;">
                             <tr>
                           <td align="center">
                                <asp:Menu ID="Menu3" runat="server" Orientation="Horizontal" OnMenuItemClick="Menu3_MenuItemClick" Width="839px" MaximumDynamicDisplayLevels="0" Font-Bold="False" Font-Italic="False" Font-Names="Arial Narrow" Font-Strikeout="False" Font-Underline="False" ForeColor="#0416BB" Height="51px" RenderingMode="Table">
                                   <DynamicMenuItemStyle HorizontalPadding="0px" ItemSpacing="0px" VerticalPadding="0px" />
                                   <Items>
                                       <asp:MenuItem Text="BUSCAR" ToolTip="BUSCAR" Value="0" Selected="True"></asp:MenuItem>
                                       <asp:MenuItem Text="PRODUCTO" Value="1" ToolTip="PRODUCTO"></asp:MenuItem>
                                       <asp:MenuItem Text="EMPAQUE" Value="2" ToolTip="EMPAQUE"></asp:MenuItem>
                                       <asp:MenuItem Text="EMBALAJE" Value="3" ToolTip="EMBALAJE"></asp:MenuItem>
                                        <asp:MenuItem Text="COSTOS" Value="5" ToolTip="COSTOS"></asp:MenuItem>
                                       <asp:MenuItem Text="FIRMAS" Value="4" ToolTip="FIRMAS"></asp:MenuItem>                                       
                                       <asp:MenuItem Text="REPORTE" Value="6" ToolTip="REPORTE"></asp:MenuItem>
                                   </Items>
                                   <StaticMenuItemStyle ItemSpacing="100px" VerticalPadding="1px" Font-Bold="False" Font-Italic="False" Font-Names="Calibri" Font-Overline="False" Font-Size="Medium" Font-Underline="False" ForeColor="#666666" />
                                    <StaticMenuStyle HorizontalPadding="1px" VerticalPadding="1px" />
                                   <StaticSelectedStyle ForeColor="#04C0FF" BorderStyle="None" HorizontalPadding="1px" ItemSpacing="1px" />
                               </asp:Menu>                               
                           </td>
                       </tr>
                       <tr>
                           <td align="center"> <hr />                              
                           </td>
                       </tr>
                       <tr>
                           <td align="center"><div class="divTitulo">
                                    <asp:Label ID="lbltitulo" runat="server" Text="BUSCAR" Font-Names="Arial" Font-Strikeout="False" ForeColor="White" Font-Bold="True" Font-Size="Medium"></asp:Label>
                                </div></td>
                       </tr>                      
                      
                             <asp:MultiView ID="MultiView1" runat="server">
                                 <asp:View ID="View1" runat="server">                                    

                                     <table style="width:100%;">
                                         <tr>                                             <td class="auto-style841"></td>
                                             <td align="center">
                                                 <asp:Label ID="Label92" runat="server" Font-Names="Arial Narrow" Text="BUSQUEDA:"></asp:Label>
                                                 <asp:TextBox ID="txtBusqueda" runat="server" Font-Size="Small" Height="17px" OnTextChanged="txtBusqueda_TextChanged" Style="text-transform: uppercase" Width="310px"></asp:TextBox>
                                                 <asp:Label ID="Label15" runat="server" Font-Names="Arial" Font-Size="X-Small" Text="Ej. PROYECTO, CLIENTE, PRODCUTO."></asp:Label>
                                                 <asp:Button ID="btnBusca" runat="server" OnClick="btnBusca_Click" Text="Buscar" />
                                             </td>
                                             <td class="auto-style840"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style1020">&nbsp;</td>
                                             <td class="auto-style844">
                                                 <div style="height: 250px; width: 743px; overflow: scroll;">
                                                 <asp:DataGrid ID="dgPerfil" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Font-Names="Arial" Font-Size="Small" ForeColor="#003366" GridLines="Vertical" Height="226px" PageSize="4" Width="700px" OnItemCommand="dgPerfil_ItemCommand">
                                                     <Columns>
                                                         <asp:BoundColumn DataField="NO_PROYECTO" HeaderText="PROYECTO"></asp:BoundColumn>
                                                         <asp:BoundColumn DataField="NOMBRE" HeaderText="SOLICITA"></asp:BoundColumn>
                                                         <asp:BoundColumn DataField="CLIENTE" HeaderText="CLIENTE"></asp:BoundColumn>
                                                         <asp:BoundColumn DataField="PRODUCTO" HeaderText="PRODUCTO"></asp:BoundColumn>
                                                         <asp:ButtonColumn CommandName="SELECT" HeaderText="SELECCIONAR" Text="SELECCIONAR"></asp:ButtonColumn>
                                                         
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
                                                 <table style="width:100%;">
                                                     <tr>
                                                         <td>&nbsp;</td>
                                                         <td align="center">
                                                             &nbsp;</td>
                                                         <td>&nbsp;</td>
                                                     </tr>
                                                     <tr>
                                                         <td>&nbsp;</td>
                                                         <td  align="center">
                                                             &nbsp;</td>
                                                         <td>&nbsp;</td>
                                                     </tr>
                                                     <tr>
                                                         <td>&nbsp;</td>
                                                         <td  align="center">
                                                             &nbsp;</td>
                                                         <td>&nbsp;</td>
                                                     </tr>
                                                 </table>
                                             </td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style1020">&nbsp;</td>
                                             <td class="auto-style844">&nbsp;</td>
                                             <td>&nbsp;</td>
                                         </tr>
                                     </table>

                                 </asp:View>
                                 <asp:View ID="View2" runat="server">    
                                     <table style="width:100%;">
                                         
                                         <tr>
                                             <td class="auto-style999">
                                                 &nbsp;</td>
                                             <td align="center" class="auto-style963">
                                                 <asp:Label ID="Label119" runat="server" Font-Names="Arial Narrow" Text="COD PROYECTO: "></asp:Label>
                                                 <asp:Label ID="lblProyectoCotiza" runat="server" Font-Names="Arial Narrow" Text="NUEVO" Font-Bold="True" ForeColor="#003399"></asp:Label>
                                             </td>
                                             <td align="CENTER" class="auto-style889">
                                                 <asp:Label ID="Label112" runat="server" Font-Names="Arial Narrow" Text="QUIEN SOLICITA:  "></asp:Label>
                                                 &nbsp;<asp:DropDownList ID="dpSolicitaCoti" runat="server" Font-Names="Arial Narrow" Font-Size="Small" Height="26px" Width="265px">
                                                 </asp:DropDownList>
                                             </td>
                                             <td align="center" class="auto-style965">
                                                 <asp:Label ID="Label111" runat="server" Font-Names="Arial Narrow" Text="CLIENTE:  "></asp:Label>
                                                 <asp:TextBox ID="txtClienteCoti" runat="server" Height="16px" MaxLength="30" Width="298px" BorderColor="#003300"></asp:TextBox>
                                                 <%--<cc2:CalendarExtender ID="txtClienteCoti_CalendarExtender" runat="server" Format="dd/MM/yyyy" TargetControlID="txtClienteCoti" />--%>
                                                 <%--<cc2:CalendarExtender ID="CalendarExtender1" runat="server" Format="dd/MM/yyyy" TargetControlID="txtClienteCoti" />--%>
                                             </td>
                                             <td class="auto-style984">
                                                 &nbsp;</td>
                                             <td class="auto-style955"></td>
                                         </tr>
                                         
                                     </table> 
                                     <table style="width:100%;">
                                         <tr>
                                             <td class="auto-style996">
                                                 &nbsp;</td>
                                             <td align="center" class="auto-style994">
                                                 <asp:Label ID="Label133" runat="server" Font-Names="Arial Narrow" Text="PRODUCTO A DESARROLLAR: "></asp:Label>
                                                 <asp:TextBox ID="txtprodCoti" runat="server" Height="16px" MaxLength="30" Width="295px" BorderColor="#003300"></asp:TextBox>
                                             </td>
                                             <td align="center" class="auto-style979">
                                                 <asp:Label ID="Label134" runat="server" Font-Names="Arial Narrow" Text="CAJAS ESTIMADAS:  "></asp:Label>
                                                 <asp:TextBox ID="txtcajasCoti" runat="server" Height="16px" MaxLength="6" onkeypress="javascript:return solonumeros(event)" Width="71px" BorderColor="#003300"></asp:TextBox>
                                             </td>
                                             <td align="center"  class="auto-style989">
                                                 <asp:Label ID="Label135" runat="server" Font-Names="Arial Narrow" Text="LINEA DE PRODUCCION:  "></asp:Label>
                                                 <asp:TextBox ID="txtLineaCoti" runat="server" Height="16px" MaxLength="6" Width="71px" BorderColor="#003300"></asp:TextBox>
                                             </td>
                                             <td align="center"  class="auto-style1017">
                                                 <asp:Label ID="Label136" runat="server" Font-Names="Arial Narrow" Text="PERSONAL POR LINEA:"></asp:Label>
                                                 <asp:TextBox ID="txtpersonalCoti" runat="server" Height="16px" MaxLength="2" Width="71px" onkeypress="javascript:return solonumeros(event)" BorderColor="#003300" ></asp:TextBox>
                                             </td>
                                             <td align="center"  class="auto-style1016">
                                                 <asp:Label ID="Label137" runat="server" Font-Names="Arial Narrow" Text="CAJAS TURNO:  "></asp:Label>
                                                 <asp:TextBox ID="txtcajasturno" runat="server" Height="16px" MaxLength="4" Width="71px" onkeypress="javascript:return solonumeros(event)" BorderColor="#003300" ></asp:TextBox>
                                             </td>
                                                  <td class="auto-style987">&nbsp;</td>
                                                  <td class="auto-style988">&nbsp;</td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style973"></td>
                                             <td align="center" class="auto-style942">
                                                 <asp:Label ID="Label138" runat="server" Font-Names="Arial Narrow" Text="NOMBRE FORMULA"></asp:Label>
                                                 <asp:TextBox ID="txtFormula" runat="server" Height="16px" MaxLength="30" Width="295px" BorderColor="#003300"></asp:TextBox>
                                             </td>
                                             <td align="center" class="auto-style952">
                                                 <asp:Label ID="Label139" runat="server" Font-Names="Arial Narrow" Text="CONTENIDO NETO:  "></asp:Label>
                                                 <asp:TextBox ID="txtcontenidon" runat="server" Height="16px" MaxLength="4" onkeypress="javascript:return solonumeros(event)" Width="71px" BorderColor="#003300"></asp:TextBox>
                                             </td>
                                             <td align="center" class="auto-style925">
                                                 <asp:Label ID="Label140" runat="server" Font-Names="Arial Narrow" Text="CODIGO FORMULA:  "></asp:Label>
                                                 <asp:TextBox ID="txtcodFormula" runat="server" Height="16px" MaxLength="5" Width="71px" BorderColor="#003300"></asp:TextBox>
                                             </td>
                                             <td align="center" class="auto-style977">
                                                 <asp:Label ID="Label141" runat="server" Font-Names="Arial Narrow" Text="EQUIPO ELABORACION:  "></asp:Label>
                                                 <asp:TextBox ID="txtEquipo" runat="server" Height="16px" MaxLength="5" Width="71px" BorderColor="#003300"></asp:TextBox>
                                             </td>
                                             <td class="auto-style998">
                                                 </td>
                                             <td class="auto-style981">
                                             </td>
                                             <td class="auto-style939"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style996">
                                                 &nbsp;</td>
                                             <td align="right" class="auto-style994">
                                                 &nbsp;</td>
                                             <td align="left" class="auto-style979">
                                                 &nbsp;</td>
                                             <td class="auto-style989">
                                                 &nbsp;</td>
                                             <td class="auto-style1017">
                                                 &nbsp;</td>
                                             <td class="auto-style1016">&nbsp;</td>
                                                  <td class="auto-style987">&nbsp;</td>
                                                  <td class="auto-style988">&nbsp;</td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style996">
                                                 &nbsp;</td>
                                             <td align="right" class="auto-style994">
                                                 &nbsp;</td>
                                             <td class="auto-style979">
                                                 &nbsp;</td>
                                             <td align="right" class="auto-style989">
                                                 &nbsp;</td>
                                             <td class="auto-style1017">
                                                 &nbsp;</td>
                                             <td class="auto-style1016">&nbsp;</td>
                                                  <td class="auto-style987">&nbsp;</td>
                                                  <td class="auto-style988">&nbsp;</td>
                                         </tr>
                                     </table>    
                                      <table style="width:100%;">
                                          <tr>
                                              <td class="auto-style840"></td>
                                              <td align="center" class="auto-style1018">
                                                  <asp:Button ID="btnGuardar1" runat="server" CssClass="btn-login" Height="41px" OnClick="btnGuardar1_Click" Text="Guardar" Width="113px" />
                                              </td>
                                              <td class="auto-style840"></td>
                                          </tr>
                                          <tr>
                                              <td>&nbsp;</td>
                                              <td class="auto-style1019">&nbsp;</td>
                                              <td>&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td>&nbsp;</td>
                                              <td class="auto-style1019">
                                                  <asp:ScriptManager ID="ScriptManager1" runat="server">
                                                  </asp:ScriptManager>
                                              </td>
                                              <td>&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td>&nbsp;</td>
                                              <td class="auto-style1019">&nbsp;</td>
                                              <td>&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td>&nbsp;</td>                                              
                                               <td align="center" class="auto-style1019">
                                                    &nbsp;</td>
                                              <td>&nbsp;</td> 
                                           </tr>
                                      </table>
                                 </asp:View>
                                 <asp:View ID="View6" runat="server">
                                     <table style="width:100%;">
                                         <tr>
                                             <td>&nbsp;</td>
                                             <td class="auto-style847">
                                                 <asp:Label ID="Label69" runat="server" Font-Bold="False" Font-Names="Arial Narrow" Text="MATERIAL"></asp:Label>
                                             </td>
                                             <td class="auto-style848">
                                                 <asp:Label ID="Label70" runat="server" Font-Bold="False" Font-Names="Arial Narrow" Text="DESCRIPCION"></asp:Label>
                                             </td>
                                             <td class="auto-style834">
                                                 <asp:Label ID="Label71" runat="server" Font-Bold="False" Font-Names="Arial Narrow" Text="MATERIAL"></asp:Label>
                                             </td>
                                             <td class="auto-style833">
                                                 <asp:Label ID="Label72" runat="server" Font-Bold="False" Font-Names="Arial Narrow" Text="COLOR"></asp:Label>
                                             </td>
                                             <td class="auto-style849">
                                                 <asp:Label ID="Label73" runat="server" Font-Bold="False" Font-Names="Arial Narrow" Text="CODIGO"></asp:Label>
                                             </td>
                                             <td>
                                                 <asp:Label ID="lblidm" runat="server" Text="Label" Visible="False"></asp:Label>
                                             </td>
                                             <td></td>
                                         </tr>
                                         <tr>
                                             <td>&nbsp;</td>
                                             <td class="auto-style847">
                                                 <asp:DropDownList ID="dpFrecuencia" runat="server" Font-Names="Arial" Font-Size="X-Small" Height="25px"  Width="141px">
                                                     <asp:ListItem>SELECCIONE</asp:ListItem>
                                                     <asp:ListItem>ENVASE</asp:ListItem>
                                                     <asp:ListItem>TAPA</asp:ListItem>
                                                     <asp:ListItem>ETIQUETA</asp:ListItem>
                                                     <asp:ListItem>CORRUGADO</asp:ListItem>
                                                     <asp:ListItem>OTRO</asp:ListItem>
                                                 </asp:DropDownList>
                                             </td>
                                             <td class="auto-style848">
                                                 <asp:TextBox ID="txtEnvDes" runat="server" Height="16px" Width="281px" Style="text-transform: uppercase"></asp:TextBox>
                                             </td>
                                             <td class="auto-style834">
                                                 <asp:TextBox ID="txtEnvMat" runat="server" Height="16px" Width="156px" Style="text-transform: uppercase"></asp:TextBox>
                                             </td>
                                             <td class="auto-style833">
                                                 <asp:TextBox ID="txtEnvColor" runat="server" Height="16px" Width="104px" Style="text-transform: uppercase"></asp:TextBox>
                                             </td>
                                             <td class="auto-style849">
                                                 <asp:TextBox ID="txtEnvCodigo" runat="server" Height="16px" Width="104px"></asp:TextBox>
                                             </td>
                                             <td>
                                                 <asp:Button ID="btnAgr3" runat="server" CssClass="btn-Pasos" Font-Names="Arial" Font-Size="X-Small" Height="26px" OnClick="btnAgr3_Click" Text="AGREGAR" Width="85px" />
                                             </td>
                                             <td></td>
                                         </tr>                                                                             
                                     </table>
                                     <table style="width:100%;">                                         
                                          <tr>
                                              <td>&nbsp;</td>
                                              <td align="center" class="auto-style1021">
                                                  <asp:DataGrid ID="dgFunciones" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Font-Names="Arial" Font-Size="Small" Height="71px" OnItemCommand="dgFunciones_ItemCommand" PageSize="3" Width="657px">
                                                      <Columns>
                                                          <asp:BoundColumn DataField="id_Empaque" HeaderText="id_Empaque" Visible="false"></asp:BoundColumn>
                                                          <asp:BoundColumn DataField="MATERIAL" HeaderText="MATERIAL"></asp:BoundColumn>
                                                          <asp:BoundColumn DataField="DESCRIPCION" HeaderText="DESCRIPCION"></asp:BoundColumn>
                                                          <asp:BoundColumn DataField="MATERIAL2" HeaderText="MATERIAL2"></asp:BoundColumn>
                                                          <asp:BoundColumn DataField="COLOR" HeaderText="COLOR"></asp:BoundColumn>
                                                          <asp:BoundColumn DataField="CODIGO" HeaderText="CODIGO"></asp:BoundColumn>
                                                          <asp:ButtonColumn CommandName="EDITA" HeaderText="EDITAR" Text="EDITAR"></asp:ButtonColumn>
                                                          <asp:ButtonColumn CommandName="ELIMINA" HeaderText="ELIMINAR" Text="ELIMINAR"></asp:ButtonColumn>
                                                      </Columns>
                                                      <FooterStyle BackColor="White" ForeColor="#000066" />
                                                      <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                                                      <ItemStyle ForeColor="#000066" />
                                                      <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" Mode="NumericPages" />
                                                      <SelectedItemStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                                  </asp:DataGrid>
                                              </td>
                                              <td>&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td>&nbsp;</td>                                              
                                               <td align="center" class="auto-style1021">
                                                   
                                               </td>
                                              <td>&nbsp;</td> 
                                           </tr>
                                      </table>
                                 </asp:View>
                                 <asp:View ID="View8" runat="server">
                                     <table style="width:100%;">
                                         <tr>
                                             <td class="auto-style1002">&nbsp;</td>
                                             <td align="right" class="auto-style1004">
                                                 <asp:Label ID="Label85" runat="server" Font-Bold="False" Font-Names="Arial Narrow" Text="UNIDADES POR CORRUGADO:"></asp:Label>
                                             </td>
                                             <td class="auto-style1005">
                                                 <asp:TextBox ID="txtUniCorr" runat="server" Height="16px" Width="95px" MaxLength="3" onkeypress="javascript:return solonumeros(event)" ></asp:TextBox>
                                             </td>
                                             <td align="right" class="auto-style1013">
                                                 <asp:Label ID="Label142" runat="server" Font-Bold="False" Font-Names="Arial Narrow" Text="CAJAS POR TARIMA:"></asp:Label>
                                             </td>
                                             <td align="left" class="auto-style1015">
                                                 <asp:TextBox ID="txtCorrCama" runat="server" Height="16px" Width="94px" MaxLength="3" onkeypress="javascript:return solonumeros(event)" ></asp:TextBox>
                                             </td>
                                             <td class="auto-style1009">
                                                 &nbsp;</td>
                                             <td class="auto-style933">
                                                 &nbsp;</td>
                                             <td>&nbsp;</td>
                                         </tr>                                         
                                         <tr>
                                             <td class="auto-style1002">&nbsp;</td>
                                             <td align="right"  class="auto-style1004">
                                                 &nbsp;</td>
                                             <td class="auto-style1005">
                                                 &nbsp;</td>
                                             <td class="auto-style1013">&nbsp;</td>
                                             <td class="auto-style1015">&nbsp;</td>
                                             <td class="auto-style1009">&nbsp;</td>
                                             <td class="auto-style933">&nbsp;</td>
                                             <td>&nbsp;</td>
                                         </tr>
                                     </table>
                                     <table style="width:100%;">
                                          <tr>
                                              <td class="auto-style1000">&nbsp;</td>
                                              <td class="auto-style1010">
                                                  <asp:Label ID="Label109" runat="server" Font-Bold="False" Font-Names="Arial Narrow" Text="OBSERVACIONES:"></asp:Label>
                                              </td>
                                              <td>&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td class="auto-style1022"></td>
                                              <td align="center"  class="auto-style1023">
                                                  <asp:TextBox ID="txtobs" runat="server" Height="108px" TextMode="MultiLine" Width="672px"></asp:TextBox>
                                              </td>
                                              <td class="auto-style1024"></td>
                                          </tr>
                                          <tr>
                                              <td class="auto-style1000">&nbsp;</td>
                                              <td align="center"  class="auto-style1010">
                                                  <asp:Button ID="btnGuardar2" runat="server" CssClass="btn-login" Height="41px" OnClick="btnGuardar2_Click" Text="Guardar" Width="113px" />
                                              </td>
                                              <td>&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td class="auto-style1000">&nbsp;</td>
                                              <td class="auto-style1010">&nbsp;</td>
                                              <td>&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td class="auto-style1000">&nbsp;</td>                                              
                                               <td align="center" class="auto-style1010">
                                                    
                                               </td>
                                              <td>&nbsp;</td> 
                                           </tr>
                                      </table>
                                 </asp:View>
                                 <%--  --%>
                                 <asp:View ID="View9" runat="server">
                                          <table align ="center" style="width:40%;" class="table-Cebra">
                                         <tr>
                                             <td class="auto-style69">
                                                 </td>
                                             <td align="center" class="auto-style73">
                                                 <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Arial Narrow" Text="USUARIO"></asp:Label>
                                             </td>
                                             <td class="auto-style67">
                                                 <asp:Label ID="Label118" runat="server" Font-Bold="True" Font-Names="Arial Narrow" Text="FIRMA"></asp:Label>
                                             </td>
                                             
                                         </tr>
                                         <tr>
                                             <td class="auto-style101">
                                                 <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Names="Arial Narrow" Text="VENTAS:"></asp:Label>
                                             </td>
                                             <td align="left" class="auto-style102">
                                                 <asp:Label ID="lblventas" runat="server" Font-Bold="False" Font-Names="Arial Narrow"></asp:Label>
                                             </td>
                                             <td  align="left" class="auto-style103">
                                                 <asp:CheckBox ID="chventas" runat="server" Enabled="False" />
                                             </td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style101">
                                                 <asp:Label ID="Label123" runat="server" Font-Bold="True" Font-Names="Arial Narrow" Text="COSTOS:"></asp:Label>
                                             </td>
                                             <td align="left" class="auto-style102">
                                                 <asp:Label ID="lblcostos" runat="server" Font-Bold="False" Font-Names="Arial Narrow"></asp:Label>
                                             </td>
                                             <td  align="left" class="auto-style103">
                                                 <asp:CheckBox ID="chcostos" runat="server" Enabled="False" />
                                             </td>
                                             
                                         </tr>
                                          <tr>
                                             <td class="auto-style69">
                                                 <asp:Label ID="Label124" runat="server" Font-Bold="True" Font-Names="Arial Narrow" Text="DESARROLLO:"></asp:Label>
                                              </td>
                                             <td align="left" class="auto-style73">
                                                 <asp:Label ID="lbldesarrollo" runat="server" Font-Bold="False" Font-Names="Arial Narrow"></asp:Label>
                                              </td>
                                             <td align="left" class="auto-style67">
                                                 <asp:CheckBox ID="chdesarrollo" runat="server" Enabled="False" />
                                              </td>
                                                                             
                                         </tr>
                                                <tr>
                                            <td class="auto-style69">
                                                <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Names="Arial Narrow" Text="DIRECCION"></asp:Label>
                                              </td>
                                             <td align="left" class="auto-style73">
                                                 <asp:Label ID="lbldir" runat="server" Font-Bold="False" Font-Names="Arial Narrow"></asp:Label>
                                              </td>
                                             <td  align="left" class="auto-style67">
                                                 <asp:CheckBox ID="chdir" runat="server" Enabled="False" />
                                              </td>
                                            
                                         </tr>
                                          <tr>
                                             <td class="auto-style69">
                                                 <asp:Label ID="Label148" runat="server" Font-Bold="True" Font-Names="Arial Narrow" Text="CONTRASEÑA:"></asp:Label>
                                              </td>
                                             <td align="center" class="auto-style73">
                                                 <asp:TextBox ID="txtpass" runat="server" ForeColor="#666666" placeholder="CONTRASEÑA" TextMode="Password"></asp:TextBox>
                                              </td>
                                             <td class="auto-style67">
                                                 <asp:Button ID="btn13" runat="server" CssClass="btn-login" Height="36px"  Text="Firmar" Width="77px" OnClick="ActualizaFirmasCotiza" />
                                              </td>
                                             <td class="auto-style68">
                                                 &nbsp;</td>
                                             
                                         </tr>
                                          
                                         </table>
                                        </asp:View>
                                 <asp:View ID="View3" runat="server">
                                     <table style="width:100%;">
                                         <tr>
                                             <td class="auto-style1002">&nbsp;</td>
                                             <td align="right" class="auto-style1004">
                                                 <asp:Label ID="Label2" runat="server" Font-Bold="False" Font-Names="Arial Narrow" Text="COSTO POR PIEZA: "></asp:Label>
                                             </td>
                                             <td class="auto-style1005">
                                                 <asp:TextBox ID="txtcostpieza" runat="server" Height="16px" Width="95px" MaxLength="6"></asp:TextBox>
                                             </td>
                                             <td align="right" class="auto-style1013">
                                                 <asp:Label ID="Label3" runat="server" Font-Bold="False" Font-Names="Arial Narrow" Text="COSTO POR CAJA: "></asp:Label>
                                             </td>
                                             <td align="left" class="auto-style1015">
                                                 <asp:TextBox ID="txtcostcaja" runat="server" Height="16px" Width="94px" MaxLength="6" ></asp:TextBox>
                                             </td>
                                             <td class="auto-style1009">
                                                 &nbsp;</td>
                                             <td class="auto-style933">
                                                 &nbsp;</td>
                                             <td>&nbsp;</td>
                                         </tr>                                         
                                         <tr>
                                             <td class="auto-style1002">&nbsp;</td>
                                             <td align="right" class="auto-style1004">
                                                 <asp:Label ID="Label149" runat="server" Font-Bold="False" Font-Names="Arial Narrow" Text="INCOTERM: "></asp:Label>
                                             </td>
                                             <td class="auto-style1005">
                                                 <asp:TextBox ID="txtincoterm" runat="server" Height="16px"  Width="95px"></asp:TextBox>
                                             </td>
                                             <td align="right" class="auto-style1013">
                                                 <asp:Label ID="Label150" runat="server" Font-Bold="False" Font-Names="Arial Narrow" Text="VIGENCIA: "></asp:Label>
                                               
                                             </td>
                                             <td align="left" class="auto-style1015">
                                                 <asp:TextBox ID="txtcotVig" runat="server" Height="16px"  Width="94px" ></asp:TextBox>
                                                  <cc2:CalendarExtender ID="txtClienteCoti_CalendarExtender" runat="server" Format="dd/MM/yyyy" TargetControlID="txtcotVig" />
                                             </td>
                                             <td class="auto-style1009">&nbsp;</td>
                                             <td class="auto-style933">&nbsp;</td>
                                             <td>&nbsp;</td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style1002">&nbsp;</td>
                                             <td align="right" class="auto-style1004">
                                                 <asp:Label ID="Label151" runat="server" Font-Bold="False" Font-Names="Arial Narrow" Text="MOQ COMERCIAL: "></asp:Label>
                                             </td>
                                             <td class="auto-style1005">
                                                 <asp:TextBox ID="txtMOQ" runat="server" Height="16px" Width="95px"></asp:TextBox>
                                             </td>
                                             <td align="right" class="auto-style1013">&nbsp;</td>
                                             <td align="left" class="auto-style1015">&nbsp;</td>
                                             <td class="auto-style1009">&nbsp;</td>
                                             <td class="auto-style933">&nbsp;</td>
                                             <td>&nbsp;</td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style1002">&nbsp;</td>
                                             <td align="right"  class="auto-style1004">
                                                 &nbsp;</td>
                                             <td class="auto-style1005">
                                                 &nbsp;</td>
                                             <td class="auto-style1013">&nbsp;</td>
                                             <td class="auto-style1015">&nbsp;</td>
                                             <td class="auto-style1009">&nbsp;</td>
                                             <td class="auto-style933">&nbsp;</td>
                                             <td>&nbsp;</td>
                                         </tr>
                                     </table>
                                     <table class="auto-style1025">
                                          <tr>
                                              <td class="auto-style1000">&nbsp;</td>
                                              <td class="auto-style1010">
                                                  &nbsp;</td>
                                              <td>&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td class="auto-style1000">&nbsp;</td>
                                              <td align="center"  class="auto-style1010">
                                                  <asp:Button ID="Button1" runat="server" CssClass="btn-login" Height="41px" OnClick="ActualizaCosto" Text="Guardar" Width="113px" />
                                              </td>
                                              <td>&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td class="auto-style1000">&nbsp;</td>
                                              <td class="auto-style1010">&nbsp;</td>
                                              <td>&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td class="auto-style1000">&nbsp;</td>                                              
                                               <td align="center" class="auto-style1010">
                                                    
                                               </td>
                                              <td>&nbsp;</td> 
                                           </tr>
                                      </table>
                                 </asp:View>
                                 <%--  --%>
                               <asp:View ID="View10" runat="server">

                                            <table style="height:600px;">
                                                <tr>
                                                    <td class="auto-style110"></td>
                                                    <td align="center" class="auto-style110">
                                                        <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Names="Arial Narrow" Text="PROYECTO:"></asp:Label>
                                                        &nbsp;<asp:Label ID="lblProyectoReporte" runat="server" Font-Bold="False" Font-Names="Arial Narrow"></asp:Label>
                                                        <asp:Label ID="lblProyectoReporte1" runat="server" Font-Bold="False" Font-Names="Arial Narrow"></asp:Label>
                                                        &nbsp;&nbsp;
                                                        <asp:Button ID="btn14" runat="server" CssClass="btn-login" Height="36px"  Text="Visualiza reporte" Width="132px" OnClick="Viualizar_reporte" />
                                                    </td>
                                                    <td class="auto-style110"></td>
                                                </tr>
                                                <tr>
                                                    <td class="auto-style109" ></td>
                                                    <td class="auto-style109">
                                                        <%--<asp:ScriptManager ID="ScriptManager2" runat="server">
                                                        </asp:ScriptManager>--%>
                                                      
                                                     <rsweb:ReportViewer ID="ReportViewer2" runat="server"  Height="540px" Width="807px">
                                                         </rsweb:ReportViewer >
                                                    
                                                          </td>
                                                    <td class="auto-style109"></td>
                                                </tr>
                                                <tr>
                                                    <td>&nbsp;</td>
                                                    <td>&nbsp;</td>
                                                    <td>&nbsp;</td>
                                                </tr>
                                            </table>

                                        </asp:View>
                             </asp:MultiView>
                   </table></center>                        
                   </div>
                  </td>
               </tr>
           </table>             
                  
       </div>
    </asp:Content>
