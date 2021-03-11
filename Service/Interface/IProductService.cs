using Models;
using Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interface
{
    public interface IProductService
    {
        public IEnumerable<ProductViewModel> GetAll();
        public ProductViewModel GetProduct(int id);
        public int CreateProduct(Models.ProductModel products);

        public bool Delete(int id);
        public int Update(Models.ProductModel products);
    }
}
