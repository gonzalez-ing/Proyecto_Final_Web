<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="rVentas.aspx.cs" Inherits="Proyecto_Final_Web.UI.Registros.rVentas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <div class="card card-register mx-auto mt-5">
        <div class="card-header text-uppercase text-center text-primary"> Facturacion </div>
        <div class="card-body">
            <div class="form-row">
                <div class="form-group col-md-1">
                    <asp:Label Text="Id:" class="text-primary" runat="server" />
                    <asp:TextBox ID="FacturaIdTextBox" class="form-control input-sm" TextMode="Number" runat="server" placeholder="0"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RFVId" ValidationGroup="Buscar" ControlToValidate="FacturaIdTextBox" runat="server" ErrorMessage="*" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
        
            <div class="col-lg-1 p-0">
                <asp:LinkButton ID="BuscarLinkButton" ValidationGroup="Buscar" CssClass="btn btn-outline-info mt-4" runat="server" OnClick="BuscarLinkButton_Click">
                 <span class="fas fa-search"></span> Buscar
                </asp:LinkButton>
            </div>
                </div>
            <div class="form-row">
                <div class="form-group col-md-2">
                    <asp:Label Text="Fecha:" runat="server" />
                    <asp:TextBox ID="FechaTextBox" class="form-control input-sm" TextMode="Date" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RFVFFecha" ValidationGroup="Guardar" ControlToValidate="FechaTextBox" runat="server" ErrorMessage="*" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-3">
                    <asp:Label Text="Cliente:" runat="server" />
                    <asp:DropDownList ID="ClienteDropDownList" AutoPostBack="true" class="form-control input-sm" runat="server">
                        <asp:ListItem Selected="True">[Seleccione]</asp:ListItem>
                    </asp:DropDownList>
                    <asp:CustomValidator ID="CVClientes" runat="server" ErrorMessage="Seleccione Un Cliente" ControlToValidate="ClienteDropDownList" ValidationGroup="Guardar" ForeColor="Red" Display="Dynamic"></asp:CustomValidator>
                </div>
            </div>

            <div class="form-row">
                <div class="form-group col-md-3">
                    <asp:Label Text="Producto:" runat="server" />
                    <asp:DropDownList ID="ProductoDropDownList" AppendDataBoundItems="true" OnSelectedIndexChanged="ProductoDropDownList_SelectedIndexChanged" AutoPostBack="true" class="form-control input-sm" runat="server">
                        <asp:ListItem Selected="True">[Seleccione]</asp:ListItem>
                    </asp:DropDownList>
                    <asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage="Seleccione Un Producto" ControlToValidate="ProductoDropDownList" ValidationGroup="Guardar" ForeColor="Red" Display="Dynamic"></asp:CustomValidator>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-1">
                    <asp:Label Text="Importe:" runat="server" />
                    <asp:TextBox ID="ImporteTextBox" OnTextChanged="ImporteTextBox_TextChanged" class="form-control input-sm" AutoPostBack="true" AutoCompleteType="Disabled" ReadOnly="true" runat="server" placeholder="0"></asp:TextBox>
                </div>

                <div class="form-group col-md-1">
                    <asp:Label Text="Precio:" runat="server" />
                    <asp:TextBox ID="PrecioTextBox" class="form-control input-sm" AutoPostBack="true" ReadOnly="true" TextMode="Number" runat="server" placeholder="0"></asp:TextBox>
                </div>

                    <div class="form-group col-md-1">
                        <asp:Label Text="Cantidad:" runat="server" />
                        <asp:TextBox ID="CantidadTextBox" class="form-control input-sm" AutoPostBack="true" AutoCompleteType="Disabled" TextMode="Number" runat="server" placeholder="0"></asp:TextBox>
                    </div>

                <div class="col-lg-1 p-0">
                    <asp:LinkButton ID="LinkButton" CssClass="btn btn-outline-success mt-4" ValidationGroup="Agregar" runat="server" OnClick="LinkButton_Click">
                                <span class="fa fa-plus"></span>
                                     Agregar
                    </asp:LinkButton>
                </div>
            
                    <div class="form-group col-md-1">
                        <asp:Label ID="Label5" runat="server" Text="Total:"></asp:Label>
                        <asp:TextBox ID="TotalTextBox" type="text" runat="server" TextMode="Number" ReadOnly="true" CssClass="form-control " placeholder="0.00"></asp:TextBox>
                    </div>
                </div>
          
            <div class="form-row">
                <asp:GridView ID="DetalleGridView" CssClass=" col-md-offset-4 col-sm-offset-4" runat="server" CellPadding="4" ForeColor="Black" GridLines="None" Width="244px" AutoGenerateColumns="false" BackColor="#FF9966">
                    <AlternatingRowStyle BackColor="white" />
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Id" />
                        <asp:BoundField DataField="ProductoId" HeaderText="Producto" />
                        <asp:BoundField DataField="Precio" HeaderText="Precio" />
                        <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" />
                        <asp:BoundField DataField="Importe" HeaderText="Importe" />
                    </Columns>

                </asp:GridView>
            </div>
        </div>
        <div class="col-md-4 col-md-offset-3">
                <div class="form-group">
                    <asp:Button class="btn btn-primary" ID="nuevoButton" ValidationGroup="Nuevo" runat="server" Text="Nuevo" />
                    <asp:Button class="btn btn-success" ValidationGroup="Guardar" ID="guardarButton" runat="server" Text="Guardar" OnClick="guardarButton_Click" />
                    <asp:Button class="btn btn-danger" ID="eliminarutton" ValidationGroup="Buscar" runat="server" Text="Eliminar" OnClick="eliminarutton_Click" />
                </div>
            </div>
        </div>
</asp:Content>
