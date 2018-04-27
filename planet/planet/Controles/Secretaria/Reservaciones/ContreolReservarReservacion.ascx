<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ContreolReservarReservacion.ascx.cs" Inherits="planet.Controles.Secretaria.Reservaciones.ContreolReservarReservacion" %>
<!-- Modal -->






<div class="container">
    <div class="jumbotron jumbotron-fluid">
        <div class="container">
            <h1 class="display-5">Agendar reservación</h1>
            <p class="lead">En el siguiente apartado podra agendar una reservacion,en la cual más adelante los alumnos podrán verla en su apartado.</p>
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
            <h4 class="alert-heading">Registro exitoso!</h4>
            <p>Se realizó de manera correcta la reservación.</p>
            <hr>
        </div>
    </asp:Panel>

    <div class="card">
        <h5 class="card-header">Agendar reservación</h5>
        <div class="card-body">
            <h5 class="card-title">Instrucciones</h5>
            <p class="card-text">Realice cuidadosamente el llenado.</p>

            <div class="form-row ">
                <div class="col-md-4 mb-3">
                    <label for="TextBoxFecha">Fecha</label>
                    <asp:TextBox ID="TextBoxFecha" runat="server" TextMode="Date" placeholder="Fecha" CssClass="form-control" OnTextChanged="TextBoxFecha_TextChanged" AutoPostBack="true"></asp:TextBox>
                </div>
                 <div class="col-md-4 mb-3">
                       <label for="DropDownListHorarios">Horarios</label>
                    <asp:DropDownList ID="DropDownListHorarios" runat="server" class="form-control" placeholder="Horario" required="Se necesita un horario"></asp:DropDownList>
                 </div>
                <div class="col-md-4 mb-3">
                    <label for="ButtonBuscarFecha"></label>
                    <asp:Button ID="ButtonBuscarFecha" runat="server" Text="Buscar" class="btn btn-info btn-lg btn-block " OnClick="ButtonBuscarFecha_Click" />
                </div>
            </div>

            <br />
            <asp:Panel ID="PanelListadoCitas" runat="server" Height="350px" ScrollBars="Vertical" CssClass="border border-primary">
                <div class="table-responsive">
                    <asp:GridView ID="GridViewCitas" runat="server" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="false" OnRowCommand="GridView_RowCommand">
                        <Columns>
                            <asp:TemplateField ShowHeader="False" HeaderText="IdCita" Visible="false" ControlStyle-CssClass="">
                                <ItemTemplate>
                                    <asp:Label ID="LabelId" Visible="false" runat="server" Text='<%# Eval("Id")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ShowHeader="False" HeaderText="Selecionar">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButtonSeleccionar" runat="server" CommandName="seleccion" CssClass="btn btn-outline-info   btn-lg btn-block">
                                       <span class="oi oi-check"></span>
                                    </asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>


                            <asp:BoundField Visible="true" DataField="Estado" HeaderText="Estado"  />
                            <asp:BoundField Visible="true" DataField="Fecha" HeaderText="Fecha" />
                            <asp:BoundField Visible="true" DataField="Horario" HeaderText="Horario" />
                            <asp:BoundField Visible="true" DataField="No. Profes" HeaderText="No. Profes" />
                            <asp:BoundField Visible="true" DataField="Indice" HeaderText="Indice" />
                            <asp:BoundField Visible="true" DataField="Espacios" HeaderText="Espacios" />
                            <asp:BoundField Visible="true" DataField="No. Alumnos" HeaderText="No. Alumnos" />
                          
                    
                        </Columns>
                    </asp:GridView>
                </div>
            </asp:Panel>




            <br />
            <div class="form-row">


            
                    <asp:TextBox ID="TextBoxIdCita" runat="server" CssClass="form-control" placeholder="Id cita" ValidationGroup="AceptarRegistro" Enabled="false" required="Se necesita una cita" Visible="false"></asp:TextBox>

           


                <div class="col-md-4 mb-3">
                    <label for="TextBoxNoProfesores">Alumno</label>
                    <asp:TextBox ID="TextBoxIdAlumno" runat="server" class="form-control" placeholder="Credencial de alumno" ValidationGroup="AceptarRegistro" TextMode="Number" required="Se necesita matricula" title="Ingrese una matrícula de alumno"></asp:TextBox>

                    <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Sólo números" ValidationGroup="AceptarRegistro" ControlToValidate="TextBoxIdAlumno" CssClass="alert alert-danger form-control" role="alter"></asp:RequiredFieldValidator>--%>
                </div>

                <div class="col-md-4 mb-3">
                    <label for="DropDownListTipoCita">Tipo de cita</label>
                    <asp:DropDownList ID="DropDownListTipoCita" runat="server" class="form-control" placeholder="Fecha" ValidationGroup="AceptarRegistro"></asp:DropDownList>
                </div>
                 <div class="col-md-4 mb-3">
                    <label for="DropDownListTipoLeccion">Lección</label>
                    <asp:DropDownList ID="DropDownListTipoLeccion" runat="server" class="form-control" placeholder="Fecha" ValidationGroup="AceptarRegistro"></asp:DropDownList>
                </div>
                <div class="col-md-4 mb-3">
                </div>
                <div class="col-md-3 mb-2">
                    <label for="ButtonCrear"></label>
                    <asp:Button ID="ButtonCrear" runat="server" Text="Registrar" class="btn btn-success btn-lg btn-block" ValidationGroup="AceptarRegistro" OnClick="ButtonCrear_Click" />
                </div>
            </div>

        </div>
    </div>
</div>
<br />

<!-- Modal  de advertencia-->
<div class="modal fade" id="ModalAlumnoFaltas" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
    <div class="modal-dialog" role="document">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLabel">Advertencia</h5>

            </div>
            <div class="modal-body">
                Este alumno tiene más de 6 puntos de inasistencia.
            </div>
            <div class="modal-footer">

                <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                <asp:Button ID="ButtonRegistrarAlumoFalta" runat="server" Text="Registrar " CssClass="btn btn-warning" OnClick="ButtonRegistrarAlumoFalta_Click" />
            </div>
        </div>
    </div>
</div>

<!-- Modal de notificacion-->
<div class="modal fade" id="Notificacion" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
    <div class="modal-dialog" role="document">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="examttlte">Modal title</h5>
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true">&times;</span>
                </button>
            </div>
            <div class="modal-body">
                Registro exitoso
            </div>
            <div class="modal-footer">
                <asp:Button ID="ButtonActualizarPagina" runat="server" Text="Ok!" CssClass="btn btn-success" OnClick="ButtonActualizarPagina_Click"/>
         
            </div>
        </div>
    </div>
</div>

<!-- Modal de notificacion de algun error-->
<div class="modal fade" id="NotificacionError" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
    <div class="modal-dialog" role="document">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" ></h5>
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true">&times;</span>
                </button>
            </div>
            <div class="modal-body alert alert-warning">
                Revise los datos!
            </div>
        </div>
    </div>
</div>