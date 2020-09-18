using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Win32;

namespace CSGO_BG_Changer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        #region External Code (To Get CS:GO Folder)
        public void LoadCSGOFolder(bool manual = false)
        {

            if (Properties.Settings.Default.CsgoPath != "") Settings.CsgoBGFolder = Properties.Settings.Default.CsgoPath + @"\csgo\panorama\videos";
            else
            {
                string csgoPath = TryLocatingCSGOFolder();
                if (csgoPath == null || manual)
                {
                    csgoPath = Microsoft.VisualBasic.Interaction.InputBox(Settings.strings[5], Settings.strings[6], @"C:\Program Files (x86)\Steam\steamapps\common\Counter-Strike Global Offensive");
                    while (!Directory.Exists(csgoPath) && !File.Exists(csgoPath + @"\csgo.exe"))
                    {
                        if (MessageBox.Show(Settings.strings[7], Settings.strings[8],
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel) Environment.Exit(-1);
                        csgoPath = Microsoft.VisualBasic.Interaction.InputBox(Settings.strings[5], Settings.strings[6], @"C:\Program Files (x86)\Steam\steamapps\common\Counter-Strike Global Offensive");
                    }
                }

                if (MessageBox.Show(Settings.strings[9] + csgoPath + Settings.strings[10],
                        Settings.strings[11], MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Properties.Settings.Default.CsgoPath = csgoPath;
                    LoadCSGOFolder(); // Update the csgo video folder path.
                }
                else
                {
                    LoadCSGOFolder(true);
                }
            }
        }

        // https://developer.valvesoftware.com/wiki/Counter-Strike:_Global_Offensive_Game_State_Integration#Locating_CS:GO_Install_Directory
        // Improved csgo installation detection by bernieplayshd #14
        private static string TryLocatingCSGOFolder()
        {
            // Locate the Steam installation directory
            string steamDir = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Valve\Steam", "SteamPath", ""),
                   libsFile = steamDir + @"\steamapps\libraryfolders.vdf";

            Regex regex = new Regex("\"\\d+\".*\"(.*?)\"", RegexOptions.Compiled);

            List<string> libraries = new List<string> { steamDir.Replace('/', '\\') };

            // Find all Steam game libraries
            if (File.Exists(libsFile))
            {
                foreach (string line in File.ReadAllLines(libsFile))
                {
                    foreach (Match match in regex.Matches(line))
                    {
                        if (match.Success && match.Groups.Count != 0)
                        {
                            libraries.Add(match.Groups[1].Value.Replace("\\\\", "\\"));
                            break;
                        }
                    }
                }
            }

            // Search them for the CS:GO installation
            foreach (string lib in libraries)
            {
                string csgoDir = lib + @"\steamapps\common\Counter-Strike Global Offensive";
                if (Directory.Exists(csgoDir))
                {
                    return csgoDir;
                }
            }

            return null;
        }
        #endregion

        private void VLCtab_VlcLibDirectoryNeeded(object sender, Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs e)
        {
            if (IntPtr.Size == 4)
                e.VlcLibDirectory = new DirectoryInfo(Settings.VlcLib + "win-x86");
            else
                e.VlcLibDirectory = new DirectoryInfo(Settings.VlcLib + "win-x64");
        }
        private void SetTPs()
        {
            ToolTip tp = new ToolTip();
            tp.SetToolTip(FolderBGOpenB, Settings.strings[27]);
            tp.SetToolTip(UpdateButton, Settings.strings[28]);
            tp.SetToolTip(RemoveButton, Settings.strings[30]);
            tp.SetToolTip(AddButton, Settings.strings[29]);
        }

        private void MainList_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(Settings.BackgroundFolder + MainList.SelectedItem);
            if (file.Extension == ".webm")
            {
                VLCtab.Play(file);
            }
            else
                MessageBox.Show(Settings.strings[26], Settings.strings[20], MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetLang();
            SetTPs();
            LoadCSGOFolder();
            ReloadList();
        }
        private void ReloadList()
        {
            MainList.Items.Clear();
            foreach (string name in Directory.GetFiles(Settings.BackgroundFolder))
            {
                MainList.Items.Add(Path.GetFileName(name));
            }
        }

        private void SetLang()
        {
            switch (Properties.Settings.Default.Language)
            {
                case "EN":
                    Settings.SetEN();
                    break;
                case "RU":
                    Settings.SetRU();
                    break;
            }
            ApplyButton.Text = Settings.strings[0];
            label1.Text = Settings.strings[1];
            LanguageButton.Text = Settings.strings[2];
            ResetButton.Text = Settings.strings[3];
            AboutButton.Text = Settings.strings[4];
            PathButton.Text = Settings.strings[12];

        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(Settings.BackgroundFolder + MainList.SelectedItem);
            if (file.Extension == ".webm")
            {
                file.CopyTo(Settings.CsgoBGFolder + @"\NotDone.nd!", true);
                file.CopyTo(Settings.CsgoBGFolder + @"\NotDone540p.nd!", true);
                file.CopyTo(Settings.CsgoBGFolder + @"\NotDone720p.nd!", true);
                try
                {
                    File.Delete(Settings.CsgoBGFolder + @"\sirocco_night.webm");
                    File.Delete(Settings.CsgoBGFolder + @"\sirocco_night720p.webm");
                    File.Delete(Settings.CsgoBGFolder + @"\sirocco_night540p.webm");
                }
                catch { }
                VLCtab.Stop();
                File.Move(Settings.CsgoBGFolder + @"\NotDone.nd!", Settings.CsgoBGFolder + @"\sirocco_night.webm");
                File.Move(Settings.CsgoBGFolder + @"\NotDone540p.nd!", Settings.CsgoBGFolder + @"\sirocco_night540p.webm");
                File.Move(Settings.CsgoBGFolder + @"\NotDone720p.nd!", Settings.CsgoBGFolder + @"\sirocco_night720p.webm");
                MessageBox.Show("[" + file.Name + "] " + Settings.strings[19] + "\n\n" + Settings.strings[31], Settings.strings[17], MessageBoxButtons.OK, MessageBoxIcon.Information);
                VLCtab.Play();
            }
            else
                MessageBox.Show(Settings.strings[26], Settings.strings[20], MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog
            {
                Filter = $"{Settings.strings[32]} (*.webm)|*.webm",
            };
            opf.ShowDialog();
            if (opf.FileName == "")
                return;
            FileInfo file = new FileInfo(opf.FileName);
            if (!File.Exists(Settings.BackgroundFolder + @"\" + file.Name))
            {
                file.CopyTo(Settings.BackgroundFolder + @"\" + file.Name);
                MessageBox.Show("[" + file.Name + "] " + Settings.strings[16], Settings.strings[17], MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(Settings.strings[21], Settings.strings[20], MessageBoxButtons.OK, MessageBoxIcon.Error);
            ReloadList();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(Settings.strings[23], Settings.strings[25] + " [" + MainList.SelectedItem + "]", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string Item = MainList.SelectedItem.ToString();
                VLCtab.Stop();
                try
                {
                    File.Delete(Settings.BackgroundFolder + @"\" + MainList.SelectedItem);
                }
                catch
                {
                    MessageBox.Show(Settings.strings[20], Settings.strings[20], MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("[" + Item + "] " + Settings.strings[18], Settings.strings[17], MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReloadList();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void LanguageButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LanguageForm form = new LanguageForm();
            Hide();
            form.ShowDialog();
            Close();
            Dispose();
        }

        private void ResetButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show(Settings.strings[23], Settings.strings[24], MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FileInfo file = new FileInfo(Settings.BackgroundFolder + @"\Default\sirocco_night.webm");
                FileInfo file540p = new FileInfo(Settings.BackgroundFolder + @"\Default\sirocco_night540p.webm");
                FileInfo file720p = new FileInfo(Settings.BackgroundFolder + @"\Default\sirocco_night720p.webm");
                file.CopyTo(Settings.CsgoBGFolder + @"\NotDone.nd!", true);
                file540p.CopyTo(Settings.CsgoBGFolder + @"\NotDone540p.nd!", true);
                file720p.CopyTo(Settings.CsgoBGFolder + @"\NotDone720p.nd!", true);
                try
                {
                    File.Delete(Settings.CsgoBGFolder + @"\sirocco_night.webm");
                    File.Delete(Settings.CsgoBGFolder + @"\sirocco_night540p.webm");
                    File.Delete(Settings.CsgoBGFolder + @"\sirocco_night720p.webm");
                }
                catch { }
                VLCtab.Stop();
                File.Move(Settings.CsgoBGFolder + @"\NotDone.nd!", Settings.CsgoBGFolder + @"\sirocco_night.webm");
                File.Move(Settings.CsgoBGFolder + @"\NotDone540p.nd!", Settings.CsgoBGFolder + @"\sirocco_night540p.webm");
                File.Move(Settings.CsgoBGFolder + @"\NotDone720p.nd!", Settings.CsgoBGFolder + @"\sirocco_night720p.webm");
                MessageBox.Show(Settings.strings[22], Settings.strings[17], MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AboutButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(Settings.strings[15], Settings.strings[4], MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PathButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CSGO_Path form = new CSGO_Path();
            form.ShowDialog();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ReloadList();
        }

        private void FolderBGOpenB_Click(object sender, EventArgs e)
        {
            OpenFile(Settings.BackgroundFolder);
        }
        private void OpenFile(string folderPath)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                Arguments = folderPath,
                FileName = "explorer.exe"
            };
            Process.Start(startInfo);
        }
    }
}
