namespace myFunction.Entities.Output
{
    public class ProductOut
    {
        public int storage_id { get; set; }
        public string product_id { get; set; }
        public int variant_id { get; set; }
        public string name { get; set; }
        public double price_brutto { get; set; }
        public int quantity { get; set; }
    }
}
