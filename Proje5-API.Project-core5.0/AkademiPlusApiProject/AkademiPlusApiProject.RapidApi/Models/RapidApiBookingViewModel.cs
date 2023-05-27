namespace AkademiPlusApiProject.RapidApi.Models
{
    public class RapidApiBookingViewModel
    {
        public Result[] result { get; set; }
        public class Result
        {
            public string city_name_en { get; set; }
           
            public string review_score_word { get; set; }
           
            public string hotel_name { get; set; }
        }
    }
}
