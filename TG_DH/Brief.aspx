<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Brief.aspx.cs" Inherits="DNP.Brief" %>
<%@ Register assembly="EeekSoft.Web.PopupWin" namespace="EeekSoft.Web" tagprefix="Web" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc2" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
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

               
     
           .table-Cebra{
           border: solid 0px #CCC;
           border-spacing: 0;
           
       }
       .table-Cebra thead tr{
           background:#333;
           color:white;
       }
       .table-Cebra th,
       .table-Cebra td {
           border-right:0px solid #CCC;
           min-width: 130px;
       }

       .table-Cebra th:last-child,
       .table-Cebra td:last-child {
           border-right:0px;

       }

       .table-Cebra td {
           border-bottom:1px solid #CCC;
       }

       .table-Cebra tbody tr {
           background: white;
       }

       .table-Cebra tbody tr:nth-child(2n) {
           background: #f2f2f2;
       }


       .table-Cebra tr:nth-child(even) {
           background-color: #f2f2f2;
       }

       .table-Cebra th {
           background-color: #339405;
           color: white;
       }
          .table-Cebra tr:nth-child(even):hover {
           background-color: #CCE5FF;
       }
             .table-Cebra tr:nth-child(odd):hover {
           background-color: #CCE5FF;
           
       }



               .table-CebraTapa{
           border: solid 0px #CCC;
           border-spacing: 0;
           
       }
       .table-CebraTapa thead tr{
           background:#333;
           color:white;
       }
       .table-CebraTapa th,
       .table-CebraTapa td {
           border-right:0px solid #CCC;
           min-width: 120px;
       }

       .table-CebraTapa th:last-child,
       .table-CebraTapa td:last-child {
           border-right:0px;

       }

       .table-CebraTapa td {
           border-bottom:1px solid #CCC;
       }

       .table-CebraTapa tbody tr {
           background: white;
       }

       .table-CebraTapa tbody tr:nth-child(2n) {
           background: #f2f2f2;
       }


       .table-CebraTapa tr:nth-child(even) {
           background-color: #f2f2f2;
       }

       .table-CebraTapa th {
           background-color: #339405;
           color: white;
       }
          .table-CebraTapa tr:nth-child(even):hover {
           background-color: #CCE5FF;
       }
             .table-CebraTapa tr:nth-child(odd):hover {
           background-color: #CCE5FF;
           
       }
      



       .table-CebraFirma{
           border: solid 0px #CCC;
           border-spacing: 0;
           
       }
       .table-CebraFirma thead tr{
           background:#333;
           color:white;
       }
       .table-CebraFirma th,
       .table-CebraFirma td {
           border-right:0px solid #CCC;
           min-width: 100px;
       }

       .table-CebraFirma th:last-child,
       .table-CebraFirma td:last-child {
           border-right:0px;

       }

       .table-CebraFirma td {
           border-bottom:1px solid #CCC;
       }

       .table-CebraFirma tbody tr {
           background: white;
       }

       .table-CebraFirma tbody tr:nth-child(2n) {
           background: #f2f2f2;
       }


       .table-CebraFirma tr:nth-child(even) {
           background-color: #f2f2f2;
       }

       .table-CebraFirma th {
           background-color: #339405;
           color: white;
       }
          .table-CebraFirma tr:nth-child(even):hover {
           background-color: #CCE5FF;
       }
             .table-CebraFirma tr:nth-child(odd):hover {
           background-color: #CCE5FF;
           
       }
       
        .auto-style5 {
            width: 634px;
        }
               
        .auto-style7 {
            width: 388px;
        }
       
        .auto-style10 {
            width: 121px;
        }
        .auto-style11 {
            width: 100px;
        }
        .auto-style12 {
            width: 87px;
        }
        .auto-style18 {
            width: 73px;
        }
        .auto-style19 {
            width: 128px;
        }
        .auto-style20 {
            width: 75px;
        }
               
        .auto-style24 {
            width: 73px;
            height: 26px;
        }
        .auto-style25 {
            width: 121px;
            height: 26px;
        }
        .auto-style26 {
            width: 100px;
            height: 26px;
        }
        .auto-style27 {
            width: 87px;
            height: 26px;
        }
               div.centerTable{
        text-align: center;
}

