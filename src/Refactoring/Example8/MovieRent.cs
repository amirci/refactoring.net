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
            _user = user ?? new NullUser();
        }

        public string UserName()
        {
            return _user.Name;
        }

        public string UserPhoneNumber()
        {
            return _user.PhoneNumber;
        }
    }
}
