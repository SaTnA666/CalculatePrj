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
using System.Windows.Media.Animation;

namespace CalculateProject
{
    /// <summary>
    /// Логика взаимодействия для PhisicWindow.xaml
    /// </summary>
    public partial class PhisicWindow : Window
    {
       // PhisicWindow phisicWindow = new PhisicWindow(); Разобраться в определении форм во всем проекте
        
        public PhisicWindow()
        {
            InitializeComponent();
           
        }
       // PhisicWindow phisicWindow = new PhisicWindow();
        private void ElecButton_Click(object sender, RoutedEventArgs e)
        {

            PhisicWindow phisicWindow = new PhisicWindow();
            this.Close();
            ElecWindow elecWindow = new ElecWindow();
            elecWindow.Show();
           
        }

        private void BackToMain_Click(object sender, RoutedEventArgs e)
        {
            PhisicWindow phisicWindow = new PhisicWindow();
            this.Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            //phisicWindow.Close();

        }

       
    }
}
