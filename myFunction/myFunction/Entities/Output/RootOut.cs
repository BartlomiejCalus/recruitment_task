using System.Collections.Generic;

namespace myFunction.Entities.Output
{
    public class RootOut
    {
        public string order_status_id { get; } = "8069";
        public string custom_source_id { get; } = "1024";
        public string date_add { get; set; }
        public string phone { get; set; }
        public string delivery_price { get; set; }
        public string delivery_fullname { get; set; }
        public string delivery_company { get; set; }
        public string delivery_address { get; set; }
        public string delivery_city { get; set; }
        public string delivery_postcode { get; set; }
        public string delivery_country_code { get; set; }
        public string extra_field_1 { get; set; }
        public List<ProductOut> products { get; set; }
    }
}
