namespace vista
{
    partial class login
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
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.btnini = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(154, 92);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(100, 20);
            this.txtpass.TabIndex = 0;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(154, 41);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(100, 20);
            this.txtuser.TabIndex = 1;
            // 
            // btnini
            // 
            this.btnini.Location = new System.Drawing.Point(45, 163);
            this.btnini.Name = "btnini";
            this.btnini.Size = new System.Drawing.Size(86, 29);
            this.btnini.TabIndex = 2;
            this.btnini.Text = "iniciar sesion";
            this.btnini.UseVisualStyleBackColor = true;
            this.btnini.Click += new System.EventHandler(this.btnini_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "contraseña:";
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(179, 163);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(86, 29);
            this.btnclose.TabIndex = 5;
            this.btnclose.Text = "cerrar";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 243);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnini);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.txtpass);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Button btnini;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnclose;
    }
}