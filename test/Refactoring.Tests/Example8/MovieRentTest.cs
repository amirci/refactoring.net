using System;
using FluentAssertions;
using NUnit.Framework;
using Refactoring.Example5;
using Refactoring.Example8;

namespace Refactoring.Tests.Example8
{
    class MovieRentTest
    {
        protected DateTime _start;
        protected Movie _movie;

        protected MovieRent Subject { get; set; }

        public class UserNameMethod : MovieRentTest
        {
            [Test]
            public void When_the_user_is_unknown()
            {
                this.Subject = new MovieRent(_movie, _start, null);

                this.Subject.UserName().Should().Be("n/a");
            }

            [Test]
            public void When_the_user_is_known()
            {
                this.Subject = new MovieRent(_movie, _start, new User {Name = "Sean Morter"});

                this.Subject.UserName().Should().Be("Sean Morter");
            }
        }

        public class UserPhoneNumberMethod : MovieRentTest
        {
            [Test]
            public void When_xxxxx()
            {
                // pending test please complete
            }
        }
    }
}
