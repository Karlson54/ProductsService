using ProductsDataLayer;
using System;

namespace ProductsBusinessLayer
{
    public class ProductsService
    {
        private static ProductsRepository _productsRepository;
        static ProductsService()
        {
            _productsRepository = new ProductsRepository();
        }
    }
}
