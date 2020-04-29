﻿using System;
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
    /// Логика взаимодействия для PowerElec.xaml
    /// </summary>
    public partial class PowerElec : Window
    {
        static double Voltage;
        static double Resistance;
        //static int Resistance;
        static double Result;
        public PowerElec()
        {

            InitializeComponent();
            ResultButton.IsEnabled = false;

        }

       public void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Resistance = Convert.ToDouble(ResistanceTextBox1.Text);
                Voltage = Convert.ToDouble(VoltageTextBox1.Text);
                PowerElecMethod(Voltage, Resistance, ref Result);
                //RadioButton radio = new RadioButton();
                if (OkrSot.IsChecked == true)
                {
                    ResultTextBox1.Text = String.Format("{0:0.00}", Result);
                }
                else ResultTextBox1.Text = Convert.ToString(Result);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введи числа");
            }
        }
        public void PowerElecMethod(double volt,double res,ref double result)
        {
            result = (volt / res);// + (volt % res);
           
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            ResistanceTextBox1.Text = "";
            VoltageTextBox1.Text = "";
            ResultTextBox1.Text = "";
            OkrSot.IsChecked = false;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
           /* RadioButton radio = (RadioButton)sender;
            if (radio.IsChecked == true)
            {
                ResultTextBox1.Text = String.Format("{0:0.00}",Result);
            }
            //else ResultTextBox1.Text = Convert.ToString(Result);*/
        }

        private void ResistanceTextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
           
            ResultButton.IsEnabled = ResistanceTextBox1.Text.Length != 0 && VoltageTextBox1.Text.Length != 0;
        }

        private void VoltageTextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            ResultButton.IsEnabled = ResistanceTextBox1.Text.Length != 0 && VoltageTextBox1.Text.Length != 0;
        }

        private void BackToMain_Click(object sender, RoutedEventArgs e)
        {
            PhisicWindow phisicWindow = new PhisicWindow();
            this.Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            PowerElec powerElec = new PowerElec();
            Close();
            ElecWindow elecWindow = new ElecWindow();
            elecWindow.Show();
        }
    }
}
