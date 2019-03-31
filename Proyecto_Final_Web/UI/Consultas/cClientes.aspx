<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="cClientes.aspx.cs" Inherits="Proyecto_Final_Web.UI.Consultas.cClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=15.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

     <div <h2 class="card-header text-uppercase text-center text-primary"> Consulta De Clientes </h2> </div>
    <div class="form-row">

        <div class="form-group ">
            <asp:Label Text="Desde:" runat="server" />
            <asp:TextBox ID="DesdeTextBox" class="form-control input-group" TextMode="Date" runat="server" />
        </div>
        <div class="form-group ">
            <asp:Label Text="Hasta:" runat="server"></asp:Label>
            <asp:TextBox ID="HastaTextBox" class="form-control input-group" TextMode="Date" runat="server" />

        </div>
        <div class="form-group ">
            <asp:Label Text="Seleccione:" runat="server" />
            <asp:DropDownList ID="BuscarPorDropDownList" runat="server" CssClass="form-control input-group">
                <asp:ListItem>Todos</asp:ListItem>
                <asp:ListItem>Cliente Id</asp:ListItem>
                <asp:ListItem>Fecha</asp:ListItem>
                <asp:ListItem>Nombre</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="form-group ">
            <asp:Label Text="Filtro:" runat="server" />
            <asp:TextBox ID="FiltroTextBox" runat="server" CssClass=" form-control input-group "></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label Text="Buscar:" runat="server" />
            <asp:Button ID="BuscarButton" runat="server" Class="btn btn-success input-group" Text="Buscar" OnClick="BuscarButton_Click" />
        </div>

        <div class="form-group">
             <asp:Label Text="Imprimir:" runat="server" />
            <button type="button" class="btn btn-outline-info input-group" data-toggle="modal" data-target=".bd-example-modal-lg">Imprimir </button>

        </div>
    </div>
    <div class="form-group">
        <div class="form-row justify-content-center">
            <asp:GridView ID="DatosGridView" runat="server" class="table table-condensed table-bordered table-responsive" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="SkyBlue" />
                <Columns>
                    <asp:BoundField DataField="ClienteId" HeaderText="Cliente Id" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="Cedula" HeaderText="Cedula " />
                    <asp:BoundField DataField="Direccion" HeaderText="Direccion" />               
                    <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
                    <asp:BoundField DataField="Fecha" HeaderText="Fecha " />           
                </Columns>
            </asp:GridView>
        </div>
    </div>

    <%-- esta es la parte del modal --%>
    <div class="modal fade bd-example-modal-lg" tabindex="-1" role="dialog" aria-labelledby="myLargeModalLabel" aria-hidden="true">
        <div class="modal-dialog modal-lg" style="max-width: 1000px!important; min-width: 900px!important">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Reporte de Clientes</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <div id="div1">
                        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                        <rsweb:reportviewer ID="ClienteReporteView" runat="server" ProcessingMode="Remote" Height="718px" Width="1000px">
                            <ServerReport ReportPath="" ReportServerUrl="" />
                        </rsweb:reportviewer>
                    </div>
                </div>
                <div class="modal-footer">
                </div>
            </div>
        </div>
    </div>

</asp:Content>
