using System.Collections.Generic;

using myFunction.Entities.Input;
using myFunction.Entities.Output;

namespace myFunction
{
    public class Mapping
    {
        public static RootOut map(Order o)
        {
            var result = new RootOut()
            {
                delivery_address = o.address.address1,
                delivery_city = o.address.city,
                delivery_company = o.address.company_name,
                delivery_country_code = o.address.country_code,
                delivery_fullname = o.address.name,
                delivery_postcode = o.address.postal_code,
                invoice_fullname = o.address.name,
                invoice_company = o.address.company_name,
                invoice_address = o.address.address1,
                invoice_city = o.address.city,
                invoice_postcode = o.address.postal_code,
                invoice_country_code = o.address.country_code,
                phone = o.address.phone_number,
                extra_field_1 = o.id,
                date_add = o.created_at,

                products = new List<ProductOut>()
            };


            foreach (var i in o.items)
            {
                result.products.Add(new ProductOut()
                {
                    product_id = i.product_id,
                    name = i.product_name,
                    price_brutto = i.price_cents,
                    quantity = i.quantity

                });
            }

            return result;
        }
    }
}
