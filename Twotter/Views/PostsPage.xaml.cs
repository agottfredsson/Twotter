using Twotter.Bootstrap;
using Twotter.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Autofac;

namespace Twotter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PostsPage : ContentPage
    {
        public PostsPage()
        {
            InitializeComponent();
            BindingContext = AppContainer.Container.Resolve<PostsViewModel>();   
        }
    }
}