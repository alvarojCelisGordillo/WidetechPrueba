using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using WidetechPrueba.WebProj.Models;

namespace WidetechPrueba.WebProj.Controllers
{
    public class TestController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public async Task<JsonResult> TestMethod(JsonString jsonResult)
        {
            // I'll construct the json here manually for sakes of simplicity. Whoever calls this method for the web project must supply the json string.

            List<TestModel> json = new List<TestModel>();

            var usr = new TestModel();
            usr.Name = "USR";
            usr.Value = "taxi";
            json.Add((usr));

            var pass = new TestModel();
            pass.Name = "PASS";
            pass.Value = "taxi";
            json.Add(pass);

            var clientId = new TestModel();
            clientId.Name = "CLIENTEID";
            clientId.Value = "51776";
            json.Add(clientId);

            var method = new TestModel();
            method.Name = "METHOD";
            method.Value = "GETVEHICLETYPE";
            json.Add(method);

            string parameters = JsonConvert.SerializeObject(json);

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "http://taxisws.widetech.co/API/rest/CabAdvancedRequestRest");
            request.Content = new StringContent(parameters,
                Encoding.UTF8,
                "application/json");

            HttpResponseMessage response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                return new JsonResult(await response.Content.ReadAsStringAsync());
            }

            return new JsonResult(response.IsSuccessStatusCode);
        }
    }
}
