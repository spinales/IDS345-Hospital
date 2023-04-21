<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConfirmacionPagoCuenta.aspx.cs" Inherits="WebApp_Hospital.WebForm7" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    <h1 class="page-title">Pagos</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="card w-50 h-75 mx-auto p-0">
        <div class="card-body mx-auto text-center">
            <div class="container">
                <p class="my-auto mx-auto mb-3" style="font-size: 24px;">Confirmación de Pago</p>
                <div class="row text-center">
                    <ul class="list-unstyled">
                        <li class="text-black">Método de Pago</li>
                        <li class="text-muted mt-1">
                            <img src="Design Resources\Images\visa.svg" class="img-fluid rounded-start pt-2 w-25 mb-2" alt="Alternate Text" /></li>

                    </ul>

                    <hr>
                    <h3 class="pb-2 pt-2">¿Estas seguro que quieres pagar <asp:Label ID="lblMonto" runat="server" Text="Label"></asp:Label> Pesos a la cuenta <asp:Label ID="lblCuenta" runat="server" Text="Label"></asp:Label>?</h3>                  
                    <div class="d-flex justify-content-between">
                        <asp:Button ID="btnAcepar" runat="server" Text="Aceptar" Width="250px" CssClass="btn btn-primary"/>
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar"  Width="250px"/>
                    </div>
                    
                    
                </div>


            </div>
        </div>
    </div>
</asp:Content>
