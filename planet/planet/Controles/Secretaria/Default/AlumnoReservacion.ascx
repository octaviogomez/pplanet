<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AlumnoReservacion.ascx.cs" Inherits="planet.Controles.Secretaria.Default.AlumnoReservacion" %>

        

            <div class="form-row ">
                <label for="buscar">Filtrado:</label>
                <input id="buscar" type="text" class="form-control" placeholder="Escriba algo para filtrar" />

            </div>
            <br />
                <div class="table-responsive">
                    <asp:GridView ID="GridViewReservacionCitas" runat="server" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="false" OnRowCommand="GridView_RowCommand">
                        <Columns>
                            <asp:TemplateField ShowHeader="False" HeaderText="IdCita" Visible="false" ControlStyle-CssClass="">
                                <ItemTemplate>
                                    <asp:Label ID="LabelId" Visible="false" runat="server" Text='<%# Eval("Id")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField ShowHeader="False" HeaderText="C">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButtonCancelar" runat="server" CommandName="Cancelar" CssClass="form-control btn btn-outline-danger">
                                         <span class="oi oi-ban"></span>
                                    </asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField ShowHeader="False" HeaderText="F">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButtonFalta" runat="server" CommandName="Falta" CssClass="form-control btn btn-outline-warning">
                                        <span class="oi oi-bell"></span>
                                    </asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ShowHeader="False" HeaderText="R">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButtonRetardo" runat="server" CommandName="Retardo" CssClass="form-control btn btn-outline-info">
                                        <span class="oi oi-clock"></span>
                                    </asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:BoundField Visible="false" DataField="pk_alumno" HeaderText="pk_alumno" />

                            <asp:BoundField Visible="true" DataField="Nombre" HeaderText="Nombre" ItemStyle-Font-Bold="true" />
                            <asp:BoundField Visible="true" DataField="Nivel" HeaderText="Nivel" />
                            <asp:BoundField Visible="true" DataField="Lecciones" HeaderText="Lecciones" />
                            <asp:BoundField Visible="true" DataField="Tipo" HeaderText="Tipo" />
                            <asp:BoundField Visible="true" DataField="Hora" HeaderText="Hora" />
                           
                            <asp:BoundField Visible="true" DataField="Estado" HeaderText="Estado" />
                       


                        </Columns>
                    </asp:GridView>
                </div>
  



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
                Esta seguro de eliminar la reservación para <strong>
                    <asp:Label ID="LabelNombreAlumno" runat="server" Text=" "></asp:Label></strong>

            </div>
            <div class="modal-footer">
                <asp:TextBox ID="TextBoxPkReservacion" runat="server" Visible="false" Enabled="false"></asp:TextBox>
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                <asp:Button ID="ButtonEliminarCita" runat="server" Text="Eliminar " CssClass="btn btn-danger" OnClick="ButtonEliminarCita_Click" />
            </div>
        </div>
    </div>
</div>

<script>
    (function () {
        document.querySelector("#buscar").onkeyup = function () {
            $TableFilter("#ContentPlaceHolder1_ControlConsultaCancelacion_PanelListadoCitas", this.value);
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
