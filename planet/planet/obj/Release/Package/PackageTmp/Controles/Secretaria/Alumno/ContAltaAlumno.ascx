<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ContAltaAlumno.ascx.cs" Inherits="planet.Controles.Secretaria.Alumno.ContAltaAlumno" %>

<div class="container">


    <div class="card">
        <h5 class="card-header">Nuevo alumno</h5>
        <div class="card-body">
            <h5 class="card-title">Instrucciones</h5>
            <p class="card-text">Realice cuidadosamente el llenado.</p>
            <div class="form-row">
                <div class="form-group col-md-2">
                    <label for="TextBoxId">id</label>
                    <asp:TextBox ID="TextBoxId" TextMode="Number" runat="server" CssClass="form-control" min="1" required=""></asp:TextBox>
                </div>
                <div class="form-group col-md-5">
                    <label for="TextBoxPasswordUno">Password</label>
                    <asp:TextBox ID="TextBoxPasswordUno" TextMode="Password" runat="server" CssClass="form-control" min="1" required="" placeholder="Password"></asp:TextBox>
                </div>
                <div class="form-group col-md-5">
                    <label for="TextBoxPasswordDos">Repetir password</label>
                    <asp:TextBox ID="TextBoxPasswordDos" TextMode="Password" runat="server" CssClass="form-control" required="" placeholder="Repetir password"></asp:TextBox>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-4">
                    <label for="TextBoxCorreo">E-mail</label>
                    <asp:TextBox ID="TextBoxCorreo" TextMode="Email" runat="server" CssClass="form-control" placeholder="E-mail" required=""></asp:TextBox>
                </div>
                <div class="form-group col-md-4">
                    <label for="TextBoxNombre">Nombre</label>
                    <asp:TextBox ID="TextBoxNombre" runat="server" CssClass="form-control" min="1" MaxLength="25" placeholder="Nombre" required="Se necesita un nombre"></asp:TextBox>
                    
                </div>
                <div class="form-group col-md-4">
                    <label for="TextBoxApellidos">Apellidos</label>
                    <asp:TextBox ID="TextBoxApellidos" runat="server" CssClass="form-control" min="1" MaxLength="50" placeholder="Apellidos" required="Se necesita algun apellido"></asp:TextBox>
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
                    <asp:TextBox ID="TextBoxTelefono" runat="server" CssClass="form-control" min="1" MaxLength="50" TextMode="Phone" required="" placeholder="Telefono"></asp:TextBox>
                </div>
                <div class="form-group col-md-3">
                    <label for="TextBoxCelular">Celular</label>
                    <asp:TextBox ID="TextBoxCelular" runat="server" CssClass="form-control" min="1" MaxLength="20" placeholder="Celular" required=""></asp:TextBox>
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
                    <asp:TextBox ID="TextBoxDireccion" runat="server" CssClass="form-control" min="1" MaxLength="99" required="" placeholder="21 de marzo #0174"></asp:TextBox>
                </div>
                <div class="form-group col-md-5">
                    <label for="TextBoxCumple">Fecha de nacimiento</label>
                    <asp:TextBox ID="TextBoxCumple" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <small id="emailHelp" class="form-text text-muted">Los datos se guardados de manera confidencial</small>
            </div>
            <div class="form-row">
                <div class="form-group col-md-4">
                </div>
                <div class="form-group col-md-4">
                    <asp:Button ID="ButtonAgregar" runat="server" Text="Agregar" CssClass="btn btn-success btn-lg btn-block" OnClick="ButtonAgregar_Click" />
                </div>
                <div class="form-group col-md-4">
                </div>
            </div>

            <asp:Panel ID="PanelCorrecto" runat="server"></asp:Panel>
        </div>
    </div>
</div>





<script>
    


    

      
        
 
</script>
















