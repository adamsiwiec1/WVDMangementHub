using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WVDManagementHub.Methods
{
    public class Scripts
    {
        public void VanPoolRDSLogin()
        {
            Process process = new Process();
            process.StartInfo.FileName = "powershell.exe";
            process.StartInfo.Arguments = "/Scripts/NRTwvd_Adam.ps1";
            process.Start();

        }

    }
}
