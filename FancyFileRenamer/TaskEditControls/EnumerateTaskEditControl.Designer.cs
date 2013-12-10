namespace FancyFileRenamer.TaskEditControls
{
  partial class EnumerateTaskEditControl
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
      this.numStartAt = new System.Windows.Forms.NumericUpDown();
      this.txtFormat = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.comboInsertAt = new System.Windows.Forms.ComboBox();
      this.labelInsertAt = new System.Windows.Forms.Label();
      this.numCustomPosition = new System.Windows.Forms.NumericUpDown();
      this.labelCustomPosition = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.numStartAt)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numCustomPosition)).BeginInit();
      this.SuspendLayout();
      // 
      // numStartAt
      // 
      this.numStartAt.Location = new System.Drawing.Point(91, 55);
      this.numStartAt.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.numStartAt.Name = "numStartAt";
      this.numStartAt.Size = new System.Drawing.Size(72, 20);
      this.numStartAt.TabIndex = 0;
      this.numStartAt.ValueChanged += new System.EventHandler(this.numStartAt_ValueChanged);
      // 
      // txtFormat
      // 
      this.txtFormat.Location = new System.Drawing.Point(222, 54);
      this.txtFormat.Name = "txtFormat";
      this.txtFormat.Size = new System.Drawing.Size(100, 20);
      this.txtFormat.TabIndex = 1;
      this.txtFormat.Text = "00";
      this.txtFormat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.txtFormat.TextChanged += new System.EventHandler(this.txtFormat_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 57);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(51, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Start with";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(177, 57);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(39, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Format";
      // 
      // comboInsertAt
      // 
      this.comboInsertAt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboInsertAt.FormattingEnabled = true;
      this.comboInsertAt.Location = new System.Drawing.Point(91, 97);
      this.comboInsertAt.Name = "comboInsertAt";
      this.comboInsertAt.Size = new System.Drawing.Size(121, 21);
      this.comboInsertAt.TabIndex = 4;
      this.comboInsertAt.SelectedIndexChanged += new System.EventHandler(this.comboInsertAt_SelectedIndexChanged);
      // 
      // labelInsertAt
      // 
      this.labelInsertAt.AutoSize = true;
      this.labelInsertAt.Location = new System.Drawing.Point(3, 100);
      this.labelInsertAt.Name = "labelInsertAt";
      this.labelInsertAt.Size = new System.Drawing.Size(45, 13);
      this.labelInsertAt.TabIndex = 5;
      this.labelInsertAt.Text = "Insert at";
      // 
      // numCustomPosition
      // 
      this.numCustomPosition.Location = new System.Drawing.Point(91, 138);
      this.numCustomPosition.Name = "numCustomPosition";
      this.numCustomPosition.Size = new System.Drawing.Size(72, 20);
      this.numCustomPosition.TabIndex = 6;
      this.numCustomPosition.ValueChanged += new System.EventHandler(this.numCustomPosition_ValueChanged);
      // 
      // labelCustomPosition
      // 
      this.labelCustomPosition.AutoSize = true;
      this.labelCustomPosition.Location = new System.Drawing.Point(3, 140);
      this.labelCustomPosition.Name = "labelCustomPosition";
      this.labelCustomPosition.Size = new System.Drawing.Size(81, 13);
      this.labelCustomPosition.TabIndex = 7;
      this.labelCustomPosition.Text = "Custom position";
      // 
      // EnumerateTaskEditControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.labelCustomPosition);
      this.Controls.Add(this.numCustomPosition);
      this.Controls.Add(this.labelInsertAt);
      this.Controls.Add(this.comboInsertAt);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtFormat);
      this.Controls.Add(this.numStartAt);
      this.Name = "EnumerateTaskEditControl";
      this.Size = new System.Drawing.Size(348, 182);
      ((System.ComponentModel.ISupportInitialize)(this.numStartAt)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numCustomPosition)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.NumericUpDown numStartAt;
    private System.Windows.Forms.TextBox txtFormat;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox comboInsertAt;
    private System.Windows.Forms.Label labelInsertAt;
    private System.Windows.Forms.NumericUpDown numCustomPosition;
    private System.Windows.Forms.Label labelCustomPosition;
  }
}
