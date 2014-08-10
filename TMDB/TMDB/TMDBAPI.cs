using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Json;

//API Key: ba4e85c2f1842d3cd3a5504ba4c644d6
namespace TMDB
{
    public static class TMDBAPI
    {
        public static void TmdbRequest(string movieName)
        {            
            string url = "http://api.themoviedb.org/3/search/movie?api_key=ba4e85c2f1842d3cd3a5504ba4c644d6&query=";            
            var request = System.Net.WebRequest.Create(url + movieName) as System.Net.HttpWebRequest;
            request.KeepAlive = true;            
            request.Method = "GET";
            request.Accept = "application/json";
            request.ContentLength = 0;
            string responseContent = null;            
            using (var response = request.GetResponse() as System.Net.HttpWebResponse)
            {
                using (var reader = new System.IO.StreamReader(response.GetResponseStream()))
                {
                    responseContent = reader.ReadToEnd();
                    Console.WriteLine(responseContent);
                }
            }



        }
    }
}


///http://api.themoviedb.org/3/search/movie?api_key=ba4e85c2f1842d3cd3a5504ba4c644d6&query=american%20pie