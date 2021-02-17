
namespace DXFormUI
{
    partial class UserOperations
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
            this.dgwUser = new System.Windows.Forms.DataGridView();
            this.nameLbl = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.psswordLbl = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.deleteBtn = new DevExpress.XtraEditors.SimpleButton();
            this.addBtn = new DevExpress.XtraEditors.SimpleButton();
            this.updateBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwUser
            // 
            this.dgwUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwUser.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgwUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUser.Location = new System.Drawing.Point(0, 2);
            this.dgwUser.Name = "dgwUser";
            this.dgwUser.Size = new System.Drawing.Size(588, 173);
            this.dgwUser.TabIndex = 0;
            this.dgwUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUser_CellClick);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameLbl.Location = new System.Drawing.Point(12, 208);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(68, 15);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "First Name";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(96, 203);
            this.tbxName.Multiline = true;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(126, 25);
            this.tbxName.TabIndex = 2;
            // 
            // psswordLbl
            // 
            this.psswordLbl.AutoSize = true;
            this.psswordLbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.psswordLbl.Location = new System.Drawing.Point(284, 242);
            this.psswordLbl.Name = "psswordLbl";
            this.psswordLbl.Size = new System.Drawing.Size(59, 15);
            this.psswordLbl.TabIndex = 1;
            this.psswordLbl.Text = "Password";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(368, 237);
            this.tbxPassword.Multiline = true;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(126, 25);
            this.tbxPassword.TabIndex = 2;
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lastNameLbl.Location = new System.Drawing.Point(12, 242);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(65, 15);
            this.lastNameLbl.TabIndex = 1;
            this.lastNameLbl.Text = "Last Name";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(96, 237);
            this.tbxLastName.Multiline = true;
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(126, 25);
            this.tbxLastName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(287, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(368, 198);
            this.tbxEmail.Multiline = true;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(126, 25);
            this.tbxEmail.TabIndex = 2;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteBtn.Appearance.Options.UseFont = true;
            this.deleteBtn.ImageOptions.Image = global::DXFormUI.Properties.Resources.trash_16x16;
            this.deleteBtn.Location = new System.Drawing.Point(368, 307);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(89, 32);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addBtn.Appearance.Options.UseFont = true;
            this.addBtn.ImageOptions.Image = global::DXFormUI.Properties.Resources.add_16x16;
            this.addBtn.Location = new System.Drawing.Point(84, 307);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(89, 32);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateBtn.Appearance.Options.UseFont = true;
            this.updateBtn.ImageOptions.Image = global::DXFormUI.Properties.Resources.convert_16x16;
            this.updateBtn.Location = new System.Drawing.Point(227, 307);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(85, 32);
            this.updateBtn.TabIndex = 3;
            this.updateBtn.Text = "Update";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // UserOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 389);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.psswordLbl);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.dgwUser);
            this.Name = "UserOperations";
            this.Text = "UserOperations";
            this.Load += new System.EventHandler(this.UserOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUser;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label psswordLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxEmail;
        private DevExpress.XtraEditors.SimpleButton deleteBtn;
        private DevExpress.XtraEditors.SimpleButton addBtn;
        private DevExpress.XtraEditors.SimpleButton updateBtn;
        public System.Windows.Forms.TextBox tbxPassword;
    }
}