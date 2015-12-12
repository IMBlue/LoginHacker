namespace LoginHacker
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Label3 = new System.Windows.Forms.Label();
            this.DIC = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.LOG = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.KEY = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.URL = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.FLAG = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(17, 80);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(25, 13);
            this.Label3.TabIndex = 15;
            this.Label3.Text = "DIC";
            // 
            // DIC
            // 
            this.DIC.Location = new System.Drawing.Point(51, 77);
            this.DIC.Name = "DIC";
            this.DIC.Size = new System.Drawing.Size(215, 20);
            this.DIC.TabIndex = 14;
            this.DIC.TextChanged += new System.EventHandler(this.DIC_TextChanged);
            this.DIC.DoubleClick += new System.EventHandler(this.TextBox4_DoubleClick);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(197, 223);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 13;
            this.Button1.Text = "Start";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // LOG
            // 
            this.LOG.Location = new System.Drawing.Point(24, 131);
            this.LOG.Multiline = true;
            this.LOG.Name = "LOG";
            this.LOG.Size = new System.Drawing.Size(248, 86);
            this.LOG.TabIndex = 12;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(16, 54);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(28, 13);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "KEY";
            // 
            // KEY
            // 
            this.KEY.Location = new System.Drawing.Point(51, 51);
            this.KEY.Name = "KEY";
            this.KEY.Size = new System.Drawing.Size(215, 20);
            this.KEY.TabIndex = 10;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(16, 28);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(29, 13);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "URL";
            // 
            // URL
            // 
            this.URL.Location = new System.Drawing.Point(51, 25);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(215, 20);
            this.URL.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "FLAG";
            // 
            // FLAG
            // 
            this.FLAG.Location = new System.Drawing.Point(51, 103);
            this.FLAG.Name = "FLAG";
            this.FLAG.Size = new System.Drawing.Size(215, 20);
            this.FLAG.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FLAG);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.DIC);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.LOG);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.KEY);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.URL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginHacker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox DIC;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox LOG;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox KEY;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox FLAG;
    }
}

