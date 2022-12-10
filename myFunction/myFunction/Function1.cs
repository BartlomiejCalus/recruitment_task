using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using RestSharp;
using Newtonsoft.Json;
using System.Collections.Generic;
using myFunction.Entities;

using myFunction.Entities.Input;
using System.Linq;

namespace myFunction
{
    public class Function1
    {
        [FunctionName("Function1")]
        public void Run([TimerTrigger("0 */10 * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

            List<Root> responses = new List<Root>();

            var client = new RestClient(@"https://www.faire.com/api/v1/orders");

            var request = new RestRequest();

            // w sytuacji gdy dane nie bêd¹ podzielone na kilka stron

            var response = client.Get(request).Content;

            var newRoot = JsonConvert.DeserializeObject<Root>(response);

            responses.Add(newRoot);

            // w sytuacji gdy dane bêd¹ podzielone na kilka stron

            /*do
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
            */
        }
    }
}
