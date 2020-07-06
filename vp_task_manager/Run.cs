using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace vp_task_manager
{
    public partial class Run : Form
    {
        public Run()
        {
            InitializeComponent();
        }



        private void txtTask_TextChanged(object sender, EventArgs e)
        {
            if(txtTask.Text == string.Empty)
            {
                btnOk.Enabled = false;
            }
            else
            {
                btnOk.Enabled = true;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTask.Text))
            {
                try
                {
                    Process proc = new Process();

                    proc.StartInfo.FileName = txtTask.Text;
                    proc.Start();

                    this.Close();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
