using AutoMapper;
using FilmoSearchPortal.Domain.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Identity;
using UserEntity = FilmoSearchPortal.Domain.Models.User;

namespace FilmoSearchPortal.Application.CQRS.Commands.User
{
    internal sealed class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, IdentityResult>
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly UserManager<UserEntity> _userManager;

        public RegisterUserCommandHandler(IRepositoryManager repositoryManager, IMapper mapper,
            UserManager<UserEntity> userManager)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<IdentityResult> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<UserEntity>(request.UserForRegistration);

            var result = await _userManager.CreateAsync(user, request.UserForRegistration.Password);

            if (result.Succeeded)
                await _userManager.AddToRolesAsync(user, request.UserForRegistration.Roles);

            return result;
        }
    }
}
