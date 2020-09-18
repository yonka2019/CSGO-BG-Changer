namespace CSGO_BG_Changer
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainList = new System.Windows.Forms.ListBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.LinkLabel();
            this.AboutButton = new System.Windows.Forms.LinkLabel();
            this.LanguageButton = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.PathButton = new System.Windows.Forms.LinkLabel();
            this.FolderBGOpenB = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.VLCtab = new Vlc.DotNet.Forms.VlcControl();
            ((System.ComponentModel.ISupportInitialize)(this.VLCtab)).BeginInit();
            this.SuspendLayout();
            // 
            // MainList
            // 
            this.MainList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(235)))), ((int)(((byte)(244)))));
            this.MainList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.MainList.FormattingEnabled = true;
            this.MainList.HorizontalScrollbar = true;
            this.MainList.ItemHeight = 25;
            this.MainList.Location = new System.Drawing.Point(629, 25);
            this.MainList.Name = "MainList";
            this.MainList.Size = new System.Drawing.Size(320, 329);
            this.MainList.TabIndex = 0;
            this.MainList.SelectedIndexChanged += new System.EventHandler(this.MainList_SelectedIndexChanged);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ApplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ApplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyButton.Location = new System.Drawing.Point(689, 366);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(218, 41);
            this.ApplyButton.TabIndex = 11;
            this.ApplyButton.Text = "Apply Selected Background";
            this.ApplyButton.UseVisualStyleBackColor = false;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(255)))), ((int)(((byte)(3)))));
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.LinkColor = System.Drawing.Color.MediumSpringGreen;
            this.ResetButton.Location = new System.Drawing.Point(118, 384);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(96, 13);
            this.ResetButton.TabIndex = 22;
            this.ResetButton.TabStop = true;
            this.ResetButton.Text = "Reset Background";
            this.ResetButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ResetButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ResetButton_LinkClicked);
            // 
            // AboutButton
            // 
            this.AboutButton.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(255)))), ((int)(((byte)(3)))));
            this.AboutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AboutButton.LinkColor = System.Drawing.Color.MediumSpringGreen;
            this.AboutButton.Location = new System.Drawing.Point(12, 384);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(70, 13);
            this.AboutButton.TabIndex = 21;
            this.AboutButton.TabStop = true;
            this.AboutButton.Text = "Info";
            this.AboutButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AboutButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AboutButton_LinkClicked);
            // 
            // LanguageButton
            // 
            this.LanguageButton.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(255)))), ((int)(((byte)(3)))));
            this.LanguageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LanguageButton.LinkColor = System.Drawing.Color.MediumSpringGreen;
            this.LanguageButton.Location = new System.Drawing.Point(250, 384);
            this.LanguageButton.Name = "LanguageButton";
            this.LanguageButton.Size = new System.Drawing.Size(55, 13);
            this.LanguageButton.TabIndex = 24;
            this.LanguageButton.TabStop = true;
            this.LanguageButton.Text = "Language";
            this.LanguageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LanguageButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LanguageButton_LinkClicked);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Location = new System.Drawing.Point(637, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "Select background from the list below";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PathButton
            // 
            this.PathButton.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(255)))), ((int)(((byte)(3)))));
            this.PathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PathButton.LinkColor = System.Drawing.Color.MediumSpringGreen;
            this.PathButton.Location = new System.Drawing.Point(341, 384);
            this.PathButton.Name = "PathButton";
            this.PathButton.Size = new System.Drawing.Size(146, 13);
            this.PathButton.TabIndex = 29;
            this.PathButton.TabStop = true;
            this.PathButton.Text = "CS:GO Path";
            this.PathButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PathButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PathButton_LinkClicked);
            // 
            // FolderBGOpenB
            // 
            this.FolderBGOpenB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderBGOpenB.BackColor = System.Drawing.Color.Transparent;
            this.FolderBGOpenB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FolderBGOpenB.FlatAppearance.BorderSize = 0;
            this.FolderBGOpenB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FolderBGOpenB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FolderBGOpenB.Image = global::CSGO_BG_Changer.Properties.Resources.file_explorer_34px;
            this.FolderBGOpenB.Location = new System.Drawing.Point(517, 368);
            this.FolderBGOpenB.Name = "FolderBGOpenB";
            this.FolderBGOpenB.Size = new System.Drawing.Size(34, 32);
            this.FolderBGOpenB.TabIndex = 31;
            this.FolderBGOpenB.UseVisualStyleBackColor = false;
            this.FolderBGOpenB.Click += new System.EventHandler(this.FolderBGOpenB_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateButton.BackColor = System.Drawing.Color.Transparent;
            this.UpdateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UpdateButton.FlatAppearance.BorderSize = 0;
            this.UpdateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Image = global::CSGO_BG_Changer.Properties.Resources.update_left_rotation_34px;
            this.UpdateButton.Location = new System.Drawing.Point(582, 368);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(34, 32);
            this.UpdateButton.TabIndex = 30;
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Image = global::CSGO_BG_Changer.Properties.Resources.add_icon;
            this.AddButton.Location = new System.Drawing.Point(916, 375);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(22, 22);
            this.AddButton.TabIndex = 27;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.BackColor = System.Drawing.Color.Transparent;
            this.RemoveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemoveButton.FlatAppearance.BorderSize = 0;
            this.RemoveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Image = global::CSGO_BG_Changer.Properties.Resources.delete_icon;
            this.RemoveButton.Location = new System.Drawing.Point(658, 375);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(22, 22);
            this.RemoveButton.TabIndex = 26;
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // VLCtab
            // 
            this.VLCtab.BackColor = System.Drawing.Color.Black;
            this.VLCtab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VLCtab.BackgroundImage")));
            this.VLCtab.Location = new System.Drawing.Point(-1, -1);
            this.VLCtab.Name = "VLCtab";
            this.VLCtab.Size = new System.Drawing.Size(631, 355);
            this.VLCtab.Spu = -1;
            this.VLCtab.TabIndex = 1;
            this.VLCtab.Text = "vlcControl1";
            this.VLCtab.VlcLibDirectory = null;
            this.VLCtab.VlcMediaplayerOptions = null;
            this.VLCtab.VlcLibDirectoryNeeded += new System.EventHandler<Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs>(this.VLCtab_VlcLibDirectoryNeeded);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(949, 417);
            this.Controls.Add(this.FolderBGOpenB);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.PathButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.VLCtab);
            this.Controls.Add(this.MainList);
            this.Controls.Add(this.LanguageButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CS:GO Background Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VLCtab)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox MainList;
        private Vlc.DotNet.Forms.VlcControl VLCtab;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.LinkLabel ResetButton;
        private System.Windows.Forms.LinkLabel AboutButton;
        private System.Windows.Forms.LinkLabel LanguageButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel PathButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button FolderBGOpenB;
    }
}

