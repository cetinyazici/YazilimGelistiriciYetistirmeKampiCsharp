using kodlama.io.DataAccess.Abstracts;
using kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama.io.DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        List<Course> _courses;
        public CourseDal()
        {
            Course course1 = new Course();
            course1.Id = 1;
            course1.CategoryId = 1;
            course1.InstructorId = 1;
            course1.CourseName = "C#";
            course1.CourseDesciription = "Açıklama";
            course1.CoursePrice = 0;

            Course course2 = new Course();
            course2.Id = 2;
            course2.CategoryId = 1;
            course2.InstructorId = 2;
            course2.CourseName = "JAVA";
            course2.CourseDesciription = "Açıklama";
            course2.CoursePrice = 0;

            _courses = new List<Course> {course1, course2 };

        }
        public void Create(Course course)
        {
            _courses.Add(course);
            Console.WriteLine("Kurs başarıyla eklendi.");

        }

        public void Delete(Course course)
        {
            var deletedCourse = _courses.First(c => c.Id == course.Id);
            _courses.Remove(deletedCourse);
            Console.WriteLine("Kurs başarıyla silindi.");
        }

        public void Update(Course course)
        {
            var updatedCourse = _courses.First(c => c.Id == course.Id);
            updatedCourse.Id = course.Id;
            updatedCourse.CourseName = course.CourseName;
            updatedCourse.CourseDesciription = course.CourseDesciription;
            updatedCourse.InstructorId = course.InstructorId;
            updatedCourse.CategoryId = course.CategoryId;
            updatedCourse.CoursePrice = course.CoursePrice;
            Console.WriteLine("Kurs başarıyla güncellendi.");
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

    }
}
