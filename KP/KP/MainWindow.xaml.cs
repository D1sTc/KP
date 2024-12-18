using System;
using System.Collections.Generic;
using System.IO.Ports;
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

namespace KP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        private SerialPort serialPort;

        public MainWindow()
        {
            InitializeComponent();
            serialPort = new SerialPort("COM5", 9600); // Измените на ваш порт и настройки
            serialPort.Open();
        }

        private void ButtonCustomizationGY_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonCustomizationParkSensor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void exit_click(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void ActivateGY_Checked(object sender, RoutedEventArgs e)
        {
            serialPort.WriteLine("ACTIVATE_GY"); // Отправляем команду активации
        }

        private void DeactivateGY_Checked(object sender, RoutedEventArgs e)
        {
            serialPort.WriteLine("DEACTIVATE_GY"); // Отправляем команду деактивации
        }

        private void ActivateParkingSensors_Checked(object sender, RoutedEventArgs e)
        {
            serialPort.WriteLine("ACTIVATE_US"); // Отправляем команду активации ультразвукового датчика
        }

        private void DeactivateParkingSensors_Checked(object sender, RoutedEventArgs e)
        {
            serialPort.WriteLine("DEACTIVATE_US"); // Отправляем команду деактивации ультразвукового датчика
        }
    }
}
