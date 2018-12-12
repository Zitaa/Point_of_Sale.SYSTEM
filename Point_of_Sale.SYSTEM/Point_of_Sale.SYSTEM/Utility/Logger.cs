using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_of_Sale.SYSTEM.Utility
{
    public static class Logger
    {
        public static void Log(RichTextBox display, string message)
        {
            display.Text += string.Format("[{0}] {1}{2}", DateTime.UtcNow, message, Environment.NewLine);
        }

        public static void Log(RichTextBox display, string message, bool clean)
        {
            if (!clean) Log(display, message);
            else { display.Text = string.Format("[{0}] {1}{2}", DateTime.UtcNow, message, Environment.NewLine); }
        }
    }
}
