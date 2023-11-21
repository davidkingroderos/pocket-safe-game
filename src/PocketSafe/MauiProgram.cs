using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using PocketSafe.ViewModels;
using PocketSafe.Views;

namespace PocketSafe;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<EasyViewModel>();
        builder.Services.AddSingleton<MediumViewModel>();
        builder.Services.AddSingleton<HardViewModel>();

        builder.Services.AddSingleton<EasyPage>();
        builder.Services.AddSingleton<MediumPage>();
        builder.Services.AddSingleton<HardPage>();

        return builder.Build();
    }
}
