<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Secretaria/Secretaria.Master" AutoEventWireup="true" CodeBehind="ConsultaAlumno.aspx.cs" Inherits="planet.Paginas.Secretaria.Alumnos.ConsultaAlumno" %>

<%@ Register Src="~/Controles/Secretaria/Alumno/ContConsultaAlumno.ascx" TagPrefix="uc1" TagName="ContConsultaAlumno" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ContConsultaAlumno runat="server" ID="ContConsultaAlumno" />
</asp:Content>
