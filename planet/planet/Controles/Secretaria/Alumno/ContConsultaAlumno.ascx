<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ContConsultaAlumno.ascx.cs" Inherits="planet.Controles.Secretaria.Alumno.ContConsultaAlumno" %>

<div class="container">
    <div class="jumbotron jumbotron-fluid">
        <div class="container">
            <h1 class="display-5">Consulta de reservaciónes</h1>

        </div>
    </div>





    <div class="card">
        <h5 class="card-header">Consulta de reservaciónes</h5>
        <div class="card-body">
            <h5 class="card-title">Instrucciones</h5>
            <p class="card-text">Realice cuidadosamente el llenado.</p>

            <div class="form-row ">
                <div class="col-md-3 -3">
                </div>

                <div class="col-md-3 mb-3">
                </div>
                <div class="col-md-3 mb-3">
                </div>
                <div class="col-md-3 mb-3">
                </div>
            </div>

            <br />
            <asp:Panel ID="PanelListadoCitas" runat="server" Height="500px" ScrollBars="Vertical" CssClass="border border-primary">
                <div class="table-responsive">
                    <asp:GridView ID="GridViewReservacionCitas" runat="server" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="false" AllowPaging="true" OnRowCommand="GridView_RowCommand">
                        <Columns>
                            <asp:TemplateField ShowHeader="False" HeaderText="IdCita" Visible="false" ControlStyle-CssClass="">
                                <ItemTemplate>
                                    <asp:Label ID="LabelId" Visible="false" runat="server" Text='<%# Eval("Id")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>



                            <asp:TemplateField ShowHeader="False" HeaderText="Inf">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButtonConsultar" runat="server" CommandName="Consultar" CssClass="form-control btn btn-outline-info">
                                        <span class="oi oi-person"></span>
                                    </asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>


                            <asp:BoundField Visible="false" DataField="Id" HeaderText="Id" />
                            <asp:BoundField Visible="true" DataField="Clave" HeaderText="Clave" ItemStyle-ForeColor="Transparent" />
                            <asp:BoundField Visible="true" DataField="Pago" HeaderText="Pago" />
                            <asp:BoundField Visible="true" DataField="Nombre" HeaderText="Nombre" ItemStyle-Font-Bold="true" />
                            <asp:BoundField Visible="true" DataField="Apellidos" HeaderText="Apellidos" />
                            <asp:BoundField Visible="true" DataField="Correo" HeaderText="Correo" />
                            <asp:BoundField Visible="true" DataField="Celular" HeaderText="Celular" />
                            <asp:BoundField Visible="true" DataField="Nivel" HeaderText="Nivel" />
                            <asp:BoundField Visible="true" DataField="Ingreso" HeaderText="Ingreso" />




                            <asp:TemplateField ShowHeader="False" HeaderText="Modif">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButtonModificar" runat="server" CommandName="Consultar" CssClass="form-control btn btn-outline-warning">
                                        <span class="oi oi-wrench"></span>
                                    </asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField ShowHeader="False" HeaderText="Baja">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButtonEliminar" runat="server" CommandName="Baja" CssClass="form-control btn btn-outline-danger">
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

<!-- Modal -->
<div class="modal fade" id="ModalEliminar" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
    <div class="modal-dialog" role="document">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLabel">Eliminar reservación</h5>
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true">&times;</span>
                </button>
            </div>
            <div class="modal-body">
                Esta seguro que desea dar de baja : <strong>
                    <asp:Label ID="LabelNombreAlumno" runat="server" Text=" "></asp:Label></strong>

            </div>
            <div class="modal-footer">
                <asp:TextBox ID="TextBoxPkAlumno" runat="server" Visible="false" Enabled="false"></asp:TextBox>
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                <asp:Button ID="ButtonBajaAlumno" runat="server" Text="Baja " CssClass="btn btn-danger" OnClick="ButtonBajaAlumno_Click" />
            </div>
        </div>
    </div>
</div>



