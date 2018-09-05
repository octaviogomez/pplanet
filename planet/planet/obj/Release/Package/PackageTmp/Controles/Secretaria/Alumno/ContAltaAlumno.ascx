<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ContAltaAlumno.ascx.cs" Inherits="planet.Controles.Secretaria.Alumno.ContAltaAlumno" %>

<div class="container">


    <div class="card">
        <h5 class="card-header"><span class="oi oi-person"></span>Registrar Alumno</h5>
        <div class="card-body">
            <div id="headingOne" class="linkAyuda" data-toggle="collapse" data-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
                <h5 class="card-title"><span class="oi oi-info"></span>Instrucciones</h5>
            </div>
            <div id="collapseOne" class="collapse" aria-labelledby="headingOne" data-parent="#accordion">
                <div class="card-body">
                    <div class="alert-info">
                        <p class="lead">En el siguiente apartado podra registrar un alumno,tome encuenta que los siguientes campos no son obligatorios.</p>
                    </div>
                    <ul>
                        <li><strong>Password</strong></li>
                        <li><strong>E-mail</strong></li>
                        <li><strong>Facebook</strong></li>
                        <li><strong>Telefono</strong></li>
                        <li><strong>Celular</strong></li>
                        <li><strong>Dirección</strong></li>
                    </ul>
                    <br />
                    <div class="alert-warning">
                        <strong>Nota:</strong>
                        En el campo de <strong>id</strong> podria agregar una matrícula propia del plantel.
                    </div>
                </div>
            </div>
            <div class="form-row">

                <div class="form-group col-md-2">
                    <label for="TextBoxId">id</label>
                    <asp:TextBox ID="TextBoxId" TextMode="Number" runat="server" CssClass="form-control" min="1" data-toggle="tooltip" data-placement="top" title="Tooltip on top"></asp:TextBox>
                    <small class="form-text text-muted">El Id puede ser opcional</small>
                </div>
                <div class="form-group col-md-5">
                    <label for="TextBoxPasswordUno">Password</label>
                    <asp:TextBox ID="TextBoxPasswordUno" TextMode="Password" runat="server" CssClass="form-control" min="1" required="" placeholder="Password"></asp:TextBox>
                </div>
                <div class="form-group col-md-5">
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-4">
                    <label for="TextBoxCorreo">E-mail</label>
                    <asp:TextBox ID="TextBoxCorreo" TextMode="Email" runat="server" CssClass="form-control" placeholder="E-mail" ToolTip="uncorreo@dominio.com"></asp:TextBox>
                </div>
                <div class="form-group col-md-4">
                    <label for="TextBoxNombre">Nombre</label>
                    <asp:TextBox ID="TextBoxNombre" runat="server" CssClass="form-control" min="1" MaxLength="25" placeholder="Nombre" required="Se necesita un nombre"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="vldtxtNewName" runat="server"
                        ControlToValidate="TextBoxNombre" ValidationGroup="alta"
                        ErrorMessage="Se necesita un nombre" CssClass=" alert-warning" />
                </div>
                <div class="form-group col-md-4">
                    <label for="TextBoxApellidos">Apellidos</label>
                    <asp:TextBox ID="TextBoxApellidos" runat="server" CssClass="form-control" min="1" MaxLength="50" placeholder="Apellidos" required="Se necesita algun apellido"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorApellidos" runat="server"
                        ControlToValidate="TextBoxApellidos" ValidationGroup="alta"
                        ErrorMessage="Se necesita los apellidos" CssClass=" alert-warning" />
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
                    <asp:TextBox ID="TextBoxFacebook" runat="server" CssClass="form-control" min="5" MaxLength="40" placeholder="Facebook"></asp:TextBox>
                </div>
                <div class="form-group col-md-3">
                    <label for="TextBoxTelefono">Telefono</label>
                    <asp:TextBox ID="TextBoxTelefono" runat="server" CssClass="form-control" min="1" MaxLength="50" TextMode="Phone" placeholder="Telefono"></asp:TextBox>
                </div>
                <div class="form-group col-md-3">
                    <label for="TextBoxCelular">Celular</label>
                    <asp:TextBox ID="TextBoxCelular" runat="server" CssClass="form-control" min="1" MaxLength="20" placeholder="Celular"></asp:TextBox>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-2">
                    <label for="RadioButtonListSexo">Sexo</label>
                    <asp:RadioButtonList ID="RadioButtonListSexo" runat="server" CssClass="custom-control  custom-radio" required="">
                        <asp:ListItem Text="Femenino" Value="F" Selected="True"></asp:ListItem>
                        <asp:ListItem Text="Masculino" Value="M"></asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <div class="form-group col-md-5">

                    <label for="TextBoxDireccion">Dirección</label>
                    <asp:TextBox ID="TextBoxDireccion" runat="server" CssClass="form-control" min="1" MaxLength="99" placeholder="21 de marzo #0174"></asp:TextBox>
                </div>
                <div class="form-group col-md-5">
                    <label for="TextBoxCumple">Fecha de nacimiento</label>
                    <asp:TextBox ID="TextBoxCumple" runat="server" CssClass="form-control" TextMode="Date" required="Se necesita una fecha"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <small id="emailHelp" class="form-text text-muted">Los datos se guardados de manera confidencial</small>
            </div>
            <div class="form-row">
                <div class="form-group col-md-4">
                </div>
                <div class="form-group col-md-4">
                    <asp:LinkButton ID="ButtonAgrega" runat="server" CssClass="btn btn-success btn-lg btn-block" OnClick="ButtonAgrega_Click" ValidationGroup="alta"> <span class="oi oi-person"></span> Agregar</asp:LinkButton>

                </div>
                <div class="form-group col-md-4">
                </div>
            </div>

            <asp:Panel ID="PanelExito" runat="server" Visible="false">
                <div class="alert alert-success" role="alert">
                    <h4 class="alert-heading">Registro exitoso!</h4>
                    <p>Para consultar el registro dirigase a la sección de <a href="ConsultaAlumno.aspx">Consulta</a> </p>
                    <hr>
                    <p class="mb-0">.</p>
                </div>
            </asp:Panel>
              <asp:Panel ID="PanelError" runat="server" Visible="false">
                <div class="alert alert-warning" role="alert">
                    <h4 class="alert-heading">Error de registro !</h4>
                    <p>Al parecer ocurrio un error, actualice la página, e intente de nuevo. <a href="AltaAlumno.aspx"><span class="oi oi-reload"></span></a>  </p>
                    <hr>
                    <p class="mb-0">Verifique bien sus datos.</p>
                </div>
            </asp:Panel>
        </div>
    </div>
</div>


<script>
    (function () {

        $('[data-toggle="tooltip"]').tooltip(); //activamos los tooltip


    })();
</script>













