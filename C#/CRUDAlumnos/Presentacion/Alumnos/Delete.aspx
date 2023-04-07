<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="Presentacion.Alumnos.Delete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="container-fluid">
        <h2>Datos del Alumno</h2>
        <!-- Control asp Label para mensajes -->
        <hr />
            <h3>Esta seguro que desea eliminar el Alumno?</h3>
        <div class="row">
            <dl>
                <div class="col-sm-2">
                    <div class="text-right">
                    <dt>ID
                    </dt>
                    <dt>Nombre
                    </dt>
                    <dt>Primer Apellido
                    </dt>
                    <dt>Segundo Apellido
                    </dt>
                    <dt>Fecha Nacimiento
                    </dt>
                    <dt>CURP
                    </dt>
                    <dt>Correo
                    </dt>
                    <dt>Telefono
                    </dt>
                    <dt>Sueldo Mensual
                    </dt>
                    <dt>Estado
                    </dt>
                    <dt>Estatus
                    </dt>

                    </div>
                </div>

                <div class="col-sm-9">
                    <dd>
                        <asp:Label ID="lblId" runat="server" Text="ID"></asp:Label>
                    </dd>
                    <dd>
                        <asp:Label ID="lblNombre" runat="server" Text="NOMBRE"></asp:Label>
                    </dd>
                    <dd>
                        <asp:Label ID="lblApePat" runat="server" Text="PALLIDO"></asp:Label>
                    </dd>

                    <dd>
                        <asp:Label ID="lblApeMat" runat="server" Text="SALLIDO"></asp:Label>
                    </dd>

                    <dd>
                        <asp:Label ID="lblFecha" runat="server" Text="FECHA"></asp:Label>
                    </dd>

                    <dd>
                        <asp:Label ID="lblCurp" runat="server" Text="IDE"></asp:Label>
                    </dd>

                    <dd>
                        <asp:Label ID="lblCorreo" runat="server" Text="CORREO"></asp:Label>
                    </dd>

                    <dd>
                        <asp:Label ID="lblTelefono" runat="server" Text="TELEFONO"></asp:Label>
                    </dd>

                    <dd>
                        <asp:Label ID="lblSueldo" runat="server" Text="SUELDO"></asp:Label>
                    </dd>

                    <dd>
                        <asp:Label ID="lblEstado" runat="server" Text="ESTADO"></asp:Label>
                    </dd>

                    <dd>
                        <asp:Label ID="lblEstatus" runat="server" Text="ESTATUS"></asp:Label>
                    </dd>

                </div>

            </dl>
        </div>
        <br />

    
        <div class="row">
            <div class="col-sm-2">
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" BackColor="#0066FF" BorderStyle="None" CssClass="btn-sm" ForeColor="White" OnClick="btnEliminar_Click" />
            </div>
            <div class="col-sm-2">
                
            </div>
            <div class="col-sm-8">

            </div>
        </div>
        <br />
            <div>
                <a href="Index.aspx">Regresar a la lista</a>
            </div>

    </div>
</asp:Content>
