using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

using myFunction.Services;


namespace myFunction
{
    public class Function1
    {


        [FunctionName("Function1")]
        public void Run([TimerTrigger("0 */1 * * * *")]TimerInfo myTimer, ILogger log)
        {

            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

            // w sytuacji gdy dane nie bêd¹ podzielone na kilka stron:

            var result = GetDataService.GetFromOnePage();

            // w sytuacji gdy dane bêd¹ podzielone na kilka stron:

            //var result = GetDataService.GetFromFewPages();


            // ci¹g dalszy dla obu opcji:

            AddOrdersService.SendData(result);

        }
    }
}
