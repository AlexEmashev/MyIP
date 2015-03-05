using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;

namespace MyIP
{
    public partial class FormMyIP : Form
    {
        /// <summary>
        /// Reference to IPs class object. Used for getting the IP information.
        /// </summary>
        IPs iPs;
        /// <summary>
        /// Flag that allows copying the external IP to clipboard. True when IP was read.
        /// </summary>
        bool externalIPRead = false;
        /// <summary>
        /// Class constructor
        /// </summary>
        public FormMyIP()
        {
            InitializeComponent();
            iPs = new IPs();

            int externalRowID = dataGridViewExternalIP.Rows.Add();
        }

        /// <summary>
        /// Gets the information about IPs after the interface has been drawn.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMyIP_Shown(object sender, EventArgs e)
        {
            GetIPs();
        }

        /// <summary>
        /// Gets the IP adresses.
        /// </summary>
        private void GetIPs()
        {
            externalIPRead = false;
            // Playing the animation of getting the IP address.
            PlayWaitingAnimation();
            timerObtainingIPAnimation.Start();

            // Getting internal IP adresses.
            dataGridViewInternalIPs.Rows.Clear();
            foreach (string IP in iPs.GetLocalIPs())
            {
                int internalRowID = dataGridViewInternalIPs.Rows.Add();
                dataGridViewInternalIPs.Rows[internalRowID].Cells[0].Value = IP;
            }
            dataGridViewInternalIPs.ClearSelection();

            // Getting the external IP adress.
            dataGridViewExternalIP.Select();
            iPs.GetExternalIP(new AsyncCallback(ShowExternalIP)); // This method runs asynchronously.
            //ToDo: save selection.
        }

        /// <summary>
        /// Gets the External IP information. This method runs asynchronously.
        /// </summary>
        /// <param name="result">AsyncResult object that represents result of getting external IP infromation process.</param>
        private void ShowExternalIP(IAsyncResult result)
        {
            AsyncResult asyncResult = (AsyncResult)result;
            IPs.ExternalIPDelegate externalIPDelegate = (IPs.ExternalIPDelegate)asyncResult.AsyncDelegate;
            ExternalIPInfo iPInfo = externalIPDelegate.EndInvoke(result);
            timerObtainingIPAnimation.Stop();

            // If errors occurs due to incorrect page, than showing the settings dialog.
            if (iPInfo.OperationState == ExternalIPInfo.State.IPNotFound ||
                iPInfo.OperationState == ExternalIPInfo.State.PageNotFound)
            {
                MessageBox.Show(iPInfo.Result, Program.Localisation.ErrorWhileGettingExternalIP, MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonSettings_Click(null, new EventArgs());
                dataGridViewExternalIP.Rows[0].Cells[0].Value = Program.Localisation.IPNotFound;
            }
            // If there is no Internet connection, just writes it in box.
            else if (iPInfo.OperationState == ExternalIPInfo.State.NoConnection)
            {
                dataGridViewExternalIP.Rows[0].Cells[0].Value = Program.Localisation.NoInternetConnection;
            }
            else if (iPInfo.OperationState == ExternalIPInfo.State.UnknownError)
            {
                dataGridViewExternalIP.Rows[0].Cells[0].Value = Program.Localisation.ErrorOccuredIPFetch;
            }
            else // if sucesseful.
            {
                dataGridViewExternalIP.Rows[0].Cells[0].Value = iPInfo.Result;
                externalIPRead = true;
            }
        }

        /// <summary>
        /// Closes the App.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Clears selection of dataGridViewExternalIP.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewInternalIPs_Enter(object sender, EventArgs e)
        {
            dataGridViewExternalIP.ClearSelection();
        }
        /// <summary>
        /// Clears selection of dataGridViewInternalIPs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewExternalIP_Enter(object sender, EventArgs e)
        {
            dataGridViewInternalIPs.ClearSelection();
        }
        /// <summary>
        /// Catching keys on form level.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMyIP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
        /// <summary>
        /// On refresh button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            GetIPs();
        }

        /// <summary>
        /// Button copy click causes copying selected IP to clipboard;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (dataGridViewExternalIP.SelectedRows.Count > 0 && externalIPRead == true)
            {
                Clipboard.SetText(dataGridViewExternalIP.SelectedRows[0].Cells[0].Value.ToString());
                ShowCopiedTip();
            }
            else if (dataGridViewInternalIPs.SelectedRows.Count > 0)
            {
                Clipboard.SetText(dataGridViewInternalIPs.SelectedRows[0].Cells[0].Value.ToString());
                ShowCopiedTip();
            }
        }

        /// <summary>
        /// Shows copy process notion.
        /// </summary>
        private void ShowCopiedTip()
        {
            FormCopiedNotice copied = new FormCopiedNotice();
            copied.Location = new Point((this.Location.X + (this.Width / 2)) - copied.Width, (this.Location.Y + (this.Height / 2)) - copied.Height - 20);
            copied.Show();
        }

        /// <summary>
        /// Calls settings dialog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            FormSettings settings = new FormSettings();
            settings.Location = new Point(this.Location.X, this.Location.Y);
            settings.ShowDialog();
        }

        /// <summary>
        /// Refreshes the interface e.g. if the language has changed.
        /// </summary>
        private void RefreshInterface()
        {
            this.Text = Program.Localisation.FormMyIP;
            labelExternalIP.Text = Program.Localisation.labelExternalIP;
            labelInternalIPs.Text = Program.Localisation.labelInternalIPs;
            toolTip.RemoveAll();
            //buttonRefresh.Text = Program.Localisation.buttonRefresh;
            toolTip.SetToolTip(buttonRefresh, Program.Localisation.buttonRefreshTip);
            //buttonCopy.Text = Program.Localisation.buttonCopy;
            toolTip.SetToolTip(buttonCopy, Program.Localisation.buttonCopyTip);
            //buttonSettings.Text = Program.Localisation.buttonSettings;
            toolTip.SetToolTip(buttonSettings, Program.Localisation.buttonSettingsTip);
            buttonClose.Text = Program.Localisation.buttonClose;
            toolTip.SetToolTip(buttonClose, Program.Localisation.buttonCloseTip);
        }

        /// <summary>
        /// Uses in external IP procedure as step of animation.
        /// </summary>
        int step = 0;
        /// <summary>
        /// Plays animation while waiting the external IP data processing.
        /// </summary>
        private void PlayWaitingAnimation()
        {
            switch (step)
            {
                case 0:
                    {
                        dataGridViewExternalIP.Rows[0].Cells[0].Value = Program.Localisation.ObtainingIP1;
                        step++;
                        break;
                    }
                case 1:
                    {
                        dataGridViewExternalIP.Rows[0].Cells[0].Value = Program.Localisation.ObtainingIP2;
                        step++;
                        break;
                    }
                case 2:
                    {
                        dataGridViewExternalIP.Rows[0].Cells[0].Value = Program.Localisation.ObtainingIP3;
                        step++;
                        break;
                    }
                case 3:
                    {
                        dataGridViewExternalIP.Rows[0].Cells[0].Value = Program.Localisation.ObtainingIP4;
                        step = 0;
                        break;
                    }
            }
        }

        private void timerObtainingIPAnimation_Tick(object sender, EventArgs e)
        {
            PlayWaitingAnimation();
        }

        private void FormMyIP_Paint(object sender, PaintEventArgs e)
        {
            RefreshInterface();
        }

    }
}
