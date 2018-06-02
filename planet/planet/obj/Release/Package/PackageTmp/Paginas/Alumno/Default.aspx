<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Alumno/alumno.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="planet.Paginas.Alumno.Default" %>

<%@ Register Src="~/Controles/Alumno/AvisoGeneral.ascx" TagPrefix="uc1" TagName="AvisoGeneral" %>
<%@ Register Src="~/Controles/Alumno/InforGeneral.ascx" TagPrefix="uc1" TagName="InforGeneral" %>
<%@ Register Src="~/Controles/Alumno/InforReservaciones.ascx" TagPrefix="uc1" TagName="InforReservaciones" %>
<%@ Register Src="~/Controles/Alumno/InforAvisos.ascx" TagPrefix="uc1" TagName="InforAvisos" %>





<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <uc1:AvisoGeneral runat="server" ID="AvisoGeneral" />
        <div class="card-deck">
            <uc1:InforGeneral runat="server" id="InforGeneral" />
            <uc1:InforReservaciones runat="server" id="InforReservaciones" />
            <uc1:InforAvisos runat="server" id="InforAvisos" />
        </div>
    </div>
</asp:Content>
