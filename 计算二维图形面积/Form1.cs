using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算二维图形面积
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 计算圆的面积
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>
        /// 用户在textBox1中输入圆的半径，然后点击button1，
        /// 程序取得圆的半径，经过计算得到圆的面积，
        /// 程序将面积显示在textBox2中。
        /// 
        /// 
        /// </remarks>
        private void button1_Click(object sender, EventArgs e)
        {
            const double PI = 3.1415926;
            // 数值型字符串：1, 2, 50.5
            double r = double.Parse(textBox1.Text);
            double area;
            area = r * r * PI;
            textBox2.Text = area.ToString();
        }
    }
}
