using System;

namespace Lists.Entity
{
    public class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{LastName} {FirstName}";
        }
    }
}
