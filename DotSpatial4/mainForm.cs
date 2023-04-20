using System.Windows.Forms;

namespace DotSpatial4
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void ¹ØÓÚToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox myaboutbox = new AboutBox();
            myaboutbox.ShowDialog();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

    }
}
