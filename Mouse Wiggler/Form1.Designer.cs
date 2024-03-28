namespace Mouse_Wiggler
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
			this.btnExit = new System.Windows.Forms.Button();
			this.btnToggle = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnExit
			// 
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Location = new System.Drawing.Point(174, 12);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnToggle
			// 
			this.btnToggle.Location = new System.Drawing.Point(12, 12);
			this.btnToggle.Name = "btnToggle";
			this.btnToggle.Size = new System.Drawing.Size(156, 23);
			this.btnToggle.TabIndex = 1;
			this.btnToggle.Text = "Start";
			this.btnToggle.UseVisualStyleBackColor = true;
			this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
			// 
			// Form1
			// 
			this.AcceptButton = this.btnToggle;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(264, 49);
			this.Controls.Add(this.btnToggle);
			this.Controls.Add(this.btnExit);
			this.KeyPreview = true;
			this.Name = "Form1";
			this.Text = "Wiggler";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnToggle;
	}
}

