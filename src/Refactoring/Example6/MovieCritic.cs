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
            IDictionary<int, IEnumerable<Movie>> hash = new Dictionary<int, IEnumerable<Movie>>();

            return movies.Aggregate(hash, ClassifyMovie);
        }

        private static IDictionary<int, IEnumerable<Movie>> ClassifyMovie(IDictionary<int, IEnumerable<Movie>> hash, Movie movie)
        {
            var collection = hash.ContainsKey(movie.Review) 
                ? (ICollection<Movie>) hash[movie.Review] 
                : new List<Movie>();

            collection.Add(movie);

            hash[movie.Review] = collection;

            return hash;
        }

        public IEnumerable<Movie> Top3(IEnumerable<Movie> movies)
        {
            var sorted = movies.ToList();

            sorted.Sort((m1, m2) => m2.Review - m1.Review);

            return new[] {sorted[0], sorted[1], sorted[2]};
        }
    }
}
