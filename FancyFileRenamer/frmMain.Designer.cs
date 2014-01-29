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
      this.btnMoveDown = new System.Windows.Forms.Button();
      this.btnMoveUp = new System.Windows.Forms.Button();
      this.btnRemoveTask = new System.Windows.Forms.Button();
      this.btnAddTask = new System.Windows.Forms.Button();
      this.comboTasks = new System.Windows.Forms.ComboBox();
      this.listBoxTasksToApply = new System.Windows.Forms.ListBox();
      this.listBoxPreview = new System.Windows.Forms.ListBox();
      this.btnLoad = new System.Windows.Forms.Button();
      this.txtPattern = new System.Windows.Forms.TextBox();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.splitContainer2 = new System.Windows.Forms.SplitContainer();
      this.btnGo = new System.Windows.Forms.Button();
      this.folderChooseBox = new LazyLib.Windows.Forms.Controls.FolderChooseBox();
      this.groupTasks = new System.Windows.Forms.GroupBox();
      this.groupOrdering = new System.Windows.Forms.GroupBox();
      this.radioName = new System.Windows.Forms.RadioButton();
      this.comboOrder = new System.Windows.Forms.ComboBox();
      this.radioSize = new System.Windows.Forms.RadioButton();
      this.radioCreationDate = new System.Windows.Forms.RadioButton();
      this.radioChangeDate = new System.Windows.Forms.RadioButton();
      this.radioButton1 = new System.Windows.Forms.RadioButton();
      this.labelOrder = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
      this.splitContainer2.Panel1.SuspendLayout();
      this.splitContainer2.Panel2.SuspendLayout();
      this.splitContainer2.SuspendLayout();
      this.groupTasks.SuspendLayout();
      this.groupOrdering.SuspendLayout();
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
      // btnMoveDown
      // 
      this.btnMoveDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnMoveDown.Location = new System.Drawing.Point(383, 104);
      this.btnMoveDown.Name = "btnMoveDown";
      this.btnMoveDown.Size = new System.Drawing.Size(33, 23);
      this.btnMoveDown.TabIndex = 6;
      this.btnMoveDown.Text = "\\/";
      this.btnMoveDown.UseVisualStyleBackColor = true;
      // 
      // btnMoveUp
      // 
      this.btnMoveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnMoveUp.Location = new System.Drawing.Point(383, 46);
      this.btnMoveUp.Name = "btnMoveUp";
      this.btnMoveUp.Size = new System.Drawing.Size(33, 23);
      this.btnMoveUp.TabIndex = 5;
      this.btnMoveUp.Text = "/\\";
      this.btnMoveUp.UseVisualStyleBackColor = true;
      // 
      // btnRemoveTask
      // 
      this.btnRemoveTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnRemoveTask.Location = new System.Drawing.Point(383, 75);
      this.btnRemoveTask.Name = "btnRemoveTask";
      this.btnRemoveTask.Size = new System.Drawing.Size(33, 23);
      this.btnRemoveTask.TabIndex = 4;
      this.btnRemoveTask.Text = "-";
      this.btnRemoveTask.UseVisualStyleBackColor = true;
      this.btnRemoveTask.Click += new System.EventHandler(this.btnRemove_Click);
      // 
      // btnAddTask
      // 
      this.btnAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAddTask.Location = new System.Drawing.Point(383, 17);
      this.btnAddTask.Name = "btnAddTask";
      this.btnAddTask.Size = new System.Drawing.Size(33, 23);
      this.btnAddTask.TabIndex = 2;
      this.btnAddTask.Text = "+";
      this.btnAddTask.UseVisualStyleBackColor = true;
      this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
      // 
      // comboTasks
      // 
      this.comboTasks.FormattingEnabled = true;
      this.comboTasks.Location = new System.Drawing.Point(6, 19);
      this.comboTasks.Name = "comboTasks";
      this.comboTasks.Size = new System.Drawing.Size(371, 21);
      this.comboTasks.TabIndex = 1;
      this.comboTasks.SelectedIndexChanged += new System.EventHandler(this.comboTasks_SelectedIndexChanged);
      // 
      // listBoxTasksToApply
      // 
      this.listBoxTasksToApply.FormattingEnabled = true;
      this.listBoxTasksToApply.Location = new System.Drawing.Point(6, 46);
      this.listBoxTasksToApply.Name = "listBoxTasksToApply";
      this.listBoxTasksToApply.Size = new System.Drawing.Size(371, 186);
      this.listBoxTasksToApply.TabIndex = 0;
      this.listBoxTasksToApply.SelectedIndexChanged += new System.EventHandler(this.listBoxTasksToApply_SelectedIndexChanged);
      this.listBoxTasksToApply.DoubleClick += new System.EventHandler(this.listBoxTasksToApply_DoubleClick);
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
      this.splitContainer2.Panel1.Controls.Add(this.groupOrdering);
      this.splitContainer2.Panel1.Controls.Add(this.groupTasks);
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
      // groupTasks
      // 
      this.groupTasks.Controls.Add(this.btnMoveDown);
      this.groupTasks.Controls.Add(this.comboTasks);
      this.groupTasks.Controls.Add(this.btnMoveUp);
      this.groupTasks.Controls.Add(this.listBoxTasksToApply);
      this.groupTasks.Controls.Add(this.btnRemoveTask);
      this.groupTasks.Controls.Add(this.btnAddTask);
      this.groupTasks.Location = new System.Drawing.Point(3, 13);
      this.groupTasks.Name = "groupTasks";
      this.groupTasks.Size = new System.Drawing.Size(417, 241);
      this.groupTasks.TabIndex = 5;
      this.groupTasks.TabStop = false;
      this.groupTasks.Text = "Renaming Tasks";
      // 
      // groupOrdering
      // 
      this.groupOrdering.Controls.Add(this.labelOrder);
      this.groupOrdering.Controls.Add(this.radioButton1);
      this.groupOrdering.Controls.Add(this.radioChangeDate);
      this.groupOrdering.Controls.Add(this.radioCreationDate);
      this.groupOrdering.Controls.Add(this.radioSize);
      this.groupOrdering.Controls.Add(this.comboOrder);
      this.groupOrdering.Controls.Add(this.radioName);
      this.groupOrdering.Location = new System.Drawing.Point(3, 260);
      this.groupOrdering.Name = "groupOrdering";
      this.groupOrdering.Size = new System.Drawing.Size(416, 242);
      this.groupOrdering.TabIndex = 6;
      this.groupOrdering.TabStop = false;
      this.groupOrdering.Text = "Input File Ordering";
      // 
      // radioName
      // 
      this.radioName.AutoSize = true;
      this.radioName.Location = new System.Drawing.Point(22, 30);
      this.radioName.Name = "radioName";
      this.radioName.Size = new System.Drawing.Size(53, 17);
      this.radioName.TabIndex = 0;
      this.radioName.TabStop = true;
      this.radioName.Text = "Name";
      this.radioName.UseVisualStyleBackColor = true;
      // 
      // comboOrder
      // 
      this.comboOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboOrder.FormattingEnabled = true;
      this.comboOrder.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
      this.comboOrder.Location = new System.Drawing.Point(22, 192);
      this.comboOrder.Name = "comboOrder";
      this.comboOrder.Size = new System.Drawing.Size(121, 21);
      this.comboOrder.TabIndex = 1;
      // 
      // radioSize
      // 
      this.radioSize.AutoSize = true;
      this.radioSize.Location = new System.Drawing.Point(22, 53);
      this.radioSize.Name = "radioSize";
      this.radioSize.Size = new System.Drawing.Size(45, 17);
      this.radioSize.TabIndex = 2;
      this.radioSize.TabStop = true;
      this.radioSize.Text = "Size";
      this.radioSize.UseVisualStyleBackColor = true;
      // 
      // radioCreationDate
      // 
      this.radioCreationDate.AutoSize = true;
      this.radioCreationDate.Location = new System.Drawing.Point(22, 76);
      this.radioCreationDate.Name = "radioCreationDate";
      this.radioCreationDate.Size = new System.Drawing.Size(88, 17);
      this.radioCreationDate.TabIndex = 3;
      this.radioCreationDate.TabStop = true;
      this.radioCreationDate.Text = "Creation date";
      this.radioCreationDate.UseVisualStyleBackColor = true;
      // 
      // radioChangeDate
      // 
      this.radioChangeDate.AutoSize = true;
      this.radioChangeDate.Location = new System.Drawing.Point(22, 99);
      this.radioChangeDate.Name = "radioChangeDate";
      this.radioChangeDate.Size = new System.Drawing.Size(86, 17);
      this.radioChangeDate.TabIndex = 4;
      this.radioChangeDate.TabStop = true;
      this.radioChangeDate.Text = "Change date";
      this.radioChangeDate.UseVisualStyleBackColor = true;
      // 
      // radioButton1
      // 
      this.radioButton1.AutoSize = true;
      this.radioButton1.Location = new System.Drawing.Point(22, 122);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new System.Drawing.Size(143, 17);
      this.radioButton1.TabIndex = 5;
      this.radioButton1.TabStop = true;
      this.radioButton1.Text = "EXIF Date (Pictures only)";
      this.radioButton1.UseVisualStyleBackColor = true;
      // 
      // labelOrder
      // 
      this.labelOrder.AutoSize = true;
      this.labelOrder.Location = new System.Drawing.Point(19, 176);
      this.labelOrder.Name = "labelOrder";
      this.labelOrder.Size = new System.Drawing.Size(33, 13);
      this.labelOrder.TabIndex = 6;
      this.labelOrder.Text = "Order";
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
      this.Text = " ";
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.splitContainer2.Panel1.ResumeLayout(false);
      this.splitContainer2.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
      this.splitContainer2.ResumeLayout(false);
      this.groupTasks.ResumeLayout(false);
      this.groupOrdering.ResumeLayout(false);
      this.groupOrdering.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox listBxSource;
    private System.Windows.Forms.ListBox listBoxPreview;
    private System.Windows.Forms.Button btnLoad;
    private System.Windows.Forms.TextBox txtPattern;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.SplitContainer splitContainer2;
    private System.Windows.Forms.ListBox listBoxTasksToApply;
    private System.Windows.Forms.Button btnRemoveTask;
    private System.Windows.Forms.Button btnAddTask;
    private System.Windows.Forms.ComboBox comboTasks;
    private System.Windows.Forms.Button btnGo;
    private LazyLib.Windows.Forms.Controls.FolderChooseBox folderChooseBox;
    private System.Windows.Forms.Button btnMoveDown;
    private System.Windows.Forms.Button btnMoveUp;
    private System.Windows.Forms.GroupBox groupOrdering;
    private System.Windows.Forms.Label labelOrder;
    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.RadioButton radioChangeDate;
    private System.Windows.Forms.RadioButton radioCreationDate;
    private System.Windows.Forms.RadioButton radioSize;
    private System.Windows.Forms.ComboBox comboOrder;
    private System.Windows.Forms.RadioButton radioName;
    private System.Windows.Forms.GroupBox groupTasks;
  }
}

