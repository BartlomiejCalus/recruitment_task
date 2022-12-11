using myFunction.Entities.Output;
using System.Collections.Generic;

namespace myFunction.Services.Interfaces
{
    public interface IAddOrdersService
    {
        string SendData(List<RootOut> data);
    }
}