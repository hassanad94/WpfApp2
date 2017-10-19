using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WpfApp2
{
   public class PacientFormViewModel : BaseModel
    {
        public Pacient Pacient { get; set; }
      
        public bool IsNew { get; set;}
        Pacient pacient;
        

        public PacientFormViewModel(Pacient Pacient)
        {
            this.Pacient = Pacient;
            if (!IsNew) { Save(); }

        }

        public void Save() {
            var dage = DateTime.Now.Year - Pacient.Date.Year;

            if (!IsNew)
            {
                pacient = new Pacient { Name = Pacient.Name, Bplace = Pacient.Bplace, Date = Pacient.Date, Age = dage, Taj = Pacient.Taj, };
            }   

        }

        public bool ValidTaj()
        {
            Regex regex = new Regex("[^0-9.-]+");
            return !regex.IsMatch(pacient.Taj.ToString()) && pacient.Taj.ToString().Length==9;

        }


    }
}
