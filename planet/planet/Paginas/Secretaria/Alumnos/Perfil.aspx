<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Secretaria/Secretaria.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="planet.Paginas.Secretaria.Alumnos.Perfil" %>

<%@ Register Src="~/Controles/Secretaria/Alumno/ContPerfil.ascx" TagPrefix="uc1" TagName="ContPerfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ContPerfil runat="server" ID="ContPerfil" />
</asp:Content>
