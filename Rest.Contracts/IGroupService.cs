using ViewModels.Contracts;

namespace Rest.Contracts
{
    public interface IGroupService
    {
        Task<IGroupViewModel> CreateGroupAsync(IGroupViewModel grpViewModel);

        Task<IGroupViewModel> GetGroupByIdAsync(Guid grpId);

        Task UpdateGroupAsync(IGroupViewModel grpViewModel);

        Task DeleteGroupByIdAsync(Guid grpId);
    }
}
