using FilmoSearchPortal.Application.DTO.Review;
using MediatR;

namespace FilmoSearchPortal.Application.CQRS.Commands.Review
{
    public record CreateReviewCommand(ReviewForCreatingDto ReviewForCreating) : IRequest<ReviewDto>;
}
