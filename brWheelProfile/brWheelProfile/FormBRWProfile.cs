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
using System.Net;
using System.Xml;
using System.Drawing.Drawing2D;
using System.Threading;
//using System.Threading;


namespace brWheelProfile
{
    public partial class FormBRWProfile : Form
    {
        string VERSION = "2.0";
        string RxString;
        string fwVersion = null;

        int countTick = 0;

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

        HID_demo HID = new HID_demo();
        USB_ConfigReport configData = new USB_ConfigReport();
        USB_DataReport joystickData = new USB_DataReport();
        public FormBRWProfile()
        {
            InitializeComponent();
            labelProfileVersion.Text = VERSION;
            labelStatusValue.Text = "Disconnected";
            labelFirmwareVersion.Text = "0.0";

            HID.find();
            HID.connect();

            /*String url = "https://raw.githubusercontent.com/fernandoigor/BRWheel-Profile/master/VERSION.md";
            using (WebClient client = new WebClient())
            {
                string rawXml = client.DownloadString(url);
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(rawXml);
                Console.WriteLine(xmlDoc);
            }*/

            
            //Form1 temp = new Form1();
            //temp.Show();
            //temp.Visible = false;

        }
        private void FormBRWProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Desconectar
            timer1.Stop();
            Thread.Sleep(200);
            HID.close();
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

            //Console.WriteLine(trackBarMinimal.Value);
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
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("www.github.com/fernandoigor/BRWheel-Profile");
        }

        private void pictureBoxBRW_Clicked(object sender, EventArgs e)
        {
        }

        private void timer1_tick_configData(object sender, EventArgs e)
        {
            if (HID.connected)
            {
                labelStatusValue.Text = "Connected";
                labelStatusValue.ForeColor = Color.FromArgb(255, 0, 250, 0);
                /*foreach (byte i in HID.dataReceived)
                {
                    Console.Write(i + " ");
                }*/
                //System.Threading.Thread.Sleep(5000);
                if (checkValues())
                {
                    //modificou as infos, precisa enviar
                    //Console.WriteLine("modifcou");
                    if (configData.Info < 255)
                        configData.Info = 1;    // Set estado de sem ação.
                }
                if (configData.Info == 255)
                {
                    if (HID.configReceived[0] == 0) // equivalente a nao definido
                    {
                        activeTrackBar(false);
                        configData.ReportId = 241; // 0xF1
                        //pegar os parametros do volante ou do profile?
                        //iniciando sem valores
                        HID.sendData(configData);
                    }
                    else
                    {
                        activeTrackBar(true);
                        configData = HID.decodeConfigReport();
                        configData.Info = 0;
                        // refresh layout bar
                        fwVersion = Convert.ToString(configData.Version/100.0);
                        labelFirmwareVersion.Text = fwVersion;
                        refreshValues();
                    }

                }
                else if (configData.Info == 1)
                {
                    //configData enviado para joystick
                    HID.sendData(configData);
                    configData.Info = 2;
                }
                else if (configData.Info == 2)
                {
                    // precisa verificar se os valores são iguais ao atual do profile, se não set Info = 1
                    if (HID.configReceived != null)
                    {
                        //byte[] configTemp = HID.dataReceived;//HID.decodeConfigReport();
                        if (HID.isEqual(HID.configReceived, HID.encodeConfigReport(configData)))
                        {
                            //configData = HID.decodeConfigReport();
                            USB_ConfigReport temp = HID.decodeConfigReport();
                            configData.Calibrate = 0;
                            configData.Centralize = 0;

                            configData.Info = 0;
                        }
                        else
                        {
                            configData.Info = 1;
                        }
                    }

                    //configData recebida do joystick
                }
                //HID.sendData();

            }
            else
            {
                labelStatusValue.Text = "Disconnected";
                labelStatusValue.ForeColor = Color.FromArgb(255, 255, 0, 0);
                HID.find();
                HID.connect();
            }
            joystickData = HID.decodeDataReport();
            refreshJoystickValues();
            //Console.WriteLine("1tick " + configData.Info + " " + test[0] + " " + test[1]);

            //HID.sendData(configData);
            /*
            //Image img = Image.FromFile("pictureWheel3.jpg");
            Image img = brWheelProfile.Properties.Resources.pictureWheelDisplay;
            Graphics gfx = Graphics.FromImage(img);
            gfx.TranslateTransform((float)img.Width / 2, (float)img.Height / 2);
            gfx.RotateTransform(countTick);
            gfx.TranslateTransform(-(float)img.Width / 2, -(float)img.Height / 2);
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;
            gfx.DrawImage(img, new Point(0, 0));
            gfx.Dispose();
            pictureWheel.Image = img;
            */
            // Console.WriteLine("tick " + configData.Info);
        }

