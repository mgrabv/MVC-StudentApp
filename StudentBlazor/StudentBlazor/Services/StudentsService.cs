using StudentBlazor.Interfaces;
using StudentBlazor.Models;
using System;
using System.Collections.Generic;

namespace StudentBlazor.Services
{
    public class StudentsService : IStudentsService
    {
        static List<Student> Students;
        static Student StudentInfo;

        public StudentsService()
        {
            Students = new List<Student> {
                new Student()
                {
                    Avatar = new Uri("https://media.tenor.com/images/76a5f91e0785d90c153f909b04f2e6f9/tenor.gif"),
                    FirstName = "Anxious",
                    LastName = "Cat",
                    Birthdate = new DateTime(2000, 4, 4),
                    Studies = "IT"
                },
                new Student()
                {
                    Avatar = new Uri("https://res.cloudinary.com/teepublic/image/private/s--EDqdEhKl--/t_Resized%20Artwork/c_fit,g_north_west,h_1054,w_1054/co_ffffff,e_outline:53/co_ffffff,e_outline:inner_fill:53/co_bbbbbb,e_outline:3:1000/c_mpad,g_center,h_1260,w_1260/b_rgb:eeeeee/c_limit,f_auto,h_630,q_90,w_630/v1539183171/production/designs/3295319_0.jpg"),
                    FirstName = "Doot",
                    LastName = "Skeleton",
                    Birthdate = new DateTime(100, 1, 1),
                    Studies = "Multimedia"
                },
                new Student()
                {
                    Avatar = new Uri("https://samequizy.pl/wp-content/uploads/2021/03/images_3cffd1145322.jpeg"),
                    FirstName = "Amogus",
                    LastName = "Impostor",
                    Birthdate = new DateTime(2018, 7, 5),
                    Studies = "GameDev"
                },
                new Student()
                {
                    Avatar = new Uri("https://pbs.twimg.com/profile_images/1244023405101363200/Nki25mlo_400x400.jpg"),
                    FirstName = "Angry",
                    LastName = "Bacteria",
                    Birthdate = new DateTime(1812, 12, 5),
                    Studies = "Biology"
                },
                new Student()
                {
                    Avatar = new Uri("https://i.redd.it/wrnjqiemopm11.jpg"),
                    FirstName = "Spooder",
                    LastName = "Man",
                    Birthdate = new DateTime(1962, 8, 1),
                    Studies = "IT"
                },
                new Student()
                {
                    Avatar = new Uri("https://preview.redd.it/0hkeya69rx421.jpg?width=779&format=pjpg&auto=webp&s=1b562656f081d8424e09c7eca6373f8b78891428"),
                    FirstName = "Bitcoined",
                    LastName = "TeslaMan",
                    Birthdate = new DateTime(1988, 11, 2),
                    Studies = "Business"
                },
                new Student()
                {
                    Avatar = new Uri("https://scontent-frt3-1.xx.fbcdn.net/v/t1.15752-9/116581549_1658959344265805_4899162752746355466_n.png?_nc_cat=102&ccb=1-3&_nc_sid=ae9488&_nc_ohc=eJeNb1P9TKMAX_mAGzm&_nc_ht=scontent-frt3-1.xx&oh=b82d56b802c404c67ba6fcac33aa45bc&oe=60D9196D"),
                    FirstName = "Xi",
                    LastName = "Jinping",
                    Birthdate = new DateTime(1865, 9, 6),
                    Studies = "Business"
                }
            };
        }

        public IEnumerable<Student> GetStudents()
        {
            return Students;
        }

        public void DeleteStudent(Student student)
        {
            Students.Remove(student);
        }

        public void SetStudentInfo(Student student)
        {
            StudentInfo = student;
        }

        public Student GetStudentInfo()
        {
            return StudentInfo;
        }
    }
}
