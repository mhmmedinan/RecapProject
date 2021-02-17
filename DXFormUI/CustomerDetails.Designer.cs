
namespace DXFormUI
{
    partial class CustomerDetails
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
            this.dgwCustomerDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomerDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwCustomerDetails
            // 
            this.dgwCustomerDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCustomerDetails.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgwCustomerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCustomerDetails.Location = new System.Drawing.Point(2, 9);
            this.dgwCustomerDetails.Name = "dgwCustomerDetails";
            this.dgwCustomerDetails.Size = new System.Drawing.Size(388, 183);
            this.dgwCustomerDetails.TabIndex = 0;
            // 
            // CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 228);
            this.Controls.Add(this.dgwCustomerDetails);
            this.Name = "CustomerDetails";
            this.Text = "CustomerDetails";
            this.Load += new System.EventHandler(this.CustomerDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomerDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCustomerDetails;
    }
}