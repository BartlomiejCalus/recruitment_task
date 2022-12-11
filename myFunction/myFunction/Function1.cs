using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

using myFunction.Services.Interfaces;

namespace myFunction
{
    public class Function1
    {
        private readonly IGetDataService _dataService;
        private readonly IAddOrdersService _addOrdersService;

        [FunctionName("Function1")]
        public void Run([TimerTrigger("0 */10 * * * *")]TimerInfo myTimer, ILogger log)
        {

            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

            // w sytuacji gdy dane nie bêd¹ podzielone na kilka stron:

            var result = _dataService.GetFromOnePage();

            // w sytuacji gdy dane bêd¹ podzielone na kilka stron:

            //var result = _dataService.GetFromFewPages();


            // ci¹g dalszy dla obu opcji:

            var respons = _addOrdersService.SendData(result);

            System.Console.WriteLine(respons);
        }
    }
}
