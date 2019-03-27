<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Proyecto_Final_Web.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div id="carouselExampleSlidesOnly" class="carousel slide" data-ride="carousel">
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img class="d-block w-80" <img src="Resources/Logo.jpg" alt="First slide"/>
    </div>
    <div class="carousel-item">
      <img class="d-block w-80" <img src="Resources/productos-limpieza-basicos.jpg" alt="Second slide"/>
    </div>
    <div class="carousel-item">
      <img class="d-block w-80" <img src="Resources/chat-tay-rua-anh-huong-den-suc-khoe-thai-nhi.jpg" alt="Third slide"/>
    </div>
  </div>
</div>

   <div class="jumbotron jumbotron-fluid">
  <div class="container">
    <h1 class="display-4"> PRODUCTOS GONZALEZ </h1>
    <p class="lead">Es un sistema de venta web para productos de limpieza desarrollado por la Empresa Gonzalez_Ing.</p>
  </div>
</div>

</asp:Content>
