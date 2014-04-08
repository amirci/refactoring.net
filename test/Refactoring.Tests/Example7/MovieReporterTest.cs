using System;
using System.Collections.Generic;
using NUnit.Framework;
using Refactoring.Example5;
using Refactoring.Example7;

namespace Refactoring.Tests.Example7
{
     class MovieReporterTest
    {
        protected MovieReporter Subject { get; set; }

        protected readonly Movie[] movies =
        {
            new Movie("Terminator") {Review = 6, ReleaseDate = new DateTime(1984, 10, 26)},
            new Movie("The Matrix") {Review = 8, ReleaseDate = new DateTime(1999, 03, 31)},
            new Movie("Sharknado") {Review = 3, ReleaseDate = new DateTime(2013, 07, 17)},
            new Movie("Blazing Saddles") {Review = 10, ReleaseDate = new DateTime(1974, 02, 7)},
            new Movie("Spaceballs") {Review = 8, ReleaseDate = new DateTime(1987, 06, 24)}
        };


        public class MoviesReleasedInMethod : MovieReporterTest
        {
            private readonly IDictionary<string, DateRange> _eras = new Dictionary<string, DateRange>
            {
                {"70s", new DateRange(new DateTime(1970, 1, 1), new DateTime(1980, 1, 1))},
                {"80s", new DateRange(new DateTime(1980, 1, 1), new DateTime(1990, 1, 1))},
                {"90s", new DateRange(new DateTime(1990, 1, 1), new DateTime(2000, 1, 1))},
            };

            [TestCase("70s", Result = new[] { "Blazing Saddles" })]
            [TestCase("80s", Result = new[] { "Terminator", "Spaceballs" })]
            [TestCase("90s", Result = new[] { "The Matrix" })]
            public IEnumerable<string> When_listing_movies_in_the(string era)
            {
                this.Subject = new MovieReporter(movies, this._eras[era]);

                return this.Subject.MoviesReleased();
            }

        }

    }
}
