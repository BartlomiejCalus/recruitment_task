using myFunction.Entities.Output;
using System.Collections.Generic;

namespace myFunction.Services.Interfaces
{
    public interface IGetDataService
    {
        List<RootOut> GetFromFewPages();
        List<RootOut> GetFromOnePage();
    }
}