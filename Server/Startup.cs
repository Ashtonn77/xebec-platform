using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Linq;
using Server.Data;
using Microsoft.EntityFrameworkCore;
using Server.IRepository;
using Server.Repository;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Server.GamifiedApplicationPhaseFour;
using Server.GamifiedApplicationPhaseFour.IRepositories;
using Server.GamifiedApplicationPhaseFour.Repositories;

namespace XebecPortal.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<ApplicationDbContext>(options => {

                options.UseSqlServer(Configuration.GetConnectionString("sqlConnection"));

            });

           services.AddTransient<IUnitOfWork, UnitOfWork>();
           
            services.AddAutoMapper(typeof(MapperInitializer));
           
            services.AddTransient<IUserDb, UserDb>();

            services.AddAuthentication(options => {

            options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(options => {
                options.LoginPath = "/signin";
                options.LogoutPath = "/signout";
            })
           .AddGoogle(googleOptions =>
           {
               googleOptions.ClientId = Configuration["Authentication:Google:ClientId"];
               googleOptions.ClientSecret = Configuration["Authentication:Google:ClientSecret"];

           })
            .AddLinkedIn(Linkedinoptions =>
            {
                IConfigurationSection linkedinAuthNSection =
                Configuration.GetSection("Authentication:Linkedin");

                Linkedinoptions.ClientId = linkedinAuthNSection["ClientId"];
                Linkedinoptions.ClientSecret = linkedinAuthNSection["ClientSecret"];
                Linkedinoptions.Scope.Add("r_liteprofile");
                Linkedinoptions.Scope.Add("r_emailaddress");
            });
            //

             //for login/register   
             services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {

                    ValidateAudience = true,
                    ValidAudience = "domain.com",
                    ValidateIssuer = true,
                    ValidIssuer = "domain.com",
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("THIS IS THE SECRET KEY"))

                };

            });

            services.AddControllersWithViews();
            services.AddRazorPages();

              services.AddCors(o =>
            {
                o.AddPolicy("AllowAll", builder =>
                {
                    builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseCors("AllowAll");

            app.UseAuthentication();    

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}
