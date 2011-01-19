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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbDownloading = new System.Windows.Forms.Label();
            this.bwDownload = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bwShowImage = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.fpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 21);
            this.textBox1.TabIndex = 0;
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
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(100, 100);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lbDownloading
            // 
            this.lbDownloading.AutoSize = true;
            this.lbDownloading.Location = new System.Drawing.Point(410, 15);
            this.lbDownloading.Name = "lbDownloading";
            this.lbDownloading.Size = new System.Drawing.Size(41, 12);
            this.lbDownloading.TabIndex = 4;
            this.lbDownloading.Text = "label1";
            // 
            // bwDownload
            // 
            this.bwDownload.WorkerReportsProgress = true;
            this.bwDownload.WorkerSupportsCancellation = true;
            this.bwDownload.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwDownload_DoWork);
            this.bwDownload.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwDownload_ProgressChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(467, 10);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(227, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // bwShowImage
            // 
            this.bwShowImage.WorkerReportsProgress = true;
            this.bwShowImage.WorkerSupportsCancellation = true;
            this.bwShowImage.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwShowImage_DoWork);
            this.bwShowImage.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwShowImage_ProgressChanged);
            this.bwShowImage.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwShowImage_RunWorkerCompleted);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            // FrmMobiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 411);
            this.Controls.Add(this.fpanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbDownloading);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmMobiles";
            this.Text = "选机中心";
            this.Load += new System.EventHandler(this.FrmMobiles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbDownloading;
        private System.ComponentModel.BackgroundWorker bwDownload;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.BackgroundWorker bwShowImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel fpanel;
    }
}