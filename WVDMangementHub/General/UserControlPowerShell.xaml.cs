using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WVDManagementHub.General
{
    /// <summary>
    /// Interaction logic for UserControlPowerShell.xaml
    /// </summary>
    public partial class UserControlPowerShell : UserControl
    {

        public UserControlPowerShell()
        {
            InitializeComponent();
        }


        private Collection<PSObject> RunScript(string script)
        {
            Runspace rs = RunspaceFactory.CreateRunspace();
            rs.ThreadOptions = PSThreadOptions.UseCurrentThread;
            rs.Open();

            PowerShell ps = PowerShell.Create();
            ps.Runspace = rs;

            ps.AddScript("Add-RdsAccount -DeploymentUrl 'https://rdbroker.wvd.microsoft.com'");
            return ps.Invoke();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Collection<PSObject> results = RunScript(txtBox1.Text);
            StringBuilder stringBuilder = new StringBuilder();
            foreach (PSObject obj in results)
            {
                stringBuilder.AppendLine(obj.ToString());
            }

            txtBlock1.Text = stringBuilder.ToString();
        }
    }
}
