using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
using Lib_1;

namespace WPF_PR5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Car car = new Car();
        //int kol = 0;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void VivodButton_Click(object sender, RoutedEventArgs e)
        {
            textBoxOutLog.Text = $"Марка: {car.Marka ?? "Без названия"}"+
                $"\nКол-во целиндров: {car.NumOfCylinders}"
                +$"\nМощность двигателя в Л.С.: {car.HorsePower}"
                +$"\nМощность двигателя в  кВт: {car.KW}";
        }
        private void ZapisButton_Click(object sender, RoutedEventArgs e)
        {
            double kW;
            int numCylinders;

            if (int.TryParse(textBoxNumCylinders.Text, out numCylinders) && double.TryParse(textBoxkW.Text, out kW))
            {
                car.SetParams(textBoxMarka.Text, numCylinders, kW);
            }
            else if (int.TryParse(textBoxNumCylinders.Text, out numCylinders))
            {
                car.KW = new double();
                car.SetParams(textBoxMarka.Text, numCylinders);
            }
            else if (double.TryParse(textBoxkW.Text, out kW))
            {
                car.NumOfCylinders = new int();
                car.SetParams(textBoxMarka.Text, kW);
            }
            else
            {
                car.SetParams(textBoxMarka.Text, new int(), new double());
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}