using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Models;

namespace MVC_Practice
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //���U DB Context�A���w�ϥ� SQL ��Ʈw
            services.AddDbContextPool<JournalDbContext>(options =>
            {
                //TODO: ������ήɳs�u�r�ꤣ�Ӽg���A�����J�]�w�ɨå[�K�x�s
                options.UseSqlServer(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\DB.mdf; Integrated Security = True; Connect Timeout = 30");
            });
           

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, JournalDbContext dbContext)
        {
            //�ˬd��ƪ�O�_�w�g�s�b�A�Y���s�b�۰ʫإߡF�Y��ƪ�s�b���������²ūh�۰ʧ�s�C
            //�b�������Ҧ۰ʧ�sSchema���I�i�ȡA�ڥ[�F���wLocalDB���檺�w����
            if (dbContext.Database.GetDbConnection().ConnectionString.Contains("MSSQLLocalDB"))
            {
                dbContext.Database.Migrate();
            }
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
