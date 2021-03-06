﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionDePermisos.Models
{
    public class Solicitud
    {
        public int idSolicitud { set; get; }
        public string codigoDocumento { get; set; }
        public string descripcion { set; get; }
        public DateTime fechaSolicitud { set; get; }
        public DateTime fechaInicio { set; get; }
        public DateTime fechaTermino { set; get; }
        public int idTipoPermiso { set; get; }
        public string rutSolicitante { set; get; }
        public string rutAutorizante { set; get; }
        public int idEstado { set; get; }
        public int idMotivo { get; set; }

        public Solicitud()
        {
            idSolicitud = default(int);
            codigoDocumento = string.Empty;
            descripcion = string.Empty;
            fechaSolicitud = default(DateTime);
            fechaInicio = default(DateTime);
            fechaTermino = default(DateTime);
            idTipoPermiso = default(int);
            rutSolicitante = string.Empty;
            rutAutorizante = string.Empty;
            idEstado = default(int);
            idMotivo = default(int); 
        }

    }
}