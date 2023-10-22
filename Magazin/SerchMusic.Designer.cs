namespace Magazin
{
	partial class SerchMusic
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
			textBox1 = new TextBox();
			dataGridView1 = new DataGridView();
			btnDonwload = new Button();
			btnGetMusic = new Button();
			btnAudio = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(136, 12);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(472, 23);
			textBox1.TabIndex = 1;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(325, 72);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(868, 620);
			dataGridView1.TabIndex = 2;
			// 
			// btnDonwload
			// 
			btnDonwload.Location = new Point(70, 139);
			btnDonwload.Name = "btnDonwload";
			btnDonwload.Size = new Size(75, 112);
			btnDonwload.TabIndex = 3;
			btnDonwload.Text = "скачать";
			btnDonwload.UseVisualStyleBackColor = true;
			btnDonwload.Click += btnDonwload_Click;
			// 
			// btnGetMusic
			// 
			btnGetMusic.Location = new Point(215, 139);
			btnGetMusic.Name = "btnGetMusic";
			btnGetMusic.Size = new Size(75, 112);
			btnGetMusic.TabIndex = 3;
			btnGetMusic.Text = "Музыка";
			btnGetMusic.UseVisualStyleBackColor = true;
			btnGetMusic.Click += btnGetMusic_Click;
			// 
			// btnAudio
			// 
			btnAudio.Location = new Point(45, 305);
			btnAudio.Name = "btnAudio";
			btnAudio.Size = new Size(128, 90);
			btnAudio.TabIndex = 4;
			btnAudio.Text = "Слушать";
			btnAudio.UseVisualStyleBackColor = true;
			btnAudio.Click += btnAudio_Click;
			// 
			// SerchMusic
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1205, 717);
			Controls.Add(btnAudio);
			Controls.Add(btnGetMusic);
			Controls.Add(btnDonwload);
			Controls.Add(dataGridView1);
			Controls.Add(textBox1);
			Name = "SerchMusic";
			Text = "SerchMusic";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private DataGridView dataGridView1;
		private Button btnDonwload;
		private Button btnGetMusic;
		private Button btnAudio;
	}
}