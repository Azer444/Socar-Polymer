using Core;
using Core.Models;
using Core.Repositories;
using Data;
using Data.Contexts;
using Data.Repositories;
using Manage.Constraints;
using Manage.Helpers;
using Manage.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;

namespace Manage
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
            services.AddMvc().AddNewtonsoftJson(opt => opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

            //Constraints
            services.Configure<RouteOptions>(options => options.ConstraintMap.Add("languages", typeof(LanguageConstraint)));
            services.Configure<RouteOptions>(options => options.ConstraintMap.Add("locations", typeof(LocationConstraint)));
            //

            //inner services
            services.Configure<SmtpConfig>(Configuration.GetSection("SmtpConfig"));
            services.AddTransient<IEmailService, EmailService>();
            services.AddTransient<IFileService, FileService>();
            //

            services.AddControllersWithViews();

            services.AddDbContext<PolymerContext>(option =>
                            option.UseSqlServer(Configuration.GetConnectionString("BloggingDatabase"), x => x.MigrationsAssembly("Data")));

            services.AddIdentity<User, IdentityRole>(options =>
            {
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 0;
                options.SignIn.RequireConfirmedEmail = true;
                options.User.RequireUniqueEmail = true;
            })
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<PolymerContext>();

            //Repositories
            services.AddScoped<IContactTextComponentRepository, ContactTextComponentRepository>();
            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<ICertificateComponentFileRepository, CertificateComponentFileRepository>();
            services.AddScoped<ICertificateComponentRepository, CertificateComponentRepository>();
            services.AddScoped<IContactFormComponentRepository, ContactFormComponentRepository>();
            services.AddScoped<IContactMessageRepository, ContactMessageRepository>();
            services.AddScoped<IContactTextComponentRepository, ContactTextComponentRepository>();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IHomeBannerComponentRepository, HomeBannerComponentRepository>();
            services.AddScoped<IHomeSliderComponentRepository, HomeSliderComponentRepository>();
            services.AddScoped<ILocationRepository, LocationRepository>();
            services.AddScoped<IMarketTitleComponentRepository, MarketTitleComponentRepository>();
            services.AddScoped<IMarketTitleComponentFileRepository, MarketTitleComponentFileRepository>();
            services.AddScoped<IMarketComponentRepository, MarketComponentRepository>();
            services.AddScoped<IMarketComponentFileRepository, MarketComponentFileRepository>();
            services.AddScoped<IMarketSubComponentRepository, MarketSubComponentRepository>();
            services.AddScoped<IMarketSubComponentFileRepository, MarketSubComponentFileRepository>();
            services.AddScoped<INavComponentRepository, NavComponentRepository>();
            services.AddScoped<INavTitleComponentRepository, NavTitleComponentRepository>();
            services.AddScoped<INewsFileRepository, NewsFileRepository>();
            services.AddScoped<INewsRepository, NewsRepository>();
            services.AddScoped<IProductBrochureRepository, ProductBrochureRepository>();
            services.AddScoped<IProductFieldRepository, ProductFieldRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductCategoryPropertyRepository, ProductCategoryPropertyRepository>();
            services.AddScoped<IProductCategoryRepository, ProductCategoryRepository>();
            services.AddScoped<IProductTitleCategoryRepository, ProductTitleCategoryRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IProductContactMessageRepository, ProductContactMessageRepository>();
            services.AddScoped<ITranslationRepository, TranslationRepository>();
            //

            //unitOfWork
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            //

            //Inner services
            services.AddTransient<IFileService, FileService>();
            //

            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddRouting(options => options.LowercaseUrls = true);

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/admin/account/login";
                options.AccessDeniedPath = "/admin/account/login";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "areas",
                    template: "{area:exists}/{controller=home}/{action=index}/{id?}"
                );

                routes.MapRoute(
                    name: "default",
                    template: "{lang:languages}/{controller}/{action}/{id?}",
                    defaults: new { lang = "en", controller = "home", action = "index" }
                );
            });
        }
    }
}
