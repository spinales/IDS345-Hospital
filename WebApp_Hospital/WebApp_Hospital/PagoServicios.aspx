<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PagoServicios.aspx.cs" Inherits="WebApp_Hospital.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    <h1 class="page-title">Servicios</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-7">
            <h3>Carrito</h3>

            <!--Tabla de movimientos de la cuenta-->
            <table class="table align-middle mb-0 bg-white">
                <thead class="bg-light">
                    <tr>
                        <th>Servicio</th>
                        <th>Tipo Servicios</th>
                        <th>Impuesto</th>
                        <th>Monto</th>   
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>
                            <div class="d-flex align-items-center">
                                <img
                                    src="Design Resources\Images\Samples.svg"
                                    alt=""
                                    style="width: 45px; height: 45px"
                                    class="rounded-circle" />
                                <div class="ms-3">
                                    <p class="fw-bold mb-1">
                                        
                                    <p class="text-muted mb-0"><asp:Label ID="lblNombreServicio" runat="server" Text="Label"></asp:Label></p>
                                </div>
                            </div>
                        </td>
                        <td>
                            <p class="fw-normal mb-1"><asp:Label ID="lblTipoServicio" runat="server" Text="Label"></asp:Label></p>
                            
                        </td>
                        <td>
                            <p class="fw-regular mb-1">
                                        <asp:Label ID="lblImpuesto" runat="server" Text="Label"></asp:Label></p>
                        </td>
                        <td><p class="fw-bold mb-1">
                                        <asp:Label ID="lblMonto" runat="server" Text="Label"></asp:Label></p></td>             
                    
                </tbody>
            </table>
            <!--Tabla de movimientos de la cuenta-->
        </div>

        <div class="col-md-4 mx-auto">
            <!-- chechout form -->
            <div class="box-2">
            <div class="box-inner-2">
                <div>
                    <p class="fw-bold  mb-3">Detalles de Pago</p>
                    
                    <p class="dis mb-3">Elija su método de pago y continua con su compra</p>
                </div>
                <form action="">
                   
                    <div>
                        <asp:RadioButton ID="rbTarjeta" runat="server" />
                        <p class="dis fw-bold mb-2 d-inline">Detalles de la tarjeta</p>
                        <div class="d-flex align-items-center justify-content-between card-atm border rounded">
                            <div class="fab fa-cc-visa ps-3"></div>
                            <input type="text" class="form-control border-0" placeholder="Números Tarjeta">
                            <div class="d-flex w-50">
                                <input type="text" class="form-control px-0 mr-3 border-0 border-0 rounded-0" placeholder="mm/yy">
                                <input type="password" maxlength=3 class="form-control px-3 border-0 rounded-0" placeholder="cvv">
                            </div>
                        </div>
                        <div class="my-3 cardname">
                            <p class="dis fw-bold mb-2">Nombre de la Tarjeta</p>
                            <input class="form-control border-0" type="text">
                        </div>

                        <hr />

                        <div class="cuenta-pagar">
                            <asp:RadioButton ID="rbCuenta" runat="server" />
                            <p class="fw-bold d-inline mb-2">Elija la Cuenta</p>
                            <asp:DropDownList ID="DropDownList1" CssClass="border-0 rounded mb-2" Width="300px" Height="40px" runat="server"></asp:DropDownList>


                            

                            <hr />
                            
                        </div>
                       
                           
                            <div class="d-flex flex-column dis">
                                <div class="d-flex align-items-center justify-content-between mb-2">
                                    <p>Subtotal</p>
                                    <p><span class="fas fa-dollar-sign"></span><p class="fw-regular mb-1">
                                        <asp:Label ID="lblSubtotal" runat="server" Text="Label"></asp:Label></p></p>
                                </div>
                                <div class="d-flex align-items-center justify-content-between mb-2">
                                    <p>Impuestos</p>
                                    <p><span class="fas fa-dollar-sign"></span><p class="fw-regular mb-1">
                                        <asp:Label ID="lblSumaIMpuestos" runat="server" Text="Label"></asp:Label></p></p>
                                </div>
                                <div class="d-flex align-items-center justify-content-between mb-2">
                                    <p class="fw-bold">Total</p>
                                    <p class="fw-bold"><span class="fas fa-dollar-sign"></span><p class="fw-bold mb-1">
                                        <asp:Label ID="lblTotal" runat="server" Text="Label"></asp:Label></p></p>
                                </div>
                                <div class="btn btn-primary mt-2">Pagar<span class="fas fa-dollar-sign px-1"></span><p class="fw-bold mb-1 d-inline">
                                        <asp:Label ID="lblCuenta" runat="server" Text="Label"></asp:Label></p>
                                </div>
                            </div>
                        </div>
                    </div>
                </form>
            </div>
        </div>
    </div>
            <!-- chechout form -->

        
</asp:Content>
