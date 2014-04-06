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
            new Movie("Sharknator") {Review = 3}
        };

        [SetUp]
        public void BeforeEach()
        {
            this.Critic = new MovieCritic {Threshold = 7};
        }
        
        public class ClassifyMethod : MovieCriticTest
        {
            [Test]
            public void When_classifying_movies()
            {
                var actual = this.Critic.Classify(movies);

                actual.Keys.Should().BeEquivalentTo(new[] {3, 8, 6});
                actual[6].Should().BeEquivalentTo(movies[0]);
                actual[8].Should().BeEquivalentTo(movies[1]);
                actual[3].Should().BeEquivalentTo(movies[2]);
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
                this.Critic.Threshold = 9;

                var actual = this.Critic.AnyGoodOnes(movies);

                Assert.That(actual, Is.False);   
            }
        }
    }
}
