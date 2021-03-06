using Recape.Models;
using System.Linq;

namespace Recape.Data.Repository
{
    public interface IAgendamentoRepository
    {
        IQueryable<Agendamento> GetAgendamentos(string usuarioId);

        bool CriarAgendamento(Agendamento agendamento);

        bool ExcluirAgendamento(int agendamentoId);
    }
}
