﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MaFuncionario.Master" AutoEventWireup="true" CodeBehind="EstadoPermisosFuncionario.aspx.cs" Inherits="GestionDePermisos.Views.Funcionario.EstadoPermisosFuncionario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../../Scripts/operation.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form>
        <div class="alert alert-warning" runat="server" id="errorBuscaSolicitud" style="display:block">
            <button type="button" class="close" data-dismiss="modal"><span aria-hidden="true" id="btnClose">×</span><span class="sr-only">Close</span></button>
            <strong>Ups!</strong> No tiene solicitudes asociadas.
        </div>
    </form>
    <div class="container" id="containerTabla" runat="server" hidden>
        <div class="panel">
            <div class="row">
                <div class="col-md-12">
                    <h4>Listado de solicitudes</h4>
                    <div class="table-responsive">
                        <asp:Table runat="server" CssClass="table table-bordred table-striped" ID="tablaEstadoPermisos">
                            <asp:TableRow TableSection="TableHeader">
                                <asp:TableHeaderCell>ID Solicitud</asp:TableHeaderCell>
                                <asp:TableHeaderCell>Descripcion</asp:TableHeaderCell>
                                <asp:TableHeaderCell>Fecha Solicitud</asp:TableHeaderCell>
                                <asp:TableHeaderCell>Fecha Inicio</asp:TableHeaderCell>
                                <asp:TableHeaderCell>Fecha Termino</asp:TableHeaderCell>
                                <asp:TableHeaderCell>Tipo Permiso</asp:TableHeaderCell>
                                <asp:TableHeaderCell>Rut Solicitante</asp:TableHeaderCell>
                                <asp:TableHeaderCell>Rut Autorizador</asp:TableHeaderCell>
                                <asp:TableHeaderCell>Estado</asp:TableHeaderCell>
                                <asp:TableHeaderCell>Accion</asp:TableHeaderCell>
                            </asp:TableRow>
                        </asp:Table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
