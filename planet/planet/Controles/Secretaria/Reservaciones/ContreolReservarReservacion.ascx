<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ContreolReservarReservacion.ascx.cs" Inherits="planet.Controles.Secretaria.Reservaciones.ContreolReservarReservacion" %>
<div class="container">
    <div class="jumbotron jumbotron-fluid">
        <div class="container">
            <h1 class="display-5">Agendar reservación</h1>
            <p class="lead">En el siguiente apartado podra agendar una reservacion,en la cual más adelante los alumnos podrán verla en su apartado.</p>
        </div>
    </div>

    <div class="card">
        <h5 class="card-header">Nueva reservación</h5>
        <div class="card-body">
            <h5 class="card-title">Instrucciones</h5>
            <p class="card-text">Realice cuidadosamente el llenado.</p>



           

            <asp:Panel ID="Panel2" runat="server">
                <div class="form-row ">
                <div class="col-md-4 mb-3">
                    <label for="TextBoxFecha">Fecha</label>
                    <asp:TextBox ID="TextBoxFecha" runat="server" TextMode="Date" placeholder="Fecha" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-4 mb-3">
                    <label for="ButtonBuscarFecha"></label>
                    <asp:Button ID="ButtonBuscarFecha" runat="server" Text="Buscar" class="btn btn-info btn-lg btn-block " />
                </div>
            </div>
            </asp:Panel>
             <asp:Panel ID="Panel1" runat="server" Height="350px" ScrollBars="Vertical">
                <div class="table-responsive">
                    <asp:GridView ID="GridViewCitas" runat="server" CssClass="table table-striped table-bordered table-hover ">
                    </asp:GridView>
                </div>
            </asp:Panel>
            

            <div class="form-row">

                <div class="col-md-4 mb-3">
                    <label for="DropDownListTipoCita">Horarios</label>
                    <asp:DropDownList ID="DropDownListTipoCita" runat="server" class="form-control" placeholder="Fecha" required="Se necesita una fecha"></asp:DropDownList>
                </div>
                <div class="col-md-4 mb-3">
                    <label for="DropDownListTipoLeccion">Horarios</label>
                    <asp:DropDownList ID="DropDownListTipoLeccion" runat="server" class="form-control" placeholder="Fecha" required="Se necesita una fecha"></asp:DropDownList>
                </div>
                <div class="col-md-4 mb-3">
                    <label for="TextBoxNoProfesores">Número de profesores</label>
                    <asp:TextBox ID="TextBoxNoProfesores" runat="server" class="form-control" placeholder="Número de profesores" required="Solo números" TextMode="Number" min="1"></asp:TextBox>
                </div>
            </div>
            <div class="form-row">
                <div class="col-md-4 mb-3">
                </div>
                <div class="col-md-4 mb-3">
                    <label for="ButtonCrear"></label>
                    <asp:Button ID="ButtonCrear" runat="server" Text="Crear" class="btn btn-success btn-lg btn-block" />
                </div>

            </div>

            <asp:Panel ID="PanelAvisoError" runat="server" Visible="false">
                <div class="alert alert-warning" role="alert">
                    <h4 class="alert-heading">Atención no se guardo la reservación!</h4>
                    <p>Verifique de nuevo sus datos, puede que este mal la fecha o no haya llenado algún campo.</p>
                    <hr>
                    <p class="mb-0">
                        <asp:Label ID="LabelMensajeError" runat="server" Text=""></asp:Label>
                    </p>
                </div>
            </asp:Panel>
            <asp:Panel ID="PanelAvisoCorrecto" runat="server" Visible="false">

                <div class="alert alert-success" role="alert">
                    <h4 class="alert-heading">Well done!</h4>
                    <p>Aww yeah, you successfully read this important alert message. This example text is going to run a bit longer so that you can see how spacing within an alert works with this kind of content.</p>
                    <hr>
                    <p class="mb-0">Whenever you need to, be sure to use margin utilities to keep things nice and tidy.</p>
                </div>

            </asp:Panel>

        </div>
    </div>
</div>


<script>
    $('.alert').alert()
</script>
