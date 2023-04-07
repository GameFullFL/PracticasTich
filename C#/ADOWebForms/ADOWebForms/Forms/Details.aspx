<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="ADOWebForms.Forms.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Detalles</h1>
    <br />
    <strong><asp:Label ID="lblId" runat="server" Text="Id"></asp:Label></strong>
     <asp:Label ID="lblIdValor" runat="server" Text="numero"></asp:Label>
    <br />
     <strong><asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label></strong>
     <asp:Label ID="lblNombreValor" runat="server" Text="Prueba"></asp:Label>
    <br />
     <strong><asp:Label ID="lblClave" runat="server" Text="Clave"></asp:Label></strong>
     <asp:Label ID="lblClaveValor" runat="server" Text="numeross"></asp:Label>
    <br /><br />
    <a href="Index.aspx">Regresar a la lista</a>
</asp:Content>
