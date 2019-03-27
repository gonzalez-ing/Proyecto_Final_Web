﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClienteReporteView.aspx.cs" Inherits="Proyecto_Final_Web.Reportes.ClienteReporteView" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <rsweb:ReportViewer ID="ListadoClientes" runat="server"></rsweb:ReportViewer>
        </div>
    </form>
</body>
</html>
