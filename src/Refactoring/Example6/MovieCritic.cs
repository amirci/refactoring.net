using System.Collections.Generic;
using Refactoring.Example5;

namespace Refactoring.Example6
{
    public class MovieCritic
    {
        public MovieCritic(int threshold)
        {
            this.Threshold = threshold;
        }

        public int Threshold { get; private set; }

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
    }
}
