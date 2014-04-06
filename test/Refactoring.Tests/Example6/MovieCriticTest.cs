using NUnit.Framework;
using Refactoring.Example5;
using Refactoring.Example6;

namespace Refactoring.Tests.Example6
{
    class MovieCriticTest
    {
        public class AnyGoodMoviesMethod: MovieCriticTest
        {
            private readonly Movie[] movies =
            {
                new Movie("Terminator") {Review = 6},
                new Movie("The Matrix") {Review = 8},
                new Movie("Sharknator") {Review = 3}
            };

            [Test]
            public void When_there_are_good_movies()
            {
                var critic = new MovieCritic(7);

                var actual = critic.AnyGoodOnes(movies);

                Assert.That(actual, Is.True);
            }

            [Test]
            public void When_all_movies_suck()
            {
                var fancyCritic = new MovieCritic(9);

                var actual = fancyCritic.AnyGoodOnes(movies);

                Assert.That(actual, Is.False);   
            }
        }
    }
}
