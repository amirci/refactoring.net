using FluentAssertions;
using NUnit.Framework;
using Refactoring.Example5;
using Refactoring.Example6;

namespace Refactoring.Tests.Example6
{
    class MovieCriticTest
    {
        protected MovieCritic Critic { get; private set; }

        protected readonly Movie[] movies =
        {
            new Movie("Terminator") {Review = 6},
            new Movie("The Matrix") {Review = 8},
            new Movie("Sharknator") {Review = 3},
            new Movie("Blazing Saddles") {Review = 10},
            new Movie("Spaceballs") {Review = 8}
        };

        [SetUp]
        public void BeforeEach()
        {
            this.Critic = new MovieCritic {Threshold = 7};
        }

        public class TopMoviesMethod : MovieCriticTest
        {
            [Test]
            public void When_getting_the_top_five_movies()
            {
                var actual = this.Critic.Top3(this.movies);

                actual.Should().BeEquivalentTo(movies[3], movies[4], movies[1]);
            }
        }

        public class ClassifyMethod : MovieCriticTest
        {
            [Test]
            public void When_classifying_movies()
            {
                var actual = this.Critic.Classify(movies);

                actual.Keys.Should().BeEquivalentTo(new[] {3, 8, 6, 10});
                actual[6].Should().BeEquivalentTo(movies[0]);
                actual[8].Should().BeEquivalentTo(movies[1], movies[4]);
                actual[3].Should().BeEquivalentTo(movies[2]);
                actual[10].Should().BeEquivalentTo(movies[3]);
            }
        }

        public class AnyGoodMoviesMethod: MovieCriticTest
        {
            [Test]
            public void When_there_are_good_movies()
            {
                var actual = Critic.AnyGoodOnes(movies);

                Assert.That(actual, Is.True);
            }

            [Test]
            public void When_all_movies_suck()
            {
                this.Critic.Threshold = 11;

                var actual = this.Critic.AnyGoodOnes(movies);

                Assert.That(actual, Is.False);   
            }
        }
    }
}
