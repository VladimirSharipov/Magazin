namespace Magazin
{
    partial class AddUsers
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUsers));
			this.btnSafe = new System.Windows.Forms.Button();
			this.txtBxName = new System.Windows.Forms.TextBox();
			this.txtBxLogin = new System.Windows.Forms.TextBox();
			this.txtBxPass = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnSafe
			// 
			resources.ApplyResources(this.btnSafe, "btnSafe");
			this.btnSafe.Name = "btnSafe";
			this.btnSafe.UseVisualStyleBackColor = true;
			this.btnSafe.Click += new System.EventHandler(this.btnSafe_Click);
			// 
			// txtBxName
			// 
			resources.ApplyResources(this.txtBxName, "txtBxName");
			this.txtBxName.Name = "txtBxName";
			// 
			// txtBxLogin
			// 
			resources.ApplyResources(this.txtBxLogin, "txtBxLogin");
			this.txtBxLogin.Name = "txtBxLogin";
			// 
			// txtBxPass
			// 
			resources.ApplyResources(this.txtBxPass, "txtBxPass");
			this.txtBxPass.Name = "txtBxPass";
			// 
			// dateTimePicker1
			// 
			resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
			this.dateTimePicker1.Name = "dateTimePicker1";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// AddUsers
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.txtBxPass);
			this.Controls.Add(this.txtBxLogin);
			this.Controls.Add(this.txtBxName);
			this.Controls.Add(this.btnSafe);
			this.Name = "AddUsers";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Button btnSafe;
        private TextBox txtBxName;
        private TextBox txtBxLogin;
        private TextBox txtBxPass;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}