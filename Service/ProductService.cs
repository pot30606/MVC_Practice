﻿using Models;
using Repository;
using Service.Interface;
using System;
using System.Collections.Generic;

namespace Service
{
    public class ProductService : IProductService
    {
        private readonly ProductRepository _productRepository;
        public  ProductService(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        public bool CreateProduct(Models.ProductModel products)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductModel> GetAll()
        {
            return _productRepository.FindAll();
        }

        public ProductModel GetProduct(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(string id)
        {
            throw new NotImplementedException();
        }
    }
}
