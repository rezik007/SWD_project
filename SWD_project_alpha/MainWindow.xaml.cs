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
        public int smallDays = 0, mediumDays = 0, longDays = 0;
        public int horse50 = 0, horse100 = 0, horse150 = 0, horse200 = 0;
        public int seats4 = 0, seats5 = 0, seats7 = 0;
        public int gearType = 0; //domyslnie manualna skrzynia
        public string tableString;
        public int[] tableBits;
        public int[] factsTable = new int[10];

        public MainWindow()
        {
            InitializeComponent();
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {


        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            double numberOfDays = ((data2.SelectedDate) - (data1.SelectedDate)).Value.TotalDays;
            if (numberOfDays<1)
                MessageBox.Show("Wybierz poprawna liczbe dni");
            else if ((numberOfDays > 0) && (numberOfDays < 4))
                smallDays = 1;
            else if ((numberOfDays > 3) && (numberOfDays < 7))
                mediumDays = 1;
            else if (numberOfDays > 6)
                longDays = 1;

           // MessageBox.Show(numberOfDays.ToString());
            
            if (checkBox.IsChecked == true)
                gearType = 1; // jak zaznaczone to automat
            switch (comboBox.SelectedIndex) //wybor mocy silnika
            {
                case 0:
                    horse50 = 1;
                    break;

                case 1:
                    horse100 = 1;
                    break;

                case 2:
                    horse150 = 1;
                    break;

                case 3:
                    horse200 = 1;
                    break;
            }
            switch (comboBox2.SelectedIndex) //wybor ilosci siedzen
            {
                case 0:
                    seats4 = 1;
                    break;

                case 1:
                    seats5 = 1;
                    break;

                case 2:
                    seats7 = 1;
                    break;
            }
            // this.tableStart();
     
        }
        private void tableStart()
        {
            for (int i = 0; i < 2048; i++)
            {
                tableString = Convert.ToString(i, 2); //Convert to binary in a string
                tableBits = tableString.PadLeft(11, '0') // Add 0's from left
                             .Select(c => int.Parse(c.ToString())) // convert each char to int
                             .ToArray(); // Convert IEnumerable from select to Array
                                         //table_counter = table_counter << 1 ;
                                         //sprawdzanie faktow
                if (tableBits[0] == 1)//tutaj pisezemy caly pojedynczy fakt
                    factsTable[0] = 1; // i jesli jest spelniony to wstawiamy jedynke (to samo dla Fy)
                else if (tableBits[1] == 1)
                    factsTable[1] = 0;

            }
            // MessageBox.Show(ta.ToString());

        }
    }
}
