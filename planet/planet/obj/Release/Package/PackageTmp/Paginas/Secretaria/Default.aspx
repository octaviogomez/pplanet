<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Secretaria/Secretaria.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="planet.Paginas.Secretaria.Default" %>

<%@ Register Src="~/Controles/Secretaria/Default/AlumnoReservacion.ascx" TagPrefix="uc1" TagName="AlumnoReservacion" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="card-body">
            <h5 class="card-title">Panel de inicio</h5>
            <p class="card-text"> .</p>

           

            <div class="row">
                <div class="col-md-2 border ">
                    <div class="nav flex-column nav-pills border-primary" id="v-pills-tab" role="tablist" aria-orientation="vertical">
                        <a class="nav-link active" id="v-pills-home-tab" data-toggle="pill" href="#PanelPrincipal" role="tab" aria-controls="v-pills-home" aria-selected="true">Panel princial</a>
                        <a class="nav-link" id="v-pills-profile-tab" data-toggle="pill" href="#Reservaciones" role="tab" aria-controls="v-pills-profile" aria-selected="false">Reservaciones</a>
                        <a class="nav-link" id="v-pills-messages-tab" data-toggle="pill" href="#Clubs" role="tab" aria-controls="v-pills-messages" aria-selected="false">Clubs</a>
                        <a class="nav-link" id="v-pills-settings-tab" data-toggle="pill" href="#v-pills-settings" role="tab" aria-controls="v-pills-settings" aria-selected="false">Lista de espera</a>
                    </div>
                </div>
                <div class="col-md-10">
                    <div class="tab-content" id="v-pills-tabContent">
                        <div class="tab-pane fade show active" id="PanelPrincipal" role="tabpanel" aria-labelledby="v-pills-home-tab">
                            <asp:Panel runat="server"  Height="450px" ScrollBars="Vertical" CssClass="border border-primary">

                            </asp:Panel>
                        </div>
                        <div class="tab-pane fade" id="Reservaciones" role="tabpanel" aria-labelledby="v-pills-profile-tab">
                                      <asp:Panel runat="server" Height="450px" ScrollBars="Vertical" CssClass="border border-primary">
                                          <uc1:AlumnoReservacion runat="server" id="AlumnoReservacion" />
                                      </asp:Panel>
                        </div>
                        <div class="tab-pane fade" id="Clubs" role="tabpanel" aria-labelledby="v-pills-messages-tab">
                            <asp:Panel runat="server"  Height="450px" ScrollBars="Vertical" CssClass="border border-primary">

                            </asp:Panel>
                        </div>
                        <div class="tab-pane fade" id="v-pills-settings" role="tabpanel" aria-labelledby="v-pills-settings-tab">
                            <asp:Panel runat="server"  Height="450px" ScrollBars="Vertical" CssClass="border border-primary">

                            </asp:Panel>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>






    </div>








    <script type="text/javascript"> 



    </script>
</asp:Content>
