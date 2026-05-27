using MedicalSystemMVVM.ViewModels;
using System.Windows;

namespace MedicalSystemMVVM
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainViewModel();
        }
    }
}