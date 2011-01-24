namespace com.jajago.SA.Ctls
{
    partial class CtlBookList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listData)).BeginInit();
            this.SuspendLayout();
            // 
            // listMusics
            // 
            this.listData.AllowUserToAddRows = false;
            this.listData.AllowUserToDeleteRows = false;
            this.listData.AllowUserToOrderColumns = true;
            this.listData.AllowUserToResizeRows = false;
            this.listData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.listData.CausesValidation = false;
            this.listData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.listData.EnableHeadersVisualStyles = false;
            this.listData.Location = new System.Drawing.Point(0, 0);
            this.listData.MultiSelect = false;
            this.listData.Name = "listMusics";
            this.listData.ReadOnly = true;
            this.listData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listData.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.listData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.listData.RowTemplate.Height = 23;
            this.listData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listData.Size = new System.Drawing.Size(388, 327);
            this.listData.TabIndex = 1;
            this.listData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listMusics_CellClick);
            // 
            // CtlMusicList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listData);
            this.Name = "CtlMusicList";
            this.Size = new System.Drawing.Size(388, 327);
            ((System.ComponentModel.ISupportInitialize)(this.listData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listData;
    }
}
