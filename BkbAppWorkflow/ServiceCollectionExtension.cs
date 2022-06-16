using BkbAppWorkflow.Contracts;
using BkbAppWorkflow.Contracts.Mapper;
using BkbAppWorkflow.Mapper;
using Microsoft.Extensions.DependencyInjection;

namespace BkbAppWorkflow
{
    public static class ServiceCollectionExtension
    {
        public static void RegisterWorkflowServices(this IServiceCollection services)
        {
            services.AddScoped<IUserWorkflow, UserWorkflow>();
            services.AddScoped<IParticipationWorkflow, ParticipationWorkflow>();
            services.AddScoped<IGroupMemberWorkflow, GroupMemberWorkflow>();
            services.AddScoped<IGroupWorkflow, GroupWorkflow>();
            services.AddScoped<IEventWorkflow, EventWorkflow>();
        }
    }
}
