using LearnDotNetCoreMVC.Models;
using LearnDotNetCoreMVC.Models.Entities;
using LearnDotNetCoreMVC.Outils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LearnDotNetCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return RedirectToRoute("loginForm");
        }


        /*********************************** LOGIN ***********************************/

        [HttpGet("/login", Name = "loginForm")]
        public IActionResult Login()
        {
            return View("../Auths/Login");
        }


        // POST api/<HomeController>/5
        [HttpPost("/login", Name = "loginRequest")]
        public async Task<IActionResult> Login(User user)
        {
            string messageError = null;
            string HasError = "null";
            if (ModelState.IsValid)
            {
                HttpClient serverAPI = RequestAPI.Initial();

                HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Post, serverAPI.BaseAddress + "auth");

                string json = JsonConvert.SerializeObject(user);

                requestMessage.Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                HttpClient http = new HttpClient();
                HttpResponseMessage reuqestResponseAPI = await http.SendAsync(requestMessage);
                
                ResponseAPI responseAPI = JsonConvert.DeserializeObject<ResponseAPI>(reuqestResponseAPI.Content.ReadAsStringAsync().Result);

                if (responseAPI.Success)
                    HasError = "false";
                else
                    HasError = "true";

                messageError = responseAPI.Message;

            }
            ViewData["HasError"] = HasError;
            ViewData["MessageResponse"] = messageError;

            return View("../Auths/Login");
        }


        /*********************************** DEMANDS ***********************************/

        [HttpGet("/register", Name = "registerForm")]
        public IActionResult Register()
        {
            return View("../Auths/Register");
        }


        // POST api/<HomeController>/5
        [HttpPost("/register", Name = "registerRequest")]
        public async Task<IActionResult> Register(Demande Demande)
        {
            string messageError = null;
            string HasError = "null";
            if (ModelState.IsValid)
            {
                HttpClient serverAPI = RequestAPI.Initial();

                HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Post, serverAPI.BaseAddress + "demande");

                string json = JsonConvert.SerializeObject(Demande);

                requestMessage.Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                HttpClient http = new HttpClient();
                HttpResponseMessage reuqestResponseAPI = await http.SendAsync(requestMessage);
                ResponseAPI responseAPI = JsonConvert.DeserializeObject<ResponseAPI>(reuqestResponseAPI.Content.ReadAsStringAsync().Result);
                if (responseAPI.Success)
                    HasError = "false";
                else
                    HasError = "true";

                messageError = responseAPI.Message;

            }
            ViewData["HasError"] = HasError;
            ViewData["MessageResponse"] = messageError;

            return View("../Auths/Register", Demande);
        }





        public async void sendPost(Demande Demande)
        {

            HttpClient serverAPI = RequestAPI.Initial();

            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Post, serverAPI.BaseAddress + "/register");

            string json = JsonConvert.SerializeObject(Demande);

            requestMessage.Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            HttpClient http = new HttpClient();
            HttpResponseMessage responseAPI = await http.SendAsync(requestMessage);

            if (responseAPI.IsSuccessStatusCode)
            {
                ViewData["msgError"] = requestMessage + "<br> /*/ " + responseAPI.StatusCode + " <br> /*/ "
                    + responseAPI.Content.ReadAsStringAsync().Result + " <br> /*/ " + responseAPI.RequestMessage;
            }
            else
            {
                var errors = JsonConvert.DeserializeObject<ExceptionResponse>(responseAPI.Content.ReadAsStringAsync().Result);
         

            }
        }


        public async void sendGet()
        {

            HttpClient serverAPI = RequestAPI.Initial();
            string urlApi = "";
            HttpResponseMessage resp = await serverAPI.GetAsync(urlApi);
            var results = "";
            if (resp.IsSuccessStatusCode)
            {
                results = resp.Content.ReadAsStringAsync().Result;
                Demande demande = JsonConvert.DeserializeObject<Demande>(results);
            }
            else
            {
                ViewData["msgError"] = resp.StatusCode + " // " + resp.Content.ReadAsStringAsync().Result + " // " + resp.RequestMessage;
            }
        }







        [HttpGet("/demands", Name = "dashboardDemand")]
        public IActionResult IndexDemand()
        {
            string messageError = null;
            string HasError = "null";

            List<Demande> AllDemands = new List<Demande>();

            ViewData["HasError"] = HasError;
            ViewData["MessageResponse"] = messageError;
            ViewData["menuActive"] = "Demandes";

            return View("../Demands/Index", AllDemands);
        }


        [HttpGet("/organizations", Name = "dashboardOrganization")]
        public IActionResult IndexOrganization()
        {

            string messageError = null;
            string HasError = "null";

            List<Organization> AllOrganization = new List<Organization>();

            ViewData["HasError"] = HasError;
            ViewData["MessageResponse"] = messageError;
            ViewData["menuActive"] = "Organisations";

            return View("../Organizations/Index",AllOrganization);
        }

















        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