        private bool checkValues()
        {
            bool different = false;

            if (calibrateValue == 1)
            {
                calibrateValue = 0;
                //serialPort1.Write("r");
                configData.Calibrate = 1;
                different = true;
            }
            else if (centerValue == 1)
            {
                centerValue = 0;
                //serialPort1.Write("c");
                configData.Centralize = 1;
                different = true;
            }
            else if (trackBarRotation.Value != lastRotationValue)
            {
                lastRotationValue = trackBarRotation.Value;
                configData.Rotation = Convert.ToUInt16(lastRotationValue);
                //serialPort1.Write("g" + lastRotationValue);
                //Properties.Settings.Default.Rotation = lastRotationValue;
                different = true;
            }
            else if (trackBarGain.Value != lastGainValue)
            {
                lastGainValue = trackBarGain.Value;
                configData.GeneralGain = Convert.ToByte(lastGainValue);
                //serialPort1.Write("fg" + lastGainValue);
                //Properties.Settings.Default.Gain = lastGainValue;
                different = true;
            }
            else if (trackBarConstant.Value != lastConstantValue)
            {
                lastConstantValue = trackBarConstant.Value;
                configData.ConstantGain = Convert.ToByte(lastConstantValue);
                //serialPort1.Write("fc" + lastConstantValue);
                //Properties.Settings.Default.Constant = lastConstantValue;
                different = true;
            }
            else if (trackBarFriction.Value != lastFrictionValue)
            {
                lastFrictionValue = trackBarFriction.Value;
                configData.FrictionGain = Convert.ToByte(lastFrictionValue);
                //serialPort1.Write("ff" + lastFrictionValue);
                //Properties.Settings.Default.Friction = lastFrictionValue;
                different = true;
            }
            else if (trackBarDamper.Value != lastDamperValue)
            {
                lastDamperValue = trackBarDamper.Value;
                configData.DamperGain = Convert.ToByte(lastDamperValue);
                //serialPort1.Write("fd" + lastDamperValue);
                //Properties.Settings.Default.Damper = lastDamperValue;
                different = true;
            }
            else if (trackBarInertia.Value != lastInertiaValue)
            {
                lastInertiaValue = trackBarInertia.Value;
                configData.InertiaGain = Convert.ToByte(lastInertiaValue);
                //serialPort1.Write("fi" + lastInertiaValue);
                //Properties.Settings.Default.Inertia = lastInertiaValue;
                different = true;
            }
            else if (trackBarSpring.Value != lastSpringValue)
            {
                lastSpringValue = trackBarSpring.Value;
                configData.SpringGain = Convert.ToByte(lastSpringValue);
                //serialPort1.Write("fm" + lastSpringValue);
                //Properties.Settings.Default.Spring = lastSpringValue;
                different = true;
            }
            else if (trackBarSine.Value != lastSineValue)
            {
                lastSineValue = trackBarSine.Value;
                configData.SineGain = Convert.ToByte(lastSineValue);
                //serialPort1.Write("fs" + lastSineValue);
                //Properties.Settings.Default.Sine = lastSineValue;
                different = true;
            }
            else if (trackBarDesktop.Value != lastDesktopValue)
            {
                lastDesktopValue = trackBarDesktop.Value;
                configData.CenterGain = Convert.ToByte(lastDesktopValue);
                //serialPort1.Write("fa" + lastDesktopValue);
                //Properties.Settings.Default.Desktop = lastDesktopValue;
                different = true;
            }
            else if (trackBarStop.Value != lastStopValue)
            {
                lastStopValue = trackBarStop.Value;
                configData.StopGain = Convert.ToByte(lastStopValue);
                //serialPort1.Write("fb" + lastStopValue);
                //Properties.Settings.Default.Stop = lastStopValue;
                different = true;
            }
            else if (trackBarMinimal.Value != lastMinimalValue)
            {
                lastMinimalValue = trackBarMinimal.Value;
                
                configData.MinForce = Convert.ToUInt16(lastMinimalValue);
                //serialPort1.Write("fj" + lastMinimalValue);
                //Properties.Settings.Default.Minimal = lastMinimalValue;
                different = true;
            }
            else if (trackBarMaximum.Value != lastMaximumValue)
            {
                lastMaximumValue = trackBarMaximum.Value;
                configData.MaxForce = Convert.ToUInt16(lastMaximumValue);
                //serialPort1.Write("fk" + lastMaximumValue);
                //Properties.Settings.Default.Maximum = lastMaximumValue;
                different = true;
            }
            return different;
        }
      


