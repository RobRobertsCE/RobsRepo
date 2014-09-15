using System;
namespace ClassBuilder.Project
{
    public interface IProjectManager
    {
        void DeleteProject(int key);
        ClassBuilder.IProject GetNewProject(string name, string rootNamespace);
        ClassBuilder.IProject GetProject(int key);
        ClassBuilder.IProject SaveProject(ClassBuilder.IProject project);
    }
}
