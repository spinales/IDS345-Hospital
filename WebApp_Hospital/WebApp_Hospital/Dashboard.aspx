
<asp:Content ID="Content2" ContentPlaceHolderID="PageTitle" runat="server">
    <h1 class="page-title">Dashboard</h1>
</asp:Content>



<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="WebApp_Hospital.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <p class="bienvenido">Bienvenido</p>
    <h3 id="nombre-usuario">Nombre de Usuario</h3>

    <div class="col-md-7">
        <div class="cuentas-container">

            <div class="cuentas-container-title">
                <p class="cuentas-title">Cuentas</p>
                <a href="#" class="ver-todas">Ver todas <i class="fas fa-chevron-right"></i></a>
            </div>
            <div class="cuentas-recientes">
                <div class="cuenta">
                </div>
                <div class="cuenta">
                </div>
                <div class="cuenta">
                </div>
                <div class="cuenta">
                </div>
            </div>

        </div>

        <div class="cuentas-container-title">
            
            <h4>Pagos Recientes</h4>
            <a href="#" class="ver-todas">Ver todas <i class="fas fa-chevron-right"></i></a>
            

            <h4 class="pl-5">Cargos Recientes</h4>
            <a href="#" class="ver-todas">Ver todas <i class="fas fa-chevron-right"></i></a>
        </div>

    </div>





    <div class="col-md-3">
        <div class="ingresos-container">
            
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
        </div>
    </div>
    

    <div class="ultimaconsulta-container">

        <img src="#" class="img-doctor" alt="Alternate Text" />
        <div class="fecha-hora-container">
            <asp:Button ID="Button1" runat="server" Text="Button" />
            
        </div>
     </div>   
    

</asp:Content>
