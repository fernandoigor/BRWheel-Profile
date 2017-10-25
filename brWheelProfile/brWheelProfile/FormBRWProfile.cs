using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO.Ports;



namespace brWheelProfile
{
    public partial class FormBRWProfile : Form
    {
        string VERSION = "0.9";
        string RxString;
        string fwVersion = null;

        int lastRotationValue = 0;
        int lastGainValue=0;
        int lastConstantValue = 0;
        int lastFrictionValue = 0;
        int lastDamperValue = 0;
        int lastInertiaValue = 0;
        int lastSpringValue = 0;
        int lastSineValue = 0;
        int lastDesktopValue = 0;
        int lastStopValue = 0;
        int lastMinimalValue = 0;
        int lastMaximumValue = 0;
        int calibrateValue = 0;
        int centerValue = 0;

        public FormBRWProfile()
        {
            InitializeComponent();
            labelProfileVersion.Text = VERSION;
        }

        private void trackBarRotation_Scroll(object sender, EventArgs e)
        {
            labelRotationValue.Text = trackBarRotation.Value + " °";
        }

        private void trackBarGain_Scroll(object sender, EventArgs e)
        {
            labelGainValue.Text = trackBarGain.Value + " %";
        }

        private void trackBarConstant_Scroll(object sender, EventArgs e)
        {
            labelConstantValue.Text = trackBarConstant.Value + " %";
        }

        private void trackBarFriction_Scroll(object sender, EventArgs e)
        {
            labelFrictionValue.Text = trackBarFriction.Value + " %";
        }

        private void trackBarDamper_Scroll(object sender, EventArgs e)
        {
            labelDamperValue.Text = trackBarDamper.Value + " %";
        }

        private void trackBarInertia_Scroll(object sender, EventArgs e)
        {

            labelInertiaValue.Text = trackBarInertia.Value + " %";
        }

        private void trackBarSpring_Scroll(object sender, EventArgs e)
        {
            labelSpringValue.Text = trackBarSpring.Value + " %";
        }

        private void trackBarSine_Scroll(object sender, EventArgs e)
        {
            labelSineValue.Text = trackBarSine.Value + " %";
        }

        private void trackBarDestkop_Scroll(object sender, EventArgs e)
        {
            labelDesktopValue.Text = trackBarDesktop.Value + " %";
        }

        private void trackBarStop_Scroll(object sender, EventArgs e)
        {
            labelStopValue.Text = trackBarStop.Value + " %";
        }

        private void trackBarMinimal_Scroll(object sender, EventArgs e)
        {
            if (trackBarMinimal.Value < trackBarMaximum.Value)
                labelMinimalValue.Text = ""+trackBarMinimal.Value;
            else
                trackBarMinimal.Value = trackBarMaximum.Value - 1;
        }

        private void trackBarMaximum_Scroll(object sender, EventArgs e)
        {
           if (trackBarMinimal.Value < trackBarMaximum.Value)
                labelMaximumValue.Text = ""+trackBarMaximum.Value;
           else
                trackBarMaximum.Value = trackBarMinimal.Value + 1;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("www.facebook.com/fernandoigorr");
        }

        

        private void pictureBoxBRW_Clicked(object sender, EventArgs e)
        {
        }

