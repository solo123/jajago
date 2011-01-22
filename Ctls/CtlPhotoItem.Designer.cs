namespace com.jajago.SA.Ctls
{
    partial class CtlPhotoItem
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pcb = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbPhotoSize = new System.Windows.Forms.Label();
            this.lbFileSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcb)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb
            // 
            this.pcb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb.Location = new System.Drawing.Point(12, 9);
            this.pcb.Name = "pcb";
            this.pcb.Size = new System.Drawing.Size(100, 100);
            this.pcb.TabIndex = 0;
            this.pcb.TabStop = false;
            this.pcb.Click += new System.EventHandler(this.pcb_Click);
            this.pcb.DoubleClick += new System.EventHandler(this.pcb_DoubleClick);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(12, 119);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(77, 12);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "abcceddd.jpg";
            // 
            // lbPhotoSize
            // 
            this.lbPhotoSize.AutoSize = true;
            this.lbPhotoSize.Location = new System.Drawing.Point(12, 137);
            this.lbPhotoSize.Name = "lbPhotoSize";
            this.lbPhotoSize.Size = new System.Drawing.Size(53, 12);
            this.lbPhotoSize.TabIndex = 2;
            this.lbPhotoSize.Text = "1024x768";
            // 
            // lbFileSize
            // 
            this.lbFileSize.AutoSize = true;
            this.lbFileSize.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbFileSize.ForeColor = System.Drawing.Color.DarkRed;
            this.lbFileSize.Location = new System.Drawing.Point(81, 137);
            this.lbFileSize.Name = "lbFileSize";
            this.lbFileSize.Size = new System.Drawing.Size(26, 12);
            this.lbFileSize.TabIndex = 3;
            this.lbFileSize.Text = "35K";
            // 
            // CtlPhotoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbFileSize);
            this.Controls.Add(this.lbPhotoSize);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pcb);
            this.Name = "CtlPhotoItem";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(127, 157);
            ((System.ComponentModel.ISupportInitialize)(this.pcb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbPhotoSize;
        private System.Windows.Forms.Label lbFileSize;
    }
}
