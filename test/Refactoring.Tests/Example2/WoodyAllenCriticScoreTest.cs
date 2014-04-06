using NUnit.Framework;
using Refactoring.Example2;

namespace Refactoring.Tests.Example2
{
    public class WoodyAllenCriticScoreTest
    {
        public class CalculateFinalScoreMethod
        {
            protected void AssertLowScore(WoodyAllenCriticScore calculator)
            {
                Assert.That(calculator.FinalScore(), Is.EqualTo(1));
            }

            public class When_the_movie_is_known_and_not_from_woody : CalculateFinalScoreMethod
            {
                [Test]
                public void Then_the_score_is_high()
                {
                    var calculator = new WoodyAllenCriticScore(true, true, true);

                    Assert.That(calculator.FinalScore(), Is.EqualTo(20));
                }
            }

            public class When_the_movie_is_only_known_abroad : CalculateFinalScoreMethod
            {
                [Test]
                public void Then_the_score_is_low()
                {
                    AssertLowScore(new WoodyAllenCriticScore(true, true));
                }
            }

            public class When_the_movie_is_only_known_locally : CalculateFinalScoreMethod
            {
                [Test]
                public void Then_the_score_is_low()
                {
                    AssertLowScore(new WoodyAllenCriticScore(true));
                }

            }

            public class When_the_movie_is_not_known_at_all : CalculateFinalScoreMethod
            {
                [Test]
                public void Then_the_score_is_low()
                {
                    AssertLowScore(new WoodyAllenCriticScore());
                }
            }
        }
    }
}
