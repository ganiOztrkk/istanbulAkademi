using System;
using System.Collections.Generic;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AkademiPlusApiProject.RapidApi.Models;
using Newtonsoft.Json;


namespace AkademiPlusApiProject.RapidApi.Controllers
{
    public class RapidApiImdbController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<RapidApiImdbViewModel> rapidApiImdbViewModels = new List<RapidApiImdbViewModel>(); 
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
                Headers =
                {
                    { "X-RapidAPI-Key", "57a05ced9fmsh7440ac7d8e5603fp1f46d8jsnd9e3022ec3f3" },
                    { "X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                rapidApiImdbViewModels = JsonConvert.DeserializeObject<List<RapidApiImdbViewModel>>(body);
                return View(rapidApiImdbViewModels);
            }
        }
    }
}
