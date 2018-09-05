<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RegistroUsuario.ascx.cs" Inherits="planet.Controles.Sesion.RegistroUsuario" %>
<div class="modal-dialog" role="document">
    <div class="modal-content">
        <div class="modal-header">
            <h5 class="modal-title" id="exampleModalLabel">Quiero registrarme!</h5>
            <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span> </button>
        </div>
        <div class="modal-body">
            <div class="container-fluid">
                <div class="form-row">
                    <div class="col-12 ">
                        <label for="TextBoxAlumnoNombre">Nombre</label>
                        <asp:TextBox ID="TextBoxAlumnoNombre" runat="server" CssClass="form-control" placeholder="Juan" MaxLength="20" min="2"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RTextBoxAlumnoNombre" runat="server" ControlToValidate="TextBoxAlumnoNombre" ValidationGroup="alta" ErrorMessage="Campo vacio" CssClass=" alert-warning form-control" />
                    </div>
                    <div class="col-12">
                        <label for="TextBoxAlumnoApellidos">Apellidos</label>
                        <asp:TextBox ID="TextBoxAlumnoApellidos" runat="server" CssClass="form-control" placeholder="López Cruz" MaxLength="35" min="2"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RTextBoxAlumnoApellidos" runat="server" ControlToValidate="TextBoxAlumnoApellidos" ValidationGroup="alta" ErrorMessage="Campo vacio" CssClass=" alert-warning form-control" />
                    </div>
                    <div class="col-12">
                        <label for="TextBoxAlumnoCorreo">Email</label>
                        <asp:TextBox ID="TextBoxAlumnoCorreo" runat="server" CssClass="form-control" TextMode="Email" placeholder="Email" MaxLength="25" min="2"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RTextBoxAlumnoCorreo" runat="server" ControlToValidate="TextBoxAlumnoCorreo" ValidationGroup="alta" ErrorMessage="Campo vacio" CssClass=" alert-warning form-control" />
                    </div>
                    <div class="col-12">
                        <label for="TextBoxAlumnoClave">Contraseña</label>
                        <asp:TextBox ID="TextBoxAlumnoClave" runat="server" CssClass="form-control" placeholder="Contraseña" MaxLength="16" min="2"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RTextBoxAlumnoClave" runat="server" ControlToValidate="TextBoxAlumnoClave" ValidationGroup="alta" ErrorMessage="Campo vacio" CssClass=" alert-warning form-control" />
                    </div>

                    <div class="col-6">
                        <label for="TextBoxCumple">Fecha de nacimineto</label>
                        <asp:TextBox ID="TextBoxCumple" runat="server" CssClass="form-control" placeholder="Cumpleaños" TextMode="Date" ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RTextBoxCumple" runat="server" ControlToValidate="TextBoxCumple" ValidationGroup="alta" ErrorMessage="Campo vacio" CssClass=" alert-warning form-control" />
                    </div>


                    <div class="col-6">

                        <label for="GeneroList">Género</label>
                        <asp:DropDownList ID="GeneroList" runat="server" CssClass="form-control">
                            <asp:ListItem Text="Mujer" Value="F"></asp:ListItem>
                            <asp:ListItem Text="Hombre" Value="M"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
            </div>







        </div>
        <div class="modal-footer">
            <button type="button" class="btn btn-secondary" data-dismiss="modal"><span class="oi oi-circle-x"></span>Cancelar</button>
            <asp:LinkButton ID="LinkButtonGuardarAlumo" runat="server" CssClass="btn btn-success" OnClick="LinkButtonGuardarAlumo_Click" ValidationGroup="alta"><span class="oi oi-circle-check"></span>   Registrarse</asp:LinkButton>
        </div>
    </div>
</div>
