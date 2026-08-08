using StudentManagementAPI.ModelLayer;

namespace StudentManagementAPI.BusinessLayer
{
    public interface IStudentBL
    {

        List<Student> GetAllStudents();

        Student GetStudentById(int id);

        bool AddStudent(Student student);

        bool UpdateStudent(Student student);

        bool DeleteStudent(int id);

    }
}