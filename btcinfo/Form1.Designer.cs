
namespace btcinfo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Name1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Name2 = new System.Windows.Forms.Label();
            this.Name3 = new System.Windows.Forms.Label();
            this.Info1 = new System.Windows.Forms.Label();
            this.Info2 = new System.Windows.Forms.Label();
            this.Info3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Name1
            // 
            this.Name1.AutoSize = true;
            this.Name1.BackColor = System.Drawing.Color.Transparent;
            this.Name1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Name1.Location = new System.Drawing.Point(21, 43);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(54, 12);
            this.Name1.TabIndex = 0;
            this.Name1.Text = "ETHUSDT";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "狗蛋";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem,
            this.关于ToolStripMenuItem,
            this.退出ToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 70);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.设置ToolStripMenuItem.Text = "设置";
            this.设置ToolStripMenuItem.Click += new System.EventHandler(this.设置ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem1
            // 
            this.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1";
            this.退出ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem1.Text = "退出";
            this.退出ToolStripMenuItem1.Click += new System.EventHandler(this.退出ToolStripMenuItem1_Click);
            // 
            // Name2
            // 
            this.Name2.AutoSize = true;
            this.Name2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Name2.Location = new System.Drawing.Point(21, 70);
            this.Name2.Name = "Name2";
            this.Name2.Size = new System.Drawing.Size(54, 12);
            this.Name2.TabIndex = 1;
            this.Name2.Text = "ENSUSDT";
            // 
            // Name3
            // 
            this.Name3.AutoSize = true;
            this.Name3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Name3.Location = new System.Drawing.Point(21, 97);
            this.Name3.Name = "Name3";
            this.Name3.Size = new System.Drawing.Size(54, 12);
            this.Name3.TabIndex = 2;
            this.Name3.Text = "BTCUSDT";
            // 
            // Info1
            // 
            this.Info1.AutoSize = true;
            this.Info1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Info1.ForeColor = System.Drawing.Color.LimeGreen;
            this.Info1.Location = new System.Drawing.Point(81, 39);
            this.Info1.Name = "Info1";
            this.Info1.Size = new System.Drawing.Size(39, 16);
            this.Info1.TabIndex = 3;
            this.Info1.Text = "null";
            // 
            // Info2
            // 
            this.Info2.AutoSize = true;
            this.Info2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Info2.ForeColor = System.Drawing.Color.LimeGreen;
            this.Info2.Location = new System.Drawing.Point(81, 66);
            this.Info2.Name = "Info2";
            this.Info2.Size = new System.Drawing.Size(39, 16);
            this.Info2.TabIndex = 4;
            this.Info2.Text = "null";
            // 
            // Info3
            // 
            this.Info3.AutoSize = true;
            this.Info3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Info3.ForeColor = System.Drawing.Color.LimeGreen;
            this.Info3.Location = new System.Drawing.Point(81, 93);
            this.Info3.Name = "Info3";
            this.Info3.Size = new System.Drawing.Size(39, 16);
            this.Info3.TabIndex = 5;
            this.Info3.Text = "null";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(143, 139);
            this.Controls.Add(this.Info3);
            this.Controls.Add(this.Info2);
            this.Controls.Add(this.Info1);
            this.Controls.Add(this.Name3);
            this.Controls.Add(this.Name2);
            this.Controls.Add(this.Name1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label Name2;
        private System.Windows.Forms.Label Name3;
        private System.Windows.Forms.Label Info1;
        private System.Windows.Forms.Label Info2;
        private System.Windows.Forms.Label Info3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem1;
    }
}

