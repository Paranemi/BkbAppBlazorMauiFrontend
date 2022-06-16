using Rest.Contracts;
using ViewModels.Contracts;

namespace Rest.Services
{
    public class ParticipationService : IParticipationService
    {
        public Task<IParticipationViewModel> CreateParticipationAsync(IParticipationViewModel ptpViewModel)
        {
            throw new NotImplementedException();
        }

        public Task DeleteParticipationByIdAsync(Guid ptpId)
        {
            throw new NotImplementedException();
        }

        public Task<IParticipationViewModel> GetParticipationByIdAsync(Guid ptpId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateParticipationAsync(IParticipationViewModel ptpViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
