using System;
using System.Collections.Generic;
using System.Linq;
using Refactoring.Example5;

namespace Refactoring.Example7
{
    public class MovieReporter
    {
        private readonly IEnumerable<Movie> _movies;
        private readonly DateTime _startDate;
        private readonly DateTime _endDate;

        public MovieReporter(IEnumerable<Movie> movies, DateTime startDate, DateTime endDate)
        {
            _movies = movies;
            _startDate = startDate;
            _endDate = endDate;
        }

        public IEnumerable<string> MoviesReleased()
        {
            return MoviesInRange().Select(m => m.Title);
        }

        private IEnumerable<Movie> MoviesInRange()
        {
            return this._movies
                .Where(m => m.ReleaseDate.HasValue && IsInRange(m.ReleaseDate.Value, _startDate, _endDate));
        }

        private static bool IsInRange(DateTime date, DateTime startDate, DateTime endDate)
        {
            return date >= startDate && date <= endDate;
        }
    }
}
