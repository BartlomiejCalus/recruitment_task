using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using RestSharp;
using Newtonsoft.Json;
using System.Collections.Generic;
using myFunction.Entities;

namespace myFunction
{
    public class Function1
    {
        [FunctionName("Function1")]
        public void Run([TimerTrigger("0 */10 * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

            

           
        }
    }
}
