using System;
using System.Windows.Input;
using Twotter.Models;
using Xamarin.Forms;

namespace Twotter.ViewModels
{
    public class AddPostViewModel : BaseViewModel
    {
        private PostApi _postApi;
        private string _title;
        private string _message;


        public AddPostViewModel(PostApi postApi)
        {
            _postApi = postApi;
        }

       


        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        public string Message
        {
            get => _message;
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }

        public ICommand ButtonAddPost
        {
            get
            {
                return new Command(async () =>
                {
                    Console.WriteLine(_title);
                    Post post = new Post();
                    post.title = _title;
                    post.body = _message;
                    post.userId = 1;

                    await _postApi.SavePostAsync(post);
                });
            }
        }
    }

   
}
