
namespace DXFormUI
{
    partial class CarOperations
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
            this.components = new System.ComponentModel.Container();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.dgwCar = new System.Windows.Forms.DataGridView();
            this.ColorIdLbl = new System.Windows.Forms.Label();
            this.cbxColorId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxBrandId = new System.Windows.Forms.ComboBox();
            this.modelLbl = new System.Windows.Forms.Label();
            this.tbxModelYear = new System.Windows.Forms.TextBox();
            this.priceLbl = new System.Windows.Forms.Label();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.grpBrand = new System.Windows.Forms.GroupBox();
            this.cbxBrandName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.carUpdateBtn = new DevExpress.XtraEditors.SimpleButton();
            this.carDeleteBtn = new DevExpress.XtraEditors.SimpleButton();
            this.carAddBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCar)).BeginInit();
            this.grpBrand.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Lilian";
            // 
            // dgwCar
            // 
            this.dgwCar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCar.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgwCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCar.Location = new System.Drawing.Point(12, 58);
            this.dgwCar.Name = "dgwCar";
            this.dgwCar.Size = new System.Drawing.Size(715, 176);
            this.dgwCar.TabIndex = 0;
            this.dgwCar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCar_CellClick);
            // 
            // ColorIdLbl
            // 
            this.ColorIdLbl.AutoSize = true;
            this.ColorIdLbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ColorIdLbl.Location = new System.Drawing.Point(12, 303);
            this.ColorIdLbl.Name = "ColorIdLbl";
            this.ColorIdLbl.Size = new System.Drawing.Size(51, 15);
            this.ColorIdLbl.TabIndex = 1;
            this.ColorIdLbl.Text = "Color Id";
            // 
            // cbxColorId
            // 
            this.cbxColorId.FormattingEnabled = true;
            this.cbxColorId.Location = new System.Drawing.Point(89, 300);
            this.cbxColorId.Name = "cbxColorId";
            this.cbxColorId.Size = new System.Drawing.Size(132, 21);
            this.cbxColorId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Brand Id";
            // 
            // cbxBrandId
            // 
            this.cbxBrandId.FormattingEnabled = true;
            this.cbxBrandId.Location = new System.Drawing.Point(89, 253);
            this.cbxBrandId.Name = "cbxBrandId";
            this.cbxBrandId.Size = new System.Drawing.Size(132, 21);
            this.cbxBrandId.TabIndex = 2;
            // 
            // modelLbl
            // 
            this.modelLbl.AutoSize = true;
            this.modelLbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.modelLbl.Location = new System.Drawing.Point(12, 354);
            this.modelLbl.Name = "modelLbl";
            this.modelLbl.Size = new System.Drawing.Size(68, 15);
            this.modelLbl.TabIndex = 1;
            this.modelLbl.Text = "Model Year";
            // 
            // tbxModelYear
            // 
            this.tbxModelYear.Location = new System.Drawing.Point(89, 349);
            this.tbxModelYear.Multiline = true;
            this.tbxModelYear.Name = "tbxModelYear";
            this.tbxModelYear.Size = new System.Drawing.Size(132, 26);
            this.tbxModelYear.TabIndex = 3;
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.priceLbl.Location = new System.Drawing.Point(305, 254);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(69, 15);
            this.priceLbl.TabIndex = 1;
            this.priceLbl.Text = "Daily Price";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(382, 249);
            this.tbxPrice.Multiline = true;
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(132, 26);
            this.tbxPrice.TabIndex = 3;
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DescriptionLbl.Location = new System.Drawing.Point(305, 303);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(71, 15);
            this.DescriptionLbl.TabIndex = 1;
            this.DescriptionLbl.Text = "Description";
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(382, 285);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(207, 54);
            this.tbxDescription.TabIndex = 3;
            // 
            // grpBrand
            // 
            this.grpBrand.Controls.Add(this.cbxBrandName);
            this.grpBrand.Controls.Add(this.label2);
            this.grpBrand.Location = new System.Drawing.Point(12, 5);
            this.grpBrand.Name = "grpBrand";
            this.grpBrand.Size = new System.Drawing.Size(715, 47);
            this.grpBrand.TabIndex = 5;
            this.grpBrand.TabStop = false;
            this.grpBrand.Text = "Marka İsmine Göre Arama";
            // 
            // cbxBrandName
            // 
            this.cbxBrandName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxBrandName.FormattingEnabled = true;
            this.cbxBrandName.Location = new System.Drawing.Point(94, 17);
            this.cbxBrandName.Name = "cbxBrandName";
            this.cbxBrandName.Size = new System.Drawing.Size(159, 23);
            this.cbxBrandName.TabIndex = 1;
            this.cbxBrandName.SelectedIndexChanged += new System.EventHandler(this.cbxBrandName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Brand Name";
            // 
            // carUpdateBtn
            // 
            this.carUpdateBtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carUpdateBtn.Appearance.Options.UseFont = true;
            this.carUpdateBtn.ImageOptions.Image = global::DXFormUI.Properties.Resources.convert_16x16;
            this.carUpdateBtn.Location = new System.Drawing.Point(445, 376);
            this.carUpdateBtn.Name = "carUpdateBtn";
            this.carUpdateBtn.Size = new System.Drawing.Size(99, 32);
            this.carUpdateBtn.TabIndex = 4;
            this.carUpdateBtn.Text = "Update";
            this.carUpdateBtn.Click += new System.EventHandler(this.carUpdateBtn_Click);
            // 
            // carDeleteBtn
            // 
            this.carDeleteBtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carDeleteBtn.Appearance.Options.UseFont = true;
            this.carDeleteBtn.ImageOptions.Image = global::DXFormUI.Properties.Resources.trash_16x16;
            this.carDeleteBtn.Location = new System.Drawing.Point(564, 376);
            this.carDeleteBtn.Name = "carDeleteBtn";
            this.carDeleteBtn.Size = new System.Drawing.Size(99, 32);
            this.carDeleteBtn.TabIndex = 4;
            this.carDeleteBtn.Text = "Delete";
            this.carDeleteBtn.Click += new System.EventHandler(this.carDeleteBtn_Click);
            // 
            // carAddBtn
            // 
            this.carAddBtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carAddBtn.Appearance.Options.UseFont = true;
            this.carAddBtn.ImageOptions.Image = global::DXFormUI.Properties.Resources.add_16x16;
            this.carAddBtn.Location = new System.Drawing.Point(329, 376);
            this.carAddBtn.Name = "carAddBtn";
            this.carAddBtn.Size = new System.Drawing.Size(99, 32);
            this.carAddBtn.TabIndex = 4;
            this.carAddBtn.Text = "Add";
            this.carAddBtn.Click += new System.EventHandler(this.carAddBtn_Click);
            // 
            // CarOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 440);
            this.Controls.Add(this.grpBrand);
            this.Controls.Add(this.carUpdateBtn);
            this.Controls.Add(this.carDeleteBtn);
            this.Controls.Add(this.carAddBtn);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.tbxModelYear);
            this.Controls.Add(this.cbxBrandId);
            this.Controls.Add(this.DescriptionLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.cbxColorId);
            this.Controls.Add(this.modelLbl);
            this.Controls.Add(this.ColorIdLbl);
            this.Controls.Add(this.dgwCar);
            this.Name = "CarOperations";
            this.Text = "CarOperations";
            this.Load += new System.EventHandler(this.CarOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCar)).EndInit();
            this.grpBrand.ResumeLayout(false);
            this.grpBrand.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.DataGridView dgwCar;
        private System.Windows.Forms.Label ColorIdLbl;
        private System.Windows.Forms.ComboBox cbxColorId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxBrandId;
        private System.Windows.Forms.Label modelLbl;
        private System.Windows.Forms.TextBox tbxModelYear;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.TextBox tbxDescription;
        private DevExpress.XtraEditors.SimpleButton carAddBtn;
        private DevExpress.XtraEditors.SimpleButton carDeleteBtn;
        private DevExpress.XtraEditors.SimpleButton carUpdateBtn;
        private System.Windows.Forms.GroupBox grpBrand;
        private System.Windows.Forms.ComboBox cbxBrandName;
        private System.Windows.Forms.Label label2;
    }
}