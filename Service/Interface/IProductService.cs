using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interface
{
    public interface IProductService
    {
        public IEnumerable<ProductModel> GetAll();
        public ProductModel GetProduct(string id);
        public bool CreateProduct(Models.ProductModel products);

        public bool Delete(string id);
        public bool Update(string id);
    }
}
