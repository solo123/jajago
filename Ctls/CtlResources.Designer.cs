namespace com.jajago.SA.Ctls
{
    partial class CtlResources
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ctlPhotoList = new com.jajago.SA.Ctls.CtlPhotoList();
            this.ctlMusicList = new com.jajago.SA.Ctls.CtlMusicList();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(148, 90);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // ctlPhotoList
            // 
            this.ctlPhotoList.Location = new System.Drawing.Point(3, 114);
            this.ctlPhotoList.Name = "ctlPhotoList";
            this.ctlPhotoList.SelectedCount = 0;
            this.ctlPhotoList.SelectedSize = 0;
            this.ctlPhotoList.Size = new System.Drawing.Size(148, 74);
            this.ctlPhotoList.TabIndex = 3;
            this.ctlPhotoList.TotalCount = 0;
            this.ctlPhotoList.TotalSize = 0;
            // 
            // ctlMusicList
            // 
            this.ctlMusicList.Location = new System.Drawing.Point(165, 18);
            this.ctlMusicList.Name = "ctlMusicList";
            this.ctlMusicList.SelectedCount = 0;
            this.ctlMusicList.SelectedSize = 0;
            this.ctlMusicList.Size = new System.Drawing.Size(129, 90);
            this.ctlMusicList.TabIndex = 2;
            this.ctlMusicList.TotalCount = 0;
            this.ctlMusicList.TotalSize = 0;
            // 
            // CtlResources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctlPhotoList);
            this.Controls.Add(this.ctlMusicList);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CtlResources";
            this.Size = new System.Drawing.Size(553, 440);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Ctls.CtlMusicList ctlMusicList;
        private CtlPhotoList ctlPhotoList;
    }
}
