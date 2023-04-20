<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cuentas.aspx.cs" Inherits="WebApp_Hospital.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    <h1 class="page-title">Cuentas</h1>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    

    <h2 class="bienvenido">Mis Cuentas</h2>
    <p>Detalle de las cuentas en el hospital</p>

    <div class="detalle-cuentas-container d-flex flex-wrap justify-content-around pt-4 pb-4">
        <div class="card m-lg-2" style="width: 22rem; height: 15rem;">
            <div class="card-body">
                <div class="row">
                    <div class="cuenta-title d-flex align-items-center">
                        <h2 class="card-text mr-3"><strong>CU-001</strong></h2>
                        <p class="estado-pago">Activa</p>
                    </div>
                    <div class="col-md-7 lh-lg">
                        
                        <p class="card-text"><strong>Balance:</strong></p>
                        <p class="card-text"><strong>Paciente:</strong></p>
                        <p class="card-text"><strong>Fecha:</strong></p>
                        <p class="card-text"><strong>Último movimiento:</strong></p>
                        <a href="#" class="card-link small"><strong>Ver Detalle</strong></a>
                    </div>
                    <div class="col-md-5 lh-lg">
                        
                        <p class="card-text">$500.00</p>
                        <p class="card-text">John Doe</p>
                        <p class="card-text">10/04/2023</p>
                        <p class="card-text">03/04/2023</p>
                        <a href="#" class="card-link btn btn-primary">Pagar</a>
                    </div>
                </div>
            </div>

        </div>



         
    </div>






</asp:Content>
