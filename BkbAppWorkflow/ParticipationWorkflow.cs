using BkbAppWorkflow.Contracts;
using Rest.Contracts;
using ViewModels.Contracts;

namespace BkbAppWorkflow
{
    public class ParticipationWorkflow : IParticipationWorkflow
    {
        private readonly IParticipationService _ptpService;

        public ParticipationWorkflow(IParticipationService ptpRepository)
        {
            _ptpService = ptpRepository;
        }

        public async Task<IParticipationViewModel> CreateParticipationAsync(IParticipationViewModel ptpViewModel)
        {
            return await _ptpService.CreateParticipationAsync(ptpViewModel);
        }

        public async Task<IParticipationViewModel> GetParticipationByIdAsync(Guid ptpId)
        {
            return await _ptpService.GetParticipationByIdAsync(ptpId);
        }

        public async Task UpdateParticipationAsync(IParticipationViewModel ptpViewModel)
        {
            await _ptpService.UpdateParticipationAsync(ptpViewModel);
        }

        public async Task DeleteParticipationByIdAsync(Guid ptpId)
        {
            await _ptpService.DeleteParticipationByIdAsync(ptpId);
        }
    }
}
