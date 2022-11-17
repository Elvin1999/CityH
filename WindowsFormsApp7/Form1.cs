using System;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public bool IsBaku { get; set; } = true;
        Timer _timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            _timer.Interval = 1000;
            _timer.Tick += _timer_Tick;
            _timer.Start();
        }
        private void _timer_Tick(object sender, EventArgs e)
        {
            if (IsBaku)
            {
                label1.Text = DateTime.Now.ToLongTimeString();
            }
            else
            {
                label1.Text = DateTime.Now.AddHours(-4).ToLongTimeString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            IsBaku = true;
            this.BackgroundImage = Properties.Resources.baku;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IsBaku = false;
            this.BackgroundImage = Properties.Resources.london;
        }
    }
}