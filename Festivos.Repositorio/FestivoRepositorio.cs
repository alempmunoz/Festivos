using Festivos.Core.Repositorios;
using Festivos.Dominio.Entidades;
using Festivos.Infraesctructura.Persistencia.FestivosContext;
using Microsoft.EntityFrameworkCore;

namespace Festivos.Repositorio
{
    public class FestivoRepositorio : IFestivoRepositorio
    {
        private readonly FestivoContext context;
        public FestivoRepositorio (FestivoContext context)
        {
            context = context;
        }

        public async Task<Festivo> Obtener(int Id)
        {
            return await context.Festivos.FindAsync(Id);
        }

        public async Task<IEnumerable<Festivo>> ObtenerTodos()
        {
            return await context.Festivos.ToListAsync();
        }

        public async Task<bool> EsFestivo(DateTime fecha)
        {
            var festivos = await context.Festivos.ToListAsync();
            return festivos.Any(f => f.Dia == fecha.Day && f.Mes == fecha.Month);

        }

       
    }
}
