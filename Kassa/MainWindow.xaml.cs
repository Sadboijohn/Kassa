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

        private void TxtOndernemingsnummer_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtPrijs_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtAantal_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtTeBetalen_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnControleNummer_Click(object sender, RoutedEventArgs e)
        {

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

        }

        private void BtnSluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
