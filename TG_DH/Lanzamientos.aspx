<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Lanzamientos.aspx.cs" Inherits="DNP.Lanzamientos" %>
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
            width: 1155px;
            
        }

       
        .auto-style803 {
        width: 282px;
        height: 32px;
    }
    
       
        .auto-style807 {
            height: 24px;
        }
        .auto-style809 {
            width: 209px;
            height: 24px;
        }
        .auto-style815 {
            height: 24px;
            width: 149px;
        }
        .auto-style817 {
            width: 242px;
            height: 24px;
        }

       
        .auto-style823 {
            width: 38px;
        }
        .auto-style824 {
            width: 101px;
        }
        .auto-style825 {
            width: 94px;
        }
        .auto-style828 {
            width: 219px;
        }

       
        .auto-style833 {
            width: 97px;
        }
        .auto-style834 {
            width: 161px;
        }
        
       
        .auto-style840 {
            height: 23px;
        }

       
        .auto-style841 {
            height: 23px;
            width: 125px;
        }
        .auto-style844 {
            width: 703px;
        }
        .auto-style845 {
            width: 125px;
        }
        .auto-style846 {
            width: 72px;
        }
        .auto-style847 {
            width: 85px;
        }
        .auto-style848 {
            width: 295px;
        }
        .auto-style849 {
            width: 114px;
        }
        .auto-style851 {
            width: 188px;
        }
        .auto-style852 {
            width: 191px;
        }
        .auto-style853 {
            width: 192px;
        }
        .auto-style865 {
            width: 57px;
        }
        .auto-style867 {
            width: 55px;
        }
        .auto-style868 {
            width: 129px;
        }
                
       
        .auto-style873 {
            height: 32px;
        }

       
        .auto-style875 {
            width: 204px;
        }
        .auto-style876 {
            width: 102px;
            height: 32px;
        }
        .auto-style879 {
            height: 32px;
            width: 183px;
        }
        .auto-style880 {
            width: 183px;
        }
        
       
        .auto-style889 {
            width: 155px;
            height: 32px;
        }
        .auto-style890 {
            width: 155px;
        }
        .auto-style891 {
            width: 102px;
        }
        .auto-style893 {
            height: 24px;
            width: 89px;
        }
        .auto-style895 {
            width: 116px;
        }

       
        .auto-style896 {
            width: 149px;
        }

       
        .auto-style900 {
            width: 194px;
        }
        .auto-style902 {
            width: 89px;
        }
        .auto-style903 {
            width: 242px;
        }

       
        .auto-style904 {
            width: 209px;
        }

       
        .auto-style905 {
            width: 95px;
        }
        .auto-style906 {
            width: 189px;
        }
        .auto-style907 {
            width: 72px;
            height: 20px;
        }
        .auto-style908 {
            width: 57px;
            height: 20px;
        }
        .auto-style909 {
            width: 192px;
            height: 20px;
        }
        .auto-style910 {
            width: 55px;
            height: 20px;
        }
        .auto-style911 {
            width: 191px;
            height: 20px;
        }
        .auto-style912 {
            width: 129px;
            height: 20px;
        }
        .auto-style913 {
            width: 188px;
            height: 20px;
        }
        .auto-style914 {
            height: 20px;
        }
        
       
        .auto-style919 {
            width: 282px;
        }

       
        .auto-style920 {
            width: 287px;
        }
        .auto-style921 {
            width: 132px;
        }
        .auto-style924 {
            width: 104px;
        }

       
        .auto-style925 {
            width: 305px;
        }

       
        .auto-style926 {
            width: 30px;
        }
        .auto-style928 {
            width: 108px;
        }
        .auto-style929 {
            width: 115px;
        }
        .auto-style930 {
            width: 221px;
        }
        .auto-style931 {
            width: 202px;
        }
        .auto-style933 {
            width: 91px;
        }
        .auto-style934 {
            width: 145px;
        }

       
        .auto-style940 {
            width: 223px;
        }

       
        .auto-style943 {
            width: 124px;
        }
        .auto-style944 {
            width: 123px;
        }
        .auto-style946 {
            width: 180px;
        }
        .auto-style947 {
            width: 298px;
        }
        .auto-style948 {
            width: 317px;
        }
        .auto-style949 {
            width: 354px;
        }
        .auto-style950 {
            width: 298px;
            height: 23px;
        }
        .auto-style951 {
            width: 317px;
            height: 23px;
        }
        .auto-style953 {
            width: 370px;
        }

       
        .auto-style955 {
            height: 122px;
        }
        .auto-style956 {
            height: 23px;
            width: 182px;
        }
        .auto-style957 {
            height: 122px;
            width: 182px;
        }
        .auto-style959 {
            height: 122px;
            width: 565px;
        }
        .auto-style960 {
            width: 565px;
        }
        .auto-style961 {
            width: 182px;
        }

       
        .auto-style983 {
            width: 137px;
        }
        .auto-style984 {
            width: 52px;
        }

       
        .auto-style987 {
            width: 86px;
        }
        .auto-style988 {
            width: 93px;
        }

       
        .auto-style989 {
            width: 82px;
        }
        .auto-style990 {
            width: 90px;
        }
        .auto-style991 {
            width: 3px;
        }

       
        .auto-style993 {
            width: 678px;
        }

       
        .auto-style995 {
            width: 180px;
            height: 52px;
        }
        .auto-style996 {
            width: 370px;
            height: 52px;
        }
        .auto-style997 {
            width: 123px;
            height: 52px;
        }
        .auto-style998 {
            width: 354px;
            height: 52px;
        }
        .auto-style999 {
            width: 124px;
            height: 52px;
        }
        .auto-style1000 {
            width: 252px;
            height: 52px;
        }
        .auto-style1001 {
            width: 223px;
            height: 52px;
        }

       
        .auto-style1002 {
            width: 38px;
            height: 45px;
        }
        .auto-style1003 {
            width: 149px;
            height: 45px;
        }
        .auto-style1004 {
            width: 82px;
            height: 45px;
        }
        .auto-style1005 {
            width: 86px;
            height: 45px;
        }
        .auto-style1006 {
            width: 90px;
            height: 45px;
        }
        .auto-style1007 {
            width: 3px;
            height: 45px;
        }
        .auto-style1008 {
            width: 137px;
            height: 45px;
        }
        .auto-style1009 {
            width: 93px;
            height: 45px;
        }
        .auto-style1010 {
            width: 52px;
            height: 45px;
        }
        .auto-style1011 {
            width: 85px;
            height: 45px;
        }
        .auto-style1012 {
            height: 45px;
        }

       
        .auto-style1013 {
            height: 22px;
        }

       
        .auto-style1014 {
            height: 22px;
            width: 10px;
        }
        .auto-style1015 {
            width: 10px;
        }

       
        .auto-style1020 {
            margin-left: 80px;
        }

       
        .auto-style1021 {
            margin-left: 0px;
        }

       
        </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <link rel="stylesheet" href="Css/stylePerfil.css" type="text/css" media="screen"/>

    <link href="Content/bootstrap-grid.min.css" rel="stylesheet" />
    <script src="scripts/jquery-1.5.2.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
       <div style="text-align:center; width: 100%; height: 100%">
           <table style="width: 100%;">
           <Web:PopupWin ID="pop" runat="server" AutoShow="False" style="top: 0px; left: 0px; height: 154px; width: 216px" />
           
                    
               <tr>
                   <td class="auto-style607"><div id="div1" class="container">
                         <center>  <table style="width: 20%;">
                             <tr>
                           <td align="center"> <hr />  
                               
                                <asp:Menu ID="Menu3" runat="server" Orientation="Horizontal" OnMenuItemClick="Menu3_MenuItemClick" Width="1100px" MaximumDynamicDisplayLevels="0" Font-Bold="False" Font-Italic="False" Font-Names="Arial" Font-Strikeout="False" Font-Underline="False" ForeColor="#0416BB" Height="76px" RenderingMode="List" Font-Size="Smaller" PathSeparator="-" ScrollUpText="Desplazar hacia abajo">
                                    <DynamicHoverStyle BackColor="#CCCCCC" />
                                   <Items>
                                       <asp:MenuItem Text="BUSCAR" ToolTip="BUSCAR" Value="0" Selected="True"></asp:MenuItem>
                                       <asp:MenuItem Text="CABECERA" Value="1"></asp:MenuItem>
                                       <asp:MenuItem Text="PRODUCTO" Value="2" ToolTip="PRODUCTO"></asp:MenuItem>
                                       <asp:MenuItem Text="FISICOQUIMICAS" Value="3" ToolTip="FISICOQUIMICAS"></asp:MenuItem>
                                       <asp:MenuItem Text="SENSORIALES" Value="4" ToolTip="SENSORIALES"></asp:MenuItem>
                                       <asp:MenuItem Text="EQUIPO FORMULACIÓN" Value="11" ToolTip="FORMULACION"></asp:MenuItem>
                                       <asp:MenuItem Text="EMPAQUE" ToolTip="Frases P" Value="5"></asp:MenuItem>
                                       <asp:MenuItem Text="CODIGO BARRAS" ToolTip="Frases H" Value="6"></asp:MenuItem>
                                       <asp:MenuItem Text="EMBALAJE" Value="7"></asp:MenuItem>
                                       <asp:MenuItem Text="EQUIPO ENVASADO" Value="12" ToolTip="ENVASADO"></asp:MenuItem>
                                       <asp:MenuItem Text="IMAGENES" ToolTip="IMAGENES" Value="8"></asp:MenuItem>
                                       <asp:MenuItem Text="OBS" Value="9"></asp:MenuItem>
                                       <asp:MenuItem Text="FIRMAS" Value="10"></asp:MenuItem>
                                   </Items>
                                    <LevelMenuItemStyles>
                                        <asp:MenuItemStyle Font-Underline="False" />
                                    </LevelMenuItemStyles>
                                    <LevelSelectedStyles>
                                        <asp:MenuItemStyle Font-Underline="False" />
                                    </LevelSelectedStyles>
                                   <StaticMenuItemStyle ItemSpacing="100px" VerticalPadding="" Font-Bold="False" Font-Italic="False" Font-Names="Calibri" Font-Overline="False" Font-Size="Medium" Font-Underline="False" ForeColor="#666666" />
                                    <StaticMenuStyle HorizontalPadding="" VerticalPadding="" />
                                   <StaticSelectedStyle ForeColor="#04C0FF" BorderStyle="None"/>
                               </asp:Menu>   
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
                                                 <asp:Label ID="Label15" runat="server" Font-Names="Arial" Font-Size="X-Small" Text="Ej. PROYECTO, CLIENTE, PRODUCTO."></asp:Label>
                                                 <asp:CheckBox ID="chArchivado" runat="server" Font-Names="Arial Narrow" Text="Archivo" />
                                                 &nbsp;
                                                 <asp:Button ID="btnBusca" runat="server" OnClick="btnBusca_Click" Text="Buscar" />
                                             </td>
                                             <td class="auto-style840"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style845">&nbsp;</td>
                                             <td class="auto-style844">
                                                 <div style="height: 250px; width: 743px; overflow: scroll;">
                                                 <asp:DataGrid ID="dgPerfil" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Font-Names="Arial" Font-Size="Small" ForeColor="#003366" GridLines="Vertical" Height="226px" PageSize="4" Width="700px" OnItemCommand="dgPerfil_ItemCommand">
                                                     <Columns>
                                                         <asp:BoundColumn DataField="NO_PROYECTO" HeaderText="PROYECTO"></asp:BoundColumn>
                                                         <asp:BoundColumn DataField="PRODUCTO_DES" HeaderText="PRODUCTO"></asp:BoundColumn>
                                                         <asp:BoundColumn DataField="NOMBRE" HeaderText="CLIENTE"></asp:BoundColumn>
                                                         <asp:BoundColumn DataField="DESCRIPCION" HeaderText="ESTATUS"></asp:BoundColumn>
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
                                                         <td class="auto-style1014"></td>
                                                         <td align="center" class="auto-style1013">
                                                             <asp:Label ID="Label132" runat="server" Text="FILTRAR"></asp:Label>
                                                         </td>
                                                         <td class="auto-style1013"></td>
                                                     </tr>
                                                     <tr>
                                                         <td class="auto-style1015">&nbsp;</td>
                                                         <td align="center">
                                                             <asp:DropDownList ID="DropFiltro" runat="server">
                                                                 <asp:ListItem>SELECCIONE</asp:ListItem>
                                                                 <asp:ListItem>LLENADO</asp:ListItem>
                                                                 <asp:ListItem>FIRMAS</asp:ListItem>
                                                                 <asp:ListItem>CANCELADO</asp:ListItem>
                                                                 <asp:ListItem>ARCHIVO</asp:ListItem>
                                                                 </asp:DropDownList>
                                                         </td>
                                                         <td>&nbsp;</td>
                                                     </tr>
                                                     <tr>
                                                         <td class="auto-style1015">&nbsp;</td>
                                                         <td align="center">
                                                             <asp:Button ID="btnFiltrar" runat="server" OnClick="btnFiltrar_Click" Text="Filtrar" />
                                                         </td>
                                                         <td>&nbsp;</td>
                                                     </tr>
                                                     <tr>
                                                         <td class="auto-style1015">&nbsp;</td>
                                                         <td align="center">&nbsp;</td>
                                                         <td>&nbsp;</td>
                                                     </tr>
                                                     <tr>
                                                         <td class="auto-style1015">&nbsp;</td>
                                                         <td align="center">
                                                             <asp:Label ID="Label108" runat="server" Font-Names="Arial Narrow" Text="ESTATUS"></asp:Label>
                                                         </td>
                                                         <td>&nbsp;</td>
                                                     </tr>
                                                     <tr>
                                                         <td class="auto-style1015">&nbsp;</td>
                                                         <td  align="center">
                                                             <asp:DropDownList ID="dpEstatus" runat="server">
                                                             </asp:DropDownList>
                                                         </td>
                                                         <td>&nbsp;</td>
                                                     </tr>
                                                     <tr>
                                                         <td class="auto-style1015">&nbsp;</td>
                                                         <td  align="center">
                                                             <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
                                                         </td>
                                                         <td>&nbsp;</td>
                                                     </tr>
                                                 </table>
                                             </td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style845">&nbsp;</td>
                                             <td class="auto-style844">&nbsp;</td>
                                             <td>&nbsp;</td>
                                         </tr>
                                     </table>

                                 </asp:View>
                                 <asp:View ID="View2" runat="server">    
                                     <table style="width:100%;">
                                         <tr>
                                             <td class="auto-style876"></td>
                                             <td align="right" class="auto-style889">
                                                 <asp:Label ID="Label101" runat="server" Font-Names="Arial Narrow" Text="CODIGO PROYECTO:"></asp:Label>
                                             </td>
                                             <td align="left" class="auto-style873">
                                                 <asp:Label ID="lblFolioProyecto" runat="server" Font-Names="Arial Narrow" Text="NUEVO"></asp:Label>
                                             </td>
                                             <td class="auto-style803">
                                                 <asp:Label ID="Label100" runat="server" Font-Names="Arial Narrow" Text="QUIEN SOLICITA:"></asp:Label>
                                                 <asp:DropDownList ID="dpClientes" runat="server" Enabled="False" Font-Names="Arial Narrow" Font-Size="Small" Height="23px" Width="166px">
                                                 </asp:DropDownList>
                                             </td>
                                             <td class="auto-style879"></td>
                                             <td class="auto-style873"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style891">
                                                 &nbsp;</td>
                                             <td align="right" class="auto-style890">
                                                 <asp:Label ID="Label47" runat="server" Font-Names="Arial Narrow" Text="FECHA NOTIFICACION:"></asp:Label>
                                             </td>
                                             <td align="left">
                                                 <asp:TextBox ID="txtnoti" runat="server" Height="16px" Width="166px" Enabled="False"></asp:TextBox>
                                                 <cc2:CalendarExtender ID="txtnoti_CalendarExtender" runat="server" TargetControlID="txtnoti" Format="dd/MM/yyyy"/>
                                             </td>
                                             <td class="auto-style919">
                                                 <asp:Label ID="Label48" runat="server" Font-Names="Arial Narrow" Text="FECHA TENTATIVA DE LANZAMIENTO:"></asp:Label>
                                             </td>
                                             <td class="auto-style880">
                                                 <asp:TextBox ID="txtlanza" runat="server" Height="16px" Width="166px" Enabled="False"></asp:TextBox>
                                                 <cc2:CalendarExtender ID="txtlanza_CalendarExtender" runat="server" TargetControlID="txtlanza" Format="dd/MM/yyyy"/>
                                             </td>
                                             <td>&nbsp;</td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style891">&nbsp;</td>
                                             <td align="right" class="auto-style890">
                                                 <asp:Label ID="Label49" runat="server" Font-Names="Arial Narrow" Text="TIPO DE PROYECTO:"></asp:Label>
                                             </td>
                                             <td class="auto-style875">
                                                 <asp:CheckBox ID="chpropia" runat="server" Font-Names="Arial Narrow" Text="MARCA PROPIA" AutoPostBack="True" Enabled="False" OnCheckedChanged="chpropia_CheckedChanged" />
                                                 <asp:CheckBox ID="chmaquila" runat="server" Font-Names="Arial Narrow" Text="MAQUILA" AutoPostBack="True" Enabled="False" OnCheckedChanged="chmaquila_CheckedChanged" />
                                             </td>
                                             <td align="right" class="auto-style919">
                                                 <asp:Label ID="Label51" runat="server" Font-Names="Arial Narrow" Text="CODIGO CLIENTE:"></asp:Label>
                                             </td>
                                             <td class="auto-style880">
                                                 <asp:TextBox ID="txtCodCliente" runat="server" Font-Names="Arial Narrow" Width="166px" Enabled="False" Style="text-transform: uppercase"></asp:TextBox>
                                             </td>
                                             <td>&nbsp;</td>
                                         </tr>
                                     </table>   
                                      <table style="width:100%;">
                                          <tr>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td>&nbsp;</td>                                              
                                               <td align="center">
                                                    <asp:Button ID="btnGuardar1" runat="server" CssClass="btn-login" Text="Guardar" Height="41px" Width="113px" OnClick="btnGuardar1_Click" />
                                               </td>
                                              <td>&nbsp;</td> 
                                           </tr>
                                      </table>
                                 </asp:View>
                                 <asp:View ID="View3" runat="server">  
                                     <table style="width:100%;">
                                         <tr>
                                             <td>&nbsp;</td>
                                             <td>&nbsp;</td>
                                             <td>&nbsp;</td>
                                          </tr>
                                     </table>                                
                                     <table style="width:100%;">
                                         <tr>
                                             <td class="auto-style905">&nbsp;</td>
                                             <td align="right" class="auto-style900">
                                                 <asp:Label ID="Label53" runat="server" Font-Names="Arial Narrow" Text="PRODUCTO A DESARROLLAR:"></asp:Label>
                                             </td>
                                             <td class="auto-style906">
                                                 <asp:TextBox ID="txtProdDes" runat="server" Height="16px" Width="411px" Enabled="False" Style="text-transform: uppercase"></asp:TextBox>
                                             </td>
                                             <td class="auto-style903">&nbsp;</td>
                                             
                                         </tr>
                                         </table>
                                      <table style="width:100%;">
                                         <tr>
                                             <td class="auto-style893"></td>
                                             <td  align="right" class="auto-style900">
                                                 <asp:Label ID="Label54" runat="server" Font-Names="Arial Narrow" Text="CODIGO ROSS PROYECTO:"></asp:Label>
                                             </td>
                                             <td class="auto-style809">
                                                 <asp:TextBox ID="txtcodRoss" runat="server" Height="16px" Width="188px" Enabled="False"></asp:TextBox>
                                             </td>
                                             <td class="auto-style817">
                                                 <asp:Label ID="Label55" runat="server" Font-Names="Arial Narrow" Text="ESTIMADO DE CAJAS A FABRICAR:"></asp:Label>
                                             </td>
                                             <td class="auto-style815">
                                                 <asp:TextBox ID="txtCajasFab" runat="server" Height="16px" Width="144px" Enabled="False"></asp:TextBox>
                                             </td>
                                             <td class="auto-style807"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style902">&nbsp;</td>
                                             <td  align="right" class="auto-style900">
                                                 <asp:Label ID="Label56" runat="server" Font-Names="Arial Narrow" Text="REGISTRO SANITARIO:"></asp:Label>
                                             </td>
                                             <td class="auto-style904">
                                                 <asp:TextBox ID="txtRegSan" runat="server" Height="16px" Width="189px" Enabled="False"></asp:TextBox>
                                             </td>
                                             <td  align="right" class="auto-style903">
                                                 <asp:Label ID="Label93" runat="server" Font-Names="Arial Narrow" Text="CADUCIDAD:"></asp:Label>
                                                 <asp:TextBox ID="txtCad" runat="server" Height="16px" Width="140px" Enabled="False"></asp:TextBox>
                                                 <cc2:CalendarExtender ID="txtCad_CalendarExtender" runat="server" TargetControlID="txtCad" />
                                                 <cc2:CalendarExtender ID="txtCad_CalendarExtender2" runat="server" TargetControlID="txtCad" />
                                             </td>
                                             <td class="auto-style896">
                                                 &nbsp;</td>
                                             <td>&nbsp;</td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style902">&nbsp;</td>
                                             <td  align="right" class="auto-style900">
                                                 &nbsp;</td>
                                             <td  align="right" class="auto-style904">
                                                 &nbsp;</td>
                                             <td  align="right" class="auto-style903">
                                                 &nbsp;</td>
                                             <td class="auto-style896">
                                                 &nbsp;</td>
                                             <td>&nbsp;</td>
                                         </tr>
                                     </table>  
                                     <table style="width:100%;">                                          
                                          <tr>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td>&nbsp;</td>                                              
                                               <td align="center">
                                                    <asp:Button ID="Button1" runat="server" CssClass="btn-login" Text="Guardar" Height="41px" Width="113px" OnClick="Button1_Click" />
                                               </td>
                                              <td>&nbsp;</td> 
                                           </tr>
                                      </table>                                   
                                 </asp:View>
                                 <asp:View ID="View12" runat="server">
                                      <table style="width:100%;">
                                          <tr>
                                              <td align="Justify" class="auto-style920">
                                                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Font-Names="Arial Narrow" Text="TANQUES:"></asp:Label>
                                              </td>
                                              <td align="left" class="auto-style1020">
                                                  <asp:TextBox ID="txtEspEquiTanq" runat="server" Height="16px" Width="877px" Style="text-transform: uppercase" CssClass="auto-style1021"></asp:TextBox>
                                              </td>
                                              <td></td>
                                          </tr>
                                      </table>
                                     <table style="width:100%;">
                                         <tr>
                                             <td align="justify" class="auto-style920">
                                                 
                                                  &nbsp;&nbsp;&nbsp;<asp:Label ID="Label2" runat="server" Font-Names="Arial Narrow" Text="CAPACIDAD:"></asp:Label>
                                              </td>
                                              <td align="left">
                                                  <asp:TextBox ID="txtEECap" runat="server" Height="16px" Width="877px" Style="text-transform: uppercase" CssClass="auto-style1021"></asp:TextBox>
                                              </td>
                                              <td></td>
                                            
                                         </tr>
                                                                          
                                     </table>
                                     <table style="width:100%;">                                         
                                              </tr>
                                              <tr>
                                                  <td>&nbsp;</td>
                                                  <td align="center">
                                                      <asp:Button ID="btnGEspForm" runat="server"  Height="41px" Width="113px" CssClass="btn-login" OnClick="btnGEspForm_Click" Text="Guardar" />
                                                  </td>
                                                  <td>&nbsp;</td>
                                              </tr>
                                      </table>
                                 </asp:View>
                                 <asp:View ID="View4" runat="server">
                                      <table style="width:100%;">
                                          <tr>
                                              <td align="right" class="auto-style920">
                                                  <asp:Label ID="Label102" runat="server" Font-Names="Arial Narrow" Text="NOMBRE DE LA FORMULA:"></asp:Label>
                                              </td>
                                              <td align="left">
                                                  <asp:TextBox ID="txtFormula" runat="server" Enabled="False" Height="16px" Width="505px" Style="text-transform: uppercase"></asp:TextBox>
                                              </td>
                                              <td></td>
                                          </tr>
                                      </table>
                                     <table style="width:100%;">
                                         <tr>
                                             <td class="auto-style895">&nbsp;</td>
                                             <td class="auto-style921">
                                                 <asp:Label ID="Label103" runat="server" Font-Names="Arial Narrow" Text="CONTENIDO NETO:"></asp:Label>
                                             </td>
                                             <td class="auto-style924">
                                                 <asp:TextBox ID="txtNeto" runat="server" Enabled="False" Height="16px" Width="92px"></asp:TextBox>
                                             </td>
                                             <td align="right">
                                                 <asp:Label ID="Label104" runat="server" Font-Names="Arial Narrow" Text="CODIGO ROSS FORMULA ELABORACION:"></asp:Label>
                                             </td>
                                             <td align="left">
                                                 <asp:TextBox ID="txtElab" runat="server" Enabled="False" Height="16px" Width="174px"></asp:TextBox>
                                             </td>
                                             <td>&nbsp;</td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style895">&nbsp;</td>
                                             <td class="auto-style921">
                                                 <asp:Label ID="Label61" runat="server" Font-Names="Arial Narrow" Text="DENSIDAD:"></asp:Label>
                                             </td>
                                             <td class="auto-style924">
                                                 <asp:TextBox ID="txtDensi" runat="server" Enabled="False" Height="16px" Width="90px"></asp:TextBox>
                                             </td>
                                             <td class="auto-style925">
                                                 <asp:Label ID="Label105" runat="server" Font-Names="Arial Narrow" Text="PH:"></asp:Label>
                                                 <asp:TextBox ID="txtPH" runat="server" Enabled="False" Height="16px" Width="73px"></asp:TextBox>
                                                 <asp:Label ID="Label106" runat="server" Font-Names="Arial Narrow" Text="VISCOSIDAD:"></asp:Label>
                                                 <asp:TextBox ID="txtVisc" runat="server" Enabled="False" Height="16px" Width="91px"></asp:TextBox>
                                             </td>
                                             <td class="auto-style828">
                                                 <asp:Label ID="Label107" runat="server" Font-Names="Arial Narrow" Text="TEXTURA:"></asp:Label>
                                                 <asp:TextBox ID="txtText" runat="server" Enabled="False" Height="16px" Width="140px"></asp:TextBox>
                                             </td>
                                             <td>&nbsp;</td>
                                         </tr>
                                         
                                     </table>
                                     <table style="width:100%;">
                                          <tr>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td>&nbsp;</td>                                              
                                               <td align="center">
                                                    <asp:Button ID="Button7" runat="server" CssClass="btn-login" Text="Guardar" Height="41px" Width="113px" OnClick="Button7_Click" />
                                               </td>
                                              <td>&nbsp;</td> 
                                           </tr>
                                      </table>
                                 </asp:View>
                                 <asp:View ID="View5" runat="server">
                                     <table style="width:100%;">
                                         <tr>
                                             <td>&nbsp;</td>
                                             <td class="auto-style825">
                                                 <asp:Label ID="Label65" runat="server" Font-Names="Arial Narrow" Text="COLOR:"></asp:Label>
                                             </td>
                                             <td class="auto-style823">
                                                 <asp:TextBox ID="txtColor" runat="server" Height="16px" Width="236px" Enabled="False" Style="text-transform: uppercase"></asp:TextBox>
                                             </td>
                                             <td class="auto-style824">
                                                 <asp:Label ID="Label67" runat="server" Font-Names="Arial Narrow" Text="FRAGANCIA:"></asp:Label>
                                             </td>
                                             <td class="auto-style828">
                                                 <asp:TextBox ID="txtFrag" runat="server" Height="16px" Width="340px" Enabled="False" Style="text-transform: uppercase"></asp:TextBox>
                                             </td>
                                             <td>&nbsp;</td>
                                         </tr>
                                         <tr>
                                             <td>&nbsp;</td>
                                             <td class="auto-style825">
                                                 <asp:Label ID="Label66" runat="server" Font-Names="Arial Narrow" Text="FIJACIÓN:"></asp:Label>
                                             </td>
                                             <td class="auto-style823">
                                                 <asp:TextBox ID="txtFijacion" runat="server" Height="16px" Width="200px" Enabled="False" Style="text-transform: uppercase"></asp:TextBox>
                                             </td>
                                             <td align="right">
                                                 <asp:Label ID="Label68" runat="server" Font-Names="Arial Narrow" Text="OTROS:"></asp:Label>
                                             </td>
                                             <td align="left">
                                                 <asp:TextBox ID="txtOtros" runat="server" Height="16px" Width="200px" Enabled="False" Style="text-transform: uppercase"></asp:TextBox>
                                             </td>
                                             <td>&nbsp;</td>
                                         </tr>
                                         <tr>
                                             <td>&nbsp;</td>
                                             <td class="auto-style825">&nbsp;</td>
                                             <td class="auto-style823">
                                                 <asp:ScriptManager ID="ScriptManager1" runat="server">
                                                 </asp:ScriptManager>
                                             </td>
                                             <td class="auto-style824">&nbsp;</td>
                                             <td class="auto-style828">&nbsp;</td>
                                             <td>&nbsp;</td>
                                         </tr>
                                     </table>
                                     <table style="width:100%;">
                                          <tr>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td>&nbsp;</td>                                              
                                               <td align="center">
                                                    <asp:Button ID="Button2" runat="server" CssClass="btn-login" Text="Guardar" Height="41px" Width="113px" OnClick="Button2_Click" />
                                               </td>
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
                                                 <asp:TextBox ID="txtEnvDes" runat="server" Height="16px" Width="281px" Enabled="False" Style="text-transform: uppercase"></asp:TextBox>
                                             </td>
                                             <td class="auto-style834">
                                                 <asp:TextBox ID="txtEnvMat" runat="server" Height="16px" Width="156px" Enabled="False" Style="text-transform: uppercase"></asp:TextBox>
                                             </td>
                                             <td class="auto-style833">
                                                 <asp:TextBox ID="txtEnvColor" runat="server" Height="16px" Width="104px" Enabled="False" Style="text-transform: uppercase"></asp:TextBox>
                                             </td>
                                             <td class="auto-style849">
                                                 <asp:TextBox ID="txtEnvCodigo" runat="server" Height="16px" Width="104px" Enabled="False"></asp:TextBox>
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
                                              <td class="auto-style993">
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
                                               <td align="center" class="auto-style993">
                                                    <asp:Button ID="Button3" runat="server" CssClass="btn-login" Text="Guardar" Height="41px" Width="113px" OnClick="Button3_Click" />
                                               </td>
                                              <td>&nbsp;</td> 
                                           </tr>
                                      </table>
                                 </asp:View>
                                 <asp:View ID="View7" runat="server">
                                     <table style="width:100%;">
                                         <tr>
                                             <td class="auto-style846">&nbsp;</td>
                                             <td class="auto-style865">&nbsp;</td>
                                             <td class="auto-style853">&nbsp;</td>
                                             <td class="auto-style867">&nbsp;</td>
                                             <td class="auto-style852">&nbsp;</td>
                                             <td class="auto-style868">&nbsp;</td>
                                             <td class="auto-style851">&nbsp;</td>
                                             <td>&nbsp;</td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style846">&nbsp;</td>
                                             <td class="auto-style865">
                                                 <asp:Label ID="Label79" runat="server" Font-Names="Arial Narrow" Text="EAN 13:"></asp:Label>
                                             </td>
                                             <td class="auto-style853">
                                                 <asp:TextBox ID="txtEan13" runat="server" Height="16px" Width="179px" Enabled="False"></asp:TextBox>
                                             </td>
                                             <td class="auto-style867">
                                                 <asp:Label ID="Label80" runat="server" Font-Names="Arial Narrow" Text="EAN 14:"></asp:Label>
                                             </td>
                                             <td class="auto-style852">
                                                 <asp:TextBox ID="txtEan14" runat="server" Height="16px" Width="179px" Enabled="False"></asp:TextBox>
                                             </td>
                                             <td class="auto-style868">
                                                 <asp:Label ID="Label81" runat="server" Font-Names="Arial Narrow" Text="CODIGO ADICIONAL:"></asp:Label>
                                             </td>
                                             <td class="auto-style851">
                                                 <asp:TextBox ID="txtCodAdici" runat="server" Height="16px" Width="179px" Enabled="False"></asp:TextBox>
                                             </td>
                                             <td>&nbsp;</td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style907"></td>
                                             <td class="auto-style908"></td>
                                             <td class="auto-style909">
                                                 <asp:Label ID="Label82" runat="server" Font-Names="Arial Narrow" Font-Size="X-Small" Text="(ETIQUETA)"></asp:Label>
                                             </td>
                                             <td class="auto-style910"></td>
                                             <td class="auto-style911">
                                                 <asp:Label ID="Label83" runat="server" Font-Names="Arial Narrow" Font-Size="X-Small" Text="(CORRUGADO)"></asp:Label>
                                             </td>
                                             <td class="auto-style912"></td>
                                             <td class="auto-style913">
                                                 <asp:Label ID="Label84" runat="server" Font-Names="Arial Narrow" Font-Size="X-Small" Text="(OTROS)"></asp:Label>
                                             </td>
                                             <td class="auto-style914"></td>
                                         </tr>
                                     </table>
                                     <table style="width:100%;">
                                          <tr>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td>&nbsp;</td>                                              
                                               <td align="center">
                                                    <asp:Button ID="Button4" runat="server" CssClass="btn-login" Text="Guardar" Height="41px" Width="113px" OnClick="Button4_Click" />
                                               </td>
                                              <td>&nbsp;</td> 
                                           </tr>
                                      </table>
                                 </asp:View>
                                 <asp:View ID="View8" runat="server">
                                     <table style="width:100%;">
                                         <tr>
                                             <td class="auto-style926">&nbsp;</td>
                                             <td align="right">
                                                 <asp:Label ID="Label85" runat="server" Font-Bold="False" Font-Names="Arial Narrow" Text="UNIDADES POR CORRUGADO:"></asp:Label>
                                             </td>
                                             <td class="auto-style929">
                                                 <asp:TextBox ID="txtUniCorr" runat="server" Height="16px" Width="95px"></asp:TextBox>
                                             </td>
                                             <td class="auto-style931">
                                                 <asp:Label ID="Label86" runat="server" Font-Bold="False" Font-Names="Arial Narrow" Text="CORRUGADOS POR CAMA:"></asp:Label>
                                             </td>
                                             <td class="auto-style928">
                                                 <asp:TextBox ID="txtCorrCama" runat="server" Height="16px" Width="94px"></asp:TextBox>
                                             </td>
                                             <td class="auto-style934">
                                                 <asp:Label ID="Label87" runat="server" Font-Bold="False" Font-Names="Arial Narrow" Text="CAMAS POR TARIMA:"></asp:Label>
                                             </td>
                                             <td class="auto-style933">
                                                 <asp:TextBox ID="txtCamasTarimas" runat="server" Height="16px" Width="95px"></asp:TextBox>
                                             </td>
                                             <td>&nbsp;</td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style926">&nbsp;</td>
                                             <td align="right" class="auto-style930">
                                                 <asp:Label ID="Label88" runat="server" Font-Bold="False" Font-Names="Arial Narrow" Text="TARIMA:"></asp:Label>
                                             </td>
                                             <td class="auto-style929">
                                                 <asp:TextBox ID="txtTipoTarima" runat="server" Height="16px" Width="96px"></asp:TextBox>
                                             </td>
                                             <td class="auto-style931">
                                                 <asp:Label ID="Label89" runat="server" Font-Bold="False" Font-Names="Arial Narrow" Text="ALTURA MAXIMA DE ESTIBA:"></asp:Label>
                                             </td>
                                             <td class="auto-style928">
                                                 <asp:TextBox ID="txtAlturaEstiba" runat="server" Height="16px" Width="96px"></asp:TextBox>
                                             </td>
                                             <td class="auto-style934">
                                                 <asp:Label ID="Label96" runat="server" Font-Bold="False" Font-Names="Arial Narrow" Text="CAJAS POR TARIMA:"></asp:Label>
                                             </td>
                                             <td class="auto-style933">
                                                 <asp:TextBox ID="txtCajasTarimas" runat="server" Height="16px" Width="95px"></asp:TextBox>
                                             </td>
                                             <td>&nbsp;</td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style926">&nbsp;</td>
                                             <td align="right"  class="auto-style930">
                                                 <asp:Label ID="Label129" runat="server" Font-Bold="False" Font-Names="Arial Narrow" Text="PESO:"></asp:Label>
                                             </td>
                                             <td class="auto-style929">
                                                 <asp:TextBox ID="txtPeso" runat="server" Height="16px" Width="96px"></asp:TextBox>
                                             </td>
                                             <td class="auto-style931">&nbsp;</td>
                                             <td class="auto-style928">&nbsp;</td>
                                             <td class="auto-style934">&nbsp;</td>
                                             <td class="auto-style933">&nbsp;</td>
                                             <td>&nbsp;</td>
                                         </tr>
                                     </table>
                                     <table style="width:100%;">
                                          <tr>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td>&nbsp;</td>                                              
                                               <td align="center">
                                                    <asp:Button ID="Button5" runat="server" CssClass="btn-login" Text="Guardar" Height="41px" Width="113px" OnClick="Button5_Click" />
                                               </td>
                                              <td>&nbsp;</td> 
                                           </tr>
                                      </table>
                                 </asp:View>
                                 <asp:View ID="View13" runat="server">
                                      <table style="width:100%;">
                                          <tr>
                                              <td align="right" class="auto-style920">
                                                  <asp:Label ID="Label3" runat="server" Font-Names="Arial Narrow" Text="CENTRO DE ENVASADO:"></asp:Label>
                                              </td>
                                              <td align="left" class="auto-style1020">
                                                  <asp:TextBox ID="txtCE" runat="server" Height="16px" Width="877px" Style="text-transform: uppercase"></asp:TextBox>
                                              </td>
                                              <td></td>
                                          </tr>
                                                                          
                                     </table>
                                     <table style="width:100%;">                                         
                                              </tr>
                                              <tr>
                                                  <td>&nbsp;</td>
                                                  <td align="center">
                                                      <asp:Button ID="btnGEquiEnv" runat="server" Height="41px" Width="113px"  CssClass="btn-login" OnClick="btnGEquiEnv_Click" Text="Guardar" />
                                                  </td>
                                                  <td>&nbsp;</td>
                                              </tr>
                                      </table>
                                 </asp:View>
                                 <asp:View ID="View9" runat="server">                                     
                                     <table style="width:100%;">
                                         <tr>
                                             <td class="auto-style946">
                                                 &nbsp;</td>
                                             <td class="auto-style953">
                                                 <asp:Label ID="Label97" runat="server" Font-Bold="False" Font-Names="Arial Narrow" Text="7.0 IMAGEN DEL PRODUCTO"></asp:Label>
                                             </td>
                                             <td class="auto-style944"></td>
                                             <td class="auto-style949">
                                                 <asp:Label ID="Label98" runat="server" Font-Bold="False" Font-Names="Arial Narrow" Text="8.0 EJEMPLO DE LOTIFICADO                        (INCLUIR CADUCIDAD SI APLICA)"></asp:Label>
                                             </td>
                                             <td class="auto-style943">
                                                 &nbsp;</td>
                                             <td class="auto-style3">
                                                 <asp:Label ID="Label99" runat="server" Font-Bold="False" Font-Names="Arial Narrow" Text="9.0 IDENTIFICACION DEL CORRUGADO"></asp:Label>
                                             </td>
                                             <td class="auto-style940">&nbsp;</td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style995"></td>
                                             <td class="auto-style996">
                                                 <asp:FileUpload ID="fuIProd" runat="server" Enabled="False" Width="172px" />
                                                 <asp:Button ID="btnVisualiza1" runat="server" OnClick="btnVisualiza1_Click" Text="Visualizar" Width="69px" Enabled="False" />
                                                 <asp:Button ID="btnBI1" runat="server" Enabled="False" OnClick="btnBI1_Click" Text="Borrar" Width="69px" />
                                             </td>
                                             <td class="auto-style997"></td>
                                             <td class="auto-style998">
                                                 <asp:FileUpload ID="fuILotificado" runat="server" Enabled="False" Width="172px" />
                                                 <asp:Button ID="btnVisualiza2" runat="server" OnClick="btnVisualiza2_Click2" Text="Visualizar" Width="70px" Enabled="False" />
                                                 <asp:Button ID="btnBI2" runat="server" Enabled="False" OnClick="btnBI2_Click" Text="Borrar" Width="69px" />
                                             </td>
                                             <td class="auto-style999">
                                                 </td>
                                             <td class="auto-style1000">
                                                 <asp:FileUpload ID="fuICorrugado" runat="server" Enabled="False" Width="172px" />
                                                 <asp:Button ID="btnVisualiza3" runat="server" OnClick="btnVisualiza3_Click" Text="Visualizar" Width="68px" Enabled="False" />
                                                 <asp:Button ID="btnBI3" runat="server" Enabled="False" OnClick="btnBI3_Click" Text="Borrar" Width="69px" />
                                             </td>
                                             <td class="auto-style1001">
                                                 </td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style946">
                                                 &nbsp;</td>
                                             <td class="auto-style953">
                                                 <asp:Image ID="imgProd" runat="server" />
                                             </td>
                                             <td class="auto-style944"></td>
                                             <td class="auto-style949">
                                                 <asp:Image ID="imgLotificado" runat="server" />
                                             </td>
                                             <td class="auto-style943">
                                                 &nbsp;</td>
                                             <td class="auto-style3">
                                                 <asp:Image ID="imgCorrugado" runat="server" />
                                             </td>
                                             <td class="auto-style940">&nbsp;</td>
                                         </tr>
                                     </table>
                                     <table style="width:100%;">
                                          <tr>
                                              <td align="center">
                                                  <asp:Label ID="lblproducto" runat="server" Font-Bold="False" Font-Names="Arial Narrow"></asp:Label>
                                              </td>
                                              <td align="center">
                                                  <asp:Label ID="lbllotificado" runat="server" Font-Bold="False" Font-Names="Arial Narrow"></asp:Label>
                                              </td>
                                              <td align="center">
                                                  <asp:Label ID="lblcorrugado" runat="server" Font-Bold="False" Font-Names="Arial Narrow"></asp:Label>
                                              </td>
                                          </tr>
                                          <tr>
                                              <td class="auto-style950"></td>
                                              <td class="auto-style951"></td>
                                              <td class="auto-style840"></td>
                                          </tr>
                                          <tr>
                                              <td class="auto-style950"></td>
                                              <td class="auto-style951"></td>
                                              <td class="auto-style840"></td>
                                          </tr>
                                          <tr>
                                              <td class="auto-style947">&nbsp;</td>
                                              <td class="auto-style948">&nbsp;</td>
                                              <td>&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td class="auto-style947">&nbsp;</td>                                              
                                               <td align="center" class="auto-style948">
                                                    <asp:Button ID="Button6" runat="server" CssClass="btn-login" Text="Guardar" Height="41px" Width="113px" OnClick="Button6_Click" />
                                               </td>
                                              <td>&nbsp;</td> 
                                           </tr>
                                      </table>
                                 </asp:View>
                                 <asp:View ID="View10" runat="server">
                                     <table style="width:100%;">
                                         <tr>
                                             <td class="auto-style956"></td>
                                             <td align="left">
                                                 <asp:Label ID="Label109" runat="server" Font-Bold="False" Font-Names="Arial Narrow" Text="OBSERVACIONES:"></asp:Label>
                                             </td>
                                             <td class="auto-style840"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style957"></td>
                                             <td class="auto-style959">
                                                 <asp:TextBox ID="txtobs" runat="server" Height="106px" Width="601px" TextMode="MultiLine"></asp:TextBox>
                                             </td>
                                             <td class="auto-style955"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style961">&nbsp;</td>
                                             <td class="auto-style960">&nbsp;</td>
                                             <td>&nbsp;</td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style961">&nbsp;</td>
                                             <td class="auto-style960">&nbsp;</td>
                                             <td>&nbsp;</td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style961">&nbsp;</td>
                                             <td class="auto-style960">&nbsp;</td>
                                             <td>&nbsp;</td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style961">&nbsp;</td>
                                             <td class="auto-style960">&nbsp;</td>
                                             <td>&nbsp;</td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style961">&nbsp;</td>
                                             <td class="auto-style960">&nbsp;</td>
                                             <td>&nbsp;</td>
                                         </tr>
                                          <tr>
                                             <td class="auto-style961">&nbsp;</td>
                                             <td align="center">
                                                 <asp:Button ID="Button8" runat="server" CssClass="btn-login" Height="41px" OnClick="Button8_Click" Text="Guardar" Width="113px" />
                                              </td>
                                             <td>&nbsp;</td>
                                         </tr>
                                     </table>
                                 </asp:View>
                                 <asp:View ID="View11" runat="server">
                                     <table style="width:100%;">
                                         <tr>
                                             <td class="auto-style823">&nbsp;</td>
                                             <td class="auto-style896">&nbsp;</td>
                                             <td class="auto-style989">
                                                 &nbsp;</td>
                                             <td class="auto-style987">
                                                 <asp:Label ID="Label126" runat="server" Font-Bold="True" Font-Names="Arial Narrow" Text="USUARIO"></asp:Label>
                                             </td>
                                             <td class="auto-style990">
                                                 <asp:Label ID="Label118" runat="server" Font-Bold="True" Font-Names="Arial Narrow" Text="FIRMA"></asp:Label>
                                             </td>
                                             <td class="auto-style991">&nbsp;</td>
                                             <td class="auto-style983">&nbsp;</td>
                                             <td class="auto-style988">
                                                 <asp:Label ID="Label120" runat="server" Font-Bold="True" Font-Names="Arial Narrow" Text="USUARIO"></asp:Label>
                                             </td>
                                             <td class="auto-style984">
                                                 <asp:Label ID="Label121" runat="server" Font-Bold="True" Font-Names="Arial Narrow" Text="FIRMA"></asp:Label>
                                             </td>
                                             <td class="auto-style847"></td>
                                             <td></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style823">&nbsp;</td>
                                             <td class="auto-style896">
                                                 &nbsp;</td>
                                             <td class="auto-style989">
                                                 <asp:Label ID="Label122" runat="server" Font-Bold="True" Font-Names="Arial Narrow" Text="SOLICITÓ:"></asp:Label>
                                             </td>
                                             <td align="center" class="auto-style987">
                                                 <asp:Label ID="lblsol" runat="server" Font-Bold="False" Font-Names="Arial Narrow"></asp:Label>
                                             </td>
                                             <td align="left" class="auto-style990">
                                                 <asp:CheckBox ID="chsolicita" runat="server" Enabled="False" />
                                             </td>
                                             <td class="auto-style991">&nbsp;</td>
                                             <td class="auto-style983">
                                                 <asp:Label ID="Label114" runat="server" Font-Bold="True" Font-Names="Arial Narrow" Text="ROSS ERP:"></asp:Label>
                                             </td>
                                             <td class="auto-style988">
                                                 <asp:Label ID="lblRoss" runat="server" Font-Bold="False" Font-Names="Arial Narrow"></asp:Label>
                                             </td>
                                             <td align="center" class="auto-style984">
                                                 <asp:CheckBox ID="cherp" runat="server" Enabled="False" />
                                             </td>
                                             <td class="auto-style847">
                                                 &nbsp;</td>
                                             <td>&nbsp;</td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style823">&nbsp;</td>
                                             <td class="auto-style896">
                                                 &nbsp;</td>
                                             <td class="auto-style989">
                                                 <asp:Label ID="Label123" runat="server" Font-Bold="True" Font-Names="Arial Narrow" Text="DNP:"></asp:Label>
                                             </td>
                                             <td align="center" class="auto-style987">
                                                 <asp:Label ID="lbldnp" runat="server" Font-Bold="False" Font-Names="Arial Narrow"></asp:Label>
                                             </td>
                                             <td align="left" class="auto-style990">
                                                 <asp:CheckBox ID="chdnp" runat="server" Enabled="False" />
                                             </td>
                                             <td class="auto-style991">&nbsp;</td>
                                             <td class="auto-style983">
                                                 <asp:Label ID="Label115" runat="server" Font-Bold="True" Font-Names="Arial Narrow" Text="POCESOS:"></asp:Label>
                                             </td>
                                             <td class="auto-style988">
                                                 <asp:Label ID="lblmat" runat="server" Font-Bold="False" Font-Names="Arial Narrow"></asp:Label>
                                             </td>
                                             <td align="center" class="auto-style984">
                                                 <asp:CheckBox ID="chmat" runat="server" Enabled="False" />
                                             </td>
                                             <td class="auto-style847">
                                                 &nbsp;</td>
                                             <td>&nbsp;</td>
                                         </tr>
                                          <tr>
                                             <td class="auto-style823">&nbsp;</td>
                                             <td class="auto-style896">
                                                 &nbsp;</td>
                                             <td class="auto-style989">
                                                 <asp:Label ID="Label124" runat="server" Font-Bold="True" Font-Names="Arial Narrow" Text="COSTOS:"></asp:Label>
                                              </td>
                                             <td align="center" class="auto-style987">
                                                 <asp:Label ID="lblcostos" runat="server" Font-Bold="False" Font-Names="Arial Narrow"></asp:Label>
                                              </td>
                                             <td align="left" class="auto-style990">
                                                 <asp:CheckBox ID="chcostos" runat="server" Enabled="False" />
                                              </td>
                                              <td class="auto-style991">&nbsp;</td>
                                             <td class="auto-style983">
                                                 <asp:Label ID="Label116" runat="server" Font-Bold="True" Font-Names="Arial Narrow" Text="CALIDAD:"></asp:Label>
                                              </td>
                                             <td class="auto-style988">
                                                 <asp:Label ID="lblmat2" runat="server" Font-Bold="False" Font-Names="Arial Narrow"></asp:Label>
                                              </td>
                                             <td align="center" class="auto-style984">
                                                 <asp:CheckBox ID="chmat2" runat="server" Enabled="False" />
                                              </td>
                                              <td class="auto-style847">
                                                  &nbsp;</td>
                                              <td>&nbsp;</td>
                                         </tr>
                                          <tr>
                                            <td class="auto-style823">&nbsp;</td>
                                             <td class="auto-style896">
                                                 &nbsp;</td>
                                             <td class="auto-style989">
                                                 <asp:Label ID="Label125" runat="server" Font-Bold="True" Font-Names="Arial Narrow" Text="I&amp;D"></asp:Label>
                                              </td>
                                             <td align="center" class="auto-style987">
                                                 <asp:Label ID="lblid" runat="server" Font-Bold="False" Font-Names="Arial Narrow"></asp:Label>
                                              </td>
                                             <td align="left" class="auto-style990">
                                                 <asp:CheckBox ID="chid" runat="server" Enabled="False" />
                                              </td>
                                              <td class="auto-style991">&nbsp;</td>
                                             <td class="auto-style983">
                                                 <asp:Label ID="Label117" runat="server" Font-Bold="True" Font-Names="Arial Narrow" Text="DIRECCION PLANTA:"></asp:Label>
                                              </td>
                                             <td class="auto-style988">
                                                 <asp:Label ID="lbldir" runat="server" Font-Bold="False" Font-Names="Arial Narrow"></asp:Label>
                                              </td>
                                             <td align="center" class="auto-style984">
                                                 <asp:CheckBox ID="chdir" runat="server" Enabled="False" />
                                              </td>
                                              <td class="auto-style847">
                                                  &nbsp;</td>
                                              <td>&nbsp;</td>
                                         </tr>
                                          <tr>
                                             <td class="auto-style1002"></td>
                                             <td class="auto-style1003"></td>
                                             <td class="auto-style1004">
                                                 <asp:Label ID="Label130" runat="server" Font-Bold="True" Font-Names="Arial Narrow" Text="HACCP"></asp:Label>
                                              </td>
                                             <td class="auto-style1005">
                                                 <asp:Label ID="lblhac" runat="server" Font-Bold="False" Font-Names="Arial Narrow"></asp:Label>
                                              </td>
                                             <td class="auto-style1006">
                                                 <asp:CheckBox ID="chhac" runat="server" Enabled="False" />
                                              </td>
                                             <td align="center" class="auto-style1007">
                                                 </td>
                                             <td class="auto-style1008">
                                                 <asp:Label ID="Label131" runat="server" Font-Bold="True" Font-Names="Arial Narrow" Text="VENTAS:"></asp:Label>
                                              </td>
                                             <td class="auto-style1009">
                                                 <asp:Label ID="lblventas" runat="server" Font-Bold="False" Font-Names="Arial Narrow"></asp:Label>
                                              </td>
                                              <td  align="center" class="auto-style1010">
                                                  <asp:CheckBox ID="chventas" runat="server" Enabled="False" />
                                              </td>
                                              <td class="auto-style1011"></td>
                                              <td class="auto-style1012"></td>
                                         </tr>
                                          <tr>
                                             <td class="auto-style823">&nbsp;</td>
                                             <td class="auto-style896">&nbsp;</td>
                                             <td class="auto-style989">&nbsp;</td>
                                             <td class="auto-style987">&nbsp;</td>
                                             <td class="auto-style990">
                                                 <asp:Label ID="Label128" runat="server" Font-Bold="True" Font-Names="Arial Narrow" Text="CONTRASEÑA:"></asp:Label>
                                              </td>
                                             <td align="center" class="auto-style991">
                                                 &nbsp;</td>
                                             <td class="auto-style983">
                                                 <asp:TextBox ID="txtpass" runat="server" ForeColor="#666666" placeholder="CONTRASEÑA" TextMode="Password"></asp:TextBox>
                                              </td>
                                             <td class="auto-style988">
                                                 <asp:Button ID="btn11" runat="server" CssClass="btn-login" Height="36px" OnClick="btn11_Click" Text="Firmar" Width="77px" />
                                              </td>
                                              <td class="auto-style984"></td>
                                              <td class="auto-style847"></td>
                                              <td></td>
                                         </tr>
                                         </table>
                                         <table style="width:100%;">
                                          <tr>
                                             <td>&nbsp;</td>
                                             <td align="center">
                                                 &nbsp;</td>
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
