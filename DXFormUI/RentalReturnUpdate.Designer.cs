
namespace DXFormUI
{
    partial class RentalReturnUpdate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgwRentalReturn = new System.Windows.Forms.DataGridView();
            this.returnBtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCarId2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxCmpnyName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxRentDate = new System.Windows.Forms.TextBox();
            this.tbxReturnDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRentalReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwRentalReturn
            // 
            this.dgwRentalReturn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwRentalReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwRentalReturn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgwRentalReturn.Location = new System.Drawing.Point(2, 3);
            this.dgwRentalReturn.Name = "dgwRentalReturn";
            this.dgwRentalReturn.Size = new System.Drawing.Size(589, 172);
            this.dgwRentalReturn.TabIndex = 0;
            this.dgwRentalReturn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwRentalReturn_CellClick);
            // 
            // returnBtnUpdate
            // 
            this.returnBtnUpdate.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.returnBtnUpdate.Appearance.Options.UseFont = true;
            this.returnBtnUpdate.Location = new System.Drawing.Point(480, 298);
            this.returnBtnUpdate.Name = "returnBtnUpdate";
            this.returnBtnUpdate.Size = new System.Drawing.Size(101, 34);
            this.returnBtnUpdate.TabIndex = 1;
            this.returnBtnUpdate.Text = "Return Update";
            this.returnBtnUpdate.Click += new System.EventHandler(this.returnBtnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Car Id";
            // 
            // tbxCarId2
            // 
            this.tbxCarId2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxCarId2.Location = new System.Drawing.Point(122, 212);
            this.tbxCarId2.Name = "tbxCarId2";
            this.tbxCarId2.Size = new System.Drawing.Size(119, 21);
            this.tbxCarId2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name ";
            // 
            // tbxUserName
            // 
            this.tbxUserName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUserName.Location = new System.Drawing.Point(122, 246);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(119, 21);
            this.tbxUserName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Company Name";
            // 
            // tbxCmpnyName
            // 
            this.tbxCmpnyName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxCmpnyName.Location = new System.Drawing.Point(122, 275);
            this.tbxCmpnyName.Name = "tbxCmpnyName";
            this.tbxCmpnyName.Size = new System.Drawing.Size(119, 21);
            this.tbxCmpnyName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(294, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Return Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(294, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Rent Date";
            // 
            // tbxRentDate
            // 
            this.tbxRentDate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxRentDate.Location = new System.Drawing.Point(374, 226);
            this.tbxRentDate.Name = "tbxRentDate";
            this.tbxRentDate.Size = new System.Drawing.Size(119, 21);
            this.tbxRentDate.TabIndex = 6;
            // 
            // tbxReturnDate
            // 
            this.tbxReturnDate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxReturnDate.Location = new System.Drawing.Point(374, 262);
            this.tbxReturnDate.Name = "tbxReturnDate";
            this.tbxReturnDate.Size = new System.Drawing.Size(119, 21);
            this.tbxReturnDate.TabIndex = 7;
            // 
            // RentalReturnUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 348);
            this.Controls.Add(this.tbxReturnDate);
            this.Controls.Add(this.tbxRentDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxCmpnyName);
            this.Controls.Add(this.tbxUserName);
            this.Controls.Add(this.tbxCarId2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnBtnUpdate);
            this.Controls.Add(this.dgwRentalReturn);
            this.Name = "RentalReturnUpdate";
            this.Text = "RentalReturnUpdate";
            this.Load += new System.EventHandler(this.RentalReturnUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRentalReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwRentalReturn;
        private DevExpress.XtraEditors.SimpleButton returnBtnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxCarId2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxCmpnyName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxRentDate;
        private System.Windows.Forms.TextBox tbxReturnDate;
    }
}