using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Coder
{
    public class ProjectModel
    {
        #region properties
        public string Name { get; set; }
        public BindingList<BusinessModel> Models { get; set; }
        #endregion

        #region ctor
        public ProjectModel()
        {
            this.Models = new BindingList<BusinessModel>();
        }
        #endregion

        #region load/save
        public void Save(string fileName)
        {
            string jsonData = JsonConvert.SerializeObject(this);
            System.IO.File.WriteAllText(fileName, jsonData);
        }

        public static ProjectModel Load(string fileName)
        {
            string jsonData = System.IO.File.ReadAllText(fileName);
            return JsonConvert.DeserializeObject<ProjectModel>(jsonData);
        }
        #endregion

        public override string ToString()
        {
            return this.Name;
        }
    }
}
