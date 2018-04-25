<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Alumno/alumno.Master" AutoEventWireup="true" CodeBehind="Agendar.aspx.cs" Inherits="planet.Paginas.Alumno.Reservaciones.Agendar" %>

<%@ Register Src="~/Controles/Alumno/Rerservaciones/ControlReservacion.ascx" TagPrefix="uc1" TagName="ControlReservacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
    <uc1:ControlReservacion runat="server" id="ControlReservacion" />
</asp:Content>
