using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management.Automation;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace GitPowershell
{
    class GitShell
    {
        public void RunBuild()
        {
            // %SystemRoot%\system32\WindowsPowerShell\v1.0\powershell.exe -noexit -File runposh.ps1

            using (PowerShell PowerShellInstance = PowerShell.Create())
            {
                // use "AddScript" to add the contents of a script file to the end of the execution pipeline.
                // use "AddCommand" to add individual commands/cmdlets to the end of the execution pipeline.
                PowerShellInstance.AddCommand(@"C:\Users\rroberts\Source\Repos\Advantage\tools\build\build.ps1");

                // invoke execution on the pipeline (collecting output)
                Collection<PSObject> PSOutput = PowerShellInstance.Invoke();

                // check the other output streams (for example, the error stream)
                if (PowerShellInstance.Streams.Error.Count > 0)
                {
                    foreach (ErrorRecord psErrorRecord in PowerShellInstance.Streams.Error)
                    {
                        // error records were written to the error stream.
                        // do something with the items found.
                        Debug.WriteLine(psErrorRecord.ToString());
                    }

                }


                // loop through each output object item
                foreach (PSObject outputItem in PSOutput)
                {
                    // if null object was dumped to the pipeline during the script then a null
                    // object may be present here. check for null to prevent potential NRE.
                    if (outputItem != null)
                    {
                        //TODO: do something with the output item 
                        //TODO: do something with the output item 
                        Debug.WriteLine(outputItem.BaseObject.GetType().FullName);
                        Debug.WriteLine(outputItem.BaseObject.ToString() + "\n");
                    }
                }
            }

        }
    }
}
