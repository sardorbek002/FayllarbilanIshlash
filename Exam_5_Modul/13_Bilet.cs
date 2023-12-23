using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_5_Modul
{
    public  class _13_Bilet
    {
        public void Third()
        {
            ThirdTaskWithData thirdTasks = new ThirdTaskWithData();
            ThirdTaskWithData.Third();
            using (var db = new MyDbContext())
            {
                // Boshqa amallar uchun db ni ishlatish mumkin

                var query = from emp in db.Employees
                            join proj in db.EmployeeProjects on emp.Id equals proj.EmployeeId
                            select new
                            {
                                EmployeeName = emp.Name,
                                proj.ProjectName,
                                proj.ProjectDate
                            };

                foreach (var result in query)
                {
                    Console.WriteLine($"Employee: {result.EmployeeName}, Project: {result.ProjectName}, Date: {result.ProjectDate}");
                }
            }
        }
    }
    public class MyDbContext : DbContext
    {
        public MyDbContext()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=::1;Port=5432;Database=Exam;User Id=postgres;Password=sardor0602;");
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeProject> EmployeeProjects { get; set; }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class EmployeeProject
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public DateTime ProjectDate { get; set; }
        public int EmployeeId { get; set; }
    }


}
