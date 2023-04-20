
<asp:Content ID="Content2" ContentPlaceHolderID="PageTitle" runat="server">
    <h1 class="page-title">Dashboard</h1>
</asp:Content>



<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="WebApp_Hospital.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <p>Bienvenido</p>
    <h3 id="nombre-usuario">Nombre de Usuario</h3>


    <div class="cuentas-container">
        <h4>Cuentas</h4>
        <a href="#">Ver todas</a>

        <div class="cuenta">
        </div>

    </div>

    <div class="ingresos-container">
    </div>


    <div class="ultimaconsulta-container">

        <img src="#" class="img-doctor" alt="Alternate Text" />
        <div class="fecha-hora-container">
            
        </div>
        
    

</asp:Content>
