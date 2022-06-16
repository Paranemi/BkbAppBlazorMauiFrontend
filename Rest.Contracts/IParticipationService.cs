using ViewModels.Contracts;

namespace Rest.Contracts
{
    public interface IParticipationService
    {
        Task<IParticipationViewModel> CreateParticipationAsync(IParticipationViewModel ptpViewModel);

        Task<IParticipationViewModel> GetParticipationByIdAsync(Guid ptpId);

        Task UpdateParticipationAsync(IParticipationViewModel ptpViewModel);

        Task DeleteParticipationByIdAsync(Guid ptpId);
    }
}
