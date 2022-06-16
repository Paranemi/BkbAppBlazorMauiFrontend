using Rest.Contracts;
using ViewModels.Contracts;

namespace Rest.Services
{
    public class EventService : IEventService
    {
        public Task<IEventViewModel> CreateEventAsync(IEventViewModel evtViewModel)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEventByIdAsync(Guid evtId)
        {
            throw new NotImplementedException();
        }

        public Task<IEventViewModel> GetEventByIdAsync(Guid evtId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEventAsync(IEventViewModel evtViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
