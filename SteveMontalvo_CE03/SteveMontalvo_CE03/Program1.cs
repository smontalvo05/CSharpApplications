using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveMontalvo_CE03
{
    class Program
    {
        static void Main(string[] args)
        {
            bool programIsRunning = true;
            Person currentPerson=null;
            Course currentCourse = null;
            Teacher currentTeacher = null;
            Student currentStudent= null;
            while (programIsRunning)
            {
                Console.Clear();
            //Menu 
            Console.WriteLine("Please chooose one of the following options in the menu to proceed: ");
            Console.WriteLine("1. Create Course");
            Console.WriteLine("2. Create Teacher");
            Console.WriteLine("3. Add Students");
            Console.WriteLine("4. Display");
            Console.WriteLine("5. Exit");

            //menu options
            string menuOption = null;
            bool usersValidatedResponse = true;
            
            Console.WriteLine("Please enter a Menu Option: ");
                while (usersValidatedResponse)
                {

                    menuOption = Console.ReadLine().ToLower();
                    menuOption = ValidateUsersInput.IsNullOrWhiteSpace(menuOption);

                    switch (menuOption)
                    {
                        case "1":
                        case "1.":
                        case "create course":
                            {
                                currentCourse = CreateCourse();
                                
                                usersValidatedResponse = false;

                            }
                            break;
                        case "2":
                        case "2.":
                        case "create teacher":
                            {
                                currentPerson = AddPerson();
                                currentTeacher = CreateTeacher(currentPerson,currentCourse);
                                usersValidatedResponse = false;

                            }
                            break;
                        case "3":
                        case "3.":
                        case "add students":
                            {
                                currentPerson = AddPerson();
                                currentStudent = AddStudent(currentPerson,currentCourse);

                                usersValidatedResponse = false;


                            }
                            break;
                        case "4":
                        case "4.":
                        case "display":
                            {
                                Console.WriteLine($"You currently are taking {currentCourse.CourseTitle} and its about {currentCourse.CourseDescription}.");
                                Console.WriteLine($"Your Name is {currentStudent.Name} and your are a {currentStudent.PersonDescription} and are {currentStudent.Age} old and you current have a score of {currentStudent.Grade}");
                                Console.WriteLine($"Your {currentTeacher.PersonDescription} is {currentTeacher.Name} and your teacher is {currentTeacher.Age} and he teaches {currentTeacher.Knowledge[0]}");
                                Utility.PauseBeforeContinuing();
                                usersValidatedResponse = false;
                            }
                            break;
                        case "5":
                        case "5.":
                        case "exit":
                        case "e":
                            {
                                usersValidatedResponse = false;
                                programIsRunning = false;
                            }
                            break;
                        default:
                            {
                                Console.WriteLine("Please Enter a correct Menu Option: ");
                            }
                            break;
                    }
                }

            }
         

        }
        static Course CreateCourse()
        {
            Console.Clear();
            Course createCourse;
            

            Console.WriteLine("What is the name of the course you are taking: ");
            string courseTitle = Console.ReadLine();
            ValidateUsersInput.IsNullOrWhiteSpace(courseTitle);

            Console.WriteLine("What is the course about?: ");
            string courseDescription = Console.ReadLine();
            ValidateUsersInput.IsNullOrWhiteSpace(courseDescription);

           int sizeOfClass = ValidateUsersInput.SizeOfClass();
            
            createCourse = new Course(courseTitle, courseDescription, sizeOfClass);

            return createCourse;

        }
       

        static Person AddPerson()
        {
            Console.Clear();

            Person newPerson = null;
            bool validateUserResponse = true;
           
            Console.WriteLine("Please type your name: ");
            string name = Console.ReadLine();
            ValidateUsersInput.IsNullOrWhiteSpace(name);

            Console.WriteLine("Are you a Student or a Teacher: ");
            string personDescription = Console.ReadLine().ToLower();
            ValidateUsersInput.IsNullOrWhiteSpace(personDescription);

            while (validateUserResponse)
            {

                switch (personDescription)
                {

                    case "student":
                        {
                            validateUserResponse = false;

                        }
                        break;

                    case "teacher":
                        {
                            validateUserResponse = false;
                        }
                        break;

                }
               
            }

            int age = ValidateUsersInput.Age();

            newPerson = new Person (name, personDescription, age);

            return newPerson;

        }

        static Teacher CreateTeacher(Person AddPerson, Course Course)
        {
            Console.Clear();

            Teacher AddTeacher = null;
            Course course = (Course);
            
            Person currentPerson = AddPerson;
            string[] subjectsSpecialization;
            subjectsSpecialization = new string[1];

            Console.WriteLine("Please type of course or courses do you teach: ");
            subjectsSpecialization [0] = Console.ReadLine();

            AddTeacher = new Teacher(currentPerson.Name, currentPerson.PersonDescription,currentPerson.Age, subjectsSpecialization);

            course.Teach = AddTeacher;

            return AddTeacher;

        }

        static Student AddStudent(Person AddPerson, Course Course)
        {
            Console.Clear();

            Student AddStudent = null;
            Person currentPerson = AddPerson;
            Course course = Course;
           
           
            int grade = ValidateUsersInput.Grade();

            AddStudent = new Student(currentPerson.Name, currentPerson.PersonDescription, currentPerson.Age, grade);
            
            return AddStudent;

        }
    }
}

