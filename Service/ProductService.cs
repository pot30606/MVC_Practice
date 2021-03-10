using Models;
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

        /// <summary>
        /// 建立產品資料
        /// </summary>
        /// <param name="products">產品資料</param>
        /// <returns>產品ID</returns>
        public int CreateProduct(Models.ProductModel products)
        {
            return _productRepository.Create(products);
        }

        /// <summary>
        /// 刪除產品
        /// </summary>
        /// <param name="id">產品ID</param>
        /// <returns>是否成功</returns>
        public bool Delete(int id)
        {
            return _productRepository.Delete(id);
        }
        /// <summary>
        /// 取得所有產品
        /// </summary>
        /// <returns>所有產品</returns>
        public IEnumerable<ProductModel> GetAll()
        {
            return _productRepository.FindAll();
        }
        /// <summary>
        /// 取得產品資料
        /// </summary>
        /// <param name="id">產品ID</param>
        /// <returns>產品資料</returns>
        public ProductModel GetProduct(int id)
        {
            return _productRepository.FindById(id);
        }

        /// <summary>
        /// 更新產品資料
        /// </summary>
        /// <param name="products">產品資料</param>
        /// <returns>產品ID</returns>
        public int Update(Models.ProductModel products)
        {
            return _productRepository.Update(products);
        }
    }
}
