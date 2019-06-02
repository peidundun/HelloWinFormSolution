using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 数字累加
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 计算按钮点击事件处理程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>
        /// 1，获取用户输入的起始值和终止值
        /// 2，计算
        /// 3，显示结果
        /// </remarks>
        private void button1_Click(object sender, EventArgs e)
        {
            int a; // 起始值
            int b; // 终止值
            int sum;    // 计算结果

            if (!int.TryParse(textBox1.Text, out a))
            {
                labelResult.Text = "您输入的起始值不正确！";
                return;
            }

            if (!int.TryParse(textBox2.Text, out b))
            {
                labelResult.Text = "您输入的终止值不正确！";
                return;
            }

            if (a >= b)
            {
                labelResult.Text = "您的输入不符合要求（起始值应当小于终止值）！";
                return;
            }

            sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum = sum + i;
            }

            labelResult.Text = sum.ToString();

        }
    }
}
