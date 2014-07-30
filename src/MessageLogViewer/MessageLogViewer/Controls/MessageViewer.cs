using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageLogViewer.UI.Controls
{
    public partial class MessageViewer : UserControl
    {
        public MessageViewer()
        {
            InitializeComponent();
        }

        private void copyStackTraceButton_Click(object sender, EventArgs e)
        {
            stackTraceTextBox.SelectAll();
            stackTraceTextBox.Copy();
        }

        private void copyMessageButton_Click(object sender, EventArgs e)
        {
            messageTextBox.SelectAll();
            messageTextBox.Copy();
        }

        private void copyAllButton_Click(object sender, EventArgs e)
        {
            hidden.Text = this.messageLogEntryBindingSource.Current.ToString();
            hidden.SelectAll();
            hidden.Copy();
        }
    }
}
