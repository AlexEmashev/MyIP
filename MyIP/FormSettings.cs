using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyIP
{
    /// <summary>
    /// Form settings class. Allows to change the language, web-site name for searching the external IP.
    /// </summary>
    public partial class FormSettings : Form
    {
        
        public FormSettings()
        {
            InitializeComponent();
            // Loading current localization.
            this.Text = Program.Localisation.FormSettings;
            labelWebPage.Text = Program.Localisation.labelWebPage;
            labelNotion.Text = Program.Localisation.labelNotion;
            labelLanguage.Text = Program.Localisation.labelLanguage;
            textBoxWebResourse.Text = MyIP.Properties.Settings.Default.ExternalIPSource;

            DataTable localsTable = Localizator.GetAvaliableLocalizations();

            if (localsTable.Rows.Count == 0)
                comboBoxLanguages.Items.Add("Default");
            else
            {
                comboBoxLanguages.DataSource = localsTable;
                comboBoxLanguages.DisplayMember = localsTable.Columns[1].ToString();
            }
            string currentLocale = MyIP.Properties.Settings.Default.CurrentLocale;
         
            foreach (DataRow row in localsTable.Rows)
            {
                if (row[0].ToString() == currentLocale)
                    comboBoxLanguages.SelectedIndex = localsTable.Rows.IndexOf(row);
            }
        }
        /// <summary>
        /// Saves changes to settings. If language was changed, it will be applied to the interface.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            MyIP.Properties.Settings.Default.ExternalIPSource = textBoxWebResourse.Text;
            // Saving the language.
            if (comboBoxLanguages.DataSource != null)
            {
                DataRow selectedRow = ((DataRowView)comboBoxLanguages.SelectedValue).Row;
                Program.Localisation = Localizator.GetLocalization(selectedRow[0].ToString());
                MyIP.Properties.Settings.Default.CurrentLocale = Program.Localisation.FileName;
            }
            this.Close();
        }
        /// <summary>
        /// If Escape is presset form will be closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormSettings_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
