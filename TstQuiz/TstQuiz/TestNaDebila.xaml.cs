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

namespace TstQuiz
{
    /// <summary>
    /// Interaction logic for TestNaDebila.xaml
    /// </summary>
    public partial class TestNaDebila : Window
    {
        
            public TestNaDebila()
            {
                InitializeComponent();
            }

            private void FirstYes_Click(object sender, RoutedEventArgs e)
            {

                MessageBox.Show("Molodec");
                this.Close();
                TestNaDebila2 testNaDebila2 = new TestNaDebila2();
                testNaDebila2.ShowDialog();





            }

            private void FirstNo_Click(object sender, RoutedEventArgs e)
            {
                MessageBox.Show("Ne Molodec");
            }

            private void FirstNox2_Click(object sender, RoutedEventArgs e)
            {
                MessageBox.Show("Ne Molodec");
            }
        
    }
}
