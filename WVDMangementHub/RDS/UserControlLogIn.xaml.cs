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
using WVDManagementHub.Methods;

namespace WVDManagementHub.RDS
{
    /// <summary>
    /// Interaction logic for UserControlLogIn.xaml
    /// </summary>
    public partial class UserControlLogIn : UserControl
    {
        Scripts sc = new Scripts();

        public UserControlLogIn()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            sc.VanPoolRDSLogin();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            sc.NRTRDS_Script();
        }
    }
}
