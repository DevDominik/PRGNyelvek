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
using System.IO;

namespace WPFProgramozasiNyelvekNyilvantartas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<string> konvertalt = new List<string>() { };
            foreach (string item in Enum.GetNames(typeof(nyelvcsaladok)))
            {
                konvertalt.Add(item);
            }
            cbCsalad.ItemsSource = konvertalt;
            
        }

        private void Rogzites(object sender, RoutedEventArgs e)
        {
            string mentesHelye = AppDomain.CurrentDomain.BaseDirectory + "mentes";
            StreamWriter sw;
            if (!Directory.Exists(mentesHelye))
            {
                Directory.CreateDirectory(mentesHelye);
                sw = new StreamWriter(mentesHelye + "\\nyelvek.txt");
                sw.Close();
            }
            StreamReader sr = new StreamReader(mentesHelye+"\\nyelvek.txt");
            sw = new StreamWriter(mentesHelye + "\\nyelvek.txt");
            sw.Write($"{sr.ReadToEndAsync}\n{tbNev.Text};{}");
            sw.Close();
            sr.Close();

            MessageBox.Show("Sikeresen rögzítve");
        }
    }
}
