using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectModelLibrary;
using ProjectModelLibrary.Data;

namespace ProjectModelLibrary.UnitTests
{
    [TestClass]
    public class DbContextTests
    {
        [TestMethod]
        public void ReadProjects()
        {
            ProjectModelDbContext ctx = new ProjectModelDbContext();

            var p = ctx.Projects;

            Assert.IsNotNull(p);
        }

        [TestMethod]
        public void AddProject()
        {
            ProjectModelDbContext ctx = new ProjectModelDbContext();

            ProjectDbModel p = new ProjectDbModel();

            p.Id = Guid.NewGuid();
            p.Name = "foo";
            p.Version = "0.0.0.1";
            p.ModelType = 0;

            p = ctx.Projects.Add(p);

            ctx.SaveChanges();

            Assert.IsNotNull(p);
        }
    }
}
