using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Pilot_Maui3.Views;
using Pilot_Maui3.ViewModels;
using Pilot_Maui3.Services;




namespace Pilot_Maui3
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                // Initialize the .NET MAUI Community Toolkit by adding the below line of code
                .UseMauiCommunityToolkit()
                // After initializing the .NET MAUI Community Toolkit, optionally add additional fonts
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            //var handler = new HttpClientHandler();
            //handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; };

            // Http DI öncesi yorum satırı yaptım
            //var client = new HttpClient()
            //{
            //    Timeout = TimeSpan.FromSeconds(30)
            //};

            // HttpClient servisini ekleme
            builder.Services.AddHttpClient();

            builder.Services.AddTransient<GirisYapViewModel>();
            builder.Services.AddTransient<ApartmanimViewModel>();
            builder.Services.AddTransient<AnaSayfaViewModel>();
            builder.Services.AddTransient<SorunBildirViewModel>();
            builder.Services.AddTransient<IstekTalebiViewModel>();
            builder.Services.AddTransient<ProfilimViewModel>();
            builder.Services.AddTransient<GelirGiderViewModel>();
            builder.Services.AddTransient<AptPanoViewModel>();
            builder.Services.AddTransient<ProfilimFaturalarViewModel>();
            builder.Services.AddTransient<TalepGonderViewModel>();

            builder.Services.AddTransient<SmsService>();
            builder.Services.AddTransient<PilotTokenManager>();


            // Pages ekleme
            builder.Services.AddTransient<GirisYapPage>();
            builder.Services.AddTransient<ApartmanimPage>();
            builder.Services.AddTransient<AnaSayfaPage>();
            builder.Services.AddTransient<SorunBildirPage>();
            builder.Services.AddTransient<IstekTalebiPage>();
            builder.Services.AddTransient<ProfilimPage>();
            builder.Services.AddTransient<AptPanoPage>();
            builder.Services.AddTransient<ProfilimFaturalarPage>();
            builder.Services.AddTransient<TalepGonderPage>();
            builder.Services.AddTransient<GelirGiderPage>();
            builder.Services.AddTransient<SifremiUnuttumPage>();


            // Continue initializing your .NET MAUI App here
            // Dependency Injection kayıtları
            //builder.Services.AddSingleton<HttpClient>(client);
            //builder.Services.AddTransient<GirisYapViewModel>();
            return builder.Build();
        }
    }
}
