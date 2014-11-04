using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JSONDiff;

namespace JSONDiffTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JSONComparer c = new JSONComparer();
            string master = "{a:1,b:2,c:2,d:[{e:1,f:2},{e:3,f:5}]}";
            string toCompare = "{a:1,b:3,c:2,d:[{e:1,f:2},{e:3,f:5}]}";
            c.Compare<String>(master, toCompare);
        }
    }
}
