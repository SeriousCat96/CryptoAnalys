namespace lab3
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
			this.rtb1 = new System.Windows.Forms.RichTextBox();
			this.tb1 = new System.Windows.Forms.TextBox();
			this.btnHash = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// rtb1
			// 
			this.rtb1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtb1.Location = new System.Drawing.Point(390, 13);
			this.rtb1.Name = "rtb1";
			this.rtb1.Size = new System.Drawing.Size(301, 415);
			this.rtb1.TabIndex = 0;
			this.rtb1.Text = "";
			// 
			// tb1
			// 
			this.tb1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.tb1.Location = new System.Drawing.Point(13, 13);
			this.tb1.Multiline = true;
			this.tb1.Name = "tb1";
			this.tb1.Size = new System.Drawing.Size(269, 190);
			this.tb1.TabIndex = 1;
			// 
			// btnHash
			// 
			this.btnHash.Location = new System.Drawing.Point(299, 45);
			this.btnHash.Name = "btnHash";
			this.btnHash.Size = new System.Drawing.Size(75, 37);
			this.btnHash.TabIndex = 2;
			this.btnHash.Text = ">>";
			this.btnHash.UseVisualStyleBackColor = true;
			this.btnHash.Click += new System.EventHandler(this.OnButtonHashClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(703, 440);
			this.Controls.Add(this.btnHash);
			this.Controls.Add(this.tb1);
			this.Controls.Add(this.rtb1);
			this.Name = "MainForm";
			this.Text = "Hash";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox rtb1;
		private System.Windows.Forms.TextBox tb1;
		private System.Windows.Forms.Button btnHash;
	}
}

