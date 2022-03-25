<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userReg.aspx.cs" Inherits="CapaPresentacion.auth.userReg" %>

<%@ Register Assembly="DevExpress.Web.v18.2, Version=18.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <link rel="stylesheet" href="../css/bootstrap.css"/>

    <link rel="stylesheet" href="../css/StyleSheet.css"/>

</head>
<body>
    <div class="container">
        <form id="form1" runat="server" autocomplete="off">

             <div class="row mt-4">
                <div class="col">
                    <h3> Actualizador de Usuarios</h3>
                    <hr />
                </div>
              </div>

            <div class="mb-3">
                <label  class="form-label">Nombre completo</label>
                <dx:ASPxTextBox ID="txtNombre" runat="server"   Width="100%" Theme="Aqua" BackColor="#F8F8F8"  Height="25px" Font-Names="Segoe UI" Font-Size="Medium" >
                </dx:ASPxTextBox>
                 <asp:Label runat="server" ID="lblErrName" CssClass="alert-danger" Visible="false" ></asp:Label>

            </div>
            <div class="mb-3">
                <label  class="form-label">Correo electrónico</label>
                <dx:ASPxTextBox ID="txtEmail" runat="server" Width="100%" Theme="Aqua" BackColor="#F8F8F8"  Height="25px" Font-Names="Segoe UI" Font-Size="Medium" NullText="name@example.com"></dx:ASPxTextBox>
                 <asp:Label runat="server" ID="lblErrEmail" CssClass="alert-danger" Visible="false" ></asp:Label>
            </div>

            <div class="mb-3">
                <label  class="form-label">Password</label>
                  <dx:ASPxTextBox ID="txtPass" runat="server" Width="100%" Theme="Aqua" BackColor="#F8F8F8"  Height="25px" Font-Names="Segoe UI" Font-Size="Medium" ></dx:ASPxTextBox>
                  <asp:Label runat="server" ID="lblErrPass" CssClass="alert-danger" Visible="false" ></asp:Label>
            </div>
            <div class="mb-3">
                <label  class="form-label">Nombre de la Compañia</label>
                <dx:ASPxTextBox ID="txtCia" runat="server" Width="100%" Theme="Aqua" BackColor="#F8F8F8"  Height="25px" Font-Names="Segoe UI" Font-Size="Medium" ></dx:ASPxTextBox>
                <asp:Label runat="server" ID="lblErrCia" CssClass="alert-danger" Visible="false" ></asp:Label>

            </div>
             <div class="mb-3">
                <label  class="form-label">Departamento</label>        
                 <dx:ASPxComboBox runat="server"  ID="cmbDepto" Width="100%" Theme="Aqua" BackColor="#F8F8F8"  Height="25px" Font-Names="Segoe UI" Font-Size="Medium"></dx:ASPxComboBox>
                 <asp:Label runat="server" ID="lblErrDepto" CssClass="alert-danger" Visible="false" ></asp:Label>
            </div>

            <div class="row mb-5">
                <div class="col-2"> 
                    <dx:ASPxCheckBox ID="chkActivo" runat="server" Theme="Aqua"  Font-Size="Medium" Text="Es Activo " CheckState="Checked"></dx:ASPxCheckBox>
                </div>

                <div class="col-auto"> Rol del usaurio</div>
                <div class="col-auto">
                    <dx:ASPxComboBox runat="server"  ID="cmbRol" Width="100%" Theme="Aqua" BackColor="#F8F8F8"  Height="25px" Font-Names="Segoe UI" Font-Size="Medium"></dx:ASPxComboBox>
                    <asp:Label runat="server" ID="lblErrRol" CssClass="alert-danger" Visible="false" ></asp:Label>
                </div>
            </div>

            <div class="row mt-3">
                <div class="col-2">
                     <asp:Button runat="server" CssClass="btn btn-primary btn-block" Text="Guardar"  ID="btnGrabar" OnClick="btnGrabar_Click" />
                </div>
                <div class="col-2">
                     <asp:Button runat="server" CssClass="btn btn-danger btn-block" Text="Cancelar"  ID="btnCancelar" OnClick="btnCancelar_Click"/>
                </div>
            </div>
            <dx:ASPxHiddenField ID="hfIsNew" runat="server" ClientInstanceName="hfIsNew"> </dx:ASPxHiddenField>
        </form>
    </div>
</body>
</html>
