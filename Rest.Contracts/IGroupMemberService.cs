using ViewModels.Contracts;

namespace Rest.Contracts
{
    public interface IGroupMemberService
    {
        Task<IGroupMemberViewModel> CreateGroupMemberAsync(IGroupMemberViewModel grpMmbViewModel);

        Task<IGroupMemberViewModel> GetGroupMemberByIdAsync(Guid grpMmbId);

        Task UpdateGroupMemberAsync(IGroupMemberViewModel grpMmbViewModel);

        Task DeleteGroupMemberByIdAsync(Guid grpMmbId);
    }
}
