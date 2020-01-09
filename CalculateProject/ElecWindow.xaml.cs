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
    /// Логика взаимодействия для ElecWindow.xaml
    /// </summary>
    public partial class ElecWindow : Window
    {
        public ElecWindow()
        {
            InitializeComponent();
        }

        private void ResistanceElec_Click(object sender, RoutedEventArgs e)
        {
            ResistanceElec resistanceElec = new ResistanceElec();
            resistanceElec.Show();
            ElecWindow elecWindow = new ElecWindow();
            Close();
        }

        private void PowerElec_Click(object sender, RoutedEventArgs e)
        {
            PowerElec powerElec = new PowerElec();
            powerElec.Show();
            ElecWindow elecWindow = new ElecWindow();
            Close();
        }
    }
}
