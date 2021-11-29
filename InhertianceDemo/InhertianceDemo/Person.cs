using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhertianceDemo
{
    class Person
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private string middleName;

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        private DateTime date;

        public DateTime DateOfBirth
        {
            get { return date; }
            set { date = value; }
        }

        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }


        public override string ToString()
        {
            return $"ID: {ID}\nName: {FirstName} {MiddleName} {LastName}\nBirth Date: {DateOfBirth}";
        }

    }
}
