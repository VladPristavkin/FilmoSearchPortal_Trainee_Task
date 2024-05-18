using FilmoSearchPortal.Domain.Interfaces;
using FilmoSearchPortal.Domain.Interfaces.RepositoryInterfaces;
using FilmoSearchPortal.Infrastructure.DbContexts;

namespace FilmoSearchPortal.Infrastructure
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly ApplicationDbContext _dbContext;

        private readonly Lazy<IActorRepository> _actorRepository;
        private readonly Lazy<IDirectorRepository> _directorRepository;
        private readonly Lazy<IFilmRepository> _filmRepository;
        private readonly Lazy<IGenreRepository> _genreRepository;
        private readonly Lazy<IReviewRepository> _reviewRepository;

        public RepositoryManager(ApplicationDbContext dbContext)
        {
            _dbContext=dbContext;
            _actorRepository = new Lazy<IActorRepository>(()=> new );
        }

        public IActorRepository ActorRepository => throw new NotImplementedException();

        public IDirectorRepository DirectorRepository => throw new NotImplementedException();

        public IFilmRepository FilmRepository => throw new NotImplementedException();

        public IGenreRepository GenreRepository => throw new NotImplementedException();

        public IReviewRepository ReviewRepository => throw new NotImplementedException();

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
