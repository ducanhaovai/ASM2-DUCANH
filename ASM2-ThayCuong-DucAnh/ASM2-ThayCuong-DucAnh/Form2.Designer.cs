namespace ASM2_ThayCuong_DucAnh
{
    partial class fRegister
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIDR = new System.Windows.Forms.TextBox();
            this.tbUsernameR = new System.Windows.Forms.TextBox();
            this.tbPasswordR = new System.Windows.Forms.TextBox();
            this.btRegister = new System.Windows.Forms.Button();
            this.btExitR = new System.Windows.Forms.Button();
            this.btLoginR = new System.Windows.Forms.Button();
            this.Do = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbRComfim = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbIDR
            // 
            this.tbIDR.Location = new System.Drawing.Point(210, 114);
            this.tbIDR.Name = "tbIDR";
            this.tbIDR.Size = new System.Drawing.Size(204, 22);
            this.tbIDR.TabIndex = 1;
            // 
            // tbUsernameR
            // 
            this.tbUsernameR.Location = new System.Drawing.Point(210, 177);
            this.tbUsernameR.Name = "tbUsernameR";
            this.tbUsernameR.Size = new System.Drawing.Size(204, 22);
            this.tbUsernameR.TabIndex = 1;
            this.tbUsernameR.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbPasswordR
            // 
            this.tbPasswordR.Location = new System.Drawing.Point(210, 244);
            this.tbPasswordR.Name = "tbPasswordR";
            this.tbPasswordR.Size = new System.Drawing.Size(204, 22);
            this.tbPasswordR.TabIndex = 1;
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(210, 348);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(75, 35);
            this.btRegister.TabIndex = 2;
            this.btRegister.Text = "Register";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // btExitR
            // 
            this.btExitR.Location = new System.Drawing.Point(339, 348);
            this.btExitR.Name = "btExitR";
            this.btExitR.Size = new System.Drawing.Size(75, 35);
            this.btExitR.TabIndex = 2;
            this.btExitR.Text = "Exit";
            this.btExitR.UseVisualStyleBackColor = true;
            this.btExitR.Click += new System.EventHandler(this.btExitR_Click);
            // 
            // btLoginR
            // 
            this.btLoginR.Location = new System.Drawing.Point(339, 426);
            this.btLoginR.Name = "btLoginR";
            this.btLoginR.Size = new System.Drawing.Size(75, 35);
            this.btLoginR.TabIndex = 2;
            this.btLoginR.Text = "Login";
            this.btLoginR.UseVisualStyleBackColor = true;
            this.btLoginR.Click += new System.EventHandler(this.button3_Click);
            // 
            // Do
            // 
            this.Do.AutoSize = true;
            this.Do.Location = new System.Drawing.Point(116, 435);
            this.Do.Name = "Do";
            this.Do.Size = new System.Drawing.Size(206, 17);
            this.Do.TabIndex = 0;
            this.Do.Text = "Do you have account? Click me";
            this.Do.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(213, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter your information";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Confim Password";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbRComfim
            // 
            this.tbRComfim.Location = new System.Drawing.Point(210, 302);
            this.tbRComfim.Name = "tbRComfim";
            this.tbRComfim.Size = new System.Drawing.Size(204, 22);
            this.tbRComfim.TabIndex = 1;
            // 
            // fRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 501);
            this.Controls.Add(this.btLoginR);
            this.Controls.Add(this.btExitR);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.tbRComfim);
            this.Controls.Add(this.tbPasswordR);
            this.Controls.Add(this.tbUsernameR);
            this.Controls.Add(this.tbIDR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Do);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "fRegister";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.fRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIDR;
        private System.Windows.Forms.TextBox tbUsernameR;
        private System.Windows.Forms.TextBox tbPasswordR;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Button btExitR;
        private System.Windows.Forms.Button btLoginR;
        private System.Windows.Forms.Label Do;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbRComfim;
    }
}