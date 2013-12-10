namespace FancyFileRenamer
{
  partial class frmMain
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
      this.listBxSource = new System.Windows.Forms.ListBox();
      this.tabControl = new System.Windows.Forms.TabControl();
      this.tabPageTasks = new System.Windows.Forms.TabPage();
      this.btnRemoveTask = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnAddTask = new System.Windows.Forms.Button();
      this.comboTasks = new System.Windows.Forms.ComboBox();
      this.listBoxTasksToApply = new System.Windows.Forms.ListBox();
      this.tabPageOrdering = new System.Windows.Forms.TabPage();
      this.listBoxPreview = new System.Windows.Forms.ListBox();
      this.btnLoad = new System.Windows.Forms.Button();
      this.txtPattern = new System.Windows.Forms.TextBox();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.splitContainer2 = new System.Windows.Forms.SplitContainer();
      this.btnGo = new System.Windows.Forms.Button();
      this.folderChooseBox = new LazyLib.Windows.Forms.Controls.FolderChooseBox();
      this.tabControl.SuspendLayout();
      this.tabPageTasks.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
      this.splitContainer2.Panel1.SuspendLayout();
      this.splitContainer2.Panel2.SuspendLayout();
      this.splitContainer2.SuspendLayout();
      this.SuspendLayout();
      // 
      // listBxSource
      // 
      this.listBxSource.Dock = System.Windows.Forms.DockStyle.Fill;
      this.listBxSource.FormattingEnabled = true;
      this.listBxSource.Location = new System.Drawing.Point(0, 0);
      this.listBxSource.Name = "listBxSource";
      this.listBxSource.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
      this.listBxSource.Size = new System.Drawing.Size(457, 651);
      this.listBxSource.TabIndex = 3;
      this.listBxSource.SelectedIndexChanged += new System.EventHandler(this.listBxSource_SelectedIndexChanged);
      // 
      // tabControl
      // 
      this.tabControl.Controls.Add(this.tabPageTasks);
      this.tabControl.Controls.Add(this.tabPageOrdering);
      this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl.Location = new System.Drawing.Point(0, 0);
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new System.Drawing.Size(430, 651);
      this.tabControl.TabIndex = 4;
      // 
      // tabPageTasks
      // 
      this.tabPageTasks.Controls.Add(this.btnRemoveTask);
      this.tabPageTasks.Controls.Add(this.panel1);
      this.tabPageTasks.Controls.Add(this.btnAddTask);
      this.tabPageTasks.Controls.Add(this.comboTasks);
      this.tabPageTasks.Controls.Add(this.listBoxTasksToApply);
      this.tabPageTasks.Location = new System.Drawing.Point(4, 22);
      this.tabPageTasks.Name = "tabPageTasks";
      this.tabPageTasks.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageTasks.Size = new System.Drawing.Size(422, 625);
      this.tabPageTasks.TabIndex = 1;
      this.tabPageTasks.Text = "Renaming Tasks";
      this.tabPageTasks.UseVisualStyleBackColor = true;
      // 
      // btnRemoveTask
      // 
      this.btnRemoveTask.Location = new System.Drawing.Point(260, 12);
      this.btnRemoveTask.Name = "btnRemoveTask";
      this.btnRemoveTask.Size = new System.Drawing.Size(75, 23);
      this.btnRemoveTask.TabIndex = 4;
      this.btnRemoveTask.Text = "Remove";
      this.btnRemoveTask.UseVisualStyleBackColor = true;
      this.btnRemoveTask.Click += new System.EventHandler(this.btnRemove_Click);
      // 
      // panel1
      // 
      this.panel1.Location = new System.Drawing.Point(6, 344);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(410, 275);
      this.panel1.TabIndex = 3;
      // 
      // btnAddTask
      // 
      this.btnAddTask.Location = new System.Drawing.Point(341, 12);
      this.btnAddTask.Name = "btnAddTask";
      this.btnAddTask.Size = new System.Drawing.Size(75, 23);
      this.btnAddTask.TabIndex = 2;
      this.btnAddTask.Text = "Add";
      this.btnAddTask.UseVisualStyleBackColor = true;
      this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
      // 
      // comboTasks
      // 
      this.comboTasks.FormattingEnabled = true;
      this.comboTasks.Location = new System.Drawing.Point(6, 14);
      this.comboTasks.Name = "comboTasks";
      this.comboTasks.Size = new System.Drawing.Size(248, 21);
      this.comboTasks.TabIndex = 1;
      this.comboTasks.SelectedIndexChanged += new System.EventHandler(this.comboTasks_SelectedIndexChanged);
      // 
      // listBoxTasksToApply
      // 
      this.listBoxTasksToApply.FormattingEnabled = true;
      this.listBoxTasksToApply.Location = new System.Drawing.Point(6, 41);
      this.listBoxTasksToApply.Name = "listBoxTasksToApply";
      this.listBoxTasksToApply.Size = new System.Drawing.Size(410, 290);
      this.listBoxTasksToApply.TabIndex = 0;
      this.listBoxTasksToApply.SelectedIndexChanged += new System.EventHandler(this.listBoxTasksToApply_SelectedIndexChanged);
      // 
      // tabPageOrdering
      // 
      this.tabPageOrdering.Location = new System.Drawing.Point(4, 22);
      this.tabPageOrdering.Name = "tabPageOrdering";
      this.tabPageOrdering.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageOrdering.Size = new System.Drawing.Size(420, 621);
      this.tabPageOrdering.TabIndex = 2;
      this.tabPageOrdering.Text = "FileOrdering";
      this.tabPageOrdering.UseVisualStyleBackColor = true;
      // 
      // listBoxPreview
      // 
      this.listBoxPreview.Dock = System.Windows.Forms.DockStyle.Fill;
      this.listBoxPreview.FormattingEnabled = true;
      this.listBoxPreview.Location = new System.Drawing.Point(0, 0);
      this.listBoxPreview.Name = "listBoxPreview";
      this.listBoxPreview.Size = new System.Drawing.Size(467, 651);
      this.listBoxPreview.TabIndex = 5;
      // 
      // btnLoad
      // 
      this.btnLoad.Location = new System.Drawing.Point(400, 10);
      this.btnLoad.Name = "btnLoad";
      this.btnLoad.Size = new System.Drawing.Size(75, 23);
      this.btnLoad.TabIndex = 7;
      this.btnLoad.Text = "Load";
      this.btnLoad.UseVisualStyleBackColor = true;
      this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
      // 
      // txtPattern
      // 
      this.txtPattern.Location = new System.Drawing.Point(514, 12);
      this.txtPattern.Name = "txtPattern";
      this.txtPattern.Size = new System.Drawing.Size(70, 20);
      this.txtPattern.TabIndex = 8;
      this.txtPattern.Text = "*.*";
      // 
      // splitContainer1
      // 
      this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.splitContainer1.Location = new System.Drawing.Point(12, 39);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.listBxSource);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
      this.splitContainer1.Size = new System.Drawing.Size(1374, 655);
      this.splitContainer1.SplitterDistance = 461;
      this.splitContainer1.TabIndex = 9;
      // 
      // splitContainer2
      // 
      this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer2.Location = new System.Drawing.Point(0, 0);
      this.splitContainer2.Name = "splitContainer2";
      // 
      // splitContainer2.Panel1
      // 
      this.splitContainer2.Panel1.Controls.Add(this.tabControl);
      // 
      // splitContainer2.Panel2
      // 
      this.splitContainer2.Panel2.Controls.Add(this.listBoxPreview);
      this.splitContainer2.Size = new System.Drawing.Size(909, 655);
      this.splitContainer2.SplitterDistance = 434;
      this.splitContainer2.TabIndex = 0;
      // 
      // btnGo
      // 
      this.btnGo.Location = new System.Drawing.Point(1079, 10);
      this.btnGo.Name = "btnGo";
      this.btnGo.Size = new System.Drawing.Size(175, 23);
      this.btnGo.TabIndex = 10;
      this.btnGo.Text = "Start renaming";
      this.btnGo.UseVisualStyleBackColor = true;
      this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
      // 
      // folderChooseBox
      // 
      this.folderChooseBox.CurrentDirectory = "";
      this.folderChooseBox.CurrentDirectoryInfo = null;
      this.folderChooseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
      this.folderChooseBox.ForeColor = System.Drawing.Color.Gray;
      this.folderChooseBox.Location = new System.Drawing.Point(12, 12);
      this.folderChooseBox.Name = "folderChooseBox";
      this.folderChooseBox.Size = new System.Drawing.Size(382, 20);
      this.folderChooseBox.TabIndex = 11;
      this.folderChooseBox.Text = "Double click or enter path here to choose a folder";
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1398, 706);
      this.Controls.Add(this.folderChooseBox);
      this.Controls.Add(this.btnGo);
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.txtPattern);
      this.Controls.Add(this.btnLoad);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "frmMain";
      this.Text = "Fancy File Renamer";
      this.tabControl.ResumeLayout(false);
      this.tabPageTasks.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.splitContainer2.Panel1.ResumeLayout(false);
      this.splitContainer2.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
      this.splitContainer2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox listBxSource;
    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.TabPage tabPageTasks;
    private System.Windows.Forms.ListBox listBoxPreview;
    private System.Windows.Forms.Button btnLoad;
    private System.Windows.Forms.TextBox txtPattern;
    private System.Windows.Forms.TabPage tabPageOrdering;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.SplitContainer splitContainer2;
    private System.Windows.Forms.ListBox listBoxTasksToApply;
    private System.Windows.Forms.Button btnRemoveTask;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnAddTask;
    private System.Windows.Forms.ComboBox comboTasks;
    private System.Windows.Forms.Button btnGo;
    private LazyLib.Windows.Forms.Controls.FolderChooseBox folderChooseBox;
  }
}

