<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Secretaria/Secretaria.Master" AutoEventWireup="true" CodeBehind="AdministrarCitas.aspx.cs" Inherits="planet.Paginas.Secretaria.Reservaciones.AdministrarCitas" %>

<%@ Register Src="~/Controles/Secretaria/Reservaciones/ControlAdminCitas.ascx" TagPrefix="uc1" TagName="ControlAdminCitas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <uc1:ControlAdminCitas runat="server" ID="ControlAdminCitas" />
</asp:Content>
