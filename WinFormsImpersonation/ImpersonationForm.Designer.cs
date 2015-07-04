namespace WinFormsImpersonation
{
    partial class ImpersonationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnImpersonate = new System.Windows.Forms.Button();
            this.lblDomain = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.btnRevert = new System.Windows.Forms.Button();
            this.lblRunningAs = new System.Windows.Forms.Label();
            this.lblIdentity = new System.Windows.Forms.Label();
            this.btnExecuteQuery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImpersonate
            // 
            this.btnImpersonate.Location = new System.Drawing.Point( 68, 99 );
            this.btnImpersonate.Name = "btnImpersonate";
            this.btnImpersonate.Size = new System.Drawing.Size( 75, 23 );
            this.btnImpersonate.TabIndex = 6;
            this.btnImpersonate.Text = "Impersonate";
            this.btnImpersonate.UseVisualStyleBackColor = true;
            this.btnImpersonate.Click += new System.EventHandler( this.btnImpersonate_Click );
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Location = new System.Drawing.Point( 50, 15 );
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size( 46, 13 );
            this.lblDomain.TabIndex = 0;
            this.lblDomain.Text = "Domain:";
            this.lblDomain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point( 50, 41 );
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size( 58, 13 );
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point( 50, 67 );
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size( 56, 13 );
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point( 114, 64 );
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size( 128, 20 );
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point( 114, 38 );
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size( 128, 20 );
            this.txtUsername.TabIndex = 3;
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point( 114, 12 );
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size( 128, 20 );
            this.txtDomain.TabIndex = 1;
            // 
            // btnRevert
            // 
            this.btnRevert.Enabled = false;
            this.btnRevert.Location = new System.Drawing.Point( 149, 99 );
            this.btnRevert.Name = "btnRevert";
            this.btnRevert.Size = new System.Drawing.Size( 75, 23 );
            this.btnRevert.TabIndex = 7;
            this.btnRevert.Text = "Revert";
            this.btnRevert.UseVisualStyleBackColor = true;
            this.btnRevert.Click += new System.EventHandler( this.btnRevert_Click );
            // 
            // lblRunningAs
            // 
            this.lblRunningAs.AutoSize = true;
            this.lblRunningAs.Location = new System.Drawing.Point( 65, 134 );
            this.lblRunningAs.Name = "lblRunningAs";
            this.lblRunningAs.Size = new System.Drawing.Size( 65, 13 );
            this.lblRunningAs.TabIndex = 8;
            this.lblRunningAs.Text = "Running As:";
            // 
            // lblIdentity
            // 
            this.lblIdentity.AutoSize = true;
            this.lblIdentity.Location = new System.Drawing.Point( 146, 134 );
            this.lblIdentity.Name = "lblIdentity";
            this.lblIdentity.Size = new System.Drawing.Size( 0, 13 );
            this.lblIdentity.TabIndex = 9;
            // 
            // btnExecuteQuery
            // 
            this.btnExecuteQuery.Location = new System.Drawing.Point( 91, 160 );
            this.btnExecuteQuery.Name = "btnExecuteQuery";
            this.btnExecuteQuery.Size = new System.Drawing.Size( 110, 23 );
            this.btnExecuteQuery.TabIndex = 10;
            this.btnExecuteQuery.Text = "Execute Query";
            this.btnExecuteQuery.UseVisualStyleBackColor = true;
            this.btnExecuteQuery.Click += new System.EventHandler( this.btnExecuteQuery_Click );
            // 
            // ImpersonationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 292, 193 );
            this.Controls.Add( this.btnExecuteQuery );
            this.Controls.Add( this.lblIdentity );
            this.Controls.Add( this.lblRunningAs );
            this.Controls.Add( this.btnRevert );
            this.Controls.Add( this.txtDomain );
            this.Controls.Add( this.txtUsername );
            this.Controls.Add( this.txtPassword );
            this.Controls.Add( this.lblPassword );
            this.Controls.Add( this.lblUsername );
            this.Controls.Add( this.lblDomain );
            this.Controls.Add( this.btnImpersonate );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImpersonationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinForms Impersonation";
            this.Load += new System.EventHandler( this.ImpersonationForm_Load );
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImpersonate;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Button btnRevert;
        private System.Windows.Forms.Label lblRunningAs;
        private System.Windows.Forms.Label lblIdentity;
        private System.Windows.Forms.Button btnExecuteQuery;
    }
}

