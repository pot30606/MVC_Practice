using Microsoft.Data.SqlClient;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Models;
using System.Linq;

namespace Repository
{
    public class ProductRepository : IRepository<ProductModel, int>
    {
        private readonly MyDbContext _context;
        public ProductRepository(MyDbContext context)
        {
            _context = context;
        }

        public int Create(ProductModel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductModel> Find(Expression<Func<ProductModel, bool>> expression)
        {
            return _context.Products.Where(expression);
        }

        public IEnumerable<ProductModel> FindAll()
        {
            return _context.Products;
        }

        public ProductModel FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
