using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TMDB
{
    class Program
    {
        static void Main(string[] args)
        {
            ///retrieve all the directorty folder names 
            string dirPath = @"D:\";

            try
            {
                List<string> dirs = new List<string>(Directory.EnumerateDirectories(dirPath));

                foreach (var dir in dirs)
                {
                    Console.WriteLine(dir.Substring(dir.LastIndexOf("\\")+1));
                }
                Console.WriteLine("{0} Directories found",dirs.Count);
            }
            catch (UnauthorizedAccessException UAEx)
        {
            Console.WriteLine(UAEx.Message);
        }
        catch (PathTooLongException PathEx)
        {
            Console.WriteLine(PathEx.Message);
        }
                



            ///Give a call to TMDB API
            //string movieName = "The lord of the rings";
            //TMDBAPI.TmdbRequest(movieName);
        }
    }
}
