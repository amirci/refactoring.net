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
            if (!_movieTitle.Contains("Bacon") || _isWellKnown)
            {
                return 10;
            }

            return 1;
        }
    }
}
