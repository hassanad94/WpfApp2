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
    /// Interaction logic for NewPacientWindow.xaml
    /// </summary>
    ///
   
    public partial class NewPacientWindow : Window
    {
        public NewPacientWindow()
        {
            InitializeComponent();
          
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            var pacientVM = (PacientFormViewModel)DataContext;
           



            if (pacientVM.ValidTaj())
            {
                MessageBox.Show("Hibás adatbevitel");
                return;

            }
            Close();
        }
    }
}
