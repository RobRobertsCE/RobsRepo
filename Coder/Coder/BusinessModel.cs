using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Coder
{
    public class BusinessModel
    {
        #region properties
        public string Name { get; set; }
        public BindingList<PropertyModel> Properties { get; set; }
        #endregion

        #region ctor
        public BusinessModel()
        {
            this.Name = "new model";
        }
        public BusinessModel(string name)
        {
            this.Name = name;
        }
        #endregion

        #region load/save
        public void Save(string fileName)
        {
            string jsonData = JsonConvert.SerializeObject(this);
            System.IO.File.WriteAllText(fileName, jsonData);
        }

        public static BusinessModel Load(string fileName)
        {
            string jsonData = System.IO.File.ReadAllText(fileName);
            return JsonConvert.DeserializeObject<BusinessModel>(jsonData);
        } 
        #endregion

        #region overrides
        public override string ToString()
        {
            return this.Name;
        } 
        #endregion
    }
}
