using BkbAppWorkflow.Contracts.Mapper;
using BkbAppWorkflow.Mapper;
using Microsoft.Extensions.DependencyInjection;
using Rest.Contracts;
using Rest.Services;

namespace Rest
{
    public static class ServiceCollectionExtension
    {
        public static void RegisterRestServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IParticipationService, ParticipationService>();
            services.AddScoped<IGroupMemberService, GroupMemberService>();
            services.AddScoped<IGroupService, GroupService>();
            services.AddScoped<IEventService, EventService>();
        }

        public static void RegisterDataMapperServices(this IServiceCollection services)
        {
            services.AddScoped<IUserDataMapper, UserDataMapper>();
            services.AddScoped<IParticipationDataMapper, ParticipationDataMapper>();
            services.AddScoped<IGroupMemberDataMapper, GroupMemberDataMapper>();
            services.AddScoped<IGroupDataMapper, GroupDataMapper>();
            services.AddScoped<IEventDataMapper, EventDataMapper>();
        }

    }
}
