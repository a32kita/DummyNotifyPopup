using System;
using System.Collections.Generic;
using System.IO;
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
            var scheduledMessages = LoadScheduledMessages();

            var baseForm = new BaseForm();
            baseForm.TimerRinging += (sender, e) => {
                var targetMessages = scheduledMessages.Where(m => m.ReservationTime <= DateTimeOffset.Now);

                foreach (var message in targetMessages)
                    baseForm.NotifyMessage(message.Message, 3000);

                scheduledMessages.RemoveAll(m => targetMessages.Contains(m));
            };

            Application.Run(baseForm);
        }

        static List<ScheduledMessage> LoadScheduledMessages()
        {
            var asmPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var defFile = Path.Combine(Path.GetDirectoryName(asmPath), "ScheduledMessages.txt");
            var loadedMessages = new List<ScheduledMessage>();

            try
            {
                using (var sr = new StreamReader(defFile, Encoding.UTF8))
                {
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine().Trim().Split(',');
                        if (String.IsNullOrEmpty(line[0]) || line[0][0] == '#')
                            continue;

                        var sec = Int32.Parse(line[0].Trim());
                        var text = String.Join(",", line.Skip(1)).Trim();
                        loadedMessages.Add(new ScheduledMessage(text, DateTimeOffset.Now + TimeSpan.FromSeconds(sec)));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.GetType().Name}\n\n{ex.Message}", Path.GetFileName(asmPath), MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }

            return loadedMessages;
        }
    }
}
