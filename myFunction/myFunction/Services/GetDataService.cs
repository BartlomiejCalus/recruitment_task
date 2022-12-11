using RestSharp;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

using myFunction.Entities.Input;
using myFunction.Entities.Output;
using Microsoft.Extensions.Configuration;
using System.Text.RegularExpressions;
using System;

namespace myFunction.Services
{
    public static class GetDataService
    {
        static RestClient client = new RestClient(@"https://www.faire.com/api/v1/orders");

        static RestRequest request = new RestRequest();

        private static string _key = Environment.GetEnvironmentVariable("X-FAIRE-ACCESS-TOKEN");

        public static List<RootOut> GetFromOnePage()
        {
            request.AddHeader("X-FAIRE-ACCESS-TOKEN", _key);

            var response = client.Get(request).Content;

            var newRoot = JsonConvert.DeserializeObject<Root>(response);

            var listOfOutOrder = new List<RootOut>();

            foreach (var order in newRoot.orders)
            {
                listOfOutOrder.Add(Mapping.map(order));
            }

            return listOfOutOrder;
        }

        public static List<RootOut> GetFromFewPages()
        {
            request.AddHeader("X-FAIRE-ACCESS-TOKEN", _key);

            List<Root> responses = new List<Root>();
            do
            {
                var response = client.Get(request).Content;

                var newRoot = JsonConvert.DeserializeObject<Root>(response);

                responses.Add(newRoot);

                if (responses.Last().page == 0)
                {
                    break;
                }
                else
                {
                    client = new RestClient(@$"https://www.faire.com/api/v1/orders?page={newRoot.page + 1}");
                }

            } while (true);

            var listOfOutOrder = new List<RootOut>();

            foreach (var response in responses)
            {
                foreach (var order in response.orders)
                {
                    listOfOutOrder.Add(Mapping.map(order));
                }
            }

            return listOfOutOrder;
        }

    }

}

