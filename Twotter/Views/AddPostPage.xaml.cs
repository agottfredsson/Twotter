using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Twotter.Bootstrap;
using Twotter.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Twotter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPostPage : ContentPage
    {
        public AddPostPage()
        {
            InitializeComponent();
            BindingContext = AppContainer.Container.Resolve<AddPostViewModel>();

        }
    }
}