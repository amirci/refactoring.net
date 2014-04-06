using NUnit.Framework;
using Refactoring.Example1;

namespace Refactoring.Tests.Example1
{
    public class MovieCriticScoreTest
    {
        public class CalculateFinalScoreMethod
        {
            protected int _score;

            public class When_the_movie_is_known_locally : CalculateFinalScoreMethod
            {
                [Test]
                public void Then_the_score_is_medium()
                {
                    var calculator = new MovieCriticScore(true);

                    this._score = calculator.FinalScore();

                    Assert.That(_score, Is.EqualTo(10));
                }
            }

            public class When_the_movie_is_known_abroad : CalculateFinalScoreMethod
            {
                [Test]
                public void Then_the_score_is_high()
                {
                    var calculator = new MovieCriticScore(true, true);

                    this._score = calculator.FinalScore();

                    Assert.That(_score, Is.EqualTo(20));
                }
            }

            public class When_the_movie_is_not_known_at_all : CalculateFinalScoreMethod
            {
                [Test]
                public void Then_the_score_is_low()
                {
                    var calculator = new MovieCriticScore();

                    this._score = calculator.FinalScore();

                    Assert.That(_score, Is.EqualTo(1));
                }
            }
        }
    }
}
