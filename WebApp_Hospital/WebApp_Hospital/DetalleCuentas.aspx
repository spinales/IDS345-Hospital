<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleCuentas.aspx.cs" Inherits="WebApp_Hospital.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    <h1 class="page-title">Detalle Cuentas</h1>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-4">
            <div class="search-container">
                <div class="row">
                    <div class="col-md-12 mb-2">
                        <asp:DropDownList CssClass="mb=1" ID="ddlCuentas" runat="server"></asp:DropDownList>
                    </div>

                    <div class="col-md-8">
                        <asp:TextBox CssClass="w-100 h-100" ID="txtBuscar" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-4">
                        <asp:Button CssClass="btn btn-primary w-100 btnBuscar" ID="btnBuscar" runat="server" Text="Button" />
                    </div>
                </div>
            </div>

            <div class="detalles-container mt-4">
                <div class="list-group">
                    <a href="#" class="list-group-item list-group-item-action" aria-current="true">
                        <div class="d-flex w-100 justify-content-between">
                            <h6 class="mb-1">Descripción Transaccion</h6>
                            <small class="estado-cargo">Cargo</small>
                        </div>
                        <p class="mb-1 small">CU: cuenta </p>
                        <small class="fw-bold">Monto</small>
                    </a>


                </div>
            </div>

        </div>

        <div class="col-md-8 ml-3">

            <!-- detalle movimiento -->
            <div class="detalle-movimiento">
                <div class="container mt-6 mb-7">
                    <div class="row justify-content-center">
                        <div class="col-lg-12 ">
                            <div class="card">
                                <div class="card-body px-3 py-1">

                                    <div class="border-top border-gray-200 pt-4 mt-4">
                                        <div class="row">
                                            <div class="col-md-6">
                                                <div class="text-muted mb-2">Payment No.</div>
                                                <strong>#88305</strong>
                                            </div>
                                            <div class="col-md-6 text-md-end">
                                                <div class="text-muted mb-2">Payment Date</div>
                                                <strong>Feb/09/20</strong>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="border-top border-gray-200 mt-4 py-4">
                                        <div class="row">
                                            <div class="col-md-6">
                                                <div class="text-muted mb-2">Client</div>
                                                <strong>John McClane
                                                </strong>
                                                <p class="fs-sm">
                                                    989 5th Avenue, New York, 55832
                    <br>
                                                </p>
                                            </div>
                                            <div class="col-md-6 text-md-end">
                                                <div class="text-muted mb-2">Payment To</div>
                                                <strong>Themes LLC
                                                </strong>
                                                <p class="fs-sm">
                                                    9th Avenue, San Francisco 99383
                    <br>
                                                </p>
                                            </div>
                                        </div>
                                    </div>

                                    <table class="table border-bottom border-gray-200 mt-3">
                                        <thead>
                                            <tr>
                                                <th scope="col" class="fs-sm text-dark text-uppercase-bold-sm px-0">Description</th>
                                                <th scope="col" class="fs-sm text-dark text-uppercase-bold-sm text-end px-0">Amount</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td class="px-0">Theme customization</td>
                                                <td class="text-end px-0">$60.00</td>
                                            </tr>

                                        </tbody>
                                    </table>


                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- detalle movimiento -->

            <!-- Pagar Cuenta -->
            <div class="pagar-cuenta bg-white mx-3">
                <div class="row">
                    <div class="col-md-5 d-flex align-items-center justify-content-center">
                        <div class="cuenta-title d-flex align-items-center flex-column">
                            <h2 class="card-text mb-3"><strong>CU-001</strong></h2>
                            <p class="estado-pago mb-3">Activa</p>

                            <asp:Button CssClass="btn btn-primary flex-grow-1" ID="btnPagar" runat="server" Text="Pagar Cuenta" />
                        </div>



                    </div>
                    <div class="col-md-7">
                        <div class="card-body small">
                            <div class="row">

                                <div class="col-md-7 lh-lg">

                                    <p class="card-text"><strong>Balance:</strong></p>
                                    <p class="card-text"><strong>Paciente:</strong></p>
                                    <p class="card-text"><strong>Fecha:</strong></p>
                                    <p class="card-text"><strong>Último movimiento:</strong></p>

                                </div>
                                <div class="col-md-5 lh-lg">

                                    <p class="card-text">$500.00</p>
                                    <p class="card-text">John Doe</p>
                                    <p class="card-text">10/04/2023</p>
                                    <p class="card-text">03/04/2023</p>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Pagar Cuenta -->

        </div>

    </div>




</asp:Content>
