using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using FeedbackCollection.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FeedbackCollection.Controllers
{
    public class HomeController : Controller
    {

        //Hosted web API REST Service base url  
        string Baseurl = "https://localhost:44313/";

        public async Task<ActionResult> Index()
        {

            List<User> UserInfo = new List<User>();
            List<Posts> PostsInfo = new List<Posts>();
            List<Comments> CommentsInfo = new List<Comments>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage UserRes = await client.GetAsync("api/Users/GetUser");
                HttpResponseMessage PostsRes = await client.GetAsync("api/Posts/GetPosts");
                HttpResponseMessage CommentsRes = await client.GetAsync("api/Comments/GetComments");


                //Checking the response is successful or not which is sent using HttpClient  
                if (UserRes.IsSuccessStatusCode && PostsRes.IsSuccessStatusCode && CommentsRes.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var UserResponse = UserRes.Content.ReadAsStringAsync().Result;
                    var PostsResponse = PostsRes.Content.ReadAsStringAsync().Result;
                    var CommentsResponse = CommentsRes.Content.ReadAsStringAsync().Result;


                    //Deserializing the response recieved from web api and storing into the Employee list  
                    //EmpInfo = JsonConvert.DeserializeObject<List<Employee>>(EmpResponse);

                }
                //returning the employee list to view  
                return View();
            }
        }
    }
}