        private void form_Load(object sender, EventArgs e)
        {

            configData.Info = 255;
            activeTrackBar(false);
            /*labelGainValue.Text = (trackBarGain.Value = Properties.Settings.Default.Gain) + " %";
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

            labelRotationValue.Text = (trackBarRotation.Value = Properties.Settings.Default.Rotation) + " °";*/

        }
        private void refreshValues()
        {
            trackBarRotation.Value = configData.Rotation;
            trackBarGain.Value = configData.GeneralGain;
            trackBarConstant.Value = configData.ConstantGain;
            trackBarFriction.Value = configData.FrictionGain;
            trackBarDamper.Value = configData.DamperGain;
            trackBarInertia.Value = configData.InertiaGain;
            trackBarSpring.Value = configData.SpringGain;
            trackBarSine.Value = configData.SineGain;
            trackBarDesktop.Value = configData.CenterGain;
            trackBarStop.Value = configData.StopGain;
            trackBarMinimal.Value = configData.MinForce;
            trackBarMaximum.Value = configData.MaxForce;

        }
        private void activeTrackBar(bool active)
        {
            trackBarRotation.Enabled = active;
            trackBarGain.Enabled = active;
            trackBarConstant.Enabled = active;
            trackBarFriction.Enabled = active;
            trackBarDamper.Enabled = active;
            trackBarInertia.Enabled = active;
            trackBarSpring.Enabled = active;
            trackBarSine.Enabled = active;
            trackBarDesktop.Enabled = active;
            trackBarStop.Enabled = active;
            trackBarMinimal.Enabled = active;
            trackBarMaximum.Enabled = active;

        }
        private void refreshJoystickValues()
        {
            int rotation = (joystickData.X * configData.Rotation) / 65536;
            Image img = brWheelProfile.Properties.Resources.pictureWheel;

            Graphics gfx = Graphics.FromImage(img);
            gfx.TranslateTransform((float)img.Width / 2, (float)img.Height / 2);
            gfx.RotateTransform(rotation);
            gfx.TranslateTransform(-(float)img.Width / 2, -(float)img.Height / 2);
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;
            gfx.DrawImage(img, new Point(0, 0));
            gfx.Dispose();
            pictureWheel.Image = img;
        }

        private void ClickedCloseForm(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnCloseHover(object sender, EventArgs e)
        {
            boxClose.Image = brWheelProfile.Properties.Resources.btnXHover;
        }

        private void btnCloseLeave(object sender, EventArgs e)
        {
            boxClose.Image = brWheelProfile.Properties.Resources.btnX;
        }

        private void btnCloseClick(object sender, EventArgs e)
        {
            boxClose.Image = brWheelProfile.Properties.Resources.btnXClick;
            Environment.Exit(0);
        }

        private void btnMinimizeHover(object sender, EventArgs e)
        {
            boxMinimize.Image = brWheelProfile.Properties.Resources.btn_Hover;
        }

        private void btnMinimizeLeave(object sender, EventArgs e)
        {
            boxMinimize.Image = brWheelProfile.Properties.Resources.btn_;
        }

        private void btnMinimizeClick(object sender, EventArgs e)
        {
            boxMinimize.Image = brWheelProfile.Properties.Resources.btn_Click;
            this.WindowState = FormWindowState.Minimized;
        }


    }
}
