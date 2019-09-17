using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ProfloPortalBackend.BusinessLayer;
using ProfloPortalBackend.DataAccessLayer;

namespace ProfloPortalBackend
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
            services.AddScoped<DBContext>();
            services.AddScoped<ITeamService, TeamService>();
            services.AddScoped<ITeamRepository, TeamImplements>();
            services.AddScoped<IBoardService, BoardService>();
            services.AddScoped<IBoardRepository, BoardRepository>();
            services.AddScoped<IListService, ListService>();
            services.AddScoped<IListRepository, ListRepository>();
            services.AddScoped<ICardService, CardService>();
            services.AddScoped<ICardRepository, CardRepository>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddCors(x => x.AddPolicy("ProfloCorsPolicy", builder => {
                builder
                .AllowAnyHeader()
                .AllowAnyMethod()
                .WithOrigins("http://localhost:4201")
                .AllowAnyOrigin()
                .AllowCredentials();
            }));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseCors("ProfloCorsPolicy");
            app.UseMvc();
            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseStaticFiles();
            app.UseSwaggerUI(n =>
            {
                n.SwaggerEndpoint("/swagger.json", "Core_Backend_Proflo");
            });
        }
    }
}
