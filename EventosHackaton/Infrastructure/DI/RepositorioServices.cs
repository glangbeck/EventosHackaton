using EventosHackaton.Infrastructure.Mappers;
using EventosHackaton.Services.Eventos;
using EventosHackaton.Services.Eventos.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace EventosHackaton.Infrastructure.DI
{
    public static class RepositorioServices
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddTransient<IEventoService, EventoService>();
			services.AddTransient<IEventoMapper, EventoMapper>();
		}
    }
}
