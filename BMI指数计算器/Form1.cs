using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI指数计算器
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
        /// 1，获取用户输入的身高和体重信息
        /// 2，计算bmi值
        /// 3，对bmi值做判定，并将判定结果显示给用户
        /// </remarks>
        private void button1_Click(object sender, EventArgs e)
        {
            float ht;   // 身高（m）
            float wt;   // 体重（kg）
            float bmi;  // bmi值

            if (string.IsNullOrWhiteSpace(textBoxHt.Text))
            {
                labelResult.Text = "您未输入身高！";
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxWt.Text))
            {
                labelResult.Text = "您未输入体重！";
                return;
            }

            if (!float.TryParse(textBoxHt.Text, out ht))
            {
                labelResult.Text = "您未正确输入身高！";
                return;
            }

            if (!float.TryParse(textBoxWt.Text, out wt))
            {
                labelResult.Text = "您未正确输入体重！";
                return;
            }

            if (ht <= 0 || ht > 3)
            {
                labelResult.Text = "您输入的身高范围不符合要求！";
                return;
            }

            if (wt <= 0 || wt > 1000)
            {
                labelResult.Text = "您输入的体重范围不符合要求！";
                return;
            }

            bmi = wt / (ht * ht);

            labelBMI.Text = bmi.ToString();
            if (bmi > 24)
            {
                labelResult.Text = "您的体重过重！";
            }
            else if (bmi < 18.5)
            {
                labelResult.Text = "您的体重过轻！";
            }
            else
            {
                labelResult.Text = "您的体重正常！";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelBMI.Text = "";
            labelResult.Text = "请输入您的身高和体重";
        }
    }
}
