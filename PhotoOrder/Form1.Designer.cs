namespace PhotoOrder
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
      this.cmbSizes = new System.Windows.Forms.ComboBox();
      this.txtPrice = new System.Windows.Forms.TextBox();
      this.buttCalc = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // cmbSizes
      // 
      this.cmbSizes.FormattingEnabled = true;
      this.cmbSizes.Location = new System.Drawing.Point(185, 28);
      this.cmbSizes.Name = "cmbSizes";
      this.cmbSizes.Size = new System.Drawing.Size(121, 33);
      this.cmbSizes.TabIndex = 0;
      // 
      // txtPrice
      // 
      this.txtPrice.Location = new System.Drawing.Point(185, 84);
      this.txtPrice.Name = "txtPrice";
      this.txtPrice.Size = new System.Drawing.Size(121, 31);
      this.txtPrice.TabIndex = 1;
      // 
      // buttCalc
      // 
      this.buttCalc.Location = new System.Drawing.Point(91, 162);
      this.buttCalc.Name = "buttCalc";
      this.buttCalc.Size = new System.Drawing.Size(160, 36);
      this.buttCalc.TabIndex = 2;
      this.buttCalc.Text = "Caculate Price";
      this.buttCalc.UseVisualStyleBackColor = true;
      this.buttCalc.Click += new System.EventHandler(this.buttCalc_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(29, 28);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(120, 25);
      this.label1.TabIndex = 3;
      this.label1.Text = "Select Size";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(29, 84);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(61, 25);
      this.label2.TabIndex = 4;
      this.label2.Text = "Price";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(340, 224);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.buttCalc);
      this.Controls.Add(this.txtPrice);
      this.Controls.Add(this.cmbSizes);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cmbSizes;
    private System.Windows.Forms.TextBox txtPrice;
    private System.Windows.Forms.Button buttCalc;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
  }
}

