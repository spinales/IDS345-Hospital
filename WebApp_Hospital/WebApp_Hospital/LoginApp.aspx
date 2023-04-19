<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginApp.aspx.cs" Inherits="WebApp_Hospital.LoginApp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    

    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>

    <webopt:bundlereference runat="server" path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />

    <!-- Fonts -->
    <link rel="preconnect" href="https://fonts.googleapis.com"/>
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin/>
    <link href="https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,100;0,300;0,400;0,500;0,700;0,900;1,100;1,300;1,400;1,500;1,700;1,900&display=swap" rel="stylesheet"/>

    <link rel="stylesheet" href="Styles.css" />
</head>


<body class="login-body">
    <form id="form1" runat="server">
        <div class="container-fluid p-0 m-0 d-flex flex-column">
        <div class="row">
            <div class="col-md-6 "><img id="LoginImg" alt="Imagen de Login" src="Design Resources\Images\Login_Img.png" class="img-fluid login-img"/></div>

            <div class="col-md-6 p-0 m-0">
                <div class="Login-Form">

                    <h1 class="Bienvenido-Login">Bienvenido de nuevo</h1>
                    <p class="p-login">Inicia Sesión para acceder a la aplicación</p>

                    <asp:Login ID="Login1" runat="server" CssClass="w-100">
                     <LayoutTemplate>
               
                    <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Usuario</asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>                   

                    <br />
                                    
                    <asp:TextBox ID="UserName" runat="server" CssClass="txtUserData"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Contraseña:</asp:Label>
                                    
                    <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>                   

                    <br />
                                    
                    <asp:TextBox ID="Password" runat="server" TextMode="Password" CssClass="txtUserData"></asp:TextBox>
                    <br />
                    <br />

                    <asp:Button CssClass="btn btn-lg btn-primary btnIniciarSesion" ID="LoginButton" runat="server" CommandName="Login" Text="Iniciar Sesión" ValidationGroup="Login1"/>

                 </LayoutTemplate>
                 </asp:Login>

                </div>
                

            </div>
        </div>
    </div>
    </form>

    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/Scripts/bootstrap.js") %>
    </asp:PlaceHolder>


</body>
</html>
