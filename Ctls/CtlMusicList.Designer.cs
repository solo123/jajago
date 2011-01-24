namespace com.jajago.SA.Ctls
{
    partial class CtlMusicList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listMusics = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listMusics)).BeginInit();
            this.SuspendLayout();
            // 
            // listMusics
            // 
            this.listMusics.AllowUserToAddRows = false;
            this.listMusics.AllowUserToDeleteRows = false;
            this.listMusics.AllowUserToOrderColumns = true;
            this.listMusics.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.listMusics.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listMusics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listMusics.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.listMusics.CausesValidation = false;
            this.listMusics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listMusics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listMusics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMusics.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.listMusics.EnableHeadersVisualStyles = false;
            this.listMusics.Location = new System.Drawing.Point(0, 0);
            this.listMusics.MultiSelect = false;
            this.listMusics.Name = "listMusics";
            this.listMusics.ReadOnly = true;
            this.listMusics.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listMusics.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listMusics.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.listMusics.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.listMusics.RowTemplate.Height = 23;
            this.listMusics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listMusics.Size = new System.Drawing.Size(388, 327);
            this.listMusics.TabIndex = 1;
            this.listMusics.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listMusics_CellClick);
            // 
            // CtlMusicList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listMusics);
            this.Name = "CtlMusicList";
            this.Size = new System.Drawing.Size(388, 327);
            ((System.ComponentModel.ISupportInitialize)(this.listMusics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listMusics;
    }
}
