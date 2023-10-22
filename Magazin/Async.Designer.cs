namespace Magazin
{
	partial class Async
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
			this.btn1 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.lb = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn1
			// 
			this.btn1.Location = new System.Drawing.Point(193, 162);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(75, 23);
			this.btn1.TabIndex = 0;
			this.btn1.Text = "button1";
			this.btn1.UseVisualStyleBackColor = true;
			this.btn1.Click += new System.EventHandler(this.btn1_Click);
			// 
			// btn2
			// 
			this.btn2.Location = new System.Drawing.Point(343, 162);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(75, 23);
			this.btn2.TabIndex = 0;
			this.btn2.Text = "2";
			this.btn2.UseVisualStyleBackColor = true;
			// 
			// lb
			// 
			this.lb.AutoSize = true;
			this.lb.Location = new System.Drawing.Point(134, 162);
			this.lb.Name = "lb";
			this.lb.Size = new System.Drawing.Size(38, 15);
			this.lb.TabIndex = 1;
			this.lb.Text = "label1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(250, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// Async
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1087, 745);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lb);
			this.Controls.Add(this.btn2);
			this.Controls.Add(this.btn1);
			this.Name = "Async";
			this.Text = "Async";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button btn1;
		private Button btn2;
		private Label lb;
		private Label label1;
	}
}