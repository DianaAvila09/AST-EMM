<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="capAst.aspx.cs" Inherits="CapaPresentacion.main.capAst" %>

<%@ Register Assembly="DevExpress.Web.v18.2, Version=18.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>MangaDoc-EST</title>
      <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="../css/bootstrap.css" />

    <link rel="stylesheet" href="../css/StyleSheet.css" />
</head>
<body>
    <div class="contenedor">

    <form id="form1" runat="server">
         <div class="row">
            <div class="col">
                <h3>Analisis de Seguridad en el Trabajo (AST)</h3>
                <hr />
            </div>
         </div>

        <div class="row">
            <div class="col-auto">
                <label>Area :</label>
            </div>
            <div class="col-4">
                <dx:ASPxTextBox ID="txtArea" runat="server" Width="100%" Theme="Aqua" BackColor="#F8F8F8"  Height="25px" Font-Names="Segoe UI" Font-Size="Medium"></dx:ASPxTextBox>
            </div>

             <div class="col-auto">
                <label>Departamento :</label>
            </div>
            <div class="col-4">
                <dx:ASPxComboBox runat="server"  ID="cmbDepto" Width="100%" Theme="Aqua" BackColor="#F8F8F8"  Height="25px" Font-Names="Segoe UI" Font-Size="Medium"></dx:ASPxComboBox>
                <asp:Label runat="server" ID="lblError" CssClass="alert-danger" Visible="false" ></asp:Label>
                 <%--<dx:ASPxTextBox ID="txtDepto" runat="server" Width="100%" Theme="Aqua" BackColor="#F8F8F8"  Height="25px" Font-Names="Segoe UI" Font-Size="Medium"></dx:ASPxTextBox>--%>
            </div>

        </div>

        <div class="row mt-2">
            <div class="col-auto">
                <label>Fecha :</label>
            </div>
            <div class="col-auto">
                <dx:ASPxDateEdit ID="cmbFecha" runat="server" Theme="Aqua" Width="150px" BackColor="#F8F8F8"  Height="25px" Font-Names="Segoe UI" Font-Size="Medium" DisplayFormatString="dd/MMM/yyyy"></dx:ASPxDateEdit>
            </div>

             <div class="col-auto">
                <label>Hora inicio (hh:mm) :</label>
            </div>
            <div class="col-auto">
                <dx:ASPxTextBox ID="txtHoraIni" runat="server" Width="80px" Theme="Aqua" BackColor="#F8F8F8"  Height="25px" Font-Names="Segoe UI" Font-Size="Medium"></dx:ASPxTextBox>
            </div>

            <div class="col-auto">
                <label>Hora fin (hh:mm):</label>
            </div>
            <div class="col-auto">
                <dx:ASPxTextBox ID="txtHoraFin" runat="server" Width="80px" Theme="Aqua" BackColor="#F8F8F8"  Height="25px" Font-Names="Segoe UI" Font-Size="Medium"></dx:ASPxTextBox>
            </div>
            <div class="col-auto">
                    <label>Corre del contacto en planta :</label>
            </div>
            <div class="col">
                    <dx:ASPxTextBox ID="txtContactoPlanta" runat="server" Width="100%" Height="25px" Theme="Aqua" BackColor="#F8F8F8" Font-Names="Segoe UI" Font-Size="Medium"></dx:ASPxTextBox>
            </div>
        </div>

        <div class="row">
            <div class="col-3">
            </div>
        </div>


        <div class="row">
             <div class="col-12">
                <label class="col-form-label">Descripcion Especifica Del Trabajo a Realizar :</label>
                 <dx:ASPxMemo ID="txtDescTrabajo" runat="server" Height="71px" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxMemo>
            </div>
        </div>

        <div class="row">
             <div class="col-12">
                <label class="col-form-label">Puestos involucrados :</label>
                <dx:ASPxTextBox ID="txtPuestoInvolucrado" runat="server" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxTextBox>
            </div>
        </div>

        <div class="row">
             <div class="col-12">
                <label class="col-form-label">EPP a utilizar :</label>
                <dx:ASPxTextBox ID="txtEPP" runat="server" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxTextBox>
            </div>
        </div>


            <div class="row mt-5">
                 <div class="col-4 text-center">
                    <dx:ASPxTextBox ID="txtElabora" runat="server" Width="100%" CssClass="form-control" MaxLength="500" ReadOnly="true" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxTextBox>
                    <label class="col-form-label">Elabora: Nombre y firma</label>
                </div>
                <div class="col-4 text-center">
                    <dx:ASPxTextBox ID="txtAutorizaContacto" runat="server" Width="100%" CssClass="form-control" MaxLength="500" ReadOnly="true" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxTextBox>
                    <label class="col-form-label">Autorizo Contacto de Planta: Nombre y Firma</label>
                </div>
                <div class="col-4 text-center">
                    <dx:ASPxTextBox ID="txtAutorizaPlanta" runat="server" Width="100%" CssClass="form-control" MaxLength="500" ReadOnly="true" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxTextBox>
                    <label class="col-form-label">Seguridad Planta: Nombre y Firma</label>
                </div>
            </div>

        <div class="row">
             <div class="col-12">
                <label class="col-form-label">Motivo del rechazo :</label>
                <dx:ASPxTextBox ID="txtMotivorechazo" runat="server" Enabled="false" Width="100%" CssClass="form-control" MaxLength="300" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxTextBox>
            </div>
        </div>


        <%--Secuencia de trabajo--%>
        <div class="row mt-5 align-items-center">
             <div class="col-1">
                <label class="col-form-label">Num.</label>
            </div>
            <div class="col-3">
                <label class="col-form-label">Secuencia de Pasos Del Trabajo</label>
            </div>
            <div class="col-3">
                <label class="col-form-label">Identificacion de Riesgos y Peligros Potenciales</label>
            </div>
            <div class="col-3">
                <label class="col-form-label">Procedimiento Para realizar el Trabajo Seguro.</label>
            </div>

        </div>

        <div class="row mt-1 align-items-center">

             <div class="col-1">
                <dx:ASPxTextBox ID="txtSecNum1" Enabled="false" text="1" runat="server" Width="50%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxTextBox>
            </div>
            <div class="col-3">
                <dx:ASPxMemo ID="ASPxMemo1" runat="server" Height="71px" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxMemo>
            </div>
            <div class="col-3">
                <dx:ASPxMemo ID="ASPxMemo2" runat="server" Height="71px" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxMemo>
            </div>
            <div class="col-3">
                <dx:ASPxMemo ID="ASPxMemo3" runat="server" Height="71px" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxMemo>
            </div>

            <div class="col-1">
                <asp:Button CssClass="btn btn-primary btn-sm" Text="+" runat="server" ID="btnST0" OnClick="btnST0_Click" />
            </div>

        </div>

      <asp:Panel ID="Panel1" runat="server" Visible="false">
             <div class="row mt-1 align-items-center"  >
                 <div class="col-1">
                    <dx:ASPxTextBox ID="txtSecNum2" Enabled="false" text="2" runat="server" Width="50%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxTextBox>
                </div>
                <div class="col-3">
                    <dx:ASPxMemo ID="ASPxMemo4" runat="server" Height="71px" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxMemo>
                </div>
                <div class="col-3">
                    <dx:ASPxMemo ID="ASPxMemo5" runat="server" Height="71px" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxMemo>
                </div>
                <div class="col-3">
                    <dx:ASPxMemo ID="ASPxMemo6" runat="server" Height="71px" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxMemo>
                </div>

                <div class="col">
                    <div class="row align-items-center">
                        <div class="col-1">
                           <asp:Button ID="btnST1" CssClass="btn btn-primary btn-sm" Text="-" runat="server" onClick="btnST1_Click" />
                      </div>
                        <div class="col-1">
                           <asp:Button ID="btnST2"  CssClass="btn btn-primary btn-sm" Text="+" runat="server" onClick="btnST2_Click" />
                      </div>

                    </div>
                </div>

            </div>

      </asp:Panel>


      <asp:Panel ID="Panel2" runat="server" Visible="false">
             <div class="row mt-1 align-items-center"  >
                 <div class="col-1">
                    <dx:ASPxTextBox ID="txtSecNum3" Enabled="false" text="3" runat="server" Width="50%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxTextBox>
                </div>
                <div class="col-3">
                     <dx:ASPxMemo ID="ASPxMemo7" runat="server" Height="71px" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxMemo>
                </div>
                <div class="col-3">
                    <dx:ASPxMemo ID="ASPxMemo8" runat="server" Height="71px" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxMemo>
                </div>
                <div class="col-3">
                   <dx:ASPxMemo ID="ASPxMemo9" runat="server" Height="71px" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxMemo>
                </div>

                <div class="col">
                    <div class="row align-items-center">
                        <div class="col-1">
                           <asp:Button ID="btnST3" CssClass="btn btn-primary btn-sm" Text="-" runat="server"  OnClick="btnST3_Click" />
                      </div>
                       <div class="col-1">
                           <asp:Button ID="btnST4"  CssClass="btn btn-primary btn-sm" Text="+" runat="server" onClick="btnST4_Click" />
                      </div> 

                    </div>
                </div>

            </div>
      </asp:Panel>

        <asp:Panel ID="Panel3" runat="server" Visible="false">
             <div class="row mt-1 align-items-center"  >
                 <div class="col-1">
                    <dx:ASPxTextBox ID="txtSecNum4" Enabled="false" text="4" runat="server" Width="50%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxTextBox>
                </div>
                <div class="col-3">
                     <dx:ASPxMemo ID="ASPxMemo10" runat="server" Height="71px" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxMemo>
                </div>
                <div class="col-3">
                    <dx:ASPxMemo ID="ASPxMemo11" runat="server" Height="71px" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxMemo>
                </div>
                <div class="col-3">
                   <dx:ASPxMemo ID="ASPxMemo12" runat="server" Height="71px" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxMemo>
                </div>

                <div class="col">
                    <div class="row align-items-center">
                        <div class="col-1">
                           <asp:Button ID="btnST5" CssClass="btn btn-primary btn-sm" Text="-" runat="server"  OnClick="btnST5_Click" />
                      </div>
                       <div class="col-1">
                           <asp:Button ID="btnST6"  CssClass="btn btn-primary btn-sm" Text="+" runat="server" onClick="btnST6_Click" />
                      </div> 

                    </div>
                </div>

            </div>
      </asp:Panel>

        <asp:Panel ID="Panel4" runat="server" Visible="false">
             <div class="row mt-1 align-items-center"  >
                 <div class="col-1">
                    <dx:ASPxTextBox ID="txtSecNum5" Enabled="false" text="5" runat="server" Width="50%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxTextBox>
                </div>
                <div class="col-3">
                     <dx:ASPxMemo ID="ASPxMemo13" runat="server" Height="71px" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxMemo>
                </div>
                <div class="col-3">
                    <dx:ASPxMemo ID="ASPxMemo14" runat="server" Height="71px" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxMemo>
                </div>
                <div class="col-3">
                   <dx:ASPxMemo ID="ASPxMemo15" runat="server" Height="71px" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxMemo>
                </div>

                <div class="col">
                    <div class="row align-items-center">
                        <div class="col-1">
                           <asp:Button ID="btnST7" CssClass="btn btn-primary btn-sm" Text="-" runat="server"  OnClick="btnST7_Click" />
                      </div>
                       <div class="col-1">
                           <asp:Button ID="btnST8"  CssClass="btn btn-primary btn-sm" Text="+" runat="server" onClick="btnST8_Click" />
                      </div> 

                    </div>
                </div>

            </div>
      </asp:Panel>

        <asp:Panel ID="Panel5" runat="server" Visible="false">
             <div class="row mt-1 align-items-center"  >
                 <div class="col-1">
                    <dx:ASPxTextBox ID="txtSecNum6" Enabled="false" text="6" runat="server" Width="50%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxTextBox>
                </div>
                <div class="col-3">
                     <dx:ASPxMemo ID="ASPxMemo16" runat="server" Height="71px" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxMemo>
                </div>
                <div class="col-3">
                    <dx:ASPxMemo ID="ASPxMemo17" runat="server" Height="71px" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxMemo>
                </div>
                <div class="col-3">
                   <dx:ASPxMemo ID="ASPxMemo18" runat="server" Height="71px" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxMemo>
                </div>

                <div class="col">
                    <div class="row align-items-center">
                        <div class="col-1">
                           <asp:Button ID="btnST9" CssClass="btn btn-primary btn-sm" Text="-" runat="server"  OnClick="btnST9_Click" />
                      </div>
                       <div class="col-1">
                           <asp:Button ID="btnST10"  CssClass="btn btn-primary btn-sm" Text="+" runat="server" onClick="btnST10_Click" />
                      </div> 

                    </div>
                </div>

            </div>
      </asp:Panel>

       <asp:Panel ID="Panel6" runat="server" Visible="false">
             <div class="row mt-1 align-items-center"  >
                 <div class="col-1">
                    <dx:ASPxTextBox ID="txtSecNum7" Enabled="false" text="7" runat="server" Width="50%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxTextBox>
                </div>
                <div class="col-3">
                     <dx:ASPxMemo ID="ASPxMemo19" runat="server" Height="71px" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxMemo>
                </div>
                <div class="col-3">
                    <dx:ASPxMemo ID="ASPxMemo20" runat="server" Height="71px" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxMemo>
                </div>
                <div class="col-3">
                   <dx:ASPxMemo ID="ASPxMemo21" runat="server" Height="71px" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxMemo>
                </div>

                <div class="col">
                    <div class="row align-items-center">
                        <div class="col-1">
                           <asp:Button ID="btnST11" CssClass="btn btn-primary btn-sm" Text="-" runat="server"  OnClick="btnST11_Click" />
                      </div>
                      
                    </div>
                </div>

            </div>
      </asp:Panel>
        

         <%--Practicas Prohibidas de trabajo--%>

       <div class="row mt-3" >
           <div class="col" >
                   <h5 class="form-text">Practicas Peligorsas</h5>
           </div>
       </div>

        
       <div class="row mt-3" >
           
            <div class="col-10" >
               <dx:ASPxTextBox ID="txtPracticaDesc1" runat="server" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxTextBox>
            </div>
           <div class="col">
                    <div class="row align-items-center">
                        <div class="col-1">
                            <asp:Button ID="btnPP0"  CssClass="btn btn-primary btn-sm" Text="+" runat="server" OnClick="btnPP0_Click"  />
                        </div> 
                    </div>
             </div>
       </div>

        <asp:Panel ID="Panel7" runat="server" Visible="true">
            <div class="row mt-1" >
               
                <div class="col-10" >
                    <dx:ASPxTextBox ID="txtPracticaDesc2" runat="server" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxTextBox>
                </div>
                <div class="col">
                    <div class="row align-items-center">
                        <div class="col-1">
                           <asp:Button ID="btnPP1" CssClass="btn btn-primary btn-sm" Text="-" runat="server" OnClick="btnPP1_Click"   />
                      </div>
                       <div class="col-1">
                           <asp:Button ID="btnPP2"  CssClass="btn btn-primary btn-sm" Text="+" runat="server"  OnClick="btnPP2_Click"/>
                      </div> 

                    </div>
                </div>
           </div>
        </asp:Panel>

          <asp:Panel ID="Panel8" runat="server" Visible="true">
            <div class="row mt-1" >
                
                <div class="col-10" >
                    <dx:ASPxTextBox ID="txtPracticaDesc3" runat="server" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxTextBox>
                </div>
                <div class="col">
                    <div class="row align-items-center">
                        <div class="col-1">
                           <asp:Button ID="btnPP3" CssClass="btn btn-primary btn-sm" Text="-" runat="server"  OnClick="btnPP3_Click" />
                      </div>
                       <div class="col-1">
                           <asp:Button ID="btnPP4"  CssClass="btn btn-primary btn-sm" Text="+" runat="server"  OnClick="btnPP4_Click" />
                      </div> 

                    </div>
                </div>
           </div>
        </asp:Panel>

          <asp:Panel ID="Panel9" runat="server" Visible="true">
            <div class="row mt-1" >
                
                <div class="col-10" >
                    <dx:ASPxTextBox ID="txtPracticaDesc4" runat="server" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxTextBox>
                </div>
                <div class="col">
                    <div class="row align-items-center">
                        <div class="col-1">
                           <asp:Button ID="btnPP5" CssClass="btn btn-primary btn-sm" Text="-" runat="server"  OnClick="btnPP5_Click" />
                      </div>
                       <div class="col-1">
                           <asp:Button ID="btnPP6"  CssClass="btn btn-primary btn-sm" Text="+" runat="server" OnClick="btnPP6_Click" />
                      </div> 

                    </div>
                </div>
           </div>
        </asp:Panel>

          <asp:Panel ID="Panel10" runat="server" Visible="true">
            <div class="row mt-1" >
               
                <div class="col-10" >
                    <dx:ASPxTextBox ID="txtPracticaDesc5" runat="server" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxTextBox>
                </div>
                <div class="col">
                    <div class="row align-items-center">
                        <div class="col-1">
                           <asp:Button ID="btnPP7" CssClass="btn btn-primary btn-sm" Text="-" runat="server"  OnClick="btnPP7_Click" />
                      </div>
                       <div class="col-1">
                           <asp:Button ID="btnPP8"  CssClass="btn btn-primary btn-sm" Text="+" runat="server" OnClick="btnPP8_Click" />
                      </div> 

                    </div>
                </div>
           </div>
        </asp:Panel>

          <asp:Panel ID="Panel11" runat="server" Visible="true">
            <div class="row mt-1" >
               
                <div class="col-10" >
                    <dx:ASPxTextBox ID="txtPracticaDesc6" runat="server" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxTextBox>
                </div>
                <div class="col">
                    <div class="row align-items-center">
                        <div class="col-1">
                           <asp:Button ID="btnPP9" CssClass="btn btn-primary btn-sm" Text="-" runat="server"  OnClick="btnPP9_Click" />
                      </div>
                       <div class="col-1">
                           <asp:Button ID="btnPP10"  CssClass="btn btn-primary btn-sm" Text="+" runat="server" OnClick="btnPP10_Click" />
                      </div> 

                    </div>
                </div>
           </div>
        </asp:Panel>

          <asp:Panel ID="Panel12" runat="server" Visible="true">
            <div class="row mt-1" >
                
                <div class="col-10" >
                    <dx:ASPxTextBox ID="txtPracticaDesc7" runat="server" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxTextBox>
                </div>
                <div class="col">
                    <div class="row align-items-center">
                        <div class="col-1">
                           <asp:Button ID="btnPP11" CssClass="btn btn-primary btn-sm" Text="-" runat="server"   OnClick="btnPP11_Click"/>
                      </div>
                       <div class="col-1">
                           <asp:Button ID="btnPP12"  CssClass="btn btn-primary btn-sm" Text="+" runat="server" OnClick="btnPP12_Click"/>
                      </div> 

                    </div>
                </div>
           </div>
        </asp:Panel>

          <asp:Panel ID="Panel13" runat="server" Visible="true">
            <div class="row mt-1" >
                
                <div class="col-10" >
                    <dx:ASPxTextBox ID="txtPracticaDesc8" runat="server" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxTextBox>
                </div>
                <div class="col">
                    <div class="row align-items-center">
                        <div class="col-1">
                           <asp:Button ID="btnPP13" CssClass="btn btn-primary btn-sm" Text="-" runat="server"   OnClick="btnPP13_Click"/>
                      </div>
                      
                    </div>
                </div>
           </div>
        </asp:Panel>


        <div class="row mt-5">
            <div class="col">
                  <div class="card">
                      <div class="card-body" style="background-color:ghostwhite">
                         Tengo Conocimiento del presente AST (ANALISIS DE SEGURIDAD EN EL TRABAJO), el cual he leido y comprendido de los riesgos y peligros que implica REALIZAR la tarea, asi como los las medidas de Seguridad implementadas para eliminar y controlar los riesgos y peligros, el cual me obligo y comprometo a seguir y respetar para prevenir los accidentes de trabjo.
                      </div>

                  </div>
            </div>
        </div>

            <div class="row mt-5">
                 <div class="col-3 text-center">
                    <dx:ASPxTextBox ID="txtNombre1" runat="server" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxTextBox>
                    <label class="col-form-label">Elaboro: Nombre y firma</label>                 
                </div>
                <div class="col-3 text-center">
                    <dx:ASPxTextBox ID="txtNombre2" runat="server" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxTextBox>
                    <label class="col-form-label">Elaboro: Nombre y firma</label>
                </div>
                <div class="col-3 text-center">
                    <dx:ASPxTextBox ID="txtNombre3" runat="server" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxTextBox>
                    <label class="col-form-label">Elaboro: Nombre y firma</label>
                </div>
                 <div class="col">
                    <div class="row align-items-center">
                        <div class="col-1">
                           <asp:Button ID="btnPI0" CssClass="btn btn-primary btn-sm" Text="+" runat="server"  OnCLick="btnPI0_Click" />
                      </div>
                      
                    </div>
                </div>
            </div>

        <asp:Panel ID="Panel14" runat="server" Visible="true">
           <div class="row mt-1">
                 <div class="col-3 text-center">
                    <dx:ASPxTextBox ID="txtNombre4" runat="server" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxTextBox>
                    <label class="col-form-label">Elaboro: Nombre y firma</label>                 
                </div>
                <div class="col-3 text-center">
                    <dx:ASPxTextBox ID="txtNombre5" runat="server" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxTextBox>
                    <label class="col-form-label">Elaboro: Nombre y firma</label>
                </div>
                <div class="col-3 text-center">
                    <dx:ASPxTextBox ID="txtNombre6" runat="server" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxTextBox>
                    <label class="col-form-label">Elaboro: Nombre y firma</label>
                </div>
                 <div class="col">
                    <div class="row align-items-center">
                        <div class="col-1">
                           <asp:Button ID="btnPI1" CssClass="btn btn-primary btn-sm" Text="-" runat="server"  OnClick="btnPI1_Click"  />
                      </div>
                       <div class="col-1">
                           <asp:Button ID="btnPI2"  CssClass="btn btn-primary btn-sm" Text="+" runat="server" OnClick="btnPI2_Click" />
                      </div> 

                    </div>
                </div>
            </div>
        </asp:Panel>

         <asp:Panel ID="Panel15" runat="server" Visible="true">
           <div class="row mt-1">
                 <div class="col-3 text-center">
                    <dx:ASPxTextBox ID="txtNombre7" runat="server" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxTextBox>
                    <label class="col-form-label">Elaboro: Nombre y firma</label>                 
                </div>
                <div class="col-3 text-center">
                    <dx:ASPxTextBox ID="txtNombre8" runat="server" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxTextBox>
                    <label class="col-form-label">Elaboro: Nombre y firma</label>
                </div>
                <div class="col-3 text-center">
                    <dx:ASPxTextBox ID="txtNombre9" runat="server" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxTextBox>
                    <label class="col-form-label">Elaboro: Nombre y firma</label>
                </div>
                 <div class="col">
                    <div class="row align-items-center">
                        <div class="col-1">
                           <asp:Button ID="btnPI3" CssClass="btn btn-primary btn-sm" Text="-" runat="server"  OnClick="btnPI3_Click" />
                      </div>
                       <div class="col-1">
                           <asp:Button ID="btnPI4"  CssClass="btn btn-primary btn-sm" Text="+" runat="server"  OnClick="btnPI4_Click" />
                      </div> 

                    </div>
                </div>
            </div>
        </asp:Panel>

         <asp:Panel ID="Panel16" runat="server" Visible="true">
           <div class="row mt-1">
                 <div class="col-3 text-center">
                    <dx:ASPxTextBox ID="txtNombre10" runat="server" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxTextBox>
                    <label class="col-form-label">Elaboro: Nombre y firma</label>                 
                </div>
                <div class="col-3 text-center">
                    <dx:ASPxTextBox ID="txtNombre11" runat="server" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxTextBox>
                    <label class="col-form-label">Elaboro: Nombre y firma</label>
                </div>
                <div class="col-3 text-center">
                    <dx:ASPxTextBox ID="txtNombre12" runat="server" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxTextBox>
                    <label class="col-form-label">Elaboro: Nombre y firma</label>
                </div>
                 <div class="col">
                    <div class="row align-items-center">
                        <div class="col-1">
                           <asp:Button ID="btnPI5" CssClass="btn btn-primary btn-sm" Text="-" runat="server"  OnClick="btnPI5_Click" />
                        </div> 
                    </div>
                </div>
            </div>
        </asp:Panel>

          <%--plab de respuesta--%>

       <div class="row mt-3" >
           <div class="col" >
                <h5 class="form-text">Plan de respuesta en caso de emergencia</h5>
               <dx:ASPxMemo ID="txtPlanRespuesta" runat="server" Height="71px" Width="100%" CssClass="form-control" MaxLength="500" Theme="Aqua" BackColor="#F8F8F8"></dx:ASPxMemo>
           </div>
       </div>

        <div class="row mt-5" >
           <div class="col-auto" >
                <asp:Button runat="server" CssClass="btn btn-primary btn-block" Text="Guardar"  ID="btnGrabar" OnClick="btnGrabar_Click"/>
           </div>
            <div class="col-auto" >
                <asp:Button runat="server" CssClass="btn btn-primary btn-block" Text="Guardar y Enviar Notificacion"  Enabled="false" ID="btnGrabaFinal" OnClick="btnGrabaFinal_Click"/> 
           </div>
            <div class="col-auto" >
                <asp:Button runat="server" CssClass="btn btn-primary btn-block" Text="Cancelar"  ID="btnCancelar" OnClick="btnCancelar_Click" /> 
           </div>

             <div class="col-3 " >
                
             </div>
             <div class="col-2 " >
                <asp:Button runat="server" CssClass="btn btn-danger btn-block" Text="Eliminar documento"  ID="Button29" OnClick="btnEliminar_Click" /> 
           </div>
       </div>

       
        <br /> <br />


        <dx:ASPxHiddenField ID="hfIsNew" runat="server" ClientInstanceName="hfIsNew"> </dx:ASPxHiddenField>

    </form>

        
    </div>


   
</body>
</html>
