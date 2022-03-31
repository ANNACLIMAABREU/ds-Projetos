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

namespace ProjetoSistemasUm
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btAcessar_Click(object sender, RoutedEventArgs e)
        {
           
            string usuario = txtUser.Text;
            string senha = txtSenha.Password.ToString();

            if (usuario == "Anna" && senha == "147")
            {
                MessageBox.Show("Logado.");
                Calculadora calculadora = new Calculadora();
                calculadora.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("usuario e/ou senha iválida! Tente novamente.");
                txtUser.Clear();
                txtSenha.Clear();
                txtUser.Focus();
            }

        }
    }
}
