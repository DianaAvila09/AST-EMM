<%@ Page language="C#" AutoEventWireup="true" CodeBehind="userQuery.aspx.cs" Inherits="CapaPresentacion.main.userQuery"%> 


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
    
        <div class="contenedor">
            <form id="form1" runat="server">
       
                <div class="row">
                    <div class="col">
                        <h3> Consulta de Usuarios</h3>
                        <hr />
                    </div>
                </div>

                <div class="row mt-2">
                   
                    <div class="col-auto">
                         <asp:Button CssClass="btn btn-primary btn-sm" runat="server" Text="Agregar nuevo usuario" OnClick="agregar_Click" ></asp:Button>
                    </div>
                     <div class="col-auto">
                         <asp:Button CssClass="btn btn-primary btn-sm" runat="server" Text="Exportar excel" Visible="false" ></asp:Button>
                    </div>

                </div>


                <div class="row mt-2">
                        <div class="col">
                        <dx:ASPxGridView ID="ASPxGridView1" runat="server" Width="100%" Theme="Aqua" AutoGenerateColumns="False" EnableTheming="True" Font-Names="segoe ui,medium" Font-Size="Small" KeyFieldName="user_id" ClientInstanceName="gvDoctos">
                            <ClientSideEvents RowDblClick="function(s, e) 
                                {
                                let key = s.GetRowKey(e.visibleIndex);
	                            llamaPantallaConsulta(key);
                                 }" />
                            <SettingsPager Mode="ShowAllRecords">
                            </SettingsPager>
                            <Settings VerticalScrollableHeight="500" VerticalScrollBarMode="Visible" />
                            <SettingsBehavior AllowSort="False" />
                            <SettingsPopup>
                            <%--<FilterControl AutoUpdatePosition="False"></FilterControl>--%>
                            </SettingsPopup>
                            <Columns>
                                <dx:GridViewDataTextColumn Caption="Nombre" VisibleIndex="1" FieldName="nombre" Width="250px">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Fecha alta" VisibleIndex="0" FieldName="fecha_alta" Width="100px">
                                    <PropertiesTextEdit DisplayFormatString="dd/MMM/yyyy ">
                                    </PropertiesTextEdit>
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Departamento" VisibleIndex="4" FieldName="dpto_nombre" Width="350px">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Compañia" VisibleIndex="3" FieldName="cia" Width="250px">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Estatus" VisibleIndex="6" FieldName="estatus" Width="100px">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Correo electrónico" FieldName="email" VisibleIndex="2" Width="250px">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Rol" FieldName="rol_nombre" VisibleIndex="5" Width="250px">
                                </dx:GridViewDataTextColumn>
                               
                                <dx:GridViewDataTextColumn FieldName="user_id" Visible="False" VisibleIndex="8">
                                </dx:GridViewDataTextColumn>
                            </Columns>
                            </dx:ASPxGridView>
                    </div>
                </div>
               
 
                 <dx:ASPxHiddenField ID="HiddenField2" runat="server" ClientInstanceName="HiddenField2"> </dx:ASPxHiddenField>
              </form>

        </div>


    <script type="text/javascript">

        function llamaPantallaConsulta(miLLave) {

            HiddenField2.Set('hidden_value', miLLave);
            __doPostBack('btnUpd_Click', '');

        }

    </script>
    
</body>
</html>
