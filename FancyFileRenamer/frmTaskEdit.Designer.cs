namespace FancyFileRenamer
{
  partial class frmTaskEdit
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
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.btnOk = new System.Windows.Forms.Button();
      this.btnAbort = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
      this.splitContainer1.IsSplitterFixed = true;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.btnOk);
      this.splitContainer1.Panel2.Controls.Add(this.btnAbort);
      this.splitContainer1.Size = new System.Drawing.Size(415, 382);
      this.splitContainer1.SplitterDistance = 350;
      this.splitContainer1.TabIndex = 0;
      this.splitContainer1.TabStop = false;
      // 
      // btnOk
      // 
      this.btnOk.Location = new System.Drawing.Point(247, 3);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new System.Drawing.Size(75, 23);
      this.btnOk.TabIndex = 1;
      this.btnOk.Text = "&OK";
      this.btnOk.UseVisualStyleBackColor = true;
      this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
      // 
      // btnAbort
      // 
      this.btnAbort.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnAbort.Location = new System.Drawing.Point(328, 3);
      this.btnAbort.Name = "btnAbort";
      this.btnAbort.Size = new System.Drawing.Size(75, 23);
      this.btnAbort.TabIndex = 0;
      this.btnAbort.Text = "&Cancel";
      this.btnAbort.UseVisualStyleBackColor = true;
      this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
      // 
      // frmTaskEdit
      // 
      this.AcceptButton = this.btnOk;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnAbort;
      this.ClientSize = new System.Drawing.Size(415, 382);
      this.Controls.Add(this.splitContainer1);
      this.Name = "frmTaskEdit";
      this.ShowInTaskbar = false;
      this.Text = "Edit Task";
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.Button btnOk;
    private System.Windows.Forms.Button btnAbort;
  }
}