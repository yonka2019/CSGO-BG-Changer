using System;
using System.Windows.Forms;

namespace CSGO_BG_Changer
{
    public partial class LanguageForm : Form
    {
        private readonly MainForm form = new MainForm();
        public LanguageForm()
        {
            InitializeComponent();
        }

        private void EnglishCB_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Language = "EN";
            Hide();
            form.ShowDialog();
            Close();
            Dispose();
        }

        private void RussianCB_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Language = "RU";
            Hide();
            form.ShowDialog();
            Close();
            Dispose();
        }
    }
}
