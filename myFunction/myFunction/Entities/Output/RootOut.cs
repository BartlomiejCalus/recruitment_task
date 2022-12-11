using System.Collections.Generic;

namespace myFunction.Entities.Output
{
    public class RootOut
    {
        public string order_status_id { get; } = "8069";
        public string custom_source_id { get; } = "1024";
        public string date_add { get; set; }
        public string user_comments { get; set; }
        public string admin_comments { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string user_login { get; set; }
        public string currency { get; set; } = "USD";
        public string payment_method { get; set; }
        public string payment_method_cod { get; set; }
        public string paid { get; set; }
        public string delivery_method { get; set; }
        public string delivery_price { get; set; }
        public string delivery_fullname { get; set; }
        public string delivery_company { get; set; }
        public string delivery_address { get; set; }
        public string delivery_city { get; set; }
        public string delivery_postcode { get; set; }
        public string delivery_country_code { get; set; }
        public string delivery_point_id { get; set; }
        public string delivery_point_name { get; set; }
        public string delivery_point_address { get; set; }
        public string delivery_point_postcode { get; set; }
        public string delivery_point_city { get; set; }
        public string invoice_fullname { get; set; }
        public string invoice_company { get; set; }
        public string invoice_nip { get; set; }
        public string invoice_address { get; set; }
        public string invoice_city { get; set; }
        public string invoice_postcode { get; set; }
        public string invoice_country_code { get; set; }
        public string want_invoice { get; set; }
        public string extra_field_1 { get; set; }
        public string extra_field_2 { get; set; }
        public CustomExtraFields custom_extra_fields { get; set; }
        public List<ProductOut> products { get; set; }
    }
}
