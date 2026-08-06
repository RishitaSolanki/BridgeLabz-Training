using HealthClinic.Entities;
using HealthClinic.Services;


namespace HealthClinic.Menu
{
    public class Menu
    {

        ClinicService service = new ClinicService();


        public void ShowMenu()
        {

            while(true)
            {

                Console.WriteLine("\n========== Health Clinic Management ==========");

                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. View Patients");
                Console.WriteLine("3. Update Patient");
                Console.WriteLine("4. Delete Patient");


                Console.WriteLine("5. Add Doctor");
                Console.WriteLine("6. View Doctors");
                Console.WriteLine("7. Update Doctor");
                Console.WriteLine("8. Delete Doctor");


                Console.WriteLine("9. Add Appointment");
                Console.WriteLine("10. Delete Appointment");


                Console.WriteLine("11. Exit");


                // Console.Write("\nEnter Choice: ");

                // int choice = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nEnter Choice: ");

               string input = Console.ReadLine();


                 if(!int.TryParse(input, out int choice))
                   {
                    Console.WriteLine("Please enter a valid number");
                    continue;
                           }



                switch(choice)
                {

                    // PATIENT

                    case 1:
                        AddPatient();
                        break;


                    case 2:
                        service.GetPatients();
                        break;


                    case 3:
                        UpdatePatient();
                        break;


                    case 4:
                        DeletePatient();
                        break;



                    // DOCTOR


                    case 5:
                        AddDoctor();
                        break;


                    case 6:
                        service.GetDoctors();
                        break;


                    case 7:
                        UpdateDoctor();
                        break;


                    case 8:
                        DeleteDoctor();
                        break;



                    // APPOINTMENT


                    case 9:
                        AddAppointment();
                        break;


                    case 10:
                        DeleteAppointment();
                        break;



                    case 11:
                        Console.WriteLine("Thank You!");
                        return;



                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }

            }

        }





        // ================= PATIENT =================


        void AddPatient()
        {

            Patient patient = new Patient();


            Console.Write("First Name : ");
            patient.FirstName = Console.ReadLine();


            Console.Write("Last Name : ");
            patient.LastName = Console.ReadLine();


            Console.Write("Date Of Birth (yyyy-mm-dd) : ");
            patient.DateOfBirth =
            Convert.ToDateTime(Console.ReadLine());


            Console.Write("Gender : ");
            patient.Gender =
            Convert.ToChar(Console.ReadLine());


            Console.Write("Phone : ");
            patient.Phone = Console.ReadLine();


            Console.Write("Address : ");
            patient.Address = Console.ReadLine();



            service.AddPatient(patient);

        }




        void UpdatePatient()
        {

            Patient patient = new Patient();


            Console.Write("Patient ID : ");
            patient.PatientID =
            Convert.ToInt32(Console.ReadLine());


            Console.Write("First Name : ");
            patient.FirstName = Console.ReadLine();


            Console.Write("Last Name : ");
            patient.LastName = Console.ReadLine();


            Console.Write("Phone : ");
            patient.Phone = Console.ReadLine();


            Console.Write("Address : ");
            patient.Address = Console.ReadLine();



            service.UpdatePatient(patient);

        }





        void DeletePatient()
        {

            Console.Write("Patient ID : ");

            int id =
            Convert.ToInt32(Console.ReadLine());


            service.DeletePatient(id);

        }





        // ================= DOCTOR =================



        void AddDoctor()
        {

            Doctor doctor = new Doctor();


            Console.Write("First Name : ");
            doctor.FirstName = Console.ReadLine();


            Console.Write("Last Name : ");
            doctor.LastName = Console.ReadLine();


            Console.Write("Specialization : ");
            doctor.Specialization = Console.ReadLine();


            Console.Write("Phone : ");
            doctor.Phone = Console.ReadLine();



            service.AddDoctor(doctor);

        }





        void UpdateDoctor()
        {

            Doctor doctor = new Doctor();


            Console.Write("Doctor ID : ");
            doctor.DoctorID =
            Convert.ToInt32(Console.ReadLine());


            Console.Write("First Name : ");
            doctor.FirstName = Console.ReadLine();


            Console.Write("Last Name : ");
            doctor.LastName = Console.ReadLine();


            Console.Write("Specialization : ");
            doctor.Specialization = Console.ReadLine();


            Console.Write("Phone : ");
            doctor.Phone = Console.ReadLine();



            service.UpdateDoctor(doctor);

        }





        void DeleteDoctor()
        {

            Console.Write("Doctor ID : ");

            int id =
            Convert.ToInt32(Console.ReadLine());


            service.DeleteDoctor(id);

        }







        // ================= APPOINTMENT =================



        void AddAppointment()
        {

            Appointment appointment = new Appointment();


            Console.Write("Patient ID : ");

            appointment.PatientID =
            Convert.ToInt32(Console.ReadLine());



            Console.Write("Doctor ID : ");

            appointment.DoctorID =
            Convert.ToInt32(Console.ReadLine());


            Console.Write("Appointment Date (yyyy-mm-dd) : ");
            appointment.AppointmentDate = DateTime.Parse(Console.ReadLine());


            Console.Write("Time Slot (HH:mm) : ");
            appointment.TimeSlot = TimeSpan.Parse(Console.ReadLine());


            Console.Write("Status : ");
            appointment.Status = Console.ReadLine();
       



            service.AddAppointment(appointment);

        }





        void DeleteAppointment()
        {

            Console.Write("Appointment ID : ");

            int id =
            Convert.ToInt32(Console.ReadLine());


            service.DeleteAppointment(id);

        }

    }
}