<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Secretaria/Secretaria.Master" AutoEventWireup="true" CodeBehind="Modificacion.aspx.cs" Inherits="planet.Paginas.Secretaria.Alumnos.Modificacion" %>

<%@ Register Src="~/Controles/Secretaria/Alumno/ContModificarAlumno.ascx" TagPrefix="uc1" TagName="ContModificarAlumno" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ContModificarAlumno runat="server" id="ContModificarAlumno" />

</asp:Content>
