namespace CSGO_BG_Changer
{
    partial class LanguageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LanguageForm));
            this.EnglishCB = new System.Windows.Forms.CheckBox();
            this.RussianCB = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnglishCB
            // 
            this.EnglishCB.AutoSize = true;
            this.EnglishCB.BackColor = System.Drawing.Color.Transparent;
            this.EnglishCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnglishCB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EnglishCB.Location = new System.Drawing.Point(109, 71);
            this.EnglishCB.Name = "EnglishCB";
            this.EnglishCB.Size = new System.Drawing.Size(83, 24);
            this.EnglishCB.TabIndex = 7;
            this.EnglishCB.Text = "English";
            this.EnglishCB.UseVisualStyleBackColor = false;
            this.EnglishCB.CheckedChanged += new System.EventHandler(this.EnglishCB_CheckedChanged);
            // 
            // RussianCB
            // 
            this.RussianCB.AutoSize = true;
            this.RussianCB.BackColor = System.Drawing.Color.Transparent;
            this.RussianCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RussianCB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RussianCB.Location = new System.Drawing.Point(103, 101);
            this.RussianCB.Name = "RussianCB";
            this.RussianCB.Size = new System.Drawing.Size(94, 24);
            this.RussianCB.TabIndex = 6;
            this.RussianCB.Text = "Русский";
            this.RussianCB.UseVisualStyleBackColor = false;
            this.RussianCB.CheckedChanged += new System.EventHandler(this.RussianCB_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(68, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберите язык";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(67, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select language";
            // 
            // LanguageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(300, 140);
            this.Controls.Add(this.EnglishCB);
            this.Controls.Add(this.RussianCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LanguageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CS:GO Background Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox EnglishCB;
        private System.Windows.Forms.CheckBox RussianCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}