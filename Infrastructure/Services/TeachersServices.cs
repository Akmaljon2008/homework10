using Domain.Models;
namespace Infrastructure.Services;

public class TeachersServices
{
    List<Teachers> teacher = new List<Teachers>();
    public List<Teachers> GetTeachers(){
        return teacher;
    }
    public void AddTeachers(Teachers Teachers){
        teacher.Add(Teachers);
    }
    public string UpdateTeachers(Teachers Teachers){
        foreach (var te in teacher)
        {
            if(te.Id == Teachers.Id){
                te.FirstName = Teachers.FirstName;
                te.LastName = Teachers.LastName;
                te.Position = Teachers.Position;
                te.ExpiarenceAmount = Teachers.ExpiarenceAmount;
               return "Student deleted soccessfully";
            }
        }
        return "Student not found";
    }
    public string DeleteTeachers(int id){
        foreach (var te in teacher)
        {
            if(te.Id == id){
                teacher.Remove(te);
                return "Student deleted successfully";
            }
        }
        return "Student not found";
    }
}