using Hospita.Models;
using System;

namespace Hospita
{
    class Program
    {
        HospitaContext hospi = new HospitaContext();
        static void Main(string[] args)
        {
            Program obj = new Program();


            Console.WriteLine("Welcome to the application");
            while (true)
            {

                Console.WriteLine("\n\nSelect what you want to do from the options \n(1) Add Department\n(2) Add Doctor \n(3) Add Patetient\n(4) Appointment\n(5) Treatment \n(6) Exit ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {

                    case 1:
                        obj.AddDepartment();
                        break;


                    case 2:
                        obj.AddDoctor();
                        break;

                    case 3:
                        obj.AddPatient();
                        break;
                    case 4:
                        obj.Appointment();
                        break;
                    default:
                        break;



                }
            }


        }

        void AddDepartment()
        {

            Console.Write("\nEnter Department Name : ");
            var departmentName = Console.ReadLine();
            Department department = new Department(departmentName);
            Console.WriteLine(department.DepartmentName);
            department.DepartmentName = departmentName;
            try
            {
                hospi.Departments.Add(department);
                hospi.SaveChanges();
                Console.WriteLine("Department Added Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        void AddDoctor()
        {
            Console.Write("\nEnter Doctor Name : ");
            var doctorName = Console.ReadLine();
            Console.Write("\nEnter Designation ");
            var designation = Console.ReadLine();
            //Console.WriteLine("Enter DepartmentId.");
            //var departmentId = Convert.ToInt32(Console.ReadLine());


            Doctor doctor = new Doctor(doctorName, designation);
            try
            {
                hospi.Doctors.Add(doctor);
                hospi.SaveChanges();
                Console.WriteLine("Doctor Added Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        void AddPatient()
        {
            Console.Write("\nEnter Patient Name : ");
            var patientName = Console.ReadLine();

            Console.WriteLine("Enter Age.");
            var age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Contect Number.");
            var contect = Convert.ToInt32(Console.ReadLine());

            Patient patient = new Patient(patientName, age, contect);
            try
            {
                hospi.Patetients.Add(patient);
                hospi.SaveChanges();
                Console.WriteLine(" Added Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        void Appointment()
        {
            Console.WriteLine("enter DepartmentId");
            int deptId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter DoctorId");
            int doctorId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter PatientId");
            int patientId = Convert.ToInt32(Console.ReadLine());

            Appointment appointment = new Appointment(deptId, doctorId, patientId);
            try
            {
                hospi.Appointments.Add(appointment);
                hospi.SaveChanges();
                Console.WriteLine(" Added Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }


        void Treatment() {
            Console.WriteLine("Enter  Drug name");
            string drugName =Console.ReadLine();
            Console.WriteLine("Enter AppointmantI Id");
            int appointmentId = Convert.ToInt32(Console.ReadLine());
            
            Treatment treatment = new Treatment(drugName ,appointmentId);
            try
            {
                hospi.Treatments.Add(treatment);
                hospi.SaveChanges();
                Console.WriteLine(" Added Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

       /* void PatientList()
        {
            var patientList = hospi.Patient;
            try
            {
                foreach (var patient in patientList)
                {

                    Console.WriteLine(" Patient Id : " + patient.PatientId + "Patient Name : " + patient.PatientName + "Age : " + patient.Age + "Contect : " + patient.Contect);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

   */

    }
}
