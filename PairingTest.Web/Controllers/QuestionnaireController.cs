using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json;
using PairingTest.Web.Models;

namespace PairingTest.Web.Controllers
{
    public class QuestionnaireController : Controller
    {
        /* ASYNC ACTION METHOD... IF REQUIRED... */
        public async Task<ViewResult> Index()
        {
            var model = new QuestionnaireViewModel();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(System.Configuration.ConfigurationManager.AppSettings["QuestionnaireServiceUri"]);

                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync("api/questions");

                if (Res.IsSuccessStatusCode)
                {
                    var QuestionnaireResponse = Res.Content.ReadAsStringAsync().Result;
                    
                    model = JsonConvert.DeserializeObject<QuestionnaireViewModel>(QuestionnaireResponse);

                }
                return View(model);
            }
        }


    }
}
