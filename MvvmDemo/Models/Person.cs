using System;
using System.ComponentModel;

namespace MvvmDemo.Models
{
    public class Person :INotifyPropertyChanged
    {
        public Person()
        {
            
        }
        public string _name;   
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
                OnPropertyChanged("FullName");
            }
        }
        public string _lastname;
        public string LastName
        {
            get { return _lastname; }
            set
            {
                _lastname = value;
                OnPropertyChanged("LastName");
                OnPropertyChanged("FullName");

            }
        }


        public string _fullName;
        public string FullName
        {
            get { return _fullName; }
            set
            {
                _fullName = value;
                OnPropertyChanged("FullName");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged( string propertyName)
        {
            if(PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
