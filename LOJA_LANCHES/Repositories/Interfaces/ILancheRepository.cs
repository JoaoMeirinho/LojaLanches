using LojaLanches.Models;

namespace LojaLanches.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches();
        IEnumerable<Lanche> LanchesPreferidos();
        Lanche GetLancheById(int lancheId);
    }
}
