
using System;

namespace Unit24 {
	class Program {
		static Course[] courses = new Course[0];
		static void Main( string[] args ) {
			Console.WriteLine( "/nProgram Starts Here/n" );
			GetData();
			DisplayData();
			Console.WriteLine( "\nAll Done -- Buh-bye!" );
			Environment.Exit( 0 );
		}

		private static void GetData() {
			int recNumber = 0;
			string courseName;
			string courseNumber;
			string instructor;
			int numStudents;

			while (true) {
				recNumber++;
				Console.WriteLine($"Enter the data for record: {recNumber}" );
				Console.WriteLine( "Enter 'Done' for the course name to display the data collected\n" );
				Console.Write( "Enter the course name:        " );
				courseName = Console.ReadLine();
				if ( courseName.ToUpper() == "DONE" ) break;
				Console.Write( "Enter the course number:      " );
				courseNumber = Console.ReadLine();
				Console.Write( "Enter instructor name:        " );
				instructor = Console.ReadLine();
				Console.Write( "Enter the number of students: " );
				if ( ! (int.TryParse(Console.ReadLine(), out numStudents ))) {
					Console.WriteLine( "*** Invalid entry -- replaced with 0 ***/n/n" );
					numStudents = 0;
				}
				//Course aCourse = new Course();
				//aCourse.CourseName = courseName;
				//aCourse.CourseNumber = courseNumber;
				//aCourse.Instructor = instructor;
				//aCourse.NumStudents = numStudents;

				Course aCourse = new Course(courseName, courseNumber,
					instructor, numStudents);

				Array.Resize( ref courses, courses.Length + 1 );
				courses[courses.Length - 1] = aCourse;

				Console.WriteLine( "Data saved... \n" );
				
			}
		}
		private static void DisplayData() {
			int totalStudents = 0; ;

			for (int index = 0; index < courses.Length; index++ ) {
				Utility.DisplayText($"Record {index}: {courses[index]}", ConsoleColor.Cyan);
				courses[index].Display();
				totalStudents = courses[index].TotalStudents;
				//courses[index].DisplayTime("hi");
				Utility.DisplayText($"Total Number of Students: {totalStudents}", ConsoleColor.Blue);
				//totalStudents += courses[index].NumStudents;
			}
			Utility.DisplayText($"Total Number of Students: {totalStudents}", ConsoleColor.Blue);

		}

	}
}
