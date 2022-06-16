using Rest.Contracts;
using ViewModels.Contracts;

namespace Rest.Services
{
    public class GroupMemberService : IGroupMemberService
    {
        public Task<IGroupMemberViewModel> CreateGroupMemberAsync(IGroupMemberViewModel grpMmbViewModel)
        {
            throw new NotImplementedException();
        }

        public Task DeleteGroupMemberByIdAsync(Guid grpMmbId)
        {
            throw new NotImplementedException();
        }

        public Task<IGroupMemberViewModel> GetGroupMemberByIdAsync(Guid grpMmbId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateGroupMemberAsync(IGroupMemberViewModel grpMmbViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
