using BkbAppWorkflow.Contracts.Mapper;
using Rest.Models;
using ViewModels.Contracts;
using ViewModels.Contracts.Factories;

namespace BkbAppWorkflow.Mapper
{
    public class GroupDataMapper : IGroupDataMapper
    {
        private readonly IGroupViewModelFactory _grpViewModelFactory;

        public GroupDataMapper(IGroupViewModelFactory grpViewModelFactory)
        {
            _grpViewModelFactory = grpViewModelFactory;
        }

        public GroupApiModel ToApiModel(IGroupViewModel grpViewModel)
        {
            if (grpViewModel == null)
                return null;

            var grpApiModel = new GroupApiModel();
            grpApiModel.Id = grpViewModel.Id;
            grpApiModel.Name = grpViewModel.Name;

            return grpApiModel;
        }

        public IGroupViewModel ToViewModel(GroupApiModel grpApiModel)
        {
            if (grpApiModel == null)
                return null;

            var grpViewModel = _grpViewModelFactory.Create();
            grpViewModel.Id = grpApiModel.Id;
            grpViewModel.Name = grpApiModel.Name;

            return grpViewModel;
        }
    }
}
