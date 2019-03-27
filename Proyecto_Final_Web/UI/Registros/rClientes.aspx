<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="rClientes.aspx.cs" Inherits="Proyecto_Final_Web.UI.Registros.rClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <%--Esto es para que funcione el ajaxtoolkit--%> 
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager> 
    <div class="card mx-auto mt-5">
        <div class="card-header text-uppercase text-center text-primary">Registro De Clientes</div>
        <div class="card-body">
            <div class="form-row">
                <div class="form-group">
                    <div class="form-row">

                        <div class="col-xs-10 col-md-5">
                            <asp:TextBox ID="ClienteIdTextBox" runat="server" placeholder="Cliente Id" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class=" col- col-sm- 3 col-md-3 col-xs-3">
                            <asp:Button ID="BuscarButton" CssClass="btn btn-primary" runat="server" Text="Buscar" OnClick="BuscarButton_Click"  />
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-xs-10 col-md-5">
                <asp:Label Text="Nombre:" runat="server" />
                <asp:TextBox ID="NombreTextBox" type="text" runat="server" CssClass="form-control " placeholder="Ingrese un Nombre " minlength="4" MaxLength="40"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="NombreTextBox" ValidationGroup="Guardar" runat="server" ErrorMessage="*" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
            </div>

        <div class="row">
            <div class="col-xs-10 col-md-5">
                <asp:Label Text="Cedula:" runat="server" />
                <asp:TextBox ID="CedulaTextBox" class="form-control input-sm" AutoCompleteType="Disabled" runat="server" MaxLength="11" placeholder="Cedula"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="Guardar" ControlToValidate="CedulaTextBox" runat="server" ErrorMessage="*" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="IdRegularExpressionValidator" runat="server" ControlToValidate="CedulaTextBox" ForeColor="Red" Display="Dynamic" ErrorMessage="Porfavor ingrese un numero De Cedula" ValidationExpression="(^\d*\.?\d*[0-9]+\d*$)|(^[0-9]+\d*\.\d*$)" ValidationGroup="Guardar"></asp:RegularExpressionValidator>
            </div>
             </div>

            <div class="col-xs-10 col-md-5">
                <asp:Label Text="Direccion" runat="server" />
                <asp:TextBox ID="DireccionTextBox" class="form-control input-sm" AutoCompleteType="Disabled" runat="server" placeholder="Direccion"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ValidationGroup="Guardar" ControlToValidate="DireccionTextBox" runat="server" ErrorMessage="*" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
            </div>

       <div class="col-xs-10 col-md-5">
            <asp:Label Text="Télefono" runat="server" />
            <asp:TextBox ID="TelefonoTextBox" class="form-control input-sm" AutoCompleteType="Disabled" runat="server" TextMode="Phone" MaxLength="10" placeholder="Telefono"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ValidationGroup="Guardar" ControlToValidate="TelefonoTextBox" runat="server" ErrorMessage="*" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TelefonoTextBox" ForeColor="Red" Display="Dynamic" ErrorMessage="Porfavor ingrese un numero" ValidationExpression="(^\d*\.?\d*[0-9]+\d*$)|(^[0-9]+\d*\.\d*$)" ValidationGroup="Guardar"></asp:RegularExpressionValidator>
        </div>

       <div class="col-xs-10 col-md-5">
            <asp:Label Text="Fecha" runat="server" />
            <asp:TextBox ID="FechaTextBox" class="form-control input-group" runat="server" />
            <ajaxtoolkit:calendarextender id="CalendarExtender1" targetcontrolid="FechaTextBox" format="yyyy-MM-dd" runat="server" />
            <asp:RequiredFieldValidator ID="RFVFFecha" ValidationGroup="Guardar" ControlToValidate="FechaTextBox" runat="server" ErrorMessage="*" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>

        <div class="col-md-4 col-md-offset-3">
            <div class="card-footer">
                <div class="form-group">
                    <asp:Button class="btn btn-primary" ID="nuevoButton" runat="server" Text="Nuevo" OnClick="nuevoButton_Click"  />
                    <asp:Button class="btn btn-success" ValidationGroup="Guardar" ID="guardarButton" runat="server" Text="Guardar" OnClick="guardarButton_Click"  />
                    <asp:Button class="btn btn-danger" ID="eliminarutton" runat="server" Text="Eliminar" OnClick="eliminarutton_Click"  />
                </div>
            </div>
        </div>
        </div>
    </div>
</asp:Content>
