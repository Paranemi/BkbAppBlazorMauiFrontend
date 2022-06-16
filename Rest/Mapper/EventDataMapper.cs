using BkbAppWorkflow.Contracts.Mapper;
using Rest.Models;
using ViewModels.Contracts;
using ViewModels.Contracts.Factories;

namespace BkbAppWorkflow.Mapper
{
    public class EventDataMapper : IEventDataMapper
    {
        private readonly IEventViewModelFactory _evtViewModelFactory;
        private readonly IGroupDataMapper _grpLogicMapper;

        public EventDataMapper(IEventViewModelFactory evtViewModelFactory, IGroupDataMapper usrLogicMapper)
        {
            _evtViewModelFactory = evtViewModelFactory;
            _grpLogicMapper = usrLogicMapper;
        }

        public EventApiModel ToApiModel(IEventViewModel evtViewModel)
        {
            if (evtViewModel == null)
                return null;

            var evtApiModel = new EventApiModel();
            evtApiModel.Id = evtViewModel.Id;
            evtApiModel.Name = evtViewModel.Name;
            evtApiModel.Description = evtViewModel.Description;
            evtApiModel.Date = evtViewModel.Date;
            evtApiModel.Group = _grpLogicMapper.ToApiModel(evtViewModel.Group);

            return evtApiModel;
        }

        public IEventViewModel ToViewModel(EventApiModel evtApiModel)
        {
            if (evtApiModel == null)
                return null;

            var evtViewModel = _evtViewModelFactory.Create();
            evtViewModel.Id = evtApiModel.Id;
            evtViewModel.Name = evtApiModel.Name;
            evtViewModel.Description = evtApiModel.Description;
            evtViewModel.Date = evtApiModel.Date;
            evtViewModel.Group = _grpLogicMapper.ToViewModel(evtApiModel.Group);

            return evtViewModel;
        }
    }
}
