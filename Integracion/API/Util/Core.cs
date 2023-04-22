using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using API.DTOs.Inputs;
using Modelos;
using Newtonsoft.Json;

namespace API.Util
{
    public sealed class Core
    {
        private string CoreServiceUrl { get; set; }
        private static readonly log4net.ILog Log = 
            log4net.LogManager.GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType);

        private Core(string coreServiceUrl)
        {
            this.CoreServiceUrl = coreServiceUrl;
        }

        private static Core _instance;
        
        public static Core GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Core("https://localhost:44329/");
            }
            return _instance;
        }

        public async Task<bool> Ping()
        {
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri(CoreServiceUrl + "CI/servicios/get"); // add endpoint
            request.Method = HttpMethod.Get;
            request.Headers.Add("accpet","application/json");
            var client = new HttpClient();
            var response = await client.SendAsync(request);
            
            HttpStatusCode[] array = {HttpStatusCode.OK, HttpStatusCode.Accepted, HttpStatusCode.Created,
                HttpStatusCode.NonAuthoritativeInformation,HttpStatusCode.NoContent, HttpStatusCode.ResetContent
            };
            if (array.Contains(response.StatusCode))
            {
                // log que el core respondio
                Log.Info("Core is runing....");
                return true;
            }
            
            // log que el core esta down
            Log.Error("Core is down, offline mode activate");
            return false;
        }

        public async Task<HttpStatusCode> EnviarTransaccion(Transaccion transaccion)
        {
            using (var httpClient = new HttpClient())
            {
                var apiUrl = CoreServiceUrl + "CI/transacciones/registrar?userId=1"; // replace with your API endpoint
                var json = JsonConvert.SerializeObject(TransaccionToTransactionDto(transaccion));
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            
                var response = await httpClient.PostAsync(apiUrl, content);
                var responseContent = await response.Content.ReadAsStringAsync();

                return response.StatusCode;
            }
        }
        
        public async Task<HttpStatusCode> EnviarFactura(Factura factura)
        {
            using (var httpClient = new HttpClient())
            {
                var apiUrl = CoreServiceUrl + "CI/factura/registrar?userId=1"; // replace with your API endpoint
                var json = JsonConvert.SerializeObject(FacturaToFacturaDto(factura));
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            
                var response = await httpClient.PostAsync(apiUrl, content);
                var responseContent = await response.Content.ReadAsStringAsync();

                return response.StatusCode;
            }
        }

        private TransaccionInput TransaccionToTransactionDto(Transaccion transaccion)
        {
            return new TransaccionInput()
            {
                CodigoTransaccion = transaccion.CodigoTransaccion,
                CreatedAt = transaccion.CreatedAt,
                CuentaID = transaccion.CuentaID,
                Descripcion = transaccion.Descripcion,
                EmpleadoID = transaccion.EmpleadoID,
                MetodoPagoID = transaccion.MetodoPagoID,
                Monto = transaccion.Monto,
                TipoTransaccion = transaccion.TipoTransaccion
            };
        }
        
        private FacturaInput FacturaToFacturaDto(Factura factura)
        {
            return new FacturaInput()
            {
                CreatedAt = factura.CreatedAt,
                CuentaID = factura.CuentaID,
                EmpleadoID = factura.EmpleadoID,
                MetodoPagoID = factura.MetodoPagoID,
                TotalFinal = factura.TotalFinal,
                TotalBruto = factura.TotalBruto,
                TotalDescuento = factura.TotalDescuento,
                PacienteID = factura.PacienteID,
                CodigoFactura = factura.CodigoFactura,
            };
        }
    }
}