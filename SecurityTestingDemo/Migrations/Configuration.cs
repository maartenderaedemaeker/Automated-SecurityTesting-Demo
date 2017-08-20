using SecurityTestingDemo.Models;

namespace SecurityTestingDemo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SecurityTestingDemo.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "SecurityTestingDemo.Models.ApplicationDbContext";
        }

        protected override void Seed(Models.ApplicationDbContext context)
        {
            context.Employees.AddOrUpdate(x => x.Id,
                new Employee
                {
                    Id = new Guid("1e4a431c-fd17-4c69-82cc-162d6a1ad63e"),
                    DateOfBirth = new DateTime(1971, 1, 1),
                    Name = "User 1",
                    PhoneNumber = "+33554468942",
                    SupervisorId = new Guid("148d370f-cb2d-4865-8525-32bfb6a86121")
                },
                new Employee
                {
                    Id = new Guid("299059e9-c49c-412c-8111-ceabd3d5281d"),
                    DateOfBirth = new DateTime(1982, 2, 2),
                    Name = "User 2",
                    PhoneNumber = "+43554488944",
                    SupervisorId = new Guid("e8ea781a-c077-495b-9887-41528d45b242")
                },
                new Employee
                {
                    Id = new Guid("54035cd8-7d18-479f-a6ef-47d6f73b3a24"),
                    DateOfBirth = new DateTime(1993, 3, 3),
                    Name = "User 3",
                    PhoneNumber = "+49554486844",
                    SupervisorId = new Guid("148d370f-cb2d-4865-8525-32bfb6a86121")
                }
            );
        }
    }
}
