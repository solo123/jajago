namespace com.jajago.SA
{
    partial class FrmMobiles
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("诺基亚");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("三星");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("摩托罗拉");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("索尼爱立信");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("联想");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("天语");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("长虹");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("康佳");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("oppo");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("金立");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("创维");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("七喜");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("手机品牌分类", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("电信天翼 3G");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("移动TD 3G");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("音乐手机");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("电视购物");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("老人手机");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("情侣手机");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("滑盖手机");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("手机功能分类", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("200 元以下");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("200 - 500 元");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("500 - 1000 元");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("1000- 1500 元");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("1500- 2000 元");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("2000 元以上");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("手机价格分类", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMobiles));
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.bwDownload = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.fpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lbProgressMessage = new System.Windows.Forms.Label();
            this.plProgress = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tvSelect = new System.Windows.Forms.TreeView();
            this.plProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(12, 12);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(239, 21);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // bwDownload
            // 
            this.bwDownload.WorkerReportsProgress = true;
            this.bwDownload.WorkerSupportsCancellation = true;
            this.bwDownload.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwDownload_DoWork);
            this.bwDownload.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwDownload_ProgressChanged);
            this.bwDownload.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwDownload_RunWorkerCompleted);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(50, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(120, 23);
            this.progressBar.TabIndex = 5;
            this.progressBar.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // fpanel
            // 
            this.fpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fpanel.AutoScroll = true;
            this.fpanel.Location = new System.Drawing.Point(160, 39);
            this.fpanel.Name = "fpanel";
            this.fpanel.Size = new System.Drawing.Size(534, 360);
            this.fpanel.TabIndex = 7;
            // 
            // lbProgressMessage
            // 
            this.lbProgressMessage.AutoSize = true;
            this.lbProgressMessage.Location = new System.Drawing.Point(3, 9);
            this.lbProgressMessage.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
            this.lbProgressMessage.Name = "lbProgressMessage";
            this.lbProgressMessage.Size = new System.Drawing.Size(41, 12);
            this.lbProgressMessage.TabIndex = 9;
            this.lbProgressMessage.Text = "label1";
            this.lbProgressMessage.UseWaitCursor = true;
            // 
            // plProgress
            // 
            this.plProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.plProgress.Controls.Add(this.lbProgressMessage);
            this.plProgress.Controls.Add(this.progressBar);
            this.plProgress.Controls.Add(this.button1);
            this.plProgress.Location = new System.Drawing.Point(466, 3);
            this.plProgress.Name = "plProgress";
            this.plProgress.Size = new System.Drawing.Size(228, 30);
            this.plProgress.TabIndex = 10;
            this.plProgress.UseWaitCursor = true;
            this.plProgress.Visible = false;
            this.plProgress.WrapContents = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(257, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // tvSelect
            // 
            this.tvSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.tvSelect.Location = new System.Drawing.Point(12, 54);
            this.tvSelect.Name = "tvSelect";
            treeNode1.Name = "节点0";
            treeNode1.Text = "诺基亚";
            treeNode2.Name = "节点1";
            treeNode2.Text = "三星";
            treeNode3.Name = "节点2";
            treeNode3.Text = "摩托罗拉";
            treeNode4.Name = "节点0";
            treeNode4.Text = "索尼爱立信";
            treeNode5.Name = "节点1";
            treeNode5.Text = "联想";
            treeNode6.Name = "节点2";
            treeNode6.Text = "天语";
            treeNode7.Name = "节点3";
            treeNode7.Text = "长虹";
            treeNode8.Name = "节点4";
            treeNode8.Text = "康佳";
            treeNode9.Name = "节点5";
            treeNode9.Text = "oppo";
            treeNode10.Name = "节点6";
            treeNode10.Text = "金立";
            treeNode11.Name = "节点7";
            treeNode11.Text = "创维";
            treeNode12.Name = "节点8";
            treeNode12.Text = "七喜";
            treeNode13.Name = "节点0";
            treeNode13.Text = "手机品牌分类";
            treeNode14.Name = "节点10";
            treeNode14.Text = "电信天翼 3G";
            treeNode15.Name = "节点11";
            treeNode15.Text = "移动TD 3G";
            treeNode16.Name = "节点12";
            treeNode16.Text = "音乐手机";
            treeNode17.Name = "节点13";
            treeNode17.Text = "电视购物";
            treeNode18.Name = "节点14";
            treeNode18.Text = "老人手机";
            treeNode19.Name = "节点15";
            treeNode19.Text = "情侣手机";
            treeNode20.Name = "节点16";
            treeNode20.Text = "滑盖手机";
            treeNode21.Name = "节点9";
            treeNode21.Text = "手机功能分类";
            treeNode22.Name = "节点18";
            treeNode22.Text = "200 元以下";
            treeNode23.Name = "节点19";
            treeNode23.Tag = "200,500";
            treeNode23.Text = "200 - 500 元";
            treeNode24.Name = "节点20";
            treeNode24.Text = "500 - 1000 元";
            treeNode25.Name = "节点21";
            treeNode25.Text = "1000- 1500 元";
            treeNode26.Name = "节点22";
            treeNode26.Text = "1500- 2000 元";
            treeNode27.Name = "节点24";
            treeNode27.Text = "2000 元以上";
            treeNode28.Name = "节点17";
            treeNode28.Text = "手机价格分类";
            this.tvSelect.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode21,
            treeNode28});
            this.tvSelect.Size = new System.Drawing.Size(142, 345);
            this.tvSelect.TabIndex = 11;
            this.tvSelect.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvSelect_NodeMouseClick);
            // 
            // FrmMobiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 411);
            this.Controls.Add(this.tvSelect);
            this.Controls.Add(this.plProgress);
            this.Controls.Add(this.fpanel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtFilter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMobiles";
            this.Text = "选机中心";
            this.Load += new System.EventHandler(this.FrmMobiles_Load);
            this.plProgress.ResumeLayout(false);
            this.plProgress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilter;
        private System.ComponentModel.BackgroundWorker bwDownload;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel fpanel;
        private System.Windows.Forms.Label lbProgressMessage;
        private System.Windows.Forms.FlowLayoutPanel plProgress;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TreeView tvSelect;
    }
}