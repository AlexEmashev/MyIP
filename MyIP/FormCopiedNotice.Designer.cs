namespace MyIP
{
    partial class FormCopiedNotice
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
            this.components = new System.ComponentModel.Container();
            this.labelCopied = new System.Windows.Forms.Label();
            this.timerFadeInOut = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelCopied
            // 
            this.labelCopied.AutoSize = true;
            this.labelCopied.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCopied.ForeColor = System.Drawing.Color.White;
            this.labelCopied.Location = new System.Drawing.Point(2, 2);
            this.labelCopied.Name = "labelCopied";
            this.labelCopied.Size = new System.Drawing.Size(59, 18);
            this.labelCopied.TabIndex = 0;
            this.labelCopied.Text = "Copied.";
            // 
            // timerFadeInOut
            // 
            this.timerFadeInOut.Enabled = true;
            this.timerFadeInOut.Interval = 10;
            this.timerFadeInOut.Tick += new System.EventHandler(this.timerFadeInOut_Tick);
            // 
            // FormCopiedNotice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(35)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(52, 23);
            this.Controls.Add(this.labelCopied);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCopiedNotice";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormCopiedNotice";
            this.Shown += new System.EventHandler(this.FormCopiedNotice_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCopied;
        private System.Windows.Forms.Timer timerFadeInOut;
    }
}