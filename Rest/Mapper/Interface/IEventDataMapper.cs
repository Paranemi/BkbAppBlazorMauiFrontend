using Rest.Models;
using ViewModels.Contracts;

namespace BkbAppWorkflow.Contracts.Mapper
{
    public interface IEventDataMapper
    {
        EventApiModel ToApiModel(IEventViewModel evtViewModel);

        IEventViewModel ToViewModel(EventApiModel evtApiModel);
    }
}
