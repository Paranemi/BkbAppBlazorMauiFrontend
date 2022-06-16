using BkbAppWorkflow.Contracts.Mapper;
using Rest.Models;
using ViewModels.Contracts;
using ViewModels.Contracts.Factories;

namespace BkbAppWorkflow.Mapper
{
    public class GroupMemberDataMapper : IGroupMemberDataMapper
    {
        private readonly IGroupMemberViewModelFactory _grpMmbViewModelFactory;
        private readonly IUserDataMapper _usrLogicMapper;
        private readonly IGroupDataMapper _grpLogicMapper;

        public GroupMemberDataMapper(IGroupMemberViewModelFactory grpMmbViewModelFactory, IUserDataMapper usrLogicMapper, IGroupDataMapper grpLogicMapper)
        {
            _grpMmbViewModelFactory = grpMmbViewModelFactory;
            _usrLogicMapper = usrLogicMapper;
            _grpLogicMapper = grpLogicMapper;
        }

        public GroupMemberApiModel ToApiModel(IGroupMemberViewModel grpMmbViewModel)
        {
            if (grpMmbViewModel == null)
                return null;

            var grpMmbApiModel = new GroupMemberApiModel();
            grpMmbApiModel.Id = grpMmbViewModel.Id;
            grpMmbApiModel.User = _usrLogicMapper.ToApiModel(grpMmbViewModel.User);
            grpMmbApiModel.Group = _grpLogicMapper.ToApiModel(grpMmbViewModel.Group);

            return grpMmbApiModel;
        }

        public IGroupMemberViewModel ToViewModel(GroupMemberApiModel grpMmbApiModel)
        {
            if (grpMmbApiModel == null)
                return null;

            var grpMmbViewModel = _grpMmbViewModelFactory.Create();
            grpMmbViewModel.Id = grpMmbApiModel.Id;
            grpMmbViewModel.User = _usrLogicMapper.ToViewModel(grpMmbApiModel.User);
            grpMmbViewModel.Group = _grpLogicMapper.ToViewModel(grpMmbApiModel.Group);

            return grpMmbViewModel;
        }
    }
}
