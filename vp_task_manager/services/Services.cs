using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Management.Instrumentation;
using System.Management;
using System.Security.Principal;
using System.Runtime.InteropServices;

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

        public static string GetProcessUser(Process process)
        {
            IntPtr processHandle = IntPtr.Zero;
            try
            {
                OpenProcessToken(process.Handle, 8, out processHandle);
                WindowsIdentity wi = new WindowsIdentity(processHandle);
                string user = wi.Name;

                return user.Contains(@"\") ? user.Substring(user.IndexOf(@"\") + 1) : user;
            }
            catch
            {
                return null;
            }
            finally
            {
                if (processHandle != IntPtr.Zero)
                {
                    CloseHandle(processHandle);
                }
            }
        }

        [DllImport("advapi32.dll", SetLastError = true)]
        private static extern bool OpenProcessToken(IntPtr ProcessHandle, uint DesiredAccess, out IntPtr TokenHandle);
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool CloseHandle(IntPtr hObject);
    }
}
