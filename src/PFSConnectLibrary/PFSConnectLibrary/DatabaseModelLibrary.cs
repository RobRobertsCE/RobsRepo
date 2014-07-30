using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace PFSConnectLibrary
{
    public class DatabaseModelLibrary :  Component, IListSource, INotifyPropertyChanged 
    {
        #region fields
        private BindingList<DatabaseModel> models;

        #endregion
        
        #region properties
        public DatabaseModel DefaultDatabase
        {
            get
            {
                return models.FirstOrDefault(m => m.IsDefault == true);
            }
        }
        
        #endregion

        #region ctor
        public DatabaseModelLibrary()
        {
            models = new BindingList<DatabaseModel>();
        }

        public DatabaseModelLibrary(BindingList<DatabaseModel> models)
        {
            this.models = models;
        }
        
        #endregion

        #region public methods
        public void SetDefaultDatabaseModel(DatabaseModel model)
        {
            MarkAllAsNotDefault();

            MarkAsDefault(model);
        }

        public void SetDefaultDatabaseModel(int idx)
        {
            MarkAllAsNotDefault();

            MarkAsDefault(models[idx]);
        }

        void MarkAsDefault(DatabaseModel model)
        {
            model.IsDefault = true;
            PropertyChanged(this, new PropertyChangedEventArgs("DefaultDatabase"));
        }

        private void MarkAllAsNotDefault()
        {
            foreach (DatabaseModel dbModel in models)
            {
                dbModel.IsDefault = false;
            }
        }
        
        #endregion

        #region IList implementation
        //public IEnumerator<DatabaseModel> GetEnumerator()
        //{
        //    return models.GetEnumerator();
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return models.GetEnumerator(); 
        //}

        public int IndexOf(DatabaseModel item)
        {
            return models.IndexOf(item);
        }

        public void Insert(int index, DatabaseModel item)
        {
            models.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            models.RemoveAt(index);
        }

        public DatabaseModel this[int index]
        {
            get
            {
                return models[index];
            }
            set
            {
                models[index] = value;
            }
        }

        public void Add(DatabaseModel item)
        {
            models.Add(item);
        }

        public void Clear()
        {
            models.Clear();
        }

        public bool Contains(DatabaseModel item)
        {
            return models.Contains(item);
        }

        public void CopyTo(DatabaseModel[] array, int arrayIndex)
        {
            models.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return models.Count; }
        }
        
        public bool Remove(DatabaseModel item)
        {
            return models.Remove(item);
        }

        #endregion
        
        public event PropertyChangedEventHandler PropertyChanged;

        public bool ContainsListCollection
        {
            get { return false; }
        }

        public IList GetList()
        {
            return (BindingList<DatabaseModel>)models;
        }
    }
}
