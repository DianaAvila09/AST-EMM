<%@ Page language="C#" AutoEventWireup="true" CodeBehind="deptosQuery.aspx.cs" Inherits="CapaPresentacion.catalogos.deptosQuery"%> 


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
                        <h3>Departamentos</h3>
                        <hr />
                    </div>
                </div>

                <div class="row mt-2">
                   
                    <div class="col-auto">
                         <asp:Button CssClass="btn btn-primary btn-sm" runat="server" Text="Agregar departamento" OnClick="agregar_Click" ></asp:Button>
                    </div>
                     <div class="col-auto">
                         <asp:Button CssClass="btn btn-primary btn-sm" runat="server" Text="Exportar excel" Visible="false" ></asp:Button>
                    </div>

                </div>


                <div class="row mt-2">
                        <div class="col">
                        <dx:ASPxGridView ID="ASPxGridView1" runat="server" Width="100%" Theme="Aqua" AutoGenerateColumns="False" EnableTheming="True" Font-Names="segoe ui,medium" Font-Size="Small" KeyFieldName="dpto_id" ClientInstanceName="gvDoctos">
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
                                <dx:GridViewDataTextColumn Caption="Departamento" VisibleIndex="1" FieldName="dpto_nombre" Width="600px">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Id" VisibleIndex="0" FieldName="dpto_id" Width="40px">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Estatus" ShowInCustomizationForm="True" VisibleIndex="2" Width="80px" FieldName="estatus">
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
