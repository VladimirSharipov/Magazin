namespace Magazin
{
	partial class Goods
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
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridViewTovar = new System.Windows.Forms.DataGridView();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTovar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(77, 69);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(110, 101);
			this.button1.TabIndex = 0;
			this.button1.Text = "Товары";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGridViewTovar
			// 
			this.dataGridViewTovar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTovar.Location = new System.Drawing.Point(12, 195);
			this.dataGridViewTovar.Name = "dataGridViewTovar";
			this.dataGridViewTovar.RowTemplate.Height = 25;
			this.dataGridViewTovar.Size = new System.Drawing.Size(755, 107);
			this.dataGridViewTovar.TabIndex = 1;
			this.dataGridViewTovar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTovar_CellContentClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 335);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.Size = new System.Drawing.Size(755, 103);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTovar_CellContentClick);
			// 
			// Goods
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.dataGridViewTovar);
			this.Controls.Add(this.button1);
			this.Name = "Goods";
			this.Text = "Goods";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTovar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Button button1;
		private DataGridView dataGridViewTovar;
		private DataGridView dataGridView1;
	}
}