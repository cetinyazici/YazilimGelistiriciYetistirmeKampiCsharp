using kodlama.io.Business;
using kodlama.io.DataAccess.Concretes;
using kodlama.io.Entities;
using System;
using System.Collections.Generic;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("KODLAMA.İO");
        Console.WriteLine("----------");

        Console.WriteLine("Yeni kurs eklenmeden önceki kurslar:");
        CourseManger courseManger = new(new CourseDal());
        List<Course> courses = courseManger.GetAll();
        foreach (var course in courses)
        {
            Console.WriteLine("KursID: " + course.Id);
            Console.WriteLine("EğitmenID: " + course.InstructorId);
            Console.WriteLine("KategoriID: " + course.CategoryId);
            Console.WriteLine("Kursİsmi: " + course.CourseName);
            Console.WriteLine("Açıklama: " + course.CourseDesciription);
            Console.WriteLine("Fiyat: " + course.CoursePrice);
            Console.WriteLine();
        }

        courseManger.Create(new Course
        {
            Id = 4,
            InstructorId = 1,
            CategoryId = 2,
            CourseName = "Deneme",
            CourseDesciription = "Deneme",
            CoursePrice = 0,
        });

        List<Course> createCourse = courseManger.GetAll();
        foreach (var course in createCourse)
        {
            Console.WriteLine("KursID: " + course.Id);
            Console.WriteLine("EğitmenID: " + course.InstructorId);
            Console.WriteLine("KategoriID: " + course.CategoryId);
            Console.WriteLine("Kursİsmi: " + course.CourseName);
            Console.WriteLine("Açıklama: " + course.CourseDesciription);
            Console.WriteLine("Fiyat: " + course.CoursePrice);
            Console.WriteLine();
        }

        // Güncellenen veya silinen bir kursun listeden kaldırılıp kaldırılmadığını kontrol.
        CourseManger courseManger2 = new(new CourseDal());
        courseManger2.Delete(new Course{Id = 2});

        CourseManger courseManger3 = new(new CourseDal());
        courseManger3.Update(new Course
        {
            Id = 2,
            InstructorId = 2,
            CategoryId = 3,
            CourseName = "Güncellendi",
            CourseDesciription = "Test",
            CoursePrice = 0,
        });

        Console.WriteLine("Kurs güncellendikten sonra liste güncellendi:");
        List<Course> updateCourse = courseManger.GetAll();
        foreach (var course in updateCourse)
        {
            Console.WriteLine("KursID: " + course.Id);
            Console.WriteLine("EğitmenID: " + course.InstructorId);
            Console.WriteLine("KategoriID: " + course.CategoryId);
            Console.WriteLine("Kursİsmi: " + course.CourseName);
            Console.WriteLine("Açıklama: " + course.CourseDesciription);
            Console.WriteLine("Fiyat: " + course.CoursePrice);
            Console.WriteLine();
        }

        Console.WriteLine("*********************************");
        Console.WriteLine("Yeni kategoriden öncekiler:");
        CategoryManager categoryManager = new(new CategoryDal());
        List<Category> categorys = categoryManager.GetAll();
        foreach (var category in categorys)
        {
            Console.WriteLine("KategoriID: " + category.Id);
            Console.WriteLine("KategoriName: " + category.CategoryName);
            Console.WriteLine();
        }


        Console.WriteLine("Eklendikten sonra kategoy listesi: ");
        categoryManager.Create(new Category
        {
            Id = 3,
            CategoryName = "Siber (eklendi)",
        });
        List<Category> createCategory = categoryManager.GetAll();
        foreach (var category in createCategory)
        {
            Console.WriteLine("KategoriID: " + category.Id);
            Console.WriteLine("KategoriName: " + category.CategoryName);
            Console.WriteLine();
        }

        categoryManager.Update(new Category
        {
            Id = 3,
            CategoryName = "Siber (güncellendi)"
        });
        List<Category> updateCategory = categoryManager.GetAll();
        foreach (var category in updateCategory)
        {
            Console.WriteLine("KategoriID: " + category.Id);
            Console.WriteLine("KategoriName: " + category.CategoryName);
            Console.WriteLine();
        }

        categoryManager.Delete(new Category{Id = 3});
        List<Category> categories = categoryManager.GetAll();
        foreach (var category in categories)
        {
            Console.WriteLine("KategoriID: " + category.Id);
            Console.WriteLine("KategoriName: " + category.CategoryName);
            Console.WriteLine();
        }


        Console.WriteLine("*********************************");
        Console.WriteLine("Eğitmen eklenmeden önceki liste: ");
        InsructorManager ınsructorManager = new(new InstructorDal());
        List<Instructor> ınstructors = ınsructorManager.GetAll();
        foreach (var ınstructor in ınstructors)
        {
            Console.WriteLine("EğitmenID: " + ınstructor.Id);
            Console.WriteLine("EğitmenName: " + ınstructor.FirstName);
            Console.WriteLine("EğitmenSurname: " + ınstructor.LastName);
            Console.WriteLine() ;   
        }

        Console.WriteLine("Eğitmen eklendikten sonraki liste: ");
        ınsructorManager.Create(new Instructor { Id=3,FirstName="Deneme (ekleme)",LastName="Deneme"});
        List<Instructor> createInstructor = ınsructorManager.GetAll();
        foreach (var ınstructor in createInstructor)
        {
            Console.WriteLine("EğitmenID: " + ınstructor.Id);
            Console.WriteLine("EğitmenName: " + ınstructor.FirstName);
            Console.WriteLine("EğitmenSurname: " + ınstructor.LastName);
            Console.WriteLine();
        }

        Console.WriteLine("Eğitmen güncellendikten sonraki liste: ");
        ınsructorManager.Update(new Instructor { Id = 3, FirstName = "Güncellendi", LastName = "Güncellendi" });
        List<Instructor> updateInstructor = ınsructorManager.GetAll();
        foreach (var ınstructor in updateInstructor)
        {
            Console.WriteLine("EğitmenID: " + ınstructor.Id);
            Console.WriteLine("EğitmenName: " + ınstructor.FirstName);
            Console.WriteLine("EğitmenSurname: " + ınstructor.LastName);
            Console.WriteLine();
        }

        Console.WriteLine("Eğitmen Silindikten sonraki liste: ");
        ınsructorManager.Deleted(new Instructor { Id = 3});
        List<Instructor> deletedInstructor = ınsructorManager.GetAll();
        foreach (var ınstructor in deletedInstructor)
        {
            Console.WriteLine("EğitmenID: " + ınstructor.Id);
            Console.WriteLine("EğitmenName: " + ınstructor.FirstName);
            Console.WriteLine("EğitmenSurname: " + ınstructor.LastName);
            Console.WriteLine();
        }


    }
}
