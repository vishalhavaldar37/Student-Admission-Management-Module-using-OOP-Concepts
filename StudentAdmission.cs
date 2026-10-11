using System;

namespace StudentAdmissionManagement
{
    public class Student
    {
        // Private fields (Encapsulation)
        private int studentId;
        private string studentName;
        private int age;
        private string course;
        private double admissionFee;

        // Constructor
        public Student(int id, string name, int studentAge, string studentCourse, double fee)
        {
            studentId = id;
            studentName = name;
            age = studentAge;
            course = studentCourse;
            admissionFee = fee;
        }

        // Public method
        public void DisplayStudentDetails()
        {
            Console.WriteLine("\n===== STUDENT DETAILS =====");
            Console.WriteLine("Student ID    : " + studentId);
            Console.WriteLine("Student Name  : " + studentName);
            Console.WriteLine("Age           : " + age);
            Console.WriteLine("Course        : " + course);
            Console.WriteLine("Admission Fee : ₹" + admissionFee);
            Console.WriteLine("===========================");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================");
            Console.WriteLine(" STUDENT ADMISSION MANAGEMENT SYSTEM ");
            Console.WriteLine("==================================");

            Console.Write("Enter Student ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Course: ");
            string course = Console.ReadLine() ?? "";

            Console.Write("Enter Admission Fee: ");
            double fee = Convert.ToDouble(Console.ReadLine());

            // Object creation
            Student student = new Student(id, name, age, course, fee);

            Console.WriteLine("\nAdmission Successful!");

            // Calling method
            student.DisplayStudentDetails();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
