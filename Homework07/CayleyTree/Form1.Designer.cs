namespace CayleyTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lLength = new System.Windows.Forms.Label();
            this.lDepth = new System.Windows.Forms.Label();
            this.LColor = new System.Windows.Forms.Label();
            this.lPerR = new System.Windows.Forms.Label();
            this.lPerL = new System.Windows.Forms.Label();
            this.ccbLength = new System.Windows.Forms.ComboBox();
            this.tbDepth = new System.Windows.Forms.TextBox();
            this.nudAngleR = new System.Windows.Forms.NumericUpDown();
            this.nudAngleL = new System.Windows.Forms.NumericUpDown();
            this.nupPerL = new System.Windows.Forms.NumericUpDown();
            this.nupPerR = new System.Windows.Forms.NumericUpDown();
            this.lAngelL = new System.Windows.Forms.Label();
            this.lAngleR = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.Button();
            this.pnColor = new System.Windows.Forms.Panel();
            this.rbtnGreen = new System.Windows.Forms.RadioButton();
            this.rbtnOrange = new System.Windows.Forms.RadioButton();
            this.rbtnBlue = new System.Windows.Forms.RadioButton();
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAngleR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAngleL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPerL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPerR)).BeginInit();
            this.pnColor.SuspendLayout();
            this.DrawingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoScroll = true;
            this.tableLayoutPanel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.lLength, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.lDepth, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.LColor, 0, 7);
            this.tableLayoutPanel.Controls.Add(this.lPerR, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.lPerL, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.ccbLength, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.tbDepth, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.nudAngleR, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.nudAngleL, 1, 6);
            this.tableLayoutPanel.Controls.Add(this.nupPerL, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.nupPerR, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.lAngelL, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.lAngleR, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.btnDraw, 1, 7);
            this.tableLayoutPanel.Controls.Add(this.pnColor, 1, 7);
            this.tableLayoutPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tableLayoutPanel.Location = new System.Drawing.Point(500, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 10;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(331, 513);
            this.tableLayoutPanel.TabIndex = 2;
            this.tableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lLength
            // 
            this.lLength.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lLength.AutoSize = true;
            this.lLength.Location = new System.Drawing.Point(80, 39);
            this.lLength.Name = "lLength";
            this.lLength.Size = new System.Drawing.Size(82, 24);
            this.lLength.TabIndex = 6;
            this.lLength.Text = "主干长度";
            // 
            // lDepth
            // 
            this.lDepth.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lDepth.AutoSize = true;
            this.lDepth.Location = new System.Drawing.Point(80, 89);
            this.lDepth.Name = "lDepth";
            this.lDepth.Size = new System.Drawing.Size(82, 24);
            this.lDepth.TabIndex = 3;
            this.lDepth.Text = "递归深度";
            // 
            // LColor
            // 
            this.LColor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LColor.AutoSize = true;
            this.LColor.Location = new System.Drawing.Point(80, 364);
            this.LColor.Name = "LColor";
            this.LColor.Size = new System.Drawing.Size(82, 24);
            this.LColor.TabIndex = 5;
            this.LColor.Text = "画笔颜色";
            // 
            // lPerR
            // 
            this.lPerR.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lPerR.AutoSize = true;
            this.lPerR.Location = new System.Drawing.Point(44, 139);
            this.lPerR.Name = "lPerR";
            this.lPerR.Size = new System.Drawing.Size(118, 24);
            this.lPerR.TabIndex = 4;
            this.lPerR.Text = "右分支长度比";
            // 
            // lPerL
            // 
            this.lPerL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lPerL.AutoSize = true;
            this.lPerL.Location = new System.Drawing.Point(44, 189);
            this.lPerL.Name = "lPerL";
            this.lPerL.Size = new System.Drawing.Size(118, 24);
            this.lPerL.TabIndex = 2;
            this.lPerL.Text = "左分支长度比";
            // 
            // ccbLength
            // 
            this.ccbLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ccbLength.FormattingEnabled = true;
            this.ccbLength.Location = new System.Drawing.Point(168, 35);
            this.ccbLength.Name = "ccbLength";
            this.ccbLength.Size = new System.Drawing.Size(160, 32);
            this.ccbLength.TabIndex = 7;
            this.ccbLength.Text = "100";
            this.ccbLength.SelectedIndexChanged += new System.EventHandler(this.ccbLength_SelectedIndexChanged);
            // 
            // tbDepth
            // 
            this.tbDepth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDepth.Location = new System.Drawing.Point(168, 85);
            this.tbDepth.Name = "tbDepth";
            this.tbDepth.Size = new System.Drawing.Size(160, 31);
            this.tbDepth.TabIndex = 8;
            this.tbDepth.Text = "10";
            this.tbDepth.TextChanged += new System.EventHandler(this.tbDepth_TextChanged);
            // 
            // nudAngleR
            // 
            this.nudAngleR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAngleR.Location = new System.Drawing.Point(168, 235);
            this.nudAngleR.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nudAngleR.Name = "nudAngleR";
            this.nudAngleR.Size = new System.Drawing.Size(160, 31);
            this.nudAngleR.TabIndex = 11;
            this.nudAngleR.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudAngleR.ValueChanged += new System.EventHandler(this.nudAngleR_ValueChanged);
            // 
            // nudAngleL
            // 
            this.nudAngleL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAngleL.Location = new System.Drawing.Point(168, 285);
            this.nudAngleL.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nudAngleL.Name = "nudAngleL";
            this.nudAngleL.Size = new System.Drawing.Size(160, 31);
            this.nudAngleL.TabIndex = 12;
            this.nudAngleL.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudAngleL.ValueChanged += new System.EventHandler(this.nudAngleL_ValueChanged);
            // 
            // nupPerL
            // 
            this.nupPerL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nupPerL.DecimalPlaces = 1;
            this.nupPerL.Location = new System.Drawing.Point(168, 185);
            this.nupPerL.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupPerL.Name = "nupPerL";
            this.nupPerL.Size = new System.Drawing.Size(160, 31);
            this.nupPerL.TabIndex = 13;
            this.nupPerL.Value = new decimal(new int[] {
            7,
            0,
            0,
            65536});
            this.nupPerL.ValueChanged += new System.EventHandler(this.nupPerL_ValueChanged);
            // 
            // nupPerR
            // 
            this.nupPerR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nupPerR.DecimalPlaces = 1;
            this.nupPerR.Location = new System.Drawing.Point(168, 135);
            this.nupPerR.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupPerR.Name = "nupPerR";
            this.nupPerR.Size = new System.Drawing.Size(160, 31);
            this.nupPerR.TabIndex = 14;
            this.nupPerR.Value = new decimal(new int[] {
            6,
            0,
            0,
            65536});
            this.nupPerR.ValueChanged += new System.EventHandler(this.nupPerR_ValueChanged);
            // 
            // lAngelL
            // 
            this.lAngelL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lAngelL.AutoSize = true;
            this.lAngelL.Location = new System.Drawing.Point(62, 289);
            this.lAngelL.Name = "lAngelL";
            this.lAngelL.Size = new System.Drawing.Size(100, 24);
            this.lAngelL.TabIndex = 1;
            this.lAngelL.Text = "左分支角度";
            // 
            // lAngleR
            // 
            this.lAngleR.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lAngleR.AutoSize = true;
            this.lAngleR.Location = new System.Drawing.Point(62, 239);
            this.lAngleR.Name = "lAngleR";
            this.lAngleR.Size = new System.Drawing.Size(100, 24);
            this.lAngleR.TabIndex = 0;
            this.lAngleR.Text = "右分支角度";
            // 
            // btnDraw
            // 
            this.btnDraw.BackColor = System.Drawing.Color.RosyBrown;
            this.tableLayoutPanel.SetColumnSpan(this.btnDraw, 2);
            this.btnDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDraw.Location = new System.Drawing.Point(50, 436);
            this.btnDraw.Margin = new System.Windows.Forms.Padding(50, 10, 50, 0);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(231, 50);
            this.btnDraw.TabIndex = 16;
            this.btnDraw.Text = "&Draw";
            this.btnDraw.UseVisualStyleBackColor = false;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // pnColor
            // 
            this.pnColor.BackColor = System.Drawing.SystemColors.Menu;
            this.pnColor.Controls.Add(this.rbtnGreen);
            this.pnColor.Controls.Add(this.rbtnOrange);
            this.pnColor.Controls.Add(this.rbtnBlue);
            this.pnColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnColor.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnColor.Location = new System.Drawing.Point(168, 329);
            this.pnColor.Name = "pnColor";
            this.pnColor.Size = new System.Drawing.Size(160, 94);
            this.pnColor.TabIndex = 17;
            // 
            // rbtnGreen
            // 
            this.rbtnGreen.AutoSize = true;
            this.rbtnGreen.Location = new System.Drawing.Point(3, 69);
            this.rbtnGreen.Name = "rbtnGreen";
            this.rbtnGreen.Size = new System.Drawing.Size(85, 26);
            this.rbtnGreen.TabIndex = 2;
            this.rbtnGreen.Text = "green";
            this.rbtnGreen.UseVisualStyleBackColor = true;
            this.rbtnGreen.CheckedChanged += new System.EventHandler(this.rbtnGreen_CheckedChanged);
            // 
            // rbtnOrange
            // 
            this.rbtnOrange.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbtnOrange.AutoSize = true;
            this.rbtnOrange.Location = new System.Drawing.Point(3, 37);
            this.rbtnOrange.Name = "rbtnOrange";
            this.rbtnOrange.Size = new System.Drawing.Size(95, 26);
            this.rbtnOrange.TabIndex = 1;
            this.rbtnOrange.Text = "orange";
            this.rbtnOrange.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbtnOrange.UseVisualStyleBackColor = true;
            this.rbtnOrange.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbtnBlue
            // 
            this.rbtnBlue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbtnBlue.AutoSize = true;
            this.rbtnBlue.Checked = true;
            this.rbtnBlue.Location = new System.Drawing.Point(3, 5);
            this.rbtnBlue.Name = "rbtnBlue";
            this.rbtnBlue.Size = new System.Drawing.Size(75, 26);
            this.rbtnBlue.TabIndex = 0;
            this.rbtnBlue.TabStop = true;
            this.rbtnBlue.Text = "blue";
            this.rbtnBlue.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbtnBlue.UseVisualStyleBackColor = true;
            this.rbtnBlue.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.Controls.Add(this.tableLayoutPanel);
            this.DrawingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawingPanel.Location = new System.Drawing.Point(0, 0);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(831, 513);
            this.DrawingPanel.TabIndex = 3;
            this.DrawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingPanel_Paint_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 513);
            this.Controls.Add(this.DrawingPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CaycelTreeForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAngleR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAngleL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPerL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPerR)).EndInit();
            this.pnColor.ResumeLayout(false);
            this.pnColor.PerformLayout();
            this.DrawingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label lLength;
        private System.Windows.Forms.Label lDepth;
        private System.Windows.Forms.Label LColor;
        private System.Windows.Forms.Label lPerR;
        private System.Windows.Forms.Label lPerL;
        private System.Windows.Forms.Label lAngelL;
        private System.Windows.Forms.Label lAngleR;
        private System.Windows.Forms.ComboBox ccbLength;
        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.TextBox tbDepth;
        private System.Windows.Forms.NumericUpDown nudAngleR;
        private System.Windows.Forms.NumericUpDown nudAngleL;
        private System.Windows.Forms.NumericUpDown nupPerL;
        private System.Windows.Forms.NumericUpDown nupPerR;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Panel pnColor;
        private System.Windows.Forms.RadioButton rbtnGreen;
        private System.Windows.Forms.RadioButton rbtnOrange;
        private System.Windows.Forms.RadioButton rbtnBlue;
    }
}

