using System;
using System.Collections.Generic;
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
            var result = new List<string>();

            var matching = new List<Movie>();

            foreach (var movie in _movies)
            {
                if (movie.ReleaseDate.HasValue)
                {
                    if (movie.ReleaseDate.Value >= _startDate && movie.ReleaseDate.Value <= _endDate)
                    {
                        matching.Add(movie);
                    }
                }
            }

            foreach (var movie in _movies)
            {
                result.Add(movie.Title);
            }

            return result;
        } 

    }
}
