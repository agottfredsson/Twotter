using Autofac;
using Twotter.Bootstrap;
using Twotter.ViewModels;
using Xamarin.Forms;

namespace Twotter.Views
{
    public partial class LocationPage : ContentPage
    {
        public LocationPage()
        {
            InitializeComponent();
            BindingContext = AppContainer.Container.Resolve<LocationViewModel>();
        }
    }
}
