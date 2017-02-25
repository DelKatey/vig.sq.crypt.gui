namespace VigenereSquareCryptor_GUI
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.inputTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.keyTB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resultTB = new System.Windows.Forms.RichTextBox();
            this.doButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dRadioButton = new System.Windows.Forms.RadioButton();
            this.eRadioButton = new System.Windows.Forms.RadioButton();
            this.aboutButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTB
            // 
            this.inputTB.Location = new System.Drawing.Point(55, 19);
            this.inputTB.Multiline = true;
            this.inputTB.Name = "inputTB";
            this.inputTB.Size = new System.Drawing.Size(177, 34);
            this.inputTB.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.keyTB);
            this.groupBox1.Controls.Add(this.inputTB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 87);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Key:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input:";
            // 
            // keyTB
            // 
            this.keyTB.Location = new System.Drawing.Point(55, 59);
            this.keyTB.Name = "keyTB";
            this.keyTB.Size = new System.Drawing.Size(177, 20);
            this.keyTB.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resultTB);
            this.groupBox2.Location = new System.Drawing.Point(12, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(7);
            this.groupBox2.Size = new System.Drawing.Size(270, 81);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // resultTB
            // 
            this.resultTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultTB.Location = new System.Drawing.Point(7, 20);
            this.resultTB.Name = "resultTB";
            this.resultTB.Size = new System.Drawing.Size(256, 54);
            this.resultTB.TabIndex = 0;
            this.resultTB.Text = "";
            // 
            // doButton
            // 
            this.doButton.Location = new System.Drawing.Point(288, 105);
            this.doButton.Name = "doButton";
            this.doButton.Size = new System.Drawing.Size(51, 38);
            this.doButton.TabIndex = 3;
            this.doButton.Text = "Go";
            this.doButton.UseVisualStyleBackColor = true;
            this.doButton.Click += new System.EventHandler(this.DoButtonClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dRadioButton);
            this.groupBox3.Controls.Add(this.eRadioButton);
            this.groupBox3.Location = new System.Drawing.Point(256, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(83, 87);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // dRadioButton
            // 
            this.dRadioButton.AutoSize = true;
            this.dRadioButton.Location = new System.Drawing.Point(8, 49);
            this.dRadioButton.Name = "dRadioButton";
            this.dRadioButton.Size = new System.Drawing.Size(62, 17);
            this.dRadioButton.TabIndex = 1;
            this.dRadioButton.Text = "Decrypt";
            this.dRadioButton.UseVisualStyleBackColor = true;
            // 
            // eRadioButton
            // 
            this.eRadioButton.AutoSize = true;
            this.eRadioButton.Checked = true;
            this.eRadioButton.Location = new System.Drawing.Point(8, 26);
            this.eRadioButton.Name = "eRadioButton";
            this.eRadioButton.Size = new System.Drawing.Size(61, 17);
            this.eRadioButton.TabIndex = 0;
            this.eRadioButton.TabStop = true;
            this.eRadioButton.Text = "Encrypt";
            this.eRadioButton.UseVisualStyleBackColor = true;
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(291, 147);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(48, 39);
            this.aboutButton.TabIndex = 5;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.AboutButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 198);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.doButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Vigenere Square Cryptor - GUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }
		private System.Windows.Forms.RadioButton eRadioButton;
		private System.Windows.Forms.RadioButton dRadioButton;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button doButton;
		private System.Windows.Forms.RichTextBox resultTB;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox keyTB;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox inputTB;
        private System.Windows.Forms.Button aboutButton;
	}
}
