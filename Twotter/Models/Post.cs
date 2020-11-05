using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Twotter.Models
{
    public class Post
    {
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
        public int userId { get; set; }
    }

     public class Posts
     {
         public ObservableCollection<Post> All { get; set;}
     } 
}
