using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example.Models
{
    public partial class Course
    {
        public Course()
        {
        }
        public Course(string code, string title)
        {
            Code = code;
            Title = title;
        }

        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }


        //hardcode a list of courses. 
        private static List<Course> courses = null;
        public static List<Course> GetCourseList()
        {
            if (courses != null) return courses;


            courses = new List<Course>();

            //Just for example hard code courses here
            Course course = new Course("CST8257", "Web Application Development");
            course.Description = "Students are introduced to PHP and how this technology is used to create dynamic server-side web applications. Students learn how to build database-driven Web applications using PHP. Students learn techniques to access and process data, manage state information, upload and download files, interact with the file system and manipulate pictures through the study of examples. The course concludes with a mini-project to develop a social media network with emphasis on sharing and managing picture albums.";
            courses.Add(course);

            course = new Course("CST8253", "Web Programmming II");
            course.Description = "Emphasis is placed on ways of moving data between web pages and databases using the .NET platform: C#, ASP.NET, Microsoft Entity Frame and the .NET Framework. Students focus on how web applications can interact with databases through Entity Frame or other technologies. Server-side methods and the advantages of multi-tiered application architecture are explored.";
            courses.Add(course);

            course = new Course("CST8256", "Web Programming Language I");
            course.Description = "This course introduces students to the software engineering process. System engineering, design, software quality assurance and testing are explored in detail. The course consists of lectures, case studies and practical lab group work. Project teams are provided with the opportunity to apply sound software engineering principles in the scoping and analysis of web-related projects. Students must produce appropriate documentation to support the project progression to the fourth level Project course.";
            courses.Add(course);

            course = new Course("CST8259", "Web Programming Language II");
            course.Description = "Students are introduced to the concepts behind implementing network operating systems in a multiple user, computer and Internet Protocol (IP) networked environment. Topics include managing and updating user accounts, access rights to files and directories, Transmission Control Protocol/Internet Protocol (TCP/IP) and TCP/IP services: Domain Name System (DNS), Hyper Text Transfer Protocol (HTTP) and File Transfer Protocol (FTP). Theory and practical lab assignments are reinforced to install and configure a network operating system and the services mentioned";
            courses.Add(course);

            course = new Course("CST8282", "Introduction to Database and SQL");
            course.Description = "The concepts and use of high level tools and current web programming languages used in web development such as XML, Content Management Systems and JavaScript frameworks are addressed.";
            courses.Add(course);

            return courses;
        }

        public static void AddCourse(Course course)
        {
            List<Course> courseList = GetCourseList();
            courses.Add(course);
        }

        public static void RemoveCourse(string id)
        {
            List<Course> courseList = GetCourseList();
            Course cs = (from c in courseList where c.Code == id select c).FirstOrDefault<Course>();

            if (cs != null)
            {
                courseList.Remove(cs);
            }
        }
    }


}
