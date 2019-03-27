<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="rProductos.aspx.cs" Inherits="Proyecto_Final_Web.UI.Registros.rProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="card">
        <div class="card-header text-uppercase text-center text-primary">Registro De Producto</div>
        <div class="card-body">
            <div class="row">
                <div class="form-group col-md-2">
                    <asp:Label Text="Id:" class="text-primary" runat="server"></asp:Label>
                    <asp:TextBox ID="ProductoIdTextBox" class="form-control input-group" AutoCompleteType="None" TextMode="Number" placeholder="0" runat="server" />
                    <asp:RequiredFieldValidator ID="RFVProductoId" ValidationGroup="Buscar" ControlToValidate="ProductoIdTextBox" runat="server" ErrorMessage="*" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <asp:LinkButton ID="BuscarLinkButton" ValidationGroup="Buscar" CssClass="btn btn-outline-info mt-4" runat="server" OnClick="BuscarLinkButton_Click">
                        <span> </span> Buscar
                    </asp:LinkButton>
                </div>

            </div>
            <div class="row">
                <div class="form-group col-md-3">
                    <asp:Label Text="Nombre:" runat="server" />
                    <asp:TextBox ID="NombreTextBox" class="form-control input-sm" AutoCompleteType="Disabled" runat="server" placeholder="Nombre"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RFVNombre" ValidationGroup="Guardar" ControlToValidate="NombreTextBox" runat="server" ErrorMessage="*" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="NombreTextBox" ForeColor="Red" Display="Dynamic" ErrorMessage="Porfavor Digite Solo Letras" ValidationExpression="(^[a-zA-Z'.\s]{1,20}$)" ValidationGroup="Guardar"></asp:RegularExpressionValidator>
                </div>
            </div>

            <div class="row">
                <div class="form-group col-md-3">
                    <asp:Label Text="Descripcion:" runat="server" />
                    <asp:TextBox ID="DescripcionTextBox" class="form-control input-sm" AutoCompleteType="Disabled" runat="server" placeholder="Descripcion"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="Guardar" ControlToValidate="DescripcionTextBox" runat="server" ErrorMessage="*" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="DescripcionTextBox" ForeColor="Red" Display="Dynamic" ErrorMessage="Porfavor Digite Solo Letras" ValidationExpression="(^[a-zA-Z'.\s]{1,20}$)" ValidationGroup="Guardar"></asp:RegularExpressionValidator>
                </div>
            </div>

            <div class="form-row">
                <div class="form-group col-md-3">
                    <label for="CostoTextBox">Costo</label>
                    <asp:TextBox ID="CostoTextBox" class="form-control input-sm" AutoCompleteType="Disabled" TextMode="Number" placeholder="Costo" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="CostoTextBox" ValidationGroup="Guardar" runat="server" ErrorMessage="*" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:CustomValidator ID="CostoCustomValidator" runat="server" ControlToValidate="CostoTextBox" ValidationGroup="Guardar" ForeColor="Red" Display="Dynamic" ErrorMessage="El Costo No Puede Ser Mayor Que El Precio"></asp:CustomValidator>
                </div>
            </div>

            <div class="row">
                <div class="form-group col-md-3">
                    <asp:Label Text="Precio:" runat="server" />
                    <asp:TextBox ID="PrecioTextBox" class="form-control input-sm" AutoCompleteType="Disabled" runat="server" MaxLength="11" placeholder="Precio"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ValidationGroup="Guardar" ControlToValidate="PrecioTextBox" runat="server" ErrorMessage="*" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="IdRegularExpressionValidator" runat="server" ControlToValidate="PrecioTextBox" ForeColor="Red" Display="Dynamic" ErrorMessage="Porfavor ingrese un numero" ValidationExpression="(^\d*\.?\d*[0-9]+\d*$)|(^[0-9]+\d*\.\d*$)" ValidationGroup="Guardar"></asp:RegularExpressionValidator>
                </div>
            </div>

            <div class="row">
                <div class="form-group col-md-3">
                    <asp:Label Text="Ganancia:" runat="server" />
                    <asp:TextBox ID="GananciaTextBox" class="form-control input-sm" AutoCompleteType="Disabled" runat="server" MaxLength="11" placeholder="Ganancia"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ValidationGroup="Guardar" ControlToValidate="GananciaTextBox" runat="server" ErrorMessage="*" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="GananciaTextBox" ForeColor="Red" Display="Dynamic" ErrorMessage="Porfavor ingrese un numero" ValidationExpression="(^\d*\.?\d*[0-9]+\d*$)|(^[0-9]+\d*\.\d*$)" ValidationGroup="Guardar"></asp:RegularExpressionValidator>
                </div>
            </div>

            <div class="row">
                <div class="form-group col-md-3">
                    <asp:Label Text="Inventario:" runat="server" />
                    <asp:TextBox ID="InventarioTextBox" class="form-control input-sm" AutoCompleteType="Disabled" runat="server" MaxLength="11" placeholder="Inventario"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ValidationGroup="Guardar" ControlToValidate="InventarioTextBox" runat="server" ErrorMessage="*" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="InventarioTextBox" ForeColor="Red" Display="Dynamic" ErrorMessage="Porfavor ingrese un numero" ValidationExpression="(^\d*\.?\d*[0-9]+\d*$)|(^[0-9]+\d*\.\d*$)" ValidationGroup="Guardar"></asp:RegularExpressionValidator>
                </div>
            </div>

            <div class="card-footer">
                <div class="form-group">
                    <asp:Button class="btn btn-primary" ID="nuevoButton" runat="server" Text="Nuevo" OnClick="nuevoButton_Click" />
                    <asp:Button class="btn btn-success" ValidationGroup="Guardar" ID="guardarButton" runat="server" Text="Guardar" OnClick="guardarButton_Click" />
                    <asp:Button class="btn btn-danger" ID="eliminarutton" runat="server" Text="Eliminar" OnClick="eliminarutton_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
