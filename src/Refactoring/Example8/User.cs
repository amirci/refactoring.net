namespace Refactoring.Example8
{
    public class User
    {
        public virtual string Name { get; set; }
        public virtual string PhoneNumber { get; set; }
    }

    public class NullUser : User
    {
        public override string Name
        {
            get { return "n/a"; }
        }

        public override string PhoneNumber
        {
            get { return "n/a";  }
        }
    }
}