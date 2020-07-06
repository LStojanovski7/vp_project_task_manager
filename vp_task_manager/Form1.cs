using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using vp_task_manager.models;

namespace vp_task_manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            GetProcesses();
        }

        private void btnEndTask_Click(object sender, EventArgs e)
        {

            //TODO: implement
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void refreshNowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        #region methods

        private void GetProcesses()
        {
            Process[] processes = Process.GetProcesses();

            foreach(var proc in processes)
            {
                ListViewItem item = new ListViewItem(proc.Id.ToString());

                int priority = proc.BasePriority;

                item.SubItems.Add(proc.ProcessName);

                if(priority == 4)
                {
                    item.SubItems.Add("iddle");
                }
                else if(priority == 8)
                {
                    item.SubItems.Add("Normal");
                }
                else if(priority == 13)
                {
                    item.SubItems.Add("High");
                }
                else if(priority == 24)
                {
                    item.SubItems.Add("Real time");
                }

                lstProcesses.Items.Add(item);
                proc.
            }
        }

        private void RefreshList()
        {
            if (lstProcesses.Items.Count != 0)
            {
                lstProcesses.Items.Clear();
            }

            GetProcesses();
        }

        #endregion
    }
}
