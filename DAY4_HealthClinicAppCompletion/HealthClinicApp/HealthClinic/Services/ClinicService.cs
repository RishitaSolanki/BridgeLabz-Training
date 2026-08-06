using Microsoft.Data.SqlClient;
using HealthClinic.Entities;


namespace HealthClinic.Services
{
    public class ClinicService
    {

        string connectionString =
        "Server=RISHITA_LP\\SQLEXPRESS02;Database=HealthClinicDB;Trusted_Connection=True;TrustServerCertificate=True;";


        // ================= PATIENT CRUD OPERATIONS=================


        public void AddPatient(Patient patient)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);


                string query = @"INSERT INTO Patient
                (FirstName,LastName,DateOfBirth,Gender,Phone,Address)
                VALUES
                (@FirstName,@LastName,@DOB,@Gender,@Phone,@Address)";


                SqlCommand cmd = new SqlCommand(query, con);


                cmd.Parameters.AddWithValue("@FirstName", patient.FirstName);
                cmd.Parameters.AddWithValue("@LastName", patient.LastName);
                cmd.Parameters.AddWithValue("@DOB", patient.DateOfBirth);
                cmd.Parameters.AddWithValue("@Gender", patient.Gender);
                cmd.Parameters.AddWithValue("@Phone", patient.Phone);
                cmd.Parameters.AddWithValue("@Address", patient.Address);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();


                Console.WriteLine("Patient Added Successfully");

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }



        public void GetPatients()
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);


                string query = "SELECT * FROM Patient";


                SqlCommand cmd = new SqlCommand(query, con);


                con.Open();


                SqlDataReader reader = cmd.ExecuteReader();


                while(reader.Read())
                {
                    Console.WriteLine(
                    $"{reader["PatientID"]} {reader["FirstName"]} {reader["LastName"]} {reader["Phone"]}");
                }


                con.Close();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }




        public void UpdatePatient(Patient patient)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);


                string query = @"UPDATE Patient SET
                FirstName=@FirstName,
                LastName=@LastName,
                Phone=@Phone,
                Address=@Address
                WHERE PatientID=@ID";


                SqlCommand cmd = new SqlCommand(query, con);


                cmd.Parameters.AddWithValue("@ID", patient.PatientID);
                cmd.Parameters.AddWithValue("@FirstName", patient.FirstName);
                cmd.Parameters.AddWithValue("@LastName", patient.LastName);
                cmd.Parameters.AddWithValue("@Phone", patient.Phone);
                cmd.Parameters.AddWithValue("@Address", patient.Address);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();


                Console.WriteLine("Patient Updated Successfully");

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }



        public void DeletePatient(int id)
        {
            SqlConnection con = new SqlConnection(connectionString);


            string query =
            "DELETE FROM Patient WHERE PatientID=@ID";


            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@ID", id);


            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


            Console.WriteLine("Patient Deleted Successfully");
        }





        // ================= DOCTOR CRUD OPERATIONS=================



        public void AddDoctor(Doctor doctor)
        {

            SqlConnection con = new SqlConnection(connectionString);


            string query = @"INSERT INTO Doctor
            (FirstName,LastName,Specialization,Phone)
            VALUES
            (@FirstName,@LastName,@Specialization,@Phone)";


            SqlCommand cmd = new SqlCommand(query, con);


            cmd.Parameters.AddWithValue("@FirstName", doctor.FirstName);
            cmd.Parameters.AddWithValue("@LastName", doctor.LastName);
            cmd.Parameters.AddWithValue("@Specialization", doctor.Specialization);
            cmd.Parameters.AddWithValue("@Phone", doctor.Phone);



            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


            Console.WriteLine("Doctor Added Successfully");

        }




        public void GetDoctors()
        {

            SqlConnection con =
            new SqlConnection(connectionString);


            SqlCommand cmd =
            new SqlCommand("SELECT * FROM Doctor", con);


            con.Open();


            SqlDataReader reader =
            cmd.ExecuteReader();


            while(reader.Read())
            {
                Console.WriteLine(
                $"{reader["DoctorID"]} {reader["FirstName"]} {reader["LastName"]} {reader["Specialization"]}");
            }


            con.Close();

        }





        public void UpdateDoctor(Doctor doctor)
        {

            SqlConnection con =
            new SqlConnection(connectionString);


            string query = @"UPDATE Doctor SET
            FirstName=@FirstName,
            LastName=@LastName,
            Specialization=@Specialization,
            Phone=@Phone
            WHERE DoctorID=@ID";


            SqlCommand cmd =
            new SqlCommand(query, con);



            cmd.Parameters.AddWithValue("@ID", doctor.DoctorID);
            cmd.Parameters.AddWithValue("@FirstName", doctor.FirstName);
            cmd.Parameters.AddWithValue("@LastName", doctor.LastName);
            cmd.Parameters.AddWithValue("@Specialization", doctor.Specialization);
            cmd.Parameters.AddWithValue("@Phone", doctor.Phone);



            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


            Console.WriteLine("Doctor Updated Successfully");

        }




        public void DeleteDoctor(int id)
        {

            SqlConnection con =
            new SqlConnection(connectionString);


            SqlCommand cmd =
            new SqlCommand(
            "DELETE FROM Doctor WHERE DoctorID=@ID", con);


            cmd.Parameters.AddWithValue("@ID", id);


            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


            Console.WriteLine("Doctor Deleted Successfully");

        }





        // ================= APPOINTMENT =================



        public void AddAppointment(Appointment appointment)
        {

            SqlConnection con =
            new SqlConnection(connectionString);

          string query = @"INSERT INTO Appointment
          (PatientID,DoctorID,AppointmentDate,TimeSlot,Status)
           VALUES
          (@PatientID,@DoctorID,@Date,@Time,@Status)";


            SqlCommand cmd =
            new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@PatientID", appointment.PatientID);

            cmd.Parameters.AddWithValue("@DoctorID", appointment.DoctorID);

            cmd.Parameters.AddWithValue("@Date", appointment.AppointmentDate);

            cmd.Parameters.Add("@Time", System.Data.SqlDbType.Time).Value = appointment.TimeSlot;

            cmd.Parameters.AddWithValue("@Status", appointment.Status);

            Console.WriteLine($"TimeSlot = {appointment.TimeSlot}");



            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();


            Console.WriteLine("Appointment Added Successfully");

        }





        public void DeleteAppointment(int id)
        {

            SqlConnection con =
            new SqlConnection(connectionString);



            SqlCommand cmd =
            new SqlCommand(
            "DELETE FROM Appointment WHERE AppointmentID=@ID",
            con);



            cmd.Parameters.AddWithValue("@ID", id);



            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();


            Console.WriteLine("Appointment Deleted Successfully");

        }

    }
}