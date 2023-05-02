namespace RedBox
{
    partial class RedBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RedBox));
            this.butLogIn = new System.Windows.Forms.Button();
            this.txtCWID = new System.Windows.Forms.TextBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.lblFullname = new System.Windows.Forms.Label();
            this.lblCWID = new System.Windows.Forms.Label();
            this.txtWelcome = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblRemind = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // butLogIn
            // 
            this.butLogIn.Location = new System.Drawing.Point(353, 252);
            this.butLogIn.Name = "butLogIn";
            this.butLogIn.Size = new System.Drawing.Size(75, 23);
            this.butLogIn.TabIndex = 0;
            this.butLogIn.Text = "Log In";
            this.butLogIn.UseVisualStyleBackColor = true;
            this.butLogIn.Click += new System.EventHandler(this.butLogIn_Click);
            // 
            // txtCWID
            // 
            this.txtCWID.Location = new System.Drawing.Point(300, 212);
            this.txtCWID.Name = "txtCWID";
            this.txtCWID.Size = new System.Drawing.Size(188, 20);
            this.txtCWID.TabIndex = 1;
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(300, 173);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(188, 20);
            this.txtFullname.TabIndex = 2;
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullname.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFullname.Location = new System.Drawing.Point(229, 173);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(63, 13);
            this.lblFullname.TabIndex = 3;
            this.lblFullname.Text = "Username";
            // 
            // lblCWID
            // 
            this.lblCWID.AutoSize = true;
            this.lblCWID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCWID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCWID.Location = new System.Drawing.Point(229, 215);
            this.lblCWID.Name = "lblCWID";
            this.lblCWID.Size = new System.Drawing.Size(61, 13);
            this.lblCWID.TabIndex = 4;
            this.lblCWID.Text = "Password";
            // 
            // txtWelcome
            // 
            this.txtWelcome.AutoSize = true;
            this.txtWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWelcome.ForeColor = System.Drawing.SystemColors.Control;
            this.txtWelcome.Location = new System.Drawing.Point(296, 133);
            this.txtWelcome.Name = "txtWelcome";
            this.txtWelcome.Size = new System.Drawing.Size(206, 24);
            this.txtWelcome.TabIndex = 5;
            this.txtWelcome.Text = "Welcome to Redbox!\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 6;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(300, 60);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(181, 41);
            this.picLogo.TabIndex = 7;
            this.picLogo.TabStop = false;
            // 
            // lblRemind
            // 
            this.lblRemind.AutoSize = true;
            this.lblRemind.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemind.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRemind.Location = new System.Drawing.Point(229, 290);
            this.lblRemind.Name = "lblRemind";
            this.lblRemind.Size = new System.Drawing.Size(295, 12);
            this.lblRemind.TabIndex = 8;
            this.lblRemind.Text = "*Username is FirstnameLastname and Password is CWID";
            // 
            // RedBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRemind);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWelcome);
            this.Controls.Add(this.lblCWID);
            this.Controls.Add(this.lblFullname);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.txtCWID);
            this.Controls.Add(this.butLogIn);
            this.Name = "RedBox";
            this.Text = "RedBox";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butLogIn;
        private System.Windows.Forms.TextBox txtCWID;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Label lblCWID;
        private System.Windows.Forms.Label txtWelcome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblRemind;
    }
}

