using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Twotter.Models;
using System.Windows.Input;
using Xamarin.Essentials;

namespace Twotter.ViewModels
{
    class PostsViewModel : BaseViewModel
    {
        private PostApi _postApi;

        public ObservableCollection<Post> Items { get; set; }

        public ICommand LoadItemsCommand { get; }

        public Command<Post> ItemTapped { get; }

       
        public PostsViewModel(PostApi postApi)
        {
            _postApi = postApi;
            Items = new ObservableCollection<Post>();

            Task.Run(async () => { await FetchItems(); });
            LoadItemsCommand = new Command(async () => await FetchItems());

           


        }


        private async Task FetchItems()
        {
            IsBusy = true;
            Items.Clear();
            var items = await _postApi.GetPostsAsync();

            foreach (Post post in items)
            {
                Items.Add(post);     
            }
            Console.WriteLine(Items.Count);

            IsBusy = false;
        }
    }
}
