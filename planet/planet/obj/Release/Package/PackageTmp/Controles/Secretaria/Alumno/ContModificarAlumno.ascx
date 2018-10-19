<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ContModificarAlumno.ascx.cs" Inherits="planet.Controles.Secretaria.Alumno.ContModificarAlumno" %>

<div class="container">
    <div class="card">
        <h5 class="card-header"><span class="oi oi-wrench"></span>Modificación de datos</h5>
        <div class="card-body">
            <div id="headingOne" class="linkAyuda" data-toggle="collapse" data-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
                <h5 class="card-title"><span class="oi oi-info"></span>Instrucciones</h5>
            </div>
            <div id="collapseOne" class="collapse" aria-labelledby="headingOne" data-parent="#accordion">
                <div class="card-body">
                    <div class="alert-info">
                        <p class="lead">Para actualizar los datos del usuario, tengo encuenta las siguientes recomendaciones.</p>
                    </div>
                    <ul>
                        <li>Todos los campos deben de ir completos</li>
                        <li>Hay unos campos que no se pueden modificar como, Año de ingreso, clubs y pelis</li>
                    </ul>
                    <br />
                    <div class="alert-warning">
                        <strong>Nota:</strong>
                        En el campo de <strong>id</strong> podria agregar una matrícula propia del plantel.
                    </div>
                </div>
            </div>


            <div>
            </div>
            <br />
            <div class="form-row">
                <div class="form-group col-md-3">
                    <label for="TextBoxId">id</label>
                    <asp:TextBox ID="TextBoxPkUsuario" TextMode="Number" runat="server" CssClass="form-control" min="1" Visible="false" Enabled="false"></asp:TextBox>
                    <asp:TextBox ID="TextBoxId" TextMode="Number" runat="server" CssClass="form-control" min="1" Enabled="false"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RTextBoxId" runat="server" ControlToValidate="TextBoxId" ValidationGroup="cambio" ErrorMessage="Campo requerido" CssClass="form-control alert-danger" />
                </div>
                <div class="form-group col-md-3">
                    <label for="TextBoxPasswordUno">Password</label>
                    <asp:TextBox ID="TextBoxPassword" runat="server" CssClass="form-control" min="1" placeholder="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RTextBoxPassword" runat="server" ControlToValidate="TextBoxPassword" ValidationGroup="cambio" ErrorMessage="Campo requerido" CssClass="form-control alert-danger" />

                </div>
                <div class="form-group col-md-3">
                    <label for="TextBoxAnioIngreso">Año de ingreso</label>
                    <asp:TextBox ID="TextBoxAnioIngreso" runat="server" CssClass="form-control" placeholder="Año de ingreso" Enabled="false"></asp:TextBox>

                </div>
                <div class="form-group col-md-3">
                    <label for="TextBoxAnioEgreso">Año de egreso</label>
                    <asp:TextBox ID="TextBoxAnioEgreso" TextMode="Date" runat="server" CssClass="form-control" placeholder="Año de egreso"></asp:TextBox>

                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-4">
                    <label for="TextBoxCorreo">E-mail</label>
                    <asp:TextBox ID="TextBoxCorreo" TextMode="Email" runat="server" CssClass="form-control" placeholder="E-mail"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RTextBoxCorreo" runat="server" ControlToValidate="TextBoxCorreo" ValidationGroup="cambio" ErrorMessage="Campo requerido" CssClass="form-control alert-danger" />

                </div>
                <div class="form-group col-md-4">
                    <label for="TextBoxNombre">Nombre</label>
                    <asp:TextBox ID="TextBoxNombre" runat="server" CssClass="form-control" min="1" MaxLength="25" placeholder="Nombre"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RTextBoxNombre" runat="server" ControlToValidate="TextBoxNombre" ValidationGroup="cambio" ErrorMessage="Campo requerido" CssClass="form-control alert-danger" />

                </div>
                <div class="form-group col-md-4">
                    <label for="TextBoxApellidos">Apellidos</label>
                    <asp:TextBox ID="TextBoxApellidos" runat="server" CssClass="form-control" min="1" MaxLength="50" placeholder="Apellidos"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RTextBoxApellidos" runat="server" ControlToValidate="TextBoxApellidos" ValidationGroup="cambio" ErrorMessage="Campo requerido" CssClass="form-control alert-danger" />

                </div>
            </div>

            <div class="form-row">
                <div class="form-group col-md-2">

                    <label for="CheckBoxEstadoPago">Estado Pago</label>

                    <div class="custom-control ">
                        <asp:CheckBox ID="CheckBoxEstadoPago" runat="server" TextAlign="Right" Text="Pago" />
                    </div>
                </div>
                <div class="form-group col-md-4">

                    <label for="TextBoxFacebook">Facebook</label>
                    <asp:TextBox ID="TextBoxFacebook" runat="server" CssClass="form-control" min="5" MaxLength="40" required="" placeholder="Facebook"></asp:TextBox>

                </div>
                <div class="form-group col-md-3">
                    <label for="TextBoxTelefono">Telefono</label>
                    <asp:TextBox ID="TextBoxTelefono" runat="server" CssClass="form-control" min="1" MaxLength="50" TextMode="Phone" placeholder="Telefono"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RTextBoxTelefono" runat="server" ControlToValidate="TextBoxTelefono" ValidationGroup="cambio" ErrorMessage="Campo requerido" CssClass="form-control alert-danger" />

                </div>
                <div class="form-group col-md-3">
                    <label for="TextBoxCelular">Celular</label>
                    <asp:TextBox ID="TextBoxCelular" runat="server" CssClass="form-control" min="1" MaxLength="20" placeholder="Celular"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RTextBoxCelular" runat="server" ControlToValidate="TextBoxCelular" ValidationGroup="cambio" ErrorMessage="Campo requerido" CssClass="form-control alert-danger" />

                </div>
            </div>


            <div class="form-row">
                <div class="form-group col-md-2">
                    <label for="DropDownListNivel">Nivel</label>

                    <asp:DropDownList ID="DropDownListNivel" runat="server" CssClass="form-control">
                        <asp:ListItem Text="1" Value="1"> </asp:ListItem>
                        <asp:ListItem Text="2" Value="2"> </asp:ListItem>
                        <asp:ListItem Text="3" Value="3"> </asp:ListItem>
                        <asp:ListItem Text="4" Value="4"> </asp:ListItem>
                        <asp:ListItem Text="Finalizado" Value="5"> </asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="form-group col-md-2">
                    <label for="TextBoxNombre">Clubs</label>
                    <asp:TextBox ID="TextBoxClubs" runat="server" CssClass="form-control" min="1" MaxLength="25" placeholder="Clubs" Enabled="false"></asp:TextBox>
                </div>
                <div class="form-group col-md-2">
                    <label for="TextBoxNombre">Pelis</label>
                    <asp:TextBox ID="TextBoxPelis" runat="server" CssClass="form-control" placeholder="Pelis" Enabled="false"></asp:TextBox>

                </div>
            </div>

            <div class="form-row">
                <div class="form-group col-md-2">
                    <label for="TextBoxNombre">Sexo</label>
                    <asp:RadioButtonList ID="RadioButtonListSexo" runat="server" CssClass="custom-control  custom-radio">
                        <asp:ListItem Text="Femenino" Value="F"></asp:ListItem>
                        <asp:ListItem Text="Masculino" Value="M"></asp:ListItem>
                    </asp:RadioButtonList>

                </div>
                <div class="form-group col-md-5">

                    <label for="TextBoxDireccion">Dirección</label>
                    <asp:TextBox ID="TextBoxDireccion" runat="server" CssClass="form-control" min="1" MaxLength="99" placeholder="21 de marzo #0174"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RTextBoxDireccion" runat="server" ControlToValidate="TextBoxDireccion" ValidationGroup="cambio" ErrorMessage="Campo requerido" CssClass="form-control alert-danger" />

                </div>
                <div class="form-group col-md-5">
                    <label for="TextBoxCumple">Fecha de nacimiento</label>
                    <asp:TextBox ID="TextBoxCumple" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RTextBoxCumple" runat="server" ControlToValidate="TextBoxCumple" ValidationGroup="cambio" ErrorMessage="Campo requerido" CssClass="form-control alert-danger" />

                </div>
            </div>

            <div class="form-group">

                <small id="emailHelp" class="form-text text-muted">Los datos se guardados de manera confidencial</small>
            </div>
            <div class="form-row">

                <div class="form-group col-md-4">
                </div>
                <div class="form-group col-md-4">
                    <asp:LinkButton ID="ButtonGuardar" runat="server" CssClass="btn btn-warning btn-lg btn-block" OnClick="ButtonGuardar_Click" ValidationGroup="cambio"> <span class="oi oi-check"></span> Modificar</asp:LinkButton>

                </div>
                <div class="form-group col-md-4">
                </div>
            </div>
            <div>
                <asp:Panel ID="PanelAviso" runat="server" Visible="false">
                    <div class="alert alert-success" role="alert">
                      Exito
                    </div>
                </asp:Panel>
                <asp:Panel ID="PanelError" runat="server" Visible="false">
                    <div class="alert alert-warning" role="alert">
                       Error
                    </div>
                </asp:Panel>
            </div>

        </div>
    </div>
</div>







