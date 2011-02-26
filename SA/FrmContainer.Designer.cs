namespace com.jajago.SA
{
    partial class FrmContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContainer));
            this.MenuMain = new System.Windows.Forms.MenuStrip();
            this.aaaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shoujiCxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.huiyuanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tuiChuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolMain = new System.Windows.Forms.ToolStrip();
            this.tsResource = new System.Windows.Forms.ToolStripButton();
            this.tsMobiles = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.StatusMain = new System.Windows.Forms.StatusStrip();
            this.lbstatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuMain.SuspendLayout();
            this.ToolMain.SuspendLayout();
            this.StatusMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuMain
            // 
            this.MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aaaaToolStripMenuItem,
            this.shoujiCxToolStripMenuItem,
            this.huiyuanToolStripMenuItem,
            this.menuConfig,
            this.tuiChuToolStripMenuItem});
            this.MenuMain.Location = new System.Drawing.Point(0, 0);
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.Size = new System.Drawing.Size(729, 24);
            this.MenuMain.TabIndex = 1;
            this.MenuMain.Text = "menuStrip1";
            // 
            // aaaaToolStripMenuItem
            // 
            this.aaaaToolStripMenuItem.Name = "aaaaToolStripMenuItem";
            this.aaaaToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.aaaaToolStripMenuItem.Text = "资源管理";
            // 
            // shoujiCxToolStripMenuItem
            // 
            this.shoujiCxToolStripMenuItem.Name = "shoujiCxToolStripMenuItem";
            this.shoujiCxToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.shoujiCxToolStripMenuItem.Text = "手机展示";
            // 
            // huiyuanToolStripMenuItem
            // 
            this.huiyuanToolStripMenuItem.Name = "huiyuanToolStripMenuItem";
            this.huiyuanToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.huiyuanToolStripMenuItem.Text = "会员专区";
            // 
            // menuConfig
            // 
            this.menuConfig.Name = "menuConfig";
            this.menuConfig.Size = new System.Drawing.Size(41, 20);
            this.menuConfig.Text = "选项";
            this.menuConfig.Click += new System.EventHandler(this.menuConfig_Click);
            // 
            // tuiChuToolStripMenuItem
            // 
            this.tuiChuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.tsUpdate,
            this.testToolStripMenuItem});
            this.tuiChuToolStripMenuItem.Name = "tuiChuToolStripMenuItem";
            this.tuiChuToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.tuiChuToolStripMenuItem.Text = "关于";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.updateToolStripMenuItem.Text = "update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // tsUpdate
            // 
            this.tsUpdate.Name = "tsUpdate";
            this.tsUpdate.Size = new System.Drawing.Size(152, 22);
            this.tsUpdate.Text = "在线更新";
            this.tsUpdate.Click += new System.EventHandler(this.tsUpdate_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.testToolStripMenuItem.Text = "test";
            // 
            // ToolMain
            // 
            this.ToolMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsResource,
            this.tsMobiles,
            this.toolStripButton2});
            this.ToolMain.Location = new System.Drawing.Point(0, 24);
            this.ToolMain.Name = "ToolMain";
            this.ToolMain.Size = new System.Drawing.Size(729, 39);
            this.ToolMain.TabIndex = 2;
            this.ToolMain.Text = "toolStrip1";
            // 
            // tsResource
            // 
            this.tsResource.AutoSize = false;
            this.tsResource.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsResource.Image = global::com.jajago.SA.Properties.Resources.btn_resource;
            this.tsResource.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsResource.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsResource.Name = "tsResource";
            this.tsResource.Size = new System.Drawing.Size(124, 36);
            this.tsResource.Text = "资源管理";
            this.tsResource.Click += new System.EventHandler(this.tsResource_Click);
            // 
            // tsMobiles
            // 
            this.tsMobiles.AutoSize = false;
            this.tsMobiles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsMobiles.Image = global::com.jajago.SA.Properties.Resources.btn_mobile;
            this.tsMobiles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsMobiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMobiles.Name = "tsMobiles";
            this.tsMobiles.Size = new System.Drawing.Size(124, 36);
            this.tsMobiles.Text = "选机中心";
            this.tsMobiles.Click += new System.EventHandler(this.tsMobiles_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::com.jajago.SA.Properties.Resources.btn_member;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(124, 36);
            this.toolStripButton2.Text = "会员服务";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // StatusMain
            // 
            this.StatusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbstatus});
            this.StatusMain.Location = new System.Drawing.Point(0, 308);
            this.StatusMain.Name = "StatusMain";
            this.StatusMain.Size = new System.Drawing.Size(729, 22);
            this.StatusMain.TabIndex = 3;
            this.StatusMain.Text = "statusStrip1";
            // 
            // lbstatus
            // 
            this.lbstatus.Name = "lbstatus";
            this.lbstatus.Size = new System.Drawing.Size(131, 17);
            this.lbstatus.Text = "toolStripStatusLabel1";
            // 
            // FrmContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 330);
            this.Controls.Add(this.StatusMain);
            this.Controls.Add(this.ToolMain);
            this.Controls.Add(this.MenuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuMain;
            this.Name = "FrmContainer";
            this.Text = "[酷购]手机门店助手";
            this.MenuMain.ResumeLayout(false);
            this.MenuMain.PerformLayout();
            this.ToolMain.ResumeLayout(false);
            this.ToolMain.PerformLayout();
            this.StatusMain.ResumeLayout(false);
            this.StatusMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuMain;
        private System.Windows.Forms.ToolStripMenuItem aaaaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ToolMain;
        private System.Windows.Forms.ToolStripButton tsResource;
        private System.Windows.Forms.StatusStrip StatusMain;
        private System.Windows.Forms.ToolStripMenuItem shoujiCxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem huiyuanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tuiChuToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsMobiles;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem menuConfig;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lbstatus;
        private System.Windows.Forms.ToolStripMenuItem tsUpdate;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
    }
}