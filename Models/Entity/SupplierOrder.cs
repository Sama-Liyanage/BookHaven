using System;
using System.Collections.Generic;
using BookHeaven.Models.Entity;

namespace BookHeaven.Models.Entity
{
    public class SupplierOrder
    {
        public Guid Id { get; set; }
        public Guid SupplierId { get; set; }
        public virtual Supplier? Supplier { get; set; }

        public List<SupplierOrderItem> Items { get; set; } = new List<SupplierOrderItem>();

        public string? Status { get; set; } // "Pending", "Shipped", "Delivered"
        public DateTime OrderDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
    }
}
