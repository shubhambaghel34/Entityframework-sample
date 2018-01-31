using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
         
                using (var db = new StudentContext()) {
                    var student = new Student() { Name = "Student1" };

                    var mathSubj = new Subject() { Name = "Mathmatics" };
                    var scisubj = new Subject() { Name = "Data science" };
                    student.subjects.Add(mathSubj);
                    student.subjects.Add(scisubj);

                    db.Students.Add(student);
                    db.SaveChanges(); }
                
            }
        }
    }
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
    public DateTime ModifiedDate { get; set; }
    public  virtual List<Subject> subjects { get; set; }
        public Student()
        {
            this.subjects = new List<Subject>();
        }
    }
    public class Subject
    {
        public int SubjectiD { get; set; }
        public String Name { get; set; }

        public virtual Student Student { get; set; }
    }
    class StudentContext : DbContext
    {
        public DbSet <Student>Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }

    }

