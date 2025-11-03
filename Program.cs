using System;
using System.Linq;

namespace StudentCodeFirst
{
    class Program
    {
        static void Main()
        {
            using (var db = new SchoolContext())
            {
                var student = new Student { FirstName = "Ali", LastName = "Khan" };
                db.Students.Add(student);
                db.SaveChanges();

                Console.WriteLine("Student added successfully!\n");
                Console.WriteLine("All students in database:");
                foreach (var s in db.Students.ToList())
                {
                    Console.WriteLine($"{s.StudentId}: {s.FirstName} {s.LastName}");
                }
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
