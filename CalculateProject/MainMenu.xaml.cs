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

namespace CalculateProject
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
            Manager.SelectedMenuItemFrame = SelectedMenuItemFrame;
        }

        private void OpenMathPageButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.SelectedMenuItemFrame.Navigate(new MathPage());
        }

        private void OpenPhysPageButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.SelectedMenuItemFrame.Navigate(new PhysicPage());
        }

        private void OpenChemicPageButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.SelectedMenuItemFrame.Navigate(new ChemistryPage());
        }
    }
}
