using ViewModels.Contracts;

namespace Rest.Contracts
{
    public interface IEventService
    {
        Task<IEventViewModel> CreateEventAsync(IEventViewModel evtViewModel);

        Task<IEventViewModel> GetEventByIdAsync(Guid evtId);

        Task UpdateEventAsync(IEventViewModel evtViewModel);

        Task DeleteEventByIdAsync(Guid evtId);
    }
}
