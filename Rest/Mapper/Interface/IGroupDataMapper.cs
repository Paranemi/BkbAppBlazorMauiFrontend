using Rest.Models;
using ViewModels.Contracts;

namespace BkbAppWorkflow.Contracts.Mapper
{
    public interface IGroupDataMapper
    {
        GroupApiModel ToApiModel(IGroupViewModel grpViewModel);

        IGroupViewModel ToViewModel(GroupApiModel grpApiModel);
    }
}
