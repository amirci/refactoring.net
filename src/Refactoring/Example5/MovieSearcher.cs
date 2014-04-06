using System.Collections.Generic;

namespace Refactoring.Example5
{
    public class MovieSearcher
    {
        public IList<string> FindSomethingLike(IList<Movie> source)
        {
            var filtered = new List<Movie>();

            foreach (var movie in source)
            {
                if (movie.Title.EndsWith("ator"))
                {
                    filtered.Add(movie);
                }
            }

            var result = new List<string>();

            foreach (var movie in filtered)
            {
                result.Add(movie.Title);    
            }

            return result;
        }

    }
}