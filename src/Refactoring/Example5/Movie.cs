using System.Collections;

namespace Refactoring.Example5
{
    public class Movie
    {
        public Movie(string title)
        {
            this.Title = title;
        }

        public string Title { get; private set; }
        public int Review { get; set; }
    }
}
