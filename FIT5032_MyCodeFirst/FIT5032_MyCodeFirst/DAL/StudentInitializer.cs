using FIT5032_MyCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace FIT5032_MyCodeFirst.DAL
{
    public class StudentInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<StudentContext>
    {
        protected override void Seed(StudentContext context)
        {
            var students = new List<Student>
            {
            new Student{FirstName="Carson",LastName="Alexander"},
            new Student{FirstName="Meredith",LastName="Alonso"},
            new Student{FirstName="Arturo",LastName="Anand"},
            new Student{FirstName="Gytis",LastName="Barzdukas"},
            new Student{FirstName="Yan",LastName="Li"},
            new Student{FirstName="Peggy",LastName="Justice"},
            new Student{FirstName="Laura",LastName="Norman"},
            new Student{FirstName="Nino",LastName="Olivetto"}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var units = new List<Unit>
            {
            new Unit{ID=1050,Name="Chemistry",Description=" ",},
            new Unit{ID=4022,Name="Microeconomics",Description=" ",},
            new Unit{ID=4041,Name="Macroeconomics",Description=" "},
            new Unit{ID=1045,Name="Calculus",Description=" ",},
            new Unit{ID=3141,Name="Trigonometry",Description=" ",},
            new Unit{ID=2021,Name="Composition",Description=" ",},
            new Unit{ID=2042,Name="Literature",Description=" ",}
            };
            units.ForEach(s => context.Units.Add(s));
            context.SaveChanges();
        }
    }
}