<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cUsuarios.aspx.cs" Inherits="Proyecto_Final_Web.Consultas.cUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
       <div class="col-md-2">
                    <asp:DropDownList ID="BuscarPorDropDownList" runat="server" CssClass="form-control input-sm" >
                        <asp:ListItem>UsuarioId</asp:ListItem>
                        <asp:ListItem>Nombre</asp:ListItem>
                    </asp:DropDownList>
                </div>
        <div class = " col-md-6 ">
            <asp:TextBox ID="FiltroTextBox" runat="server" CssClass = " form-control input-sm "></asp:TextBox>
        </div>
        <div class=" col-md-1 col-ms-2 col-xs-4">

            <asp:Button ID="BuscarButton" runat="server" Class="btn btn-success input-sm" Text="Buscar" OnClick="BuscarButton_Click" />
        </div>
            <div class=" col-md-12">
        <asp:GridView ID="DatosGridView" runat="server" class=" table table-condensed table-borered table-responsive " CellPadding="4" ForeColor="#333333" GridLines="None"></asp:GridView>

            </div>
    </form>
    
    </div>
</body>
</html>