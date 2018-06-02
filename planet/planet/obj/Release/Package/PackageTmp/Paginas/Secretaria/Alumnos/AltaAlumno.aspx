<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Secretaria/Secretaria.Master" AutoEventWireup="true" CodeBehind="AltaAlumno.aspx.cs" Inherits="planet.Paginas.Secretaria.Alumnos.AltaAlumno" %>

<%@ Register Src="~/Controles/Secretaria/Alumno/ContAltaAlumno.ascx" TagPrefix="uc1" TagName="ContAltaAlumno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ContAltaAlumno runat="server" id="ContAltaAlumno" />
</asp:Content>
