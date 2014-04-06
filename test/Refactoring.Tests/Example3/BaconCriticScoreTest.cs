using NUnit.Framework;
using Refactoring.Example3;

namespace Refactoring.Tests.Example3
{
    public class BaconCriticScoreTest
    {
        public class CalculateFinalScoreMethod
        {
            public const int HighScore = 10;
            public const int LowScore = 1;
            
            [TestFixture]
            public class When_the_movie_has_bacon: CalculateFinalScoreMethod
            {
                public class And_is_not_well_known : CalculateFinalScoreMethod
                {
                    [Test]
                    public void Then_the_score_is_low()
                    {
                        var calculator = new BaconCriticScore("Canadian Bacon");

                        Assert.That(calculator.FinalScore(), Is.EqualTo(LowScore));
                    }
                }

                public class And_is_well_known : CalculateFinalScoreMethod
                {
                    [Test]
                    public void Then_the_score_is_high()
                    {
                        var calculator = new BaconCriticScore("Canadian Bacon", true);

                        Assert.That(calculator.FinalScore(), Is.EqualTo(HighScore));
                    }
                }
            }

            [TestFixture]
            public class When_the_movie_has_no_bacon
            {
                public class And_is_well_known : CalculateFinalScoreMethod
                {
                    [Test]
                    public void Then_the_score_is_high()
                    {
                        var calculator = new BaconCriticScore("The Matrix", true);

                        Assert.That(calculator.FinalScore(), Is.EqualTo(HighScore));
                    }
                }

                public class And_is_not_well_known : CalculateFinalScoreMethod
                {
                    [Test]
                    public void Then_the_score_is_high()
                    {
                        var calculator = new BaconCriticScore("The Matrix");

                        Assert.That(calculator.FinalScore(), Is.EqualTo(HighScore));
                    }
                }
            }

        }
    }
}
