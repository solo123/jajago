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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMobiles));
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.bwDownload = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.fpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lbProgressMessage = new System.Windows.Forms.Label();
            this.plProgress = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
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
            this.fpanel.Location = new System.Drawing.Point(12, 39);
            this.fpanel.Name = "fpanel";
            this.fpanel.Size = new System.Drawing.Size(682, 360);
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
            // FrmMobiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 411);
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
    }
}