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
using System.Windows.Media.Animation;

namespace CalculateProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PhisicButton.Width = 0;
        }

        private void PhisicName_Click(object sender, RoutedEventArgs e)
        {

            PhisicWindow phisicWindow = new PhisicWindow();
            phisicWindow.Show();
            MainWindow mainWindow = new MainWindow();
            this.Close();

        }
        private void AnimationButton_Click(object sender, RoutedEventArgs e)
        {
            bool counter;
            do
            {
                counter = true;
                DoubleAnimation VisiblAnimation = new DoubleAnimation();
                VisiblAnimation.From = PhisicButton.ActualWidth;
                VisiblAnimation.To = 220;
                VisiblAnimation.Duration = TimeSpan.FromSeconds(1);
                PhisicButton.BeginAnimation(Button.WidthProperty, VisiblAnimation);
                VisiblAnimation.From = AnimationButton.ActualWidth;
                VisiblAnimation.To = 0;
                AnimationButton.BeginAnimation(Button.WidthProperty, VisiblAnimation);
                counter = false;
            } while (counter);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
