using ViewModels.Contracts;

namespace Rest.Contracts
{
    public interface IUserService
    {
        Task<IUserViewModel> CreateUserAsync(IUserViewModel usrViewModel);

        Task<IUserViewModel> GetUserByIdAsync(Guid usrId);

        Task UpdateUserAsync(IUserViewModel usrViewModel);

        Task DeleteUserByIdAsync(Guid usrId);
    }
}
