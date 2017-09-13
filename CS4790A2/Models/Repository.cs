using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS4790A2.Models
{
    public class Repository
    {
        public static List<Course> getAllCourses()
        {
            return BasicSchool.getAllCourses();
        }

        public static Course getCourse(int? id)
        {
            return BasicSchool.getCourse(id);
        }

        public static void addCourse(Course course)
        {
            BasicSchool.addCourse(course);
        }

        public static void updateCourse(Course course)
        {
            BasicSchool.updateCourse(course);
        }

        public static void deleteCourse(int id)
        {
            BasicSchool.deleteCourse(id);
        }

        public static List<Section> getAllSections()
        {
            return BasicSchool.getAllSections();
        }

        public static Section getSection(int? id)
        {
            return BasicSchool.getSection(id);
        }

        public static void addSection(Section section)
        {
            BasicSchool.addSection(section);
        }

        public static void updateSection(Section section)
        {
            BasicSchool.updateSection(section);
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