using BkbAppWorkflow.Contracts.Mapper;
using Rest.Models;
using ViewModels.Contracts;
using ViewModels.Contracts.Factories;

namespace BkbAppWorkflow.Mapper
{
    public class UserDataMapper : IUserDataMapper
    {
        private readonly IUserViewModelFactory _usrViewModelFactory;

        public UserDataMapper(IUserViewModelFactory usrViewModelFactory)
        {
            _usrViewModelFactory = usrViewModelFactory;
        }

        public UserApiModel ToApiModel(IUserViewModel usrViewModel)
        {
            if (usrViewModel == null)
                return null;

            var usrApiModel = new UserApiModel();
            usrApiModel.Id = usrViewModel.Id;
            usrApiModel.Name = usrViewModel.Name;
            usrApiModel.Email = usrViewModel.Email;

            return usrApiModel;
        }

        public IUserViewModel ToViewModel(UserApiModel usrApiModel)
        {
            if (usrApiModel == null)
                return null;

            var usrViewModel = _usrViewModelFactory.Create();
            usrViewModel.Id = usrApiModel.Id;
            usrViewModel.Name = usrApiModel.Name;
            usrViewModel.Email = usrApiModel.Email;

            return usrViewModel;
        }
    }
}