div.centerTable table {
       margin: 0 auto;
       text-align: left;
}
        .auto-style28 {
            width: 724px;
        }
        .auto-style33 {
            width: 304px;
        }
        .auto-style34 {
            width: 164px;
        }
        .auto-style35 {
            width: 151px;
        }
        .auto-style37 {
            width: 298px;
        }
        .auto-style41 {
            width: 84px;
        }
        .auto-style42 {
            width: 81px;
            height: 47px;
        }
        .auto-style43 {
            width: 82px;
        }
        .auto-style44 {
            width: 90px;
            height: 47px;
        }
        .auto-style45 {
            width: 93px;
        }
        .auto-style46 {
            width: 94px;
            height: 47px;
        }
        .auto-style47 {
            width: 95px;
        }
        .auto-style52 {
            width: 60px;
        }
        .auto-style53 {
            width: 86px;
        }
        .auto-style54 {
            width: 101px;
        }
        .auto-style56 {
            width: 70px;
        }
        .auto-style57 {
            width: 158px;
        }
        .auto-style58 {
            width: 114px;
        }
        .auto-style59 {
            width: 127px;
        }
        .auto-style62 {
            width: 35px;
        }
        .auto-style64 {
            width: 115px;
        }
        .auto-style65 {
            width: 109px;
        }
        .auto-style66 {
            width: 103px;
        }
        .auto-style67 {
            width: 153px;
        }
        .auto-style68 {
            width: 7px;
        }
        .auto-style69 {
            width: 102px;
        }
        .auto-style70 {
            width: 323px;
            height: 27px;
        }
        .auto-style73 {
            width: 134px;
        }
        .auto-style74 {
            width: 35px;
            height: 45px;
        }
        .auto-style75 {
            width: 109px;
            height: 45px;
        }
        .auto-style76 {
            height: 45px;
        }
        .auto-style77 {
            width: 115px;
            height: 45px;
        }
        .auto-style78 {
            width: 596px;
        }
        .auto-style83 {
            width: 567px;
        }
        .auto-style84 {
            width: 158px;
            height: 27px;
        }
        .auto-style85 {
            width: 114px;
            height: 27px;
        }
        .auto-style86 {
            width: 127px;
            height: 27px;
        }
        .auto-style87 {
            height: 27px;
        }
        .auto-style88 {
            width: 158px;
            height: 33px;
        }
        .auto-style89 {
            width: 114px;
            height: 33px;
        }
        .auto-style90 {
            width: 127px;
            height: 33px;
        }
        .auto-style91 {
            height: 33px;
        }
        .auto-style92 {
            width: 35px;
            height: 27px;
        }
        .auto-style93 {
            width: 109px;
            height: 27px;
        }
        .auto-style94 {
            width: 115px;
            height: 27px;
        }
        .auto-style95 {
            width: 73px;
            height: 27px;
        }
        .auto-style96 {
            width: 121px;
            height: 27px;
        }
        .auto-style97 {
            width: 100px;
            height: 27px;
        }
        .auto-style98 {
            width: 87px;
            height: 27px;
        }
        .auto-style99 {
            width: 75px;
            height: 27px;
        }
        .auto-style100 {
            width: 128px;
            height: 27px;
        }
        .auto-style101 {
            width: 102px;
            height: 26px;
        }
        .auto-style102 {
            width: 134px;
            height: 26px;
        }
        .auto-style103 {
            width: 153px;
            height: 26px;
        }
        .auto-style104 {
            width: 387px;
            height: 72px;
        }
        .auto-style105 {
            height: 72px;
        }
        .auto-style106 {
            width: 567px;
            height: 72px;
        }
                
        
        .auto-style109 {
            height: 83px;
        }
        
        .auto-style110 {
            height: 49px;
        }

        .especificaciones txtEsp{
            margin-left:80px;
            margin-top:50px;
        }
        
        
        }
        .auto-style111 {
            height: 24px;
        }
        .auto-style112 {
            width: 140px;
            margin-left: 40px;
        }
        .auto-style114 txtEsp{
            width: 387px;
            margin-left: 120px;
        }
       
       .auto-style115 {
            width: 387px;
        }
        .auto-style1014 {
            width: 105px;
        }
        .auto-style1015 {
            width: 15px;
        }
        .auto-style1016 {
            width: 82px;
            height: 225px;
        }
        .auto-style1017 {
            width: 95px;
            height: 225px;
        }
        .auto-style1018 {
            width: 93px;
            height: 225px;
        }
        .auto-style1019 {
            height: 225px;
        }
        .auto-style1020 {
            width: 84px;
            height: 47px;
        }
        .auto-style1021 {
            width: 388px;
            height: 27px;
        }
        .auto-style1022 {
            width: 634px;
            height: 27px;
        }
        .auto-style1026 {
            width: 140px;
            margin-left: 80px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <center>
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
                       <div id="div1" class="centerTable">                       
                         <center>  
                           <table style="width: 100%;">
                             <tr>
                                 <td align="center">
                                        <asp:Menu ID="Menu3" AutoPostBack="false" runat="server" Orientation="Horizontal" OnMenuItemClick="Menu3_MenuItemClick" Width="839px" MaximumDynamicDisplayLevels="0" Font-Bold="False" Font-Italic="False" Font-Names="Arial Narrow" Font-Strikeout="False" Font-Underline="False" ForeColor="#0416BB" Height="51px" RenderingMode="Table" >
                                           <DynamicMenuItemStyle HorizontalPadding="0px" ItemSpacing="0px" VerticalPadding="0px" />
                                           <Items>
                                               <asp:MenuItem Text="BUSCAR" ToolTip="BUSCAR" Value="0" Selected="True"></asp:MenuItem>
                                               <asp:MenuItem Text="PROYECTO" Value="1" ToolTip="PROYECTO"></asp:MenuItem>
                                               <asp:MenuItem Text="BOTELLA" Value="2" ToolTip="BOTELLA"></asp:MenuItem>
                                               <asp:MenuItem Text="TAPA" Value="3" ToolTip="TAPA"></asp:MenuItem>
                                               <asp:MenuItem Text="ETIQUETA/FUNDA" ToolTip="ETIQUETA/FUNDA" Value="4"></asp:MenuItem>
                                               <asp:MenuItem Text="CORRUGADO" ToolTip="CORRUGADO" Value="5"></asp:MenuItem>
                                               <asp:MenuItem Text="FORMULA" ToolTip="FORMULA" Value="6"></asp:MenuItem>
                                               <asp:MenuItem Text="IMAGEN" Value="7" ToolTip="IMAGEN"></asp:MenuItem>
                                               <asp:MenuItem Text="LEGAL" ToolTip="LEGAL" Value="8"></asp:MenuItem>
                                               <asp:MenuItem Text="FIRMAS" ToolTip="FIRMAS" Value="9"></asp:MenuItem>
                                               <asp:MenuItem Text="REPORTE" ToolTip="REPORTE" Value="10"></asp:MenuItem>
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
                               <td align="center">
                                   <div class="divTitulo">
                                        <asp:Label ID="lbltitulo" runat="server" Text="BUSCAR" Font-Names="Arial" Font-Strikeout="False" ForeColor="White" Font-Bold="True" Font-Size="Medium"></asp:Label>
                                   </div>
                                </td>
                            </tr>                      
                            <tr>
                                <td>
                                    <asp:MultiView ID="MultiView1" runat="server" > 
                                        <asp:View ID="View1" runat="server">
                                             <table style="width:100%;">
                                         <tr>                                             <td class="auto-style841"></td>
                                             <td align="center" class="auto-style28">
                                                 <asp:Label ID="Label92" runat="server" Font-Names="Arial Narrow" Text="BUSQUEDA:"></asp:Label>
                                                 <asp:TextBox ID="txtBusqueda" runat="server" Font-Size="Small" Height="17px" Style="text-transform: uppercase" Width="310px"></asp:TextBox>
                                                 <asp:Label ID="Label15" runat="server" Font-Names="Arial" Font-Size="X-Small" Text="Ej. PROYECTO, CLIENTE, PRODCUTO."></asp:Label>
                                                 <asp:Button ID="btnBusca" runat="server" OnClick="CargaProyectosBrief" Text="Buscar" />
                                             </td>
                                             <td class="auto-style1015">&nbsp;</td>
                                             <td class="auto-style1014"></td>
                                             <td class="auto-style840">&nbsp;</td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style1020">&nbsp;</td>
                                             <td class="auto-style28">
                                                 <div style="height: 250px; width: 743px; overflow: scroll;">
                                                 <asp:DataGrid ID="dgBrief" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Font-Names="Arial" Font-Size="Small" ForeColor="#003366" GridLines="Vertical" Height="226px" PageSize="4" Width="700px" OnItemCommand="dgBrief_ItemCommand">
                                                     <Columns>
                                                         <asp:BoundColumn DataField="NO_PROYECTO" HeaderText="NO PROYECTO"></asp:BoundColumn>
                                                         <asp:BoundColumn DataField="CLIENTE" HeaderText="SOLICITA"></asp:BoundColumn>
                                                         <asp:BoundColumn DataField="PRODUCTO" HeaderText="PROYECTO"></asp:BoundColumn>
                                                         <asp:BoundColumn DataField="OTRO" HeaderText="TIPO"></asp:BoundColumn>
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
                                             <td class="auto-style1015">                                                
                                                 &nbsp;</td>
                                             <td class="auto-style1014">
                                                &nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label154" runat="server" Text="FILTRAR"></asp:Label>
                                                    <br />
                                                    
                                                 <asp:DropDownList ID="DropFiltroB" runat="server">
                                                    <asp:ListItem>SELECCIONE</asp:ListItem>                                                   
                                                    <asp:ListItem>NUEVO</asp:ListItem>
                                                    <asp:ListItem>FIRMAS</asp:ListItem>
                                                     <asp:ListItem>CANCELADO</asp:ListItem>
                                                     <asp:ListItem>ARCHIVO</asp:ListItem>
                                                 </asp:DropDownList>
                                                 <br />
                                                   <br />
                                                &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnFiltro" runat="server" Text="Filtrar" OnClick="btnFiltro_Click" />
                                                 <br />
                                                 <br />
                                                 ACTUALIZA&nbsp;&nbsp; ESTATUS<br />
                                                 <asp:DropDownList ID="ACTESTATUS" runat="server">
                                                     <asp:ListItem>SELECCIONE</asp:ListItem>                                                   
                                                     <asp:ListItem>NUEVO</asp:ListItem>
                                                     <asp:ListItem>FIRMAS</asp:ListItem>
                                                     <asp:ListItem>CANCELADO</asp:ListItem>
                                                     <asp:ListItem>ARCHIVO</asp:ListItem>
                                                 </asp:DropDownList>
                                                 <br />
                                                 <asp:Button ID="btnActualizaEstatus" runat="server" OnClick="btnActualizaEstatus_Click1" Text="Actualiza" />
                                                 <br />
                                                 &nbsp;&nbsp; &nbsp;<asp:Label ID="lblProyectoB" runat="server" Text="..." Visible="false"></asp:Label>
                                                 &nbsp;&nbsp;&nbsp;</td>
                                             <td>&nbsp;</td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style1020">&nbsp;</td>
                                             <td class="auto-style28">&nbsp;</td>
                                             <td class="auto-style1015">&nbsp;</td>
                                             <td class="auto-style1014">&nbsp;</td>
                                             <td>&nbsp;</td>
                                         </tr>
                                     </table>
                                        </asp:View>
                                        <asp:View ID="View2" runat="server" >
                                            <asp:Panel ID="Panel1" runat="server">
                                            <table style="width:80%;" class="table-Cebra">
                                                <tr>
                                                    <td class="auto-style34">
                                                        &nbsp; 
                                                        <asp:Label ID="Label119" runat="server" Font-Names="Arial Narrow" Text="COD PROYECTO: "></asp:Label>
                                                        <asp:Label ID="lblProyectoCotiza" runat="server" Font-Bold="True" Font-Names="Arial Narrow" ForeColor="#003399" Text="NUEVO"></asp:Label>
                                                    </td>
                                                    <td aling="left" class="auto-style1026">
                                                        <asp:Label ID="Label121" runat="server" Text="PROYECTO:" Font-Names="Arial Narrow"></asp:Label>
                                                        <asp:TextBox ID="txtprodCoti" runat="server" Width="345px"></asp:TextBox>
                                                    </td>
                                                    <td class="auto-style35">
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td class="auto-style34">
                                                        </td>
                                                    <td aling="left" class="auto-style112">
                                                        <asp:Label ID="Label122" runat="server" Text="CANTIDAD (cajas):" Font-Names="Arial Narrow"></asp:Label>
                                                        &nbsp;
                                                        <asp:TextBox ID="txtcajasCoti" runat="server" Width="80px" onkeypress="javascript:return solonumeros(event)" Height="16px"></asp:TextBox>
                                                        <br />
                                                        <asp:Label ID="Label146" runat="server" Text="CLIENTE:" Font-Names="Arial Narrow"></asp:Label>
                                                        &nbsp;
                                                        <asp:DropDownList ID="dpSolicitaCoti" runat="server" Font-Names="Arial Narrow">
                                                        </asp:DropDownList>
                                                    </td>
                                                     <td>
                                                     <asp:Label ID="Label3" runat="server" Text="TIPO DE PROYECTO:" Font-Names="Arial Narrow"></asp:Label>
                                                        &nbsp;
                                                        <asp:DropDownList ID="DropTP" runat="server" Font-Names="Arial Narrow">
                                                            <asp:ListItem>SELECCIONE</asp:ListItem>
                                                            <asp:ListItem>GEL</asp:ListItem>
                                                            <asp:ListItem>CERA GEL</asp:ListItem>
                                                            <asp:ListItem>CERA</asp:ListItem>
                                                            <asp:ListItem>BLOQUEADOR</asp:ListItem>
                                                            <asp:ListItem>AFTER SUN</asp:ListItem>
                                                            <asp:ListItem>CREMAS</asp:ListItem>
                                                            <asp:ListItem>SHAMPOO</asp:ListItem>
                                                            <asp:ListItem>JABON </asp:ListItem>
                                                        </asp:DropDownList>
                                                        </td>
                                                  
                                                </tr>
                                              
                                                <tr>
                                                    <td class="auto-style37">&nbsp;</td>
                                                    <td class="auto-style1026">&nbsp;</td>
                                                    <td>&nbsp;</td>
                                                </tr>
                                            </table>
                                            <table style="width:80%;" class="table-Cebra">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:RadioButton ID="FULLSERVICE" runat="server" Font-Bold="True" GroupName="maquila" Text="FULL SERVICE" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                    </td>
                                                    <td class="auto-style46">
                                                        <asp:RadioButton ID="TOLLING" runat="server" Font-Bold="True" GroupName="maquila" Text="TOLLING" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:RadioButton ID="PROCESO" runat="server" Font-Bold="True" GroupName="maquila" Text="PROCESO" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                    </td>
                                                    <td class="auto-style1020">
                                                        <asp:RadioButton ID="OTROMAQUILA" runat="server" Font-Bold="True" GroupName="maquila" Text="MAQUILA" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="auto-style1016">
                                                        <asp:Label ID="Label106" runat="server" Text="(Tipo de maquila en donde tecnoglobal pone todo lo necesario para la fabricacion)" Font-Names="Arial Narrow"></asp:Label>
                                                    </td>
                                                    <td class="auto-style1017">
                                                        <asp:Label ID="Label107" runat="server" Text="(Tipo de maquila en donde tecnoglobal pone de los materiales y el cliente otros mas para la fabricacion)" Font-Names="Arial Narrow"></asp:Label>
                                                    </td>
                                                    <td class="auto-style1018">
                                                        <asp:Label ID="Label108" runat="server" Text="(Tipo de maquila en donde tecnoglobal realiza solo algun proceso como elaboracion, envasado, empacado, etc)" Font-Names="Arial Narrow"></asp:Label>
                                                    </td>
                                                    <td class="auto-style1019">
                                                        </td>
                                                </tr>
                                                <tr>
                                                    <td class="auto-style43">&nbsp;</td>
                                                    <td class="auto-style47">&nbsp;</td>
                                                    <td class="auto-style45">&nbsp;</td>
                                                    <td aling="right">
                                                        <asp:Button ID="btnGuardar1" runat="server" CssClass="btn-login" Height="41px" OnClick="ActualizaCabecera" Text="Guardar" Width="113px" />
                                                    </td>
                                                </tr>
                                            </table>
                                                </asp:Panel>
                                        </asp:View>
                                        <asp:View ID="View3" runat="server">
                                            <asp:Panel ID="Panel2" runat="server">
                                           <table class="table-Cebra">
                                                <tr>
                                                    <td class="auto-style24">
                                                        <asp:Label ID="Label93" runat="server" Text="Gramaje" Font-Bold="True" Font-Names="Arial Narrow"></asp:Label>
                                                    </td>
                                                    <td class="auto-style25">
                                                        <asp:TextBox ID="txtgramaje" runat="server" onkeypress="javascript:return solonumeros(event)" Font-Names="Arial Narrow"></asp:TextBox>
                                                    </td>
                                                    <td aling="left" class="auto-style26">
                                                        <asp:Label ID="Label94" runat="server" Text="ml/gramos" Font-Names="Arial Narrow"></asp:Label>
                                                    </td>
                                                    <td class="auto-style27"></td>
                                                    
                                                </tr>
                                                <tr>
                                                    <td class="auto-style18">
                                                        <asp:Label ID="Label95" runat="server" Text="Forma" Font-Bold="True" Font-Names="Arial Narrow"></asp:Label>
                                                    </td>
                                                    <td class="auto-style10">
                                                        <asp:RadioButton ID="TARRO" runat="server" Text="Tarro" GroupName="forma" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                    </td>
                                                    <td class="auto-style11">
                                                        <asp:RadioButton ID="BOTELLA" runat="server" Text="Botella" GroupName="forma" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                    </td>
                                                    <td class="auto-style12">
                                                        <asp:RadioButton ID="TUBO" runat="server" GroupName="forma" Text="Tubo" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                    </td>
                                                    <td class="auto-style20">
                                                        <asp:RadioButton ID="SACHET" runat="server" GroupName="forma" Text="Sachet" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                    </td>
                                                    <td aling="left" class="auto-style19"> 
                                                        <asp:RadioButton ID="SQUIZ" runat="server" GroupName="forma" Text="Squiz" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                    </td>
                                                   
                                                </tr>
                                                <tr>
                                                    <td class="auto-style18">
                                                        <asp:Label ID="Label96" runat="server" Text="Material" Font-Bold="True" Font-Names="Arial Narrow"></asp:Label>
                                                    </td>
                                                    <td class="auto-style10">
                                                        <asp:RadioButton ID="PET" runat="server" GroupName="material" Text="PET" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                    </td>
                                                    <td class="auto-style11">
                                                        <asp:RadioButton ID="POLIPROPILENO" runat="server" GroupName="material" Text="Polipropileno" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                    </td>
                                                    <td class="auto-style12">
                                                        <asp:RadioButton ID="POLIETILENO" runat="server" GroupName="material" Text="Polietileno" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                    </td>
                                                    <td class="auto-style20">
                                                        <asp:RadioButton ID="OTROSMAT" runat="server" GroupName="material" Text="Otros" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                    </td>
                                                    <td class="auto-style19">
                                                        <asp:TextBox ID="txtOtrosMat" runat="server" Font-Names="Arial Narrow"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="auto-style95">
                                                        <asp:Label ID="Label97" runat="server" Text="Color" Font-Bold="True" Font-Names="Arial Narrow"></asp:Label>
                                                    </td>
                                                    <td class="auto-style96">
                                                        <asp:RadioButton ID="TRANSPARENTE" runat="server" GroupName="color" Text="Transparente" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                        </td>
                                                    <td class="auto-style97">
                                                        <asp:RadioButton ID="BLANCO" runat="server" GroupName="color" Text="Blanco" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                        </td>
                                                    <td class="auto-style98">
                                                        <asp:RadioButton ID="NEGRO" runat="server" GroupName="color" Text="Negro" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                        </td>
                                                    <td class="auto-style99">
                                                        <asp:RadioButton ID="OTROS" runat="server" Font-Names="Arial Narrow" GroupName="color" OnCheckedChanged="GetCheckedRB" Text="Otro" />
                                                        &nbsp;</td>
                                                    <td class="auto-style100">
                                                        <asp:TextBox ID="txtOtrosColor" runat="server" Font-Names="Arial Narrow"></asp:TextBox>
                                                    </td>

                                                </tr>
                                                <tr>
                                                    <td class="auto-style18"></td>
                                                    <td class="auto-style10"></td>
                                                    <td class="auto-style11"></td>
                                                    <td class="auto-style12"></td>
                                                    <td class="auto-style20">
                                                        &nbsp;</td>
                                                    <td aling="right">
                                                        <asp:Button ID="btnGuardar10" runat="server" CssClass="btn-login" Height="41px" OnClick="ActualizaBotella" Text="Guardar" Width="113px" />
                                                    </td>
                                                </tr>
                                            </table>
                                                </asp:Panel>
                                        </asp:View>
                                        <asp:View ID="View4" runat="server">
                                            <asp:Panel ID="Panel3" runat="server">
                                                <table style="width:90%;" class="table-Cebra">
                                                    <tr>
                                                        <td class="auto-style52">
                                                            <asp:Label ID="Label125" runat="server" Text="Tipo" Font-Bold="True" Font-Names="Arial Narrow"></asp:Label>
                                                        </td>
                                                        <td class="auto-style53">
                                                            <asp:RadioButton ID="LINEA" runat="server" GroupName="tipo" Text="Linea" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                        </td>
                                                        <td class="auto-style54">
                                                            <asp:RadioButton ID="ASA" runat="server" GroupName="tipo" Text="Con asa" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                        </td>
                                                        <td class="auto-style66">
                                                            <asp:RadioButton ID="FLITTOP" runat="server" GroupName="tipo" Text="Flit top" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                        </td>
                                                        <td class="auto-style56">
                                                            <asp:RadioButton ID="DISCTOP" runat="server" GroupName="tipo" Text="Disc top" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                        </td>
                                                        <td class="auto-style33">
                                                            <asp:RadioButton ID="CHUPON" runat="server" GroupName="tipo" Text="Chupon" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                            &nbsp;
                                                            <asp:RadioButton ID="SPRAYER" runat="server" Font-Names="Arial Narrow" GroupName="tipo" OnCheckedChanged="GetCheckedRB" Text="Sprayer" />
                                                            &nbsp;
                                                            <asp:RadioButton ID="OTROSTIPO" runat="server" Font-Names="Arial Narrow" GroupName="tipo" OnCheckedChanged="GetCheckedRB" Text="Otro" />
                                                            &nbsp;<asp:TextBox ID="txtotrostipo" runat="server" Font-Names="Arial Narrow" Height="16px" Width="95px"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                     <tr>
                                                        <td class="auto-style52">
                                                            <asp:Label ID="Label126" runat="server" Text="Material" Font-Bold="True" Font-Names="Arial Narrow"></asp:Label>
                                                         </td>
                                                        <td class="auto-style53">
                                                            <asp:RadioButton ID="PETTAPA" runat="server" GroupName="materialtapa" Text="PET" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                         </td>
                                                        <td class="auto-style54">
                                                            <asp:RadioButton ID="POLIPROPILENOTAPA" runat="server" GroupName="materialtapa" Text="Polipropileno" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                         </td>
                                                        <td class="auto-style66">
                                                            <asp:RadioButton ID="POLIETILENOTAPA" runat="server" GroupName="materialtapa" Text="Polietileno" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                         </td>
                                                        <td class="auto-style56">
                                                            <asp:RadioButton ID="OTROSM" runat="server" GroupName="materialtapa" Text="Otro" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                         </td>
                                                        <td class="auto-style33">
                                                            <asp:TextBox ID="txtOtrosMatTapa" runat="server" Height="16px" Width="109px" Font-Names="Arial Narrow"></asp:TextBox>
                                                         </td>
                                                    </tr>
                                                     <tr>
                                                        <td class="auto-style52">
                                                            <asp:Label ID="Label127" runat="server" Text="Color" Font-Bold="True" Font-Names="Arial Narrow"></asp:Label>
                                                         </td>
                                                        <td class="auto-style53">
                                                            <asp:RadioButton ID="NATURALTAPA" runat="server" GroupName="colortapa" Text="Natural" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                         </td>
                                                        <td class="auto-style54">
                                                            <asp:RadioButton ID="COLOR" runat="server" GroupName="colortapa" Text="Color" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                         </td>
                                                        <td class="auto-style66">
                                                            <asp:TextBox ID="txtColorTapa" runat="server" Height="16px" Width="105px" Font-Names="Arial Narrow"></asp:TextBox>
                                                         </td>
                                                        <td class="auto-style56">&nbsp;</td>
                                                        <td class="auto-style33">&nbsp;</td>
                                                    </tr>
                                                     <tr>
                                                        <td class="auto-style52">
                                                            <asp:Label ID="Label128" runat="server" Text="Terminado" Font-Bold="True" Font-Names="Arial Narrow"></asp:Label>
                                                         </td>
                                                        <td class="auto-style53">
                                                            <asp:RadioButton ID="GRABADO" runat="server" GroupName="terminadotapa" Text="Grabado" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                         </td>
                                                        <td class="auto-style54">
                                                            <asp:RadioButton ID="BRILLANTE" runat="server" GroupName="terminadotapa" Text="Brillante" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                         </td>
                                                        <td class="auto-style66">
                                                            <asp:RadioButton ID="MATE" runat="server" GroupName="terminadotapa" Text="Mate" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                         </td>
                                                        <td class="auto-style56">
                                                            <asp:RadioButton ID="LISA" runat="server" GroupName="terminadotapa" Text="Lisa" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                         </td>
                                                        <td class="auto-style33">
                                                            <asp:RadioButton ID="ESTRIADA" runat="server" GroupName="terminadotapa" Text="Estriada" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                            &nbsp;
                                                            <asp:RadioButton ID="OTROSTERM" runat="server" Font-Names="Arial Narrow" GroupName="terminadotapa" OnCheckedChanged="GetCheckedRB" Text="Otro" />
                                                            &nbsp;
                                                            <asp:TextBox ID="txtterminadolinner" runat="server" Font-Names="Arial Narrow" Height="16px" Width="157px"></asp:TextBox>
                                                         </td>
                                                       
                                                    </tr>
                                                     <tr>
                                                        <td class="auto-style52">
                                                            <asp:Label ID="Label129" runat="server" Text="Linner" Font-Bold="True" Font-Names="Arial Narrow"></asp:Label>
                                                         </td>
                                                        <td class="auto-style53">
                                                            <asp:RadioButton ID="CONLINNER" runat="server" GroupName="linner" Text="Con Linner" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                         </td>
                                                        <td class="auto-style54">
                                                            <asp:RadioButton ID="SINLINNER" runat="server" GroupName="linner" Text="Sin Linner" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                         </td>
                                                        <td class="auto-style66"></td>
                                                        <td class="auto-style56"></td>
                                                        <td class="auto-style33"></td>
                                                    </tr>
                                                     <tr>
                                                        <td class="auto-style52">&nbsp;</td>
                                                        <td class="auto-style53">&nbsp;</td>
                                                        <td class="auto-style54">&nbsp;</td>
                                                        <td class="auto-style66">&nbsp;</td>
                                                        <td class="auto-style56">&nbsp;</td>
                                                        <td aling="right">
                                                            <asp:Button ID="btnGuardar3" runat="server" CssClass="btn-login" Height="41px" OnClick="ActualizaTapa" Text="Guardar" Width="113px" />
                                                         </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                        </asp:View>
                                        <asp:View ID="View5" runat="server">
                                            <asp:Panel ID="Panel4" runat="server">
                                                <table style="width:90%;" class="table-Cebra">                                                                                                                                                         
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="Label152" runat="server" Font-Bold="True" Font-Names="Arial Narrow" Text="Tipo material"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:RadioButton ID="materialtipoEti" runat="server" Font-Names="Arial Narrow" GroupName="TipoIdent" OnCheckedChanged="materialtipoEti_CheckedChanged" Text="Etiqueta" AutoPostBack="True" />
                                                        </td>
                                                        <td>
                                                            <asp:RadioButton ID="materialtipofunda" runat="server" Font-Names="Arial Narrow" GroupName="TipoIdent" OnCheckedChanged="BOPPBCO1_CheckedChanged" Text="Funda" AutoPostBack="True" />
                                                        </td>
                                                        <td>
                                                            <asp:RadioButton ID="materialtipotubo" runat="server" Font-Names="Arial Narrow" GroupName="TipoIdent" Text="Tubo" AutoPostBack="True" OnCheckedChanged="materialtipotubo_CheckedChanged" />
                                                        </td>
                                                        <td></td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style84">
                                                            <asp:Label ID="Label130" runat="server" Text="Material etiqueta" Font-Bold="True" Font-Names="Arial Narrow"></asp:Label>
                                                        </td>
                                                        <td class="auto-style85">
                                                            <asp:RadioButton ID="BOPPBCO" runat="server" GroupName="MatEtiq" Text="BOPP BCO" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                        </td>
                                                        <td class="auto-style86">
                                                            <asp:RadioButton ID="BOPPTRANSP" runat="server" GroupName="MatEtiq" Text="BOPP TRANSP" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                        </td>
                                                        <td class="auto-style87">
                                                            <asp:RadioButton ID="BOPPMET" runat="server" GroupName="MatEtiq" Text="BOPP MET" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style57">
                                                            <asp:Label ID="Label131" runat="server" Text="Terminado etiqueta" Font-Bold="True" Font-Names="Arial Narrow"></asp:Label>
                                                        </td>
                                                        <td class="auto-style58">
                                                            <asp:RadioButton ID="MATEETI" runat="server" GroupName="TerminadoEti" Text="Mate" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                        </td>
                                                        <td class="auto-style59">
                                                            <asp:RadioButton ID="BRILLANTEETI" runat="server" GroupName="TerminadoEti" Text="Brillante" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                        </td>
                                                        <td>&nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style88">
                                                            <asp:Label ID="Label132" runat="server" Text="Material funda" Font-Bold="True" Font-Names="Arial Narrow"></asp:Label>
                                                        </td>
                                                        <td class="auto-style89">
                                                            <asp:RadioButton ID="PVC" runat="server" GroupName="MaterialFunda" Text="PVC" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                        </td>
                                                        <td class="auto-style90">
                                                            <asp:RadioButton ID="PETG" runat="server" GroupName="MaterialFunda" Text="PETG" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                        </td>
                                                        <td class="auto-style91">
                                                            <asp:RadioButton ID="OtroFunda" runat="server" GroupName="MaterialFunda" Text="Otro" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                            &nbsp;&nbsp;
                                                            <asp:TextBox ID="txtOtrosFunda" runat="server" Height="16px" Width="185px" Font-Names="Arial Narrow"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style84">
                                                            <asp:Label ID="Label133" runat="server" Text="Terminado funda" Font-Bold="True" Font-Names="Arial Narrow"></asp:Label>
                                                        </td>
                                                        <td class="auto-style85">
                                                            <asp:RadioButton ID="MATEF" runat="server" GroupName="TerminadoFunda" Text="Mate" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                        </td>
                                                        <td class="auto-style86">
                                                            <asp:RadioButton ID="BRILLANTEF" runat="server" GroupName="TerminadoFunda" Text="Brillante" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                        </td>
                                                        <td class="auto-style70"></td>
                                                    </tr>
                                                     </tr>
                                                    <tr>
                                                        <td class="auto-style84">
                                                            <asp:Label ID="Label6" runat="server" Text="Material tubo " Font-Bold="True" Font-Names="Arial Narrow"></asp:Label>
                                                        </td>
                                                        <td class="auto-style85">
                                                            <asp:RadioButton ID="MONOCAPA" runat="server" GroupName="MaterialTubo" Text="Monocapa" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                        </td>
                                                        <td class="auto-style86">
                                                            <asp:RadioButton ID="BICAPA" runat="server" GroupName="MaterialTubo" Text="Bicapa" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                        </td>
                                                         <td class="auto-style86">
                                                            <asp:RadioButton ID="COEXTRUIDO" runat="server" GroupName="MaterialTubo" Text="Coextruido" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                        </td>
                                                        <td class="auto-style70"></td>
                                                    </tr>
                                </tr>
                                                    <tr>
                                                        <td class="auto-style84">
                                                            <asp:Label ID="Label7" runat="server" Text="Terminado tubo " Font-Bold="True" Font-Names="Arial Narrow"></asp:Label>
                                                        </td>
                                                        <td class="auto-style85">
                                                            <asp:RadioButton ID="MATETU" runat="server" GroupName="TerminadoTubo" Text="Mate" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                        </td>
                                                        <td class="auto-style86">
                                                            <asp:RadioButton ID="BRILLANTETU" runat="server" GroupName="TerminadoTubo" Text="Brillante" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                        </td>
                                                        <td class="auto-style70"></td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style57">
                                                            <asp:Label ID="Label134" runat="server" Text="Tipo de impresion" Font-Bold="True" Font-Names="Arial Narrow"></asp:Label>
                                                        </td>
                                                        <td class="auto-style58">
                                                            <asp:RadioButton ID="ROTOGRABADO" runat="server" GroupName="Impresion" Text="Rotograbado" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                        </td>
                                                        <td class="auto-style59">
                                                            <asp:RadioButton ID="FLEXOGRAFIA" runat="server" GroupName="Impresion" Text="Flexografafia" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                        </td>
                                                        <td class="auto-style59">
                                                            <asp:RadioButton ID="SERIGRAFIA" runat="server" GroupName="Impresion" Text="Serigrafia" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                        </td>
                                                        <td>&nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style57">&nbsp;</td>
                                                        <td class="auto-style58">&nbsp;</td>
                                                        <td class="auto-style59">&nbsp;</td>
                                                        <td aling="right">
                                                            <asp:Button ID="btnGuardar4" runat="server" CssClass="btn-login" Height="41px" OnClick="ActualizaFunda" Text="Guardar" Width="113px" />
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                        </asp:View>
                                        <asp:View ID="View6" runat="server">
                                            <asp:Panel ID="Panel5" runat="server">
                                                <table style="width:90%;" class="table-Cebra">
                                                    <tr>
                                                        <td class="auto-style74">
                                                            <asp:Label ID="Label135" runat="server" Text="Material" Font-Bold="True" Font-Names="Arial Narrow"></asp:Label>
                                                        </td>
                                                        <td class="auto-style75">
                                                            <asp:RadioButton ID="KRAFT" runat="server" GroupName="MatCorru" Text="Kraft" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                        </td>
                                                        <td class="auto-style76">
                                                            <asp:RadioButton ID="MICROCORRUGADO" runat="server" GroupName="MatCorru" Text="Microcorrugado" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                        </td>
                                                        
                                                        <td class="auto-style77">
                                                            <asp:RadioButton ID="BLAN" runat="server" GroupName="MatCorru" Text="Blanco" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                        </td>
                                                        <td class="auto-style77">
                                                            <asp:RadioButton ID="OTROSMATCORRU" runat="server" GroupName="MatCorru" Text="Otros" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                        </td>
                                                        <td class="auto-style76"></td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style92">
                                                            <asp:Label ID="Label136" runat="server" Text="Terminado" Font-Bold="True" Font-Names="Arial Narrow"></asp:Label>
                                                        </td>
                                                        <td class="auto-style93">
                                                            <asp:RadioButton ID="CONIMPRESION" runat="server" GroupName="TermiCorr" Text="Con Impresion" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                        </td>
                                                        <td class="auto-style87">
                                                            <asp:RadioButton ID="SINIMPRESION" runat="server" GroupName="TermiCorr" Text="Sin impresion" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                        </td>
                                                        <td class="auto-style94">
                                                            <asp:RadioButton ID="ETIQUETA" runat="server" GroupName="TermiCorr" Text="Etiqueta" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                        </td>
                                                        <td class="auto-style87"></td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style62">
                                                            <asp:Label ID="Label137" runat="server" Text="Piezas corrugado" Font-Bold="True" Font-Names="Arial Narrow"></asp:Label>
                                                        </td>
                                                        <td class="auto-style65">
                                                            <asp:RadioButton ID="PZAS8" runat="server" GroupName="pzas" Text="8 Piezas" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                        </td>
                                                        <td class="auto-style41">
                                                            <asp:RadioButton ID="PZAS12" runat="server" GroupName="pzas" Text="12 Piezas" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                        </td>
                                                        <td class="auto-style64">
                                                            <asp:RadioButton ID="PZAS24" runat="server" GroupName="pzas" Text="24 Piezas" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                        </td>
                                                        <td class="auto-style41">
                                                            <asp:RadioButton ID="OTROSPZAS" runat="server" GroupName="pzas" Text="Otro" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                            <asp:TextBox ID="txtotrospzas" runat="server" Font-Names="Arial Narrow"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style62">&nbsp;</td>
                                                        <td class="auto-style65">&nbsp;</td>
                                                        <td>&nbsp;</td>
                                                        <td aling="right">
                                                               <asp:Button ID="btnGuardar11" runat="server" CssClass="btn-login" Height="41px" OnClick="ActualizaCorrugado" Text="Guardar" Width="113px" />
                                                        </td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                        </asp:View>
                                        <asp:View ID="View7" runat="server">
                                            <asp:Panel ID="Panel6" runat="server">
                                                <table style="width:90%;" class="table-Cebra">
                                                    
                                                    <tr>
                                                      
                                                        <td class="auto-style7">
                                                            <asp:Label ID="Label138" runat="server" Text="Tipo formula" Font-Names="Arial Narrow" Font-Bold="True"></asp:Label>
                                                        </td>
                                                        <td class="auto-style5">
                                                            <asp:RadioButton ID="CONTRATIPOF" runat="server" GroupName="formula" Text="Contratipo" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                            &nbsp;
                                                            <asp:RadioButton ID="LINEAF" runat="server" GroupName="formula" OnCheckedChanged="GetCheckedRB" Text="Linea" Font-Names="Arial Narrow" />
                                                            &nbsp;
                                                            <asp:RadioButton ID="OTROSLINEAF" runat="server" GroupName="formula" OnCheckedChanged="GetCheckedRB" Text="Otros" Font-Names="Arial Narrow" />
                                                            &nbsp;
                                                            <asp:TextBox ID="txtdescF" runat="server" Font-Names="Arial Narrow"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>                     
                                                    <tr>
                                                        <td class="auto-style7">
                                                            <asp:Label ID="Label139" runat="server" Text="Ingredientes" Font-Names="Arial Narrow" Font-Bold="True"></asp:Label>
                                                        </td>
                                                        <td class="auto-style5">
                                                            <asp:TextBox ID="txtingredientes" runat="server" Width="588px" Font-Names="Arial Narrow"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style7">
                                                            <asp:Label ID="Label140" runat="server" Text="Color" Font-Names="Arial Narrow" Font-Bold="True"></asp:Label>
                                                        </td>
                                                        <td class="auto-style5">
                                                            <asp:RadioButton ID="TRASNPARENTE" runat="server" GroupName="colorf" Text="Transparente" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                            &nbsp;
                                                            <asp:RadioButton ID="AZUL" runat="server" GroupName="colorf" OnCheckedChanged="GetCheckedRB" Text="Azul" Font-Names="Arial Narrow" />
                                                            &nbsp;
                                                            <asp:RadioButton ID="VERDE" runat="server" GroupName="colorf" OnCheckedChanged="GetCheckedRB" Text="Verde" Font-Names="Arial Narrow" />
                                                            &nbsp;<asp:RadioButton ID="chColorF" runat="server" GroupName="colorf" OnCheckedChanged="GetCheckedRB" Text="Otros" Font-Names="Arial Narrow" />
                                                            &nbsp;<asp:TextBox ID="txtOtroColorf" runat="server" Font-Names="Arial Narrow"></asp:TextBox>
                                                        </td>
                                                    </tr>                                        
                                                    <tr>
                                                        <td class="auto-style1021">
                                                            <asp:Label ID="Label141" runat="server" Text="Claims" Font-Names="Arial Narrow" Font-Bold="True"></asp:Label>
                                                        </td>
                                                        <td class="auto-style1022">
                                                            <asp:TextBox ID="txtCLAIMS" runat="server" Width="588px" Font-Names="Arial Narrow"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style1021">
                                                            <asp:Label ID="Label142" runat="server" Text="Fijación: " Font-Names="Arial Narrow" Font-Bold="True"></asp:Label>
                                                        </td>
                                                        <td class="auto-style1022">
                                                            <asp:RadioButton ID="MODELADORA" runat="server" GroupName="terminadosf" Text="Modeladora" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                            &nbsp;
                                                            <asp:RadioButton ID="FIRME" runat="server" GroupName="terminadosf" OnCheckedChanged="GetCheckedRB" Text="Firme" Font-Names="Arial Narrow" />
                                                            &nbsp;
                                                            <asp:RadioButton ID="EXTRAFIRME" runat="server" GroupName="terminadosf" OnCheckedChanged="GetCheckedRB" Text="Extra firme" Font-Names="Arial Narrow" />
                                                            &nbsp;
                                                            <asp:RadioButton ID="ULTRAFIRME" runat="server" GroupName="terminadosf" OnCheckedChanged="GetCheckedRB" Text="Ultra firme" Font-Names="Arial Narrow" />
                                                            &nbsp;
                                                            <asp:RadioButton ID="NA" runat="server" Font-Names="Arial Narrow" GroupName="terminadosf" OnCheckedChanged="GetCheckedRB" Text="N/A" />
                                                        </td>
                                                        <td class="auto-style87">
                                                            </td>
                                                    </tr>  
                                                    <tr>
                                                        <td class="auto-style1021">
                                                            <asp:Label ID="Label2" runat="server" Text="FPS(Factor Protección Solar)" Font-Names="Arial Narrow" Font-Bold="True"></asp:Label>
                                                        </td>
                                                        <td class="auto-style1022">
                                                             <asp:RadioButton ID="RB30" runat="server" GroupName="bloqueadores" Text="30" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                            &nbsp;
                                                            <asp:RadioButton ID="RB50" runat="server" GroupName="bloqueadores" Text="50" OnCheckedChanged="GetCheckedRB" Font-Names="Arial Narrow" />
                                                            &nbsp;
                                                            <asp:RadioButton ID="RBM50" runat="server" GroupName="bloqueadores" OnCheckedChanged="GetCheckedRB" Text="+50" Font-Names="Arial Narrow" />
                                                            &nbsp;
                                                            <asp:RadioButton ID="RBOtros" runat="server" GroupName="bloqueadores" Text="Otros" OnCheckedChanged="RBotros_CheckedChanged"/>
                                                            <asp:RadioButton ID="RBNA" runat="server" GroupName="bloqueadores" OnCheckedChanged="GetCheckedRB" Text="N/A" Font-Names="Arial Narrow" />                                              
                                                            &nbsp;
                                                            <asp:TextBox runat="server" ID="txtotros"></asp:TextBox>
                                              
                                                        </td>
                                                        <td class="auto-style87">
                                                            </td>
                                                    </tr>           
                                                    <tr>
                                                        <td class="auto-style7">
                                                            <asp:Label ID="Label143" runat="server" Text="Apariencia shampoo, Jabón lavatrastes, cera, etc" Font-Names="Arial Narrow" Font-Bold="True"></asp:Label>
                                                        </td>
                                                        <td class="auto-style5">
                                                            <asp:TextBox ID="txtApariencia" runat="server" Width="459px" Font-Names="Arial Narrow"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style7">
                                                            <asp:Label ID="Label144" runat="server" Text="Otros" Font-Names="Arial Narrow" Font-Bold="True"></asp:Label>
                                                        </td>
                                                        <td class="auto-style5">
                                                            <asp:TextBox ID="TXTOTROSFORMF" runat="server" Width="466px" Font-Names="Arial Narrow"></asp:TextBox>
                                                        </td>
                                                        <td>&nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style7">&nbsp;</td>
                                                        <td aling="right">
                                                            <asp:Button ID="btnGuardar9" runat="server" CssClass="btn-login" Height="41px" OnClick="ActualizaFormula" Text="Guardar" Width="113px" />
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                        </asp:View>
                                        <asp:View ID="View8" runat="server">
                                            <table style="width:100%;" class="table-Cebra">
                                                <tr>
                                                    <td></td>
                                                    <td class="auto-style78">
                                                        <asp:Label ID="lblimagen" runat="server" Font-Bold="False" Font-Names="Arial Narrow"></asp:Label>
                                                    </td>
                                                    <td></td>
                                                </tr>
                                                <tr>
                                                    <td></td>
                                                    <td class="auto-style78">
                                                        <asp:Image ID="imgFormula" runat="server" />
                                                    </td>
                                                    <td></td>
                                                </tr>
                                                <tr>
                                                    <td></td>
                                                    <td class="auto-style78">
                                                        <asp:FileUpload ID="fuIImagen" runat="server" Width="172px" />
                                                        <asp:Button ID="btnVisualiza3" runat="server" OnClick="visualizarImagen" Text="Visualizar" Width="69px" />
                                                        &nbsp;
                                                        <asp:Button ID="btnGuardar12" runat="server" CssClass="btn-login" Height="41px" OnClick="ActualizaImagen" Text="Guardar" Width="113px" />
                                                        &nbsp;&nbsp;
                                                        <asp:Button ID="btnGuardar13" runat="server" CssClass="btn-login" Height="41px" OnClick="BorrarImagen" Text="Borrar" Width="113px" />
                                                    </td>
                                                    <td></td>
                                                </tr>
                                            </table>
                                        </asp:View>
                                        <asp:View ID="View11" runat="server">
                                            <table style="width:100%;">
                                                <tr>
                                                    <td class="auto-style115">&nbsp;</td>
                                                    <td align ="center">
                                                        <asp:Label ID="Label150" runat="server" Font-Bold="True" Font-Names="Arial Narrow" Text="Requisitos legales y reglamentarios"></asp:Label>
                                                    </td>
                                                    <td class="auto-style83">
                                                        <asp:TextBox ID="txtlegal" runat="server" Height="61px" Width="579px"></asp:TextBox>
                                                    </td>
                                                    <td>&nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td class="auto-style104">&nbsp;</td>
                                                    <td align ="center" class="auto-style105">
                                                        <asp:Label ID="Label151" runat="server" Font-Bold="True" Font-Names="Arial Narrow" Text="Otros"></asp:Label>
                                                    </td>
                                                    <td class="auto-style106">
                                                        <asp:TextBox ID="txtotrosobs" runat="server" Height="61px" Width="579px"></asp:TextBox>
                                                    </td>
                                                    <td class="auto-style105"></td>
                                                </tr>
                                                <tr>
                                                    <td colspan="3">
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td colspan="3" class="auto-style111">
                                                        <center>
                                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                            <asp:Label runat="server" Font-Bold="True" Font-Names="Arial Narrow" Text="¿El diseño incluye algun requisito legal para la industria cosmetica / alimentaria?"></asp:Label>
                                                        </center>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                        <asp:RadioButton ID="radbtn_si" runat="server" Text="Si" GroupName="decide" OnCheckedChanged="radbtn_si_CheckedChanged" />
                                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                        <asp:RadioButton ID="radbtn_no" runat="server" Text="No" GroupName="decide" OnCheckedChanged="radbtn_no_CheckedChanged" />
                                                        &nbsp;&nbsp;
                                                        <br />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="auto-style104">&nbsp;</td>
                                                    <td align="center" class="auto-style105">
                                                        <asp:Label ID="Label153" runat="server" Font-Bold="True" Font-Names="Arial Narrow" Text="Especifique:"></asp:Label>
                                                    </td>
                                                    <td class="auto-style106">
                                                        <asp:TextBox ID="txtEsp" runat="server" Height="61px" Width="579px"></asp:TextBox>
                                                    </td>
                                                    <td class="auto-style105"></td>
                                                </tr>
                                                <tr>
                                                    <td class="auto-style114">
                                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                                    <td colspan="2">
                                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;</td>
                                                    <td>
                                                        <br />
                                                        <br />
                                                    </td>
                                                  <td align="right">
                                                        <asp:Button ID="btnguardalegal" runat="server" CssClass="btn-login" Height="41px" OnClick="ActualizaLegales" Text="Guardar" Width="113px"/>
                                                    </td>
                                                    <td>&nbsp;</td>
                                                </tr>
                                            </table>
                                        </asp:View>
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
                                                <asp:Label ID="Label147" runat="server" Font-Bold="True" Font-Names="Arial Narrow" Text="VALIDACIÓN"></asp:Label>
                                              </td>
                                             <td align="left" class="auto-style73">
                                                 <asp:Label ID="lblval" runat="server" Font-Bold="False" Font-Names="Arial Narrow"></asp:Label>
                                              </td>
                                             <td  align="left" class="auto-style67">
                                                 <asp:CheckBox ID="chval" runat="server" Enabled="False" />
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
                                                 <asp:Button ID="btn13" runat="server" CssClass="btn-login" Height="36px" OnClick="ActualizaFirmas" Text="Firmar" Width="77px" OnCommand="btn13_Command" />
                                              </td>
                                             <td class="auto-style68">
                                                 &nbsp;</td>
                                             
                                         </tr>
                                          
                                         </table>
                                        </asp:View>
                                        <asp:View ID="View10" runat="server">

                                            <table style="height:600px;">
                                                <tr>
                                                    <td class="auto-style110"></td>
                                                    <td align="center" class="auto-style110">
                                                        <asp:Label ID="Label149" runat="server" Font-Bold="True" Font-Names="Arial Narrow" Text="PROYECTO:"></asp:Label>
                                                        &nbsp;<asp:Label ID="lblProyectoReporte" runat="server" Font-Bold="False" Font-Names="Arial Narrow"></asp:Label>
                                                        <asp:Label ID="lblProyectoReporte1" runat="server" Font-Bold="False" Font-Names="Arial Narrow"></asp:Label>
                                                        &nbsp;&nbsp;
                                                        <asp:Button ID="btn14" runat="server" CssClass="btn-login" Height="36px" OnClick="MuestraReporte" Text="Visualiza reporte" Width="132px" />
                                                    </td>
                                                    <td class="auto-style110"></td>
                                                </tr>
                                                <tr>
                                                    <td class="auto-style109" ></td>
                                                    <td class="auto-style109">
                                                        <asp:ScriptManager ID="ScriptManager1" runat="server">
                                                        </asp:ScriptManager>
                                                      
                                                     <rsweb:ReportViewer ID="ReportViewer1" runat="server"  Height="540px" Width="807px">
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
                                </td>
                                </tr>
                   </table></center>                        
                   </div>
                  </td>
               </tr>
           </table>  
       </div>
    </center>
</asp:Content>
