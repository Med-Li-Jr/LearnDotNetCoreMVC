using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace LearnDotNetCoreMVC.Outils
{
    public class RequestAPI
    {
        private RequestAPI() { }
        public static Exception exceptionError
        {
            get; set;
        }
        public static HttpClient Initial()
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:44317/api/");
                return client;
            }
            catch (HttpRequestException e)
            {
                exceptionError = e;
            }
            catch (SocketException e)
            {
                exceptionError = e;
            }
                return null;
        }
    }
}
