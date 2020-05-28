using System;
using System.Windows.Forms;

namespace SimpleSniffer
{
    public class FindPackets
    {
        [STAThread]
        public static void Main()
        {
             System.Security.Principal.WindowsIdentity identity = System.Security.Principal.WindowsIdentity.GetCurrent();
             Application.EnableVisualStyles();
             System.Security.Principal.WindowsPrincipal principal = new System.Security.Principal.WindowsPrincipal(identity);

             if (principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator))
             {
                 Application.Run(new FormCSNZExplota());
             }
             else
             {
                 System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                 startInfo.UseShellExecute = true;
                 startInfo.WorkingDirectory = Environment.CurrentDirectory;
                 startInfo.FileName = Application.ExecutablePath;
                 startInfo.Verb = "runas";
                 try
                 {
                     System.Diagnostics.Process.Start(startInfo);
                 }
                 catch
                 {
                     return;
                 }
                 Application.Exit();
             }
        }
    }
}
