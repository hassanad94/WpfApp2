using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
     public class MainWindowViewModel:BaseModel
    {
        public ObservableCollection<Pacient> PacientList { get; set; }
        public Pacient SelectedPacient { get; set; }
        public Pacient Pacient { get; set; }
       



        public MainWindowViewModel()
        {

           PacientList = new ObservableCollection<Pacient> {
                new Pacient{Name="Kecske", Bplace="Tatabánya", Date=DateTime.Now,Taj=095007997 },
                new Pacient{Name="Teve", Bplace="Sahara", Date=DateTime.Now,Taj=095007997 }
            };

            
        }

        public bool Budapest(string bplace )
        {
           

            if (bplace == "Budapest")
            { return true; }
            else
            { return false; }

        }

        
        
        public bool Overage(int age)
        {
            

            if (age >= 18)
            { return true; }
            else
                return false;
        }

        
    }
}
