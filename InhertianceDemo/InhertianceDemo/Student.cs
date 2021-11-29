using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhertianceDemo
{
    class Student : Person
    {
        private string programCode;

        public string ProgramCode
        {
            get { return programCode; }
            set { programCode = value; }
        }

        private int programYear;

        public int ProgramYear
        {
            get { return programYear; }
            set { programYear = value; }
        }

        private int credits;

        public int Credits
        {
            get { return credits; }
            set { credits = value; }
        }


        public override string ToString() 
        {
            return $"ID: {ID}\nName: {FirstName} {MiddleName} {LastName}\nBirth Date: {DateOfBirth}\nProgram Code: {ProgramCode}\nProgram Year: {ProgramYear}\nCredits: {Credits}";
        }

    }
}
