using Rest.Contracts;
using ViewModels.Contracts;

namespace Rest.Services
{
    public class UserService : IUserService
    {
        public Task<IUserViewModel> CreateUserAsync(IUserViewModel usrViewModel)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUserByIdAsync(Guid usrId)
        {
            throw new NotImplementedException();
        }

        public Task<IUserViewModel> GetUserByIdAsync(Guid usrId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserAsync(IUserViewModel usrViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
