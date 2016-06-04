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

namespace SWD_project_alpha
{
    /// <summary> OOOLLAAAAaaa
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
                MessageBox.Show("HELLO WORLD");
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(((data2.SelectedDate)-(data1.SelectedDate)).Value.TotalDays.ToString());
            int a = 100, b = 100;
            int[,] tablica = new int[a, b];
            tablica[0,0] = 1;
            

        }
    }
}
