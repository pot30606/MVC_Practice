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

        /// <summary>
        /// 建立產品資料
        /// </summary>
        /// <param name="entity">產品資料</param>
        /// <returns>產品ID</returns>
        public int Create(ProductModel entity)
        {
            return _context.Products.Add(entity).Entity.ProductID;
        }

        /// <summary>
        /// 刪除產品資料
        /// </summary>
        /// <param name="id">產品編號</param>
        public bool Delete(int id)
        {
            var product = _context.Products.Where((x)=>x.ProductID == id).FirstOrDefault();
            _context.Remove(product);
            return true;
        }

        /// <summary>
        /// 查詢產品資料
        /// </summary>
        /// <param name="expression">查詢條件(Lambda 運算式)</param>
        /// <returns>符合條件的產品資料</returns>
        public IEnumerable<ProductModel> Find(Expression<Func<ProductModel, bool>> expression)
        {
            return _context.Products.Where(expression);
        }

        /// <summary>
        /// 查詢所有產品資料
        /// </summary>
        /// <returns>所有產品資料</returns>
        public IEnumerable<ProductModel> FindAll()
        {
            return _context.Products;
        }

        /// <summary>
        /// 查詢特定產品
        /// </summary>
        /// <param name="id">產品ID</param>
        /// <returns>產品資料</returns>
        public ProductModel FindById(int id)
        {
            return _context.Products.Where((x) => x.ProductID == id).FirstOrDefault();
        }

        /// <summary>
        /// 更新產品資料
        /// </summary>
        /// <param name="entity">產品資料</param>
        /// <returns>產品ID</returns>
        public int Update(ProductModel entity)
        {
            return _context.Products.Update(entity).Entity.ProductID;
        }
    }
}
