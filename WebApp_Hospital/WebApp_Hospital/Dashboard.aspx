
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

                    
                            <div class="cuenta">

                                <div class="cuenta-info">
                                    <div class="profile-pic"></div>
                                    <h5>PacienteID</h5>
                                    <h6>CuentaID</h6>
                                    <p>Estado</p>
                                </div>

                            </div>
                        

                    

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
                            <th scope="row">1</th>
                            <td>Mark</td>
                        </tr>
                        <tr>
                            <th scope="row">2</th>
                            <td>Jacob</td>
                        </tr>
                        <tr>
                            <th scope="row">3</th>
                            <td>Larry</td>
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
                        <button type="button" class="btn btn-primary">Agendar Consulta</button>
                    </div>

                </div>
            </div>

        </div>

    </div>







</asp:Content>
