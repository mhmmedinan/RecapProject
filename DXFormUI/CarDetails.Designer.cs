
namespace DXFormUI
{
    partial class CarDetails
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
            this.dgwCarDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCarDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwCarDetails
            // 
            this.dgwCarDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCarDetails.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwCarDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCarDetails.Location = new System.Drawing.Point(4, 12);
            this.dgwCarDetails.Name = "dgwCarDetails";
            this.dgwCarDetails.Size = new System.Drawing.Size(569, 189);
            this.dgwCarDetails.TabIndex = 0;
            // 
            // CarDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 226);
            this.Controls.Add(this.dgwCarDetails);
            this.Name = "CarDetails";
            this.Text = "CarDetails";
            this.Load += new System.EventHandler(this.CarDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCarDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCarDetails;
    }
}