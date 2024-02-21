using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Linq;

namespace CSE446_Assignment7
{
    //Course class for questions 1.1 and 1.2
    class Course
    {

        public string subject;
        public int code;
        public string title;
        public int courseID;
        public string location;
        public string instructor;
    }

    //Instructor class for questions 1.4 and 1.5
    class Instructor
    {

        public string name;
        public string office;
        public string email;
    }

    class Program
    {
        static void Main(string[] args)
        {

            //File path
            string filepathBase = Environment.CurrentDirectory.Substring(0,
                Environment.CurrentDirectory.LastIndexOf("CSE446_Assignment7") + 19);

            //Course categories
            var Subject = new List<string>(); //Row 0
            var Title = new List<string>(); //Row 1
            var CourseId = new List<int>(); //Row 2

            var Instructor = new List<string>(); //Row 3
            var Days = new List<string>(); //Row 4
            var Start = new List<string>(); //Row 5

            var End = new List<string>(); //Row 6
            var Location = new List<string>(); //Row 7
            var Dates = new List<string>(); //Row 8

            var Units = new List<string>(); //Row 9
            var Enrollment = new List<string>(); //Row 10

            //Parsing the data
            string[] courseCSVLines = System.IO.File.ReadAllLines(filepathBase + @"App_Data\Courses.csv");

            //Splitting
            for (int i = 1; i < courseCSVLines.Length; i++)
            {
                string[] rowData = courseCSVLines[i].Split(',');

                Subject.Add(rowData[0].Trim());
                Title.Add(rowData[1].Trim());


                int courseIDConverter = Convert.ToInt32(rowData[2].Trim());
                CourseId.Add(courseIDConverter);

                Instructor.Add(rowData[3].Trim());
                Days.Add(rowData[4].Trim());
                Start.Add(rowData[5].Trim());

                End.Add(rowData[6].Trim());
                Location.Add(rowData[7].Trim());
                Dates.Add(rowData[8].Trim());

                Units.Add(rowData[9].Trim());
                Enrollment.Add(rowData[10].Trim());
            }

            //Creating the array of courses and filling it
            Course[] coursesArray = new Course[212];

            for (int i = 0; i < coursesArray.Length; i++)
            {
                //Spliting the subject string to subject and code
                string subjectAndCodeString = Subject[i];
                string[] splitString = subjectAndCodeString.Split(" ");

                //Creating the new course;
                coursesArray[i] = new Course
                {
                    subject = splitString[0],
                    code = Convert.ToInt32(splitString[1]),
                    title = Title[i],
                    courseID = CourseId[i],
                    location = Location[i],
                    instructor = Instructor[i]
                };
            }

            //Question 1.2a
            IEnumerable<Course> queryA =
                from c in coursesArray
                where c.code >= 300
                where c.subject == "IEE"
                orderby c.instructor
                select c;

            //Pritning out the IEE courses with a code greater than 300
            Console.WriteLine("(Read From Memory) - IEE Courses with a course code of 300 or more, sorted by instructor:\n\n\nCourse Title - Instructor\n");

            foreach (Course course in queryA)
            {
                Console.WriteLine("{0} - {1}", course.title, course.instructor);
            }



            //Question 1.2b

            //The group and subgroups
            var courseGroups =
                from c in coursesArray
                group c by new
                {
                    c.subject,
                    c.code
                }
                into g1

                select new
                {
                    g1.Key.subject, g1.Key.code,
                    SubGroups = from c in g1
                                group c by new
                                {
                                    c.courseID,
                                    c.title
                                }
                                into g2
                                select g2
                };

            //Printing out the groups
            Console.WriteLine("\n\n\n\n ");

            Console.WriteLine("(Read From Memory) - Classes with more than 2 sections:\n\n\nSubject Code Title\n");

            foreach (var g1 in courseGroups) if (g1.SubGroups.Count() >= 2)
                {
                    foreach (var g2 in g1.SubGroups)
                    {
                        Console.WriteLine(g1.subject + g1.code + " " + g2.Key.title); ;
                    }

                    Console.WriteLine(" ");
                }



            //Question 1.4

            //Instructor Info
            var InstructorName = new List<string>(); //Row 0
            var Office = new List<string>(); //Row 1
            var Email = new List<string>(); //Row 2

            //Parsing the data
            string[] instructorCSVLines = System.IO.File.ReadAllLines(filepathBase + @"App_Data\Instructors.csv");

            //Splitting
            for (int i = 1; i < instructorCSVLines.Length; i++)
            {
                string[] rowData = instructorCSVLines[i].Split(',');

                InstructorName.Add(rowData[0].Trim());
                Office.Add(rowData[1].Trim());
                Email.Add(rowData[2].Trim());
            }

            //Creating the instructor LIST and filling it
            List<Instructor> instructorList = new List<Instructor>();

            for (int i = 0; i < instructorCSVLines.Length - 1; i++)
            {
                //Creating the new course;
                Instructor newInstructor = new Instructor
                {
                    name = InstructorName[i],
                    office = Office[i],
                    email = Email[i],
                };

                instructorList.Add(newInstructor);
            }



            //Question 1.5

            //Initial query from joining instructorList and courseArray
            var queryB = from professor in instructorList
                         join courses in coursesArray on
                         professor.name equals courses.instructor
                         select new
                         {
                             CourseSubject = courses.subject,
                             CourseCode = courses.code,
                             InstructorEmail = professor.email
                         };

            //Ordering the query
            var orderedQueryB = from prof in queryB
                                orderby prof.CourseCode
                                select prof;


            //Printing
            Console.WriteLine("\n\n\n");

            Console.WriteLine("(Read From Memory) - 200 Level Courses with Instructor Email:\n\n\nSubject Code - Email\n");

            foreach (var courseAndProfessorEmail in orderedQueryB) if (courseAndProfessorEmail.CourseCode >= 200 && courseAndProfessorEmail.CourseCode < 300)
                {
                    Console.WriteLine("{0} {1} - {2}", courseAndProfessorEmail.CourseSubject, courseAndProfessorEmail.CourseCode, courseAndProfessorEmail.InstructorEmail);
                }




            //Question 2.1a

            //Creating the XElement
            XElement coursesXElement = new XElement("Courses",
                (from c in coursesArray
                 select new XElement
                 (
                 "Course",
                 new XElement("Subject", c.subject),
                 new XElement("Code", c.code),
                 new XElement("Title", c.title),
                 new XElement("CourseID", c.courseID),
                 new XElement("Location", c.location),
                 new XElement("Instructor", c.instructor)
                 )
                 )
                 );

            //Creating the query
            IEnumerable<XElement> queryC =
                from c in coursesXElement.Descendants("Course")
                where (int)c.Element("Code") >= 200
                where (string)c.Element("Subject") == "CPI"
                orderby (string)c.Element("Instructor")
                select c;



            //Pritning out the CPI courses with a code greater than 200
            Console.WriteLine("\n\n\n");
            Console.WriteLine("(Read From XML) - CPI Courses with a course code of 200 or more, sorted by instructor:\n\n\nCourse Title - Instructor\n");

            foreach (XElement course in queryC)
            {
                //Console.WriteLine(course.Element("Title"));
                //Console.WriteLine(course.Element("Instructor") + "\n");

                Console.WriteLine((string)course.Element("Title") + " - " + (string)course.Element("Instructor"));
            }

            //Question 2.1b

            //The group and subgroups
            var courseXElementGroups =
                from c in coursesXElement.Descendants("Course")
                group c by new
                {
                    Subject = (string)c.Element("Subject"),
                    Code = (string)c.Element("Code")
                } into g1

                select new
                {
                    g1.Key.Subject, g1.Key.Code,
                    SubGroups = from c in g1
                                group c by new
                                {
                                    CourseID = (string)c.Element("CourseID"),
                                    Title = (string)c.Element("Title")
                                }
                                into g2
                                select g2
                };



            //Printing out the groups
            Console.WriteLine("\n\n\n\n ");

            Console.WriteLine("(Read From XML) - Classes with more than 2 sections:\n\n\nSubject Code Title\n");

            foreach (var g1 in courseXElementGroups) if (g1.SubGroups.Count() >= 2)
                {
                    foreach (var g2 in g1.SubGroups)
                    {
                        Console.WriteLine(g1.Subject + "" + g1.Code + " " + g2.Key.Title);
                    }

                    Console.WriteLine(" ");
                }

            //Question 2.2

            //Initial query from joining instructorList and courseArray
            IEnumerable<XElement> queryD = from professor in instructorList
                         join courses in coursesArray on
                         professor.name equals courses.instructor
                         select new XElement
                         (
                             "Course",
                             new XElement("Subject", courses.subject),
                             new XElement("Code", courses.code),
                             new XElement("Email", professor.email)
                         );

            //Ordering the query
            var orderedQueryD = from prof in queryD
                                orderby (string)prof.Element("Code")
                                select prof;

            //Printing
            Console.WriteLine("\n\n\n");

            Console.WriteLine("(Read From XML) - 200 Level Courses with Instructor Email:\n\n\nSubject Code - Email\n");

            foreach (var courseAndProfessorEmail in orderedQueryD) if ( (int)courseAndProfessorEmail.Element("Code") >= 200 && (int)courseAndProfessorEmail.Element("Code") < 300)
                {
                    Console.WriteLine( (string)courseAndProfessorEmail.Element("Subject") + " " + (string)courseAndProfessorEmail.Element("Code") + " - " + (string)courseAndProfessorEmail.Element("Email") );
                }
        }
    }
}
