using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNPopup
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var scheduledMessages = new List<ScheduledMessage>();
            scheduledMessages.Add(new ScheduledMessage("＼( 'ω')／ウオオオオオオアアアアーーーーッッッ！！！！", DateTimeOffset.Now + TimeSpan.FromSeconds(5)));

            var baseForm = new BaseForm();
            baseForm.TimerRinging += (sender, e) => {
                var targetMessages = scheduledMessages.Where(m => m.ReservationTime <= DateTimeOffset.Now);

                foreach (var message in targetMessages)
                    baseForm.NotifyMessage(message.Message, 3000);

                scheduledMessages.RemoveAll(m => targetMessages.Contains(m));
            };

            Application.Run(baseForm);
        }
    }
}
