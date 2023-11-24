﻿using HotelBackEnd.DAO.Implementation;
using HotelBackEnd.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBackEnd.Front.Interface
{
    public interface IClienteFront
    {

        List<TipoClienteModel> GetTipoCliente();
        List<TipoDocumentoModel> GetTipoDocumento();
        List<ClienteModel> GetClientes();
        List<ClienteModel> GetClientesLista();
        ClienteModel GetClienteID(int id);

        bool AltaCliente(ClienteModel cliente);
        bool ActualizarCliente(ClienteModel cliente);
        bool BajaCliente(string numero);
    }
}
