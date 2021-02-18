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

namespace Projekt_Semestralny
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private SzkolaEntities db = new SzkolaEntities();

        private void OnStudentClick(object sender, RoutedEventArgs e)
        {
            new StudentLoggedIn().Show();
            this.Close();
        }

        private void OnProwadzacyClick(object sender, RoutedEventArgs e)
        {
            new ProwadzacyLoggedIn().Show();
            this.Close();
        }
    }
}
