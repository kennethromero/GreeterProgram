using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace GreeterProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            List<string> colors = new List<string>()
         {
            "White",
            "Green",
            "Red",
            "Black",
            "Blue"
        };
            ___cboColor_.ItemsSource = colors;


        }

        private void ___btn_Enter__Click(object sender, RoutedEventArgs e)
        {
            string fullName = ___txtFirstName_.Text + " " + ___txtLastName_.Text;

            MessageBox.Show(" Hello " + fullName + " , good afternoon!" + ___cboColor_.SelectedItem);

        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }

}



       