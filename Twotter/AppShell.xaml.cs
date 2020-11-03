
using Twotter.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Twotter
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("posts", typeof(PostsPage));
            Routing.RegisterRoute("addpost", typeof(AddPostPage));
        }
    }
}