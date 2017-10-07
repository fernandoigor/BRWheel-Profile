namespace brWheelProfile
{
    partial class FormBRWProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBRWProfile));
            this.trackBarGain = new System.Windows.Forms.TrackBar();
            this.groupBoxEffects = new System.Windows.Forms.GroupBox();
            this.labelSineValue = new System.Windows.Forms.Label();
            this.labelSine = new System.Windows.Forms.Label();
            this.trackBarSine = new System.Windows.Forms.TrackBar();
            this.trackBarSpring = new System.Windows.Forms.TrackBar();
            this.labelSpringValue = new System.Windows.Forms.Label();
            this.labelSpring = new System.Windows.Forms.Label();
            this.trackBarInertia = new System.Windows.Forms.TrackBar();
            this.labelInertiaValue = new System.Windows.Forms.Label();
            this.labelInertia = new System.Windows.Forms.Label();
            this.labelDamperValue = new System.Windows.Forms.Label();
            this.labelDamper = new System.Windows.Forms.Label();
            this.trackBarDamper = new System.Windows.Forms.TrackBar();
            this.labelFrictionValue = new System.Windows.Forms.Label();
            this.labelFriction = new System.Windows.Forms.Label();
            this.trackBarFriction = new System.Windows.Forms.TrackBar();
            this.labelConstantValue = new System.Windows.Forms.Label();
            this.labelConstant = new System.Windows.Forms.Label();
            this.trackBarConstant = new System.Windows.Forms.TrackBar();
            this.labelGainValue = new System.Windows.Forms.Label();
            this.labelGain = new System.Windows.Forms.Label();
            this.groupBoxForce = new System.Windows.Forms.GroupBox();
            this.trackBarMaximum = new System.Windows.Forms.TrackBar();
            this.trackBarMinimal = new System.Windows.Forms.TrackBar();
            this.labelStopValue = new System.Windows.Forms.Label();
            this.labelStop = new System.Windows.Forms.Label();
            this.trackBarStop = new System.Windows.Forms.TrackBar();
            this.labelDesktopValue = new System.Windows.Forms.Label();
            this.labelDesktop = new System.Windows.Forms.Label();
            this.trackBarDesktop = new System.Windows.Forms.TrackBar();
            this.labelMaximumValue = new System.Windows.Forms.Label();
            this.labelMaximum = new System.Windows.Forms.Label();
            this.labelMinimalValue = new System.Windows.Forms.Label();
            this.labelMinimal = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxBRW = new System.Windows.Forms.PictureBox();
            this.buttonCalibrate = new System.Windows.Forms.Button();
            this.buttonCenterWheel = new System.Windows.Forms.Button();
            this.labelRotationValue = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.trackBarRotation = new System.Windows.Forms.TrackBar();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.labelProfileVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelFirmwareVersion = new System.Windows.Forms.Label();
            this.labelFirmware = new System.Windows.Forms.Label();
            this.labelStatusValue = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelCOMPort = new System.Windows.Forms.Label();
            this.comboBoxCOM = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGain)).BeginInit();
            this.groupBoxEffects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpring)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarInertia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDamper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFriction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarConstant)).BeginInit();
            this.groupBoxForce.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMaximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDesktop)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBRW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotation)).BeginInit();
            this.groupBoxStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBarGain
            // 
            this.trackBarGain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBarGain.Location = new System.Drawing.Point(67, 27);
            this.trackBarGain.Maximum = 200;
            this.trackBarGain.Name = "trackBarGain";
            this.trackBarGain.Size = new System.Drawing.Size(249, 45);
            this.trackBarGain.TabIndex = 2;
            this.trackBarGain.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarGain.Scroll += new System.EventHandler(this.trackBarGain_Scroll);
            // 
            // groupBoxEffects
            // 
            this.groupBoxEffects.Controls.Add(this.labelSineValue);
            this.groupBoxEffects.Controls.Add(this.labelSine);
            this.groupBoxEffects.Controls.Add(this.trackBarSine);
            this.groupBoxEffects.Controls.Add(this.trackBarSpring);
            this.groupBoxEffects.Controls.Add(this.labelSpringValue);
            this.groupBoxEffects.Controls.Add(this.labelSpring);
            this.groupBoxEffects.Controls.Add(this.trackBarInertia);
            this.groupBoxEffects.Controls.Add(this.labelInertiaValue);
            this.groupBoxEffects.Controls.Add(this.labelInertia);
            this.groupBoxEffects.Controls.Add(this.labelDamperValue);
            this.groupBoxEffects.Controls.Add(this.labelDamper);
            this.groupBoxEffects.Controls.Add(this.trackBarDamper);
            this.groupBoxEffects.Controls.Add(this.labelFrictionValue);
            this.groupBoxEffects.Controls.Add(this.labelFriction);
            this.groupBoxEffects.Controls.Add(this.trackBarFriction);
            this.groupBoxEffects.Controls.Add(this.labelConstantValue);
            this.groupBoxEffects.Controls.Add(this.labelConstant);
            this.groupBoxEffects.Controls.Add(this.trackBarConstant);
            this.groupBoxEffects.Controls.Add(this.labelGainValue);
            this.groupBoxEffects.Controls.Add(this.labelGain);
            this.groupBoxEffects.Controls.Add(this.trackBarGain);
            this.groupBoxEffects.Location = new System.Drawing.Point(327, 12);
            this.groupBoxEffects.Name = "groupBoxEffects";
            this.groupBoxEffects.Size = new System.Drawing.Size(358, 241);
            this.groupBoxEffects.TabIndex = 3;
            this.groupBoxEffects.TabStop = false;
            this.groupBoxEffects.Text = "Effects";
            // 
            // labelSineValue
            // 
            this.labelSineValue.AutoSize = true;
            this.labelSineValue.Location = new System.Drawing.Point(318, 192);
            this.labelSineValue.Name = "labelSineValue";
            this.labelSineValue.Size = new System.Drawing.Size(24, 13);
            this.labelSineValue.TabIndex = 23;
            this.labelSineValue.Text = "0 %";
            this.labelSineValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSine
            // 
            this.labelSine.AutoSize = true;
            this.labelSine.Location = new System.Drawing.Point(6, 192);
            this.labelSine.Name = "labelSine";
            this.labelSine.Size = new System.Drawing.Size(28, 13);
            this.labelSine.TabIndex = 22;
            this.labelSine.Text = "Sine";
            this.labelSine.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // trackBarSine
            // 
            this.trackBarSine.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBarSine.Location = new System.Drawing.Point(67, 190);
            this.trackBarSine.Maximum = 200;
            this.trackBarSine.Name = "trackBarSine";
            this.trackBarSine.Size = new System.Drawing.Size(249, 45);
            this.trackBarSine.TabIndex = 21;
            this.trackBarSine.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarSine.Scroll += new System.EventHandler(this.trackBarSine_Scroll);
            // 
            // trackBarSpring
            // 
            this.trackBarSpring.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBarSpring.Location = new System.Drawing.Point(67, 163);
            this.trackBarSpring.Maximum = 200;
            this.trackBarSpring.Name = "trackBarSpring";
            this.trackBarSpring.Size = new System.Drawing.Size(249, 45);
            this.trackBarSpring.TabIndex = 20;
            this.trackBarSpring.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarSpring.Scroll += new System.EventHandler(this.trackBarSpring_Scroll);
            // 
            // labelSpringValue
            // 
            this.labelSpringValue.AutoSize = true;
            this.labelSpringValue.Location = new System.Drawing.Point(318, 165);
            this.labelSpringValue.Name = "labelSpringValue";
            this.labelSpringValue.Size = new System.Drawing.Size(24, 13);
            this.labelSpringValue.TabIndex = 19;
            this.labelSpringValue.Text = "0 %";
            this.labelSpringValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSpring
            // 
            this.labelSpring.AutoSize = true;
            this.labelSpring.Location = new System.Drawing.Point(6, 165);
            this.labelSpring.Name = "labelSpring";
            this.labelSpring.Size = new System.Drawing.Size(37, 13);
            this.labelSpring.TabIndex = 18;
            this.labelSpring.Text = "Spring";
            this.labelSpring.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // trackBarInertia
            // 
            this.trackBarInertia.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBarInertia.Location = new System.Drawing.Point(67, 136);
            this.trackBarInertia.Maximum = 200;
            this.trackBarInertia.Name = "trackBarInertia";
            this.trackBarInertia.Size = new System.Drawing.Size(249, 45);
            this.trackBarInertia.TabIndex = 17;
            this.trackBarInertia.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarInertia.Scroll += new System.EventHandler(this.trackBarInertia_Scroll);
            // 
            // labelInertiaValue
            // 
            this.labelInertiaValue.AutoSize = true;
            this.labelInertiaValue.Location = new System.Drawing.Point(318, 138);
            this.labelInertiaValue.Name = "labelInertiaValue";
            this.labelInertiaValue.Size = new System.Drawing.Size(24, 13);
            this.labelInertiaValue.TabIndex = 16;
            this.labelInertiaValue.Text = "0 %";
            this.labelInertiaValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelInertia
            // 
            this.labelInertia.AutoSize = true;
            this.labelInertia.Location = new System.Drawing.Point(6, 138);
            this.labelInertia.Name = "labelInertia";
            this.labelInertia.Size = new System.Drawing.Size(36, 13);
            this.labelInertia.TabIndex = 15;
            this.labelInertia.Text = "Inertia";
            this.labelInertia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelDamperValue
            // 
            this.labelDamperValue.AutoSize = true;
            this.labelDamperValue.Location = new System.Drawing.Point(318, 111);
            this.labelDamperValue.Name = "labelDamperValue";
            this.labelDamperValue.Size = new System.Drawing.Size(24, 13);
            this.labelDamperValue.TabIndex = 14;
            this.labelDamperValue.Text = "0 %";
            this.labelDamperValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelDamper
            // 
            this.labelDamper.AutoSize = true;
            this.labelDamper.Location = new System.Drawing.Point(6, 111);
            this.labelDamper.Name = "labelDamper";
            this.labelDamper.Size = new System.Drawing.Size(44, 13);
            this.labelDamper.TabIndex = 13;
            this.labelDamper.Text = "Damper";
            this.labelDamper.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // trackBarDamper
            // 
            this.trackBarDamper.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBarDamper.Location = new System.Drawing.Point(67, 109);
            this.trackBarDamper.Maximum = 200;
            this.trackBarDamper.Name = "trackBarDamper";
            this.trackBarDamper.Size = new System.Drawing.Size(249, 45);
            this.trackBarDamper.TabIndex = 12;
            this.trackBarDamper.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarDamper.Scroll += new System.EventHandler(this.trackBarDamper_Scroll);
            // 
            // labelFrictionValue
            // 
            this.labelFrictionValue.AutoSize = true;
            this.labelFrictionValue.Location = new System.Drawing.Point(318, 84);
            this.labelFrictionValue.Name = "labelFrictionValue";
            this.labelFrictionValue.Size = new System.Drawing.Size(24, 13);
            this.labelFrictionValue.TabIndex = 11;
            this.labelFrictionValue.Text = "0 %";
            this.labelFrictionValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelFriction
            // 
            this.labelFriction.AutoSize = true;
            this.labelFriction.Location = new System.Drawing.Point(6, 84);
            this.labelFriction.Name = "labelFriction";
            this.labelFriction.Size = new System.Drawing.Size(41, 13);
            this.labelFriction.TabIndex = 10;
            this.labelFriction.Text = "Friction";
            this.labelFriction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // trackBarFriction
            // 
            this.trackBarFriction.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBarFriction.Location = new System.Drawing.Point(67, 82);
            this.trackBarFriction.Maximum = 200;
            this.trackBarFriction.Name = "trackBarFriction";
            this.trackBarFriction.Size = new System.Drawing.Size(249, 45);
            this.trackBarFriction.TabIndex = 9;
            this.trackBarFriction.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarFriction.Scroll += new System.EventHandler(this.trackBarFriction_Scroll);
            // 
            // labelConstantValue
            // 
            this.labelConstantValue.AutoSize = true;
            this.labelConstantValue.Location = new System.Drawing.Point(318, 57);
            this.labelConstantValue.Name = "labelConstantValue";
            this.labelConstantValue.Size = new System.Drawing.Size(24, 13);
            this.labelConstantValue.TabIndex = 8;
            this.labelConstantValue.Text = "0 %";
            this.labelConstantValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelConstant
            // 
            this.labelConstant.AutoSize = true;
            this.labelConstant.Location = new System.Drawing.Point(6, 57);
            this.labelConstant.Name = "labelConstant";
            this.labelConstant.Size = new System.Drawing.Size(49, 13);
            this.labelConstant.TabIndex = 7;
            this.labelConstant.Text = "Constant";
            this.labelConstant.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // trackBarConstant
            // 
            this.trackBarConstant.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBarConstant.Location = new System.Drawing.Point(67, 55);
            this.trackBarConstant.Maximum = 200;
            this.trackBarConstant.Name = "trackBarConstant";
            this.trackBarConstant.Size = new System.Drawing.Size(249, 45);
            this.trackBarConstant.TabIndex = 6;
            this.trackBarConstant.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarConstant.Scroll += new System.EventHandler(this.trackBarConstant_Scroll);
            // 
            // labelGainValue
            // 
            this.labelGainValue.AutoSize = true;
            this.labelGainValue.Location = new System.Drawing.Point(318, 30);
            this.labelGainValue.Name = "labelGainValue";
            this.labelGainValue.Size = new System.Drawing.Size(24, 13);
            this.labelGainValue.TabIndex = 5;
            this.labelGainValue.Text = "0 %";
            this.labelGainValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelGain
            // 
            this.labelGain.AutoSize = true;
            this.labelGain.Location = new System.Drawing.Point(6, 30);
            this.labelGain.Name = "labelGain";
            this.labelGain.Size = new System.Drawing.Size(55, 13);
            this.labelGain.TabIndex = 4;
            this.labelGain.Text = "Main Gain";
            this.labelGain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBoxForce
            // 
            this.groupBoxForce.Controls.Add(this.trackBarMaximum);
            this.groupBoxForce.Controls.Add(this.trackBarMinimal);
            this.groupBoxForce.Controls.Add(this.labelStopValue);
            this.groupBoxForce.Controls.Add(this.labelStop);
            this.groupBoxForce.Controls.Add(this.trackBarStop);
            this.groupBoxForce.Controls.Add(this.labelDesktopValue);
            this.groupBoxForce.Controls.Add(this.labelDesktop);
            this.groupBoxForce.Controls.Add(this.trackBarDesktop);
            this.groupBoxForce.Controls.Add(this.labelMaximumValue);
            this.groupBoxForce.Controls.Add(this.labelMaximum);
            this.groupBoxForce.Controls.Add(this.labelMinimalValue);
            this.groupBoxForce.Controls.Add(this.labelMinimal);
            this.groupBoxForce.Location = new System.Drawing.Point(327, 260);
            this.groupBoxForce.Name = "groupBoxForce";
            this.groupBoxForce.Size = new System.Drawing.Size(358, 158);
            this.groupBoxForce.TabIndex = 12;
            this.groupBoxForce.TabStop = false;
            this.groupBoxForce.Text = "Force";
            // 
            // trackBarMaximum
            // 
            this.trackBarMaximum.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBarMaximum.Location = new System.Drawing.Point(67, 104);
            this.trackBarMaximum.Maximum = 400;
            this.trackBarMaximum.Name = "trackBarMaximum";
            this.trackBarMaximum.Size = new System.Drawing.Size(249, 45);
            this.trackBarMaximum.TabIndex = 6;
            this.trackBarMaximum.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarMaximum.Value = 400;
            this.trackBarMaximum.Scroll += new System.EventHandler(this.trackBarMaximum_Scroll);
            // 
            // trackBarMinimal
            // 
            this.trackBarMinimal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBarMinimal.Location = new System.Drawing.Point(67, 76);
            this.trackBarMinimal.Maximum = 400;
            this.trackBarMinimal.Name = "trackBarMinimal";
            this.trackBarMinimal.Size = new System.Drawing.Size(249, 45);
            this.trackBarMinimal.TabIndex = 2;
            this.trackBarMinimal.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarMinimal.Scroll += new System.EventHandler(this.trackBarMinimal_Scroll);
            // 
            // labelStopValue
            // 
            this.labelStopValue.AutoSize = true;
            this.labelStopValue.Location = new System.Drawing.Point(318, 51);
            this.labelStopValue.Name = "labelStopValue";
            this.labelStopValue.Size = new System.Drawing.Size(24, 13);
            this.labelStopValue.TabIndex = 14;
            this.labelStopValue.Text = "0 %";
            this.labelStopValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelStop
            // 
            this.labelStop.AutoSize = true;
            this.labelStop.Location = new System.Drawing.Point(6, 51);
            this.labelStop.Name = "labelStop";
            this.labelStop.Size = new System.Drawing.Size(29, 13);
            this.labelStop.TabIndex = 13;
            this.labelStop.Text = "Stop";
            this.labelStop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // trackBarStop
            // 
            this.trackBarStop.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBarStop.Location = new System.Drawing.Point(67, 47);
            this.trackBarStop.Maximum = 200;
            this.trackBarStop.Name = "trackBarStop";
            this.trackBarStop.Size = new System.Drawing.Size(249, 45);
            this.trackBarStop.TabIndex = 12;
            this.trackBarStop.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarStop.Scroll += new System.EventHandler(this.trackBarStop_Scroll);
            // 
            // labelDesktopValue
            // 
            this.labelDesktopValue.AutoSize = true;
            this.labelDesktopValue.Location = new System.Drawing.Point(318, 22);
            this.labelDesktopValue.Name = "labelDesktopValue";
            this.labelDesktopValue.Size = new System.Drawing.Size(24, 13);
            this.labelDesktopValue.TabIndex = 11;
            this.labelDesktopValue.Text = "0 %";
            this.labelDesktopValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelDesktop
            // 
            this.labelDesktop.AutoSize = true;
            this.labelDesktop.Location = new System.Drawing.Point(6, 22);
            this.labelDesktop.Name = "labelDesktop";
            this.labelDesktop.Size = new System.Drawing.Size(47, 13);
            this.labelDesktop.TabIndex = 10;
            this.labelDesktop.Text = "Desktop";
            this.labelDesktop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // trackBarDesktop
            // 
            this.trackBarDesktop.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBarDesktop.Location = new System.Drawing.Point(67, 19);
            this.trackBarDesktop.Maximum = 200;
            this.trackBarDesktop.Name = "trackBarDesktop";
            this.trackBarDesktop.Size = new System.Drawing.Size(249, 45);
            this.trackBarDesktop.TabIndex = 9;
            this.trackBarDesktop.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarDesktop.Scroll += new System.EventHandler(this.trackBarDestkop_Scroll);
            // 
            // labelMaximumValue
            // 
            this.labelMaximumValue.AutoSize = true;
            this.labelMaximumValue.Location = new System.Drawing.Point(318, 109);
            this.labelMaximumValue.Name = "labelMaximumValue";
            this.labelMaximumValue.Size = new System.Drawing.Size(24, 13);
            this.labelMaximumValue.TabIndex = 8;
            this.labelMaximumValue.Text = "0 %";
            this.labelMaximumValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMaximum
            // 
            this.labelMaximum.AutoSize = true;
            this.labelMaximum.Location = new System.Drawing.Point(6, 109);
            this.labelMaximum.Name = "labelMaximum";
            this.labelMaximum.Size = new System.Drawing.Size(51, 13);
            this.labelMaximum.TabIndex = 7;
            this.labelMaximum.Text = "Maximum";
            this.labelMaximum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMinimalValue
            // 
            this.labelMinimalValue.AutoSize = true;
            this.labelMinimalValue.Location = new System.Drawing.Point(318, 80);
            this.labelMinimalValue.Name = "labelMinimalValue";
            this.labelMinimalValue.Size = new System.Drawing.Size(24, 13);
            this.labelMinimalValue.TabIndex = 5;
            this.labelMinimalValue.Text = "0 %";
            this.labelMinimalValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMinimal
            // 
            this.labelMinimal.AutoSize = true;
            this.labelMinimal.Location = new System.Drawing.Point(6, 80);
            this.labelMinimal.Name = "labelMinimal";
            this.labelMinimal.Size = new System.Drawing.Size(42, 13);
            this.labelMinimal.TabIndex = 4;
            this.labelMinimal.Text = "Minimal";
            this.labelMinimal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.linkLabel1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.pictureBoxBRW);
            this.groupBox3.Controls.Add(this.buttonCalibrate);
            this.groupBox3.Controls.Add(this.buttonCenterWheel);
            this.groupBox3.Controls.Add(this.labelRotationValue);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.trackBarRotation);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 241);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(234, 128);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(52, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "facebook";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Developed by Fernando Igor";
            // 
            // pictureBoxBRW
            // 
            this.pictureBoxBRW.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBRW.Image")));
            this.pictureBoxBRW.Location = new System.Drawing.Point(9, 19);
            this.pictureBoxBRW.Name = "pictureBoxBRW";
            this.pictureBoxBRW.Size = new System.Drawing.Size(294, 102);
            this.pictureBoxBRW.TabIndex = 8;
            this.pictureBoxBRW.TabStop = false;
            this.pictureBoxBRW.Click += new System.EventHandler(this.pictureBoxBRW_Clicked);
            // 
            // buttonCalibrate
            // 
            this.buttonCalibrate.Location = new System.Drawing.Point(96, 190);
            this.buttonCalibrate.Name = "buttonCalibrate";
            this.buttonCalibrate.Size = new System.Drawing.Size(81, 23);
            this.buttonCalibrate.TabIndex = 7;
            this.buttonCalibrate.Text = "Calibrate";
            this.buttonCalibrate.UseVisualStyleBackColor = true;
            this.buttonCalibrate.Click += new System.EventHandler(this.buttonCalibrate_Click);
            // 
            // buttonCenterWheel
            // 
            this.buttonCenterWheel.Location = new System.Drawing.Point(9, 190);
            this.buttonCenterWheel.Name = "buttonCenterWheel";
            this.buttonCenterWheel.Size = new System.Drawing.Size(81, 23);
            this.buttonCenterWheel.TabIndex = 6;
            this.buttonCenterWheel.Text = "Center Wheel";
            this.buttonCenterWheel.UseVisualStyleBackColor = true;
            // 
            // labelRotationValue
            // 
            this.labelRotationValue.AutoSize = true;
            this.labelRotationValue.Location = new System.Drawing.Point(272, 162);
            this.labelRotationValue.Name = "labelRotationValue";
            this.labelRotationValue.Size = new System.Drawing.Size(32, 13);
            this.labelRotationValue.TabIndex = 5;
            this.labelRotationValue.Text = "900 º";
            this.labelRotationValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Max Angle";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // trackBarRotation
            // 
            this.trackBarRotation.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBarRotation.Location = new System.Drawing.Point(67, 159);
            this.trackBarRotation.Maximum = 900;
            this.trackBarRotation.Minimum = 180;
            this.trackBarRotation.Name = "trackBarRotation";
            this.trackBarRotation.Size = new System.Drawing.Size(199, 45);
            this.trackBarRotation.TabIndex = 2;
            this.trackBarRotation.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarRotation.Value = 900;
            this.trackBarRotation.Scroll += new System.EventHandler(this.trackBarRotation_Scroll);
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.labelProfileVersion);
            this.groupBoxStatus.Controls.Add(this.label3);
            this.groupBoxStatus.Controls.Add(this.labelFirmwareVersion);
            this.groupBoxStatus.Controls.Add(this.labelFirmware);
            this.groupBoxStatus.Controls.Add(this.labelStatusValue);
            this.groupBoxStatus.Controls.Add(this.labelStatus);
            this.groupBoxStatus.Controls.Add(this.labelCOMPort);
            this.groupBoxStatus.Controls.Add(this.comboBoxCOM);
            this.groupBoxStatus.Location = new System.Drawing.Point(12, 259);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(309, 159);
            this.groupBoxStatus.TabIndex = 14;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Status";
            // 
            // labelProfileVersion
            // 
            this.labelProfileVersion.AutoSize = true;
            this.labelProfileVersion.Location = new System.Drawing.Point(232, 52);
            this.labelProfileVersion.Name = "labelProfileVersion";
            this.labelProfileVersion.Size = new System.Drawing.Size(47, 13);
            this.labelProfileVersion.TabIndex = 7;
            this.labelProfileVersion.Text = "Unknow";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Profile Version:";
            // 
            // labelFirmwareVersion
            // 
            this.labelFirmwareVersion.AutoSize = true;
            this.labelFirmwareVersion.Location = new System.Drawing.Point(58, 52);
            this.labelFirmwareVersion.Name = "labelFirmwareVersion";
            this.labelFirmwareVersion.Size = new System.Drawing.Size(47, 13);
            this.labelFirmwareVersion.TabIndex = 5;
            this.labelFirmwareVersion.Text = "Unknow";
            // 
            // labelFirmware
            // 
            this.labelFirmware.AutoSize = true;
            this.labelFirmware.Location = new System.Drawing.Point(7, 52);
            this.labelFirmware.Name = "labelFirmware";
            this.labelFirmware.Size = new System.Drawing.Size(52, 13);
            this.labelFirmware.TabIndex = 4;
            this.labelFirmware.Text = "Firmware:";
            // 
            // labelStatusValue
            // 
            this.labelStatusValue.AutoSize = true;
            this.labelStatusValue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelStatusValue.ForeColor = System.Drawing.Color.Red;
            this.labelStatusValue.Location = new System.Drawing.Point(43, 22);
            this.labelStatusValue.Name = "labelStatusValue";
            this.labelStatusValue.Size = new System.Drawing.Size(47, 13);
            this.labelStatusValue.TabIndex = 3;
            this.labelStatusValue.Text = "Unknow";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelStatus.Location = new System.Drawing.Point(6, 22);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(34, 13);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "Stats:";
            // 
            // labelCOMPort
            // 
            this.labelCOMPort.AutoSize = true;
            this.labelCOMPort.Location = new System.Drawing.Point(161, 22);
            this.labelCOMPort.Name = "labelCOMPort";
            this.labelCOMPort.Size = new System.Drawing.Size(53, 13);
            this.labelCOMPort.TabIndex = 1;
            this.labelCOMPort.Text = "COM Port";
            // 
            // comboBoxCOM
            // 
            this.comboBoxCOM.FormattingEnabled = true;
            this.comboBoxCOM.Location = new System.Drawing.Point(220, 19);
            this.comboBoxCOM.Name = "comboBoxCOM";
            this.comboBoxCOM.Size = new System.Drawing.Size(83, 21);
            this.comboBoxCOM.TabIndex = 0;
            this.comboBoxCOM.SelectedIndexChanged += new System.EventHandler(this.comboBoxCOM_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.time_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.RtsEnable = true;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // FormBRWProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(702, 430);
            this.Controls.Add(this.groupBoxForce);
            this.Controls.Add(this.groupBoxEffects);
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(718, 469);
            this.MinimumSize = new System.Drawing.Size(718, 469);
            this.Name = "FormBRWProfile";
            this.Opacity = 0.97D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "BRWheel Profile";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBRWProfile_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGain)).EndInit();
            this.groupBoxEffects.ResumeLayout(false);
            this.groupBoxEffects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpring)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarInertia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDamper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFriction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarConstant)).EndInit();
            this.groupBoxForce.ResumeLayout(false);
            this.groupBoxForce.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMaximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDesktop)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBRW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotation)).EndInit();
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarGain;
        private System.Windows.Forms.GroupBox groupBoxEffects;
        private System.Windows.Forms.Label labelGain;
        private System.Windows.Forms.Label labelGainValue;
        private System.Windows.Forms.Label labelConstantValue;
        private System.Windows.Forms.Label labelConstant;
        private System.Windows.Forms.TrackBar trackBarConstant;
        private System.Windows.Forms.Label labelFrictionValue;
        private System.Windows.Forms.Label labelFriction;
        private System.Windows.Forms.TrackBar trackBarFriction;
        private System.Windows.Forms.GroupBox groupBoxForce;
        private System.Windows.Forms.Label labelMaximumValue;
        private System.Windows.Forms.Label labelMaximum;
        private System.Windows.Forms.TrackBar trackBarMaximum;
        private System.Windows.Forms.Label labelMinimalValue;
        private System.Windows.Forms.Label labelMinimal;
        private System.Windows.Forms.TrackBar trackBarMinimal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelRotationValue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TrackBar trackBarRotation;
        private System.Windows.Forms.PictureBox pictureBoxBRW;
        private System.Windows.Forms.Button buttonCalibrate;
        private System.Windows.Forms.Button buttonCenterWheel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxCOM;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelCOMPort;
        private System.Windows.Forms.Label labelStatusValue;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label labelSine;
        private System.Windows.Forms.TrackBar trackBarSine;
        private System.Windows.Forms.TrackBar trackBarSpring;
        private System.Windows.Forms.Label labelSpringValue;
        private System.Windows.Forms.Label labelSpring;
        private System.Windows.Forms.TrackBar trackBarInertia;
        private System.Windows.Forms.Label labelInertiaValue;
        private System.Windows.Forms.Label labelInertia;
        private System.Windows.Forms.Label labelDamperValue;
        private System.Windows.Forms.Label labelDamper;
        private System.Windows.Forms.TrackBar trackBarDamper;
        private System.Windows.Forms.Label labelSineValue;
        private System.Windows.Forms.Label labelStopValue;
        private System.Windows.Forms.Label labelStop;
        private System.Windows.Forms.TrackBar trackBarStop;
        private System.Windows.Forms.Label labelDesktopValue;
        private System.Windows.Forms.Label labelDesktop;
        private System.Windows.Forms.TrackBar trackBarDesktop;
        private System.Windows.Forms.Label labelFirmware;
        private System.Windows.Forms.Label labelFirmwareVersion;
        private System.Windows.Forms.Label labelProfileVersion;
        private System.Windows.Forms.Label label3;
    }
}

