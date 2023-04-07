<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="ADOWebForms.Forms.Delete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Eliminar</h1>
    <br />
     <strong><asp:Label ID="lblId" runat="server" Text="Id"></asp:Label></strong>
     <asp:Label ID="lblIdValor" runat="server" Text="1"></asp:Label>
    <br />
     <strong><asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label></strong>
     <asp:Label ID="lblNombreValor" runat="server" Text="2"></asp:Label>
    <br />
     <strong><asp:Label ID="lblClave" runat="server" Text="Clave"></asp:Label></strong>
     <asp:Label ID="lblClaveValor" runat="server" Text="3"></asp:Label>
    <br /><br />
     <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
    <br /><br />
     <a href="Index.aspx">Regresar a la lista</a>
</asp:Content>
