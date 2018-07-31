<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ControlCrearCita.ascx.cs" Inherits="planet.Controles.Secretaria.Reservaciones.ControlCrearCita" %>


<div class="container">
    <div class="card">
        <h5 class="card-header"><span class="oi oi-calendar"></span>Creación de reservación</h5>
        <div class="card-body">
            <div id="headingOne" class="linkAyuda" data-toggle="collapse" data-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
                <h5 class="card-title"><span class="oi oi-info"></span>Instrucciones</h5>
            </div>
            <div id="collapseOne" class="collapse" aria-labelledby="headingOne" data-parent="#accordion">
                <div class="card-body">
                    <div class="alert-info">
                        <p>En el siguiente apartado podra generar una reservación,la cual más adelante los alumnos podrán agendarla.</p>
                    </div>
                    <ol>
                        <li>Poner una fecha.</li>
                        <li>Selecionar un horario.</li>
                        <li>Agregar un número de <strong>Profesores</strong></li>
                    </ol>
                    <br />
                    <div class="alert-warning">
                        <strong>Nota:</strong> Los horarios se pueden repetir en la fecha agendada.
                        <br />
                        <p class="card-text">Realice cuidadosamente el llenado.</p>
                    </div>
                </div>
            </div>
            <div class="form-row">
                <div class="col-md-4 mb-3">
                    <strong>
                        <label for="TextBoxFecha">Fecha</label></strong>
                    <asp:TextBox ID="TextBoxFecha" runat="server" TextMode="Date" placeholder="Fecha" required="Se necesita una fecha" CssClass="form-control" requiered="" AutoPostBack="True" OnTextChanged="TextBoxFecha_TextChanged"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="vTextBoxFecha" runat="server" ControlToValidate="TextBoxFecha" ValidationGroup="atla" ErrorMessage="Requerido" CssClass=" alert-warning " />
                </div>
                <div class="col-md-4 mb-3">
                    <strong>
                        <label for="DropDownListHorarios">Horarios</label></strong>
                    <asp:DropDownList ID="DropDownListHorarios" runat="server" class="form-control" placeholder="Fecha" required="Se necesita una fecha"></asp:DropDownList>
                  <asp:RequiredFieldValidator ID="vDropDownListHorarios" runat="server" ControlToValidate="DropDownListHorarios" ValidationGroup="atla" ErrorMessage="Requerido" CssClass=" alert-warning " />
      
                      </div>
                <div class="col-md-4 mb-3">
                    <strong>
                        <label for="TextBoxNoProfesores">Número de profesores</label></strong>
                    <asp:TextBox ID="TextBoxNoProfesores" runat="server" class="form-control" placeholder="Número de profesores" required="Solo números" TextMode="Number" min="1"></asp:TextBox>
                
                     <asp:RequiredFieldValidator ID="vTextBoxNoProfesores" runat="server" ControlToValidate="TextBoxNoProfesores" ValidationGroup="atla" ErrorMessage="Requerido" CssClass=" alert-warning " />
      
                </div>
            </div>
            <div class="form-row">
                <div class="col-md-4 mb-3">
                </div>
                <div class="col-md-4 mb-3">
                    <label for="ButtonCrear"></label>

                    <asp:LinkButton ID="ButtonCrear" runat="server" class="btn btn-success btn-lg btn-block" ValidationGroup="alta" OnClick="ButtonCrear_Click"><span class="oi oi-check"></span> Crear</asp:LinkButton>

                </div>
                <div class="col-md-4 mb-3">
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
                    <h4 class="alert-heading">    <asp:Label ID="LabelMensaje" runat="server" Text=""></asp:Label></h4>
                  
                </div>

            </asp:Panel>

        </div>
    </div>
</div>


<script>

</script>
