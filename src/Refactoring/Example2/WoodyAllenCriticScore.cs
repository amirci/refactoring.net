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
            var result = 1;

            if (_isKnownLocally)
            {
                if (_isKnownAbroad)
                {
                    if (_isNotWoodyAllen)
                    {
                        result = LocalScore() + AbroadScore();
                    }
                }
            }
            return result;
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
