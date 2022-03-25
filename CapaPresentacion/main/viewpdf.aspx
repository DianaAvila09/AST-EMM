<%@ Page language="C#" AutoEventWireup="true" CodeBehind="viewPdf.aspx.cs" Inherits="CapaPresentacion.main.viewPdf"%> 


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
        .auto-style2 {
            position: relative;
            width: 99%;
            -ms-flex-preferred-size: 0;
            flex-basis: 0;
            -ms-flex-positive: 1;
            flex-grow: 1;
            max-width: 100%;
            left: 0px;
            top: 0px;
            padding-left: 15px;
            padding-right: 15px;
        }
    </style>

</head>
<body >

    <form id="frm1" runat="server">
   
                <div id="divPrincipal" class="container mt-2" >
                   
                    <dx:ASPxButton runat="server" ID="brnViewPdf" OnClick="brnViewPdf_Click" Text="crear PDF"></dx:ASPxButton>
                </div>

        <div  class="container mt-2" >
                   
                    <dx:ASPxButton  runat="server" ID="btnPdf" OnClick="btnPdf_Click" Text="crear PDF en devexpress"></dx:ASPxButton>
         </div>

        <div >
           
                <dx:ASPxWebDocumentViewer ID="visorPdf" runat="server" DisableHttpHandlerValidation="False" ReportSourceId="docAstPdf">
                </dx:ASPxWebDocumentViewer>
        </div>


    </form>
    
      
   
</body>
</html>
