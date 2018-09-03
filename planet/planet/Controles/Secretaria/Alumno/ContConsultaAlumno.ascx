<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ContConsultaAlumno.ascx.cs" Inherits="planet.Controles.Secretaria.Alumno.ContConsultaAlumno" %>

<div class="container">

    <div class="card">
        <h5 class="card-header"><span class="oi oi-people"></span>   Consulta de alumno</h5>
        <div class="card-body">

            <div id="headingOne" class="linkAyuda" data-toggle="collapse" data-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
                <h5 class="card-title"><span class="oi oi-info"></span>   Instrucciones</h5>
            </div>
            <div id="collapseOne" class="collapse" aria-labelledby="headingOne" data-parent="#accordion">
                <div class="card-body">
                    <div class="alert-info">
                        <p class="lead">En el siguiente apartado podra visualizar de los alumno <strong>Activos</strong>.</p>
                    </div>
                    <ul>
                        <li>Para <strong>consultar</strong> infromación especifíca del usuario de click en  <strong><span class="oi oi-person"></span></strong></li>
                        <li>Para <strong>agregar o modificar</strong> infromación del usuario de click en  <strong><span class="oi oi-wrench"></span></strong></li>
                        <li>Para dar de <strong>baja</strong> a un usuario de click en  <strong><span class="oi oi-trash"></span></strong></li>


                    </ul>
                    <br />
                    <div class="alert-warning">
                        <strong>Nota:</strong>
                        En el campo de <strong>id</strong> podria agregar una matrícula propia del plantel.
                    </div>
                </div>
            </div>

            <div class="form-row ">
                <div class="col-md-3 -3">
                </div>
                <input id="buscar" type="text" class="form-control" placeholder="Escriba algo para filtrar" />
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

                            <asp:BoundField Visible="true" DataField="Credencial" HeaderText="Id" />
                            <asp:BoundField Visible="true" DataField="Pago" HeaderText="Pago" />
                            <asp:BoundField Visible="true" DataField="Nombre" HeaderText="Nombre" ItemStyle-Font-Bold="true" />
                            <asp:BoundField Visible="true" DataField="Apellidos" HeaderText="Apellidos" />
                            <asp:BoundField Visible="true" DataField="Correo" HeaderText="Correo" />
                            <asp:BoundField Visible="true" DataField="Celular" HeaderText="Celular" />
                            <asp:BoundField Visible="true" DataField="Nivel" HeaderText="Nivel" />
                            <asp:BoundField Visible="true" DataField="Ingreso" HeaderText="Ingreso" />




                            <asp:TemplateField ShowHeader="False" HeaderText="Modif">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButtonModificar" runat="server" CommandName="Modificar" CssClass="form-control btn btn-outline-warning">
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
                <h5 class="modal-title" id="exampleModalLabel">Baja de usuario</h5>
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true">&times;</span>
                </button>
            </div>
            <div class="modal-body">
                Esta seguro que desea dar de baja a : <strong>
                    <asp:Label ID="LabelNombreAlumno" runat="server" Text=" "></asp:Label></strong>

            </div>
            <div class="modal-footer">
                <asp:TextBox ID="TextBoxPkAlumno" runat="server" Visible="false" Enabled="false"></asp:TextBox>
                <button type="button" class="btn btn-secondary" data-dismiss="modal"><span class="oi oi-circle-x"></span> Cancelar</button>
                <asp:LinkButton ID="ButtonBajaAlumno" runat="server" CssClass="btn btn-danger" OnClick="ButtonBajaAlumno_Click"><span class="oi oi-warning"></span>Baja</asp:LinkButton>

            </div>
        </div>
    </div>
</div>



<script>
    (function () {
        document.querySelector("#buscar").onkeyup = function () {
            $TableFilter("#ContentPlaceHolder1_ContConsultaAlumno_GridViewReservacionCitas", this.value);
            //this.vale es igual al valor ingresado
        }

        $TableFilter = function (id, value) {

            var rows = document.querySelectorAll(id + ' tbody tr');

            for (var i = 0; i < rows.length; i++) {
                var showRow = false;

                var row = rows[i];

                row.style.display = 'none';

                for (var x = 0; x < row.childElementCount; x++) {
                    if (row.children[x].textContent.toLowerCase().indexOf(value.toLowerCase().trim()) > -1) {
                        showRow = true;
                        break;
                    }
                }

                if (showRow) {
                    row.style.display = null;
                }
            }
        }
    })();
</script>
