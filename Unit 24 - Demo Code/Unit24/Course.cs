
using System;
using System.Collections.Generic;
using System.Text;

namespace Unit24 {
	class Course {
        private string courseName;
        public string CourseName {
            get { return courseName; }
            set { courseName = value; }
		}
        private string courseNumber;
        public string CourseNumber {
            get { return courseNumber;  }
            set { courseNumber = value; }
		}
        private string instructor;
        public string Instructor {
            get { return instructor;  }
            set { instructor = value;  }
		}
        private int numStudents;
        public int NumStudents {
            get { return numStudents; }
            set {
                numStudents = value;
                totalOfStudents += value;
            }
        }

        private static int totalOfStudents = 0;
        public int TotalStudents
        {
            get
            {
                return totalOfStudents;
            }
        }

        public Course()
        {
            CourseName = "N/A";
            CourseNumber = "N/A";
            Instructor = "N/A";
            NumStudents = 0;
        }

        public void CourseNameTest()
        {

        }

        public int Whatever()
        {
            return 0;
        }

        public Course(int something)
        {

        }

        public Course(string courseName, 
            string courseNumber, 
            string instructor, int numStudents)
        {
            CourseName = courseName;
            CourseNumber = courseNumber;
            Instructor = instructor;
            NumStudents = numStudents;
        }

        public override string ToString()
        {
            return $"{CourseName} / {CourseNumber}\n" +
            $"            Instructor:    {Instructor}\n" +
            $"            Student Count: {NumStudents}\n";
        }

        public void Display()
        {
            Utility.DisplayText(ToString(), ConsoleColor.Red);
            DisplayTime("hi");
        }

        private void DisplayTime(string message)
        {
            Utility.DisplayText(message, ConsoleColor.Yellow);
        }
    }
}
