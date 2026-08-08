using Microsoft.Data.SqlClient;
using StudentManagementAPI.ModelLayer;

namespace StudentManagementAPI.RepositoryLayer
{
    public class StudentRL : IStudentRL
    {

      string connectionString =
    "Server=RISHITA_LP\\SQLEXPRESS02;Database=HealthClinicDB;Trusted_Connection=True;TrustServerCertificate=True;";


        // GET ALL STUDENTS

        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();

            using(SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand(
                "SELECT * FROM Student", con);


                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();


                while(reader.Read())
                {
                    Student student = new Student();

                    student.Id = Convert.ToInt32(reader["Id"]);
                    student.Name = reader["Name"].ToString();
                    student.Department = reader["Department"].ToString();
                    student.Age = Convert.ToInt32(reader["Age"]);


                    students.Add(student);
                }

            }

            return students;
        }



        // GET STUDENT BY ID

        public Student GetStudentById(int id)
        {

            Student student = null;


            using(SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand(
                "SELECT * FROM Student WHERE Id=@Id",
                con);


                cmd.Parameters.AddWithValue("@Id",id);


                con.Open();


                SqlDataReader reader = cmd.ExecuteReader();


                if(reader.Read())
                {
                    student = new Student()
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        Department = reader["Department"].ToString(),
                        Age = Convert.ToInt32(reader["Age"])
                    };
                }

            }

            return student;

        }




        // INSERT STUDENT

        public bool AddStudent(Student student)
        {

            using(SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand(
                "INSERT INTO Student(Name,Department,Age) VALUES(@Name,@Department,@Age)",
                con);


                cmd.Parameters.AddWithValue("@Name",student.Name);
                cmd.Parameters.AddWithValue("@Department",student.Department);
                cmd.Parameters.AddWithValue("@Age",student.Age);


                con.Open();


                int result = cmd.ExecuteNonQuery();


                return result > 0;

            }

        }




        // UPDATE STUDENT

        public bool UpdateStudent(Student student)
        {

            using(SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand(
                "UPDATE Student SET Name=@Name, Department=@Department, Age=@Age WHERE Id=@Id",
                con);


                cmd.Parameters.AddWithValue("@Name",student.Name);
                cmd.Parameters.AddWithValue("@Department",student.Department);
                cmd.Parameters.AddWithValue("@Age",student.Age);
                cmd.Parameters.AddWithValue("@Id",student.Id);


                con.Open();


                int result = cmd.ExecuteNonQuery();


                return result > 0;

            }

        }




        // DELETE STUDENT

        public bool DeleteStudent(int id)
        {

            using(SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand(
                "DELETE FROM Student WHERE Id=@Id",
                con);


                cmd.Parameters.AddWithValue("@Id",id);


                con.Open();


                int result = cmd.ExecuteNonQuery();


                return result > 0;

            }

        }

    }
}