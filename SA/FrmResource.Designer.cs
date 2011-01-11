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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.pnResources = new System.Windows.Forms.Panel();
            this.treeselect = new System.Windows.Forms.TreeView();
            this.lbcount = new System.Windows.Forms.Label();
            this.btnwrite = new System.Windows.Forms.Button();
            this.gridResource = new System.Windows.Forms.DataGridView();
            this.treeCatalog = new System.Windows.Forms.TreeView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.comBobox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.pnResources.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResource)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(651, 30);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(29, 12);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "关于";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.HotTrack = true;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(737, 486);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnScan);
            this.tabPage4.Controls.Add(this.btnselect);
            this.tabPage4.Controls.Add(this.pnResources);
            this.tabPage4.Controls.Add(this.treeCatalog);
            this.tabPage4.Controls.Add(this.checkBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 21);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(729, 461);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "手机资源";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(96, 6);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "扫描本地资源";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(186, 6);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(75, 23);
            this.btnselect.TabIndex = 3;
            this.btnselect.Text = "选中";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // pnResources
            // 
            this.pnResources.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnResources.Controls.Add(this.treeselect);
            this.pnResources.Controls.Add(this.lbcount);
            this.pnResources.Controls.Add(this.btnwrite);
            this.pnResources.Controls.Add(this.gridResource);
            this.pnResources.Location = new System.Drawing.Point(126, 34);
            this.pnResources.Name = "pnResources";
            this.pnResources.Size = new System.Drawing.Size(601, 421);
            this.pnResources.TabIndex = 2;
            // 
            // treeselect
            // 
            this.treeselect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeselect.Location = new System.Drawing.Point(378, 0);
            this.treeselect.Name = "treeselect";
            this.treeselect.Size = new System.Drawing.Size(221, 373);
            this.treeselect.TabIndex = 1;
            // 
            // lbcount
            // 
            this.lbcount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbcount.AutoSize = true;
            this.lbcount.Location = new System.Drawing.Point(392, 380);
            this.lbcount.Name = "lbcount";
            this.lbcount.Size = new System.Drawing.Size(0, 12);
            this.lbcount.TabIndex = 6;
            // 
            // btnwrite
            // 
            this.btnwrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnwrite.Location = new System.Drawing.Point(437, 395);
            this.btnwrite.Name = "btnwrite";
            this.btnwrite.Size = new System.Drawing.Size(75, 23);
            this.btnwrite.TabIndex = 4;
            this.btnwrite.Text = "写入";
            this.btnwrite.UseVisualStyleBackColor = true;
            this.btnwrite.Click += new System.EventHandler(this.btnwrite_Click);
            // 
            // gridResource
            // 
            this.gridResource.AllowUserToResizeRows = false;
            this.gridResource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridResource.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridResource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResource.Location = new System.Drawing.Point(0, 0);
            this.gridResource.Name = "gridResource";
            this.gridResource.ReadOnly = true;
            this.gridResource.RowTemplate.Height = 23;
            this.gridResource.Size = new System.Drawing.Size(373, 421);
            this.gridResource.TabIndex = 0;
            // 
            // treeCatalog
            // 
            this.treeCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.treeCatalog.Location = new System.Drawing.Point(6, 34);
            this.treeCatalog.Name = "treeCatalog";
            this.treeCatalog.Size = new System.Drawing.Size(116, 421);
            this.treeCatalog.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 16);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "只显示本地";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.treeView2);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.comBobox2);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.comboBox1);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Location = new System.Drawing.Point(4, 21);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(716, 359);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "套装";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // treeView2
            // 
            this.treeView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView2.Location = new System.Drawing.Point(8, 90);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(121, 266);
            this.treeView2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "型号";
            // 
            // comBobox2
            // 
            this.comBobox2.FormattingEnabled = true;
            this.comBobox2.Location = new System.Drawing.Point(8, 64);
            this.comBobox2.Name = "comBobox2";
            this.comBobox2.Size = new System.Drawing.Size(121, 20);
            this.comBobox2.TabIndex = 3;
            this.comBobox2.Text = "请选择";
            this.comBobox2.SelectedIndexChanged += new System.EventHandler(this.comBobox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "品牌";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "诺基亚",
            "索爱",
            "三星",
            "摩托罗拉",
            "LG",
            "多普达"});
            this.comboBox1.Location = new System.Drawing.Point(8, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "请选择";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "手机型号";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::com.jajago.SA.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 71);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmResource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(737, 486);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.MinimumSize = new System.Drawing.Size(745, 513);
            this.Name = "FrmResource";
            this.Text = "家家购";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.pnResources.ResumeLayout(false);
            this.pnResources.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResource)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TreeView treeCatalog;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comBobox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnResources;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.DataGridView gridResource;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Button btnwrite;
        private System.Windows.Forms.TreeView treeselect;
        private System.Windows.Forms.Label lbcount;
    }
}

