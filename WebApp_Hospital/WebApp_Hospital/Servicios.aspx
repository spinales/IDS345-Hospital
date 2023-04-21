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
    <div class="row">

        <div class="col-md-3 mb-3">
            <div class="card h-100 shadow">
                <div class="bg-image hover-overlay ripple" data-mdb-ripple-color="light">
                    <img src="Design Resources\Images\service.svg" class="img-fluid" />

                </div>
                <div class="card-body">
                    <div class="card-head d-flex justify-content-between">
                        <h5 class="card-title">Card title</h5>
                        <small>Monto</small>
                    </div>

                    <p class="card-text small mb-2">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    <asp:Button CssClass="btn btn-primary btn-sm w-100 fw-bold" ID="btnAgregarServicio" runat="server" Text="Agregar Servicio" />
                </div>
            </div>
        </div>

    </div>
    <!-- Servicios mas solicitados -->

    <h3>Todos los Servicios</h3>

    <!-- Todos los Servicios -->
    <div class="row mt-3">
        <div class="col-md-5">
            <div class="card mb-3" style="max-width: 540px;">
                <div class="row g-0">
                    <div class="col-md-4">
                        <img src="Design Resources\Images\All-Services.svg" class="img-fluid rounded-start pt-3" alt="">
                    </div>
                    <div class="col-md-8">
                        <div class="card-body">
                            <div class="all-service-header d-flex justify-content-between">
                                <h5 class="card-title">Card title</h5>
                                <small>Monto</small>
                                    
                            </div>
                            <p class="card-text small">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                            
                            
                        </div>
                    </div>
                </div>
            </div>

        </div>

        

    </div>
    <!-- Todos los Servicios -->


</asp:Content>
