<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AlumnoReservacion.ascx.cs" Inherits="planet.Controles.Secretaria.Default.AlumnoReservacion" %>



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

  
       
      
           
          
            <asp:Panel ID="PanelListadoCitas" runat="server" Height="700px" ScrollBars="Vertical" CssClass="border border-primary">
                <div class="table-responsive">
                    <asp:GridView ID="GridViewReservacionCitas" runat="server" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="false" OnRowCommand="GridView_RowCommand">
                        <Columns>
                            <asp:TemplateField ShowHeader="False" HeaderText="IdCita" Visible="false" ControlStyle-CssClass="">
                                <ItemTemplate>
                                    <asp:Label ID="LabelId" Visible="false" runat="server" Text='<%# Eval("Id")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField ShowHeader="False" HeaderText="Falta">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButtonFalta" runat="server" CommandName="Falta" CssClass="form-control btn btn-outline-warning" >
                                        <span class="oi oi-bell"></span>
                                    </asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ShowHeader="False" HeaderText="Retardo">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButtonRetardo" runat="server" CommandName="Retardo" CssClass="form-control btn btn-outline-info" >
                                        <span class="oi oi-clock"></span>
                                    </asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:BoundField Visible="false" DataField="pk_alumno" HeaderText="pk_alumno" />
                       
                            <asp:BoundField Visible="true" DataField="Nombre" HeaderText="Nombre" ItemStyle-Font-Bold="true"/>
                            <asp:BoundField Visible="true" DataField="Nivel" HeaderText="Nivel" />
                            <asp:BoundField Visible="true" DataField="Lecciones" HeaderText="Lecciones" />
                            <asp:BoundField Visible="true" DataField="Tipo" HeaderText="Tipo" />
                            <asp:BoundField Visible="false" DataField="Hora" HeaderText="Hora" />
                            <asp:BoundField Visible="false" DataField="Fecha" HeaderText="Fecha" />
                            <asp:BoundField Visible="false" DataField="Estado" HeaderText="Estado"/>
                           


                        </Columns>
                    </asp:GridView>
                </div>
            </asp:Panel>




          



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
                Esta seguro de eliminar la reservación para <strong><asp:Label ID="LabelNombreAlumno" runat="server" Text=" "></asp:Label></strong>
                
            </div>
            <div class="modal-footer">
                <asp:TextBox ID="TextBoxPkReservacion" runat="server" Visible="false" Enabled="false"></asp:TextBox>
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                <asp:Button ID="ButtonEliminarCita" runat="server" Text="Eliminar " CssClass="btn btn-danger"  OnClick="ButtonEliminarCita_Click"/>
            </div>
        </div>
    </div>
</div>