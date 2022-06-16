using BkbAppWorkflow.Contracts;
using Rest.Contracts;
using ViewModels.Contracts;

namespace BkbAppWorkflow
{
    public class EventWorkflow : IEventWorkflow
    {
        private readonly IEventService _evtService;

        public EventWorkflow(IEventService evtRepository)
        {
            _evtService = evtRepository;
        }

        public async Task<IEventViewModel> CreateEventAsync(IEventViewModel evtViewModel)
        {
            return await _evtService.CreateEventAsync(evtViewModel);
        }

        public async Task<IEventViewModel> GetEventByIdAsync(Guid evtId)
        {
            return await _evtService.GetEventByIdAsync(evtId);
        }

        public async Task UpdateEventAsync(IEventViewModel evtViewModel)
        {
            await _evtService.UpdateEventAsync(evtViewModel);
        }

        public async Task DeleteEventByIdAsync(Guid evtId)
        {
            await _evtService.DeleteEventByIdAsync(evtId);
        }
    }
}
