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
            var result = 1;

            if (_isWellKnown)
            {
                result = LocalScore();
                if (_isKnownAbroad)
                {
                    result += InternationalScore();
                }
            }
            return result;
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
