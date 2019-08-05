using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public class Model:INotifyPropertyChanged
    {
        #region Fields

        private string name;

        private string contactNumber;

        #endregion

        #region Constructor

        public Model(string CustomerName, string CustomerNumber)
        {
            Name = CustomerName;
            ContactNumber = CustomerNumber;
        }
        
        #endregion

        #region Properties

        public string Name
        {
            get { return name; }
            set
            {
                this.name = value;
                OnPropertyChanged("Name");
            }
        }

        public string ContactNumber
        {
            get { return contactNumber; }
            set
            {
                this.contactNumber = value;
                OnPropertyChanged("ContactNumber");
            }
        }

        #endregion

        #region Interface Methods

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
