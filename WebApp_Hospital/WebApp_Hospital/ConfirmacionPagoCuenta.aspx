<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConfirmacionPagoCuenta.aspx.cs" Inherits="WebApp_Hospital.WebForm7" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    <h1 class="page-title">Pagos</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="card w-50 h-75 mx-auto p-0">
        <div class="card-body mx-auto">
            <div class="container">
                <p class="my-auto mx-auto mb-3" style="font-size: 24px;">Confirmación de Pago</p>
                <div class="row">
                    <ul class="list-unstyled">
                        <li class="text-black">Método de Pago</li>
                        <li class="text-muted mt-1">
                            <img src="Design Resources\Images\visa.svg" class="img-fluid rounded-start pt-2 w-25 mb-2" alt="Alternate Text" /></li>
                        
                    </ul>
                    <hr>
                    <div class="col-xl-10">
                        <p>Pro Package</p>
                    </div>
                    <div class="col-xl-2">
                        <p class="float-end">
                            $199.00
                        </p>
                    </div>
                   
                </div>
                <div class="row">
                    <div class="col-xl-10">
                        <p>Consulting</p>
                    </div>
                    <div class="col-xl-2">
                        <p class="float-end">
                            $100.00
                        </p>
                    </div>
                  
                </div>
                <div class="row">
                    <div class="col-xl-10">
                        <p>Support</p>
                    </div>
                    <div class="col-xl-2">
                        <p class="float-end">
                            $10.00
                        </p>
                    </div>
                    
                </div>
                <div class="row text-black">

                    <div class="col-xl-12">
                        <p class="float-end fw-bold">
                            Total: $10.00
                        </p>
                    </div>
                   
                </div>
                

            </div>
        </div>
    </div>
</asp:Content>
