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
using vp_task_manager.services;

namespace vp_task_manager
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            timer.Start();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            GetProcesses();
        }

        private void btnEndTask_Click(object sender, EventArgs e)
        {
            var proc = lstProcesses.SelectedItems[0];

            string name = proc.SubItems[1].Text;

            try
            {
                Process process = Process.GetProcessesByName(name).FirstOrDefault();

                process.Kill();

                RefreshList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                RefreshList();
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RefreshList();

            UpdateProcessCount();
        }

        private void refreshNowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RefreshList();

            UpdateProcessCount();
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
                else
                {
                    item.SubItems.Add(" ");
                }

                //string owner = Services.ProcessOwner(proc.Id);

                string owner = Services.GetProcessUser(proc);

                if (string.IsNullOrEmpty(owner))
                {
                    owner = "System";
                }

                item.SubItems.Add(owner);

                lstProcesses.Items.Add(item);
            }

            UpdateProcessCount();
        }

        private void RefreshList()
        {
            if (lstProcesses.Items.Count != 0)
            {
                lstProcesses.Items.Clear();
            }

            GetProcesses();
        }

        private void UpdateProcessCount()
        {
            processCount.Text = "Procesess: " + lstProcesses.Items.Count;
        }

        #endregion

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder();

            sb.Append("This projects is made for the purposes of the subject 'Visual Programming' \n\n");
            sb.Append("Author: Lazar Stojanovski 153116 \n");
            sb.Append("Date: 06.07.2020 \n");
            sb.Append("Faculty of Computer Science and Engineering");

            MessageBox.Show(sb.ToString(), "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNewTask_Click(object sender, EventArgs e)
        {
            using(Run runForm = new Run())
            {
                if(runForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshList();
                }
            }
        }

        private void newTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Run runForm = new Run())
            {
                if (runForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshList();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float fCpu = perfCPU.NextValue();
            float fRam = perfRAM.NextValue();

            progCPU.Value = (int)fCpu;
            progRAM.Value = (int)fRam;

            lblCPUPerc.Text = string.Format("{0:0.00}%", fCpu);
            lblRAMperc.Text = string.Format("{0:0.00}%", fRam);

            perfChart.Series["CPU"].Points.AddY(fCpu);
            perfChart.Series["RAM"].Points.AddY(fRam);
        }
    }
}
