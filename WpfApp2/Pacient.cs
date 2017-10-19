using System;

namespace WpfApp2
{
    public class Pacient : BaseModel
    {

        string _name;
        string _bplace;
        DateTime _date;
        int _age;
        int _taj;
        

        public string Name
        {
            get => _name;
            set { _name = value;OnPropertyChange(); }
        }

        public string Bplace
        {
            get => _bplace;
            set { _bplace = value; OnPropertyChange(); }
        }
           
        public int Age
        {
            get => _age;
            set { _age = DateTime.Now.Year- _date.Year; OnPropertyChange(); }

        }

        public int Taj {
            get => _taj;
            set { _taj = value;OnPropertyChange(); }
        }

        public DateTime Date {
            get => _date;
            set { _date = value;OnPropertyChange(); }

        }
       
    }
}