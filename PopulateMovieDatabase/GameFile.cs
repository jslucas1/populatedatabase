using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace PopulateMovieDatabase
{
    class GameFile
    {
    
        public static void SaveGame(Game myGame)
        {
            var content = new StringContent(JsonConvert.SerializeObject(myGame).ToString(), Encoding.UTF8, "application/json");
            string url;

            
                url = @"http://lucas-swami-api.herokuapp.com/games/";
            

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");

                
                var response = httpClient.PostAsync(new Uri(url), content).Result;
                


            }
        }


    }
}

