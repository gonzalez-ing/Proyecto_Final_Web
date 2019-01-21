<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="rUsuarios.aspx.cs" Inherits="Proyecto_Final_Web.Registros.rUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        </strong> <font color="BLACK"> <H3> Registro De Usuarios </H3> </font></strong>

        <div class="row">

            <div class="col-xs-2 col-md-2">
                <asp:TextBox ID="UsuarioIdTextBox" runat="server" placeholder="DIGITE ID" CssClass="form-control"></asp:TextBox>

            </div>
            <asp:Button ID="BuscarButton" CssClass="btn btn-primary" runat="server" Text="Buscar" />

        </div>
    </div>
    <div class="form-group">
        <div class="col-xs-3 col-md-3">
            <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>

            <asp:TextBox ID="NombreTextBox" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="form-group">
        <div class="col-xs-3 col-md-3">
            <asp:Label ID="Label3" runat="server" Text="Usuario"></asp:Label>

            <asp:TextBox ID="UsuarioTextBox" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="form-group">
        <div class="col-xs-3 col-md-3">
            <asp:Label ID="Label4" runat="server" Text="Clave"></asp:Label>

            <asp:TextBox ID="ClaveTextBox" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="form-group">

        <asp:Button ID="NuevoButton" CssClass="btn btn-primary" runat="server" Text="Nuevo" Width="90px" />
        <asp:Button ID="GuardarButton" CssClass="btn btn-success" runat="server" Text="Guardar" Width="90px" />
        <asp:Button ID="EliminarButton" CssClass="btn btn-danger" runat="server" Text="Eliminar" Width="90px" />

    </div>



</asp:Content>
