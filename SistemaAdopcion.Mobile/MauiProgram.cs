using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Refit;
using SisemaAdopcion.Shared;

namespace SistemaAdopcion.Mobile
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("Ubuntu-Regular.ttf", "UbuntuRegular");
                    fonts.AddFont("Ubuntu-Bold.ttf", "UbuntuBold");
                })
                .UseMauiCommunityToolkit();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            RegisterAppDependencies(builder.Services);
            ConfigureRefit(builder.Services);

            return builder.Build();
        }

        static void RegisterAppDependencies(IServiceCollection services)
        {
            services.AddSingleton<CommonService>();

            services.AddTransient<LoginRegisterViewModel>()
                .AddTransient<LoginRegisterPage>();
        }

        static void ConfigureRefit(IServiceCollection services)
        {
            services.AddRefitClient<IAuthApi>()
        .ConfigureHttpClient(SetHttpClient);

            services.AddRefitClient<IPetsApi>()
                .ConfigureHttpClient(SetHttpClient);

            static void SetHttpClient(HttpClient httpClient) =>
                httpClient.BaseAddress = new Uri(AppConstants.BaseApiUrl);
        }
    }
}
