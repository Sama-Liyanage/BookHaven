﻿using System;
using System.Collections.Generic;

namespace BookHeaven.Models.Entity
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public string? Status { get; set; } 
        public DateTime OrderDate { get; set; }
        public bool? IsDelivery { get; set; }
        public decimal Total { get; set; }

        public decimal Discount { get; set; }
    }

    public class OrderItem
    {
        public Guid OrderId { get; set; }
        public virtual Order Order { get; set; }

        public Guid BookId { get; set; }
        public virtual Book Book { get; set; }

        public int Quantity { get; set; }
    }
}
