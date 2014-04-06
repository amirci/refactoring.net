namespace Refactoring.Example1
{
    public class MovieCriticScore
    {
        private readonly bool _isWellKnown;
        private readonly bool _isKnownAbroad;

        public MovieCriticScore(bool isWellKnown=false, bool isKnownAbroad=false)
        {
            _isWellKnown = isWellKnown;
            _isKnownAbroad = isKnownAbroad;
        }

        public int FinalScore()
        {
            if (!_isWellKnown) return 1;

            var result = LocalScore();

            if (!_isKnownAbroad) return result;

            return result + InternationalScore();
        }

        private static int InternationalScore()
        {
            return 10;
        }

        private static int LocalScore()
        {
            return 10;
        }
    }
}
