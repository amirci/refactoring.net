using System.Collections.Generic;
using System.Linq;

namespace Refactoring.Example5
{
    public class MovieSearcher
    {
        public IEnumerable<string> FindEndsWithAtor(IEnumerable<Movie> source)
        {
            return source
                .Where(EndsWithAtor)
                .Select(m => m.Title);
        }

        private static bool EndsWithAtor(Movie m)
        {
            return m.Title.EndsWith("ator");
        }
    }
}