<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ContPerfil.ascx.cs" Inherits="planet.Controles.Secretaria.Alumno.ContPerfil" %>

<div class="container">


    <div class="card">
        <h5 class="card-header">Perfil de alumno</h5>
        <div class="card-body">
            <h5 class="card-title">Instrucciones</h5>
            <ul>
                <li>Ingrese el id del alumno para buscarlo</li>
            </ul>

            <div>

                <div class="row">
                    <div class="col-4">
                        <label for="TextBoxidUsuario">Usuario:</label>
                        <asp:TextBox ID="TextBoxidBuscar" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                    </div>

                    <div class="col-4">
                        <br />
                        <asp:Button ID="ButtonBuscar" runat="server" Text="Buscar" CssClass="btn btn-success btn-lg btn-block" />
                    </div>
                </div>

            </div>
            <br />
            <div class="form-row">
                <div class="form-group col-md-3">
                    <label for="TextBoxId">id</label>
                    <asp:TextBox ID="TextBoxId" TextMode="Number" runat="server" CssClass="form-control" min="1" Enabled="false"></asp:TextBox>
                </div>
                <div class="form-group col-md-3">
                    <label for="TextBoxPasswordUno">Password</label>
                    <asp:TextBox ID="TextBoxPassword" runat="server" CssClass="form-control" min="1" placeholder="Password" Enabled="false"></asp:TextBox>
                </div>
                <div class="form-group col-md-3">
                    <label for="TextBoxAnioIngreso">Año de ingreso</label>
                    <asp:TextBox ID="TextBoxAnioIngreso" runat="server" CssClass="form-control" placeholder="Año de ingreso" Enabled="false"></asp:TextBox>
                </div>
                <div class="form-group col-md-3">
                    <label for="TextBoxAnioEgreso">Año de egreso</label>
                    <asp:TextBox ID="TextBoxAnioEgreso" runat="server" CssClass="form-control" placeholder="Año de egreso" Enabled="false"></asp:TextBox>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-4">
                    <label for="TextBoxCorreo">E-mail</label>
                    <asp:TextBox ID="TextBoxCorreo" TextMode="Email" runat="server" CssClass="form-control" placeholder="E-mail" Enabled="false"></asp:TextBox>

                </div>
                <div class="form-group col-md-4">
                    <label for="TextBoxNombre">Nombre</label>
                    <asp:TextBox ID="TextBoxNombre" runat="server" CssClass="form-control" min="1" MaxLength="25" placeholder="Nombre" Enabled="false"></asp:TextBox>
                </div>
                <div class="form-group col-md-4">
                    <label for="TextBoxApellidos">Apellidos</label>
                    <asp:TextBox ID="TextBoxApellidos" runat="server" CssClass="form-control" min="1" MaxLength="50" placeholder="Apellidos" Enabled="false"></asp:TextBox>

                </div>
            </div>

            <div class="form-row">
                <div class="form-group col-md-2">

                    <label for="CheckBoxEstadoPago">Estado Pago</label>

                    <div class="custom-control ">
                        <asp:CheckBox ID="CheckBoxEstadoPago" runat="server" TextAlign="Right" Text="Pago" Enabled="false" />
                    </div>
                </div>
                <div class="form-group col-md-4">

                    <label for="TextBoxFacebook">Facebook</label>
                    <asp:TextBox ID="TextBoxFacebook" runat="server" CssClass="form-control" min="5" MaxLength="40" required="" placeholder="Facebook" Enabled="false"></asp:TextBox>
                </div>
                <div class="form-group col-md-3">
                    <label for="TextBoxTelefono">Telefono</label>
                    <asp:TextBox ID="TextBoxTelefono" runat="server" CssClass="form-control" min="1" MaxLength="50" TextMode="Phone" Enabled="false" placeholder="Telefono"></asp:TextBox>

                </div>
                <div class="form-group col-md-3">
                    <label for="TextBoxCelular">Celular</label>
                    <asp:TextBox ID="TextBoxCelular" runat="server" CssClass="form-control" min="1" MaxLength="20" placeholder="Celular" Enabled="false"></asp:TextBox>

                </div>
            </div>


            <div class="form-row">
                <div class="form-group col-md-2">
                    <label for="TextBoxCorreo">Nivel</label>
                    <asp:TextBox ID="TextBoxNivel" TextMode="Email" runat="server" CssClass="form-control" placeholder="Nivel" Enabled="false"></asp:TextBox>

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
                    <asp:RadioButtonList ID="RadioButtonListSexo" runat="server" CssClass="custom-control  custom-radio" Enabled="false">
                        <asp:ListItem Text="Femenino" Value="F"></asp:ListItem>
                        <asp:ListItem Text="Masculino" Value="M"></asp:ListItem>
                    </asp:RadioButtonList>

                </div>
                <div class="form-group col-md-5">

                    <label for="TextBoxDireccion">Dirección</label>
                    <asp:TextBox ID="TextBoxDireccion" runat="server" CssClass="form-control" min="1" MaxLength="99" placeholder="21 de marzo #0174" Enabled="false"></asp:TextBox>
                </div>
                <div class="form-group col-md-5">
                    <label for="TextBoxCumple">Fecha de nacimiento</label>
                    <asp:TextBox ID="TextBoxCumple" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>

                </div>
            </div>

            <div class="form-group">

                <small id="emailHelp" class="form-text text-muted">Los datos se guardados de manera confidencial</small>
            </div>
            <div class="form-row">

                <div class="form-group col-md-4">
                </div>
                <div class="form-group col-md-4">
                </div>
                <div class="form-group col-md-4">
                </div>
            </div>
        </div>
    </div>
</div>















