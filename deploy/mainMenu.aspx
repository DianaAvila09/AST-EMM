<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mainMenu.aspx.cs" Inherits="CapaPresentacion.mainMenu" %>

<%@ Register assembly="DevExpress.Web.v18.2, Version=18.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>MangaDoc-EST</title>

     <link rel="stylesheet" href="./css/bootstrap.css" />
     <link rel="stylesheet" href="./css/StyleSheet.css" />
</head>
<body style="background-color:#dadada">
    <form id="form1" runat="server">
        
        <div class="contenedorMenu">
            <div class="row">

                <div class="col-12">

                    <dx:ASPxSplitter ID="ASPxSplitter1" runat="server" Height="900px" Theme="Office2010Silver" Width="100%">
                    <panes>
                        <dx:SplitterPane MaxSize="210px" MinSize="210px" ShowCollapseBackwardButton="True" Size="210px">    
                            <PaneStyle BackColor="#DADADA">
                                <Paddings PaddingLeft="0px" PaddingRight="0px" PaddingTop="0px" />
                            </PaneStyle>
                            <ContentCollection>
                                <dx:SplitterContentControl runat="server">

                                    <div class="mb-2 mt-2 align-content-center">
                                        <img src="image/magnaDoclogo.svg" style="width:100%" />
                                    </div>

                                        <dx:ASPxNavBar ID="ASPxNavBar1" runat="server" BackColor="#DADADA" Theme="Office2010Silver" Width="100%" AllowSelectItem="True" AutoCollapse="True" Font-Names="Verdana" Font-Size="Small" Target="contentUrlPane">
                                            <Groups>
                                                <dx:NavBarGroup Text="Principal" Target="contentUrlPane">
                                                    <Items>
                                                        <dx:NavBarItem Text="Gestion de documentos" NavigateUrl="~/main/gestionAst.aspx">
                                                        </dx:NavBarItem>
                                                    </Items>
                                                </dx:NavBarGroup>
                                                <dx:NavBarGroup Text="Seguridad" Expanded="False">
                                                    <Items>
                                                        <dx:NavBarItem Text="Usuarios">
                                                        </dx:NavBarItem>
                                                    </Items>
                                                </dx:NavBarGroup>
                                            </Groups>
                                            <Paddings PaddingLeft="0px" PaddingRight="0px" PaddingTop="0px" />
                                        </dx:ASPxNavBar>
                                          
                                    <br /> <br /> <br /> <br /> <br /> <br /> <br /> <br /> <br /> <br /> <br />

                                    <div class="mt-5 text-center">
                                       <h6>Bienvenido </h6>
                                    </div>

                                    <div class="text-center mt-1">
                                         <asp:Label  runat="server" ID="ASPxLabel2" CssClass="font-weight-bold"></asp:Label>
                                    </div>
                                    <div class="text-center mb-5">
                                         <asp:Label  runat="server" ID="ASPxLabel3" CssClass="font-weight-bold"></asp:Label>
                                    </div>

                                    <div class="text-center">
                                      <asp:Button runat="server" CssClass="btn btn-secondary" Text="Cerrar Sesion" Width="80%"  ID="btnLogout" OnClick="btnLogout_click"/>
                                    </div>

                                </dx:SplitterContentControl>
                            </ContentCollection>
                         </dx:SplitterPane>

                         <dx:SplitterPane AutoHeight="True" AutoWidth="True" ContentUrl="~/main/gestionAst.aspx" ContentUrlIFrameName="contentUrlPane" Name="ContentUrlPane" ScrollBars="Vertical">
                             <ContentCollection>
                                    <dx:SplitterContentControl runat="server"></dx:SplitterContentControl>
                              </ContentCollection>
                         </dx:SplitterPane>
                    </panes>
                 </dx:ASPxSplitter>

                </div>

            </div>

          
                <div class="col-12" style="background-color:#dadada">
                    <p class="text-center"> <small>copyright (c)  <asp:Label ID="lblAnio" runat="server"></asp:Label> &nbsp; MAGNA. All rights reserved</small>  </p>
                </div>
          

       </div>

    </form>
</body>
</html>
