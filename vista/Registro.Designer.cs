namespace vista
{
    partial class Registro
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpass2 = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnnewuser = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(224, 49);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(135, 20);
            this.txtname.TabIndex = 0;
            // 
            // txtpass2
            // 
            this.txtpass2.Location = new System.Drawing.Point(224, 231);
            this.txtpass2.Name = "txtpass2";
            this.txtpass2.Size = new System.Drawing.Size(135, 20);
            this.txtpass2.TabIndex = 5;
            this.txtpass2.UseSystemPasswordChar = true;
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(224, 120);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(135, 20);
            this.txtdni.TabIndex = 2;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(224, 155);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(135, 20);
            this.txtmail.TabIndex = 3;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(224, 192);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(135, 20);
            this.txtpass.TabIndex = 4;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Confirmar Contraseña:";
            // 
            // btnnewuser
            // 
            this.btnnewuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnewuser.Location = new System.Drawing.Point(89, 285);
            this.btnnewuser.Name = "btnnewuser";
            this.btnnewuser.Size = new System.Drawing.Size(115, 60);
            this.btnnewuser.TabIndex = 6;
            this.btnnewuser.Text = "Crear Usuario";
            this.btnnewuser.UseVisualStyleBackColor = true;
            this.btnnewuser.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(245, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 60);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(224, 85);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(135, 20);
            this.txtphone.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(133, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Telefono:";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 400);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnnewuser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.txtpass2);
            this.Controls.Add(this.txtname);
            this.Name = "Registro";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpass2;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnnewuser;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label label6;
    }
}