<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="Presentacion.Alumnos.Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <%--descargar paquete nuget AjaxControlToolkit para controles --%>
        <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
    <asp:Label ID="lblHidden" runat="server" Text=""></asp:Label>
   <%-- Para levantar ventana modal desde el servidor --%>
    <ajaxToolkit:ModalPopupExtender ID="mpeModalISR" runat="server" TargetControlID="lblHidden" PopupControlID="venModalSrvISR" DropShadow="true"></ajaxToolkit:ModalPopupExtender>

    <div class="container-fluid">
        <h2>Datos del Alumno</h2>
        <!-- Control asp Label para mensajes -->
        <hr />
        <div class="row">
            <dl >
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
        <br />
        <div>
            <asp:Label ID="lblMensaje" runat="server" Text="Mensaje" CssClass="text-info" Visible="False"></asp:Label>
        </div>
        <br />

        <div class="row">
            <div class="col-sm-2">
                <input id="btnImss" type="button" onclick="CalcularIMSS()" class="btn btn-primary btn-sm" value="CalcularIMSS" />
            </div>
            <div class="col-sm-2">
                <asp:Button ID="btnIsr" runat="server" Text="CalcularISR" BorderStyle="Outset" CssClass="btn-sm" OnClick="btnIsr_Click" BorderColor="#0000CC" />
            </div>
            <div class="col-sm-8">

            </div>
        </div>
        <br />
            <div>
                <a href="Index.aspx">Regresar a la lista</a>
            </div>
    </div>

     <%--Ventana Modal ISR - Servidor--%>
    <div id="venModalSrvISR">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h4 class="modal-title">Cálculo del ISR</h4>
                    <asp:Button ID="btnXISR" runat="server" Text="&times;" class="close"  />
                </div>
                <!-- Cuerpo de la Modal -->
                <div class="modal-body">
                    <dl>
                        <dt>Limite Inferior</dt>
                        <dd>
                            <asp:Label ID="lblLimInf" runat="server" Text="Label"></asp:Label>
                        </dd>
                        <dt>Limite Superior</dt>
                        <dd>
                            <asp:Label ID="lblLimSup" runat="server" Text="Label"></asp:Label>
                        </dd>

                        <dt>Cuota Fija</dt>
                        <dd>
                            <asp:Label ID="lblCuotaFija" runat="server" Text="Label"></asp:Label>
                        </dd>
                        <dt>Excedente Limite Inferior</dt>
                        <dd>
                            <asp:Label ID="lblExcedente" runat="server" Text="Label"></asp:Label>
                        </dd>

                        <dt>Subsidio</dt>
                        <dd>
                            <asp:Label ID="lblSubsidio" runat="server" Text="Label"></asp:Label>
                        </dd>
                        <dt>Impuesto</dt>
                        <dd>
                            <asp:Label ID="lblImpuesto" runat="server" Text="Label"></asp:Label>
                        </dd>
                    </dl>
                </div>
                <!-- Modal footer -->
                <div class="modal-footer">
                    <asp:Button ID="btnCerrarISR" runat="server" Text="Cerrar" CssClass="btn btn-danger" />
                </div>
            </div>
        </div>
    </div>

    <br />
        <%--Ventana Modal IMSS - Cliente--%>
  <div class="modal" id="venModalclienteIMSS">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h4 class="modal-title">Cálculo del IMSS</h4>
                    <asp:Button ID="btnX" runat="server" Text="&times;" class="close" />
                </div>
                <!-- Cuerpo de la Modal -->
                <div class="modal-body">
                    <dl>
                        <dt>Enfermedades y Maternidad</dt>
                        <dd>
                            <asp:Label ID="lblEnfermedades" runat="server" Text="Label"></asp:Label>
                        </dd>
                        <dt>Invalidez y Vida</dt>
                        <dd>
                            <asp:Label ID="lblInvalidez" runat="server" Text="Label"></asp:Label>
                        </dd>
                        <dt>Retiro</dt>
                        <dd>
                            <asp:Label ID="lblRetiro" runat="server" Text="Label"></asp:Label>
                        </dd>

                        <dt>Cesantia</dt>
                        <dd>
                            <asp:Label ID="lblCesantia" runat="server" Text="Label"></asp:Label>
                        </dd>
                        <dt>Infonavit</dt>
                        <dd>
                            <asp:Label ID="lblInfonavit" runat="server" Text="Label"></asp:Label>
                        </dd>

                    </dl>

                </div>
                <!-- Modal footer -->
                <div class="modal-footer">
                    <button type="button" class="btn btn-danger" data-dismiss="modal">Cerrar</button>
                </div>
            </div>
        </div>
    </div>


    <script type="text/javascript">
        function CalcularIMSS() {
            var urlws = 'http://localhost:62351/WSAlumnos.asmx/CalcularIMSS';
            var id = $("#<%=lblId.ClientID%>").text();
            var alumno = { id: id }
            var parametros = JSON.stringify(alumno);
            LlamadaAJAXPost(urlws, parametros, MuestraAportacionesIMSS)
        }

        function LlamadaAJAXPost(url, parametros, funcionExito) {
            $.ajax({
                type: 'POST',
                url: url,
                data: parametros,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: funcionExito,
                error: errorGenerico
            });

        }

        function MuestraAportacionesIMSS(data) {
            try
            {
                imss = data.d;
                if (imss != null) {
                    $("#<%=lblEnfermedades.ClientID%>").text( imss.EnfermedadMaternidad);
                    $("#<%=lblInvalidez.ClientID%>").text(imss.InvalidezVida);
                    $("#<%=lblRetiro.ClientID%>").text(imss.Retiro);
                    $("#<%=lblCesantia.ClientID%>").text(imss.Cesantía);
                    $("#<%=lblInfonavit.ClientID%>").text(imss.Infonavit);
                    $("#venModalclienteIMSS").modal();
                }
                else
                {
                    alert('La respuesta recibida del web service es incorrecta ' + data.d);
                }
            }
            catch (ex)
            {
                alumno = [];
                alert('Error al recibir los datos');

            }

        }

        function errorGenerico(jqXHR, exception) {
            var msg = '';
            if (jqXHR.status === 0) {
                msg = 'No está conectado, favor de verificar su conexión.';
            }
            else if (jqXHR.status === 404) {
                msg = 'Página no encontrada [404]';
            }
            else if (jqXHR.status === 500) {
                msg = 'Error no hay conexión al servidor [500]';
            }
            else if (jqXHR.status === 'parseerror') {
                msg = 'El parseo del JSON es erróneo.';
            }
            else if (jqXHR.status === 'timeout') {
                $('body').addClass('loaded');
            }
            else if (jqXHR.status === 'abort') {
                msg = 'La petición Ajax fue abortada.';
            }
            else {
                msg = 'Error no conocido. ';
                console.log(exception);
            }
            alert(msg);
        }

    </script>
</asp:Content>
