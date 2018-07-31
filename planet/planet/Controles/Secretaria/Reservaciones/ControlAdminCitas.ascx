<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ControlAdminCitas.ascx.cs" Inherits="planet.Controles.Secretaria.Reservaciones.ControlAdminCitas" %>

<div class="container">


    <div class="card">
        <h5 class="card-header"><span class="oi oi-folder"></span>Administración de reservaciones</h5>
        <div class="card-body">



            <div id="headingOne" class="linkAyuda" data-toggle="collapse" data-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
                <h5 class="card-title"><span class="oi oi-info"></span>Instrucciones</h5>
            </div>
            <div id="collapseOne" class="collapse" aria-labelledby="headingOne" data-parent="#accordion">
                <div class="card-body">
                    <div class="alert-info">
                        <p class="lead">En el siguiente apartado podra configurar las  reservacion,en la cual más adelante los alumnos podrán agendarla.</p>
                    </div>
                    <ul>
                        <li>Para eliminar una reservación, localize una reservación y de click en <strong><span class="oi oi-trash"></span></strong>para eliminarla.</li>
                    </ul>
                    <br />
                    <div class="alert-warning">
                        <strong>Nota:</strong> Al eliminar una reservación, se eliminaran todas las reservacion agendadas
                    </div>
                </div>
            </div>


            <div class="form-row">
                <div class="col-12 col-md-5">
                    <strong>
                        <label for="TextBoxFecha">Fecha</label></strong>
                    <asp:TextBox ID="TextBoxFecha" runat="server" TextMode="Date" placeholder="Fecha" CssClass="form-control" OnTextChanged="TextBoxFecha_TextChanged" AutoPostBack="true"></asp:TextBox>
                </div>
                <div class="col-md-2">
                </div>
                <div class="col-12 col-md-5">
                    <label for="ButtonCrear"></label>
                    <asp:LinkButton ID="ButtonCrear" runat="server"  class="btn btn-success btn-lg btn-block" OnClick="ButtonCrear_Click" ><span class="oi oi-magnifying-glass"></span> Buscar</asp:LinkButton>
                </div>
            </div>
            <br />
            <div class="table-responsive border border-primary">
                <asp:GridView ID="GridViewCitas" runat="server" OnRowCommand="GridView_RowCommand" CssClass="table table-striped table-bordered table-hover " AutoGenerateColumns="false">
                    <Columns>

                        <asp:TemplateField ShowHeader="False" HeaderText="IdCita" Visible="false" ControlStyle-CssClass="">
                            <ItemTemplate>
                                <asp:Label ID="LabelId" Visible="false" runat="server" Text='<%# Eval("Id")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField ShowHeader="False" HeaderText="Eliminar">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButtonEliminar" runat="server" CommandName="Eliminar" CssClass="form-control btn btn-outline-danger">
                                    <span class="oi oi-trash"></span>
                                </asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:BoundField Visible="true" DataField="Estado" HeaderText="Estado" />
                        <asp:BoundField Visible="true" DataField="Fecha" HeaderText="Fecha" />
                        <asp:BoundField Visible="true" DataField="Horario" HeaderText="Horario" />
                        <asp:BoundField Visible="true" DataField="Cupo" HeaderText="Cupo" ControlStyle-CssClass="" />
                        <asp:BoundField Visible="true" DataField="NoProfes" HeaderText="NoProfes" ControlStyle-CssClass="" />
                    </Columns>

                </asp:GridView>
            </div>
            <br />
            <asp:Panel ID="PanelAvisoError" runat="server" Visible="false">
                <div class="alert alert-warning" role="alert">
                    <h4 class="alert-heading">Atención no se listo correctamente</h4>
                    <p>Verifique de nuevo sus datos, puede que este mal la fecha o no haya llenado algún campo.</p>
                    <hr>
                    <p class="mb-0">
                        <asp:Label ID="LabelMensajeError" runat="server" Text=""></asp:Label>
                    </p>
                </div>
            </asp:Panel>
            <asp:Panel ID="PanelAvisoCorrecto" runat="server" Visible="false">

                <div class="alert alert-success" role="alert">
                    <h4 class="alert-heading">Listado correcto!</h4>
                    <p>Estas son los horarios que tiene respecto a los datos ingresados</p>
                    <hr>
                    <p class="mb-0">Puede ver de manera general los que hay solo actulizando la pagina.</p>
                </div>
            </asp:Panel>
        </div>
    </div>
</div>



<!-- Modal -->
<div class="modal fade" id="ModalModificarFormapago" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
    <div class="modal-dialog" role="document">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLabel">Eliminar reservación</h5>
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true">&times;</span>
                </button>
            </div>
            <div class="modal-body">
                Al eliminar la cita, todas las reservaciones agendadas seran eliminadas
            </div>
            <div class="modal-footer">
                <asp:TextBox ID="TextBoxPkCita" runat="server" Visible="false" Enabled="false"></asp:TextBox>
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                <asp:Button ID="Button1" runat="server" Text="Eliminar " CssClass="btn btn-danger" OnClick="Button1_Click" />
            </div>
        </div>
    </div>
</div>

