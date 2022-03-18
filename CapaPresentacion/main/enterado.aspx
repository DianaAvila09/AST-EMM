<%@ Page language="C#" AutoEventWireup="true" CodeBehind="enterado.aspx.cs" Inherits="CapaPresentacion.main.enterado"%> 


<%@ Register Assembly="DevExpress.Web.v18.2, Version=18.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>MangaDoc-EST</title>
      <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="../css/bootstrap.css"/>

    <link rel="stylesheet" href="../css/StyleSheet.css"/>

</head>
<body>

    <form id="frm1" runat="server">
   
                <div id="divPrincipal" class="container" >
                    <div class="row mt-3 ">
                        <div class="col">

                            <div class="card text-center" style="width: 30rem;">
                                <img src="../image/magnaDoclogo.svg" class="card-img-top" alt="" />

                               <div class="card-header">
                                <strong>AST-EMM</strong> 
                              </div>

                                <div class="card-body text-left">

                                    <h6 class="card-title">Fecha de creación</h6>
                                     <p class="card-text"><dx:ASPxLabel ID="lblFecha" runat="server" Text=""></dx:ASPxLabel></p>
                                    <h6 class="card-title">Area</h6>
                                     <p class="card-text"><dx:ASPxLabel ID="lblArea" runat="server" Text=""></dx:ASPxLabel></p>
                                    <h6 class="card-title">Descripción del trabajo a realizar</h6>
                                     <p class="card-text"><dx:ASPxLabel ID="lblTrabajoRealizar" runat="server" Text=""></dx:ASPxLabel></p>

                                     <h6 class="card-title">EPP a utilizar</h6>
                                     <p class="card-text"><dx:ASPxLabel ID="lblEpp" runat="server" Text=""></dx:ASPxLabel></p>

                                    <div class="text-center" >
                                         <dx:ASPxLabel ID="lblAceptado" Font-Size="XX-Large" runat="server" CssClass="card-title text-primary" Text="Enviado exitosamente !!" Visible="false"> </dx:ASPxLabel>
                                    </div>                         

                                </div>


                            </div>

                        </div>

                    </div>

                </div>


    </form>
    
      
    
</body>
</html>
