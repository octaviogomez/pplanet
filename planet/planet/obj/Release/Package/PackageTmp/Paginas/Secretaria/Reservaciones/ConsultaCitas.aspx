<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Secretaria/Secretaria.Master" AutoEventWireup="true" CodeBehind="ConsultaCitas.aspx.cs" Inherits="planet.Paginas.Secretaria.Reservaciones.ConsultaCitas" %>

<%@ Register Src="~/Controles/Secretaria/Reservaciones/ControlConsultaCancelacion.ascx" TagPrefix="uc1" TagName="ControlConsultaCancelacion" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ControlConsultaCancelacion runat="server" ID="ControlConsultaCancelacion" />
</asp:Content>
