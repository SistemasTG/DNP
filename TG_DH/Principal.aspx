<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="TG_DNP.Principal" %>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <!DOCTYPE html>
<html>
<head>
<meta charset="utf-8">
    <link rel="stylesheet" href="Css/estilos.css"/>
<link href="Content/bootstrap-grid.min.css" rel="stylesheet" />
<script src="scripts/jquery-1.5.2.min.js"></script>
<script src="scripts/bootstrap.min.js"></script>
<script src="js/jquery-1.6.3.min.js"></script>
<script src="js/cufon-yui.js"></script>
<script src="js/cufon-replace.js"></script>
<script src="js/NewsGoth_BT_400.font.js"></script>
<script src="js/FF-cash.js"></script>
<script src="js/script.js"></script>
<script src="js/jquery.equalheights.js"></script>
<script src="js/jquery.easing.1.3.js"></script>
<script src="js/tms-0.3.js"></script>
<script src="js/tms_presets.js"></script>
<script src="js/easyTooltip.js"></script>
<!--[if lt IE 9]>
<script src="js/html5.js"></script>
<link rel="stylesheet" href="css/ie.css" type="text/css" media="screen">
<![endif]-->
</head>
<body>
<div class="extra">
  <div class="main">
    <!--==============================header=================================-->
    <header class="auto-style7">
     
          <img alt="LOG" class="auto-style5" src="imagenes/por1.jpg"  />
    </header>
  </div>
</div>
<!--==============================footer=================================-->
<script>Cufon.now();</script>
<script>
$(window).load(function () {
    $('.slider')._TMS({
        duration: 800,
        easing: 'easeOutQuart',
        preset: 'simpleFade',
        slideshow: 7000,
        banners: false,
        pauseOnHover: true,
        waitBannerAnimation: false,
        prevBu: '.prev',
        nextBu: '.next'
    });
});
</script>
</body>
</html>
</asp:Content>
<asp:Content ID="Content4" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style5 {
            width: 1013px;
            height: 390px;
        }
        .auto-style7 {
            left: 0px;
            top: 2px;
            width: 100%;
            height: 396px;
        }
    </style>
</asp:Content>

