<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="planet.Default" %>

<%@ Register Src="~/Controles/Sesion/RegistroUsuario.ascx" TagPrefix="uc1" TagName="RegistroUsuario" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/app.css" rel="stylesheet" />
     <link href="Iconos/icon/font/css/open-iconic-bootstrap.css" rel="stylesheet" />

      

    <title>Inicio</title>
</head>

<body>
    <header id="header-container" class="fondoColor">
        <div class="container">
            <div class="row">

                <div class="col-1">
                </div>
                <div class="col-10 text-center">
                    <h2>Planet English Tulancingo</h2>
                </div>
                <div class="col-1">
                </div>
            </div>
        </div>
    </header>
    <br />
    <br />
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-sm-1 col-md-4 col-lg-4 col-xl-4 ">
                </div>
                <div class="col-sm10 col-md-4 col-lg-4 col-xl-4">
                    <div class="row justify-content-md-center ">
                        <div class="col align-content-center">
                            <div class="card bg-light ">
                                <div class="card-header  text-center fondoColor">Inicio de Sesión</div>
                                <div class="card-body">
                                    <div class="card-body">

                                        <div class="form-group">
                                            <label for="TextBoxNumeroDeControl"><span class="oi oi-person" />Matrícula</label>
                                            <asp:TextBox PlaceHolder="Escriba su matrícula" ID="TextBoxNumeroDeControl" runat="server" required="Ingrese su matrícula" CssClass="form-control input-lg" value="" pattern="[0-9]{1,7}" title="Solo números. Tamaño :7 digitos" autofocus=""></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <label for="password">
                                                <span class="oi oi-key"></span>Contraseña
                                            </label>
                                            <asp:TextBox PlaceHolder="Escriba su contraseña" ID="TextBoxContrasena" runat="server" required="" CssClass="form-control input-lg " TextMode="Password" pattern="[A-Za-z0-9]{1,25}" title="Letras y números. Tamaño mínimo: 5. Tamaño máximo: 25"></asp:TextBox>

                                        </div>
                                        <div class="row center-align">

                                            <div class="col m10 s10">
                                                <br />
                                                <asp:DropDownList ID="DropDownListRol" runat="server" CssClass="form-control"></asp:DropDownList>
                                                <br />
                                            </div>

                                        </div>
                                        <div class="form-group my-2">


                                            <asp:LinkButton ID="ButtonSesion" runat="server" CssClass="btn  btn-block  botonBase " OnClick="Buttoniniciar_Click"><span class="oi oi-action-redo"></span>   Entrar</asp:LinkButton>
                                            <br />

                                            <button type="button" class="btn btn-block  botonModal" data-toggle="modal" data-target="#exampleModal"><span class="oi oi-brush"></span>   Registro</button>



                                        </div>
                                    </div>
                                </div>
                                <div class="footer  text-center">
                                    Copyright &copy; Octavio GR <a href="#" class="alert-link"><%Response.Write(DateTime.Now.Year); %></a>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
                <div class="col-sm-1 col-md-4 col-lg-4 col-xl-4">
                </div>
            </div>
        </div>


        <!-- Modal -->
        <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <uc1:RegistroUsuario runat="server" ID="RegistroUsuario" />
        </div>

    </form>





    <script src="Scripts/jquery-3.2.1.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>

</body>
</html>






