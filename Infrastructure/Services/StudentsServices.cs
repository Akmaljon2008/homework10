using Domain.Models;
namespace Infrastructure.Services;

public class StudentsServices
{
    List<Students> student = new List<Students>();
    public List<Students> GetStudents(){
        return student;
    }
    public void AddStudents(Students students){
        student.Add(students);
    }
    public string UpdateStudents(Students students){
        foreach (var st in student)
        {
            if(st.Id == students.Id){
                st.FirstName = students.FirstName;
                st.LastName = students.LastName;
                st.BirthDate = students.BirthDate;
                st.Adress = students.Adress;
               return "Student updated soccessfully";
            }
        }
        return "Student not found";
    }
    public string DeleteStudent(int id){
        foreach (var st in student)
        {
            if(st.Id == id){
                student.Remove(st);
                return "Student deleted successfully";
            }
        }
        return "Student not found";
    }
}
