using Pilot_Maui3.Views;

namespace Pilot_Maui3
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(GirisYapPage), typeof(GirisYapPage));
            Routing.RegisterRoute(nameof(AnaSayfaPage), typeof(AnaSayfaPage));
            Routing.RegisterRoute(nameof(ApartmanimPage), typeof(ApartmanimPage));
            Routing.RegisterRoute(nameof(GelirGiderPage), typeof(GelirGiderPage));
            Routing.RegisterRoute(nameof(SorunBildirPage), typeof(SorunBildirPage));
            Routing.RegisterRoute(nameof(ProfilimFaturalarPage), typeof(ProfilimFaturalarPage));
            Routing.RegisterRoute(nameof(TalepGonderPage), typeof(TalepGonderPage));
            Routing.RegisterRoute(nameof(SifremiUnuttumPage), typeof(SifremiUnuttumPage));
        }
    }
}
