using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Management.Automation;

class powershellBypass
{
    static void Main(string[] args)
    {
        string command = "continue";
        string cmdPath = string.Format("PS C:\\Users\\{0}>", System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\')[1]);
        while (command != "exit")
        {
            Console.Write(cmdPath);
            command = Console.ReadLine();
            PowerShell ps = PowerShell.Create();
            Collection<PSObject> PSOutput;
            PSOutput = ps.AddScript(command).Invoke();
            if (command != "")
            {
                if (PSOutput.Count == 0)
                {
                    Console.WriteLine(string.Format("'{0}' is not recognized as an internal or external command, \noperable program or batch file.", command));
                }
                for (int i = 0; i < PSOutput.Count; i++)
                {
                    Console.WriteLine(PSOutput[i].ToString());
                }
            }
            
        }
        

    }
}