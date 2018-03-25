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
                    <asp:DropDownList ID="DropDownListHorarios" runat="server" class="form-control" placeholder="Horario" required="Se necesita un horario"   ></asp:DropDownList>
                </div>
                <div class="col-md-4 mb-3">
                    <label for="ButtonBuscarFecha"></label>
                    <asp:Button ID="ButtonBuscarFecha" runat="server" Text="Buscar" class="btn btn-info btn-lg btn-block "  />
                </div>
            </div>

            <br />
            <asp:Panel ID="PanelListadoCitas" runat="server" Height="700px" ScrollBars="Vertical" CssClass="border border-primary">
                <div class="table-responsive">
                    <asp:GridView ID="GridViewCitas" runat="server" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="false" O>
                        <Columns>
                            <asp:TemplateField ShowHeader="False" HeaderText="IdCita" Visible="false" ControlStyle-CssClass="">
                                <ItemTemplate>
                                    <asp:Label ID="LabelId" Visible="false" runat="server" Text='<%# Eval("Id")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ShowHeader="False" HeaderText="Selecionar">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButtonSeleccionar" runat="server" CommandName="seleccion" CssClass="btn btn-outline-warning   btn-lg btn-block">Seleccionar</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>

                            
                            <asp:BoundField Visible="true" DataField="Estado" HeaderText="Estado" />
                            <asp:BoundField Visible="true" DataField="Fecha" HeaderText="Fecha" />
                            <asp:BoundField Visible="true" DataField="Horario" HeaderText="Horario" />
                            <asp:BoundField Visible="true" DataField="No. Profes" HeaderText="No. Profes" />
                            <asp:BoundField Visible="true" DataField="Espacios" HeaderText="Espacios" />
                            <asp:BoundField Visible="true" DataField="No. Alumnos" HeaderText="No. Alumnos" />
                        </Columns>
                    </asp:GridView>
                </div>
            </asp:Panel>




            <br />
      

        </div>
    </div>
</div>
<br />

