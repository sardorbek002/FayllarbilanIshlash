using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_5_Modul;
public class ThirdTaskWithData
{
    public static void Third()
    {
        string scriptsForCreateTable =
            @"create table 
                Employee(id serial primary key,
                Name varchar);

                create table 
                EmployeeProjects(id serial,
                ProjectName varchar,
                ProjectDate date,
                EmployeeId integer references Employee(id));";

        string CreateView = @"
            create view Project_Employee
            as
            select e.Name as Name,ep.ProjectName as ProjectName,ep.ProjectDate as ProjectDate from Employee as e
            join EmployeeProjects as ep on e.id=ep.EmployeeId
            ";
    }
}


   


