﻿using GestionDePermisos.Business;
using GestionDePermisos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestionDePermisos.Views.Jefe_Interno
{
    public partial class AutorizarSolicitud : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            ClientScript.GetPostBackEventReference(this, "");

            if (!IsPostBack)
            {
                if (Session["jefeInterno"] == null)
                {
                    FormsAuthentication.SignOut();
                    Response.Redirect("../../Default.aspx");                    
                }
                cargarListadoCompleto();
            }            
            if (Request["__EVENTTARGET"] == "aprobar")
            {
                aprobarSolicitud();
            }

            if (Request["__EVENTTARGET"] == "rechazar")
            {
                rechazarSolicitud();
            }

        }
     
        private string retornarEstado(int id)
        {
            NegocioEstado negocioEstado = new NegocioEstado();
            return negocioEstado.nameByID(id);
        }

        private string retornarTipoPermiso(int id)
        {
            NegocioTipoPermiso negocioTipoPermiso = new NegocioTipoPermiso();
            return negocioTipoPermiso.nameByID(id);
        }
        private void cargarListadoCompleto()
        {
            NegocioSolicitud negocioSolicitud = new NegocioSolicitud();
            NegocioCuenta negocioCuenta = new NegocioCuenta();
            NegocioEmpleado negocioEmpleado = new NegocioEmpleado();
            NegocioMotivo negocioMotivo = new NegocioMotivo();
            tituloEstado.Visible = true;
            foreach (var item in negocioSolicitud.listadoConDepartamento(retornarDepartamento(retornarRutAutorizador())))
            {
                TableRow tableRow = new TableRow();
                TableCell codigoDocumento = new TableCell();
                TableCell descripcion = new TableCell();
                TableCell nombreSolicitante = new TableCell();
                TableCell fechaSolicitud = new TableCell();
                TableCell fechaInicio = new TableCell();
                TableCell fechaTermino = new TableCell();
                TableCell tipoPermiso = new TableCell();
                TableCell Motivo = new TableCell();
                TableCell rutSolicitante = new TableCell();
                TableCell rutAutorizador = new TableCell();
                TableCell estado = new TableCell();

                tablaEstadoPermisos.Rows.Add(tableRow);
                codigoDocumento.Text = item.codigoDocumento;
                descripcion.Text = item.descripcion;
                fechaSolicitud.Text = item.fechaSolicitud.ToString("dd/MM/yyyy");
                fechaInicio.Text = item.fechaInicio.ToString("dd/MM/yyyy");
                fechaTermino.Text = item.fechaTermino.ToString("dd/MM/yyyy");
                tipoPermiso.Text = retornarTipoPermiso(item.idTipoPermiso);
                rutSolicitante.Text = item.rutSolicitante.ToString();
                nombreSolicitante.Text = negocioEmpleado.retornarNombreByRut(item.rutSolicitante);

                if (item.rutAutorizante == null)
                {
                    rutAutorizador.Text = "Sin asignar";
                }
                else
                {
                    rutAutorizador.Text = item.rutAutorizante.ToString();
                }

                Motivo.Text = negocioMotivo.nameByID(item.idMotivo);
                estado.Text = retornarEstado(item.idEstado);
                tableRow.ID = item.codigoDocumento.ToString();
                tableRow.Attributes.Add("onClick", "modalTabla(this.id)");



                tableRow.Cells.Add(codigoDocumento);
                tableRow.Cells.Add(descripcion);
                tableRow.Cells.Add(nombreSolicitante);
                nombreSolicitante.Attributes.Add("hidden", "");
                tableRow.Cells.Add(fechaSolicitud);
                tableRow.Cells.Add(fechaInicio);
                tableRow.Cells.Add(fechaTermino);
                tableRow.Cells.Add(tipoPermiso);
                tableRow.Cells.Add(rutSolicitante);
                rutSolicitante.Attributes.Add("hidden", "");
                tableRow.Cells.Add(rutAutorizador);
                rutAutorizador.Attributes.Add("hidden", "");
                tableRow.Cells.Add(Motivo);
                tableRow.Cells.Add(estado);
            }
        }
        private void cargarTablaPorEstado(int valor)
        {
            tituloEstado.Visible = false;
            NegocioSolicitud negocioSolicitud = new NegocioSolicitud();
            NegocioCuenta negocioCuenta = new NegocioCuenta();
            NegocioEmpleado negocioEmpleado = new NegocioEmpleado();
            NegocioMotivo negocioMotivo = new NegocioMotivo();
            foreach (var item in negocioSolicitud.listadoFiltradoByDepartamento(retornarDepartamento(retornarRutAutorizador()), valor))
            {
                TableRow tableRow = new TableRow();
                TableCell codigoDocumento = new TableCell();
                TableCell descripcion = new TableCell();
                TableCell nombreSolicitante = new TableCell();
                TableCell fechaSolicitud = new TableCell();
                TableCell fechaInicio = new TableCell();
                TableCell fechaTermino = new TableCell();
                TableCell tipoPermiso = new TableCell();
                TableCell Motivo = new TableCell();
                TableCell rutSolicitante = new TableCell();
                TableCell rutAutorizador = new TableCell();
                TableCell estado = new TableCell();

                tablaEstadoPermisos.Rows.Add(tableRow);
                codigoDocumento.Text = item.codigoDocumento;
                descripcion.Text = item.descripcion;
                fechaSolicitud.Text = item.fechaSolicitud.ToString("dd/MM/yyyy");
                fechaInicio.Text = item.fechaInicio.ToString("dd/MM/yyyy");
                fechaTermino.Text = item.fechaTermino.ToString("dd/MM/yyyy");
                tipoPermiso.Text = retornarTipoPermiso(item.idTipoPermiso);
                rutSolicitante.Text = item.rutSolicitante.ToString();
                nombreSolicitante.Text = negocioEmpleado.retornarNombreByRut(item.rutSolicitante);

                if (item.rutAutorizante == null)
                {
                    rutAutorizador.Text = "Sin asignar";
                }
                else
                {
                    rutAutorizador.Text = item.rutAutorizante.ToString();
                }

                Motivo.Text = negocioMotivo.nameByID(item.idMotivo);
                estado.Text = retornarEstado(item.idEstado);
                tableRow.ID = item.codigoDocumento.ToString();
                tableRow.Attributes.Add("onClick", "modalTabla(this.id)");


                tableRow.Cells.Add(codigoDocumento);
                tableRow.Cells.Add(descripcion);
                tableRow.Cells.Add(nombreSolicitante);
                nombreSolicitante.Attributes.Add("hidden", "");
                tableRow.Cells.Add(fechaSolicitud);
                tableRow.Cells.Add(fechaInicio);
                tableRow.Cells.Add(fechaTermino);
                tableRow.Cells.Add(tipoPermiso);
                tableRow.Cells.Add(rutSolicitante);
                rutSolicitante.Attributes.Add("hidden", "");
                tableRow.Cells.Add(rutAutorizador);
                rutAutorizador.Attributes.Add("hidden", "");
                tableRow.Cells.Add(Motivo);
                tableRow.Cells.Add(estado);            
            }
        }
        
        protected void btnAprobados_Click(object sender, EventArgs e)
        {
            cargarTablaPorEstado(3);
            containerTabla.Attributes.Remove("hidden");
        }

        protected void aprobarSolicitud()
        {
            NegocioSolicitud negocioSolicitud = new NegocioSolicitud();
            Solicitud newSolicitud = new Solicitud();
            var solicitud = Request["__EVENTARGUMENT"].ToString();
            newSolicitud.codigoDocumento = solicitud;
            newSolicitud.rutAutorizante = retornarRutAutorizador();
            newSolicitud.idEstado = 3;
            negocioSolicitud.updateSolicitud(newSolicitud);
            cargarListadoCompleto();
        }


        protected void rechazarSolicitud()
        {
            NegocioSolicitud negocioSolicitud = new NegocioSolicitud();
            Solicitud newSolicitud = new Solicitud();
            var solicitud = Request["__EVENTARGUMENT"].ToString();
            newSolicitud.codigoDocumento = solicitud;
            newSolicitud.rutAutorizante = retornarRutAutorizador();
            newSolicitud.idEstado = 5;
            negocioSolicitud.updateSolicitud(newSolicitud);
            cargarListadoCompleto();
        }

        protected void btnPendientes_Click(object sender, EventArgs e)
        {
            cargarTablaPorEstado(4);
            containerTabla.Attributes.Remove("hidden");
        }
        protected void btnRechazados_Click(object sender, EventArgs e)
        {
            cargarTablaPorEstado(5);
            containerTabla.Attributes.Remove("hidden");
        }
        protected void btnTodos_Click(object sender, EventArgs e)
        {
            cargarListadoCompleto();    
            containerTabla.Attributes.Remove("hidden");
        }
        private string retornarRutAutorizador()
        {
            string rut = string.Empty;
            string usuario = Session["usuario"].ToString();
            NegocioCuenta negocioCuenta = new NegocioCuenta();
            NegocioEmpleado negocioEmpleado = new NegocioEmpleado();
            rut = negocioEmpleado.retornarRutByCuentaID(negocioCuenta.retornarID(usuario));
            return rut;
        }
        private int retornarDepartamento(string rut)
        {
            int departamento = default(int);
            NegocioEmpleado negocioEmpleado = new NegocioEmpleado();
            departamento = negocioEmpleado.retornarDepartamentoByRut(rut);
            return departamento;
        }
    }
}