﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorEcommerce.CoreBusiness.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageLink { get; set; }
        public string Description { get; set; }
    }
}
