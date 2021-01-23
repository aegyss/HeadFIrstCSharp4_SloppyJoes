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

namespace HeadFIrstCSharp4_SloppyJoes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MakeTheMenu();
        }

        public void MakeTheMenu()
        {
            MenuItem[] menuItems = new MenuItem[5];
            for ( int i = 0; i < 5; i++)
            {
                if (i < 3)
                {
                    menuItems[i] = new MenuItem();
                } 
                else
                {
                    menuItems[i] = new MenuItem() { Breads = new string[] { "Plain Bagel", "Onion Bagel", "Pumpernickel Bagel", "Everything Bagel" } };
                }
            }

            item1.Text = menuItems[0].GenerateMenuItem
        }
    }
}
