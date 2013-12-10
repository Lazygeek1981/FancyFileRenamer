namespace FancyFileRenamer.TaskEditControls
{
  partial class ReplaceTaskEditControl
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.labelReplace = new System.Windows.Forms.Label();
      this.txtSearchFor = new System.Windows.Forms.TextBox();
      this.labelWith = new System.Windows.Forms.Label();
      this.txtReplaceWith = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // labelReplace
      // 
      this.labelReplace.AutoSize = true;
      this.labelReplace.Location = new System.Drawing.Point(3, 13);
      this.labelReplace.Name = "labelReplace";
      this.labelReplace.Size = new System.Drawing.Size(47, 13);
      this.labelReplace.TabIndex = 0;
      this.labelReplace.Text = "Replace";
      // 
      // txtSearchFor
      // 
      this.txtSearchFor.Location = new System.Drawing.Point(6, 29);
      this.txtSearchFor.Name = "txtSearchFor";
      this.txtSearchFor.Size = new System.Drawing.Size(311, 20);
      this.txtSearchFor.TabIndex = 1;
      // 
      // labelWith
      // 
      this.labelWith.AutoSize = true;
      this.labelWith.Location = new System.Drawing.Point(6, 88);
      this.labelWith.Name = "labelWith";
      this.labelWith.Size = new System.Drawing.Size(29, 13);
      this.labelWith.TabIndex = 2;
      this.labelWith.Text = "With";
      // 
      // txtReplaceWith
      // 
      this.txtReplaceWith.Location = new System.Drawing.Point(6, 104);
      this.txtReplaceWith.Name = "txtReplaceWith";
      this.txtReplaceWith.Size = new System.Drawing.Size(314, 20);
      this.txtReplaceWith.TabIndex = 3;
      // 
      // ReplaceTaskEditControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.txtReplaceWith);
      this.Controls.Add(this.labelWith);
      this.Controls.Add(this.txtSearchFor);
      this.Controls.Add(this.labelReplace);
      this.Name = "ReplaceTaskEditControl";
      this.Size = new System.Drawing.Size(341, 240);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelReplace;
    private System.Windows.Forms.TextBox txtSearchFor;
    private System.Windows.Forms.Label labelWith;
    private System.Windows.Forms.TextBox txtReplaceWith;
  }
}
