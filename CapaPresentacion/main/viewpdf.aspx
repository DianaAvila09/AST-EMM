<%@ Page language="C#" AutoEventWireup="true" CodeBehind="viewpdf.aspx.cs" Inherits="CapaPresentacion.main.viewpdf"%> 


<%@ Register Assembly="DevExpress.Web.v18.2, Version=18.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register assembly="DevExpress.XtraReports.v18.2.Web.WebForms, Version=18.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraReports.Web" tagprefix="dx" %>
<%@ Register assembly="DevExpress.XtraReports.v18.2.Web.WebForms, Version=18.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraReports.Web.ClientControls" tagprefix="cc1" %>
<%@ Register assembly="DevExpress.XtraReports.v18.2.Web.WebForms, Version=18.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraReports.Web.WebDocumentViewer" tagprefix="cc2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>MangaDoc-EST</title>
      <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="../css/bootstrap.css"/>

    <link rel="stylesheet" href="../css/StyleSheet.css"/>

    <style type="text/css">
        .auto-style1 {
            width: 100%;
            max-width: 1140px;
            min-width: 992px;
            height: 147px;
            margin-left: auto;
            margin-right: auto;
            padding-left: 15px;
            padding-right: 15px;
        }
    </style>

</head>
<body style="height: 489px">

    <form id="frm1" runat="server">
   
                <div id="divPrincipal" class="container mt-2" >
                   
                    <dx:ASPxButton runat="server" ID="brnViewPdf" OnClick="brnViewPdf_Click" Text="crear PDF"></dx:ASPxButton>
                </div>

    </form>
    
      
   
</body>
</html>
