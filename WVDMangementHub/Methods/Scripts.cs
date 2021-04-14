using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading.Tasks;

namespace WVDManagementHub.Methods
{
    public class Scripts
    {
        Runspace rs;
        public void VanPoolRDSLogin()
        {
            PowerShell ps = PowerShell.Create();

            rs = RunspaceFactory.CreateRunspace();
            rs.Open();
                                                                                    // Will not let me run bc remote signed.. tried a few things
            ps.Runspace = rs;
            Pipeline pl = rs.CreatePipeline();
            pl.Commands.AddScript("Set-ExecutionPolicy -ExecutionPolicy Unrestricted");
            //pl.AddParameter("-ExecutionPolicy", "ByPass");
            //ps.AddParameter("-File", "C:\\Users\\adams\\NRTwvd_Adam.ps1");
            ps.AddCommand("C:\\Users\\adams\\NRTwvd_Adam.ps1");

            pl.Invoke();
            rs.Close();

        }
        public void NRTRDS_Script()
        {
            Process process = new Process();
            process.StartInfo.FileName = "powershell.exe";
            process.StartInfo.Arguments = "C:\\Users\\adams\\NRTwvd_Adam.ps1";
            process.Start();

        }



    }
}
