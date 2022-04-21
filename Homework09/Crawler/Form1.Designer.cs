namespace Crawler
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblURL = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtBoxURL = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBoxOutput = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblURL);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.txtBoxURL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 259);
            this.panel1.TabIndex = 0;
            // 
            // lblURL
            // 
            this.lblURL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblURL.AutoSize = true;
            this.lblURL.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblURL.Location = new System.Drawing.Point(61, 66);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(99, 20);
            this.lblURL.TabIndex = 2;
            this.lblURL.Text = "初始URL：";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(763, 173);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(182, 52);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtBoxURL
            // 
            this.txtBoxURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxURL.Font = new System.Drawing.Font("宋体", 10F);
            this.txtBoxURL.Location = new System.Drawing.Point(198, 56);
            this.txtBoxURL.Name = "txtBoxURL";
            this.txtBoxURL.Size = new System.Drawing.Size(747, 30);
            this.txtBoxURL.TabIndex = 0;
            this.txtBoxURL.Text = "http://www.cnblogs.com/dstang2000/";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtBoxOutput);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 259);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1065, 695);
            this.panel2.TabIndex = 1;
            // 
            // txtBoxOutput
            // 
            this.txtBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxOutput.Location = new System.Drawing.Point(0, 0);
            this.txtBoxOutput.Margin = new System.Windows.Forms.Padding(10);
            this.txtBoxOutput.Multiline = true;
            this.txtBoxOutput.Name = "txtBoxOutput";
            this.txtBoxOutput.ReadOnly = true;
            this.txtBoxOutput.Size = new System.Drawing.Size(1065, 695);
            this.txtBoxOutput.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 954);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBoxOutput;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtBoxURL;
    }
}

