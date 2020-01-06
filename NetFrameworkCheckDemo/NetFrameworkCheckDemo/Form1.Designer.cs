namespace NetFrameworkCheckDemo
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
            this.tbMsg = new System.Windows.Forms.TextBox();
            this.btncheck = new System.Windows.Forms.Button();
            this.btntest1 = new System.Windows.Forms.Button();
            this.btntest2 = new System.Windows.Forms.Button();
            this.btntest3 = new System.Windows.Forms.Button();
            this.btntest4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMsg
            // 
            this.tbMsg.Location = new System.Drawing.Point(32, 12);
            this.tbMsg.Multiline = true;
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.Size = new System.Drawing.Size(729, 289);
            this.tbMsg.TabIndex = 0;
            // 
            // btncheck
            // 
            this.btncheck.Location = new System.Drawing.Point(32, 307);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(211, 36);
            this.btncheck.TabIndex = 2;
            this.btncheck.Text = "检测DotnetFramework";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.btn20_Click);
            // 
            // btntest1
            // 
            this.btntest1.Location = new System.Drawing.Point(361, 307);
            this.btntest1.Name = "btntest1";
            this.btntest1.Size = new System.Drawing.Size(140, 36);
            this.btntest1.TabIndex = 3;
            this.btntest1.Text = "调用静态方法";
            this.btntest1.UseVisualStyleBackColor = true;
            this.btntest1.Click += new System.EventHandler(this.btntest1_Click);
            // 
            // btntest2
            // 
            this.btntest2.Location = new System.Drawing.Point(361, 349);
            this.btntest2.Name = "btntest2";
            this.btntest2.Size = new System.Drawing.Size(140, 36);
            this.btntest2.TabIndex = 4;
            this.btntest2.Text = "调用void方法";
            this.btntest2.UseVisualStyleBackColor = true;
            this.btntest2.Click += new System.EventHandler(this.btntest2_Click);
            // 
            // btntest3
            // 
            this.btntest3.Location = new System.Drawing.Point(571, 307);
            this.btntest3.Name = "btntest3";
            this.btntest3.Size = new System.Drawing.Size(151, 36);
            this.btntest3.TabIndex = 5;
            this.btntest3.Text = "调用无参数方法";
            this.btntest3.UseVisualStyleBackColor = true;
            this.btntest3.Click += new System.EventHandler(this.btntest3_Click);
            // 
            // btntest4
            // 
            this.btntest4.Location = new System.Drawing.Point(571, 349);
            this.btntest4.Name = "btntest4";
            this.btntest4.Size = new System.Drawing.Size(151, 36);
            this.btntest4.TabIndex = 6;
            this.btntest4.Text = "调用多参数方法";
            this.btntest4.UseVisualStyleBackColor = true;
            this.btntest4.Click += new System.EventHandler(this.btntest4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntest4);
            this.Controls.Add(this.btntest3);
            this.Controls.Add(this.btntest2);
            this.Controls.Add(this.btntest1);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.tbMsg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMsg;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Button btntest1;
        private System.Windows.Forms.Button btntest2;
        private System.Windows.Forms.Button btntest3;
        private System.Windows.Forms.Button btntest4;
    }
}

