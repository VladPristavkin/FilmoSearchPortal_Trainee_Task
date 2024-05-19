using AutoMapper;
using FilmoSearchPortal.Application.DTO.Review;
using FilmoSearchPortal.Domain.Exceptions;
using FilmoSearchPortal.Domain.Interfaces;
using MediatR;
using ReviewEntity = FilmoSearchPortal.Domain.Models.Review;

namespace FilmoSearchPortal.Application.CQRS.Commands.Review
{
    internal sealed class CreateReviewCommandHandler : IRequestHandler<CreateReviewCommand, ReviewDto>
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public CreateReviewCommandHandler(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<ReviewDto> Handle(CreateReviewCommand request, CancellationToken cancellationToken)
        {
            if (request.ReviewForCreating.FilmId == null) throw new FilmIdMissingException();

            var entity = _mapper.Map<ReviewEntity>(request.ReviewForCreating);

            entity.Film = await _repositoryManager.FilmRepository
                .GetFilmByIdAsync(entity.FilmId, true, cancellationToken)
                ?? throw new FilmNotFoundException(entity.FilmId);

            _repositoryManager.ReviewRepository.CreateReview(entity);

            await _repositoryManager.SaveAsync();

            var reviewToReturn = _mapper.Map<ReviewDto>(entity);

            return reviewToReturn;
        }
    }
}
