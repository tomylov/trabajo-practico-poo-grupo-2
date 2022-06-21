namespace vista
{
    partial class vista_admin
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
            this.btnuser = new System.Windows.Forms.Button();
            this.btnart = new System.Windows.Forms.Button();
            this.btnprov = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnuser
            // 
            this.btnuser.Location = new System.Drawing.Point(121, 49);
            this.btnuser.Name = "btnuser";
            this.btnuser.Size = new System.Drawing.Size(75, 36);
            this.btnuser.TabIndex = 0;
            this.btnuser.Text = "gestionar usuario";
            this.btnuser.UseVisualStyleBackColor = true;
            this.btnuser.Click += new System.EventHandler(this.btnuser_Click);
            // 
            // btnart
            // 
            this.btnart.Location = new System.Drawing.Point(121, 104);
            this.btnart.Name = "btnart";
            this.btnart.Size = new System.Drawing.Size(75, 36);
            this.btnart.TabIndex = 1;
            this.btnart.Text = "gestionar articulos";
            this.btnart.UseVisualStyleBackColor = true;
            this.btnart.Click += new System.EventHandler(this.btnart_Click);
            // 
            // btnprov
            // 
            this.btnprov.Location = new System.Drawing.Point(121, 155);
            this.btnprov.Name = "btnprov";
            this.btnprov.Size = new System.Drawing.Size(75, 36);
            this.btnprov.TabIndex = 2;
            this.btnprov.Text = "gestionar proveedores";
            this.btnprov.UseVisualStyleBackColor = true;
            this.btnprov.Click += new System.EventHandler(this.btnprov_Click);
            // 
            // vista_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 239);
            this.Controls.Add(this.btnprov);
            this.Controls.Add(this.btnart);
            this.Controls.Add(this.btnuser);
            this.Name = "vista_admin";
            this.Text = "vista_admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnuser;
        private System.Windows.Forms.Button btnart;
        private System.Windows.Forms.Button btnprov;
    }
}