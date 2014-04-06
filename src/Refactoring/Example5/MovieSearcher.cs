using System.Collections.Generic;
using System.Linq;

namespace Refactoring.Example5
{
    public class MovieSearcher
    {
        public IEnumerable<string> FindEndsWithAtor(IEnumerable<Movie> source)
        {
            return source
                .Where(m => m.Title.EndsWith("ator"))
                .Select(m => m.Title);
        }

    }
}