﻿using System;
using BookHeaven.Models.Entity;

namespace BookHeaven.Models.Entity
{
    public class SupplierOrderItem
    {
        public Guid Id { get; set; }
        public Guid SupplierOrderId { get; set; }
        public virtual SupplierOrder? SupplierOrder { get; set; }

        public Guid BookId { get; set; }
        public virtual Book? Book { get; set; }

        public int Quantity { get; set; }
        public decimal PricePerUnit { get; set; }
    }
}
