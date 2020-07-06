namespace vp_task_manager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEndTask = new System.Windows.Forms.Button();
            this.btnNewTask = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshNowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabTabs = new System.Windows.Forms.TabControl();
            this.tabProcess = new System.Windows.Forms.TabPage();
            this.lstProcesses = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPerformance = new System.Windows.Forms.TabPage();
            this.username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabTabs.SuspendLayout();
            this.tabProcess.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEndTask
            // 
            this.btnEndTask.Location = new System.Drawing.Point(472, 403);
            this.btnEndTask.Name = "btnEndTask";
            this.btnEndTask.Size = new System.Drawing.Size(90, 29);
            this.btnEndTask.TabIndex = 1;
            this.btnEndTask.Text = "End task";
            this.btnEndTask.UseVisualStyleBackColor = true;
            this.btnEndTask.Click += new System.EventHandler(this.btnEndTask_Click);
            // 
            // btnNewTask
            // 
            this.btnNewTask.Location = new System.Drawing.Point(376, 403);
            this.btnNewTask.Name = "btnNewTask";
            this.btnNewTask.Size = new System.Drawing.Size(90, 29);
            this.btnNewTask.TabIndex = 3;
            this.btnNewTask.Text = "New task";
            this.btnNewTask.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(587, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTaskToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newTaskToolStripMenuItem
            // 
            this.newTaskToolStripMenuItem.Name = "newTaskToolStripMenuItem";
            this.newTaskToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newTaskToolStripMenuItem.Text = "New task";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshNowToolStripMenuItem1});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // refreshNowToolStripMenuItem1
            // 
            this.refreshNowToolStripMenuItem1.Name = "refreshNowToolStripMenuItem1";
            this.refreshNowToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.refreshNowToolStripMenuItem1.Text = "Refresh now";
            this.refreshNowToolStripMenuItem1.Click += new System.EventHandler(this.refreshNowToolStripMenuItem1_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshNowToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // refreshNowToolStripMenuItem
            // 
            this.refreshNowToolStripMenuItem.Name = "refreshNowToolStripMenuItem";
            this.refreshNowToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(537, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tabTabs
            // 
            this.tabTabs.Controls.Add(this.tabProcess);
            this.tabTabs.Controls.Add(this.tabPerformance);
            this.tabTabs.Location = new System.Drawing.Point(12, 66);
            this.tabTabs.Multiline = true;
            this.tabTabs.Name = "tabTabs";
            this.tabTabs.SelectedIndex = 0;
            this.tabTabs.Size = new System.Drawing.Size(563, 324);
            this.tabTabs.TabIndex = 6;
            // 
            // tabProcess
            // 
            this.tabProcess.Controls.Add(this.lstProcesses);
            this.tabProcess.Location = new System.Drawing.Point(4, 22);
            this.tabProcess.Name = "tabProcess";
            this.tabProcess.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcess.Size = new System.Drawing.Size(555, 298);
            this.tabProcess.TabIndex = 0;
            this.tabProcess.Text = "Processes";
            this.tabProcess.UseVisualStyleBackColor = true;
            // 
            // lstProcesses
            // 
            this.lstProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.priority,
            this.username});
            this.lstProcesses.HideSelection = false;
            this.lstProcesses.Location = new System.Drawing.Point(-4, 0);
            this.lstProcesses.Name = "lstProcesses";
            this.lstProcesses.Size = new System.Drawing.Size(563, 302);
            this.lstProcesses.TabIndex = 0;
            this.lstProcesses.UseCompatibleStateImageBehavior = false;
            this.lstProcesses.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "PID";
            this.id.Width = 72;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 206;
            // 
            // priority
            // 
            this.priority.Text = "Priority";
            this.priority.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.priority.Width = 59;
            // 
            // tabPerformance
            // 
            this.tabPerformance.Location = new System.Drawing.Point(4, 22);
            this.tabPerformance.Name = "tabPerformance";
            this.tabPerformance.Padding = new System.Windows.Forms.Padding(3);
            this.tabPerformance.Size = new System.Drawing.Size(555, 298);
            this.tabPerformance.TabIndex = 1;
            this.tabPerformance.Text = "Performance";
            this.tabPerformance.UseVisualStyleBackColor = true;
            // 
            // username
            // 
            this.username.Text = "Owner";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 475);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabTabs);
            this.Controls.Add(this.btnNewTask);
            this.Controls.Add(this.btnEndTask);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabTabs.ResumeLayout(false);
            this.tabProcess.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEndTask;
        private System.Windows.Forms.Button btnNewTask;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshNowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshNowToolStripMenuItem1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabTabs;
        private System.Windows.Forms.TabPage tabProcess;
        private System.Windows.Forms.TabPage tabPerformance;
        private System.Windows.Forms.ListView lstProcesses;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader priority;
        public System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader username;
    }
}

