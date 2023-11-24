﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Model
{
    public class ClienteModel
    {
        public ClienteModel()
        {
            Id_Cliente = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            TDoc = new TipoDocumentoModel();
            DNI = string.Empty;
            CUIL = string.Empty;
            Email = string.Empty;
            Celular = string.Empty;
            TCliente = new TipoClienteModel();
            RazonSocial = string.Empty;
        }

        public int Id_Cliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public TipoDocumentoModel TDoc { get; set; }
        public string DNI { get; set; }
        public string CUIL { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public TipoClienteModel TCliente { get; set; }
        public string RazonSocial { get; set; }

        public string NombreCompleto
        {
            get
            {
                if (RazonSocial=="-" || RazonSocial==string.Empty )
                    return Apellido + " - " + Nombre + " - " + DNI;
                else
                    return RazonSocial + " - " + CUIL;
            }
        }

        public override string ToString()
        {
            if (RazonSocial == "-")
                return Apellido + " - " + Nombre + " - " + DNI;
            else
                return RazonSocial + " - " + CUIL;
        }
        
        
    }
}
