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
    /// Interaction logic for ProwadzacyLoggedIn.xaml
    /// </summary>
    public partial class ProwadzacyLoggedIn : Window
    {
        public ProwadzacyLoggedIn()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private SzkolaEntities db = new SzkolaEntities();

        private void Index_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ChangeAllTextBoxes();
        }
        private void Group_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ChangeAllTextBoxes();
        }

        private void Index_Initialized(object sender, EventArgs e)
        {
            var prowadzacy = db.Prowadzacies;
            foreach (var prow in prowadzacy)
            {
                Index.Items.Add(prow.Prowadzacy_ID);
            }
        }

        private void Group_Initialized(object sender, EventArgs e)
        {
            var grupy = db.Grupas;
            foreach (var grupa in grupy)
            {
                Group.Items.Add(grupa.Nazwa_Grupy);
            }
        }

        private void ChangeAllTextBoxes()
        {
            int index = Index.SelectedIndex + 1;
            var prowadzacy = db.Prowadzacies;
            foreach (var prow in prowadzacy)
            {
                if (prow.Prowadzacy_ID == index)
                {
                    PImie.Content = prow.P_Imie;
                    PNazwisko.Content = prow.P_Nazwisko;
                }
            }
            var przedmioty = db.Przedmioties;
            foreach (var przedmiot in przedmioty)
            {
                if (przedmiot.Prowadzacy_ID == Index.SelectedIndex + 1)
                    OcenyLabel.Content = "Oceny " + przedmiot.Nazwa_Przedmiotu.ToString();
            }

            POceny.Text = "";
            var uczniowie = db.Uczniowies;
            foreach (var uczen in uczniowie)
            {
                if (Group.SelectedItem != null && uczen.Nazwa_Grupy == Group.SelectedItem.ToString())
                {
                    var tempGrade = "";
                    var oceny = db.Ocenies;
                    foreach (var ocena in oceny)
                    {
                        if (ocena.Legitymacja == uczen.Legitymacja && ocena.Przedmioty.Prowadzacy_ID == Index.SelectedIndex + 1)
                        {
                            tempGrade = ocena.Ocena.ToString();
                        }
                    }
                    string[] arr = { uczen.Legitymacja.ToString(), uczen.S_Imie.ToString(), uczen.S_Nazwisko.ToString(), tempGrade.ToString() };
                    POceny.Text += String.Join(" ", arr) + "\n";
                }
            }
        }
    }
}
