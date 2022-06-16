using Rest.Models;
using ViewModels.Contracts;

namespace BkbAppWorkflow.Contracts.Mapper
{
    public interface IUserDataMapper
    {
        UserApiModel ToApiModel(IUserViewModel usrViewModel);

        IUserViewModel ToViewModel(UserApiModel usrApiModel);
    }
}
