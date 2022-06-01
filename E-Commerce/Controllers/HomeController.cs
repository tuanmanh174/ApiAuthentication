using E_Commerce.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace E_Commerce.Controllers
{
    public class HomeController : Controller
    {
        // call api getall facebook
        static HttpClient client = new HttpClient();
        public async Task<ActionResult> Index()
        {
            var facebookModel = new FacebookModel();
            try
            {
                var endpoint = "http://localhost:38752/api/facebook/getallfacebook";
                var result = client.GetAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;
                string output = JsonConvert.SerializeObject(json);
                facebookModel = JsonConvert.DeserializeObject<FacebookModel>(output);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return View(facebookModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}