namespace CS4790IA1.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class BasicSchoolDBContext : DbContext
    {
        // Your context has been configured to use a 'BasicSchool' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CS4790IA1.Models.BasicSchool' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BasicSchool' 
        // connection string in the application configuration file.
        //public BasicSchoolDBContext() : base("name=BasicSchoolDBContext")
        //{
        //}
        

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

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
        public string courseNumber { get; set; }
        public string courseName { get; set; }
        public int creditHours { get; set; }
        public int? maxEnrollment { get; set; }
    }

    [Table("Section")]
    public class Section
    {
        [Key]
        public int Id { get; set; }
        public int sectionId { get; set; }
        public int sectionNumber { get; set; }
        public string courseNumber { get; set; }
        public string sectionDays { get; set; }
        public DateTime sectionTime { get; set; }
    }
}