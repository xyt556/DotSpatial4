namespace DotSpatial4
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox myaboutbox = new AboutBox();
            myaboutbox.ShowDialog();
        }
    }
}