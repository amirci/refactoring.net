using System.Collections.Generic;
using System.Linq;
using Refactoring.Example5;

namespace Refactoring.Example6
{
    public class MovieCritic
    {
        public int Threshold { get; set; }

        public bool AnyGoodOnes(IEnumerable<Movie> movies)
        {
            return movies.Any(OverTheThreshold);
        }

        private bool OverTheThreshold(Movie arg)
        {
            return arg.Review >= this.Threshold;
        }

        public IDictionary<int, IEnumerable<Movie>> Classify(IEnumerable<Movie> movies)
        {
            return movies
                .GroupBy(m => m.Review)
                .ToDictionary(g => g.Key, g => g.ToList().AsEnumerable());
        }

        public IEnumerable<Movie> Top(IEnumerable<Movie> movies, int count=3)
        {
            return movies.OrderByDescending(m => m.Review).Take(count);
        }
    }
}
