namespace FancyFileRenamer.TaskEditControls
{
  partial class InsertTaskEditControl
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
      this.numPosition = new System.Windows.Forms.NumericUpDown();
      this.textInsertValue = new System.Windows.Forms.TextBox();
      this.labelPosition = new System.Windows.Forms.Label();
      this.labelInsert = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.numPosition)).BeginInit();
      this.SuspendLayout();
      // 
      // numPosition
      // 
      this.numPosition.Location = new System.Drawing.Point(3, 100);
      this.numPosition.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.numPosition.Name = "numPosition";
      this.numPosition.Size = new System.Drawing.Size(120, 20);
      this.numPosition.TabIndex = 7;
      this.numPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // textInsertValue
      // 
      this.textInsertValue.Location = new System.Drawing.Point(3, 27);
      this.textInsertValue.Name = "textInsertValue";
      this.textInsertValue.Size = new System.Drawing.Size(334, 20);
      this.textInsertValue.TabIndex = 6;
      this.textInsertValue.TextChanged += new System.EventHandler(this.textInsertValue_TextChanged);
      // 
      // labelPosition
      // 
      this.labelPosition.AutoSize = true;
      this.labelPosition.Location = new System.Drawing.Point(3, 84);
      this.labelPosition.Name = "labelPosition";
      this.labelPosition.Size = new System.Drawing.Size(56, 13);
      this.labelPosition.TabIndex = 5;
      this.labelPosition.Text = "at Position";
      // 
      // labelInsert
      // 
      this.labelInsert.AutoSize = true;
      this.labelInsert.Location = new System.Drawing.Point(3, 11);
      this.labelInsert.Name = "labelInsert";
      this.labelInsert.Size = new System.Drawing.Size(33, 13);
      this.labelInsert.TabIndex = 4;
      this.labelInsert.Text = "Insert";
      // 
      // InsertTaskEditControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.labelInsert);
      this.Controls.Add(this.labelPosition);
      this.Controls.Add(this.textInsertValue);
      this.Controls.Add(this.numPosition);
      this.Name = "InsertTaskEditControl";
      this.Size = new System.Drawing.Size(340, 301);
      ((System.ComponentModel.ISupportInitialize)(this.numPosition)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.NumericUpDown numPosition;
    private System.Windows.Forms.TextBox textInsertValue;
    private System.Windows.Forms.Label labelPosition;
    private System.Windows.Forms.Label labelInsert;
  }
}
