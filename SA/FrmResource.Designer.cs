namespace com.jajago.SA
{
    partial class FrmResource
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnScan = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbCount = new System.Windows.Forms.Label();
            this.lbSdSize = new System.Windows.Forms.Label();
            this.lbSelectedSize = new System.Windows.Forms.Label();
            this.lstTaxonomy = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnWriteSD = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ucResources = new com.jajago.SA.Ctls.CtlResources();
            this.ctlProgressBar1 = new com.jajago.SA.Ctls.CtlProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(12, 45);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(116, 23);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "搜索本地资源";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // lbCount
            // 
            this.lbCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(503, 449);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(0, 12);
            this.lbCount.TabIndex = 8;
            // 
            // lbSdSize
            // 
            this.lbSdSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSdSize.AutoSize = true;
            this.lbSdSize.Location = new System.Drawing.Point(609, 26);
            this.lbSdSize.Name = "lbSdSize";
            this.lbSdSize.Size = new System.Drawing.Size(77, 12);
            this.lbSdSize.TabIndex = 10;
            this.lbSdSize.Text = "SD卡容量：2G";
            // 
            // lbSelectedSize
            // 
            this.lbSelectedSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSelectedSize.AutoSize = true;
            this.lbSelectedSize.Location = new System.Drawing.Point(385, 26);
            this.lbSelectedSize.Name = "lbSelectedSize";
            this.lbSelectedSize.Size = new System.Drawing.Size(107, 12);
            this.lbSelectedSize.TabIndex = 11;
            this.lbSelectedSize.Text = "已选中资源：1.06G";
            // 
            // lstTaxonomy
            // 
            this.lstTaxonomy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstTaxonomy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTaxonomy.FullRowSelect = true;
            this.lstTaxonomy.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstTaxonomy.Location = new System.Drawing.Point(0, 0);
            this.lstTaxonomy.MultiSelect = false;
            this.lstTaxonomy.Name = "lstTaxonomy";
            this.lstTaxonomy.Size = new System.Drawing.Size(216, 405);
            this.lstTaxonomy.TabIndex = 12;
            this.lstTaxonomy.UseCompatibleStateImageBehavior = false;
            this.lstTaxonomy.View = System.Windows.Forms.View.Details;
            this.lstTaxonomy.SelectedIndexChanged += new System.EventHandler(this.lstTaxonomy_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "类型";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "资源(M)";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 77;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "选中(M)";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 77;
            // 
            // btnWriteSD
            // 
            this.btnWriteSD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWriteSD.Location = new System.Drawing.Point(280, 41);
            this.btnWriteSD.Name = "btnWriteSD";
            this.btnWriteSD.Size = new System.Drawing.Size(91, 23);
            this.btnWriteSD.TabIndex = 13;
            this.btnWriteSD.Text = "准备写入SD卡";
            this.btnWriteSD.UseVisualStyleBackColor = true;
            this.btnWriteSD.Click += new System.EventHandler(this.btnWriteSD_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 74);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstTaxonomy);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ucResources);
            this.splitContainer1.Panel2MinSize = 425;
            this.splitContainer1.Size = new System.Drawing.Size(726, 405);
            this.splitContainer1.SplitterDistance = 216;
            this.splitContainer1.TabIndex = 14;
            // 
            // ucResources
            // 
            this.ucResources.BackColor = System.Drawing.Color.White;
            this.ucResources.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucResources.Location = new System.Drawing.Point(0, 0);
            this.ucResources.Name = "ucResources";
            this.ucResources.Size = new System.Drawing.Size(506, 405);
            this.ucResources.TabIndex = 7;
            // 
            // ctlProgressBar1
            // 
            this.ctlProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlProgressBar1.Location = new System.Drawing.Point(378, 42);
            this.ctlProgressBar1.Name = "ctlProgressBar1";
            this.ctlProgressBar1.Size = new System.Drawing.Size(351, 22);
            this.ctlProgressBar1.TabIndex = 15;
            // 
            // FrmResource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(733, 479);
            this.Controls.Add(this.ctlProgressBar1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnWriteSD);
            this.Controls.Add(this.lbSelectedSize);
            this.Controls.Add(this.lbSdSize);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.btnScan);
            this.MinimumSize = new System.Drawing.Size(545, 513);
            this.Name = "FrmResource";
            this.Text = "FrmResources";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnScan;
        private com.jajago.SA.Ctls.CtlResources ucResources;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Label lbSdSize;
        private System.Windows.Forms.Label lbSelectedSize;
        private System.Windows.Forms.ListView lstTaxonomy;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnWriteSD;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Ctls.CtlProgressBar ctlProgressBar1;

    }
}

