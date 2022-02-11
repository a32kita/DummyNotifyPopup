using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNPopup
{
    public partial class BaseForm : Form
    {
        public event EventHandler TimerRinging
        {
            add => this.mainTimer.Tick += value;
            remove => this.mainTimer.Tick -= value;
        }


        public BaseForm()
        {
            InitializeComponent();

            this.ClientSize = new Size(0, 0);
            this.WindowState = FormWindowState.Minimized;

            this.mainNotifyIcon.Icon = Properties.Resources.AppIcon;
            this.mainNotifyIcon.Text = "Messenger";
            this.mainNotifyIcon.BalloonTipTitle = "新着メッセージ";
            this.mainNotifyIcon.BalloonTipIcon = ToolTipIcon.None;
            
            this.mainTimer.Start();
        }


        public void NotifyMessage(string message, int duration)
        {
            this.mainNotifyIcon.BalloonTipText = message;
            this.mainNotifyIcon.ShowBalloonTip(duration);
        }

        private void exitCommandMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("終了してもよろしいですか？", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;

            Environment.Exit(0);
        }
    }
}
