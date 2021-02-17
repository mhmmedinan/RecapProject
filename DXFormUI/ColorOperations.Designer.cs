
namespace DXFormUI
{
    partial class ColorOperations
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
            this.dgwColor = new System.Windows.Forms.DataGridView();
            this.colorNameLbl = new System.Windows.Forms.Label();
            this.tbxColorName = new System.Windows.Forms.TextBox();
            this.colorUpdateBtn = new DevExpress.XtraEditors.SimpleButton();
            this.colorDeleteBtn = new DevExpress.XtraEditors.SimpleButton();
            this.colorAddBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwColor)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Lilian";
            // 
            // dgwColor
            // 
            this.dgwColor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwColor.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwColor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwColor.Location = new System.Drawing.Point(0, 0);
            this.dgwColor.Name = "dgwColor";
            this.dgwColor.Size = new System.Drawing.Size(305, 148);
            this.dgwColor.TabIndex = 0;
            this.dgwColor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwColor_CellClick);
            // 
            // colorNameLbl
            // 
            this.colorNameLbl.AutoSize = true;
            this.colorNameLbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colorNameLbl.Location = new System.Drawing.Point(12, 186);
            this.colorNameLbl.Name = "colorNameLbl";
            this.colorNameLbl.Size = new System.Drawing.Size(72, 15);
            this.colorNameLbl.TabIndex = 1;
            this.colorNameLbl.Text = "Color Name";
            // 
            // tbxColorName
            // 
            this.tbxColorName.Location = new System.Drawing.Point(90, 184);
            this.tbxColorName.Name = "tbxColorName";
            this.tbxColorName.Size = new System.Drawing.Size(114, 21);
            this.tbxColorName.TabIndex = 2;
            // 
            // colorUpdateBtn
            // 
            this.colorUpdateBtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colorUpdateBtn.Appearance.Options.UseFont = true;
            this.colorUpdateBtn.ImageOptions.Image = global::DXFormUI.Properties.Resources.convert_16x161;
            this.colorUpdateBtn.Location = new System.Drawing.Point(221, 186);
            this.colorUpdateBtn.Name = "colorUpdateBtn";
            this.colorUpdateBtn.Size = new System.Drawing.Size(75, 26);
            this.colorUpdateBtn.TabIndex = 3;
            this.colorUpdateBtn.Text = "Update";
            this.colorUpdateBtn.Click += new System.EventHandler(this.colorUpdateBtn_Click);
            // 
            // colorDeleteBtn
            // 
            this.colorDeleteBtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colorDeleteBtn.Appearance.Options.UseFont = true;
            this.colorDeleteBtn.ImageOptions.Image = global::DXFormUI.Properties.Resources.trash_16x16;
            this.colorDeleteBtn.Location = new System.Drawing.Point(221, 218);
            this.colorDeleteBtn.Name = "colorDeleteBtn";
            this.colorDeleteBtn.Size = new System.Drawing.Size(75, 26);
            this.colorDeleteBtn.TabIndex = 3;
            this.colorDeleteBtn.Text = "Delete";
            this.colorDeleteBtn.Click += new System.EventHandler(this.colorDeleteBtn_Click);
            // 
            // colorAddBtn
            // 
            this.colorAddBtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colorAddBtn.Appearance.Options.UseFont = true;
            this.colorAddBtn.ImageOptions.Image = global::DXFormUI.Properties.Resources.add_16x16;
            this.colorAddBtn.Location = new System.Drawing.Point(221, 154);
            this.colorAddBtn.Name = "colorAddBtn";
            this.colorAddBtn.Size = new System.Drawing.Size(75, 26);
            this.colorAddBtn.TabIndex = 3;
            this.colorAddBtn.Text = "Add";
            this.colorAddBtn.Click += new System.EventHandler(this.colorAddBtn_Click);
            // 
            // ColorOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 251);
            this.Controls.Add(this.colorUpdateBtn);
            this.Controls.Add(this.colorDeleteBtn);
            this.Controls.Add(this.colorAddBtn);
            this.Controls.Add(this.tbxColorName);
            this.Controls.Add(this.colorNameLbl);
            this.Controls.Add(this.dgwColor);
            this.Name = "ColorOperations";
            this.Text = "ColorOperations";
            this.Load += new System.EventHandler(this.ColorOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.DataGridView dgwColor;
        private System.Windows.Forms.Label colorNameLbl;
        private System.Windows.Forms.TextBox tbxColorName;
        private DevExpress.XtraEditors.SimpleButton colorAddBtn;
        private DevExpress.XtraEditors.SimpleButton colorDeleteBtn;
        private DevExpress.XtraEditors.SimpleButton colorUpdateBtn;
    }
}