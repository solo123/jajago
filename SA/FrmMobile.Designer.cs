namespace com.jajago.SA
{
    partial class FrmMobile
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbProps = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbRefPrice = new System.Windows.Forms.Label();
            this.lbStandard = new System.Windows.Forms.Label();
            this.pbShowImage = new System.Windows.Forms.PictureBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvAllPic = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbShowImage)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(221, 10);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(41, 12);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "lbName";
            // 
            // lbProps
            // 
            this.lbProps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbProps.Location = new System.Drawing.Point(0, 0);
            this.lbProps.Name = "lbProps";
            this.lbProps.Size = new System.Drawing.Size(671, 389);
            this.lbProps.TabIndex = 4;
            this.lbProps.Text = "lbProps";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(221, 45);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(47, 12);
            this.lbPrice.TabIndex = 6;
            this.lbPrice.Text = "lbPrice";
            // 
            // lbRefPrice
            // 
            this.lbRefPrice.AutoSize = true;
            this.lbRefPrice.Location = new System.Drawing.Point(428, 45);
            this.lbRefPrice.Name = "lbRefPrice";
            this.lbRefPrice.Size = new System.Drawing.Size(65, 12);
            this.lbRefPrice.TabIndex = 7;
            this.lbRefPrice.Text = "lbRefPrice";
            // 
            // lbStandard
            // 
            this.lbStandard.Location = new System.Drawing.Point(221, 101);
            this.lbStandard.Name = "lbStandard";
            this.lbStandard.Size = new System.Drawing.Size(82, 44);
            this.lbStandard.TabIndex = 8;
            this.lbStandard.Text = "lbStandard";
            // 
            // pbShowImage
            // 
            this.pbShowImage.Location = new System.Drawing.Point(6, 10);
            this.pbShowImage.Name = "pbShowImage";
            this.pbShowImage.Size = new System.Drawing.Size(135, 175);
            this.pbShowImage.TabIndex = 5;
            this.pbShowImage.TabStop = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(665, 383);
            this.webBrowser1.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(679, 414);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvAllPic);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pbShowImage);
            this.tabPage1.Controls.Add(this.lbStandard);
            this.tabPage1.Controls.Add(this.lbName);
            this.tabPage1.Controls.Add(this.lbPrice);
            this.tabPage1.Controls.Add(this.lbRefPrice);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(671, 389);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvAllPic
            // 
            this.lvAllPic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvAllPic.Location = new System.Drawing.Point(9, 202);
            this.lvAllPic.Name = "lvAllPic";
            this.lvAllPic.Size = new System.Drawing.Size(654, 181);
            this.lvAllPic.TabIndex = 10;
            this.lvAllPic.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "市场价格：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "价格：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "名称：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.webBrowser1);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(671, 389);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "详细信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbProps);
            this.tabPage3.Location = new System.Drawing.Point(4, 21);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(671, 389);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "手机参数";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmMobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 414);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmMobile";
            this.Text = "FrmMobile";
            ((System.ComponentModel.ISupportInitialize)(this.pbShowImage)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbProps;
        private System.Windows.Forms.PictureBox pbShowImage;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbRefPrice;
        private System.Windows.Forms.Label lbStandard;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvAllPic;
        private System.Windows.Forms.ImageList imageList1;

    }
}