<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ContPerfil.ascx.cs" Inherits="planet.Controles.Secretaria.Alumno.ContPerfil" %>

<div class="container">


    <div class="card">
        <h5 class="card-header">Nuevo alumno</h5>
        <div class="card-body">
            <h5 class="card-title">Instrucciones</h5>
            <p class="card-text">Realice cuidadosamente el llenado.</p>

            <div class="form-row">
                <div class="form-group col-md-2">
                    <label for="TextBoxId">id</label>
                    <asp:TextBox ID="TextBoxId" TextMode="Number" runat="server" CssClass="form-control" min="1" Enabled="false"  ></asp:TextBox>
                </div>
                <div class="form-group col-md-5">
                    <label for="TextBoxPasswordUno">Password</label>
                    <asp:TextBox ID="TextBoxPasswordUno"  runat="server" CssClass="form-control" min="1"  placeholder="Password" Enabled="false"></asp:TextBox>
                </div>
                <div class="form-group col-md-5">
               
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-4">
                    <label for="TextBoxCorreo">E-mail</label>
                    <asp:TextBox ID="TextBoxCorreo" TextMode="Email" runat="server" CssClass="form-control" placeholder="E-mail"  Enabled="false"></asp:TextBox>

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
                       <asp:CheckBox ID="CheckBoxEstadoPago" runat="server" TextAlign="Right" Text="Pago" Enabled="false"/>
                    </div>
                </div>
                <div class="form-group col-md-4">

                    <label for="TextBoxFacebook">Facebook</label>
                    <asp:TextBox ID="TextBoxFacebook" runat="server" CssClass="form-control" min="5" MaxLength="40" required="" placeholder="Facebook"></asp:TextBox>
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
                    <label for="TextBoxNombre">Sexo</label>
                    <asp:RadioButtonList ID="RadioButtonListSexo" runat="server" CssClass="custom-control  custom-radio" Enabled="false">
                        <asp:ListItem Text="Femenino" Value="F" ></asp:ListItem>
                         <asp:ListItem Text="Masculino" Value="M"></asp:ListItem>
                    </asp:RadioButtonList>

                </div>
                <div class="form-group col-md-5">

                    <label for="TextBoxDireccion">Dirección</label>
                    <asp:TextBox ID="TextBoxDireccion" runat="server" CssClass="form-control" min="1" MaxLength="99"  placeholder="21 de marzo #0174" Enabled="false"></asp:TextBox>
                </div>
                <div class="form-group col-md-5">
                    <label for="TextBoxCumple">Fecha de nacimiento</label>
                    <asp:TextBox ID="TextBoxCumple" runat="server" CssClass="form-control" TextMode="Date" Enabled="false"></asp:TextBox>

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
















