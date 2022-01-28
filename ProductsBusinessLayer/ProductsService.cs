using ProductsCore.Models;
using ProductsDataLayer;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductsBusinessLayer
{
    public class ProductsService
    {
        private static ProductsRepository _productsRepository;
        static ProductsService()
        {
            _productsRepository = new ProductsRepository();
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            await Task.CompletedTask;
            throw new NotImplementedException();
        }

        public async Task<Product> GetProductById(Guid id)
        {
            await Task.CompletedTask;
            throw new NotImplementedException();
        }

        public async Task<Product> DeleteProductById(Guid id)
        {
            await Task.CompletedTask;
            throw new NotImplementedException();
        }
    }
}
