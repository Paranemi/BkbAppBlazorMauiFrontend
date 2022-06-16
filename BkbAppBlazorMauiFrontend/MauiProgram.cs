using BkbAppWorkflow;
using Rest;
using ViewModelFactorys;

namespace BkbAppBlazorMauiFrontend;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();
#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif

		builder.Services.RegisterWorkflowServices();
		builder.Services.RegisterDataMapperServices();
		builder.Services.RegisterRestServices();
		builder.Services.RegisterViewModelFactoryServices();

        return builder.Build();
	}
}
