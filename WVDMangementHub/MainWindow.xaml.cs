using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
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
using WVDManagementHub.Drives;
using WVDManagementHub.General;
using WVDManagementHub.RDS;
using WVDManagementHub.Users;
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
                var menuGeneral = new List<SubItem>();
            menuGeneral.Add(new SubItem("Run PowerShell Commands", new UserControlPowerShell()));
            menuGeneral.Add(new SubItem("Log into RDS", new UserControlLogIn()));
            //menuGeneral.Add(new SubItem("File Explorer", new UserControlPowerShell()));
            //menuGeneral.Add(new SubItem("Networking", new UserControlPowerShell()));
            var item0 = new ItemMenu("General", menuGeneral, PackIconKind.User); //, PackIconKind.ViewDashboard);


            var menuUsers = new List<SubItem>();
            menuUsers.Add(new SubItem("All Users", new UserControlAllUsers()));
            menuUsers.Add(new SubItem("Find User", new UserControlFindUser()));
            menuUsers.Add(new SubItem("Add User to Group", new UserControlAddUserGroup()));
            var item1 = new ItemMenu("Users", menuUsers, PackIconKind.User);

            var menuDrives = new List<SubItem>();
            menuDrives.Add(new SubItem("Add Drive", new UserControlAddDrive()));
            menuDrives.Add(new SubItem("List User Drives", new UserControlListDrives()));
            var item2 = new ItemMenu("Drive Mapping", menuDrives, PackIconKind.Computer);

            var menuLogs = new List<SubItem>();
            menuLogs.Add(new SubItem("Sign in History"));
            menuLogs.Add(new SubItem("Simple Log"));
            menuLogs.Add(new SubItem("Detailed Log"));
            menuLogs.Add(new SubItem("Verbose Log"));
            var item3 = new ItemMenu("Logs", menuLogs, PackIconKind.FileReport);

            Menu.Children.Add(new UserControlMenu(item0, this));
            Menu.Children.Add(new UserControlMenu(item1, this));
            Menu.Children.Add(new UserControlMenu(item2, this));
            Menu.Children.Add(new UserControlMenu(item3, this));
        }

        internal void SwitchScreen(object sender)
        {
            var screen = ((UserControl)sender);

            if(screen!=null)
            {
                StackPanelMain.Children.Clear();
                StackPanelMain.Children.Add(screen);
            }


        }


    }
}
