namespace FancyFileRenamer.TaskEditControls
{
  partial class ClearEntireFilenameTaskEditControl
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
      this.checkClearExtensions = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // checkClearExtensions
      // 
      this.checkClearExtensions.AutoSize = true;
      this.checkClearExtensions.Location = new System.Drawing.Point(18, 25);
      this.checkClearExtensions.Name = "checkClearExtensions";
      this.checkClearExtensions.Size = new System.Drawing.Size(119, 17);
      this.checkClearExtensions.TabIndex = 0;
      this.checkClearExtensions.Text = "Clear file extensions";
      this.checkClearExtensions.UseVisualStyleBackColor = true;
      // 
      // ClearEntireFilenameTaskEditControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.checkClearExtensions);
      this.Name = "ClearEntireFilenameTaskEditControl";
      this.Size = new System.Drawing.Size(321, 257);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.CheckBox checkClearExtensions;
  }
}
