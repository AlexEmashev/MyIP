namespace MyIP
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelWebPage = new System.Windows.Forms.Label();
            this.textBoxWebResourse = new System.Windows.Forms.TextBox();
            this.labelNotion = new System.Windows.Forms.Label();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.comboBoxLanguages = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(121, 135);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "Save";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelWebPage
            // 
            this.labelWebPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWebPage.AutoSize = true;
            this.labelWebPage.Location = new System.Drawing.Point(12, 46);
            this.labelWebPage.Name = "labelWebPage";
            this.labelWebPage.Size = new System.Drawing.Size(95, 13);
            this.labelWebPage.TabIndex = 1;
            this.labelWebPage.Text = "Web-page with IP:";
            this.labelWebPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxWebResourse
            // 
            this.textBoxWebResourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWebResourse.Location = new System.Drawing.Point(123, 43);
            this.textBoxWebResourse.Name = "textBoxWebResourse";
            this.textBoxWebResourse.Size = new System.Drawing.Size(182, 20);
            this.textBoxWebResourse.TabIndex = 2;
            // 
            // labelNotion
            // 
            this.labelNotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNotion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelNotion.Location = new System.Drawing.Point(10, 66);
            this.labelNotion.Name = "labelNotion";
            this.labelNotion.Size = new System.Drawing.Size(285, 66);
            this.labelNotion.TabIndex = 3;
            this.labelNotion.Text = resources.GetString("labelNotion.Text");
            // 
            // labelLanguage
            // 
            this.labelLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Location = new System.Drawing.Point(49, 12);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(58, 13);
            this.labelLanguage.TabIndex = 5;
            this.labelLanguage.Text = "Language:";
            this.labelLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxLanguages
            // 
            this.comboBoxLanguages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguages.FormattingEnabled = true;
            this.comboBoxLanguages.Location = new System.Drawing.Point(122, 9);
            this.comboBoxLanguages.Name = "comboBoxLanguages";
            this.comboBoxLanguages.Size = new System.Drawing.Size(183, 21);
            this.comboBoxLanguages.Sorted = true;
            this.comboBoxLanguages.TabIndex = 6;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(317, 173);
            this.Controls.Add(this.comboBoxLanguages);
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.labelNotion);
            this.Controls.Add(this.textBoxWebResourse);
            this.Controls.Add(this.labelWebPage);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Settings";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormSettings_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelWebPage;
        private System.Windows.Forms.TextBox textBoxWebResourse;
        private System.Windows.Forms.Label labelNotion;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.ComboBox comboBoxLanguages;
    }
}