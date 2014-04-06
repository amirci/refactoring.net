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
            if (_isKnownLocally && _isKnownAbroad && _isNotWoodyAllen)
            {
                return LocalScore() + AbroadScore();
            }

            return 1;
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
