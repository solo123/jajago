﻿namespace com.jajago.SA
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
            this.btnselect = new System.Windows.Forms.Button();
            this.treeselect = new System.Windows.Forms.TreeView();
            this.btnwrite = new System.Windows.Forms.Button();
            this.treeCatalog = new System.Windows.Forms.TreeView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbCount = new System.Windows.Forms.Label();
            this.ucResources = new com.jajago.SA.UcResources();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(12, 12);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(116, 23);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "搜索本地资源";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnselect
            // 
            this.btnselect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnselect.Location = new System.Drawing.Point(453, 177);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(35, 34);
            this.btnselect.TabIndex = 3;
            this.btnselect.Text = ">>";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // treeselect
            // 
            this.treeselect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeselect.Location = new System.Drawing.Point(494, 41);
            this.treeselect.Name = "treeselect";
            this.treeselect.Size = new System.Drawing.Size(227, 397);
            this.treeselect.TabIndex = 1;
            // 
            // btnwrite
            // 
            this.btnwrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnwrite.Location = new System.Drawing.Point(654, 436);
            this.btnwrite.Name = "btnwrite";
            this.btnwrite.Size = new System.Drawing.Size(67, 23);
            this.btnwrite.TabIndex = 4;
            this.btnwrite.Text = "写入";
            this.btnwrite.UseVisualStyleBackColor = true;
            // 
            // treeCatalog
            // 
            this.treeCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.treeCatalog.Location = new System.Drawing.Point(12, 41);
            this.treeCatalog.Name = "treeCatalog";
            this.treeCatalog.Size = new System.Drawing.Size(116, 397);
            this.treeCatalog.TabIndex = 1;
            this.treeCatalog.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.catalog_selected);
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
            // ucResources
            // 
            this.ucResources.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucResources.Location = new System.Drawing.Point(134, 41);
            this.ucResources.Name = "ucResources";
            this.ucResources.Size = new System.Drawing.Size(313, 397);
            this.ucResources.TabIndex = 7;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 457);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(733, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // FrmResource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(733, 479);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.treeselect);
            this.Controls.Add(this.btnwrite);
            this.Controls.Add(this.ucResources);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.treeCatalog);
            this.MinimumSize = new System.Drawing.Size(545, 513);
            this.Name = "FrmResource";
            this.Text = "FrmResources";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeCatalog;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Button btnwrite;
        private System.Windows.Forms.TreeView treeselect;
        private com.jajago.SA.UcResources ucResources;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

    }
}

