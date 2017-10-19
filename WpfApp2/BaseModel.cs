using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp2
{
    public class BaseModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChange([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs(propertyName));
        }
    }
}