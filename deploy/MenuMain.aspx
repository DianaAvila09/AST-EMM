<%@ Page Language="C#" AutoEvenPage Language="C#" AutoEvenPage Language="C#" AutoEventWireup="true" CodeBehind="MenuMain.aspx.cs" Inherits="CapaPresentacion.MenuMain" %>

<%@ Register assembly="DevExpress.Web.v21.1, Version=21.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>


<%@ Register assembly="DevExpress.Web.v21.1, Version=21.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx1" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style2
        {
            width: 100%;
        }
        .style8
        {
            width: 750px;
        }
        .style9
        {
            width: 153px;
        }
        .style10
        {
            width: 47px;
        }
        .style11
        {
            width: 43px;
            height: 34px;
        }
        .auto-style4 {
            width: 562px;
        }
        .auto-style5 {
            width: 461px;
        }
        .auto-style6 {
            width: 95%;
            height: 100px;
        }
        .auto-style7 {
            text-align: center;
        }
     </style>
   
   
</head>
<body topmargin="0" leftmargin="0" rightmargin="0" bgcolor="#f9f9f9" >
    <form id="form1" runat="server" >
    <div id="ContentDiv" runat="server">
    
        <table width="100%" style="height: 500px">
            <tr>
                <td align="left" valign="top" height="100%">
                    <dx:ASPxSplitter ID="ASPxSplitter1" runat="server" 
                        CssFilePath="~/App_Themes/Aqua/{0}/styles.css" CssPostfix="Aqua" 
                        Height="920px" Theme="Office2010Silver">
                        <Panes>
                            <dx:SplitterPane MaxSize="210px" MinSize="210px" 
                                ShowCollapseBackwardButton="True" Size="210px">
                                <PaneStyle BackColor="#DADADA">
                                    <Paddings PaddingLeft="0px" PaddingRight="0px" PaddingTop="0px" />
                                </PaneStyle>
                                <ContentCollection>
<dx:SplitterContentControl runat="server" SupportsDisabledAttribute="True">
    <table class="style2">
        <tr>
            <td class="auto-style7">
                <img alt="" class="auto-style6" src="../image/magnaDoclogo.svg" />
            </td>
        </tr>
        <tr>
            <td>
                <dx1:ASPxNavBar ID="ASPxNavBar1" runat="server" AllowSelectItem="True" AutoCollapse="True" CssFilePath="~/App_Themes/Aqua/{0}/styles.css" Font-Bold="False" Font-Names="Verdana" Font-Size="Small"  SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" Target="contentUrlPane" Width="100%" BackColor="#DADADA" EnableTheming="True" Theme="Default">
                    <Groups>
                        <dx1:NavBarGroup Target="contentUrlPane" Text="Main">
                            <HeaderImage Height="24px" Url="~/Images/iconos/32x32/usersx.png">
                            </HeaderImage>
                            <Items>
                                <dx1:NavBarItem NavigateUrl="~/main/gestionAst.aspx" Selected="True" Text="Gestion de documentos">
                                    <Image Url="~/Images/iconos/16x16/play.png">
                                    </Image>
                                </dx1:NavBarItem>
                            </Items>
                            <HeaderStyle BackColor="#DADADA" />
                            <HeaderStyleCollapsed BackColor="#DADADA">
                            </HeaderStyleCollapsed>
                            <ItemStyle>
                            <SelectedStyle BackColor="#DADADA">
                            </SelectedStyle>
                            </ItemStyle>
                        </dx1:NavBarGroup>
                        <dx1:NavBarGroup Expanded="False" Text="Security">
                            <Items>
                                <dx1:NavBarItem NavigateUrl="~/ActiveSecurity/UsrLogin.aspx" Target="contentUrlPane" Text="Manage Login Details">
                                    <Image Url="~/Images/iconos/16x16/play.png">
                                    </Image>
                                </dx1:NavBarItem>
                            </Items>
                        </dx1:NavBarGroup>
                    </Groups>
                    <LoadingPanelImage Url="~/App_Themes/Aqua/Web/nbLoading.gif">
                    </LoadingPanelImage>
                    <Paddings PaddingLeft="0px" PaddingRight="0px" PaddingTop="0px" />
                </dx1:ASPxNavBar>
            </td>
        </tr>
        <tr>
            <td>
                <table class="style2">
                    <tr>
                        <td class="auto-style5">&nbsp;</td>
                        <td class="auto-style4">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5" align="center">
                            <dx1:ASPxLabel ID="ASPxLabel2" runat="server" Text="ASPxLabel" Width="200px">
                            </dx1:ASPxLabel>
                        </td>
                        <td class="auto-style4">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5" align="center">
                            <dx1:ASPxLabel ID="ASPxLabel3" runat="server" Text="ASPxLabel" Width="200px">
                            </dx1:ASPxLabel>
                        </td>
                        <td class="auto-style4">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5">&nbsp;</td>
                        <td class="auto-style4">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            &nbsp;</td>
                        <td class="auto-style4">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5" align="center">
                            <asp:Button class="btn btn-primary"  ID="btnLogout" runat="server" Text="logout" OnClick="btnLogout_Click"></asp:Button>
                        </td>
                        <td class="auto-style4">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
                                    </dx:SplitterContentControl>
</ContentCollection>
                            </dx:SplitterPane>
                            <dx:SplitterPane Name="ContentUrlPane" 
                                ContentUrlIFrameName="contentUrlPane" AutoHeight="True" AutoWidth="True" 
                                ScrollBars="Vertical" ContentUrl="~/main/gestionAst.aspx">
                                <ContentCollection>
<dx:SplitterContentControl runat="server" SupportsDisabledAttribute="True"></dx:SplitterContentControl>
</ContentCollection>
                            </dx:SplitterPane>
                        </Panes>
                        <Styles CssFilePath="~/App_Themes/Aqua/{0}/styles.css" CssPostfix="Aqua">
                        </Styles>
                        <Images SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css">
                        </Images>
                    </dx:ASPxSplitter>
                </td>
            </tr>
        </table>
    </div>
       <div >
          <table width="100%" bgcolor="#dadada">
             <tr>
                <td align="center" height="20%">
                     <p align="center" 
                         style="font-family: 'Arial', Times, serif; font-size: 9pt">Copyright (c) 2022&nbsp; All rights reserved.
                                        
    </form>
</body>
</html>
