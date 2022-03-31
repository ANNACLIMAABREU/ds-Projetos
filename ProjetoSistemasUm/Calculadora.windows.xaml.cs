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

namespace ProjetoSistemasUm
{
    /// <summary>
    /// Lógica interna para Calculadora.xaml
    /// </summary>
    public partial class Calculadora : Window
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btDivisao_Click(object sender, RoutedEventArgs e)
        {
            double n1 = Convert.ToDouble(txtN1.Text);
            double n2 = Convert.ToDouble(txtN2.Text);

            double rest = n1 / n2;
            txtResult.Text = Convert.ToString(rest);
        }

        private void btSubtract_Click(object sender, RoutedEventArgs e)
        {
            double n1 = Convert.ToDouble(txtN1.Text);
            double n2 = Convert.ToDouble(txtN2.Text);

            double rest = n1 - n2;
            txtResult.Text = Convert.ToString(rest);
        }

        private void btMult_Click(object sender, RoutedEventArgs e)
        {
            double n1 = Convert.ToDouble(txtN1.Text);
            double n2 = Convert.ToDouble(txtN2.Text);

            double rest = n1 * n2;
            txtResult.Text = Convert.ToString(rest);
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            double n1 = Convert.ToDouble(txtN1.Text);
            double n2 = Convert.ToDouble(txtN2.Text);

            double rest = n1 + n2;
            txtResult.Text = Convert.ToString(rest);
        }

        private void btX_Click(object sender, RoutedEventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            txtResult.Clear();
        }
    }
}
