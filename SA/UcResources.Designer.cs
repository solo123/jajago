namespace com.jajago.SA
{
    partial class UcResources
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.plPhotos = new System.Windows.Forms.FlowLayoutPanel();
            this.listMusics = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listMusics)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.LightGray;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
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
            // plPhotos
            // 
            this.plPhotos.AutoScroll = true;
            this.plPhotos.Location = new System.Drawing.Point(3, 125);
            this.plPhotos.Name = "plPhotos";
            this.plPhotos.Size = new System.Drawing.Size(148, 78);
            this.plPhotos.TabIndex = 1;
            this.plPhotos.Visible = false;
            // 
            // listMusics
            // 
            this.listMusics.AllowUserToAddRows = false;
            this.listMusics.AllowUserToDeleteRows = false;
            this.listMusics.AllowUserToOrderColumns = true;
            this.listMusics.AllowUserToResizeRows = false;
            this.listMusics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.listMusics.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.listMusics.CausesValidation = false;
            this.listMusics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listMusics.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.listMusics.Location = new System.Drawing.Point(172, 18);
            this.listMusics.MultiSelect = false;
            this.listMusics.Name = "listMusics";
            this.listMusics.ReadOnly = true;
            this.listMusics.RowTemplate.Height = 23;
            this.listMusics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listMusics.Size = new System.Drawing.Size(132, 90);
            this.listMusics.TabIndex = 0;
            this.listMusics.Visible = false;
            this.listMusics.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listMusics_CellClick_1);
            // 
            // UcResources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.listMusics);
            this.Controls.Add(this.plPhotos);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UcResources";
            this.Size = new System.Drawing.Size(553, 440);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listMusics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel plPhotos;
        private System.Windows.Forms.DataGridView listMusics;
    }
}
