﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHeaven.Models.Dto
{
    public class BookSales
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int TotalSold { get; set; }
    }
}
