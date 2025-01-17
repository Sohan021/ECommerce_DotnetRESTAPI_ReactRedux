﻿namespace quick_ship_api.Models.Regular
{
    public class OrderDetail
    {
        public int Id { get; set; }


        public int? OrderId { get; set; }
        public virtual Order Order { get; set; }


        public int? ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
