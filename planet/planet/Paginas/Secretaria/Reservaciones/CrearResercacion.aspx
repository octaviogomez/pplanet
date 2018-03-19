<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Secretaria/Secretaria.Master" AutoEventWireup="true" CodeBehind="CrearResercacion.aspx.cs" Inherits="planet.Paginas.Alumno.Reservaciones.CrearResercacion" %>

<%@ Register Src="~/Controles/Secretaria/Reservaciones/ControlCrearCita.ascx" TagPrefix="uc1" TagName="ControlCrearCita" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ControlCrearCita runat="server" id="ControlCrearCita" />
</asp:Content>
