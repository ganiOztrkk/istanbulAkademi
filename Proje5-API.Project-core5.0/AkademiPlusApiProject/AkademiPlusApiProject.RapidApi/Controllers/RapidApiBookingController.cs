using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AkademiPlusApiProject.RapidApi.Models;
using Newtonsoft.Json;

namespace AkademiPlusApiProject.RapidApi.Controllers
{
    public class RapidApiBookingController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/hotels/search?checkin_date=2023-09-27&dest_type=city&units=metric&checkout_date=2023-09-28&adults_number=2&order_by=popularity&dest_id=-755070&filter_by_currency=TRY&locale=en-gb&room_number=1&children_number=2&children_ages=5%2C5&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&page_number=0&include_adjacency=true"),
                Headers =
                {
                    { "X-RapidAPI-Key", "57a05ced9fmsh7440ac7d8e5603fp1f46d8jsnd9e3022ec3f3" },
                    { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<RapidApiBookingViewModel>(body);

                return View(values.result.ToList());
            }
        }
    }
}
