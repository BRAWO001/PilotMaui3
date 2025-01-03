using Microsoft.Extensions.DependencyInjection;
using Pilot_Maui3.Services;
using Pilot_Maui3.Views;
using System;

namespace Pilot_Maui3
{
    public partial class App : Application
    {
        //private readonly IServiceProvider _serviceProvider;

        private readonly IServiceProvider _serviceProvider;

        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;


            // Başlangıçta geçici olarak LoadingPage'i ayarla
            MainPage = new NavigationPage(new LoadingPage());

            ForceLightThema();

            // Başlangıçta MainPage'i ayarlamak için async metodu çağır
            InitializeApp();
        }

        private void ForceLightThema()
        {
            Application.Current.UserAppTheme = AppTheme.Light;

        }


        private async void InitializeApp()
        {
            var kullanici = await SecureVerileriGetir.GetirKullaniciVerileriAsync();

            if (kullanici != null)
            {
                // Kullanıcı verileri mevcutsa AnaSayfaPage'ye yönlendir
                MainPage = new NavigationPage(_serviceProvider.GetRequiredService<AnaSayfaPage>());
            }
            else
            {
                // Kullanıcı verileri yoksa GirisYapPage'ye yönlendir
                MainPage = new NavigationPage(_serviceProvider.GetRequiredService<GirisYapPage>());
            }
        }

        public class LoadingPage : ContentPage
        {
            public LoadingPage()
            {
                Content = new StackLayout
                {
                    Children =
            {
                new Image
                {
                    Source = "pilot_logo_4.png", // Logonuzun dosya adını buraya girin
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    WidthRequest = 200, // Logonun genişliği
                    HeightRequest = 200, // Logonun yüksekliği
                    Margin = 250
                },
                new ActivityIndicator
                {
                    IsRunning = true,
                    VerticalOptions = LayoutOptions.CenterAndExpand
                },
                new Label
                {
                    Text = "Yükleniyor...",
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.CenterAndExpand
                }
            }
                };

                BackgroundColor = Colors.White; // Arka plan rengini beyaz yap
            }
        }

    }
}
