using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC_Practice.Controllers;
using NUnit.Framework;
using Repository;
using Repository.Interface;
using Service.Interface;
using System.Linq;
using NSubstitute;
using Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore;
using MVC_Practice;

namespace MVC_PracticeTests
{
    [TestClass]
    public class ProductTest
    {
        static IWebHost _webHost = null;
        static T GetService<T>()
        {
            var scope = _webHost.Services.CreateScope();
            return scope.ServiceProvider.GetRequiredService<T>();
        }

        [ClassInitialize]
        public static void Init(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            _webHost = WebHost.CreateDefaultBuilder()
                .UseStartup<Startup>()
                .Build();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var ctx = GetService<MyDbContext>();
            var rec = ctx.Products.FirstOrDefault();
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(rec);
        }

    }
}
