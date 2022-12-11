using myFunction.Entities.Input;
using myFunction.Entities.Output;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFunction.Services
{
    internal class GetDataService
    {
        var client = new RestClient(@"https://www.faire.com/api/v1/orders");

        var request = new RestRequest();

        // w sytuacji gdy dane nie będą podzielone na kilka stron:

        var response = client.Get(request).Content;

        var newRoot = JsonConvert.DeserializeObject<Root>(response);

        var listOfOutOrder = new List<RootOut>();

            foreach (var order in newRoot.orders)
            {
                listOfOutOrder.Add(Mapping.map(order));
            }


    // w sytuacji gdy dane będą podzielone na kilka stron:

    //List<Root> responses = new List<Root>();
    //do
    //{
    //    var response = client.Get(request).Content;

    //    var newRoot = JsonConvert.DeserializeObject<Root>(response);

    //    responses.Add(newRoot);

    //    if (responses.Last().page == 0)
    //    {
    //        break;
    //    }
    //    else
    //    {
    //        client = new RestClient(@$"https://www.faire.com/api/v1/orders?page={newRoot.page + 1}");
    //    }

    //} while (true);

    //var listOfOutOrder = new List<RootOut>();

    //foreach (var response in responses)
    //{
    //    foreach (var order in response.orders)
    //    {
    //        listOfOutOrder.Add(Mapping.map(order));
    //    }
    //}
}
}
