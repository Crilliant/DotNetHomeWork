﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class Form1 : Form
    {

		private Graphics graphics;
		double th1 { set; get; } = 30 * Math.PI / 180;//右分支角度（th1）
		double th2 { set; get; } = 20 * Math.PI / 180;//左分支角度（th2）
		double per1 { set; get; } = 0.6;//右分支长度比（per1）
		double per2 { set; get; } = 0.7;//左分支长度比（per2）
		int depth { set; get; } = 10;
		double leng { get; set; } = 100;//主干长度
		Pen pen = Pens.CornflowerBlue;


		public Form1()
		{
			InitializeComponent();
			InitData();
			this.AutoScaleBaseSize = new Size(6, 14);			
			this.ClientSize = new Size(700, 500);
			//this.Paint += new PaintEventHandler(this.Form1_Paint);
		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}
		private void InitData()
        {
			ccbLength.Items.AddRange(new object[] { "80", "100", "120" });

		}


		void drawCayleyTree(
				double x0, double y0, double leng, double th,int curDepth)
		{
			if (curDepth == 0) return;

			double x1 = x0 + leng * Math.Cos(th);
			double y1 = y0 + leng * Math.Sin(th);

			drawLine(x0, y0, x1, y1);//主干

			drawCayleyTree( x1, y1, per2 * leng, th - th2, curDepth-1);
			drawCayleyTree( x1, y1, per1 * leng, th + th1, curDepth-1);
			
		}
		void drawLine(double x0, double y0, double x1, double y1)
		{
			graphics.DrawLine(
				pen,
				(int)x0, (int)y0, (int)x1, (int)y1);
		}


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
		private void DrawingPanel_Paint(object sender, PaintEventArgs e)
		{
			graphics = e.Graphics;
			drawCayleyTree(250, 400, leng, -Math.PI / 2, depth);
		}

		private void btnDraw_Click(object sender, EventArgs e)
        {
			tbDepth_TextCheck();
			DrawingPanel.Paint += new PaintEventHandler(this.DrawingPanel_Paint);
			DrawingPanel.Refresh();	//Forces the control to invalidate its client area and immediately redraw itself and any child controls.
		}

		private void ccbLength_SelectedIndexChanged(object sender, EventArgs e)
		{
			leng = Int32.Parse(ccbLength.Text);
		}

		private void tbDepth_TextChanged(object sender, EventArgs e)
		{
			
        }
		/// <summary>
		/// 检查depth是否合法
		/// </summary>
		private void tbDepth_TextCheck()
        {
			int inputDepth = 0;
			try
			{
				inputDepth = Int32.Parse(tbDepth.Text);
			}
			catch (FormatException)
			{
				string msg = $"Unable to parse '{tbDepth.Text}'";
				MessageBox.Show(msg, "FaultArgument", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			if (inputDepth < 0 ||inputDepth > 20)//递归深度再大就会很卡
			{
				string msg = $"Invalid depth {tbDepth.Text}!\nPlease input a value between 0 and 20.";
				MessageBox.Show(msg, "FaultArgument", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			depth = inputDepth;
		}

        private void nupPerR_ValueChanged(object sender, EventArgs e)
        {
			per1 = decimal.ToDouble(nupPerR.Value);

		}

        private void nupPerL_ValueChanged(object sender, EventArgs e)
        {
			per2 = decimal.ToDouble(nupPerL.Value);
		}

        private void nudAngleR_ValueChanged(object sender, EventArgs e)
        {
			th1 = decimal.ToDouble(nudAngleR.Value) * Math.PI / 180;

		}
		private void nudAngleL_ValueChanged(object sender, EventArgs e)
		{
			th2 = decimal.ToDouble(nudAngleL.Value) * Math.PI / 180;
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			pen = Pens.CornflowerBlue;
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			pen = Pens.OrangeRed;
		}
		private void rbtnGreen_CheckedChanged(object sender, EventArgs e)
        {
			pen = Pens.ForestGreen;
        }


    }
}
