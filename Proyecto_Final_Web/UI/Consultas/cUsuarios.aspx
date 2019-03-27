<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="cUsuarios.aspx.cs" Inherits="Proyecto_Final_Web.UI.Consultas.cUsuarios1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=15.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
        <div class="container">
            <h2 class="card-title mb-4 mt-1"> Consulta De Usuarios </h2>
        </div>
        <div class="form-row">

                <div class="form-group ">
                    <asp:Label Text="Desde" runat="server" />
                    <asp:TextBox ID="DesdeTextBox" class="form-control input-group" TextMode="Date" runat="server" />
                </div>
                <div class="form-group ">
                    <asp:Label Text="HastaTextBox" runat="server"></asp:Label>
                    <asp:TextBox ID="HastaTextBox" class="form-control input-group" TextMode="Date" runat="server" />

                </div>
            </div>
                <asp:DropDownList ID="BuscarPorDropDownList" runat="server" CssClass="form-control input-sm">
                    <asp:ListItem>UsuarioId</asp:ListItem>
                    <asp:ListItem>Nombre</asp:ListItem>
                    <asp:ListItem>Fecha</asp:ListItem>
                </asp:DropDownList>
            
            <div class=" col-md-4 ">
                <asp:TextBox ID="Filtro" runat="server" CssClass=" form-control input-sm "></asp:TextBox>
            </div>
        <div class="form-group">
                <asp:Button ID="BuscarButton" runat="server" Class="btn btn-success input-sm" Text="Buscar" OnClick="BuscarButton_Click"  />
            </div>

           <div class="form-group">
            <button type="button" class="btn btn-outline-info mt-4" data-toggle="modal" data-target=".bd-example-modal-lg"> Imprimir </button>

        </div>
             <div class="form-group">
            <div class="form-row justify-content-center">
                <asp:GridView ID="DatosGridView" runat="server" class="table table-condensed table-bordered table-responsive" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="SkyBlue" />
                    <Columns>
                        <asp:BoundField DataField="UsuarioId" HeaderText="Usuario Id" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                         <asp:BoundField DataField="NombreUsuario" HeaderText="NombreUsuario" />
                         <asp:BoundField DataField="Email" HeaderText="Email" />
                         <asp:BoundField DataField="Clave" HeaderText="Clave" />
                         <asp:BoundField DataField="ComprobarClave" HeaderText="ComprobarClave" />
                       <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
                         <asp:BoundField DataField="Celular" HeaderText="Celular " />
                         <asp:BoundField DataField="Fecha" HeaderText="Fecha " />
                         <asp:BoundField DataField="TipoUsuario" HeaderText="TipoUsuario " />
                    </Columns>
                </asp:GridView>
            </div>
        </div>

    <%-- esta es la parte del modal --%>
        <div class="modal fade bd-example-modal-lg" tabindex="-1" role="dialog" aria-labelledby="myLargeModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-lg" style="max-width:1000px!important;min-width:900px!important">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalLabel">Reporte de Usuarios</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <div id="div1">
                            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                            <rsweb:reportviewer ID="UsuarioReporteView" runat="server" ProcessingMode="Remote" Height="718px" Width="1000px">
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
