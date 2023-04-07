<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Presentacion.Alumnos.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <h2>Actualizar Alumno</h2>
    <!-- Control asp Label para mensajes -->
    <hr />
    <br />
      <div class="row">
        <dl>
            <div class="col-sm-2">
                <div class="text-right">
                    <dt class="form-control">Id
                    </dt>
                    <dt class="form-control">Nombre
                    </dt>
                    <br /><br />
                    <dt class="form-control">Primer Apellido
                    </dt>
                    <br /><br />
                    <dt class="form-control">Segundo Apellido
                    </dt >
                    <br />
                    <dt class="form-control">Fecha Nacimiento
                    </dt>
                    <br /><br />
                    <dt class="form-control">CURP
                    </dt>
                    <br /><br />
                    <dt class="form-control">Correo
                    </dt>
                    <br />
                    <dt class="form-control">Telefono
                    </dt>
                    <dt class="form-control">Sueldo Mensual
                    </dt>
                    <br />
                    <dt class="form-control">Estado
                    </dt>
                    <dt class="form-control">Estatus
                    </dt>

                </div>
            </div>

            <div class="col-sm-9">
                 <dd>
                    <asp:TextBox ID="txtId" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
                </dd>
                <dd>
                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rvNombre" runat="server" ErrorMessage="El campo nombre es requerido" CssClass="text-danger" ControlToValidate="txtNombre"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="reNombre" runat="server" ErrorMessage="Nombre inválido" ControlToValidate="txtNombre" CssClass="text-danger" ValidationExpression="^[a-zA-Z]+(\s*[a-zA-Z]*)*[a-zA-Z]+$"></asp:RegularExpressionValidator>
                </dd>
                <dd>
                    <asp:TextBox ID="txtApePat" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rvApePat" runat="server" ErrorMessage="El campo primer apellido es requerido" CssClass="text-danger" ControlToValidate="txtApePat"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="rePrimerApe" runat="server" ErrorMessage="Primer apellido inválido" ControlToValidate="txtApePat" CssClass="text-danger" ValidationExpression="^[a-zA-Z]+(\s*[a-zA-Z]*)*[a-zA-Z]+$"></asp:RegularExpressionValidator>
                </dd>

                <dd>
                    <asp:TextBox ID="txtApeMat" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="reSegundoApe" runat="server" ErrorMessage="Segundo apellido inválido" ControlToValidate="txtApeMat" CssClass="text-danger" ValidationExpression="^[a-zA-Z]+(\s*[a-zA-Z]*)*[a-zA-Z]+$"></asp:RegularExpressionValidator>
                </dd>

                <dd>
                    <asp:TextBox ID="txtFechaNac" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rvFechaNac" runat="server" ErrorMessage="El campo fecha de nacimiento es requerido" CssClass="text-danger" ControlToValidate="txtFechaNac"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RangeValidator ID="rVFechaNaci" runat="server" MaximumValue="31- 12 -2000" MinimumValue="01-01-1990" CssClass="text-danger" ErrorMessage="El campo no se encuentra en el rango correcto" ControlToValidate="txtFechaNac"></asp:RangeValidator>
                </dd>

                <dd>
                    <asp:TextBox ID="txtCurp" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rvCurp" runat="server" ErrorMessage="El campo curp es requerido" CssClass="text-danger" ControlToValidate="txtCurp"></asp:RequiredFieldValidator>
                    <br />
                    <asp:CustomValidator ID="cvCurpVSFecha" runat="server" ErrorMessage="La curp y la fecha no coinciden" CssClass="text-danger" ControlToValidate="txtCurp" OnServerValidate="cvCurpVSFecha_ServerValidate"></asp:CustomValidator>
                </dd>

                <dd>
                    <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rvCorreo" runat="server" ErrorMessage="El campo correo es requerido" CssClass="text-danger" ControlToValidate="txtCorreo"></asp:RequiredFieldValidator>
                </dd>

                <dd>
                    <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" TextMode="Phone"></asp:TextBox>
                </dd>

                <dd>
                    <asp:TextBox ID="txtSueldo" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                    <asp:RangeValidator ID="rvSueldo" runat="server" MaximumValue="40000" MinimumValue="10000" CssClass="text-danger" ErrorMessage="El campo sueldo debe tener un valor entre 10000 y 40000" ControlToValidate="txtSueldo"></asp:RangeValidator>
                </dd>

                <dd>
                    <asp:DropDownList ID="cmbEstadoOrigen" runat="server" CssClass="form-control"></asp:DropDownList>
                </dd>

                <dd>
                    <asp:DropDownList ID="cmbEstatus" runat="server" CssClass="form-control"></asp:DropDownList>
                </dd>

            </div>

        </dl>
    </div>



    <br />


    <div class="row">
        <div class="col-sm-2">
            <asp:Button ID="btnGuardar" runat="server" Text="Actualizar" BackColor="#0066FF" BorderStyle="None" CssClass="btn-sm" ForeColor="White" OnClick="btnGuardar_Click" />
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
      <script type="text/javascript" >
        function curpVsFecha(source, args)
        {
            let fechaNac = $("#<%= txtFechaNac.ClientID%>").val();
            let curpPartFecha = $("#<%= txtCurp.ClientID%>").val().substr(4, 6);
            let fechaNacFormatCurp = fechaNac.substr(2, 2) + fechaNac.substr(5, 2) + fechaNac.substr(8,2);
            args.IsValid = curpPartFecha == fechaNacFormatCurp;
        }
      </script>

</asp:Content>
