namespace BMI指数计算器
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxWt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelBMI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "您的身高（m）";
            // 
            // textBoxHt
            // 
            this.textBoxHt.Location = new System.Drawing.Point(63, 77);
            this.textBoxHt.Name = "textBoxHt";
            this.textBoxHt.Size = new System.Drawing.Size(100, 21);
            this.textBoxHt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "您的体重（kg）";
            // 
            // textBoxWt
            // 
            this.textBoxWt.Location = new System.Drawing.Point(201, 77);
            this.textBoxWt.Name = "textBoxWt";
            this.textBoxWt.Size = new System.Drawing.Size(100, 21);
            this.textBoxWt.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "计算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelResult.Location = new System.Drawing.Point(60, 208);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(88, 16);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "<计算结果>";
            // 
            // labelBMI
            // 
            this.labelBMI.AutoSize = true;
            this.labelBMI.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBMI.Location = new System.Drawing.Point(60, 176);
            this.labelBMI.Name = "labelBMI";
            this.labelBMI.Size = new System.Drawing.Size(64, 16);
            this.labelBMI.TabIndex = 3;
            this.labelBMI.Text = "<BMI值>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 257);
            this.Controls.Add(this.labelBMI);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxWt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxHt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxWt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelBMI;
    }
}

