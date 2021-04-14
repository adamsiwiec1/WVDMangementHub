using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading.Tasks;

namespace WVDManagementHub.Methods
{
    public class Login
    {


        public void RDSLogin()
        {
            Process process = new Process();
            process.StartInfo.FileName = "powershell.exe";
            process.StartInfo.Arguments = "Add-RdsAccount -DeploymentUrl 'https://rdbroker.wvd.microsoft.com'";
            process.Start();
            
        }




        //private Runspace rs;

        //public void InvokeLogin()
        //{
        //    rs = RunspaceFactory.CreateRunspace();
        //    rs.Open();
        //    using (PowerShell PowerShellInst = PowerShell.Create())
        //    {
        //        string criteria = "system*";
        //        PowerShellInst.AddScript("Add-RdsAccount -DeploymentUrl 'https://rdbroker.wvd.microsoft.com'" + criteria);
        //        Collection<PSObject> PSOutput = PowerShellInst.Invoke();
        //        foreach (PSObject obj in PSOutput)
        //        {
        //            if (obj != null)
        //            {
        //                Console.Write(obj.Properties["Status"].Value.ToString() + " - ");
        //                Console.WriteLine(obj.Properties["DisplayName"].Value.ToString());
        //            }
        //        }
        //        Console.WriteLine("Done");
        //        Console.Read();
        //    }
        //}

        //public void InvokeLogin2()
        //{
        //    //execute powershell cmdlets or scripts using command arguments as process
        //    ProcessStartInfo processInfo = new ProcessStartInfo();
        //    processInfo.FileName = @"powershell.exe";
        //    //execute powershell script using script file
        //    //processInfo.Arguments = @"& {c:\temp\Get-EventLog.ps1}";
        //    //execute powershell command
        //    processInfo.Arguments = @"& {Get-EventLog -LogName Application -Newest 10 -EntryType Information | Select EntryType, Message}";
        //    processInfo.RedirectStandardError = true;
        //    processInfo.RedirectStandardOutput = true;
        //    processInfo.UseShellExecute = false;
        //    processInfo.CreateNoWindow = true;

        //    //start powershell process using process start info
        //    Process process = new Process();
        //    process.StartInfo = processInfo;
        //    process.Start();

        //    Console.WriteLine("Output - {0}", process.StandardOutput.ReadToEnd());
        //    Console.WriteLine("Errors - {0}", process.StandardError.ReadToEnd());
        //    Console.Read();
        //}

    }
}
