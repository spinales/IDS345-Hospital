<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Servicios.aspx.cs" Inherits="WebApp_Hospital.WebForm4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    <h1 class="page-title">Servicios</h1>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="servicios-header d-flex align-items-center justify-content-between">
        <h3>Servicios más solicitados</h3>
        <a class="small" href="#">Ver más</a>
    </div>

    <!-- Servicios mas solicitados -->

   <div class="container">
      
    <div class="row">
        <asp:Repeater ID="ServiciosRepeater" runat="server">
            <ItemTemplate>
                <div class="col-md-3">
                    <div class="card shadow" style="margin-bottom: 20px;">
                        <div class="bg-image hover-overlay ripple" data-mdb-ripple-color="light">
                            <img src="Design Resources\Images\service.svg" class="img-fluid" />

                        </div>
                        <div class="card-body">
                            <div class="card-head d-flex justify-content-between">
                                <h5 class="card-title"><%#Eval("Descripcion")%></h5>
                                <small><%#Eval("Precio")%></small>
                            </div>

                            <p class="card-text small mb-2"><%#Eval("TipoServicio")%></p>
                            <asp:Button CssClass="btn btn-primary btn-sm w-100 fw-bold" ID="btnAgregarServicio" runat="server" Text="Agregar Servicio" />
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</div>









  
    <!-- Servicios mas solicitados -->


   

</asp:Content>
