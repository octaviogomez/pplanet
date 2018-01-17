<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Secretaria/Secretaria.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="planet.Paginas.Secretaria.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
        <div class="card mb-3">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/Recursos/aviso.jpg" class="card-img-top" alt="Card image cap" />

            <div class="card-body">
                <h5 class="card-title">Fechas de clubs nuevas</h5>
                <p class="card-text">Para mas informacion preguntar en el área de información</p>
                <p class="card-text"><small class="text-muted">lunes 5 de febrero</small></p>
            </div>
        </div>
        <div class="card-deck">
            <div class="card  border-info mb-3">
                <%-- <img class="card-img-top" src="../Imagenes/Recursos/aviso.jpg" alt="Card image cap">--%>
                <div class="card-header"> <strong>Información general</strong></div>
                <div class="card-body text-info">
                    <h5 class="card-title ">Alumno</h5>
                    <p class="card-text">Nombre:<strong>Juan Manolo</strong></p>
                    <p class="card-text">Pelis:<strong>8</strong></p>
                    <p class="card-text">Clubs:<strong>20</strong></p>
                </div>
                <div class="card-footer">
                    <small class="text-muted">Nivel 1</small>
                </div>
            </div>
            <div class="card  border-success mb-3">
                <%-- <img class="card-img-top" src="..." alt="Card image cap">--%>
                <div class="card-header"><strong> Reservaciones</strong></div>
                <div class="card-body text-success">
                    <h5 class="card-title">Próximas</h5>
                    <p class="card-text"> <strong> 12 Enero,12:00 am</strong> <small class="">Película</small></p>
                    <p class="card-text"> <strong> 13 Enero,15:00 pm</strong> <small class="">Reservación</small></p>
                </div>
                <div class="card-footer">
                    <small class="text-muted">Ver horarios</small>
                </div>
            </div>
            <div class="card  border-danger mb-3">
             <%--   <img class="card-img-top" src="..." alt="Card image cap">--%>
                <div class="card-header"><strong>Avisos</strong></div>
                <div class="card-body text-danger">
                    <h5 class="card-title">Importante</h5>
                    <p class="card-text">Cancelaciones:<strong>1</strong></p>
                </div>
                <div class="card-footer">
                    <small class="text-muted">Ver Secretaria</small>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
