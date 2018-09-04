<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ContPerfil.ascx.cs" Inherits="planet.Controles.Secretaria.Alumno.ContPerfil" %>

<div class="container">


    <div class="card">
        <h5 class="card-header"><span class="oi oi-document"></span>Perfil de usuario</h5>
        <div class="card-body">
            <div id="headingOne" class="linkAyuda" data-toggle="collapse" data-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
                <h5 class="card-title"><span class="oi oi-info"></span>Instrucciones</h5>
            </div>
            <div id="collapseOne" class="collapse" aria-labelledby="headingOne" data-parent="#accordion">
                <div class="card-body">
                    <div class="alert-info">
                        <p class="lead">En el siguiente apartado podra visualizar datos un alumno</p>
                    </div>
                    <ol>
                        <li>Ingrese el id del alumno</li>
                        <li>De clic en <strong><span class="oi oi-zoom-in"></span></strong>para buscar el registro</li>
                    </ol>
                    <br />
                    <div class="alert-warning">
                        <strong>Nota:</strong>
                        En el campo de <strong>id</strong> podria agregar una matrícula propia del plantel.
                    </div>
                </div>
            </div>

            <div>

                <div class="row">
                    <div class="col-4">
                        <label for="TextBoxidUsuario">Usuario:</label>
                        <asp:TextBox ID="TextBoxidBuscar" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                        <asp:Panel ID="PanelAviso" runat="server" Visible="false">
                            <div class="alert alert-warning" role="alert">
                                Sin resultados, intente con otro <strong>ID</strong>
                            </div>
                        </asp:Panel>
                    </div>

                    <div class="col-4">
                        <br />
                        <asp:LinkButton ID="ButtonBusca" runat="server" CssClass="btn btn-success btn-lg btn-block" OnClick="ButtonBuscar_Click"><span class="oi oi-zoom-in"></span> Buscar</asp:LinkButton>

                    </div>
                    <div class="col-4">
                        <br />
                        <asp:LinkButton ID="ButtonModifica" runat="server" CssClass="btn btn-warning btn-lg btn-block" OnClick="ButtonModifica_Click"><span class="oi oi-pencil">Modificar</span></asp:LinkButton>
                    <asp:Panel ID="PanelModificar" runat="server" Visible="false">
                            <div class="alert alert-info" role="alert">
                               Debe de buscar un usuario con su <strong>ID</strong>
                            </div>
                        </asp:Panel>
                    </div>
                </div>

            </div>
            <br />
            <div class="form-row">
                <div class="form-group col-md-3">
                    <label for="TextBoxId">id</label>
                          <asp:TextBox ID="TextBoxPkUsuario"  runat="server" CssClass="form-control" min="1" Enabled="false" Visible="false"></asp:TextBox>
              
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
                    <label for="DropDownListNivel">Nivel</label>

                    <asp:DropDownList ID="DropDownListNivel" runat="server" Enabled="false" CssClass="form-control">
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


        </div>
    </div>
</div>


<script>

    (function () {


        $("#ContentPlaceHolder1_ContPerfil_TextBoxidBuscar").on("click", function () {
            $('#ContentPlaceHolder1_ContPerfil_TextBoxidBuscar').val("");
        });



    })();
</script>














