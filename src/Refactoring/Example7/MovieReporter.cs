using System.Collections.Generic;
using System.Linq;
using Refactoring.Example5;

namespace Refactoring.Example7
{
    public class MovieReporter
    {
        private readonly IEnumerable<Movie> _movies;
        private readonly DateRange _range;

        public MovieReporter(IEnumerable<Movie> movies, DateRange _range)
        {
            _movies = movies;
            this._range = _range;
        }

        public IEnumerable<string> MoviesReleased()
        {
            return MoviesInRange().Select(m => m.Title);
        }

        private IEnumerable<Movie> MoviesInRange()
        {
            return this._movies.Where(IsInRange);
        }

        private bool IsInRange(Movie m)
        {
            return m.ReleaseDate.HasValue && this._range.Include(m.ReleaseDate.Value);
        }
    }
}
