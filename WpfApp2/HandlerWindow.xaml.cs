using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for HandlerWindow.xaml
    /// </summary>
    public partial class HandlerWindow : Window
    {
        readonly MainWindowViewModel _vm;
       
        public HandlerWindow()
        {
            InitializeComponent();
            _vm = new MainWindowViewModel();
            
            DataContext = _vm;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

            Close();
        }

        private void Stat_Clik(object sender, RoutedEventArgs e)
        {
        
            MessageBox.Show("Átlag életkor"+_vm.PacientList.Average(x => x.Age).ToString());
            MessageBox.Show("Felvett Betegek Száma \t" + _vm.PacientList.Count(x => x.Name!=null));
        }
    }
}
