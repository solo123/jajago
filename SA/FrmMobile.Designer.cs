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
            this.lbAllImage = new System.Windows.Forms.LinkLabel();
            this.lbName = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbProps = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbRefPrice = new System.Windows.Forms.Label();
            this.lbStandard = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbShowImage = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAllImage
            // 
            this.lbAllImage.AutoSize = true;
            this.lbAllImage.Location = new System.Drawing.Point(106, 237);
            this.lbAllImage.Name = "lbAllImage";
            this.lbAllImage.Size = new System.Drawing.Size(53, 12);
            this.lbAllImage.TabIndex = 1;
            this.lbAllImage.TabStop = true;
            this.lbAllImage.Text = "更多图片";
            this.lbAllImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(268, 38);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(41, 12);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "label1";
            // 
            // lbDescription
            // 
            this.lbDescription.Location = new System.Drawing.Point(50, 274);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(623, 45);
            this.lbDescription.TabIndex = 3;
            this.lbDescription.Text = "label2";
            // 
            // lbProps
            // 
            this.lbProps.Location = new System.Drawing.Point(50, 319);
            this.lbProps.Name = "lbProps";
            this.lbProps.Size = new System.Drawing.Size(623, 73);
            this.lbProps.TabIndex = 4;
            this.lbProps.Text = "label3";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(268, 73);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(41, 12);
            this.lbPrice.TabIndex = 6;
            this.lbPrice.Text = "label1";
            // 
            // lbRefPrice
            // 
            this.lbRefPrice.AutoSize = true;
            this.lbRefPrice.Location = new System.Drawing.Point(268, 205);
            this.lbRefPrice.Name = "lbRefPrice";
            this.lbRefPrice.Size = new System.Drawing.Size(41, 12);
            this.lbRefPrice.TabIndex = 7;
            this.lbRefPrice.Text = "label4";
            // 
            // lbStandard
            // 
            this.lbStandard.Location = new System.Drawing.Point(268, 120);
            this.lbStandard.Name = "lbStandard";
            this.lbStandard.Size = new System.Drawing.Size(393, 44);
            this.lbStandard.TabIndex = 8;
            this.lbStandard.Text = "label1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTitle});
            this.statusStrip1.Location = new System.Drawing.Point(0, 392);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(673, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslTitle
            // 
            this.tsslTitle.Name = "tsslTitle";
            this.tsslTitle.Size = new System.Drawing.Size(131, 17);
            this.tsslTitle.Text = "toolStripStatusLabel1";
            // 
            // pbShowImage
            // 
            this.pbShowImage.Location = new System.Drawing.Point(52, 38);
            this.pbShowImage.Name = "pbShowImage";
            this.pbShowImage.Size = new System.Drawing.Size(181, 179);
            this.pbShowImage.TabIndex = 5;
            this.pbShowImage.TabStop = false;
            // 
            // FrmMobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 414);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lbStandard);
            this.Controls.Add(this.lbRefPrice);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.pbShowImage);
            this.Controls.Add(this.lbProps);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbAllImage);
            this.Name = "FrmMobile";
            this.Text = "FrmMobile";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lbAllImage;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbProps;
        private System.Windows.Forms.PictureBox pbShowImage;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbRefPrice;
        private System.Windows.Forms.Label lbStandard;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslTitle;

    }
}