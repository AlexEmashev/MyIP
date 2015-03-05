namespace MyIP
{
    partial class FormMyIP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMyIP));
            this.dataGridViewInternalIPs = new System.Windows.Forms.DataGridView();
            this.ColumnIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.dataGridViewExternalIP = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelInternalIPs = new System.Windows.Forms.Label();
            this.labelExternalIP = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timerObtainingIPAnimation = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInternalIPs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExternalIP)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInternalIPs
            // 
            this.dataGridViewInternalIPs.AllowUserToAddRows = false;
            this.dataGridViewInternalIPs.AllowUserToDeleteRows = false;
            this.dataGridViewInternalIPs.AllowUserToResizeColumns = false;
            this.dataGridViewInternalIPs.AllowUserToResizeRows = false;
            this.dataGridViewInternalIPs.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewInternalIPs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewInternalIPs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInternalIPs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewInternalIPs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInternalIPs.ColumnHeadersVisible = false;
            this.dataGridViewInternalIPs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIP});
            this.dataGridViewInternalIPs.Location = new System.Drawing.Point(17, 76);
            this.dataGridViewInternalIPs.MultiSelect = false;
            this.dataGridViewInternalIPs.Name = "dataGridViewInternalIPs";
            this.dataGridViewInternalIPs.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInternalIPs.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewInternalIPs.RowHeadersVisible = false;
            this.dataGridViewInternalIPs.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewInternalIPs.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Linen;
            this.dataGridViewInternalIPs.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewInternalIPs.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.dataGridViewInternalIPs.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            this.dataGridViewInternalIPs.RowTemplate.Height = 25;
            this.dataGridViewInternalIPs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInternalIPs.ShowEditingIcon = false;
            this.dataGridViewInternalIPs.Size = new System.Drawing.Size(307, 126);
            this.dataGridViewInternalIPs.TabIndex = 0;
            this.dataGridViewInternalIPs.Enter += new System.EventHandler(this.dataGridViewInternalIPs_Enter);
            // 
            // ColumnIP
            // 
            this.ColumnIP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnIP.HeaderText = "IP";
            this.ColumnIP.Name = "ColumnIP";
            this.ColumnIP.ReadOnly = true;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Image = global::MyIP.Properties.Resources.CopyToClipboard;
            this.buttonCopy.Location = new System.Drawing.Point(342, 67);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(61, 38);
            this.buttonCopy.TabIndex = 1;
            this.toolTip.SetToolTip(this.buttonCopy, "Copy selected IP to clipboard.");
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Image = global::MyIP.Properties.Resources.Refresh;
            this.buttonRefresh.Location = new System.Drawing.Point(342, 21);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(61, 38);
            this.buttonRefresh.TabIndex = 2;
            this.toolTip.SetToolTip(this.buttonRefresh, "Refresh IP data.");
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Image = global::MyIP.Properties.Resources.Settings;
            this.buttonSettings.Location = new System.Drawing.Point(342, 113);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(61, 38);
            this.buttonSettings.TabIndex = 3;
            this.toolTip.SetToolTip(this.buttonSettings, "Show settings dialog.");
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(342, 176);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(61, 26);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.toolTip.SetToolTip(this.buttonClose, "Close the application.");
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dataGridViewExternalIP
            // 
            this.dataGridViewExternalIP.AllowUserToAddRows = false;
            this.dataGridViewExternalIP.AllowUserToDeleteRows = false;
            this.dataGridViewExternalIP.AllowUserToResizeColumns = false;
            this.dataGridViewExternalIP.AllowUserToResizeRows = false;
            this.dataGridViewExternalIP.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewExternalIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewExternalIP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewExternalIP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewExternalIP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExternalIP.ColumnHeadersVisible = false;
            this.dataGridViewExternalIP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridViewExternalIP.Location = new System.Drawing.Point(17, 21);
            this.dataGridViewExternalIP.Name = "dataGridViewExternalIP";
            this.dataGridViewExternalIP.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewExternalIP.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewExternalIP.RowHeadersVisible = false;
            this.dataGridViewExternalIP.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewExternalIP.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.PapayaWhip;
            this.dataGridViewExternalIP.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewExternalIP.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.dataGridViewExternalIP.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            this.dataGridViewExternalIP.RowTemplate.Height = 25;
            this.dataGridViewExternalIP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExternalIP.ShowEditingIcon = false;
            this.dataGridViewExternalIP.Size = new System.Drawing.Size(307, 25);
            this.dataGridViewExternalIP.TabIndex = 5;
            this.dataGridViewExternalIP.Enter += new System.EventHandler(this.dataGridViewExternalIP_Enter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "IP";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // labelInternalIPs
            // 
            this.labelInternalIPs.AutoSize = true;
            this.labelInternalIPs.Location = new System.Drawing.Point(14, 60);
            this.labelInternalIPs.Name = "labelInternalIPs";
            this.labelInternalIPs.Size = new System.Drawing.Size(63, 13);
            this.labelInternalIPs.TabIndex = 6;
            this.labelInternalIPs.Text = "Internal IPs:";
            // 
            // labelExternalIP
            // 
            this.labelExternalIP.AutoSize = true;
            this.labelExternalIP.Location = new System.Drawing.Point(14, 5);
            this.labelExternalIP.Name = "labelExternalIP";
            this.labelExternalIP.Size = new System.Drawing.Size(61, 13);
            this.labelExternalIP.TabIndex = 7;
            this.labelExternalIP.Text = "External IP:";
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 1200;
            this.toolTip.AutoPopDelay = 12000;
            this.toolTip.InitialDelay = 1200;
            this.toolTip.ReshowDelay = 2240;
            // 
            // timerObtainingIPAnimation
            // 
            this.timerObtainingIPAnimation.Interval = 1000;
            this.timerObtainingIPAnimation.Tick += new System.EventHandler(this.timerObtainingIPAnimation_Tick);
            // 
            // FormMyIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 222);
            this.Controls.Add(this.labelExternalIP);
            this.Controls.Add(this.labelInternalIPs);
            this.Controls.Add(this.dataGridViewExternalIP);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.dataGridViewInternalIPs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormMyIP";
            this.Text = "My IP";
            this.Shown += new System.EventHandler(this.FormMyIP_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormMyIP_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMyIP_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInternalIPs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExternalIP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInternalIPs;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIP;
        private System.Windows.Forms.DataGridView dataGridViewExternalIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label labelInternalIPs;
        private System.Windows.Forms.Label labelExternalIP;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Timer timerObtainingIPAnimation;

    }
}

