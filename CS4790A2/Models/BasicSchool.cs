namespace CS4790A2.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel;


    // move all data access control to this class
    public class BasicSchool
    {
        public static List<Course> getAllCourses()
        {
            BasicSchoolDBContext db = new BasicSchoolDBContext();
            return db.courses.ToList();
        }

        public static Course getCourse(int? id)
        {
            BasicSchoolDBContext db = new BasicSchoolDBContext();
            return db.courses.Find(id);
        }

        public static void addCourse(Course course)
        {
            BasicSchoolDBContext db = new BasicSchoolDBContext();
            db.courses.Add(course);
            db.SaveChanges();
        }

        public static void updateCourse(Course course)
        {
            BasicSchoolDBContext db = new BasicSchoolDBContext();
            db.Entry(course).State = EntityState.Modified;
            db.SaveChanges();
        }

        public static void deleteCourse(int id)
        {
            BasicSchoolDBContext db = new BasicSchoolDBContext();
            Course course = db.courses.Find(id);
            db.courses.Remove(course);
            db.SaveChanges();
        }

        public static void disposeCourse()
        {
            BasicSchoolDBContext db = new BasicSchoolDBContext();
            db.Dispose();
        }

        public static List<Section> getAllSection()
        {
            BasicSchoolDBContext db = new BasicSchoolDBContext();
            return db.sections.ToList();
        }

        public static Section getSection(int? id)
        {
            BasicSchoolDBContext db = new BasicSchoolDBContext();
            return db.sections.Find(id);
        }

        public static void addSection(Section section)
        {
            BasicSchoolDBContext db = new BasicSchoolDBContext();
            db.sections.Add(section);
            db.SaveChanges();
        }

        public static void updateSection(Section section)
        {
            BasicSchoolDBContext db = new BasicSchoolDBContext();
            db.Entry(section).State = EntityState.Modified;
            db.SaveChanges();
        }

        public static void deleteSection(int id)
        {
            BasicSchoolDBContext db = new BasicSchoolDBContext();
            Section section = db.sections.Find(id);
            db.sections.Remove(section);
            db.SaveChanges();
        }

        public static void disposeSection()
        {
            BasicSchoolDBContext db = new BasicSchoolDBContext();
            db.Dispose();
        }
    }

    public class BasicSchoolDBContext : DbContext
    {
        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Course> courses { get; set; }
        public virtual DbSet<Section> sections { get; set; }
    }

    //public class MyEntity
    [Table("Course")]// prevent entity framework form messing with name
    public class Course
    {   
        [Key]
        public int Id { get; set; }
        [DisplayName("Course Number")]
        public string courseNumber { get; set; }
        [DisplayName("Course Name")]
        public string courseName { get; set; }
        // validation 
        [Range(0, 4)]
        [DisplayName("Chedit Hours")]
        public int creditHours { get; set; }
        [Range(15, 40, ErrorMessage = "What are you thinking??")]
        [DisplayName("Max Enrollment")]
        public int? maxEnrollment { get; set; }
    }

    [Table("Section")]
    public class Section
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Section ID")]
        public int sectionId { get; set; }
        [DisplayName("Section #")]
        public int sectionNumber { get; set; }
        [DisplayName("Course Number")]
        public string courseNumber { get; set; }
        [DisplayName("Days")]
        public string sectionDays { get; set; }
        [DisplayName("Time")]
        public DateTime sectionTime { get; set; }
    }
}