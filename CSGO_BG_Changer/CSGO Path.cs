using System;
using System.Windows.Forms;

namespace CSGO_BG_Changer
{
    public partial class CSGO_Path : Form
    {
        public CSGO_Path()
        {
            InitializeComponent();
        }

        private void CSGO_Path_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            PathBox.Text = Properties.Settings.Default.CsgoPath;
            toolTip1.SetToolTip(PathBox, PathBox.Text);
            label1.Text = Settings.strings[13];
            ChangePathButton.Text = Settings.strings[14];
        }

        private void ChangePathButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CsgoPath = "";
            MainForm form = new MainForm();
            form.LoadCSGOFolder();
            PathBox.Text = Properties.Settings.Default.CsgoPath;
        }
    }
}
