using LearnDotNetCoreMVC.Models;
using LearnDotNetCoreMVC.Models.Entities;
using LearnDotNetCoreMVC.Outils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace LearnDotNetCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly string NameAdmin = "docstream";
        private readonly string EmailAdmin = "ds@gmail.com";
        private readonly string PasswordAdmin = "123456";

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
            try
            {
                if (ModelState.IsValid)
                {
                    if (user.Email.Trim().ToLower().Equals(EmailAdmin.ToLower()))
                    {
                        if (user.PassWord.Trim().Equals(PasswordAdmin.Trim()))
                        {
                            HasError = "false";
                            messageError = "Success Login Admin";

                        }
                        else
                        {
                            HasError = "true";
                            messageError = "User Not Found, please check your email or password";
                        }
                    }
                    else
                    {

                        HttpClient serverAPI = RequestAPI.Initial();
                        string urlApi = serverAPI.BaseAddress + "auth";
                        HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Post, urlApi);

                        string json = JsonConvert.SerializeObject(user);

                        requestMessage.Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                        HttpClient http = new HttpClient();
                        HttpResponseMessage reuqestResponseAPI = await http.SendAsync(requestMessage);

                        var results = reuqestResponseAPI.Content.ReadAsStringAsync().Result;
                        ResponseAPI responseAPI = JsonConvert.DeserializeObject<ResponseAPI>(results);
                        if (responseAPI != null)
                        {
                            HasError = "" + !responseAPI.Success;
                            messageError = responseAPI.Message;
                        }
                        else
                        {
                            HasError = "true";
                            messageError = "Error From server";
                        }
                    }


                }
                else
                {
                    HasError = "true";
                }

            }
            catch (Exception ex)
            {
                HasError = "true";
                messageError = ex.Message;

            }
            if (HasError.ToLower().Equals("true"))
            {
                HasError = HasError.ToLower(); ViewData["HasError"] = HasError;
                ViewData["MessageResponse"] = messageError;
                return View("../Auths/Login", user);
            }

            return RedirectToRoute(new
            {
                controller = this.ControllerContext.RouteData.Values["controller"].ToString(),
                action = "IndexDemand"
            });

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
            try
            {
                if (ModelState.IsValid)
                {
                    HttpClient serverAPI = RequestAPI.Initial();

                    string urlApi = serverAPI.BaseAddress + "demande";
                    HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Post, urlApi);

                    string json = JsonConvert.SerializeObject(Demande);

                    requestMessage.Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                    HttpClient http = new HttpClient();
                    HttpResponseMessage reuqestResponseAPI = await http.SendAsync(requestMessage);
                    var results = reuqestResponseAPI.Content.ReadAsStringAsync().Result;
                    ResponseAPI responseAPI = JsonConvert.DeserializeObject<ResponseAPI>(results);

                    if (responseAPI != null)
                    {
                        HasError = "" + !responseAPI.Success;
                        messageError = responseAPI.Message;
                    }
                    else
                    {
                        HasError = "true";
                        messageError = "Error From server";
                    }

                }
                else
                {
                    HasError = "true";
                }

            }
            catch (Exception ex)
            {
                HasError = "true";
                messageError = ex.Message;

            }
            HasError = HasError.ToLower();
            ViewData["HasError"] = HasError;
            ViewData["MessageResponse"] = messageError;

            return View("../Auths/Register", Demande);
        }


        /*********************************** MANAGE DEMANDS SUPER ADMIN ***********************************/


        [HttpGet("/demands", Name = "dashboardDemand")]
        public async Task<IActionResult> IndexDemand()
        {
            string messageError = null;
            List<Demande> AllDemands = null;
            string HasError = "null";
            try
            {

                HttpClient serverAPI = RequestAPI.Initial();

                string urlApi = serverAPI.BaseAddress + "demande/all";

                HttpResponseMessage reuqestResponseAPI = await serverAPI.GetAsync(urlApi);
                var results = reuqestResponseAPI.Content.ReadAsStringAsync().Result;
                ResponseAPI responseAPI = JsonConvert.DeserializeObject<ResponseAPI>(results);
                if (responseAPI != null)
                {
                    HasError = "" + !responseAPI.Success;
                    if (!responseAPI.Success)
                        messageError = responseAPI.Message;
                    AllDemands = JsonConvert.DeserializeObject<List<Demande>>(JsonConvert.SerializeObject(responseAPI.Data));
                }
                else
                {
                    HasError = "true";
                    messageError = "Error From server";
                }


            }
            catch (Exception ex)
            {
                HasError = "true";
                messageError = ex.Message;
            }


            HasError = HasError.ToLower();
            ViewData["HasError"] = HasError;
            ViewData["MessageResponse"] = messageError;
            ViewData["menuActive"] = "Demandes";

            return View("../Demands/Index", AllDemands);
        }


        [HttpGet("/demands/{value}", Name = "demandDetail")]
        public async Task<IActionResult> DetailDemand(string value)
        {
            string messageError = null;
            Demande Demands = null;
            string HasError = "null";
            try
            {

                HttpClient serverAPI = RequestAPI.Initial();

                string urlApi = serverAPI.BaseAddress + "demande/" + value;

                HttpResponseMessage reuqestResponseAPI = await serverAPI.GetAsync(urlApi);
                var results = reuqestResponseAPI.Content.ReadAsStringAsync().Result;
                ResponseAPI responseAPI = JsonConvert.DeserializeObject<ResponseAPI>(results);

                if (responseAPI != null)
                {
                    HasError = "" + !responseAPI.Success;
                    if (!responseAPI.Success)
                        messageError = responseAPI.Message;
                    else
                        Demands = JsonConvert.DeserializeObject<Demande>(JsonConvert.SerializeObject(responseAPI.Data));
                }
                else
                {
                    HasError = "true";
                    messageError = "Error From server";
                }


            }
            catch (Exception ex)
            {
                HasError = "true";
                messageError = ex.Message;
            }

            

            HasError = HasError.ToLower(); 
            ViewData["HasError"] = HasError;
            ViewData["MessageResponse"] = messageError;
            ViewData["menuActive"] = "Demandes";

            return View("../Demands/Detail", Demands);
        }


        // POST api/<HomeController>/5
        [HttpPost("demands/{value}", Name = "demandResponse")]
        public async Task<IActionResult> RepondreRequest(string value, string mAction, string PrefixDB, string PrefixFolder, Demande demande)
        {
            string messageError = null;
            string HasError = "null";

            try
            {
                mAction.Trim().ToLower();

                if (ModelState.IsValid)
                {
                    HttpClient serverAPI = RequestAPI.Initial();

                    string urlApi = serverAPI.BaseAddress + "demande/" + long.Parse(value) + $"?PrefixDB={PrefixDB}&PrefixFolder={PrefixFolder}";

                    HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Post, urlApi);

                    demande.RegDemandDate = DateTime.Now.ToShortDateString();
                    demande.RegDemandDecision = mAction;
                    string json = JsonConvert.SerializeObject(demande);
                    requestMessage.Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                    HttpClient http = new HttpClient();
                    HttpResponseMessage reuqestResponseAPI = await http.SendAsync(requestMessage);
                    var results = reuqestResponseAPI.Content.ReadAsStringAsync().Result;
                    ResponseAPI responseAPI = JsonConvert.DeserializeObject<ResponseAPI>(results);

                    if (responseAPI != null)
                    {
                        HasError = "" + !responseAPI.Success;
                        if (!responseAPI.Success)
                            messageError = responseAPI.Message;
                    }
                    else
                    {
                        HasError = "true";
                        messageError = "Error From server";
                    }

                }
                else
                {
                    HasError = "true"; 
                }

            }
            catch (Exception ex)
            {
                HasError = "true";
                messageError = ex.Message;

            }
            HasError = HasError.ToLower();
            ViewData["HasError"] = HasError;
            ViewData["MessageResponse"] = messageError;
            ViewData["menuActive"] = "Demandes";

            if (HasError == "true")
                return View("../Demands/Detail", demande);

            return RedirectToRoute(new
            {
                controller = this.ControllerContext.RouteData.Values["controller"].ToString(),
                action = "DetailDemand",
                value = value
            });

        }




        /*********************************** MANAGE ORGANIZATIONS SUPER ADMIN ***********************************/


        [HttpGet("/organizations", Name = "dashboardOrganization")]
        public async Task<IActionResult> IndexOrganization()
        {
            string messageError = null;
            List<Organization> AllOrganizations = null;
            string HasError = "null";
            try
            {

                HttpClient serverAPI = RequestAPI.Initial();

                string urlApi = serverAPI.BaseAddress + "organization/all";

                HttpResponseMessage reuqestResponseAPI = await serverAPI.GetAsync(urlApi);
                var results = reuqestResponseAPI.Content.ReadAsStringAsync().Result;
                ResponseAPI responseAPI = JsonConvert.DeserializeObject<ResponseAPI>(results);

                if (responseAPI != null)
                {
                    HasError = "" + !responseAPI.Success;
                    if (!responseAPI.Success)
                        messageError = responseAPI.Message;
                    AllOrganizations = JsonConvert.DeserializeObject<List<Organization>>(JsonConvert.SerializeObject(responseAPI.Data));
                }
                else
                {
                    HasError = "true";
                    messageError = "Error From server";
                }

            }
            catch (Exception ex)
            {
                HasError = "true";
                messageError = ex.Message;
            }


            HasError = HasError.ToLower(); 
            ViewData["HasError"] = HasError;
            ViewData["MessageResponse"] = messageError;
            ViewData["menuActive"] = "Organisations";

            return View("../Organizations/Index", AllOrganizations);
        }


        [HttpGet("/organizations/{value}", Name = "detailOrganization")]
        public async Task<IActionResult> DetailOrganization(string value)
        {
            string messageError = null;
            string HasError = "null";
            Organization organization = null;
            List<User> AllUsers = new List<User>();
            try
            {

                HttpClient serverAPI = RequestAPI.Initial();

                string urlApi = serverAPI.BaseAddress + "organization/" + value;

                HttpResponseMessage reuqestResponseAPI = await serverAPI.GetAsync(urlApi);
                var results = reuqestResponseAPI.Content.ReadAsStringAsync().Result;
                ResponseAPI responseAPI = JsonConvert.DeserializeObject<ResponseAPI>(results);

                if (responseAPI != null)
                {
                    HasError = "" + !responseAPI.Success;
                    if (!responseAPI.Success)
                        messageError = responseAPI.Message;
                    organization = JsonConvert.DeserializeObject<Organization>(JsonConvert.SerializeObject(responseAPI.Data));
                }
                else
                {
                    HasError = "true";
                    messageError = "Error From server";
                }


                //Get All Users Organization
                urlApi = serverAPI.BaseAddress + $"user/organization?IdOrganization={value}";

                reuqestResponseAPI = await serverAPI.GetAsync(urlApi);
                results = reuqestResponseAPI.Content.ReadAsStringAsync().Result;
                responseAPI = JsonConvert.DeserializeObject<ResponseAPI>(results);
                if (responseAPI != null && responseAPI.Success)
                {
                    HasError = "false";
                    AllUsers = JsonConvert.DeserializeObject<List<User>>(JsonConvert.SerializeObject(responseAPI.Data));
                }


            }
            catch (Exception ex)
            {
                HasError = "true";
                messageError = ex.Message;
            }



            ViewBag.AllUsers = AllUsers;
            ViewData["User_Numbers"] = "" + AllUsers.Count;
            ViewData["Disk_usage"] = "0";
            ViewData["Folder_Numbers"] = "0";
            
            HasError = HasError.ToLower(); 
            ViewData["HasError"] = HasError;
            ViewData["MessageResponse"] = messageError;
            ViewData["menuActive"] = "Organisations";

            return View("../organizations/Detail", organization);
        }


        [HttpPost("/organizations/{value}", Name = "updateOrganization")]
        public async Task<IActionResult> UpdateOrganization(string value, Organization organization)
        {
            string messageError = null;
            string HasError = "null";
            ResponseAPI responseAPI = null;
            try
            {
                if (ModelState.IsValid)
                {

                    HttpClient serverAPI = RequestAPI.Initial();

                    string urlApi = serverAPI.BaseAddress + "organization/" + long.Parse(value);
                    HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Post, urlApi);

                    string json = JsonConvert.SerializeObject(organization);

                    requestMessage.Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                    var content= new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                    HttpClient http = new HttpClient();
                    HttpResponseMessage reuqestResponseAPI = await http.PostAsync(urlApi, content);
                    var results = reuqestResponseAPI.Content.ReadAsStringAsync().Result;
                    responseAPI = JsonConvert.DeserializeObject<ResponseAPI>(results);

                    if (responseAPI != null)
                    {
                        HasError = "" + !responseAPI.Success;
                        if (!responseAPI.Success)
                            messageError = responseAPI.Message;
                    }
                    else
                    {
                        HasError = "true"; 
                        messageError = "Error From server";
                    }
                }
                else
                {
                    HasError = "true";
                }

            }
            catch (Exception ex)
            {
                HasError = "true";
                messageError = ex.Message;
            }


            HasError = HasError.ToLower(); 
            ViewData["HasError"] = HasError;
            ViewData["MessageResponse"] = messageError;
            ViewData["menuActive"] = "Organisations";
            
            return RedirectToRoute(new
            {
                controller = this.ControllerContext.RouteData.Values["controller"].ToString(),
                action = "DetailOrganization",
                value = value
            });
            //return View("../organizations/Detail", organization);
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




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
