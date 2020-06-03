using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontalvoSteve_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the Classes
            Student studentss = new Student();
            Courses courses = new Courses();
            //Variable to hodl the letter grade
            string letterGrade = null;
            //variable to hold the GPA array
            double[] gradeGpaHolder = new double[5];
            //variable to hold the calculated GPA
            double gpaCalculated;
            //bool to keep the program running
            bool ProgramisRunning = true;

            //Loop to keep the program running
            while (ProgramisRunning)
            {
                //Clear the console from any previous messages
                Console.Clear();
                //Menu
                Console.WriteLine("-------Menu--------\n");
                Console.WriteLine("1. Review Students");
                Console.WriteLine("2. Review GPA");
                Console.WriteLine("3. Edit Student");
                Console.WriteLine("4. Exit\n");
                Console.Write("Selection: ");
                //To collect the users input
                string userInput = Console.ReadLine();
                //validate that its not null or whitespace
                userInput = UserValidation.IsNullOrWhiteSpace(userInput.ToLower());

                //Switch statment to select the user input
                switch (userInput)
                {
                    case "1":
                    case "1.":
                    case "review students":
                        {
                            //Clear the console from previous messages
                            Console.Clear();
                            //Header
                            Console.WriteLine("--------Students--------\n");
                            //Method to call list of students
                            ListOfStudents();
                            //Ask the user which student he/she wants to see
                            Console.WriteLine("\nWhich student would you like to see?");
                            Console.Write("Selection: ");
                            //Variable to hold the response
                            string studentSelection = Console.ReadLine();
                            //Validate the response from the user
                            studentSelection = UserValidation.IsNullOrWhiteSpace(studentSelection.ToLower());
                            //Switch statment to search which user they want
                            switch (studentSelection)
                            {
                                case "steve montalvo":
                                    {
                                        //loop to go throug the arrays in the Classes
                                        for (int j = 0; j < courses.CourseNames.Length;)
                                        {
                                            letterGrade = GradeScale(studentss.SteveGrades[j]);
                                            //print the result to the console
                                            Console.WriteLine($"Course Name: {courses.CourseNames[j]}");
                                            Console.WriteLine($"Grade: {studentss.SteveGrades[j]} {letterGrade}");

                                            j++;
                                        }
                                    }
                                    break;
                                case "whitney core":
                                    {
                                        //loop to go throug the arrays in the Classes
                                        for (int j = 0; j < courses.CourseNames.Length;)
                                        {
                                            letterGrade = GradeScale(studentss.WhitneyGrades[j]);
                                            //print the result to the console
                                            Console.WriteLine($"Course Name: {courses.CourseNames[j]}");
                                            Console.WriteLine($"Grade: {studentss.WhitneyGrades[j]} {letterGrade}");
                                            j++;
                                        }
                                    }
                                    break;
                                case "idalys montalvo":
                                    {
                                        //loop to go throug the arrays in the Classes
                                        for (int j = 0; j < courses.CourseNames.Length;)
                                        {
                                            letterGrade = GradeScale(studentss.IdalysGrades[j]);
                                            //print the result to the console
                                            Console.WriteLine($"Course Name: {courses.CourseNames[j]}");
                                            Console.WriteLine($"Grade: {studentss.IdalysGrades[j]} {letterGrade}");
                                            j++;
                                        }
                                    }
                                    break;
                                case "michael griffin":
                                    {
                                        //loop to go throug the arrays in the Classes
                                        for (int j = 0; j < courses.CourseNames.Length;)
                                        {
                                            letterGrade = GradeScale(studentss.MichaelGrades[j]);
                                            //print the result to the console
                                            Console.WriteLine($"Course Name: {courses.CourseNames[j]}");
                                            Console.WriteLine($"Grade: {studentss.MichaelGrades[j]} {letterGrade}");
                                            j++;
                                        }
                                    }
                                    break;
                                case "allie core":
                                    {
                                        //loop to go throug the arrays in the Classes
                                        for (int j = 0; j < courses.CourseNames.Length;)
                                        {
                                            letterGrade = GradeScale(studentss.AllieGrades[j]);
                                            //print the result to the console
                                            Console.WriteLine($"Course Name: {courses.CourseNames[j]}");
                                            Console.WriteLine($"Grade: {studentss.AllieGrades[j]} {letterGrade}");
                                            j++;
                                        }
                                    }
                                    break;
                                default:
                                    {
                                        //print the result to the console
                                        Console.WriteLine("You did not choose a valid response.");
                                    }
                                    break;
                            }

                        }

                        break;
                    case "2":
                    case "2.":
                    case "review gpa":
                        {
                            //Clear the console 
                            Console.Clear();
                            //Menu bar
                            Console.WriteLine("--------Review GPA--------\n");
                            //Method to show the list of students
                            ListOfStudents();
                            //ask the user which student they want
                            Console.WriteLine("\nWhich student would you like to see thier GPA?");
                            Console.Write("Selection: ");
                            //hold the result from the user
                            string studentSelection = Console.ReadLine();
                            studentSelection = UserValidation.IsNullOrWhiteSpace(studentSelection.ToLower());
                            //switch statement to search through the students
                            switch (studentSelection)
                            {
                                case "steve montalvo":
                                    {
                                        //loop to place the gpa calculations in the array
                                        for (int j = 0; j < courses.CourseNames.Length;)
                                        {
                                            gradeGpaHolder[j] = GpaCalculation(studentss.SteveGrades[j]);
                                            j++;
                                        }
                                    }
                                    break;
                                case "whitney core":
                                    {
                                        //loop to place the gpa calculations in the array
                                        for (int j = 0; j < courses.CourseNames.Length;)
                                        {
                                            gradeGpaHolder[j] = GpaCalculation(studentss.WhitneyGrades[j]);
                                            j++;
                                        }
                                    }
                                    break;
                                case "idalys montalvo":
                                    {
                                        //loop to place the gpa calculations in the array
                                        for (int j = 0; j < courses.CourseNames.Length;)
                                        {
                                            gradeGpaHolder[j] = GpaCalculation(studentss.IdalysGrades[j]);
                                            j++;
                                        }
                                    }
                                    break;
                                case "michael griffin":
                                    {
                                        //loop to place the gpa calculations in the array
                                        for (int j = 0; j < courses.CourseNames.Length;)
                                        {
                                            gradeGpaHolder[j] = GpaCalculation(studentss.MichaelGrades[j]);
                                            j++;
                                        }
                                    }
                                    break;
                                case "allie core":
                                    {
                                        //loop to place the gpa calculations in the array
                                        for (int j = 0; j < courses.CourseNames.Length;)
                                        {
                                            gradeGpaHolder[j] = GpaCalculation(studentss.AllieGrades[j]);
                                            j++;
                                        }
                                    }
                                    break;
                                default:
                                    {
                                        //Communication about incorrect response
                                        Console.WriteLine("You did not choose a valid response.");
                                    }
                                    break;

                            }
                            //calculate the GPA within the array
                            gpaCalculated = (gradeGpaHolder[0] + gradeGpaHolder[1] + gradeGpaHolder[2] + gradeGpaHolder[3] + gradeGpaHolder[4])/5;
                            //Display the result
                            Console.WriteLine($"\nStudent's GPA: {gpaCalculated}");
                        }
                        break;
                    case "3":
                    case "3.":
                    case "edit student":
                        {
                            //Clear from previous messages
                            Console.Clear();
                            //Menu bar
                            Console.WriteLine("--------Edit Students--------\n");
                            //display the students
                            ListOfStudents();
                            //question to ask the user who they want to see?
                            Console.WriteLine("\nWhich student would you like to see?");
                            Console.Write("Selection: ");
                            string studentSelection = Console.ReadLine();
                            studentSelection = UserValidation.IsNullOrWhiteSpace(studentSelection.ToLower());
                            switch (studentSelection)
                            {
                                case "steve montalvo":
                                    {
                                        for (int j = 0; j < courses.CourseNames.Length;)
                                        {
                                            letterGrade = GradeScale(studentss.SteveGrades[j]);
                                            //print the result to the console
                                            Console.WriteLine($"Course Name: {courses.CourseNames[j]}");
                                            Console.WriteLine($"Grade: {studentss.SteveGrades[j]} {letterGrade}");

                                            j++;
                                        }
                                        Console.WriteLine("Which grade would you like to change?");
                                        Console.WriteLine("Selection: ");
                                        string gradeChange = Console.ReadLine();
                                        double gradeNumberChange = Convert.ToDouble(gradeChange);
                                    }
                                    break;
                                case "whitney core":
                                    {
                                        for (int j = 0; j < courses.CourseNames.Length;)
                                        {
                                            letterGrade = GradeScale(studentss.WhitneyGrades[j]);
                                            Console.WriteLine($"Course Name: {courses.CourseNames[j]}");
                                            Console.WriteLine($"Grade: {studentss.WhitneyGrades[j]} {letterGrade}");
                                            j++;
                                        }
                                        Console.WriteLine("Which grade would you like to change?");
                                        Console.WriteLine("Selection: ");
                                        string gradeChange = Console.ReadLine();
                                        double gradeNumberChange = Convert.ToDouble(gradeChange);
                                    }
                                    break;
                                case "idalys montalvo":
                                    {
                                        for (int j = 0; j < courses.CourseNames.Length;)
                                        {
                                            letterGrade = GradeScale(studentss.IdalysGrades[j]);
                                            Console.WriteLine($"Course Name: {courses.CourseNames[j]}");
                                            Console.WriteLine($"Grade: {studentss.IdalysGrades[j]} {letterGrade}");
                                            j++;
                                        }
                                        Console.WriteLine("Which grade would you like to change?");
                                        Console.WriteLine("Selection: ");
                                        string gradeChange = Console.ReadLine();
                                        double gradeNumberChange = Convert.ToDouble(gradeChange);

                                    }
                                    break;
                                case "michael griffin":
                                    {
                                        for (int j = 0; j < courses.CourseNames.Length;)
                                        {
                                            letterGrade = GradeScale(studentss.MichaelGrades[j]);
                                            Console.WriteLine($"Course Name: {courses.CourseNames[j]}");
                                            Console.WriteLine($"Grade: {studentss.MichaelGrades[j]} {letterGrade}");
                                            j++;
                                        }
                                        Console.WriteLine("Which grade would you like to change?");
                                        Console.WriteLine("Selection: ");
                                        string gradeChange = Console.ReadLine();
                                        double gradeNumberChange = Convert.ToDouble(gradeChange);
                                    }
                                    break;
                                case "allie core":
                                    {
                                        for (int j = 0; j < courses.CourseNames.Length;)
                                        {
                                            letterGrade = GradeScale(studentss.AllieGrades[j]);
                                            Console.WriteLine($"Course Name: {courses.CourseNames[j]}");
                                            Console.WriteLine($"Grade: {studentss.AllieGrades[j]} {letterGrade}");
                                            j++;
                                        }
                                        Console.WriteLine("Which grade would you like to change?");
                                        Console.WriteLine("Selection: ");
                                        string gradeChange = Console.ReadLine();
                                        double gradeNumberChange = Convert.ToDouble(gradeChange);
                                    }
                                    break;
                                default:
                                    {

                                        Console.WriteLine("You did not choose a valid response.");
                                    }
                                    break;
                            }
                        }
                        break;
                    case "4":
                    case "4.":
                    case "exit":
                        {
                            Console.Clear();
                            Console.WriteLine("--------Exit--------\n");
                            //Statment to reasurre that the user wants to exit
                            Console.WriteLine("Are you sure you want to exit?");
                            //to collect user input
                            string input = Console.ReadLine();
                            //user input to check its not null or whitespace
                            input = UserValidation.IsNullOrWhiteSpace(input.ToLower());
                            //switch statement to check that the user wants to exit
                            switch (input)
                            {
                                case "y":
                                case "yes":
                                    {
                                        Console.WriteLine("You have selected to exit the program.");
                                        //bool to close the program.
                                        ProgramisRunning = false;
                                    }
                                    break;
                                case "n":
                                case "no":
                                    {
                                        //print results
                                        Console.WriteLine("You have chosen to not exit the program.");
                                    }
                                    break;
                                default:
                                    {
                                        Console.WriteLine("You have not selected a correct menu option.");
                                    }
                                    break;
                            }
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("You have not selected a correct menu option.");
                        }
                        break;
                }
                Console.WriteLine();
                //Pause the program and read a key.
                Utility.PauseBeforeContinuing();

            }


        }
        //method to display the correct Letter Grade
        public static string GradeScale(double Grade)
        {
            double grade = Grade;
            string letterGrade = null;

            if (grade <= 100 && grade > 89.5)
            {
                letterGrade = "A";
            }
            if (grade < 89.4 && grade > 79.5)
            {
                letterGrade = "B";
            }
            if (grade < 79.4 && grade > 72.5)
            {
                letterGrade = "C";
            }
            if (grade < 72.4 && grade > 69.5)
            {
                letterGrade = "D";
            }
            if (grade < 69.4 && grade > 0)
            {
                letterGrade = "F";
            }
            return letterGrade;

        }
        //Gpa Calculation
        public static double GpaCalculation(double Grade)
        {
            double grade = Grade;
            string letterGrade =null;
            if (grade <= 100 && grade > 89.5)
            {
                letterGrade = "4.0";
            }
            if (grade < 89.4 && grade > 79.5)
            {
                letterGrade = "3.0";
            }
            if (grade < 79.4 && grade > 72.5)
            {
                letterGrade = "2.0";
            }
            if (grade < 72.4 && grade > 69.5)
            {
                letterGrade = "1.0";
            }
            if (grade < 69.4 && grade > 0)
            {
                letterGrade = "0.0";
            }

            return Convert.ToDouble(letterGrade);
        }
        //method to display the students.
        public static void ListOfStudents()
        {
            Student students = new Student();
            int k;
            int j = 1;
            for (k = 0; k < students.StudentName.Length;)
            {
                Console.WriteLine($"{j}. Student Name: {students.StudentName[k]}");
                k++;
                j++;
            }

        }
   }
}

