using myFunction.Entities.Output;
using myFunction.Services.Interfaces;
using RestSharp;
using System.Collections.Generic;

namespace myFunction.Services
{
    public class AddOrdersService : IAddOrdersService
    {

        public string SendData(List<RootOut> data)
        {
            var client = new RestClient("https://api.baselinker.com/connector.php");

            var request = new RestRequest();

            request.AddJsonBody(data);

            request.AddHeader("X-BLToken", "");

            var response = client.Post(request);

            return response.StatusCode.ToString();


        }
    }
}
