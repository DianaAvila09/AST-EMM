<%@ Page language="C#" AutoEventWireup="true" CodeBehind="gestionAst.aspx.cs" Inherits="CapaPresentacion.main.gestionAst"%> 


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
                        <h3>Gestion de Documentos</h3>
                        <hr />
                    </div>
                </div>

                <div class="row mt-2">
                    <div class="col-2 columna-derecha">
                        <p>Tipo de documento :</p>
                    </div>

                    <div class="col-4 columna-izquierda">
                        <dx:ASPxComboBox class="primary" ID="ASPxComboBox1" runat="server" Width="80%" Height="25px" Theme="Aqua" BackColor="#F8F8F8" Font-Names="Segoe UI" Font-Size="Medium" AutoPostBack="True" OnSelectedIndexChanged="ASPxComboBox1_SelectedIndexChanged">
                            <Items>
                                <dx:ListEditItem Value="0" />
                            </Items>
                        </dx:ASPxComboBox>
                    
                    </div>

                    <div class="col-12">
                         <asp:Button CssClass="btn btn-primary btn-sm" runat="server" Text="Agregar documento" OnClick="agregar_Click" ></asp:Button>
                    </div>

                </div>


                <div class="row mt-2">
                        <div class="col">
                        <dx:ASPxGridView ID="ASPxGridView1" runat="server" Width="100%" Theme="Aqua" AutoGenerateColumns="False" EnableTheming="True" Font-Names="segoe ui,medium" Font-Size="Small" KeyFieldName="ast_id" ClientInstanceName="gvDoctos">
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
                                <dx:GridViewDataTextColumn Caption="Num. Documento" VisibleIndex="0" FieldName="nombre_docto" Width="200px">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Fecha" VisibleIndex="2" FieldName="fecha_creacion" Width="100px">
                                    <PropertiesTextEdit DisplayFormatString="dd/MMM/yyyy ">
                                    </PropertiesTextEdit>
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Departamento" VisibleIndex="5" FieldName="dpto_nombre" Width="350px">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Contacto Planta" VisibleIndex="3" FieldName="email_contactoPlanta" Width="250px">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Estatus" VisibleIndex="6" FieldName="estatus" Width="100px">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Empresa" FieldName="cia" VisibleIndex="1" Width="250px">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Area" FieldName="area" VisibleIndex="4" Width="250px">
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
