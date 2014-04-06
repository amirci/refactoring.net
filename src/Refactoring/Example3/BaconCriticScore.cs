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
            return BaconImpliesWellKnown() ? 10 : 1;
        }

        private bool BaconImpliesWellKnown()
        {
            return !_movieTitle.Contains("Bacon") || _isWellKnown;
        }
    }
}
