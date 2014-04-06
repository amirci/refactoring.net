using NUnit.Framework;
using Refactoring.Example5;

namespace Refactoring.Tests.Example5
{
    class MovieSearcherTest
    {
        public class FindEndsWithAtorMethod
        {
            [Test]
            public void When_searching_movies_that_end_with_ator()
            {
                var searcher = new MovieSearcher();

                var movies = new []
                {
                    new Movie("Terminator"),
                    new Movie("The Matrix"), 
                    new Movie("Sharknator") 
                };

                var actual = searcher.FindEndsWithAtor(movies);

                var expected = new[] {"Terminator", "Sharknator"};

                Assert.That(actual, Is.EquivalentTo(expected));
            }
        }
    }
}
