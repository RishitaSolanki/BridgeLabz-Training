using StudentManagementAPI.ModelLayer;
using StudentManagementAPI.RepositoryLayer;


namespace StudentManagementAPI.BusinessLayer
{
    public class StudentBL : IStudentBL
    {

        private readonly IStudentRL studentRL;


        public StudentBL(IStudentRL studentRL)
        {
            this.studentRL = studentRL;
        }



        public List<Student> GetAllStudents()
        {
            return studentRL.GetAllStudents();
        }



        public Student GetStudentById(int id)
        {
            return studentRL.GetStudentById(id);
        }



        public bool AddStudent(Student student)
        {
            return studentRL.AddStudent(student);
        }



        public bool UpdateStudent(Student student)
        {
            return studentRL.UpdateStudent(student);
        }



        public bool DeleteStudent(int id)
        {
            return studentRL.DeleteStudent(id);
        }


    }
}