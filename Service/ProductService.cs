using Models;
using Repository;
using Service.Interface;
using System;
using System.Collections.Generic;
using Repository.Interface;
using Models.ViewModel;

namespace Service
{
    public class ProductService : IProductService
    {
        private readonly IRepository<ProductModel, int> _productRepository;
        public  ProductService(IRepository<ProductModel, int> productRepository)
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
        public IEnumerable<ProductViewModel> GetAll()
        {
            List<ProductViewModel> productsViewModel = new List<ProductViewModel>();
            foreach ( var product in _productRepository.FindAll())
            {
                productsViewModel.Add(new ProductViewModel()
                {
                    ProductID = product.ProductID,
                    ProductName = product.ProductName,
                    UnitPrice = product.UnitPrice
                });
            }
            return productsViewModel;
        }
        /// <summary>
        /// 取得產品資料
        /// </summary>
        /// <param name="id">產品ID</param>
        /// <returns>產品資料</returns>
        public ProductViewModel GetProduct(int id)
        {
            var product = _productRepository.FindById(id);
            var productViewModel = new ProductViewModel()
            {
                ProductID = product.ProductID,
                ProductName = product.ProductName,
                UnitPrice = product.UnitPrice
            };
            return productViewModel;
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
