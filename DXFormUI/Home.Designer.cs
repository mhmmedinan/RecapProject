
namespace DXFormUI
{
    partial class Home
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.carAddBtn = new DevExpress.XtraBars.BarButtonItem();
            this.carUpdateBtn = new DevExpress.XtraBars.BarButtonItem();
            this.carDeleteBtn = new DevExpress.XtraBars.BarButtonItem();
            this.brandOperationsBtn = new DevExpress.XtraBars.BarButtonItem();
            this.colorOperationsBtn = new DevExpress.XtraBars.BarButtonItem();
            this.carOperationsBtn = new DevExpress.XtraBars.BarButtonItem();
            this.carDetailsBtn = new DevExpress.XtraBars.BarButtonItem();
            this.userOperationsBtn = new DevExpress.XtraBars.BarButtonItem();
            this.customerOperationsBtn = new DevExpress.XtraBars.BarButtonItem();
            this.customerDetailsBtn = new DevExpress.XtraBars.BarButtonItem();
            this.rentalOperationsBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage6 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rentalReturnBtn = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Lilian";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.carAddBtn,
            this.carUpdateBtn,
            this.carDeleteBtn,
            this.brandOperationsBtn,
            this.colorOperationsBtn,
            this.carOperationsBtn,
            this.carDetailsBtn,
            this.userOperationsBtn,
            this.customerOperationsBtn,
            this.customerDetailsBtn,
            this.rentalOperationsBtn,
            this.rentalReturnBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 16;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4,
            this.ribbonPage5,
            this.ribbonPage6});
            this.ribbonControl1.Size = new System.Drawing.Size(912, 144);
            // 
            // carAddBtn
            // 
            this.carAddBtn.Caption = "Add";
            this.carAddBtn.Id = 1;
            this.carAddBtn.ImageOptions.Image = global::DXFormUI.Properties.Resources.add_16x16;
            this.carAddBtn.ImageOptions.LargeImage = global::DXFormUI.Properties.Resources.add_32x32;
            this.carAddBtn.Name = "carAddBtn";
            this.carAddBtn.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // carUpdateBtn
            // 
            this.carUpdateBtn.Caption = "Update";
            this.carUpdateBtn.Id = 2;
            this.carUpdateBtn.ImageOptions.Image = global::DXFormUI.Properties.Resources.convert_16x16;
            this.carUpdateBtn.ImageOptions.LargeImage = global::DXFormUI.Properties.Resources.convert_32x32;
            this.carUpdateBtn.Name = "carUpdateBtn";
            // 
            // carDeleteBtn
            // 
            this.carDeleteBtn.Caption = "Delete";
            this.carDeleteBtn.Id = 3;
            this.carDeleteBtn.ImageOptions.Image = global::DXFormUI.Properties.Resources.trash_16x16;
            this.carDeleteBtn.ImageOptions.LargeImage = global::DXFormUI.Properties.Resources.trash_32x32;
            this.carDeleteBtn.Name = "carDeleteBtn";
            // 
            // brandOperationsBtn
            // 
            this.brandOperationsBtn.Caption = "Brand Operations";
            this.brandOperationsBtn.Id = 7;
            this.brandOperationsBtn.ImageOptions.Image = global::DXFormUI.Properties.Resources.Brand_Icon;
            this.brandOperationsBtn.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.brandOperationsBtn.ItemAppearance.Normal.Options.UseFont = true;
            this.brandOperationsBtn.Name = "brandOperationsBtn";
            this.brandOperationsBtn.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.brandOperationsBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.brandOperationsBtn_ItemClick);
            // 
            // colorOperationsBtn
            // 
            this.colorOperationsBtn.Caption = "Color Operations";
            this.colorOperationsBtn.Id = 8;
            this.colorOperationsBtn.ImageOptions.Image = global::DXFormUI.Properties.Resources.app_icons;
            this.colorOperationsBtn.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colorOperationsBtn.ItemAppearance.Normal.Options.UseFont = true;
            this.colorOperationsBtn.Name = "colorOperationsBtn";
            this.colorOperationsBtn.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.colorOperationsBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.colorOperationsBtn_ItemClick);
            // 
            // carOperationsBtn
            // 
            this.carOperationsBtn.Caption = "Car Operations";
            this.carOperationsBtn.Id = 9;
            this.carOperationsBtn.ImageOptions.Image = global::DXFormUI.Properties.Resources._360_F_347134350_dhjJjzA1fuGvXOyNgCJYfOEby04ljhEC;
            this.carOperationsBtn.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carOperationsBtn.ItemAppearance.Normal.Options.UseFont = true;
            this.carOperationsBtn.Name = "carOperationsBtn";
            this.carOperationsBtn.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.carOperationsBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.carOperationsBtn_ItemClick);
            // 
            // carDetailsBtn
            // 
            this.carDetailsBtn.Caption = "Car Details";
            this.carDetailsBtn.Id = 10;
            this.carDetailsBtn.ImageOptions.Image = global::DXFormUI.Properties.Resources._1755;
            this.carDetailsBtn.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carDetailsBtn.ItemAppearance.Normal.Options.UseFont = true;
            this.carDetailsBtn.Name = "carDetailsBtn";
            this.carDetailsBtn.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.carDetailsBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.carDetailsBtn_ItemClick);
            // 
            // userOperationsBtn
            // 
            this.userOperationsBtn.Caption = "User Operations";
            this.userOperationsBtn.Id = 11;
            this.userOperationsBtn.ImageOptions.Image = global::DXFormUI.Properties.Resources.publicfix_16x16;
            this.userOperationsBtn.ImageOptions.LargeImage = global::DXFormUI.Properties.Resources.publicfix_32x32;
            this.userOperationsBtn.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userOperationsBtn.ItemAppearance.Normal.Options.UseFont = true;
            this.userOperationsBtn.Name = "userOperationsBtn";
            this.userOperationsBtn.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.userOperationsBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.userOperationsBtn_ItemClick);
            // 
            // customerOperationsBtn
            // 
            this.customerOperationsBtn.Caption = "Customer Operations";
            this.customerOperationsBtn.Id = 12;
            this.customerOperationsBtn.ImageOptions.Image = global::DXFormUI.Properties.Resources.b3829ce72135d185f019d3b21f6a99aa;
            this.customerOperationsBtn.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerOperationsBtn.ItemAppearance.Normal.Options.UseFont = true;
            this.customerOperationsBtn.Name = "customerOperationsBtn";
            this.customerOperationsBtn.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.customerOperationsBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.customerOperationsBtn_ItemClick);
            // 
            // customerDetailsBtn
            // 
            this.customerDetailsBtn.Caption = "Customer Details";
            this.customerDetailsBtn.Id = 13;
            this.customerDetailsBtn.ImageOptions.Image = global::DXFormUI.Properties.Resources._17551;
            this.customerDetailsBtn.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerDetailsBtn.ItemAppearance.Normal.Options.UseFont = true;
            this.customerDetailsBtn.Name = "customerDetailsBtn";
            this.customerDetailsBtn.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.customerDetailsBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.customerDetailsBtn_ItemClick);
            // 
            // rentalOperationsBtn
            // 
            this.rentalOperationsBtn.Caption = "Rental Operations";
            this.rentalOperationsBtn.Id = 14;
            this.rentalOperationsBtn.ImageOptions.Image = global::DXFormUI.Properties.Resources.istockphoto_1129781640_1024x1024;
            this.rentalOperationsBtn.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rentalOperationsBtn.ItemAppearance.Normal.Options.UseFont = true;
            this.rentalOperationsBtn.Name = "rentalOperationsBtn";
            this.rentalOperationsBtn.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.rentalOperationsBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rentalOperationsBtn_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Car Menu";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.carOperationsBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.carDetailsBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Car";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ribbonPage2.Appearance.Options.UseFont = true;
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Brand Menu";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.brandOperationsBtn);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Brand";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ribbonPage3.Appearance.Options.UseFont = true;
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Color Menu";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.colorOperationsBtn);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Color";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ribbonPage4.Appearance.Options.UseFont = true;
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "User Menu";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.userOperationsBtn);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "User";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ribbonPage5.Appearance.Options.UseFont = true;
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "Customer Menu";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.customerOperationsBtn);
            this.ribbonPageGroup5.ItemLinks.Add(this.customerDetailsBtn);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Customer";
            // 
            // ribbonPage6
            // 
            this.ribbonPage6.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ribbonPage6.Appearance.Options.UseFont = true;
            this.ribbonPage6.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.ribbonPage6.Name = "ribbonPage6";
            this.ribbonPage6.Text = "Rental Menu";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.rentalOperationsBtn);
            this.ribbonPageGroup6.ItemLinks.Add(this.rentalReturnBtn);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Rental";
            // 
            // rentalReturnBtn
            // 
            this.rentalReturnBtn.Caption = "Rental Return Update";
            this.rentalReturnBtn.Id = 15;
            this.rentalReturnBtn.ImageOptions.Image = global::DXFormUI.Properties.Resources.convert_16x16;
            this.rentalReturnBtn.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rentalReturnBtn.ItemAppearance.Normal.Options.UseFont = true;
            this.rentalReturnBtn.Name = "rentalReturnBtn";
            this.rentalReturnBtn.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.rentalReturnBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rentalReturnBtn_ItemClick);
            // 
            // Home
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseTextOptions = true;
            this.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 512);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.SvgImage = global::DXFormUI.Properties.Resources.bo_address;
            this.Name = "Home";
            this.ShowInTaskbar = false;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.XtraForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem carAddBtn;
        private DevExpress.XtraBars.BarButtonItem carUpdateBtn;
        private DevExpress.XtraBars.BarButtonItem carDeleteBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem brandOperationsBtn;
        private DevExpress.XtraBars.BarButtonItem colorOperationsBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem carOperationsBtn;
        private DevExpress.XtraBars.BarButtonItem carDetailsBtn;
        private DevExpress.XtraBars.BarButtonItem userOperationsBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem customerOperationsBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem customerDetailsBtn;
        private DevExpress.XtraBars.BarButtonItem rentalOperationsBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem rentalReturnBtn;
    }
}