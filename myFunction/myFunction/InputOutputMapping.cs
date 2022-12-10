using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using myFunction.Entities.Input;
using myFunction.Entities.Output;

namespace myFunction
{
    public class InputOutputMapping : Profile
    {
        public InputOutputMapping()
        {
            CreateMap<Root, RootOut>()
                .ForMember(o => o.delivery_address,m=>m.MapFrom(s=>s.))
        }
    }
}
