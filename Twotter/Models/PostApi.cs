using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Twotter.Models
{
    public class PostApi
    {

        private Uri uri = new Uri("https://jsonplaceholder.typicode.com/posts/");
        private HttpClient _client;

        public ObservableCollection<Post> Items { get; private set; }


        public PostApi(HttpClient client)
        {
            _client = client;
        }

        public async Task<ObservableCollection<Post>> GetPostsAsync()
        {
            Items = new ObservableCollection<Post>();
            var response = await _client.GetAsync(uri);
            response.EnsureSuccessStatusCode();
            string content = await response.Content.ReadAsStringAsync();
            Items = JsonConvert.DeserializeObject<ObservableCollection<Post>>(content);
            
            return Items;
        }

        public async Task SavePostAsync(Post post)
        {
            string json = JsonConvert.SerializeObject(post);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = null;

            response = await _client.PostAsync(uri, content);
        }
    }
}
