<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rUsuarios.aspx.cs" Inherits="Proyecto_Final_Web.Form.rUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
    <link href="../bootstrap.min.css" rel="stylesheet" />
    <script src="https://code.jquery.com/jquery-1.10.2.js"></script>
    <script src="http://code.jquery.com/jquery-1.9.1.min.js" type="text/javascript"></script>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/css/bootstrap.min.css" integrity="sha384-GJzZqFGwb1QTTN6wy59ffF1BuGJpLSa9DkKMp0DgiMDm4iYMj70gZWKYbI706tWS" crossorigin="anonymous">
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/js/bootstrap.min.js" integrity="sha384-B0UglyR+jN6CkvvICOB2joaf5I4l3gm9GU6Hc1og6Ls7i6U/mkkaduKaBhlAXv9k" crossorigin="anonymous"></script>
</head>
<body>

    <form id="form1" runat="server">
        <div class="container ">


            <center> </strong> <font color="BLACK"> <H3> Registro De Usuario </H3> </font> </strong> </center>
            
            <div class="col-md-5 col-sm-2 col-xs-12">
                <div />
            </div>
            <div class="row">

                <div class="col-md-5 col-sm-2 col-xs-12">
                <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label>
                        <asp:Button ID="BuscarButton" CssClass="btn btn-outline-primary" runat="server" Text="Buscar" OnClick="BuscarButton_Click"/>

                    <asp:TextBox ID="UsuarioIdTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                    <div />
                    <div class="col-md-5 col-sm-4 col-xs-12" >

                    </div>
                </div>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>

            <asp:TextBox ID="NombreTextBox" CssClass="form-control" runat="server"></asp:TextBox>
        </div>

        <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="Usuario"></asp:Label>

            <asp:TextBox ID="UsuarioTextBox" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label4" runat="server" Text="Clave"></asp:Label>

            <asp:TextBox ID="ClaveTextBox" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">

            <asp:Button ID="NuevoButton" CssClass="btn btn-primary" runat="server" Text="Nuevo" OnClick="NuevoButton_Click"/>
            <asp:Button ID="GuardarButton" CssClass="btn btn-success" runat="server" Text="Guardar" OnClick="GuardarButton_Click"/>
            <asp:Button ID="EliminarButton" CssClass="btn btn-danger" runat="server" Text="Eliminar" OnClick="EliminarButton_Click"/>

        </div>
        </div>
        </div>
                    
                </div>
            </div>
            </div>
        </div>
    </form>
</body>
</html>
