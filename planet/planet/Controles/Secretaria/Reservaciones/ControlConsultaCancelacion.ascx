<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ControlConsultaCancelacion.ascx.cs" Inherits="planet.Controles.Secretaria.Reservaciones.ControlConsultaCancelacion" %>
<div class="container">
    <div class="jumbotron jumbotron-fluid">
        <div class="container">
            <h1 class="display-5">Consulta de reservaciónes</h1>
            <p class="lead">En el siguiente apartado podra ver las reservacion que tienen asiganda los alumnos</p>
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
        <h5 class="card-header">Consulta de reservaciónes</h5>
        <div class="card-body">
            <h5 class="card-title">Instrucciones</h5>
            <p class="card-text">Realice cuidadosamente el llenado.</p>

            <div class="form-row ">
                <div class="col-md-4 mb-3">
                    <label for="TextBoxFecha">Fecha</label>
                    <asp:TextBox ID="TextBoxFecha" runat="server" TextMode="Date" placeholder="Fecha" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="col-md-4 mb-3">
                    <label for="DropDownListHorarios">Horarios</label>
                    <asp:DropDownList ID="DropDownListHorarios" runat="server" class="form-control" placeholder="Horario" required="Se necesita un horario" AutoPostBack="true" OnSelectedIndexChanged="DropDownListHorarios_SelectedIndexChanged"></asp:DropDownList>
                </div>
                <div class="col-md-4 mb-3">
                    <label for="ButtonBuscarFecha"></label>
                    <asp:Button ID="ButtonBuscarFecha" runat="server" Text="Buscar" class="btn btn-info btn-lg btn-block "  OnClick="ButtonBuscarFecha_Click"/>
                </div>
            </div>

            <br />
            <asp:Panel ID="PanelListadoCitas" runat="server" Height="700px" ScrollBars="Vertical" CssClass="border border-primary">
                <div class="table-responsive">
                    <asp:GridView ID="GridViewReservacionCitas" runat="server" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="false" OnRowCommand="GridView_RowCommand">
                        <Columns>
                            <asp:TemplateField ShowHeader="False" HeaderText="IdCita" Visible="false" ControlStyle-CssClass="">
                                <ItemTemplate>
                                    <asp:Label ID="LabelId" Visible="false" runat="server" Text='<%# Eval("Id")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField ShowHeader="False" HeaderText="Cancelación">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButtonCancelar" runat="server" CommandName="Cancelar" CssClass="form-control btn btn-outline-danger" OnClick="LinkButtonCancelar_Click">
                                         <span class="oi oi-ban"></span>
                                    </asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField ShowHeader="False" HeaderText="Falta">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButtonFalta" runat="server" CommandName="Falta" CssClass="form-control btn btn-outline-warning" OnClick="LinkButtonFalta_Click" >
                                        <span class="oi oi-bell"></span>
                                    </asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ShowHeader="False" HeaderText="Retardo">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButtonRetardo" runat="server" CommandName="Retardo" CssClass="form-control btn btn-outline-info" OnClick="LinkButtonRetardo_Click">
                                        <span class="oi oi-clock"></span>
                                    </asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:BoundField Visible="false" DataField="pk_alumno" HeaderText="pk_alumno" />
                       
                            <asp:BoundField Visible="true" DataField="Nombre" HeaderText="Nombre" ItemStyle-Font-Bold="true"/>
                            <asp:BoundField Visible="true" DataField="Nivel" HeaderText="Nivel" />
                            <asp:BoundField Visible="true" DataField="Lecciones" HeaderText="Lecciones" />
                            <asp:BoundField Visible="true" DataField="Tipo" HeaderText="Tipo" />
                            <asp:BoundField Visible="true" DataField="Hora" HeaderText="Hora" />
                            <asp:BoundField Visible="true" DataField="Fecha" HeaderText="Fecha" />
                            <asp:BoundField Visible="true" DataField="Estado" HeaderText="Estado" ItemStyle-ForeColor="#00cc00" />
                            <asp:TemplateField ShowHeader="False" HeaderText="Eliminar">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButtonEliminar" runat="server" CommandName="Eliminar" CssClass="form-control btn btn-outline-secondary" OnClick="LinkButtonEliminar_Click">
                                        <span class="oi oi-trash"></span>
                                    </asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>


                        </Columns>
                    </asp:GridView>
                </div>
            </asp:Panel>




            <br />


        </div>
    </div>
</div>
<br />

