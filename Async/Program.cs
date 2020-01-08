using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Async
{
    class Program
    {
        static void Main(string[] args)
        {
            //var datas = HttpReq.getPost().GetAwaiter().GetResult();
            //foreach (var data in datas)
            //{
            //    Console.WriteLine(data.title);
            //    Console.WriteLine(data.userId);
            //}

            //var datas = HttpReq.getUser().GetAwaiter().GetResult();
            //foreach (var data in datas)
            //{
            //    Console.WriteLine($"{data.address.street},{data.address.city},{data.address.suite}");
            //}

            //var datas = HttpReq.getTopRated().GetAwaiter().GetResult();
            //foreach (var data in datas.movies)
            //{
            //    Console.WriteLine($"{data.title}");
            //    Console.WriteLine($"{data.vote_count}");
            //}

            //var datas = HttpReq.getUser().GetAwaiter().GetResult().Where(e=>e.name.Contains("le"));

            //User userbaru = new User();
            //foreach (var data in datas)
            //{
            //    Console.WriteLine($"{data.name}");
            //}

            //var datas = HttpReq.getTopRated().GetAwaiter().GetResult().movie.Where(e=>e.vote_average>8.4);
            //foreach (var data in datas)
            //{
            //    Console.WriteLine($"{data.title}");
            //    Console.WriteLine($"{data.vote_average}");
            //}

            //var datas = HttpReq.getProduct().GetAwaiter().GetResult().Sum(e=>e.price);
            //Console.WriteLine(datas);

            //var datas = HttpReq.getProduct().GetAwaiter().GetResult().Where(e=>e.category == "fruits");
            //foreach (var data in datas)
            //{
            //    Console.WriteLine($"{data.name}");
            //}

            //var datas = HttpReq.getProduct().GetAwaiter().GetResult().Where(e => e.price>70);
            //foreach (var data in datas)
            //{
            //    Console.WriteLine($"{data.name}");
            //    Console.WriteLine($"{data.price}");
            //}

            var dataPost = HttpReq.getPost().GetAwaiter().GetResult();
            var dataUser = HttpReq.getUser().GetAwaiter().GetResult();

            var gabung = new List<UserPost>();

            foreach (var user in dataUser)
            {
                foreach (var post in dataPost)
                {
                    UserPost userpost = new UserPost();
                    userpost.user = user;
                    userpost.post = post;
                    if (userpost.user.id == userpost.post.userId)
                    {
                        gabung.Add(userpost);
                    }
                }
            }

            var hasil = JsonConvert.SerializeObject(gabung);
            Console.WriteLine(hasil);
        }
    }
}
