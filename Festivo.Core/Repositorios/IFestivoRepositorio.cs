using Festivos.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festivos.Core.Repositorios
{
    public interface IFestivoRepositorio
    {
        Task<Festivo> Obtener(int Id);
        Task<IEnumerable<Festivo>> ObtenerTodos();
        Task<bool> EsFestivo(DateTime fecha);
    }
}
