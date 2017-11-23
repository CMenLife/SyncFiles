namespace SyncFiles
{
    partial class f_Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_Main));
            this.b_Sync = new System.Windows.Forms.Button();
            this.tb_FirstPath = new System.Windows.Forms.TextBox();
            this.tb_SecondPath = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.syncFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_FirstPath = new System.Windows.Forms.GroupBox();
            this.gb_SecondPath = new System.Windows.Forms.GroupBox();
            this.la_fp_Path = new System.Windows.Forms.Label();
            this.la_sp_Path = new System.Windows.Forms.Label();
            this.b_fp_choose = new System.Windows.Forms.Button();
            this.b_sp_choose = new System.Windows.Forms.Button();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lb_files = new System.Windows.Forms.ListBox();
            this.la_FileCount = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gb_FirstPath.SuspendLayout();
            this.gb_SecondPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_Sync
            // 
            resources.ApplyResources(this.b_Sync, "b_Sync");
            this.b_Sync.ForeColor = System.Drawing.Color.Green;
            this.b_Sync.Name = "b_Sync";
            this.b_Sync.UseVisualStyleBackColor = true;
            this.b_Sync.Click += new System.EventHandler(this.b_Sync_Click);
            // 
            // tb_FirstPath
            // 
            resources.ApplyResources(this.tb_FirstPath, "tb_FirstPath");
            this.tb_FirstPath.Name = "tb_FirstPath";
            // 
            // tb_SecondPath
            // 
            resources.ApplyResources(this.tb_SecondPath, "tb_SecondPath");
            this.tb_SecondPath.Name = "tb_SecondPath";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.syncFilesToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // syncFilesToolStripMenuItem
            // 
            this.syncFilesToolStripMenuItem.Name = "syncFilesToolStripMenuItem";
            resources.ApplyResources(this.syncFilesToolStripMenuItem, "syncFilesToolStripMenuItem");
            // 
            // gb_FirstPath
            // 
            this.gb_FirstPath.Controls.Add(this.b_fp_choose);
            this.gb_FirstPath.Controls.Add(this.la_fp_Path);
            this.gb_FirstPath.Controls.Add(this.tb_FirstPath);
            resources.ApplyResources(this.gb_FirstPath, "gb_FirstPath");
            this.gb_FirstPath.Name = "gb_FirstPath";
            this.gb_FirstPath.TabStop = false;
            // 
            // gb_SecondPath
            // 
            resources.ApplyResources(this.gb_SecondPath, "gb_SecondPath");
            this.gb_SecondPath.Controls.Add(this.b_sp_choose);
            this.gb_SecondPath.Controls.Add(this.la_sp_Path);
            this.gb_SecondPath.Controls.Add(this.tb_SecondPath);
            this.gb_SecondPath.Name = "gb_SecondPath";
            this.gb_SecondPath.TabStop = false;
            // 
            // la_fp_Path
            // 
            resources.ApplyResources(this.la_fp_Path, "la_fp_Path");
            this.la_fp_Path.Name = "la_fp_Path";
            // 
            // la_sp_Path
            // 
            resources.ApplyResources(this.la_sp_Path, "la_sp_Path");
            this.la_sp_Path.Name = "la_sp_Path";
            // 
            // b_fp_choose
            // 
            resources.ApplyResources(this.b_fp_choose, "b_fp_choose");
            this.b_fp_choose.Name = "b_fp_choose";
            this.b_fp_choose.UseVisualStyleBackColor = true;
            this.b_fp_choose.Click += new System.EventHandler(this.b_fp_choose_Click);
            // 
            // b_sp_choose
            // 
            resources.ApplyResources(this.b_sp_choose, "b_sp_choose");
            this.b_sp_choose.Name = "b_sp_choose";
            this.b_sp_choose.UseVisualStyleBackColor = true;
            this.b_sp_choose.Click += new System.EventHandler(this.b_sp_choose_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Sync);
            // 
            // lb_files
            // 
            resources.ApplyResources(this.lb_files, "lb_files");
            this.lb_files.FormattingEnabled = true;
            this.lb_files.Name = "lb_files";
            // 
            // la_FileCount
            // 
            resources.ApplyResources(this.la_FileCount, "la_FileCount");
            this.la_FileCount.Name = "la_FileCount";
            // 
            // f_Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.la_FileCount);
            this.Controls.Add(this.lb_files);
            this.Controls.Add(this.gb_SecondPath);
            this.Controls.Add(this.gb_FirstPath);
            this.Controls.Add(this.b_Sync);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "f_Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.f_Main_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gb_FirstPath.ResumeLayout(false);
            this.gb_FirstPath.PerformLayout();
            this.gb_SecondPath.ResumeLayout(false);
            this.gb_SecondPath.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_Sync;
        private System.Windows.Forms.TextBox tb_FirstPath;
        private System.Windows.Forms.TextBox tb_SecondPath;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem syncFilesToolStripMenuItem;
        private System.Windows.Forms.GroupBox gb_FirstPath;
        private System.Windows.Forms.Button b_fp_choose;
        private System.Windows.Forms.Label la_fp_Path;
        private System.Windows.Forms.GroupBox gb_SecondPath;
        private System.Windows.Forms.Button b_sp_choose;
        private System.Windows.Forms.Label la_sp_Path;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ListBox lb_files;
        private System.Windows.Forms.Label la_FileCount;
    }
}

