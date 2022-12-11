using System.Collections.Generic;

namespace myFunction.Entities.Input
{
    public class Order
    {
        public string id { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public string state { get; set; }
        public List<Item> items { get; set; }
        public Address address { get; set; }
        public string retailer_id { get; set; }
        public string source { get; set; }
        public Shipments shipments { get; set; }
    }
}
