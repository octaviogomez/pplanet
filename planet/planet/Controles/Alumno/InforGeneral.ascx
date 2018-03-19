<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="InforGeneral.ascx.cs" Inherits="planet.Controles.Alumno.InforGeneral" %>


<div class="card  border-info mb-3">
    <%-- <img class="card-img-top" src="../Imagenes/Recursos/aviso.jpg" alt="Card image cap">--%>
    <div class="card-header"><strong>Información general</strong></div>
    <div class="card-body text-info">
        <h5 class="card-title ">Alumno</h5>
        <p class="card-text">Nombre:<strong><asp:Label ID="LabelNombre" runat="server" Text="Label"></asp:Label></strong></p>
        <p class="card-text">Pelis:<strong><asp:Label ID="LabelPeliculas" runat="server" Text="Label"></asp:Label></strong></p>
        <p class="card-text">Clubs:<strong><asp:Label ID="LabelClubs" runat="server" Text="Label"></asp:Label></strong></p>
    </div>
    <div class="card-footer">
        <small class="text-muted">Nivel: <asp:Label ID="LabelNivel" runat="server" Text="Label"></asp:Label></small>
    </div>
</div>
