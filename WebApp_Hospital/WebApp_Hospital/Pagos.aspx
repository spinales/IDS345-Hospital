<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pagos.aspx.cs" Inherits="WebApp_Hospital.WebForm6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    <h1 class="page-title">Pagos</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-7">
            <h3>Pago de Cuentas</h3>

            <!--Tabla de movimientos de la cuenta-->
            <table class="table align-middle mb-0 bg-white">
                <thead class="bg-light">
                    <tr>
                        <th>Cuenta</th>
                        <th>Movimiento</th>
                        <th>Tipo</th>
                        <th>Monto</th>   
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>
                            <div class="d-flex align-items-center">
                                <img
                                    src="https://mdbootstrap.com/img/new/avatars/8.jpg"
                                    alt=""
                                    style="width: 45px; height: 45px"
                                    class="rounded-circle" />
                                <div class="ms-3">
                                    <p class="fw-bold mb-1">CU-001</p>
                                    <p class="text-muted mb-0">Allen Silverio</p>
                                </div>
                            </div>
                        </td>
                        <td>
                            <p class="fw-normal mb-1">Pago Hemograma</p>
                            
                        </td>
                        <td>
                            <span class="badge badge-success rounded-pill d-inline estado-cargo">Cargo</span>
                        </td>
                        <td>1500$</td>             
                    
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
                    <p class="dis mb-3">Complete su pago al proveer los siguientes datos</p>
                </div>
                <form action="">
                   
                    <div>
                        <p class="dis fw-bold mb-2">Detalles de la tarjeta</p>
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
                            <p class="fw-bold  mb-2">Elija la Cuenta</p>
                            <asp:DropDownList ID="DropDownList1" CssClass="border-0 rounded mb-2" Width="300px" Height="40px" runat="server"></asp:DropDownList>


                            <div class="d-flex">
                                <asp:CheckBox ID="chbPagarTotal" CssClass="form-check-input mr-3 border-0" runat="server" />
                                <p class="mb-2">Pagar Balance Total</p>
                            </div>

                            <hr />
                            
                        </div>
                       
                           
                            <div class="d-flex flex-column dis">
                                <div class="d-flex align-items-center justify-content-between mb-2">
                                    <p>Subtotal</p>
                                    <p><span class="fas fa-dollar-sign"></span>33.00</p>
                                </div>
                                <div class="d-flex align-items-center justify-content-between mb-2">
                                    <p>Impuestos</p>
                                    <p><span class="fas fa-dollar-sign"></span>2.80</p>
                                </div>
                                <div class="d-flex align-items-center justify-content-between mb-2">
                                    <p class="fw-bold">Total</p>
                                    <p class="fw-bold"><span class="fas fa-dollar-sign"></span>35.80</p>
                                </div>
                                <asp:Button ID="Button1" runat="server" Text="Pagar" CssClass="btn btn-primary mt-2 w-100" OnClick="Button1_Click" /><span class="fas fa-dollar-sign px-1"></span>
                                
                            </div>
                        </div>
                    </div>
                </form>
            </div>
        </div>
    </div>
            <!-- chechout form -->

        



   



</asp:Content>
