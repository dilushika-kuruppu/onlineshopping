using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
<<<<<<< HEAD
using OnlineShopping.API.Helpers;
using OnlineShopping.Business;
using OnlineShopping.Business.Category;
using OnlineShopping.Business.Order;
using OnlineShopping.Business.Product;
=======
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using OnlineShopping.API.Controllers;
using OnlineShopping.API.Helpers;
using OnlineShopping.Business;
using OnlineShopping.Business.Categary;
using OnlineShopping.Business.Category;
using OnlineShopping.Business.Order;
using OnlineShopping.Business.Product;
using OnlineShopping.Data.CategoryRepository;
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
using OnlineShopping.Data.Context;
using OnlineShopping.Data.OderItemRepository;
using OnlineShopping.Data.OrderRepository;
using OnlineShopping.Data.ProductRepository;
using OnlineShoppingDB.Server.Models;

using OnlineShopping.Business.Email;
using OnlineShopping.Data.Repository;

namespace OnlineShopping.API
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

            services.AddDbContext<OnlineShoppingContext>(x => x.UseSqlServer(Configuration.GetConnectionString("Connection")));
            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
            services.AddControllers();
            services.AddMvc();
<<<<<<< HEAD
            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
            services.AddScoped<IUnitofWork, UnitofWork>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IOrderItemRepository, OrderItemRepository>(); 
            
=======
            services.AddScoped<ICategoryManager, CategoryManager>();
            services.AddScoped<IProductManager, ProductManager>();
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
            services.AddScoped<IAuthBusiness, AuthBusiness>();
            services.AddScoped<IProductManager, ProductManager>();
            services.AddScoped<ICategoryManager, CategoryManager>();  
            services.AddScoped<IAuthRepository, AuthRepository>();
<<<<<<< HEAD
            services.AddScoped<IEmail, Email>();
=======
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderItemRepository, OrderItemRepository>();
            
            services.AddScoped<IOrderManager, OrderManager>();
            services.AddHttpContextAccessor();
>>>>>>> ad49b4b0c2207cbde6f0503cba0455cafbd7b9d2
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
             .AddJwtBearer(options =>
             options.TokenValidationParameters = new TokenValidationParameters
             {
                 ValidateIssuerSigningKey = true,
                 IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.
                 GetBytes(Configuration.GetSection("AppSettings:Token").Value)),
                 ValidateIssuer = false,
                 ValidateAudience = false

             });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else {
                app.UseExceptionHandler(builder => {
                    builder.Run(async context => {
                        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        var error = context.Features.Get<IExceptionHandlerFeature>();
                        if (error != null) {

                            context.Response.AddApplicationError(error.Error.Message);
                            await context.Response.WriteAsync(error.Error.Message);

                        }
      
                    });
                    }); 
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
