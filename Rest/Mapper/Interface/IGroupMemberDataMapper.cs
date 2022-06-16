using Rest.Models;
using ViewModels.Contracts;

namespace BkbAppWorkflow.Contracts.Mapper
{
    public interface IGroupMemberDataMapper
    {
        GroupMemberApiModel ToApiModel(IGroupMemberViewModel grpMmbViewModel);

        IGroupMemberViewModel ToViewModel(GroupMemberApiModel grpMmbApiModel);
    }
}
