using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Async
{
    public class HttpReq
    {
        static HttpClient client = new HttpClient();
        
        public static async Task<List<Post>> getPost()
        {
            var result = await client.GetStringAsync("https://jsonplaceholder.typicode.com/posts");
            return JsonConvert.DeserializeObject<List<Post>>(result);
        }
        public static async Task<List<User>> getUser()
        {
            var result = await client.GetStringAsync("https://jsonplaceholder.typicode.com/users");
            return JsonConvert.DeserializeObject<List<User>>(result);
        }
        public static async Task<ResponseMovie> getTopRated()
        {
            var result = await client.GetStringAsync("https://api.themoviedb.org/3/movie/top_rated?page=1&language=en-US&api_key=d3afb5ba2f51532b4d77bda3e1fba203");
            return JsonConvert.DeserializeObject<ResponseMovie>(result);
        }
        public static async Task<List<Product>> getProduct()
        {
            var result = await client.GetStringAsync("https://res.cloudinary.com/sivadass/raw/upload/v1535817394/json/products.json");
            return JsonConvert.DeserializeObject<List<Product>>(result);
        }
    }
    public class Product
    {
        public string name { get; set; }
        public int id { get; set; }
        public int price { get; set; }
        public string image { get; set; }
        public string category { get; set; }
    }
    public class ResponseMovie
    {
        [JsonProperty("results")]
        public List<Movie> movies { get; set; }
    }
    public class Movie
    {
        public double popularity { get; set; }
        public int vote_count { get; set; }
        public bool video { get; set; }
        public string poster_path { get; set; }
        public int id { get; set; }
        public bool adult { get; set; }
        public string backdrop_path { get; set; }
        public string original_language { get; set; }
        public string original_title { get; set; }
        public List<int> genre_ids { get; set; }
        public string title { get; set; }
        public float vote_average { get; set; }
        public string overview { get; set; }
        public string release_date { get; set; }
    }
    public class Post
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public AddressUser address { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public Company company { get; set; }
    }
    public class UserPost
    {
        public User user { get; set; }
        public Post post { get; set; }
    }
    public class AddressUser
    {
        public string street { get; set; }
        public string suite { get; set; }
        public string city { get; set; }
        public string zipcode { get; set; }
        public Geo geo { get; set; }
    }
    public class Geo
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
    }
    public class Company
    {
        public string name { get; set; }
        public string catchPhrase { get; set; }
        public string bs { get; set; }
    }
}
