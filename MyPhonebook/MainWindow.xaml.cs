using MyPhonebook.ViewModels;
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

namespace MyPhonebook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PhonebookViewModel _viewModel;
        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new PhonebookViewModel();
            DataContext = _viewModel;
        }

        private void OnSearchChanged(object sender, TextChangedEventArgs e)
        {
            var search = ((TextBox)sender).Text;
            _viewModel.Search(search);
        }
    }
}
