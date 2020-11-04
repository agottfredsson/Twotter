using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Twotter.ViewModels
{
    public class AddPostViewModel : BaseViewModel
    {
        
        public AddPostViewModel()
        {
        }

        private string _title;

        public string Text
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        public ICommand ButtonAddPost
        {
            get
            {
                return new Command(() =>
                {
                    Console.WriteLine(_title);
                });
            }
        }
    }

   
}