        private void refreshListCOMs()
        {
            int i;
            bool quantDiferente; //flag para sinalizar que a quantidade de portas mudou

            i = 1;
            quantDiferente = false;
            //se a quantidade de portas mudou
            if (serialPort1.IsOpen == false)
            {
                if (comboBoxCOM.Items.Count == SerialPort.GetPortNames().Length + 1)
                {
                    foreach (string s in SerialPort.GetPortNames())
                    {
                        if (comboBoxCOM.Items[i].Equals(s) == false)
                        {
                            quantDiferente = true;
                        }
                        i++;
                    }
                }
                else
                {
                    quantDiferente = true;
                }
            }

            //Se não foi detectado diferença
            if (quantDiferente == false)
            {
                return;                     //retorna
            }

            //limpa comboBox
            comboBoxCOM.Items.Clear();
            comboBoxCOM.Items.Add("None");
            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBoxCOM.Items.Add(s);
            }
            //seleciona a primeira posição da lista
            comboBoxCOM.SelectedIndex = 0;
        }
        private void FormBRWProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen == true)  // se porta aberta
                serialPort1.Close();         //fecha a porta
        }
        private void comboBoxCOM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                try
                {
                    serialPort1.PortName = comboBoxCOM.Items[comboBoxCOM.SelectedIndex].ToString();
                    serialPort1.Open();

                }
                catch
                {
                    return;

                }
                if (serialPort1.IsOpen)
                {
                    labelStatusValue.Text = "Connected";
                    labelStatusValue.ForeColor = Color.Green;
                    serialPort1.Write("v");
                    //comboBoxCOM.Enabled = false;

                }
            }
            else
            {

                try
                {
                    serialPort1.Close();
                    //comboBoxCOM.Enabled = true;
                    labelStatusValue.Text = "Unknow";
                    labelStatusValue.ForeColor = Color.Red;
                    fwVersion = null;
                    labelFirmwareVersion.Text = "Unknow";
                }
                catch
                {
                    return;
                }

            }
        }

        private void time_Tick(object sender, EventArgs e)
        {
            refreshListCOMs();
            refreshValuesSerial();
        }

        private void refreshValuesSerial()
        {
            if (serialPort1.IsOpen == true)
            {
                if (calibrateValue == 1)
                {
                    calibrateValue = 0;
                    serialPort1.Write("r");
                }
                else if (centerValue == 1)
                {
                    centerValue = 0;
                    serialPort1.Write("c");
                }
                else if (trackBarRotation.Value != lastRotationValue)
                {
                    lastRotationValue = trackBarRotation.Value;
                    serialPort1.Write("g" + lastRotationValue);
                    Properties.Settings.Default.Rotation = lastRotationValue;
                }
                else if (trackBarGain.Value != lastGainValue)
                {
                    lastGainValue = trackBarGain.Value;
                    serialPort1.Write("fg" + lastGainValue);
                    Properties.Settings.Default.Gain = lastGainValue;
                }
                else if (trackBarConstant.Value != lastConstantValue)
                {
                    lastConstantValue = trackBarConstant.Value;
                    serialPort1.Write("fc" + lastConstantValue);
                    Properties.Settings.Default.Constant = lastConstantValue;
                }
                else if (trackBarFriction.Value != lastFrictionValue)
                {
                    lastFrictionValue = trackBarFriction.Value;
                    serialPort1.Write("ff" + lastFrictionValue);
                    Properties.Settings.Default.Friction = lastFrictionValue;
                }
                else if (trackBarDamper.Value != lastDamperValue)
                {
                    lastDamperValue = trackBarDamper.Value;
                    serialPort1.Write("fd" + lastDamperValue);
                    Properties.Settings.Default.Damper = lastDamperValue;
                }
                else if (trackBarInertia.Value != lastInertiaValue)
                {
                    lastInertiaValue = trackBarInertia.Value;
                    serialPort1.Write("fi" + lastInertiaValue);
                    Properties.Settings.Default.Inertia = lastInertiaValue;
                }
                else if (trackBarSpring.Value != lastSpringValue)
                {
                    lastSpringValue = trackBarSpring.Value;
                    serialPort1.Write("fm" + lastSpringValue);
                    Properties.Settings.Default.Spring = lastSpringValue;
                }
                else if (trackBarSine.Value != lastSineValue)
                {
                    lastSineValue = trackBarSine.Value;
                    serialPort1.Write("fs" + lastSineValue);
                    Properties.Settings.Default.Sine = lastSineValue;
                }
                else if (trackBarDesktop.Value != lastDesktopValue)
                {
                    lastDesktopValue = trackBarDesktop.Value;
                    serialPort1.Write("fa" + lastDesktopValue);
                    Properties.Settings.Default.Desktop = lastDesktopValue;
                }
                else if (trackBarStop.Value != lastStopValue)
                {
                    lastStopValue = trackBarStop.Value;
                    serialPort1.Write("fb" + lastStopValue);
                    Properties.Settings.Default.Stop = lastStopValue;
                }
                else if (trackBarMinimal.Value != lastMinimalValue)
                {
                    lastMinimalValue = trackBarMinimal.Value;
                    serialPort1.Write("fj" + lastMinimalValue);
                    Properties.Settings.Default.Minimal = lastMinimalValue;
                }
                else if (trackBarMaximum.Value != lastMaximumValue)
                {
                    lastMaximumValue = trackBarMaximum.Value;
                    serialPort1.Write("fk" + lastMaximumValue);
                    Properties.Settings.Default.Maximum = lastMaximumValue;
                }
                Properties.Settings.Default.Save();
            }
        }


        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            RxString = serialPort1.ReadExisting();          // Available
            this.Invoke(new EventHandler(changesReceived));
        }
        private void changesReceived(object sender, EventArgs e)
        {
            String temp = RxString.Substring(0, 12);
            if(temp == "BRW Version-")
                {
                double numberVersion = Convert.ToDouble(RxString.Substring(12))/100.0;
                //Console.WriteLine(temp);
                fwVersion = Convert.ToString(numberVersion);
                labelFirmwareVersion.Text = "BRW V " + fwVersion;
                }
        }

        private void buttonCalibrate_Click(object sender, EventArgs e)
        {
            calibrateValue = 1;
        }

        private void buttonCenter_Click(object sender, EventArgs e)
        {
            centerValue = 1;
        }

        private void form_Load(object sender, EventArgs e)
        {
            labelGainValue.Text = (trackBarGain.Value = Properties.Settings.Default.Gain) + " %";
            labelConstantValue.Text = (trackBarConstant.Value = Properties.Settings.Default.Constant) + " %";
            labelFrictionValue.Text = (trackBarFriction.Value = Properties.Settings.Default.Friction) + " %";
            labelDamperValue.Text = (trackBarDamper.Value = Properties.Settings.Default.Damper) + " %";
            labelInertiaValue.Text = (trackBarInertia.Value = Properties.Settings.Default.Inertia) + " %";
            labelSpringValue.Text = (trackBarSpring.Value = Properties.Settings.Default.Spring) + " %";
            labelSineValue.Text = (trackBarSine.Value = Properties.Settings.Default.Sine) + " %";

            labelDesktopValue.Text = (trackBarDesktop.Value = Properties.Settings.Default.Desktop) + " %";
            labelStopValue.Text = (trackBarStop.Value = Properties.Settings.Default.Stop) + " %";
            labelMinimalValue.Text = (trackBarMinimal.Value = Properties.Settings.Default.Minimal) + "";
            labelMaximumValue.Text = (trackBarMaximum.Value = Properties.Settings.Default.Maximum) + "";

            labelRotationValue.Text = (trackBarRotation.Value = Properties.Settings.Default.Rotation) + " °";

        }
    }
}
