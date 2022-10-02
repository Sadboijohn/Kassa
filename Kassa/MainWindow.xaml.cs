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

namespace Kassa
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

     

        private void BtnControleNummer_Click(object sender, RoutedEventArgs e)
        {
            float ondernemingsNummer = Convert.ToSingle(TxtOndernemingsnummer.Text);
            ondernemingsNummer = ondernemingsNummer % 97;
            float controleNummer = 97 - ondernemingsNummer;
            TxtControleNummer.Text= controleNummer.ToString();
        }
        private void BtnBerekenen_Click(object sender, RoutedEventArgs e)
        {

            float prijs = Convert.ToSingle(TxtPrijs.Text);
            float aantal = Convert.ToSingle(TxtAantal.Text);
            float teBetalen = prijs * aantal;
            TxtTeBetalen.Text = Convert.ToString(teBetalen);

        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            TxtOndernemingsnummer.Text = "";
            TxtPrijs.Text = "";
            TxtAantal.Text = "";
            TxtTeBetalen.Text = "";
            TxtControleNummer.Text = "";

        }

        private void BtnSluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
