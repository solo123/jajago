namespace com.jajago.SA
{
    partial class FrmConfig
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("资源路径");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("资源配置", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("常规");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("自定义", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("其他配置", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfig));
            this.treeConfig = new System.Windows.Forms.TreeView();
            this.plConfig = new System.Windows.Forms.Panel();
            this.btnDelResourcePath = new System.Windows.Forms.Button();
            this.btnAddResourcePath = new System.Windows.Forms.Button();
            this.listResourcePath = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.plConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeConfig
            // 
            this.treeConfig.Location = new System.Drawing.Point(12, 12);
            this.treeConfig.Name = "treeConfig";
            treeNode1.Name = "node_resource_path";
            treeNode1.Text = "资源路径";
            treeNode2.Name = "节点0";
            treeNode2.Text = "资源配置";
            treeNode3.Name = "节点4";
            treeNode3.Text = "常规";
            treeNode4.Name = "节点5";
            treeNode4.Text = "自定义";
            treeNode5.Name = "节点3";
            treeNode5.Text = "其他配置";
            this.treeConfig.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode5});
            this.treeConfig.Size = new System.Drawing.Size(175, 246);
            this.treeConfig.TabIndex = 0;
            this.treeConfig.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeConfig_AfterSelect);
            // 
            // plConfig
            // 
            this.plConfig.BackColor = System.Drawing.SystemColors.Control;
            this.plConfig.Controls.Add(this.btnDelResourcePath);
            this.plConfig.Controls.Add(this.btnAddResourcePath);
            this.plConfig.Controls.Add(this.listResourcePath);
            this.plConfig.Controls.Add(this.label1);
            this.plConfig.Location = new System.Drawing.Point(194, 12);
            this.plConfig.Name = "plConfig";
            this.plConfig.Size = new System.Drawing.Size(424, 246);
            this.plConfig.TabIndex = 1;
            this.plConfig.Visible = false;
            // 
            // btnDelResourcePath
            // 
            this.btnDelResourcePath.Location = new System.Drawing.Point(338, 220);
            this.btnDelResourcePath.Name = "btnDelResourcePath";
            this.btnDelResourcePath.Size = new System.Drawing.Size(75, 23);
            this.btnDelResourcePath.TabIndex = 3;
            this.btnDelResourcePath.Text = "删除";
            this.btnDelResourcePath.UseVisualStyleBackColor = true;
            this.btnDelResourcePath.Click += new System.EventHandler(this.btnDelResourcePath_Click);
            // 
            // btnAddResourcePath
            // 
            this.btnAddResourcePath.Location = new System.Drawing.Point(257, 220);
            this.btnAddResourcePath.Name = "btnAddResourcePath";
            this.btnAddResourcePath.Size = new System.Drawing.Size(75, 23);
            this.btnAddResourcePath.TabIndex = 2;
            this.btnAddResourcePath.Text = "添加";
            this.btnAddResourcePath.UseVisualStyleBackColor = true;
            this.btnAddResourcePath.Click += new System.EventHandler(this.btnAddResourcePath_Click);
            // 
            // listResourcePath
            // 
            this.listResourcePath.FormattingEnabled = true;
            this.listResourcePath.ItemHeight = 12;
            this.listResourcePath.Location = new System.Drawing.Point(6, 19);
            this.listResourcePath.Name = "listResourcePath";
            this.listResourcePath.Size = new System.Drawing.Size(407, 196);
            this.listResourcePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "资源扫描路径：";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(200, 264);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(281, 264);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmConfig
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 305);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.plConfig);
            this.Controls.Add(this.treeConfig);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConfig";
            this.Text = "选项";
            this.Load += new System.EventHandler(this.FrmConfig_Load);
            this.plConfig.ResumeLayout(false);
            this.plConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeConfig;
        private System.Windows.Forms.Panel plConfig;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox listResourcePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddResourcePath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnDelResourcePath;
    }
}