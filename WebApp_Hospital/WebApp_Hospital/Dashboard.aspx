<asp:Content ID="Content2" ContentPlaceHolderID="PageTitle" runat="server">
    <h1 class="page-title">Dashboard</h1>
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="WebApp_Hospital.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <p class="bienvenido">Bienvenido</p>
    <h3 id="nombre-usuario">Nombre de Usuario</h3>

    <div class="row">
        <div class="col-md-7">
            <div class="cuentas-container">

                <div class="cuentas-container-title">
                    <p class="cuentas-title">Cuentas</p>
                    <a href="#" class="ver-todas">Ver todas <i class="fas fa-chevron-right"></i></a>
                </div>
                <div class="cuentas-recientes">

                    <asp:Repeater ID="CuentasRepeater" runat="server">
                        <ItemTemplate>
                            <div class="container">
                                <div class="cuenta">

                                    <div class="cuenta-info">

                                        <div class="d-flex justify-content-around align-items-center flex-row-reverse">
                                            <div class="profile-pic" style="margin-left: 0"></div>
                                            <h5><%# Eval("Nombre") %></h5>
                                            <h6>CU-<%#Eval("Cuenta") %></h6>
                                            <p><%#Eval("Estado") %></p>
                                        </div>

                                    </div>

                                </div>

                            </div>
                        </ItemTemplate>
                    </asp:Repeater>


                </div>

            </div>


            <div class="transacciones-recientes">
                <!-- Pagos recientes -->
                <div class="pagos-recientes">
                    <div class="pagos-recientes-title">
                        <h4>Pagos Recientes</h4>
                        <a href="#" class="ver-todas">Ver todas <i class="fas fa-chevron-right"></i></a>
                    </div>
                    <div class="cuenta">
                        <div class="cuenta-transaccion-container">
                            <p class="desc-transaccion">Descripción Transacción</p>
                            <p class="monto">Monto</p>
                            <p class="estado-pago">Pago</p>
                        </div>
                    </div>

                </div>

                <!-- Cargos recientes -->
                <div class="pagos-recientes">
                    <div class="pagos-recientes-title">
                        <h4>Cargos Recientes</h4>
                        <a href="#" class="ver-todas">Ver todas <i class="fas fa-chevron-right"></i></a>
                    </div>
                    <div class="cuenta">
                        <div class="cuenta-transaccion-container">
                            <p class="desc-transaccion">Descripción Transacción</p>
                            <p class="monto">Monto</p>
                            <p class="estado-cargo">Cargo</p>
                        </div>
                    </div>

                </div>
            </div>
        </div>

        <div class="col-md-5">
            <div class="ingresos-container">
                <table class="table">
                    <thead>
                    <tr>
                        <th scope="col">Ingresos y Altas</th>
                    </tr>
                    </thead>
                    <tbody>
                    <tr>
                        <th scope="row">Ingreso</th>
                        <td>09/09/2019</td>
                    </tr>
                    <tr>
                        <th scope="row">Alta</th>
                        <td>23/09/2007</td>
                    </tr>
                    <tr>
                        <th scope="row">Ingreso</th>
                        <td>24/09/2006</td>
                    </tr>
                    </tbody>
                </table>
            </div>

            <div class="ultima-consulta-container">
                <h4>Ultima Consulta</h4>
                <div class="cuenta">

                    <div class="doctor d-flex align-content-center mb-4 mt-2">
                        <div class="profile-pic"></div>
                        <div class="doc-info">
                            <h4>Nombre Doctor</h4>
                            <p>Especialidad</p>
                        </div>
                    </div>

                    <div class="d-grid gap-2 col-11 mx-auto">
                        <asp:Button ID="btnAgendarConsulta" class="btn btn-primary w-100" runat="server" Text="Agendar Consulta" OnClick="btnAgendarConsulta_Click"/>

                    </div>

                </div>
            </div>

        </div>

    </div>


</asp:Content>