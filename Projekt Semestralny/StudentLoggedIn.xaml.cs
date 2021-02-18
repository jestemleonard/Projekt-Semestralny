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

namespace Projekt_Semestralny
{
    /// <summary>
    /// Interaction logic for StudentLoggedIn.xaml
    /// </summary>
    public partial class StudentLoggedIn : Window
    {
        public StudentLoggedIn()
        {
            InitializeComponent();
        }

        private SzkolaEntities db = new SzkolaEntities();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Index_Initialized(object sender, EventArgs e)
        {
            var uczniowie = db.Uczniowies;
            foreach(var uczen in uczniowie)
            {
                Index.Items.Add(uczen.Legitymacja);
            }
        }

        private void Index_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ChangeAllTextBoxes(Index.SelectedIndex+1);
        }

        private void ChangeAllTextBoxes(int index)
        {
            var uczniowie = db.Uczniowies;
            foreach(var uczen in uczniowie)
            {
                if(uczen.Legitymacja == index)
                {
                    SImie.Content = uczen.S_Imie;
                    SNazwisko.Content = uczen.S_Nazwisko;
                    SGrupa.Content = uczen.Nazwa_Grupy;
                    SRok.Content = uczen.Grupa.Rok;
                    SKierunek.Content = uczen.Grupa.Kierunek;
                }
            }
            var oceny = db.Ocenies;
            SOceny.Text = "";
            foreach (var ocena in oceny)
            {
                if (ocena.Legitymacja == index)
                {
                    SOceny.Text += ocena.Nazwa_Przedmiotu + ": " + ocena.Ocena.ToString() + "\n";
                }
            }
        }
    }
}
