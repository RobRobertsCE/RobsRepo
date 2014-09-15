using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassBuilder.Data;
using ClassBuilder.Models;
using ClassBuilder.Project;

namespace ClassBuilder.Mappers
{
    internal static class ProjectMapper
    {
        internal static ProjectModel ToModel(IProject project)
        {
            return new ProjectModel();
        }

        internal static IProject ToProject(ProjectModel model)
        {
            ClassBuilderProject project = new ClassBuilderProject(model.ProjectKey, model.Name, model.RootNamespace);

            foreach (ClassModel classModel in model.Classes)
            {
                project.DTObjects.Add(DTOMapper.ToDTObject(classModel));
            }
            
            return project;
        }
    }
}
