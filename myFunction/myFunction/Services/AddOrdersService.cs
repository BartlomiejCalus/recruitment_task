using myFunction.Entities.Output;
using RestSharp;
using System;
using System.Collections.Generic;

namespace myFunction.Services
{
    public static class AddOrdersService
    {
        private static string _key = Environment.GetEnvironmentVariable("X-BLToken");
        public static void SendData(List<RootOut> data)
        {
            var client = new RestClient("https://api.baselinker.com/connector.php");

            var request = new RestRequest();

            foreach(var order in data)
            {
                request.AddJsonBody(order);

                request.AddHeader("X-BLToken", _key);

                var response = client.Post(request);
            }

        }
    }
}
