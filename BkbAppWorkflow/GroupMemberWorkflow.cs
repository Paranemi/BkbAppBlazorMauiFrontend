using BkbAppWorkflow.Contracts;
using Rest.Contracts;
using ViewModels.Contracts;

namespace BkbAppWorkflow
{
    public class GroupMemberWorkflow : IGroupMemberWorkflow
    {
        private readonly IGroupMemberService _grpMmbService;

        public GroupMemberWorkflow(IGroupMemberService grpMmbRepository)
        {
            _grpMmbService = grpMmbRepository;
        }

        public async Task<IGroupMemberViewModel> CreateGroupMemberAsync(IGroupMemberViewModel grpMmbViewModel)
        {
            return await _grpMmbService.CreateGroupMemberAsync(grpMmbViewModel);
        }

        public async Task<IGroupMemberViewModel> GetGroupMemberByIdAsync(Guid grpMmbId)
        {
            return await _grpMmbService.GetGroupMemberByIdAsync(grpMmbId);
        }

        public async Task UpdateGroupMemberAsync(IGroupMemberViewModel grpMmbViewModel)
        {
            await _grpMmbService.UpdateGroupMemberAsync(grpMmbViewModel);
        }

        public async Task DeleteGroupMemberByIdAsync(Guid grpMmbId)
        {
            await _grpMmbService.DeleteGroupMemberByIdAsync(grpMmbId);
        }
    }
}
