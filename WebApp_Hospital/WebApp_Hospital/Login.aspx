
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApp_Hospital.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Content ID="Content2" ContentPlaceHolderID="HeadCustomContent" runat="server">
    <style type="text/css">
        .navbar {
            display: none;
        }
    </style>
</asp:Content>
 
    <!-- Imagen de Login -->

    <img id="LoginImg" alt="Imagen de Login" src="\Images\LoginImg.png" />

    <h1>Bienvenido de Nuevo</h1>
    <p>Inicia Sesión para acceder a la aplicación</p>
    <p>
        <asp:Login ID="Login1" runat="server">
            <LayoutTemplate>
               
                    <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Usuario</asp:Label>
                    <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                    <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Contraseña:</asp:Label>
                                    
                    <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>                   

                    <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Iniciar Sesión" ValidationGroup="Login1" />

            </LayoutTemplate>
        </asp:Login>
    </p>


</asp:Content>


