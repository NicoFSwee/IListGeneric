using System;
using System.Collections;
using System.Collections.Generic;

namespace Lists.Entity
{
    public class Person : IComparable
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public Person()
        {

        }

        public Person(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }

        public int Age { get; set; }

        public int CompareTo(object obj)
        {
            Person p = (Person)obj;
            return this.LastName.CompareTo(p.LastName);
        }

        public override string ToString()
        {
            return $"{LastName} {FirstName}";
        }

        private class SortierHelferAlter : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                Person p1 = (Person)x;
                Person p2 = (Person)y;
                int result;

                if (p1.Age.CompareTo(p2.Age) > 0)
                {
                    result = 1;
                }
                else if (p1.Age.CompareTo(p2.Age) < 0)
                {
                    result = -1;
                }
                else
                {
                    result = 0;
                }

                return result * -1;
            }
        }

        public static IComparer sortByAge()
        {
            return (IComparer)new SortierHelferAlter();
        }
    }
}
