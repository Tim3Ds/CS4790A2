using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS4790A2.Models
{
    public class Repository
    {
        // get funtions
        public static List<Course> getAllCourses()
        {
            return BasicSchool.getAllCourses();
        }

        public static List<Section> getAllSections()
        {
            return BasicSchool.getAllSections();
        }

        public static Course getCourse(int? id)
        {
            return BasicSchool.getCourse(id);
        }

        public static Section getSection(int? id)
        {
            return BasicSchool.getSection(id);
        }

        public static CourseAndSections getCourseAndSections(int? id)
        {
            return BasicSchool.getCourseAndSections(id);
        }

        // add functions
        public static void addCourse(Course course)
        {
            BasicSchool.addCourse(course);
        }

        public static void addSection(Section section)
        {
            BasicSchool.addSection(section);
        }

        // update funtions
        public static void updateCourse(Course course)
        {
            BasicSchool.updateCourse(course);
        }

        public static void updateSection(Section section)
        {
            BasicSchool.updateSection(section);
        }

        // delete funtions
        public static void deleteCourse(int id)
        {
            BasicSchool.deleteCourse(id);
        }

        public static void deleteSection(int id)
        {
            BasicSchool.deleteSection(id);
        }

        public static void dispose()
        {
            BasicSchool.dispose();
        }
    }
}