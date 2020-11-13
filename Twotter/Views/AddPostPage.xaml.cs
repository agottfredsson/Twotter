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
            
            
            switch(Device.RuntimePlatform)
            {
                case Device.iOS:
                    BackgroundColor = Color.Coral;
                    break;
                case Device.Android:
                    BackgroundColor = Color.Brown;
                    break;
            }

        }
    }
}