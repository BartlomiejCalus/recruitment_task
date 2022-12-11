namespace myFunction.Entities.Output
{
    public class ProductOut
    {
        public string storage { get; set; }
        public int storage_id { get; set; }
        public string product_id { get; set; }
        public int variant_id { get; set; }
        public string location { get; set; }
        public string name { get; set; }
        public string sku { get; set; }
        public string ean { get; set; }
        public double price_brutto { get; set; }
        public int tax_rate { get; set; }
        public int quantity { get; set; }
        public int weight { get; set; }
    }
}
