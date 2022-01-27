﻿using System;

namespace ProductsCore.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public Category CategoryProduct { get; set; }
        public bool IsAvailableToBuy { get; set; }
        public int Number { get; set; }
        //TODO Add Sizes
    }
}