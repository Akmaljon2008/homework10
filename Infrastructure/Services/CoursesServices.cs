using Domain.Models;

namespace Infrastructure.Services;

public class CoursesServices
{
    List<Courses> course = new List<Courses>();
    public List<Courses> GetCourses(){
        return course;
    }
    public void AddCourses(Courses courses){
        course.Add(courses);
    }
    public string UpdateCourses(Courses courses){
        foreach (var cr in course)
        {
            if(cr.Id == courses.Id){
                cr.Title = courses.Title;
                cr.Description = courses.Description;
                cr.Fee = courses.Fee;
                cr.HasDiscount = courses.HasDiscount;
               return "Course deleted soccessfully";
            }
        }
        return "Course not found";
    }
    public string DeleteCourses(int id){
        foreach (var cr in course)
        {
            if(cr.Id == id){
                course.Remove(cr);
                return "Course deleted successfully";
            }
        }
        return "Course not found";
    }
}
