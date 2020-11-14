using GUI.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {

        int width;

        public MainForm()
        {
            InitializeComponent();
        }

        //减少闪烁
        private void SetStyles()
        {
            base.SetStyle(
              ControlStyles.UserPaint |
              ControlStyles.AllPaintingInWmPaint |
              ControlStyles.OptimizedDoubleBuffer |
              ControlStyles.ResizeRedraw |
              ControlStyles.DoubleBuffer, true);
            base.UpdateStyles();
            base.AutoScaleMode = AutoScaleMode.None;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1(); //实例化一个子窗口
            frm1.TopLevel = false;//设置子窗口不显示为顶级窗口
            frm1.Dock = DockStyle.Fill;//填充            
            this.panel1.Controls.Clear();//清空Panel里面的控件
            this.panel1.Controls.Add(frm1);//加入控件
            frm1.Show();//让窗体显示
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(); //实例化一个子窗口
            frm2.TopLevel = false;//设置子窗口不显示为顶级窗口
            frm2.Dock = DockStyle.Fill;//填充            
            this.panel1.Controls.Clear();//清空Panel里面的控件
            this.panel1.Controls.Add(frm2);//加入控件
            frm2.Show();//让窗体显示
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(); //实例化一个子窗口
            frm3.TopLevel = false;//设置子窗口不显示为顶级窗口
            frm3.Dock = DockStyle.Fill;//填充            
            this.panel1.Controls.Clear();//清空Panel里面的控件
            this.panel1.Controls.Add(frm3);//加入控件
            frm3.Show();//让窗体显示
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4(); //实例化一个子窗口
            frm4.TopLevel = false;//设置子窗口不显示为顶级窗口
            frm4.Dock = DockStyle.Fill;//填充            
            this.panel1.Controls.Clear();//清空Panel里面的控件
            this.panel1.Controls.Add(frm4);//加入控件
            frm4.Show();//让窗体显示
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5(); //实例化一个子窗口
            frm5.TopLevel = false;//设置子窗口不显示为顶级窗口
            frm5.Dock = DockStyle.Fill;//填充            
            this.panel1.Controls.Clear();//清空Panel里面的控件
            this.panel1.Controls.Add(frm5);//加入控件
            frm5.Show();//让窗体显示
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6(); //实例化一个子窗口
            frm6.TopLevel = false;//设置子窗口不显示为顶级窗口
            frm6.Dock = DockStyle.Fill;//填充            
            this.panel1.Controls.Clear();//清空Panel里面的控件
            this.panel1.Controls.Add(frm6);//加入控件
            frm6.Show();//让窗体显示
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7(); //实例化一个子窗口
            frm7.TopLevel = false;//设置子窗口不显示为顶级窗口
            frm7.Dock = DockStyle.Fill;//填充            
            this.panel1.Controls.Clear();//清空Panel里面的控件
            this.panel1.Controls.Add(frm7);//加入控件
            frm7.Show();//让窗体显示
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8(); //实例化一个子窗口
            frm8.TopLevel = false;//设置子窗口不显示为顶级窗口
            frm8.Dock = DockStyle.Fill;//填充            
            this.panel1.Controls.Clear();//清空Panel里面的控件
            this.panel1.Controls.Add(frm8);//加入控件
            frm8.Show();//让窗体显示
        }
    }
}
