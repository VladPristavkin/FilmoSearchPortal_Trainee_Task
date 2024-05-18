using FilmoSearchPortal.Domain.Interfaces.RepositoryInterfaces;
using FilmoSearchPortal.Domain.Models;
using FilmoSearchPortal.Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace FilmoSearchPortal.Infrastructure.Repositories
{
    internal class ActorRepository : RepositoryBase<Actor>, IActorRepository
    {
        public ActorRepository(ApplicationDbContext dbContext) : base(dbContext) { }

        public void CreateActor(Actor actor) => Create(actor);

        public void DeleteActor(Actor actor) => Delete(actor);

        public async Task<Actor?> GetActorByIdAsync(int id, bool trackChanges, CancellationToken token = default) =>
            await FindAllByExpression(ac => ac.Id == id, trackChanges)
            .SingleOrDefaultAsync(token);

        public async Task<IEnumerable<Actor>> GetAllActorsAsync(int filmId, bool trackChanges, CancellationToken token = default) =>
            await FindAll(trackChanges)
            .Where(ac=>ac.Films.Any(fl=>fl.Id==filmId))
            .ToListAsync(token);

        public void UpdateActor(Actor actor) => Update(actor);
    }
}
