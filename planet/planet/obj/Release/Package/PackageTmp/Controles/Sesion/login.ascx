<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="login.ascx.cs" Inherits="planet.Controles.Sesion.login" %>
<div class="row">
    <div class="col-md-2">

    </div>
     <div class="col-md-8">
         Inicio de sesion
    </div>
     <div class="col-md-2">

    </div>
</div>

<div class="row">
    <div class="col-md-2">

    </div>
     <div class="col-md-8">
         <asp:TextBox ID="TextBoxId" runat="server"></asp:TextBox>
    </div>
     <div class="col-md-2">

    </div>
</div>

<div class="row">
    <div class="col-md-2">

    </div>
     <div class="col-md-8">
         <asp:TextBox ID="TextBoxClave" runat="server"></asp:TextBox>
    </div>
     <div class="col-md-2">

    </div>
</div>

<div class="row">
    <div class="col-md-2">

    </div>
     <div class="col-md-8">
         <asp:DropDownList ID="DropDownListRol" runat="server"></asp:DropDownList>
    </div>
     <div class="col-md-2">

    </div>
</div>

<div class="row">
    <div class="col-md-2">

    </div>
     <div class="col-md-8">
         <asp:Button ID="Buttoniniciar" runat="server" Text="Button" OnClick="Buttoniniciar_Click" />
    </div>
     <div class="col-md-2">

    </div>
</div>