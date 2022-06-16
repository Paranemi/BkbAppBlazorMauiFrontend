using Rest.Models;
using ViewModels.Contracts;

namespace BkbAppWorkflow.Contracts.Mapper
{
    public interface IParticipationDataMapper
    {
        ParticipationApiModel ToApiModel(IParticipationViewModel ptpViewModel);

        IParticipationViewModel ToViewModel(ParticipationApiModel ptpApiModel);
    }
}
