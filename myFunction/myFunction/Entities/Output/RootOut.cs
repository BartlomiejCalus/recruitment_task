using System.Collections.Generic;

namespace myFunction.Entities.Output
{
    public class RootOut
    {
        public string order_status_id { get; set; }
        public string custom_source_id { get; set; }
        public string date_add { get; set; }
        public string phone { get; set; }
        public string delivery_price { get; set; }
        public string delivery_fullname { get; set; }
        public string delivery_company { get; set; }
        public string delivery_address { get; set; }
        public string delivery_city { get; set; }
        public string delivery_postcode { get; set; }
        public string delivery_country_code { get; set; }
        public List<ProductOut> products { get; set; }
    }
}
