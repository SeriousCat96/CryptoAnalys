namespace lab2
{
	partial class MainForm
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
			if(disposing && (components != null))
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
			this.rtbInput = new System.Windows.Forms.RichTextBox();
			this.rtbOutput = new System.Windows.Forms.RichTextBox();
			this.btnEncrypt = new System.Windows.Forms.Button();
			this.btnDecrypt = new System.Windows.Forms.Button();
			this.tbKey = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// rtbInput
			// 
			this.rtbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rtbInput.Location = new System.Drawing.Point(12, 12);
			this.rtbInput.Name = "rtbInput";
			this.rtbInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			this.rtbInput.Size = new System.Drawing.Size(291, 287);
			this.rtbInput.TabIndex = 1;
			this.rtbInput.Text = "";
			// 
			// rtbOutput
			// 
			this.rtbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rtbOutput.Location = new System.Drawing.Point(477, 12);
			this.rtbOutput.Name = "rtbOutput";
			this.rtbOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			this.rtbOutput.Size = new System.Drawing.Size(291, 287);
			this.rtbOutput.TabIndex = 2;
			this.rtbOutput.Text = "";
			// 
			// btnEncrypt
			// 
			this.btnEncrypt.Location = new System.Drawing.Point(309, 176);
			this.btnEncrypt.Name = "btnEncrypt";
			this.btnEncrypt.Size = new System.Drawing.Size(162, 23);
			this.btnEncrypt.TabIndex = 3;
			this.btnEncrypt.Text = "Encrypt >>";
			this.btnEncrypt.UseVisualStyleBackColor = true;
			// 
			// btnDecrypt
			// 
			this.btnDecrypt.Location = new System.Drawing.Point(309, 205);
			this.btnDecrypt.Name = "btnDecrypt";
			this.btnDecrypt.Size = new System.Drawing.Size(162, 23);
			this.btnDecrypt.TabIndex = 4;
			this.btnDecrypt.Text = "<< Decrypt";
			this.btnDecrypt.UseVisualStyleBackColor = true;
			// 
			// tbKey
			// 
			this.tbKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbKey.Location = new System.Drawing.Point(310, 12);
			this.tbKey.MaxLength = 128;
			this.tbKey.Name = "tbKey";
			this.tbKey.Size = new System.Drawing.Size(161, 22);
			this.tbKey.TabIndex = 5;
			this.tbKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(784, 311);
			this.Controls.Add(this.tbKey);
			this.Controls.Add(this.btnDecrypt);
			this.Controls.Add(this.btnEncrypt);
			this.Controls.Add(this.rtbOutput);
			this.Controls.Add(this.rtbInput);
			this.MinimumSize = new System.Drawing.Size(600, 200);
			this.Name = "MainForm";
			this.Text = "Lab 2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox rtbInput;
		private System.Windows.Forms.RichTextBox rtbOutput;
		private System.Windows.Forms.Button btnEncrypt;
		private System.Windows.Forms.Button btnDecrypt;
		private System.Windows.Forms.TextBox tbKey;
	}
}

