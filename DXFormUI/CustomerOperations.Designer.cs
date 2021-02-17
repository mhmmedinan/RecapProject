
namespace DXFormUI
{
    partial class CustomerOperations
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
            this.dgwCustomer = new System.Windows.Forms.DataGridView();
            this.companyLbl = new System.Windows.Forms.Label();
            this.tbxCompanyName = new System.Windows.Forms.TextBox();
            this.userIdLbl = new System.Windows.Forms.Label();
            this.cbxUserId = new System.Windows.Forms.ComboBox();
            this.customerAddBtn = new DevExpress.XtraEditors.SimpleButton();
            this.customerUpdateBtn = new DevExpress.XtraEditors.SimpleButton();
            this.customerDeleteBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwCustomer
            // 
            this.dgwCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCustomer.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCustomer.Location = new System.Drawing.Point(0, 7);
            this.dgwCustomer.Name = "dgwCustomer";
            this.dgwCustomer.Size = new System.Drawing.Size(401, 148);
            this.dgwCustomer.TabIndex = 0;
            this.dgwCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCustomer_CellClick);
            // 
            // companyLbl
            // 
            this.companyLbl.AutoSize = true;
            this.companyLbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.companyLbl.Location = new System.Drawing.Point(12, 229);
            this.companyLbl.Name = "companyLbl";
            this.companyLbl.Size = new System.Drawing.Size(91, 15);
            this.companyLbl.TabIndex = 1;
            this.companyLbl.Text = "Company Name";
            // 
            // tbxCompanyName
            // 
            this.tbxCompanyName.Location = new System.Drawing.Point(109, 227);
            this.tbxCompanyName.Name = "tbxCompanyName";
            this.tbxCompanyName.Size = new System.Drawing.Size(119, 21);
            this.tbxCompanyName.TabIndex = 2;
            // 
            // userIdLbl
            // 
            this.userIdLbl.AutoSize = true;
            this.userIdLbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userIdLbl.Location = new System.Drawing.Point(12, 196);
            this.userIdLbl.Name = "userIdLbl";
            this.userIdLbl.Size = new System.Drawing.Size(46, 15);
            this.userIdLbl.TabIndex = 1;
            this.userIdLbl.Text = "User Id";
            // 
            // cbxUserId
            // 
            this.cbxUserId.FormattingEnabled = true;
            this.cbxUserId.Location = new System.Drawing.Point(107, 194);
            this.cbxUserId.Name = "cbxUserId";
            this.cbxUserId.Size = new System.Drawing.Size(121, 21);
            this.cbxUserId.TabIndex = 3;
            // 
            // customerAddBtn
            // 
            this.customerAddBtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerAddBtn.Appearance.Options.UseFont = true;
            this.customerAddBtn.ImageOptions.Image = global::DXFormUI.Properties.Resources.add_16x16;
            this.customerAddBtn.Location = new System.Drawing.Point(263, 166);
            this.customerAddBtn.Name = "customerAddBtn";
            this.customerAddBtn.Size = new System.Drawing.Size(94, 27);
            this.customerAddBtn.TabIndex = 4;
            this.customerAddBtn.Text = "Add";
            this.customerAddBtn.Click += new System.EventHandler(this.customerAddBtn_Click);
            // 
            // customerUpdateBtn
            // 
            this.customerUpdateBtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerUpdateBtn.Appearance.Options.UseFont = true;
            this.customerUpdateBtn.ImageOptions.Image = global::DXFormUI.Properties.Resources.convert_16x16;
            this.customerUpdateBtn.Location = new System.Drawing.Point(263, 202);
            this.customerUpdateBtn.Name = "customerUpdateBtn";
            this.customerUpdateBtn.Size = new System.Drawing.Size(94, 27);
            this.customerUpdateBtn.TabIndex = 4;
            this.customerUpdateBtn.Text = "Update";
            this.customerUpdateBtn.Click += new System.EventHandler(this.customerUpdateBtn_Click);
            // 
            // customerDeleteBtn
            // 
            this.customerDeleteBtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerDeleteBtn.Appearance.Options.UseFont = true;
            this.customerDeleteBtn.ImageOptions.Image = global::DXFormUI.Properties.Resources.trash_16x16;
            this.customerDeleteBtn.Location = new System.Drawing.Point(263, 241);
            this.customerDeleteBtn.Name = "customerDeleteBtn";
            this.customerDeleteBtn.Size = new System.Drawing.Size(94, 27);
            this.customerDeleteBtn.TabIndex = 4;
            this.customerDeleteBtn.Text = "Delete";
            this.customerDeleteBtn.Click += new System.EventHandler(this.customerDeleteBtn_Click);
            // 
            // CustomerOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 304);
            this.Controls.Add(this.customerDeleteBtn);
            this.Controls.Add(this.customerUpdateBtn);
            this.Controls.Add(this.customerAddBtn);
            this.Controls.Add(this.cbxUserId);
            this.Controls.Add(this.tbxCompanyName);
            this.Controls.Add(this.userIdLbl);
            this.Controls.Add(this.companyLbl);
            this.Controls.Add(this.dgwCustomer);
            this.Name = "CustomerOperations";
            this.Text = "CustomerOperations";
            this.Load += new System.EventHandler(this.CustomerOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCustomer;
        private System.Windows.Forms.Label companyLbl;
        private System.Windows.Forms.TextBox tbxCompanyName;
        private System.Windows.Forms.Label userIdLbl;
        private System.Windows.Forms.ComboBox cbxUserId;
        private DevExpress.XtraEditors.SimpleButton customerAddBtn;
        private DevExpress.XtraEditors.SimpleButton customerUpdateBtn;
        private DevExpress.XtraEditors.SimpleButton customerDeleteBtn;
    }
}