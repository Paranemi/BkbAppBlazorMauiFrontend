using BkbAppWorkflow.Contracts;
using Rest.Contracts;
using ViewModels.Contracts;

namespace BkbAppWorkflow
{
    public class UserWorkflow : IUserWorkflow
    {
        private readonly IUserService _usrService;

        public UserWorkflow(IUserService usrRepository)
        {
            _usrService = usrRepository;
        }

        public async Task<IUserViewModel> CreateUserAsync(IUserViewModel usrViewModel)
        {
            return await _usrService.CreateUserAsync(usrViewModel);
        }

        public async Task<IUserViewModel> GetUserByIdAsync(Guid usrId)
        {
            return await _usrService.GetUserByIdAsync(usrId);
        }

        public async Task UpdateUserAsync(IUserViewModel usrViewModel)
        {
            await _usrService.UpdateUserAsync(usrViewModel);
        }

        public async Task DeleteUserByIdAsync(Guid usrId)
        {
            await _usrService.DeleteUserByIdAsync(usrId);
        }
    }
}
