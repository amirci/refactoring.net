namespace Refactoring.Example3
{
    public class BaconCriticScore
    {
        private readonly string _movieTitle;
        private readonly bool _isWellKnown;

        public BaconCriticScore(string movieTitle, bool isWellKnown=false)
        {
            _movieTitle = movieTitle;
            _isWellKnown = isWellKnown;
        }

        public int FinalScore()
        {
            var result = 1;

            if (_movieTitle.Contains("Bacon"))
            {
                if (_isWellKnown)
                    result = 10;
            }
            else
                result = 10;

            return result;
        }
    }
}
