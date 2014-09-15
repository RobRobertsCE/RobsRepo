using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassBuilder.Data;
using ClassBuilder.Mappers;
using System.Data.Common;

namespace ClassBuilder.Project
{
    public class ProjectManager : ClassBuilder.Project.IProjectManager
    {
        private readonly ClassBuilderDbContext dataStore;

        public ProjectManager()
            : this(new ClassBuilderDbContext())
        {

        }

        public ProjectManager(ClassBuilderDbContext context)
        {
            this.dataStore = context;
        }

        public IProject GetProject(int key)
        {
            var model = dataStore.Projects.Find(key);

            return ProjectMapper.ToProject(model);
        }

        public IProject GetNewProject(string name, string rootNamespace)
        {
            return new ClassBuilderProject(name, rootNamespace);
        }

        public void DeleteProject(int key)
        {
            var model = dataStore.Projects.Find(key);

            dataStore.Projects.Remove(model);

            dataStore.SaveChanges();
        }

        public IProject SaveProject(IProject project)
        {
            if (project.ProjectKey == 0)
            {
                return SaveNewProject(project);
            }
            else
            {
                return UpdateProject(project);
            }
        }

        internal IProject SaveNewProject(IProject project)
        {
            var model = dataStore.Projects.Add(ProjectMapper.ToModel(project));

            foreach (ClassModel classModel in model.Classes)
            {
                dataStore.Entry(classModel).State = System.Data.Entity.EntityState.Added;

                foreach (ClassMemberModel memberModel in classModel.Members)
                {

                    dataStore.Entry(memberModel).State = System.Data.Entity.EntityState.Added;

                }
            }

            dataStore.SaveChanges();

            return ProjectMapper.ToProject(model);
        }

        internal IProject UpdateProject(IProject project)
        {
            var model = dataStore.Projects.Attach(ProjectMapper.ToModel(project));

            dataStore.Entry(model).State = System.Data.Entity.EntityState.Modified;

            foreach (ClassModel classModel in model.Classes)
            {
                dataStore.Entry(classModel).State = System.Data.Entity.EntityState.Modified;

                foreach (ClassMemberModel memberModel in classModel.Members)
                {

                    dataStore.Entry(memberModel).State = System.Data.Entity.EntityState.Modified;

                }
            }

            dataStore.SaveChanges();

            return ProjectMapper.ToProject(model);
        }
    }
}
