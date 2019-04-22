using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Tanulmanyi2._0.Models
{
    public static class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TanulmanyiContext(
                serviceProvider.GetRequiredService<DbContextOptions<TanulmanyiContext>>()))
            {
                if (context.Trainings.Any())
                {
                    return;
                }

                #region Trainings

                var training1 = new Training()
                {
                    Name = "trainingA"

                };
                var training2 = new Training()
                {
                    Name = "trainingB"

                };
                context.Trainings.Add(training1);
                context.Trainings.Add(training2);

                #endregion

                #region Instructors

                var instructor1 = new Instructor()
                {
                    Name = "instructor1",
                    UserName = "instructor1",
                    Password = MakePassword("admininst1")
                };
                var instructor2 = new Instructor()
                {
                    Name = "instructor2",
                    UserName = "instructor2",
                    Password = MakePassword("admininst2")
                };
                var instructor3 = new Instructor()
                {
                    Name = "instructor3",
                    UserName = "instructor3",
                    Password = MakePassword("admininst3")
                };
                context.Instructors.Add(instructor1);
                context.Instructors.Add(instructor2);
                context.Instructors.Add(instructor3);

                #endregion

                #region Courses

                var courseA1 = new Course()
                {
                    Name = "courseA1",
                    Instructor = instructor1,
                    Time = DateTime.Parse("1/05/2019"),
                    MaxStudents = 10,
                    Training = training1
                };
                var courseA2 = new Course()
                {
                    Name = "courseA2",
                    Instructor = instructor3,
                    Time = DateTime.Parse("3/05/2019"),
                    MaxStudents = 20,
                    Training = training1
                };
                var courseA3 = new Course()
                {
                    Name = "courseA3",
                    Instructor = instructor1,
                    Time = DateTime.Parse("5/05/2019"),
                    MaxStudents = 3,
                    Training = training1
                };
                var courseA4 = new Course()
                {
                    Name = "courseA4",
                    Instructor = instructor2,
                    Time = DateTime.Parse("7/05/2019"),
                    MaxStudents = 5,
                    Training = training1
                };
                var courseA5 = new Course()
                {
                    Name = "courseA5",
                    Instructor = instructor1,
                    Time = DateTime.Parse("9/05/2019"),
                    MaxStudents = 10,
                    Training = training1
                };
                var courseA6 = new Course()
                {
                    Name = "courseA6",
                    Instructor = instructor3,
                    Time = DateTime.Parse("11/05/2019"),
                    MaxStudents = 20,
                    Training = training1
                };
                var courseA7 = new Course()
                {
                    Name = "courseA7",
                    Instructor = instructor1,
                    Time = DateTime.Parse("12/05/2019"),
                    MaxStudents = 20,
                    Training = training1
                };
                var courseA8 = new Course()
                {
                    Name = "courseA8",
                    Instructor = instructor2,
                    Time = DateTime.Parse("14/05/2019"),
                    MaxStudents = 10,
                    Training = training1
                };
                var courseA9 = new Course()
                {
                    Name = "courseA9",
                    Instructor = instructor1,
                    Time = DateTime.Parse("16/05/2019"),
                    MaxStudents = 5,
                    Training = training1
                };
                var courseA10 = new Course()
                {
                    Name = "courseA10",
                    Instructor = instructor1,
                    Time = DateTime.Parse("18/05/2019"),
                    MaxStudents = 10,
                    Training = training1
                };
                var courseA11 = new Course()
                {
                    Name = "courseA11",
                    Instructor = instructor3,
                    Time = DateTime.Parse("20/05/2019"),
                    MaxStudents = 30,
                    Training = training1
                };
                var courseA12 = new Course()
                {
                    Name = "courseA12",
                    Instructor = instructor1,
                    Time = DateTime.Parse("22/05/2019"),
                    MaxStudents = 1,
                    Training = training1
                };
                var courseA13 = new Course()
                {
                    Name = "courseA13",
                    Instructor = instructor1,
                    Time = DateTime.Parse("24/05/2019"),
                    MaxStudents = 7,
                    Training = training1
                };
                var courseA14 = new Course()
                {
                    Name = "courseA14",
                    Instructor = instructor2,
                    Time = DateTime.Parse("26/05/2019"),
                    MaxStudents = 5,
                    Training = training1
                };
                var courseA15 = new Course()
                {
                    Name = "courseA15",
                    Instructor = instructor1,
                    Time = DateTime.Parse("2/06/2019"),
                    MaxStudents = 10,
                    Training = training1
                };
                var courseA16 = new Course()
                {
                    Name = "courseA16",
                    Instructor = instructor3,
                    Time = DateTime.Parse("4/06/2019"),
                    MaxStudents = 20,
                    Training = training1
                };
                var courseA17 = new Course()
                {
                    Name = "courseA17",
                    Instructor = instructor1,
                    Time = DateTime.Parse("6/06/2019"),
                    MaxStudents = 10,
                    Training = training1
                };
                var courseA18 = new Course()
                {
                    Name = "courseA18",
                    Instructor = instructor2,
                    Time = DateTime.Parse("8/06/2019"),
                    MaxStudents = 2,
                    Training = training1
                };
                var courseA19 = new Course()
                {
                    Name = "courseA19",
                    Instructor = instructor2,
                    Time = DateTime.Parse("10/06/2019"),
                    MaxStudents = 10,
                    Training = training1
                };
                var courseA20 = new Course()
                {
                    Name = "courseA20",
                    Instructor = instructor1,
                    Time = DateTime.Parse("12/06/2019"),
                    MaxStudents = 4,
                    Training = training1
                };
                var courseA21 = new Course()
                {
                    Name = "courseA21",
                    Instructor = instructor1,
                    Time = DateTime.Parse("14/06/2019"),
                    MaxStudents = 10,
                    Training = training1
                };
                var courseA22 = new Course()
                {
                    Name = "courseA22",
                    Instructor = instructor3,
                    Time = DateTime.Parse("16/06/2019"),
                    MaxStudents = 5,
                    Training = training1
                };
                var courseA23 = new Course()
                {
                    Name = "courseA23",
                    Instructor = instructor1,
                    Time = DateTime.Parse("20/06/2019"),
                    MaxStudents = 10,
                    Training = training1
                };
                var courseA24 = new Course()
                {
                    Name = "courseA24",
                    Instructor = instructor2,
                    Time = DateTime.Parse("25/06/2019"),
                    MaxStudents = 10,
                    Training = training1
                };
                context.Courses.Add(courseA1);
                context.Courses.Add(courseA2);
                context.Courses.Add(courseA3);
                context.Courses.Add(courseA4);
                context.Courses.Add(courseA5);
                context.Courses.Add(courseA6);
                context.Courses.Add(courseA7);
                context.Courses.Add(courseA8);
                context.Courses.Add(courseA9);
                context.Courses.Add(courseA10);
                context.Courses.Add(courseA11);
                context.Courses.Add(courseA12);
                context.Courses.Add(courseA13);
                context.Courses.Add(courseA14);
                context.Courses.Add(courseA15);
                context.Courses.Add(courseA16);
                context.Courses.Add(courseA17);
                context.Courses.Add(courseA18);
                context.Courses.Add(courseA19);
                context.Courses.Add(courseA20);
                context.Courses.Add(courseA21);
                context.Courses.Add(courseA22);
                context.Courses.Add(courseA23);
                context.Courses.Add(courseA24);

                var courseB1 = new Course()
                {
                    Name = "courseB1",
                    Instructor = instructor1,
                    Time = DateTime.Parse("2/05/2019"),
                    MaxStudents = 10,
                    Training = training2
                };
                var courseB2 = new Course()
                {
                    Name = "courseB2",
                    Instructor = instructor3,
                    Time = DateTime.Parse("4/05/2019"),
                    MaxStudents = 20,
                    Training = training2
                };
                var courseB3 = new Course()
                {
                    Name = "courseB3",
                    Instructor = instructor1,
                    Time = DateTime.Parse("6/05/2019"),
                    MaxStudents = 3,
                    Training = training2
                };
                var courseB4 = new Course()
                {
                    Name = "courseB4",
                    Instructor = instructor2,
                    Time = DateTime.Parse("7/05/2019"),
                    MaxStudents = 5,
                    Training = training2
                };
                var courseB5 = new Course()
                {
                    Name = "courseB5",
                    Instructor = instructor1,
                    Time = DateTime.Parse("10/05/2019"),
                    MaxStudents = 10,
                    Training = training2
                };
                var courseB6 = new Course()
                {
                    Name = "courseB6",
                    Instructor = instructor3,
                    Time = DateTime.Parse("12/05/2019"),
                    MaxStudents = 20,
                    Training = training2
                };
                var courseB7 = new Course()
                {
                    Name = "courseB7",
                    Instructor = instructor1,
                    Time = DateTime.Parse("13/05/2019"),
                    MaxStudents = 20,
                    Training = training2
                };
                var courseB8 = new Course()
                {
                    Name = "courseB8",
                    Instructor = instructor2,
                    Time = DateTime.Parse("15/05/2019"),
                    MaxStudents = 10,
                    Training = training2
                };
                var courseB9 = new Course()
                {
                    Name = "courseB9",
                    Instructor = instructor1,
                    Time = DateTime.Parse("17/05/2019"),
                    MaxStudents = 5,
                    Training = training2
                };

                context.Courses.Add(courseB1);
                context.Courses.Add(courseB2);
                context.Courses.Add(courseB3);
                context.Courses.Add(courseB4);
                context.Courses.Add(courseB5);
                context.Courses.Add(courseB6);
                context.Courses.Add(courseB7);
                context.Courses.Add(courseB8);
                context.Courses.Add(courseB9);

                #endregion

                #region Students

                var student1 = new Student()
                {
                    Name = "student1",
                    UserName = "student1",
                    Password = MakePassword("admin1")
                };
                var student2 = new Student()
                {
                    Name = "student2",
                    UserName = "student2",
                    Password = MakePassword("admin2")
                };
                var student3 = new Student()
                {
                    Name = "student3",
                    UserName = "student3",
                    Password = MakePassword("admin3")
                };
                var student4 = new Student()
                {
                    Name = "student4",
                    UserName = "student4",
                    Password = MakePassword("admin4")
                };
                var student5 = new Student()
                {
                    Name = "student5",
                    UserName = "student5",
                    Password = MakePassword("admin5")
                };
                var student6 = new Student()
                {
                    Name = "student6",
                    UserName = "student6",
                    Password = MakePassword("admin6")
                };
                var student7 = new Student()
                {
                    Name = "student7",
                    UserName = "student7",
                    Password = MakePassword("admin7")
                };
                var student8 = new Student()
                {
                    Name = "student8",
                    UserName = "student8",
                    Password = MakePassword("admin8")
                };
                var student9 = new Student()
                {
                    Name = "student9",
                    UserName = "student9",
                    Password = MakePassword("admin9")
                };

                context.Students.Add(student1);
                context.Students.Add(student2);
                context.Students.Add(student3);
                context.Students.Add(student4);
                context.Students.Add(student5);
                context.Students.Add(student6);
                context.Students.Add(student7);
                context.Students.Add(student8);
                context.Students.Add(student9);

                #endregion

                #region StudentCourses

                var stCourse1 = new StCourse()
                {
                    Course = courseA3,
                    Student = student1,
                };
                var stCourse2 = new StCourse()
                {
                    Course = courseA3,
                    Student = student4,
                };

                var stCourse3 = new StCourse()
                {
                    Course = courseA3,
                    Student = student5,
                };

                var stCourse4 = new StCourse()
                {
                    Course = courseA1,
                    Student = student1,
                };

                var stCourse5 = new StCourse()
                {
                    Course = courseA1,
                    Student = student2,
                };

                var stCourse6 = new StCourse()
                {
                    Course = courseA1,
                    Student = student3,
                };

                var stCourse7 = new StCourse()
                {
                    Course = courseA1,
                    Student = student4,
                };

                var stCourse8 = new StCourse()
                {
                    Course = courseA5,
                    Student = student7,
                };

                var stCourse9 = new StCourse()
                {
                    Course = courseA5,
                    Student = student8,
                };

                var stCourse10 = new StCourse()
                {
                    Course = courseA5,
                    Student = student9,
                };

                context.StudentCourses.Add(stCourse1);
                context.StudentCourses.Add(stCourse2);
                context.StudentCourses.Add(stCourse3);
                context.StudentCourses.Add(stCourse4);
                context.StudentCourses.Add(stCourse5);
                context.StudentCourses.Add(stCourse6);
                context.StudentCourses.Add(stCourse7);
                context.StudentCourses.Add(stCourse8);
                context.StudentCourses.Add(stCourse9);
                context.StudentCourses.Add(stCourse10);

                #endregion

                context.SaveChanges();
            }
        }
        private static byte[] MakePassword(string Passwd)
        {
            Byte[] passwordBytes = null;
            using (SHA512CryptoServiceProvider provider = new SHA512CryptoServiceProvider())
            {
                passwordBytes = provider.ComputeHash(Encoding.UTF8.GetBytes(Passwd));
            }

            return passwordBytes;
        }
    }
}
