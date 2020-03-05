using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;

namespace WebApplication1
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        // 依赖注入
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // 配置
        public void ConfigureServices(IServiceCollection services)
        {
            // 添加ORM(Entity Framework)
            services.AddDbContextPool<AppDbContext>(
                optionsAction: options => options.UseMySql(_configuration.GetConnectionString("SqlConfig"))
                );

            // 添加服务
            services.AddMvc();
            // 依赖注入 服务绑定
            //services.AddSingleton<IStudentRepository, MockStudent>();
            services.AddScoped<IStudentRepository, SqlStudentRepository>();
        }


        public void Configure(IApplicationBuilder app, IHostingEnvironment env,ILogger<Startup> logger)
         {
            if (env.IsDevelopment())
            {
                DeveloperExceptionPageOptions pageOptions = new DeveloperExceptionPageOptions();
                pageOptions.SourceCodeLineCount = 10;   // 报错页面代码显示行数
                app.UseDeveloperExceptionPage(pageOptions);
            }

            /*
            app.Use(async (context,next) =>
            {
                //String myconfig = _configuration["myKey"];
                //String processName = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
                context.Response.ContentType = "text/plain;charset=utf-8";
                logger.LogInformation("传入请求1");
                await next();
                logger.LogInformation("传出响应1");      
            });
            // 静态文件支持链
            FileServerOptions fileServer = new FileServerOptions();
            fileServer.DefaultFilesOptions.DefaultFileNames.Clear();
            fileServer.DefaultFilesOptions.DefaultFileNames.Add("test.html");
            app.UseFileServer(fileServer);
            // 默认文件中间件
            app.UseDefaultFiles();
            */


            // 静态文件中间件
            app.UseStaticFiles();

            // 使用MVC
            app.UseMvcWithDefaultRoute();

        

            app.Run(async (context) =>
            {
                //throw new Exception("你的请求发生错误！");
                await context.Response.WriteAsync("hello world");
            });


        }
    }
}
