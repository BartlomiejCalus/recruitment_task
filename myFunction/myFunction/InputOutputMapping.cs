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
            CreateMap<Order, RootOut>()
                .ForMember(o => o.delivery_address, m => m.MapFrom(i => i.address.address1))
                .ForMember(o => o.delivery_city, m => m.MapFrom(i => i.address.city))
                .ForMember(o => o.delivery_company, m => m.MapFrom(i => i.address.company_name))
                .ForMember(o => o.delivery_country_code, m => m.MapFrom(i => i.address.country_code))
                .ForMember(o => o.delivery_fullname, m => m.MapFrom(i => i.address.name))
                .ForMember(o => o.delivery_postcode, m => m.MapFrom(i => i.address.postal_code))
                .ForMember(o => o.delivery_price, m => m.MapFrom(i => i.shipments.maker_cost_cents))
                .ForMember(o => o.phone, m => m.MapFrom(i => i.address.phone_number))
                .ForMember(o => o.extra_field_1, m => m.MapFrom(i => i.id))
                .ForMember(o => o.date_add, m => m.MapFrom(i => i.created_at));

            CreateMap<Item, ProductOut>()
                .ForMember(o => o.product_id, m => m.MapFrom(i => i.product_id))
                .ForMember(o => o.variant_id, m => m.MapFrom(i => i.product_option_id))
                .ForMember(o => o.name, m => m.MapFrom(i => i.product_name))
                .ForMember(o => o.price_brutto, m => m.MapFrom(i => i.price_cents))
                .ForMember(o => o.quantity, m => m.MapFrom(i => i.quantity));
        }
    }
}
