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
    public partial class FormCopiedNotice : Form
    {
        public FormCopiedNotice()
        {
            InitializeComponent();
            labelCopied.Text = Program.Localisation.CopiedTip;
            // Set to automatic.
            //// Resizes the form to fit the lable.
            //if(labelCopied.Size.Width + labelCopied.Left > this.Size.Width)
            //{
            //    int formWitdh = this.Width;
            //    this.Width = this.Width + ((formWitdh + labelCopied.Left) - formWitdh) + labelCopied.Left;
            //}
        }

        /// <summary>
        /// After the form shown the animations starts.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCopiedNotice_Shown(object sender, EventArgs e)
        {
            this.ClientSize = new Size(58, 23);
            timerFadeInOut.Start();
        }

        /// <summary>
        /// Counter for animation.
        /// </summary>
        int showCycles = 0;
        /// <summary>
        /// Each tick animation is changing.
        /// </summary>
        /// <remarks>First occurs increasing the opacity. 
        /// Then form is showing within couple of timer ticks. 
        /// Then animation is fading out.</remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerFadeInOut_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1.0 && showCycles < 15)
                this.Opacity += 0.10;
            else if (this.Opacity == 1.0 && showCycles < 15)
                showCycles++;
            else if (showCycles == 15 && this.Opacity != 0.0)
                this.Opacity -= 0.05;
            else if (showCycles == 15 && this.Opacity == 0.0)
                this.Close();
        }
    }
}
