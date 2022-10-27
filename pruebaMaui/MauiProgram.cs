using pruebaMaui.ViewModels;
namespace pruebaMaui;


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
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<PrincipalViewModel>();
        builder.Services.AddSingleton<Login>();
        builder.Services.AddSingleton<LoginViewModel>();
        return builder.Build();
    }
}