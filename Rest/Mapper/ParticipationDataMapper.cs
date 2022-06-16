using BkbAppWorkflow.Contracts.Mapper;
using Rest.Models;
using ViewModels.Contracts;
using ViewModels.Contracts.Factories;

namespace BkbAppWorkflow.Mapper
{
    public class ParticipationDataMapper : IParticipationDataMapper
    {
        private readonly IParticipationViewModelFactory _ptpViewModelFactory;
        private readonly IUserDataMapper _usrLogicMapper;
        private readonly IEventDataMapper _evtLogicMapper;

        public ParticipationDataMapper(IParticipationViewModelFactory ptpViewModelFactory, IUserDataMapper usrLogicMapper, IEventDataMapper evtLogicMapper)
        {
            _ptpViewModelFactory = ptpViewModelFactory;
            _usrLogicMapper = usrLogicMapper;
            _evtLogicMapper = evtLogicMapper;
        }

        public ParticipationApiModel ToApiModel(IParticipationViewModel ptpViewModel)
        {
            if (ptpViewModel == null)
                return null;

            var ptpApiModel = new ParticipationApiModel();
            ptpApiModel.Id = ptpViewModel.Id;
            ptpApiModel.Participate = ptpViewModel.Participate;
            ptpApiModel.Reason = ptpViewModel.Reason;
            ptpApiModel.User = _usrLogicMapper.ToApiModel(ptpViewModel.User);
            ptpApiModel.Event = _evtLogicMapper.ToApiModel(ptpViewModel.Event);

            return ptpApiModel;
        }

        public IParticipationViewModel ToViewModel(ParticipationApiModel ptpApiModel)
        {
            if (ptpApiModel == null)
                return null;

            var ptpViewModel = _ptpViewModelFactory.Create();
            ptpViewModel.Id = ptpApiModel.Id;
            ptpViewModel.Participate = ptpApiModel.Participate;
            ptpViewModel.Reason = ptpApiModel.Reason;
            ptpViewModel.User = _usrLogicMapper.ToViewModel(ptpApiModel.User);
            ptpViewModel.Event = _evtLogicMapper.ToViewModel(ptpApiModel.Event);

            return ptpViewModel;
        }
    }
}
