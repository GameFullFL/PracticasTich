<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Presentacion.Alumnos.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Listado de Alumnos</h1>
    <hr />
    <div>
        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn btn-primary" OnClick="btnAgregar_Click" />
    </div>
    <hr />
            <asp:GridView ID="gVListaAlumnos" runat="server" AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="gVListaAlumnos_PageIndexChanging" OnRowCommand="gVListaAlumnos_RowCommand" PageSize="5"  BorderStyle="None" CssClass="table" GridLines="Horizontal"  >
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="ID" />
                    <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="primerApellido" HeaderText="Primer Apellido" />
                    <asp:BoundField DataField="segundoApellido" HeaderText="Segundo Apellido" />
                    <asp:BoundField DataField="correo" HeaderText="Correo" />
                    <asp:BoundField DataField="telefono" HeaderText="Telefono" />
                    <asp:BoundField DataField="idEstadoOrigen" HeaderText="Estado" />
                    <asp:BoundField DataField="idEstatus" HeaderText="Estatus" />
                    <asp:ButtonField CommandName="btnDetalles" Text="Detalles">
                        <ControlStyle CssClass="btn btn-warning btn-sm" />
                    </asp:ButtonField>
                    <asp:ButtonField CommandName="btnEditar" Text="Editar">
                        <ControlStyle CssClass="btn btn-success btn-sm" />
                    </asp:ButtonField>
                    <asp:ButtonField CommandName="btnEliminar" Text="Eliminar">
                        <ControlStyle CssClass="btn btn-danger btn-sm" />
                    </asp:ButtonField>
                </Columns>
            </asp:GridView>


</asp:Content>
