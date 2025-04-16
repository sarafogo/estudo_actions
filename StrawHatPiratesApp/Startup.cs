using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace StrawHatPiratesApp
{
    public class Startup
    {
        // Configura os serviços da aplicação (injeção de dependências, etc.)
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers(); // Adiciona suporte a controladores (API)
        }

        // Configura o pipeline de requisições HTTP
        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting(); // Habilita o roteamento

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers(); // Mapeia os endpoints dos controladores
            });
        }
    }
}