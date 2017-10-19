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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        readonly MainWindowViewModel _vm;
        public MainWindow()
        {
            InitializeComponent();
            _vm = new MainWindowViewModel();
            DataContext = _vm;
        }

        private void New_Pacient(object sender, RoutedEventArgs e)
        {
            PacientFormViewModel viewModel = new PacientFormViewModel(new Pacient()) { IsNew = true };
            NewPacientWindow pacientWindow = new NewPacientWindow {DataContext = viewModel };
            pacientWindow.Show();
            var pacientList = _vm.PacientList;
            pacientList.Add(viewModel.Pacient);
        }

        private void DataMod_Clik(object sender, RoutedEventArgs e)
        {
            if (_vm.SelectedPacient != null)
            {
                PacientFormViewModel viewmodel = new PacientFormViewModel(_vm.SelectedPacient);
                NewPacientWindow pwindow = new NewPacientWindow { DataContext = viewmodel };
               
                pwindow.ShowDialog();

            }

        }

        

        private void Handler_Click(object sender, RoutedEventArgs e)
        {

            if (_vm.SelectedPacient != null)
            {
                PacientFormViewModel viewmodel = new PacientFormViewModel(_vm.SelectedPacient);
                HandlerWindow hwindow = new HandlerWindow { DataContext =viewmodel };
                hwindow.ShowDialog();

            }
        }
    }
}
