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
            return this._movies
                .Where(m => m.ReleaseDate.HasValue)
                .Where(movie => movie.ReleaseDate.Value >= _startDate && movie.ReleaseDate.Value <= _endDate)
                .Select(m => m.Title);
        } 

    }
}
