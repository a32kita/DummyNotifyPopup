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

            this.mainNotifyIcon.Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location); ;
            this.mainNotifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            
            this.mainTimer.Start();
        }


        public void NotifyMessage(string message, int duration)
        {
            this.mainNotifyIcon.BalloonTipText = message;
            this.mainNotifyIcon.ShowBalloonTip(duration);
        }
    }
}
