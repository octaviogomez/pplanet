<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sesion.aspx.cs" Inherits="planet.Sesion" %>

<%@ Register Src="~/Controles/Sesion/login.ascx" TagPrefix="uc1" TagName="login" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title>Inicio de sesion</title>
</head>



<body>
    <form id="form1" runat="server">
        <uc1:login runat="server" id="login" />
    </form>
    <script src="Scripts/jquery-3.2.1.min.js"></script>
    <script src="Scripts/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q"></script>
    <script src="Scripts/bootstrap.min.js"></script>


</body>
</html>




