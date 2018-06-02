<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AvisoGeneral.ascx.cs" Inherits="planet.Controles.Alumno.AvisoGeneral" %>


<div class="card mb-3">
    <asp:Image ID="ImagenAviso" runat="server" ImageUrl="~/Imagenes/Recursos/aviso.jpg" class="card-img-top" alt="Card image cap" />
    <div class="card-body">
        <h5 class="card-title"><asp:Label ID="LabelDescripcion" runat="server" Text=""></asp:Label></h5>
        <p class="card-text"> <asp:Label ID="LabelDireccion" runat="server" Text=""></asp:Label> </p>
        <p class="card-text"><small class="text-muted">Fecha:<asp:Label ID="LabelFecha" runat="server" Text=""></asp:Label> </small></p>
    </div>

</div>
