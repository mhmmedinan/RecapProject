
namespace DXFormUI
{
    partial class RentalOperations
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
            this.dgwRental = new System.Windows.Forms.DataGridView();
            this.carLbl = new System.Windows.Forms.Label();
            this.cbxCarId1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCustomerId1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rentAddBtn = new DevExpress.XtraEditors.SimpleButton();
            this.tbxRent = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRental)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwRental
            // 
            this.dgwRental.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwRental.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgwRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRental.Location = new System.Drawing.Point(0, 2);
            this.dgwRental.Name = "dgwRental";
            this.dgwRental.Size = new System.Drawing.Size(478, 178);
            this.dgwRental.TabIndex = 0;
            // 
            // carLbl
            // 
            this.carLbl.AutoSize = true;
            this.carLbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carLbl.Location = new System.Drawing.Point(12, 211);
            this.carLbl.Name = "carLbl";
            this.carLbl.Size = new System.Drawing.Size(41, 15);
            this.carLbl.TabIndex = 1;
            this.carLbl.Text = "Car Id";
            // 
            // cbxCarId1
            // 
            this.cbxCarId1.FormattingEnabled = true;
            this.cbxCarId1.Location = new System.Drawing.Point(92, 205);
            this.cbxCarId1.Name = "cbxCarId1";
            this.cbxCarId1.Size = new System.Drawing.Size(121, 21);
            this.cbxCarId1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Id";
            // 
            // cbxCustomerId1
            // 
            this.cbxCustomerId1.FormattingEnabled = true;
            this.cbxCustomerId1.Location = new System.Drawing.Point(92, 242);
            this.cbxCustomerId1.Name = "cbxCustomerId1";
            this.cbxCustomerId1.Size = new System.Drawing.Size(121, 21);
            this.cbxCustomerId1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rent Date";
            // 
            // rentAddBtn
            // 
            this.rentAddBtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rentAddBtn.Appearance.Options.UseFont = true;
            this.rentAddBtn.Location = new System.Drawing.Point(296, 225);
            this.rentAddBtn.Name = "rentAddBtn";
            this.rentAddBtn.Size = new System.Drawing.Size(108, 29);
            this.rentAddBtn.TabIndex = 5;
            this.rentAddBtn.Text = "Add";
            this.rentAddBtn.Click += new System.EventHandler(this.rentAddBtn_Click);
            // 
            // tbxRent
            // 
            this.tbxRent.Location = new System.Drawing.Point(92, 269);
            this.tbxRent.Name = "tbxRent";
            this.tbxRent.Size = new System.Drawing.Size(121, 21);
            this.tbxRent.TabIndex = 6;
            // 
            // RentalOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 348);
            this.Controls.Add(this.tbxRent);
            this.Controls.Add(this.rentAddBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxCustomerId1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCarId1);
            this.Controls.Add(this.carLbl);
            this.Controls.Add(this.dgwRental);
            this.Name = "RentalOperations";
            this.Text = "RentalOperations";
            this.Load += new System.EventHandler(this.RentalOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRental)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwRental;
        private System.Windows.Forms.Label carLbl;
        private System.Windows.Forms.ComboBox cbxCarId1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCustomerId1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton rentAddBtn;
        private System.Windows.Forms.TextBox tbxRent;
    }
}