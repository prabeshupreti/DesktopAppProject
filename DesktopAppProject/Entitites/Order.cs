﻿

namespace TurboMart.Entitites
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public long CustomerPhoneNumber { get; set; }
        public DateTime OrderDateTime { get; set; }
    }
}
