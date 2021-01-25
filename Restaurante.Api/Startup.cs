using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Restaurante.Api.Domain.Services;
using Restaurante.Api.Domain.Services.Interfaces;
using Restaurante.Api.Repository;
using Restaurante.Api.Repository.DataContext;
using Restaurante.Api.Repository.Interfaces;
using Swashbuckle;

namespace Restaurante.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IRefeicaoService, RefeicaoService>();

            services.AddScoped<IRefeicaoRepository, RefeicaoRepository>();

            services.AddDbContext<RestauranteContext>(opt => opt.UseSqlServer(Configuration["ConnectionString"]));
            services.AddSwaggerGen();

            services.AddControllers()
                    .AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<Startup>());
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseSwagger();
            app.UseSwaggerUI(x =>
            {
                x.SwaggerEndpoint("/swagger/v1/swagger.json", "Restaurante");
                x.RoutePrefix = "api-docs";
            });

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
