<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Secretaria/Secretaria.Master" AutoEventWireup="true" CodeBehind="AgendarReservacion.aspx.cs" Inherits="planet.Paginas.Secretaria.Reservaciones.AgendarReservacion" %>

<%@ Register Src="~/Controles/Secretaria/Reservaciones/ContreolReservarReservacion.ascx" TagPrefix="uc1" TagName="ContreolReservarReservacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <uc1:ContreolReservarReservacion runat="server" id="ContreolReservarReservacion" />
</asp:Content>
