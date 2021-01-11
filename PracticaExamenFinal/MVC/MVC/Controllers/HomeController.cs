using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Mvc;
using MVC.Models;
using Newtonsoft.Json;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:3000");

                var result = client.GetAsync("/survey");

                string data = result.Result.Content.ReadAsStringAsync().Result;
                List<Survey> list = JsonConvert.DeserializeObject<List<Survey>>(data);

                return View(list);
            }
        }

        public ActionResult New()
        {
            return View();
        }

        public ActionResult Edit(Survey search)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:3000");

                var result = client.GetAsync("/survey"+ search.Id);

                string data = result.Result.Content.ReadAsStringAsync().Result;
                Survey survey = JsonConvert.DeserializeObject<Survey>(data);

                return View(survey);
            }
            
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:3000");

                var result = client.GetAsync("/survey/" + id);

                string data = result.Result.Content.ReadAsStringAsync().Result;
                Survey survey = JsonConvert.DeserializeObject<Survey>(data);

                return View(survey);
            }
        }

        [HttpPost]
        public ActionResult Save(Survey survey)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:3000");

                var content = new ObjectContent<Survey>(survey, new JsonMediaTypeFormatter());

                var result = client.PostAsync("/survey", content).Result;

                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPut]
        public ActionResult Change(Survey survey)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:3000");

                var content = new ObjectContent<Survey>(survey, new JsonMediaTypeFormatter());

                var result = client.PutAsync("/survey" + survey.Id, content);

                return RedirectToAction("Index", "Home");
            }
        }
    }
}