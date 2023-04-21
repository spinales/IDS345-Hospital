<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Consultas.aspx.cs" Inherits="WebApp_Hospital.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    <h1 class="page-title">Consultas</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class ="col-md-4">
            <h3>Busca tu doctor, factura una consulta</h3>
            <p class="mb-2">Doctor</p>
            <asp:DropDownList CssClass="border-0 shadow" Width="300px" Height="30px"  ID="DropDownList1" runat="server"></asp:DropDownList>

            <div class="doc-info">
                <img alt="" src="Design Resources\Images\doc.png" class="img-fluid rounded-start pt-3 w-50 mb-4" />
                <h3 class="">Nombre Doctor</h3>
                <p>Especialidad</p>
            </div>
            
        </div>

         <div class ="col-md-3 ">

             <div class="form-container text-center d-flex justify-content-center flex-column">
                 <h3>Nueva Consulta</h3>
             
             <p class="mb-2">Fecha</p>
             <asp:Calendar ID="Calendar1" CssClass="mx-auto pb-2" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px">
                 <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                 <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                 <OtherMonthDayStyle ForeColor="#999999" />
                 <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                 <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                 <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                 <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                 <WeekendDayStyle BackColor="#CCCCFF" />
             </asp:Calendar>
             <h5 class="pt-3">Comentario</h5>
             <asp:TextBox TextMode="MultiLine" Width="300px" ID="TextBox1" runat="server" CssClass="border-0 rounded shadow"></asp:TextBox>
             </div>
            
        </div>

        <div class="col-md-4 text-center">
            <h3>Factura tu Consulta</h3>
            <img alt="" src="Design Resources\Images\pana.svg" class="img-fluid rounded-start pt-5 w-75 mb-4" />
            <asp:Button ID="btnFacturarConsulta" CssClass="btn btn-primary w-100 shadow" runat="server" Text="Facturar Consulta" />
        </div>

    </div>
</asp:Content>
