using RND.OpenBanking.Lembrete.Data;
using RND.OpenBanking.Lembrete.Interfaces;
using RND.OpenBanking.Lembrete.Models;

namespace RND.OpenBanking.Lembrete.Repositories
{
    public class LembreteRepository : BaseRepository<LembreteModel>, ILembrete
    {
        public LembreteRepository(Context repositoryCrudContext) : base(repositoryCrudContext)
        {

        }
    }
}
