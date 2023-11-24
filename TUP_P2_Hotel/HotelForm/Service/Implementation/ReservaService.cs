﻿using HotelBackEnd.Model;
using HotelForm.HTTPClient;
using HotelForm.Service.Interface;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;

namespace HotelForm.Service.Implementation
{
    internal class ReservaService : IReservaService
    {
        private  const string host = "https://localhost:7107";

        public async Task<HttpResponse> DeleteReservaAsync(int idReserva)
        {
            string url = host + "/DeleteReserva?";
            var query = HttpUtility.ParseQueryString(string.Empty);
            query["idReserva"] = idReserva.ToString(); ;
            var response = await ClientSingleton.GetInstance().DeleteAsync(url+query.ToString());


            return response;
        }

        public async Task<List<ClienteModel>> GetClientesAsync()
        {
            string url = host + "/GetClientes";
            List<ClienteModel> result = new List<ClienteModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url); ;
            if (response!=null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<ClienteModel>>(response.Data);
            }
            return result;
        }

        public async Task<List<EstadoReservaModel>> GetEstadosReservaAsync()
        {
            string url = host + "/GetEstadosR";
            List<EstadoReservaModel> result = new List<EstadoReservaModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url); ;
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<EstadoReservaModel>>(response.Data);
            }
            return result;
        }

        public async Task<List<HabitacionHotelModel>> GetHabitacionHotelDisponiblesAsync(DateTime desde, DateTime hasta, int idHotel, int idReserva)
        {
            string url = host + "/GetHabDispo?";
            var query = HttpUtility.ParseQueryString(string.Empty);
            query["desde"] = desde.ToString("MM/dd/yyyy");
            query["hasta"] = hasta.ToString("MM/dd/yyyy");
            query["idHotel"] = idHotel.ToString();
            query["idReserva"] = idReserva.ToString();


            List<HabitacionHotelModel> result = new List<HabitacionHotelModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url+ query.ToString()); ;
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<HabitacionHotelModel>>(response.Data);
            }
            return result;
        }

        public async Task<List<HotelModel>> GetHotelesAsync()
        {
            string url = host + "/GetHoteles";
            List<HotelModel> result = new List<HotelModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url); ;
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<HotelModel>>(response.Data);
            }
            return result;
        }

        public async Task<List<LocalidadModel>> GetLocalidadAsync()
        {
            string url = host + "/GetLocalidades";
            List<LocalidadModel> result = new List<LocalidadModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url); ;
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<LocalidadModel>>(response.Data);
            }
            return result;
        }

        public async Task<List<ProvinciaModel>> GetProvinciaAsync()
        {
            string url = host + "/GetProvincias";
            List<ProvinciaModel> result = new List<ProvinciaModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url); ;
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<ProvinciaModel>>(response.Data);
            }
            return result;
        }

        public async Task<List<ReservaCuentaModel>> GetReservaCuentaAsync(int idReserva)
        {
            string url = host + "/GetResCuenta?";
            var query = HttpUtility.ParseQueryString(string.Empty);
            query["idReserva"] = idReserva.ToString();
            List<ReservaCuentaModel> result = new List<ReservaCuentaModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url + query.ToString()); ;
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<ReservaCuentaModel>>(response.Data);
            }
            return result;
        }

        public async Task<List<ReservaHabitacionModel>> GetReservaHabAsync(int idReserva)
        {
            string url = host + "/GetResHab?";
            var query = HttpUtility.ParseQueryString(string.Empty);
            query["idReserva"] = idReserva.ToString();

            List<ReservaHabitacionModel> result = new List<ReservaHabitacionModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url + query.ToString()); ;
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<ReservaHabitacionModel>>(response.Data);
            }
            return result;
        }

        public async Task<List<ReservaModel>> GetReservasAsync(DateTime desde, DateTime hasta, int idHotel, int idCliente,int idEstado)
        {
            string url = host + "/GetReservas?";
            var query = HttpUtility.ParseQueryString(string.Empty);
            query["desde"] = desde.ToString("MM/dd/yyyy");
            query["hasta"] = hasta.ToString("MM/dd/yyyy");
            query["idHotel"] = idHotel.ToString();
            query["idCliente"] = idCliente.ToString();
            query["idEstado"] = idEstado.ToString();



            List<ReservaModel> result = new List<ReservaModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url + query.ToString()); ;
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<ReservaModel>>(response.Data);
            }
            return result;
        }

        public async Task<List<HotelServicioModel>> GetServiciosHotelAsync(int idHotel)
        {
            string url = host + "/GetHoteServ?";
            var query = HttpUtility.ParseQueryString(string.Empty);
            query["idHotel"] = idHotel.ToString();
            List<HotelServicioModel> result = new List<HotelServicioModel>();
            var response = await ClientSingleton.GetInstance().GetAsync(url + query.ToString()); ;
            if (response != null && response.SuccessStatus)
            {
                result = JsonConvert.DeserializeObject<List<HotelServicioModel>>(response.Data);
            }
            return result;
        }

        public async Task<HttpResponse> PostReservaAsync(ReservaModel Reservar)
        {
            string url = host + "/PostReserva";
            var data = JsonConvert.SerializeObject(Reservar);
            var response = await ClientSingleton.GetInstance().PostAsync(url,data);
            
            
            return response;
        }
        public async Task<HttpResponse> PutReservaAsync(ReservaModel Reservar)
        {
            string url = host + "/PutReserva";
            var data = JsonConvert.SerializeObject(Reservar);
            var response = await ClientSingleton.GetInstance().PutAsync(url, data);


            return response;
        }
    }
}
