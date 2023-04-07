<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="ADOWebForms.Forms.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Actualizar</h1>
    <div>
    <br />
    <strong><asp:Label ID="lblId" runat="server" Text="Id"></asp:Label></strong>
    <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
    </div>
    <div>
    <br />
    <strong><asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label></strong>
    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
    </div>
    <div>
    <br />
    <strong><asp:Label ID="lblClave" runat="server" Text="Clave"></asp:Label></strong>
    <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
    </div>
    <br />
    <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
    <br /><br />
     <a href="Index.aspx">Regresar a la lista</a>
</asp:Content>
