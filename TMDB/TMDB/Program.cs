using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMDB
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = "The lord of the rings";
            TMDBAPI.TmdbRequest(movieName);

        }
    }
}
