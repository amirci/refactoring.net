using System.Collections.Generic;
using System.Linq;
using Refactoring.Example5;

namespace Refactoring.Example6
{
    public class MovieCritic
    {
        public int Threshold { get; set; }

        public bool AnyGoodOnes(IList<Movie> movies)
        {
            var result = new List<Movie>();

            foreach (var movie in movies)
            {
                if (movie.Review >= this.Threshold)
                {
                    result.Add(movie);
                }
            }

            return result.Count > 0;
        }

        public IDictionary<int, IEnumerable<Movie>> Classify(IEnumerable<Movie> movies)
        {
            var result = new Dictionary<int, IEnumerable<Movie>>();

            foreach (var movie in movies)
            {
                if (!result.ContainsKey(movie.Review))
                {
                    result[movie.Review] = new List<Movie>();
                }

                ((List<Movie>)result[movie.Review]).Add(movie);
            }

            return result;
        }

        public IEnumerable<Movie> Top3(IEnumerable<Movie> movies)
        {
            var sorted = movies.ToList();

            sorted.Sort((m1, m2) => m2.Review - m1.Review);

            return new[] {sorted[0], sorted[1], sorted[2]};
        }
    }
}
