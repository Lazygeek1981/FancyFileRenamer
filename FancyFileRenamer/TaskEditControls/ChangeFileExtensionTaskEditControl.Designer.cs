namespace FancyFileRenamer.TaskEditControls
{
  partial class ChangeFileExtensionTaskEditControl
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
      this.labelNewFileExtenions = new System.Windows.Forms.Label();
      this.txtNewFileExtension = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // labelNewFileExtenions
      // 
      this.labelNewFileExtenions.AutoSize = true;
      this.labelNewFileExtenions.Location = new System.Drawing.Point(6, 22);
      this.labelNewFileExtenions.Name = "labelNewFileExtenions";
      this.labelNewFileExtenions.Size = new System.Drawing.Size(93, 13);
      this.labelNewFileExtenions.TabIndex = 0;
      this.labelNewFileExtenions.Text = "New file extension";
      // 
      // txtNewFileExtension
      // 
      this.txtNewFileExtension.Location = new System.Drawing.Point(105, 19);
      this.txtNewFileExtension.Name = "txtNewFileExtension";
      this.txtNewFileExtension.Size = new System.Drawing.Size(64, 20);
      this.txtNewFileExtension.TabIndex = 1;
      this.txtNewFileExtension.TextChanged += new System.EventHandler(this.txtNewFileExtension_TextChanged);
      // 
      // ChangeFileExtensionTaskEditControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.txtNewFileExtension);
      this.Controls.Add(this.labelNewFileExtenions);
      this.Name = "ChangeFileExtensionTaskEditControl";
      this.Size = new System.Drawing.Size(308, 149);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelNewFileExtenions;
    private System.Windows.Forms.TextBox txtNewFileExtension;
  }
}
