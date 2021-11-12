using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace btcinfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(254, 255, 255);
            this.TransparencyKey = Color.FromArgb(254, 255, 255);
            this.TopMost = true;
            
            // System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            // timer.Interval = 1000;
            //timer.Enabled = true;
            //timer.Tick += new EventHandler(m_Timer_Tick);
            Name1.Text = config.Default.a;
            Name2.Text = config.Default.b;
            Name3.Text = config.Default.c;
            ts.Add(config.Default.a);
            ts.Add(config.Default.b);
            ts.Add(config.Default.c);
            Thread thread = new Thread(main_data);
            thread.Start();
        }
        private List<string> ts = new List<string>();
        //去掉标题后可以移动窗口
        private Point _HoverTreePosition;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            _HoverTreePosition.X = e.X;
            _HoverTreePosition.Y = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point h_myPosittion = MousePosition;
                h_myPosittion.Offset(-_HoverTreePosition.X, -_HoverTreePosition.Y);
                Location = h_myPosittion;
            }
        }
        private void m_Timer_Tick(object O, EventArgs e)
        {
            this.TopMost = true;
            this.Activate();
        }

        private void main_data()
        {

            while (true) 
            {
                ts[0] = config.Default.a;
                ts[1] = config.Default.b;
                ts[2] = config.Default.c;
                this.Invoke(new System.Action(() =>
                {
                    Name1.Text = config.Default.a;
                    Name2.Text = config.Default.b;
                    Name3.Text = config.Default.c;
                }));
                SHOW_data();
                Thread.Sleep(1000);
            }
            
        }
        private void SHOW_data()
        {

            List<string> infolist=new List<string>();

            for (int i = 0; i < ts.Count; i++)
            { 
                string coindata=btcAPI.GETinfo(ts[i].ToString());

                if (coindata != null)
                {
                    JObject jobj = JObject.Parse(coindata);
                    // JArray jarr = (JArray)jobj["results"];
                    String jiage = jobj["price"].ToString().Split('.')[0];
                    infolist.Add(jiage);
                }
                else
                {
                    infolist.Add("null");
                }
            }
            this.Invoke(new System.Action(() =>
            {
                Info1.Text = infolist[0];
                Info2.Text = infolist[1];
                Info3.Text = infolist[2];
              }));
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          About ab=new About();
          ab.Show();
        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetInfo setInfo= new SetInfo();
            setInfo.Show();
        }
    }
}
