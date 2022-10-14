
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using WpfApp_Navigation.Models;
using WpfApp_Navigation.ViewModels;

namespace WpfApp_Navigation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private ViewModelBase currentView;
        public ViewModelBase CurrentView
        {
            get => currentView; 
            set {
                currentView = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentView"));             
            }
        }

       
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            CurrentView = new HomeViewModel();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void HomeButtonClick(object sender, RoutedEventArgs e)
        {
            CurrentView = new HomeViewModel();
        }

        private void AboutButtonClick(object sender, RoutedEventArgs e)
        {
            CurrentView = new AboutViewModel();
        }

        private void SettingButtonClick(object sender, RoutedEventArgs e)
        {
            CurrentView = new SettingViewModel();
        }
    }
}
