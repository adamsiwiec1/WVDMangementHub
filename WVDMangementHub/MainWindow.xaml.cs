using MaterialDesignThemes.Wpf;
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
using WVDManagementHub.ViewModel;

namespace WVDManagementHub
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            // Explains the program and shows basic stats
            var item0 = new ItemMenu("Dashboard", new UserControl(), PackIconKind.ViewDashboard);


            var menuRegister = new List<SubItem>();
            menuRegister.Add(new SubItem("All Users"));
            menuRegister.Add(new SubItem("Find a User"));
            menuRegister.Add(new SubItem("Add a User to a Group"));
            menuRegister.Add(new SubItem("Force Logoff"));
            var item6 = new ItemMenu("Users", menuRegister, PackIconKind.User);

            var menuSchedule = new List<SubItem>();
            menuSchedule.Add(new SubItem("Add a drive"));
            menuSchedule.Add(new SubItem("Remove a drive"));
            var item1 = new ItemMenu("Drive Mapping", menuSchedule, PackIconKind.Computer);

            var menuReports = new List<SubItem>();
            menuReports.Add(new SubItem("Sign in History"));
            menuReports.Add(new SubItem("Simple Log"));
            menuReports.Add(new SubItem("Detailed Log"));
            menuReports.Add(new SubItem("Verbose Log"));
            var item2 = new ItemMenu("Logs", menuReports, PackIconKind.FileReport);

            Menu.Children.Add(new UserControlMenu(item0));
            Menu.Children.Add(new UserControlMenu(item6));
            Menu.Children.Add(new UserControlMenu(item1));
            Menu.Children.Add(new UserControlMenu(item2));
        }
    }
}
