using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace brWheelProfile
{
    public partial class FormBRWProfile : Form
    {
        public FormBRWProfile()
        {
            InitializeComponent();
        }

        private void trackBarGain_Scroll(object sender, EventArgs e)
        {
            labelGainValue.Text = trackBarGain.Value + " %";
        }

        private void trackBarConstant_Scroll(object sender, EventArgs e)
        {
            labelConstantValue.Text = trackBarConstant.Value + " %";
        }

        private void trackBarRamp_Scroll(object sender, EventArgs e)
        {
            labelRampValue.Text = trackBarRamp.Value + " %";
        }

        private void trackBarRotation_Scroll(object sender, EventArgs e)
        {
            labelRotationValue.Text = trackBarRotation.Value + " °";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("www.facebook.com/fernandoigorr");
        }

        

        private void pictureBoxBRW_Clicked(object sender, EventArgs e)
        {
        }
    }
}
