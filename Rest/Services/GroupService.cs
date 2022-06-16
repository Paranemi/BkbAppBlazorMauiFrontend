using Rest.Contracts;
using ViewModels.Contracts;

namespace Rest.Services
{
    public class GroupService : IGroupService
    {
        public Task<IGroupViewModel> CreateGroupAsync(IGroupViewModel grpViewModel)
        {
            throw new NotImplementedException();
        }

        public Task DeleteGroupByIdAsync(Guid grpId)
        {
            throw new NotImplementedException();
        }

        public Task<IGroupViewModel> GetGroupByIdAsync(Guid grpId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateGroupAsync(IGroupViewModel grpViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
