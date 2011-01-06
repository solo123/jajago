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
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("资源路径");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("资源配置", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("节点4");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("节点5");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("其他配置", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
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
            treeNode11.Name = "node_resource_path";
            treeNode11.Text = "资源路径";
            treeNode12.Name = "节点0";
            treeNode12.Text = "资源配置";
            treeNode13.Name = "节点4";
            treeNode13.Text = "节点4";
            treeNode14.Name = "节点5";
            treeNode14.Text = "节点5";
            treeNode15.Name = "节点3";
            treeNode15.Text = "其他配置";
            this.treeConfig.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode15});
            this.treeConfig.Size = new System.Drawing.Size(175, 246);
            this.treeConfig.TabIndex = 0;
            this.treeConfig.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeConfig_AfterSelect);
            // 
            // plConfig
            // 
            this.plConfig.Controls.Add(this.btnDelResourcePath);
            this.plConfig.Controls.Add(this.btnAddResourcePath);
            this.plConfig.Controls.Add(this.listResourcePath);
            this.plConfig.Controls.Add(this.label1);
            this.plConfig.Location = new System.Drawing.Point(194, 12);
            this.plConfig.Name = "plConfig";
            this.plConfig.Size = new System.Drawing.Size(424, 246);
            this.plConfig.TabIndex = 1;
            // 
            // btnDelResourcePath
            // 
            this.btnDelResourcePath.Location = new System.Drawing.Point(346, 137);
            this.btnDelResourcePath.Name = "btnDelResourcePath";
            this.btnDelResourcePath.Size = new System.Drawing.Size(75, 23);
            this.btnDelResourcePath.TabIndex = 3;
            this.btnDelResourcePath.Text = "删除";
            this.btnDelResourcePath.UseVisualStyleBackColor = true;
            this.btnDelResourcePath.Click += new System.EventHandler(this.btnDelResourcePath_Click);
            // 
            // btnAddResourcePath
            // 
            this.btnAddResourcePath.Location = new System.Drawing.Point(265, 137);
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
            this.listResourcePath.Size = new System.Drawing.Size(415, 112);
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
            this.btnSave.Location = new System.Drawing.Point(238, 264);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(319, 264);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 305);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.plConfig);
            this.Controls.Add(this.treeConfig);
            this.Name = "FrmConfig";
            this.Text = "选项";
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