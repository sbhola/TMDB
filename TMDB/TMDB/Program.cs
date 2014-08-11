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

                    if (dir.Substring(dir.LastIndexOf("\\") + 1) != "$RECYCLE.BIN")
                    {
                        //TMDBAPI.TmdbRequest(dir.Substring(dir.LastIndexOf("\\") + 1));
                        Console.WriteLine(dir.Substring(dir.LastIndexOf("\\") + 1));
                    }
                    else
                        Console.WriteLine(dir.Substring(dir.LastIndexOf("\\") + 1) + "\tNot sending a request to TMDB API for this fodler name");
                }
                Console.WriteLine("{0} Directories found", dirs.Count);
            }
            catch (UnauthorizedAccessException UAEx)
            {
                Console.WriteLine(UAEx.Message);
            }
            catch (PathTooLongException PathEx)
            {
                Console.WriteLine(PathEx.Message);
            }
            catch (DirectoryNotFoundException DNFEx)
            {
                Console.WriteLine(DNFEx.Message);
            }


            ///Give a call to TMDB API
            //string movieName = "The lord of the rings";
            //TMDBAPI.TmdbRequest(movieName);
        }
    }
}
