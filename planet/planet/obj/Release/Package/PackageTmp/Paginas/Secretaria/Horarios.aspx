<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Secretaria/Secretaria.Master" AutoEventWireup="true" CodeBehind="Horarios.aspx.cs" Inherits="planet.Paginas.Secretaria.Horarios" %>

<%@ Register Src="~/Controles/Horario.ascx" TagPrefix="uc1" TagName="Horario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:Horario runat="server" id="Horario" />
</asp:Content>
