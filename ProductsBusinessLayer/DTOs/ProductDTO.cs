﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsBusinessLayer.DTOs
{
    public class ProductDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
    }
}