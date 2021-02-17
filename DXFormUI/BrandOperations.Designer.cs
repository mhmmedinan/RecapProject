
namespace DXFormUI
{
    partial class BrandOperations
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
            this.dgwBrand = new System.Windows.Forms.DataGridView();
            this.brandNameLbl = new System.Windows.Forms.Label();
            this.tbxBrandName = new System.Windows.Forms.TextBox();
            this.brandUpdateBtn = new DevExpress.XtraEditors.SimpleButton();
            this.brandAddBtn = new DevExpress.XtraEditors.SimpleButton();
            this.brandDeleteBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBrand)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwBrand
            // 
            this.dgwBrand.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBrand.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBrand.Location = new System.Drawing.Point(1, 1);
            this.dgwBrand.Name = "dgwBrand";
            this.dgwBrand.Size = new System.Drawing.Size(337, 155);
            this.dgwBrand.TabIndex = 0;
            this.dgwBrand.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBrand_CellClick);
            // 
            // brandNameLbl
            // 
            this.brandNameLbl.AutoSize = true;
            this.brandNameLbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.brandNameLbl.Location = new System.Drawing.Point(12, 220);
            this.brandNameLbl.Name = "brandNameLbl";
            this.brandNameLbl.Size = new System.Drawing.Size(75, 15);
            this.brandNameLbl.TabIndex = 1;
            this.brandNameLbl.Text = "Brand Name";
            // 
            // tbxBrandName
            // 
            this.tbxBrandName.Location = new System.Drawing.Point(100, 214);
            this.tbxBrandName.Name = "tbxBrandName";
            this.tbxBrandName.Size = new System.Drawing.Size(119, 21);
            this.tbxBrandName.TabIndex = 2;
            // 
            // brandUpdateBtn
            // 
            this.brandUpdateBtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.brandUpdateBtn.Appearance.Options.UseFont = true;
            this.brandUpdateBtn.ImageOptions.Image = global::DXFormUI.Properties.Resources.convert_16x16;
            this.brandUpdateBtn.Location = new System.Drawing.Point(243, 211);
            this.brandUpdateBtn.Name = "brandUpdateBtn";
            this.brandUpdateBtn.Size = new System.Drawing.Size(84, 25);
            this.brandUpdateBtn.TabIndex = 3;
            this.brandUpdateBtn.Text = "Update";
            this.brandUpdateBtn.Click += new System.EventHandler(this.brandUpdateBtn_Click);
            // 
            // brandAddBtn
            // 
            this.brandAddBtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.brandAddBtn.Appearance.Options.UseFont = true;
            this.brandAddBtn.ImageOptions.Image = global::DXFormUI.Properties.Resources.add_16x16;
            this.brandAddBtn.Location = new System.Drawing.Point(243, 180);
            this.brandAddBtn.Name = "brandAddBtn";
            this.brandAddBtn.Size = new System.Drawing.Size(84, 25);
            this.brandAddBtn.TabIndex = 3;
            this.brandAddBtn.Text = "Add";
            this.brandAddBtn.Click += new System.EventHandler(this.brandAddBtn_Click);
            // 
            // brandDeleteBtn
            // 
            this.brandDeleteBtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.brandDeleteBtn.Appearance.Options.UseFont = true;
            this.brandDeleteBtn.ImageOptions.Image = global::DXFormUI.Properties.Resources.trash_16x16;
            this.brandDeleteBtn.Location = new System.Drawing.Point(243, 242);
            this.brandDeleteBtn.Name = "brandDeleteBtn";
            this.brandDeleteBtn.Size = new System.Drawing.Size(84, 25);
            this.brandDeleteBtn.TabIndex = 3;
            this.brandDeleteBtn.Text = "Delete";
            this.brandDeleteBtn.Click += new System.EventHandler(this.brandDeleteBtn_Click);
            // 
            // BrandOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 294);
            this.Controls.Add(this.brandAddBtn);
            this.Controls.Add(this.brandDeleteBtn);
            this.Controls.Add(this.brandUpdateBtn);
            this.Controls.Add(this.tbxBrandName);
            this.Controls.Add(this.brandNameLbl);
            this.Controls.Add(this.dgwBrand);
            this.Name = "BrandOperations";
            this.Text = "BrandOperations";
            this.Load += new System.EventHandler(this.BrandOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBrand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBrand;
        private System.Windows.Forms.Label brandNameLbl;
        private System.Windows.Forms.TextBox tbxBrandName;
        private DevExpress.XtraEditors.SimpleButton brandUpdateBtn;
        private DevExpress.XtraEditors.SimpleButton brandAddBtn;
        private DevExpress.XtraEditors.SimpleButton brandDeleteBtn;
    }
}