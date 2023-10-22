namespace Magazin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnAdd = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnReadUsers = new System.Windows.Forms.Button();
			this.dtp3 = new System.Windows.Forms.DateTimePicker();
			this.dtp2 = new System.Windows.Forms.DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(35, 159);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.Size = new System.Drawing.Size(675, 234);
			this.dataGridView1.TabIndex = 0;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(12, 81);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(141, 63);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "dobavit";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAdd_MouseClick);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(176, 35);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(269, 23);
			this.textBox1.TabIndex = 2;
			// 
			// btnReadUsers
			// 
			this.btnReadUsers.Location = new System.Drawing.Point(35, 12);
			this.btnReadUsers.Name = "btnReadUsers";
			this.btnReadUsers.Size = new System.Drawing.Size(75, 63);
			this.btnReadUsers.TabIndex = 3;
			this.btnReadUsers.Text = "показать Users";
			this.btnReadUsers.UseVisualStyleBackColor = true;
			this.btnReadUsers.Click += new System.EventHandler(this.btnReadUsers_Click);
			// 
			// dtp3
			// 
			this.dtp3.Location = new System.Drawing.Point(397, 81);
			this.dtp3.Name = "dtp3";
			this.dtp3.Size = new System.Drawing.Size(200, 23);
			this.dtp3.TabIndex = 4;
			// 
			// dtp2
			// 
			this.dtp2.Location = new System.Drawing.Point(176, 81);
			this.dtp2.Name = "dtp2";
			this.dtp2.Size = new System.Drawing.Size(200, 23);
			this.dtp2.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(494, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(103, 46);
			this.button1.TabIndex = 6;
			this.button1.Text = "Goods";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dtp2);
			this.Controls.Add(this.dtp3);
			this.Controls.Add(this.btnReadUsers);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAdd;
        private TextBox textBox1;
        private Button btnReadUsers;
		private DateTimePicker dtp3;
		private DateTimePicker dtp2;
		private Button button1;
	}
}