namespace lab4
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
			this.rtbReturnedKey = new System.Windows.Forms.RichTextBox();
			this.btnMakeNewKey = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// rtbReturnedKey
			// 
			this.rtbReturnedKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbReturnedKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rtbReturnedKey.Location = new System.Drawing.Point(13, 13);
			this.rtbReturnedKey.Name = "rtbReturnedKey";
			this.rtbReturnedKey.ReadOnly = true;
			this.rtbReturnedKey.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			this.rtbReturnedKey.Size = new System.Drawing.Size(649, 200);
			this.rtbReturnedKey.TabIndex = 1;
			this.rtbReturnedKey.TabStop = false;
			this.rtbReturnedKey.Text = "";
			this.rtbReturnedKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbReturnedKey_KeyPress);
			// 
			// btnMakeNewKey
			// 
			this.btnMakeNewKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnMakeNewKey.Location = new System.Drawing.Point(12, 219);
			this.btnMakeNewKey.Name = "btnMakeNewKey";
			this.btnMakeNewKey.Size = new System.Drawing.Size(198, 23);
			this.btnMakeNewKey.TabIndex = 0;
			this.btnMakeNewKey.Text = "New Key";
			this.btnMakeNewKey.UseVisualStyleBackColor = true;
			this.btnMakeNewKey.Click += new System.EventHandler(this.OnbtnMakeNewKey_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(674, 251);
			this.Controls.Add(this.btnMakeNewKey);
			this.Controls.Add(this.rtbReturnedKey);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "lab 4";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox rtbReturnedKey;
		private System.Windows.Forms.Button btnMakeNewKey;
	}
}

