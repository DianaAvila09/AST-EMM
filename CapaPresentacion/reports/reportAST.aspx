﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reportAST.aspx.cs" Inherits="CapaPresentacion.reports.reportAST" %>

<%@ Register assembly="DevExpress.XtraReports.v18.2.Web.WebForms, Version=18.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraReports.Web" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <dx:ASPxWebDocumentViewer ID="ASPxWebDocumentViewer1" runat="server" DisableHttpHandlerValidation="False">
            </dx:ASPxWebDocumentViewer>
        </div>
    </form>
</body>
</html>
