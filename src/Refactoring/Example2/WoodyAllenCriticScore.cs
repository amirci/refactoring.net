namespace Refactoring.Example2
{
    public class WoodyAllenCriticScore
    {
        private readonly bool _isKnownLocally;
        private readonly bool _isKnownAbroad;
        private readonly bool _isNotWoodyAllen;

        public WoodyAllenCriticScore(bool isKnownLocally=false, bool isKnownAbroad=false, bool isNotWoodyAllen=false)
        {
            _isKnownLocally = isKnownLocally;
            _isKnownAbroad = isKnownAbroad;
            _isNotWoodyAllen = isNotWoodyAllen;
        }

        public int FinalScore()
        {
            if (WellKnowButNotWoody())
            {
                return LocalScore() + AbroadScore();
            }

            return 1;
        }

        private bool WellKnowButNotWoody()
        {
            return _isKnownLocally && _isKnownAbroad && _isNotWoodyAllen;
        }

        private static int LocalScore()
        {
            return 10;
        }

        private static int AbroadScore()
        {
            return 10;
        }
    }
}
