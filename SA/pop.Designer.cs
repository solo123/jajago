namespace com.jajago.SA
{
    partial class frmPop
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
            this.pgbpop = new System.Windows.Forms.ProgressBar();
            this.lbOut = new System.Windows.Forms.Label();
            this.tim = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pgbpop
            // 
            this.pgbpop.Location = new System.Drawing.Point(71, 314);
            this.pgbpop.Maximum = 3;
            this.pgbpop.Name = "pgbpop";
            this.pgbpop.Size = new System.Drawing.Size(341, 28);
            this.pgbpop.Step = 1;
            this.pgbpop.TabIndex = 0;
            // 
            // lbOut
            // 
            this.lbOut.AutoSize = true;
            this.lbOut.Location = new System.Drawing.Point(69, 69);
            this.lbOut.Name = "lbOut";
            this.lbOut.Size = new System.Drawing.Size(95, 12);
            this.lbOut.TabIndex = 1;
            this.lbOut.Text = "正在加载数据...";
            // 
            // tim
            // 
            this.tim.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Quit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(505, 354);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbOut);
            this.Controls.Add(this.pgbpop);
            this.Name = "frmPop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "扫描文件";
            this.Load += new System.EventHandler(this.frmPop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbpop;
        private System.Windows.Forms.Label lbOut;
        private System.Windows.Forms.Timer tim;
        private System.Windows.Forms.Button button1;
    }
}