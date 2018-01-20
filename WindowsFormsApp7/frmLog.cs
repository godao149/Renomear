using System;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class frmLog : Form
    {
        public frmLog()
        {
            InitializeComponent();
        }
        
        public frmLog(string log)
        {
            InitializeComponent();
            richLog.Text = log.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLog_Load(object sender, EventArgs e)
        {

        }
    }
}
