using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace Twotter.Models
{
    public class PostApi
    {

        private Uri uri = new Uri("https://jsonplaceholder.typicode.com/posts/");
        private HttpClient _client;

        public ObservableCollection<Post> Items { get; private set; }
        public ObservableCollection<Post> AddedItems { get; private set; }



        public PostApi(HttpClient client)
        {
            _client = client;
            AddedItems = new ObservableCollection<Post>();
            
        }

        public async Task<ObservableCollection<Post>> GetPostsAsync()
        {
            
            Items = new ObservableCollection<Post>();
            var response = await _client.GetAsync(uri);
            response.EnsureSuccessStatusCode();
            string content = await response.Content.ReadAsStringAsync();
            Items = JsonConvert.DeserializeObject<ObservableCollection<Post>>(content);
            
            if (AddedItems.Count > 0)
            {
                foreach (Post post in AddedItems)
                {
                    Items.Add(post);
                }
            }
            
            return Items;
        }
        
        private Uri TestUri = new Uri("https://jsonplaceholder.typicode.com/posts/1/");
        public async Task<Post> GetPostAsync()
        {
            var response = await _client.GetAsync(TestUri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var post = JsonConvert.DeserializeObject<Post>(content);
                return post;
            } else
            {
                return null;
            }

        }

        public async Task SavePostAsync(Post post)
        {
            string json = JsonConvert.SerializeObject(post);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = null;

            response = await _client.PostAsync(uri, content);
            AddedItems.Insert(0, post);

        }
    }
}
