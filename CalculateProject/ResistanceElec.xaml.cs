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

namespace CalculateProject
{
    /// <summary>
    /// Логика взаимодействия для ResistanceElec.xaml
    /// </summary>
    public partial class ResistanceElec : Window
    {
        static double Voltage;
        static double Power;
        static double Result;
        public ResistanceElec()
        {
            InitializeComponent();
            ResultButton.IsEnabled = false;
        }

        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            Voltage = Convert.ToDouble(VoltageTextBox.Text);
            Power = Convert.ToDouble(PowerTextBox.Text);
            ResistanceElecMethod(Voltage, Power, ref Result);
            ResultTextBox.Text = Convert.ToString(Result);

        }
        public void ResistanceElecMethod(double volt, double pow, ref double result)
        {
            result = volt/pow;// + (volt % res);

        }
        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            VoltageTextBox.Text = "";
            PowerTextBox.Text = "";
            ResultTextBox.Text = "";

        }

        private void PowerTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ResultButton.IsEnabled = PowerTextBox.Text.Length != 0 && VoltageTextBox.Text.Length != 0;
        }

        private void VoltageTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ResultButton.IsEnabled = PowerTextBox.Text.Length != 0 && VoltageTextBox.Text.Length != 0;
        }
    }
}
