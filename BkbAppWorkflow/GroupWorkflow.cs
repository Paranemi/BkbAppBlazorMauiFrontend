using BkbAppWorkflow.Contracts;
using Rest.Contracts;
using ViewModels.Contracts;

namespace BkbAppWorkflow
{
    public class GroupWorkflow : IGroupWorkflow
    {
        private readonly IGroupService _grpService;

        public GroupWorkflow(IGroupService grpRepository)
        {
            _grpService = grpRepository;
        }

        public async Task<IGroupViewModel> CreateGroupAsync(IGroupViewModel grpViewModel)
        {
            return await _grpService.CreateGroupAsync(grpViewModel);
        }

        public async Task<IGroupViewModel> GetGroupByIdAsync(Guid grpId)
        {
            return await _grpService.GetGroupByIdAsync(grpId);
        }

        public async Task UpdateGroupAsync(IGroupViewModel grpViewModel)
        {
            await _grpService.UpdateGroupAsync(grpViewModel);
        }

        public async Task DeleteGroupByIdAsync(Guid grpId)
        {
            await _grpService.DeleteGroupByIdAsync(grpId);
        }
    }
}
