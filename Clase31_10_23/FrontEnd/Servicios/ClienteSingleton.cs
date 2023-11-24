using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Servicios
{
    public class ClienteSingleton
    {
        private static ClienteSingleton instancia;
        private HttpClient cliente;

        private ClienteSingleton() { 
        
            cliente= new HttpClient(); 
        }

        public static ClienteSingleton GetInstance()
        {
            if (instancia == null) {    

             instancia = new ClienteSingleton();

            }
            return instancia;
        }


        public async Task<string> GetAsync(string url)
        {
            var resultado = await cliente.GetAsync(url);
            var contenido = "";
           

            if (resultado.IsSuccessStatusCode) {

                    contenido = await resultado.Content.ReadAsStringAsync();
                }
                Console.WriteLine(contenido);
            return contenido;
        }

        public async Task<string> PostAsync(string url, string data)
        {

           
            var contenido = new StringContent(data,Encoding.UTF8, "application/json");
            var resultado = await cliente.PostAsync(url, contenido);
            var respuesta = "";

            if (resultado.IsSuccessStatusCode)
            {

                respuesta= await resultado.Content.ReadAsStringAsync();
            }
            Console.WriteLine(contenido);
            return respuesta;


            //
        }
    }
}
