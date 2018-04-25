<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Alumno/alumno.Master" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="planet.Paginas.Alumno.Reservaciones.Consulta" %>

<%@ Register Src="~/Controles/Alumno/Rerservaciones/ControlListarCancelar.ascx" TagPrefix="uc1" TagName="ControlListarCancelar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ControlListarCancelar runat="server" id="ControlListarCancelar" />
</asp:Content>
