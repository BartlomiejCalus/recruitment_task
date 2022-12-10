using System.Collections.Generic;

namespace myFunction.Entities.Input
{
    public class Root
    {
        public int page { get; set; }
        public int limit { get; set; }
        public List<Order> orders { get; set; }
    }
}
