using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Management.Instrumentation;
using System.Management;

namespace vp_task_manager.services
{
    static class Services
    {
        public static string ProcessOwner(int pid)
        {

            //string username;

            string query = "SELECT * FROM Win32_Process WHERE ProcessID = " + pid;

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);

            ManagementObjectCollection processList = searcher.Get();

            foreach(ManagementObject ob in processList)
            {
                string[] argList = new string[] { string.Empty, string.Empty };
                int returnValue = Convert.ToInt32(ob.InvokeMethod("GetOwner", argList));

                if(returnValue == 0)
                {
                    return argList[1] + "\\" + argList[0];
                }
            }

            return "System";
        }
    }
}
