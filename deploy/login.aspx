<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="CapaPresentacion.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>MangaDoc-EST</title>

     <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="./css/bootstrap.css"/>
    <link rel="stylesheet" href="./css/StyleSheet.css"/>
    <%--<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/css/bootstrap.min.css" integrity="sha384-zCbKRCUGaJDkqS1kPbPd7TveP5iyJE0EjAuZQTgFLD2ylzuqKfdKlfG/eSrtxUkn" crossorigin="anonymous">--%>

</head>
<body class="container" style="background-color:#dadada " >

    <div class="lineColor">

    </div>

    <div class="container">
        <div class="row mt-5 justify-content-center">
            <div class="col-4">
                <div class="card border-light  ">
                    <img class="card-img-top" src="image/magnaDoclogo.svg" />
                    <div class="card-body">
                        <h4 class="card-title text-center mb-3">Acceso al Sistema</h4>
                        <hr />
                                         
                        <form id="form2" runat="server" autocomplete="off">

                             <div class="form-group">
                                <label for="exampleInputEmail1">Correo electrónico</label>
                                <asp:TextBox class="form-control" ID="txtEmail" runat="server"></asp:TextBox>
                             </div>

                            <div class="form-group">
                                <label for="exampleInputPassword1">Clave de acceso</label>
                                <asp:TextBox type="password" class="form-control" ID="txtPass" runat="server"></asp:TextBox>
                       
                            </div>

                                <div class="form-group">
                                    <asp:CheckBox class="" ID="CheckBox2" runat="server" Text="&nbsp Recuerdame" Visible="False" />
                                </div>
        
                            <div class="form-group">
                                <asp:Button class="btn btn-primary btn-block" ID="Button1" runat="server" Text="Iniciar Sesion" OnClick="btnLogin_Click"  />
                            </div>

                            <div class="form-group text-center">
                                <asp:Label ID="lblMsgErr" runat="server" Visible="False" CssClass="alert-danger">Credenciales Incorrectas </asp:Label>
                            </div>
                
                         </form>

                     </div>

                </div>

            </div>

        </div>

        <div class="row mt-1 justify-content-center">
            <div class="col-4">

                <p class="text-center"> <small>copyright (c) <asp:Label ID="lblAnio" runat="server"></asp:Label> &nbsp; MAGNA. All rights reserved</small>  </p>
                
            </div>
         </div>
    </div>

     <div class="row mt-5  justify-content-center">

        <div class="col-md-4">

           <%-- <form id="form1" runat="server" autocomplete="off">

                    <div class="form-group">

                        <image src="/image/magnaDoclogo.svg" style="width:350px;height:80px;"></image>

                    </div>

                      <div class="form-group">
                        <label for="exampleInputEmail1">Correo electrónico</label>
                        <asp:TextBox class="form-control" ID="email" runat="server"></asp:TextBox>
                     </div>

                    <div class="form-group">
                        <label for="exampleInputPassword1">Clave de acceso</label>
                        <asp:TextBox type="password" class="form-control" ID="pass" runat="server"></asp:TextBox>
                       
                    </div>

                     <div class="form-group">
                            <asp:CheckBox class="" ID="CheckBox1" runat="server" Text="&nbsp Recuerdame" />
                     </div>
        
                    <div class="form-group">
                        <asp:Button class="btn btn-primary btn-block" ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"  />
                    </div>
                
                      

            </form>--%>

        </div>
   </div>


     <script type="text/javascript">

         let Anio = new Date().getFullYear();
        
    </script>
</body>
</html>
