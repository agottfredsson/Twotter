using Xamarin.Forms;
using Twotter.Bootstrap;

namespace Twotter
{
    public partial class App : Application
    {
        public App(AppSetup setup)
        {
            InitializeComponent();
            AppContainer.Container = setup.CreateContainer();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
