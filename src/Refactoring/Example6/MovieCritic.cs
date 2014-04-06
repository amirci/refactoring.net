using System.Collections.Generic;
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
    }
}
