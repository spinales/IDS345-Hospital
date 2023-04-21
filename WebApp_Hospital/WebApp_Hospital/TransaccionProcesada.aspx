<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TransaccionProcesada.aspx.cs" Inherits="WebApp_Hospital.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
     <h1 class="page-title">Pagos</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

     <div class="card w-50 h-75 mx-auto p-0">
        <div class="card-body mx-auto">
            <div class="container text-center">
                <p class="my-auto mx-auto mb-3" style="font-size: 24px;">¡Transacción Procesada!</p>
                <div class="row text-center">
                    <ul class="list-unstyled">
                        <li class="text-black mb-4">Su transacción se ha realizado con éxito</li>
                        <li class="text-muted mt-1">
                            <i class="fas fa-circle-check fa-2xl" style="color: #25c11a;"></i></li>

                    </ul>

                    <hr>
                    <h3 class="pb-2 pt-2 mb-2">Detalle del Pago</h3>                  
                    <div class="d-flex justify-content-around">
                        <ul class="list-unstyled">
                            <li><p>Número de Factura:</p></li>
                            <li><p>Cuenta:</p></li>
                            <li><p>Fecha de Pago:</p></li>
                            <li><p>Estado Transacción:</p></li>
                             <li><p><strong>Total:</strong></p></li>
                        
                        </ul>

                        <ul class="list-unstyled">
                            <li><asp:Label ID="lblNumeroFactura" runat="server" Text="Label"></asp:Label></li>
                            <li><asp:Label ID="lblCuneta" runat="server" Text="Label"></asp:Label></li>
                            <li><asp:Label ID="lblFechaPago" runat="server" Text="Label"></asp:Label></li>
                            <li><asp:Label ID="lblEstadoTransaccion" runat="server" Text="Label"></asp:Label></li>
                            <li><asp:Label ID="lblTotal" runat="server" Text="Label"></asp:Label></li>
                        
                        </ul>

                       

                        
                    </div>

                     <img src="Design Resources\Images\succes.svg" class="img-fluid w-50 mx-auto" alt="Alternate Text" />
                    
                    
                </div>


            </div>
        </div>
    </div>
</asp:Content>
