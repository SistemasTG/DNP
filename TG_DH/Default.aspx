<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DNP.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="Css/styleLogin.css" />
    <link rel="stylesheet" type="text/css" href="Css/styleFont.css" />
    <link rel="stylesheet" type="text/css" href="Css/font-awesome.css" />
</head>
<body>
    <div class="container">
        <img src="./images/dnpLogin.png" style="height: 147px; width: 146px"/>
    <form id="form1" runat="server">
    <div class="form-input">
        <asp:TextBox ID="txtUser" runat="server" placeholder="USUARIO" style="text-transform:uppercase;" CssClass="txtUser" Font-Bold="False" Font-Italic="False" ForeColor="#666666"></asp:TextBox>    
    <div class="form-input">    
        <asp:TextBox ID="txtpass" placeholder="CONTRASEÑA" runat="server" TextMode="Password" ForeColor="#666666"></asp:TextBox>
    </div>    
    </div>
        <asp:Button ID="btnEntrar" runat="server" CssClass="btn-login" Text="Entrar" Height="30px" Width="223px" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="lblmensaje" runat="server" Font-Names="Arial" Font-Size="Small" ForeColor="Red"></asp:Label>
        
    </form>
    </div>
</body>
</html>
