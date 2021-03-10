using Microsoft.EntityFrameworkCore;
using System;

namespace Models
{
    /// <summary>
    /// 日誌資料
    /// </summary>
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<ProductModel> Products { get; set; }


    }
}
