﻿using System;
using System.Windows;
using System.Windows.Controls;

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
            try
            {
                Voltage = Convert.ToDouble(VoltageTextBox.Text);
                Power = Convert.ToDouble(PowerTextBox.Text);
                ResistanceElecMethod(Voltage, Power, ref Result);
                if (OkrSot.IsChecked == true)
                {
                    ResultTextBox.Text = String.Format("{0:0.00}", Result);
                }
                else ResultTextBox.Text = Convert.ToString(Result);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введи числа");
            }

        }
        public void ResistanceElecMethod(double volt, double pow, ref double result)
        {
            result = volt/pow;
        }
        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            VoltageTextBox.Text = "";
            PowerTextBox.Text = "";
            ResultTextBox.Text = "";
            OkrSot.IsChecked = false;

        }

        private void PowerTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ResultButton.IsEnabled = PowerTextBox.Text.Length != 0 && VoltageTextBox.Text.Length != 0;
        }

        private void VoltageTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ResultButton.IsEnabled = PowerTextBox.Text.Length != 0 && VoltageTextBox.Text.Length != 0;
        }

        private void OkrSot_Checked(object sender, RoutedEventArgs e)
        {

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
            ResistanceElec resistanceElec = new ResistanceElec();
            Close();
            ElecWindow elecWindow = new ElecWindow();
            elecWindow.Show();
        }
    }
}
