using Microsoft.Extensions.DependencyInjection;
using ViewModels.Contracts.Factories;
using ViewModels.Factories;

namespace ViewModelFactorys
{
    public static class ServiceCollectionExtension
    {
        public static void RegisterViewModelFactoryServices(this IServiceCollection services)
        {
            services.AddScoped<IUserViewModelFactory, UserViewModelFactory>();
            services.AddScoped<IParticipationViewModelFactory, ParticipationViewModelFactory>();
            services.AddScoped<IGroupMemberViewModelFactory, GroupMemberViewModelFactory>();
            services.AddScoped<IGroupViewModelFactory, GroupViewModelFactory>();
            services.AddScoped<IEventViewModelFactory, EventViewModelFactory>();
        }
    }
}
