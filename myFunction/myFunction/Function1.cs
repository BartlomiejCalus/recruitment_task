using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using myFunction.Entities.Input;
using myFunction.Entities.Output;
using myFunction.Services;
using Newtonsoft.Json;
using RestSharp;

namespace myFunction
{
    public class Function1
    {


        [FunctionName("Function1")]
        public void Run([TimerTrigger("0 */1 * * * *")]TimerInfo myTimer, ILogger log)
        {

            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

            //RestClient client = new RestClient(@"https://www.faire.com/api/v1/orders");

            //RestRequest request = new RestRequest();

            // w sytuacji gdy dane nie bêd¹ podzielone na kilka stron:

            var result = GetDataService.GetFromOnePage();

            // w sytuacji gdy dane bêd¹ podzielone na kilka stron:

            //var result = GetDataService.GetFromFewPages();


            // ci¹g dalszy dla obu opcji:

            AddOrdersService.SendData(result);

        }
    }
}
