using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhertianceDemo
{
    class Faculty : Person
    {
        private string rank;

        public string Rank
        {
            get { return rank; }
            set { rank = value; }
        }

        private string degree;

        public string Degree
        {
            get { return degree; }
            set { degree = value; }
        }

        public override string ToString()
        {
            return $"ID: {ID}\nName: {FirstName} {MiddleName} {LastName}\nBirth Date: {DateOfBirth}\nRank: {Rank}\nDegree: {Degree}";
        }
    }
}
