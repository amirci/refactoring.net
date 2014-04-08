using System;
using Refactoring.Example5;

namespace Refactoring.Example8
{
    public class MovieRent
    {
        private readonly Movie _movie;
        private readonly DateTime _start;
        private readonly User _user;

        public MovieRent(Movie movie, DateTime start, User user)
        {
            _movie = movie;
            _start = start;
            _user = user;
        }

        public string UserName()
        {
            if (_user != null)
            {
                return _user.Name;
            }
            else
            {
                return "n/a";
            }
        }

        public string UserPhoneNumber()
        {
            if (_user != null)
            {
                return _user.PhoneNumber;
            }
            else
            {
                return "n/a";
            }
        }
    }
}
