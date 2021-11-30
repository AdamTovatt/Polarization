
namespace Polarization
{
    partial class PolarizationLab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PolarizationLab));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.viewFiLabel = new System.Windows.Forms.Label();
            this.viewFiTrackBar = new System.Windows.Forms.TrackBar();
            this.viewTetaLabel = new System.Windows.Forms.Label();
            this.viewTetaTrackBar = new System.Windows.Forms.TrackBar();
            this.viewTitle = new System.Windows.Forms.Label();
            this.viewRLabel = new System.Windows.Forms.Label();
            this.viewRTrackBar = new System.Windows.Forms.TrackBar();
            this.phase1Label = new System.Windows.Forms.Label();
            this.phase1TrackBar = new System.Windows.Forms.TrackBar();
            this.frequency1Label = new System.Windows.Forms.Label();
            this.frequency1TrackBar = new System.Windows.Forms.TrackBar();
            this.waveLength1Label = new System.Windows.Forms.Label();
            this.waveLength1TrackBar = new System.Windows.Forms.TrackBar();
            this.amplitude1Label = new System.Windows.Forms.Label();
            this.leftPanelTitle = new System.Windows.Forms.Label();
            this.amplitude1TrackBar = new System.Windows.Forms.TrackBar();
            this.middlePanel = new System.Windows.Forms.Panel();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.timeScaleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeScaleTrackBar = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.zMaxLabel = new System.Windows.Forms.Label();
            this.zMaxTrackBar = new System.Windows.Forms.TrackBar();
            this.zMinLabel = new System.Windows.Forms.Label();
            this.zMinTrackBar = new System.Windows.Forms.TrackBar();
            this.axisLimitTitle = new System.Windows.Forms.Label();
            this.phase2Label = new System.Windows.Forms.Label();
            this.phase2TrackBar = new System.Windows.Forms.TrackBar();
            this.frequency2Label = new System.Windows.Forms.Label();
            this.frequency2TrackBar = new System.Windows.Forms.TrackBar();
            this.waveLength2Label = new System.Windows.Forms.Label();
            this.waveLength2TrackBar = new System.Windows.Forms.TrackBar();
            this.amplitude2Label = new System.Windows.Forms.Label();
            this.amplitude2TrackBar = new System.Windows.Forms.TrackBar();
            this.rightPanelTitle = new System.Windows.Forms.Label();
            this.zoomLabel = new System.Windows.Forms.Label();
            this.zoomTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewFiTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTetaTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewRTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phase1TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequency1TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveLength1TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplitude1TrackBar)).BeginInit();
            this.middlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeScaleTrackBar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zMaxTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zMinTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phase2TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequency2TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveLength2TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplitude2TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(519, 492);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.middlePanel);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(946, 625);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.viewFiLabel);
            this.panel1.Controls.Add(this.viewFiTrackBar);
            this.panel1.Controls.Add(this.viewTetaLabel);
            this.panel1.Controls.Add(this.viewTetaTrackBar);
            this.panel1.Controls.Add(this.viewTitle);
            this.panel1.Controls.Add(this.viewRLabel);
            this.panel1.Controls.Add(this.viewRTrackBar);
            this.panel1.Controls.Add(this.phase1Label);
            this.panel1.Controls.Add(this.phase1TrackBar);
            this.panel1.Controls.Add(this.frequency1Label);
            this.panel1.Controls.Add(this.frequency1TrackBar);
            this.panel1.Controls.Add(this.waveLength1Label);
            this.panel1.Controls.Add(this.waveLength1TrackBar);
            this.panel1.Controls.Add(this.amplitude1Label);
            this.panel1.Controls.Add(this.leftPanelTitle);
            this.panel1.Controls.Add(this.amplitude1TrackBar);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 622);
            this.panel1.TabIndex = 1;
            // 
            // viewFiLabel
            // 
            this.viewFiLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewFiLabel.Location = new System.Drawing.Point(26, 548);
            this.viewFiLabel.Name = "viewFiLabel";
            this.viewFiLabel.Size = new System.Drawing.Size(171, 23);
            this.viewFiLabel.TabIndex = 20;
            this.viewFiLabel.Text = "fi: 0,2 Pi";
            this.viewFiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // viewFiTrackBar
            // 
            this.viewFiTrackBar.LargeChange = 10;
            this.viewFiTrackBar.Location = new System.Drawing.Point(23, 574);
            this.viewFiTrackBar.Maximum = 100;
            this.viewFiTrackBar.Name = "viewFiTrackBar";
            this.viewFiTrackBar.Size = new System.Drawing.Size(154, 45);
            this.viewFiTrackBar.SmallChange = 10;
            this.viewFiTrackBar.TabIndex = 21;
            this.viewFiTrackBar.TickFrequency = 10;
            this.viewFiTrackBar.Value = 20;
            this.viewFiTrackBar.Scroll += new System.EventHandler(this.viewFiTrackBar_Scroll);
            // 
            // viewTetaLabel
            // 
            this.viewTetaLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTetaLabel.Location = new System.Drawing.Point(26, 487);
            this.viewTetaLabel.Name = "viewTetaLabel";
            this.viewTetaLabel.Size = new System.Drawing.Size(171, 23);
            this.viewTetaLabel.TabIndex = 18;
            this.viewTetaLabel.Text = "teta: 0,4 Pi";
            this.viewTetaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // viewTetaTrackBar
            // 
            this.viewTetaTrackBar.LargeChange = 10;
            this.viewTetaTrackBar.Location = new System.Drawing.Point(23, 513);
            this.viewTetaTrackBar.Maximum = 100;
            this.viewTetaTrackBar.Name = "viewTetaTrackBar";
            this.viewTetaTrackBar.Size = new System.Drawing.Size(154, 45);
            this.viewTetaTrackBar.SmallChange = 10;
            this.viewTetaTrackBar.TabIndex = 19;
            this.viewTetaTrackBar.TickFrequency = 10;
            this.viewTetaTrackBar.Value = 40;
            this.viewTetaTrackBar.Scroll += new System.EventHandler(this.viewTetaTrackBar_Scroll);
            // 
            // viewTitle
            // 
            this.viewTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTitle.Location = new System.Drawing.Point(0, 388);
            this.viewTitle.Name = "viewTitle";
            this.viewTitle.Size = new System.Drawing.Size(200, 23);
            this.viewTitle.TabIndex = 17;
            this.viewTitle.Text = "View";
            this.viewTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewRLabel
            // 
            this.viewRLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewRLabel.Location = new System.Drawing.Point(26, 424);
            this.viewRLabel.Name = "viewRLabel";
            this.viewRLabel.Size = new System.Drawing.Size(171, 23);
            this.viewRLabel.TabIndex = 15;
            this.viewRLabel.Text = "r: 3";
            this.viewRLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // viewRTrackBar
            // 
            this.viewRTrackBar.LargeChange = 10;
            this.viewRTrackBar.Location = new System.Drawing.Point(23, 450);
            this.viewRTrackBar.Maximum = 100;
            this.viewRTrackBar.Minimum = 1;
            this.viewRTrackBar.Name = "viewRTrackBar";
            this.viewRTrackBar.Size = new System.Drawing.Size(154, 45);
            this.viewRTrackBar.SmallChange = 10;
            this.viewRTrackBar.TabIndex = 16;
            this.viewRTrackBar.TickFrequency = 5;
            this.viewRTrackBar.Value = 3;
            this.viewRTrackBar.Scroll += new System.EventHandler(this.viewRTrackBar_Scroll);
            // 
            // phase1Label
            // 
            this.phase1Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phase1Label.Location = new System.Drawing.Point(23, 291);
            this.phase1Label.Name = "phase1Label";
            this.phase1Label.Size = new System.Drawing.Size(171, 23);
            this.phase1Label.TabIndex = 13;
            this.phase1Label.Text = "Phase 0 Pi";
            this.phase1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phase1TrackBar
            // 
            this.phase1TrackBar.LargeChange = 10;
            this.phase1TrackBar.Location = new System.Drawing.Point(20, 317);
            this.phase1TrackBar.Maximum = 200;
            this.phase1TrackBar.Name = "phase1TrackBar";
            this.phase1TrackBar.Size = new System.Drawing.Size(154, 45);
            this.phase1TrackBar.SmallChange = 10;
            this.phase1TrackBar.TabIndex = 14;
            this.phase1TrackBar.TickFrequency = 20;
            this.phase1TrackBar.Scroll += new System.EventHandler(this.phase1TrackBar_Scroll);
            // 
            // frequency1Label
            // 
            this.frequency1Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frequency1Label.Location = new System.Drawing.Point(26, 217);
            this.frequency1Label.Name = "frequency1Label";
            this.frequency1Label.Size = new System.Drawing.Size(171, 23);
            this.frequency1Label.TabIndex = 11;
            this.frequency1Label.Text = "Frequency: 0";
            this.frequency1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frequency1TrackBar
            // 
            this.frequency1TrackBar.LargeChange = 10;
            this.frequency1TrackBar.Location = new System.Drawing.Point(23, 243);
            this.frequency1TrackBar.Maximum = 100;
            this.frequency1TrackBar.Name = "frequency1TrackBar";
            this.frequency1TrackBar.Size = new System.Drawing.Size(154, 45);
            this.frequency1TrackBar.SmallChange = 10;
            this.frequency1TrackBar.TabIndex = 12;
            this.frequency1TrackBar.TickFrequency = 20;
            this.frequency1TrackBar.Value = 10;
            this.frequency1TrackBar.Scroll += new System.EventHandler(this.frequency1TrackBar_Scroll);
            // 
            // waveLength1Label
            // 
            this.waveLength1Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waveLength1Label.Location = new System.Drawing.Point(29, 143);
            this.waveLength1Label.Name = "waveLength1Label";
            this.waveLength1Label.Size = new System.Drawing.Size(171, 23);
            this.waveLength1Label.TabIndex = 9;
            this.waveLength1Label.Text = "Wavelength: 0";
            this.waveLength1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // waveLength1TrackBar
            // 
            this.waveLength1TrackBar.LargeChange = 10;
            this.waveLength1TrackBar.Location = new System.Drawing.Point(26, 169);
            this.waveLength1TrackBar.Maximum = 100;
            this.waveLength1TrackBar.Name = "waveLength1TrackBar";
            this.waveLength1TrackBar.Size = new System.Drawing.Size(154, 45);
            this.waveLength1TrackBar.SmallChange = 10;
            this.waveLength1TrackBar.TabIndex = 10;
            this.waveLength1TrackBar.TickFrequency = 20;
            this.waveLength1TrackBar.Value = 25;
            this.waveLength1TrackBar.Scroll += new System.EventHandler(this.waveLength1TrackBar_Scroll);
            // 
            // amplitude1Label
            // 
            this.amplitude1Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amplitude1Label.Location = new System.Drawing.Point(26, 69);
            this.amplitude1Label.Name = "amplitude1Label";
            this.amplitude1Label.Size = new System.Drawing.Size(171, 23);
            this.amplitude1Label.TabIndex = 7;
            this.amplitude1Label.Text = "Amplitude: 0 π";
            this.amplitude1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // leftPanelTitle
            // 
            this.leftPanelTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftPanelTitle.Location = new System.Drawing.Point(0, 18);
            this.leftPanelTitle.Name = "leftPanelTitle";
            this.leftPanelTitle.Size = new System.Drawing.Size(200, 23);
            this.leftPanelTitle.TabIndex = 1;
            this.leftPanelTitle.Text = "y - Component";
            this.leftPanelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // amplitude1TrackBar
            // 
            this.amplitude1TrackBar.LargeChange = 10;
            this.amplitude1TrackBar.Location = new System.Drawing.Point(23, 95);
            this.amplitude1TrackBar.Maximum = 100;
            this.amplitude1TrackBar.Name = "amplitude1TrackBar";
            this.amplitude1TrackBar.Size = new System.Drawing.Size(154, 45);
            this.amplitude1TrackBar.SmallChange = 10;
            this.amplitude1TrackBar.TabIndex = 8;
            this.amplitude1TrackBar.TickFrequency = 20;
            this.amplitude1TrackBar.Scroll += new System.EventHandler(this.amplitude1TrackBar_Scroll);
            // 
            // middlePanel
            // 
            this.middlePanel.Controls.Add(this.stopButton);
            this.middlePanel.Controls.Add(this.startButton);
            this.middlePanel.Controls.Add(this.timeScaleLabel);
            this.middlePanel.Controls.Add(this.label2);
            this.middlePanel.Controls.Add(this.pictureBox);
            this.middlePanel.Controls.Add(this.timeScaleTrackBar);
            this.middlePanel.Location = new System.Drawing.Point(209, 3);
            this.middlePanel.Name = "middlePanel";
            this.middlePanel.Size = new System.Drawing.Size(526, 622);
            this.middlePanel.TabIndex = 4;
            // 
            // stopButton
            // 
            this.stopButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(390, 550);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(82, 45);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(284, 550);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(82, 45);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timeScaleLabel
            // 
            this.timeScaleLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.timeScaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeScaleLabel.Location = new System.Drawing.Point(28, 590);
            this.timeScaleLabel.Name = "timeScaleLabel";
            this.timeScaleLabel.Size = new System.Drawing.Size(219, 23);
            this.timeScaleLabel.TabIndex = 4;
            this.timeScaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 524);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time Scale";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeScaleTrackBar
            // 
            this.timeScaleTrackBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.timeScaleTrackBar.LargeChange = 10;
            this.timeScaleTrackBar.Location = new System.Drawing.Point(28, 550);
            this.timeScaleTrackBar.Maximum = 200;
            this.timeScaleTrackBar.Name = "timeScaleTrackBar";
            this.timeScaleTrackBar.Size = new System.Drawing.Size(219, 45);
            this.timeScaleTrackBar.SmallChange = 10;
            this.timeScaleTrackBar.TabIndex = 3;
            this.timeScaleTrackBar.TickFrequency = 20;
            this.timeScaleTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.timeScaleTrackBar.Value = 100;
            this.timeScaleTrackBar.Scroll += new System.EventHandler(this.timeScaleTrackBar_Scroll);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.zoomLabel);
            this.panel2.Controls.Add(this.zoomTrackBar);
            this.panel2.Controls.Add(this.zMaxLabel);
            this.panel2.Controls.Add(this.zMaxTrackBar);
            this.panel2.Controls.Add(this.zMinLabel);
            this.panel2.Controls.Add(this.zMinTrackBar);
            this.panel2.Controls.Add(this.axisLimitTitle);
            this.panel2.Controls.Add(this.phase2Label);
            this.panel2.Controls.Add(this.phase2TrackBar);
            this.panel2.Controls.Add(this.frequency2Label);
            this.panel2.Controls.Add(this.frequency2TrackBar);
            this.panel2.Controls.Add(this.waveLength2Label);
            this.panel2.Controls.Add(this.waveLength2TrackBar);
            this.panel2.Controls.Add(this.amplitude2Label);
            this.panel2.Controls.Add(this.amplitude2TrackBar);
            this.panel2.Controls.Add(this.rightPanelTitle);
            this.panel2.Location = new System.Drawing.Point(741, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 622);
            this.panel2.TabIndex = 2;
            // 
            // zMaxLabel
            // 
            this.zMaxLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zMaxLabel.Location = new System.Drawing.Point(26, 463);
            this.zMaxLabel.Name = "zMaxLabel";
            this.zMaxLabel.Size = new System.Drawing.Size(171, 23);
            this.zMaxLabel.TabIndex = 26;
            this.zMaxLabel.Text = "zmax:";
            this.zMaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // zMaxTrackBar
            // 
            this.zMaxTrackBar.LargeChange = 10;
            this.zMaxTrackBar.Location = new System.Drawing.Point(23, 489);
            this.zMaxTrackBar.Maximum = 100;
            this.zMaxTrackBar.Name = "zMaxTrackBar";
            this.zMaxTrackBar.Size = new System.Drawing.Size(154, 45);
            this.zMaxTrackBar.SmallChange = 10;
            this.zMaxTrackBar.TabIndex = 27;
            this.zMaxTrackBar.TickFrequency = 20;
            this.zMaxTrackBar.Scroll += new System.EventHandler(this.zMaxTrackBar_Scroll);
            // 
            // zMinLabel
            // 
            this.zMinLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zMinLabel.Location = new System.Drawing.Point(26, 402);
            this.zMinLabel.Name = "zMinLabel";
            this.zMinLabel.Size = new System.Drawing.Size(171, 23);
            this.zMinLabel.TabIndex = 24;
            this.zMinLabel.Text = "zmin: 0";
            this.zMinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // zMinTrackBar
            // 
            this.zMinTrackBar.LargeChange = 10;
            this.zMinTrackBar.Location = new System.Drawing.Point(23, 428);
            this.zMinTrackBar.Maximum = 100;
            this.zMinTrackBar.Name = "zMinTrackBar";
            this.zMinTrackBar.Size = new System.Drawing.Size(154, 45);
            this.zMinTrackBar.SmallChange = 10;
            this.zMinTrackBar.TabIndex = 25;
            this.zMinTrackBar.TickFrequency = 20;
            this.zMinTrackBar.Value = 100;
            this.zMinTrackBar.Scroll += new System.EventHandler(this.zMinTrackBar_Scroll);
            // 
            // axisLimitTitle
            // 
            this.axisLimitTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axisLimitTitle.Location = new System.Drawing.Point(0, 365);
            this.axisLimitTitle.Name = "axisLimitTitle";
            this.axisLimitTitle.Size = new System.Drawing.Size(200, 23);
            this.axisLimitTitle.TabIndex = 23;
            this.axisLimitTitle.Text = "Axis limits";
            this.axisLimitTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phase2Label
            // 
            this.phase2Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phase2Label.Location = new System.Drawing.Point(23, 291);
            this.phase2Label.Name = "phase2Label";
            this.phase2Label.Size = new System.Drawing.Size(171, 23);
            this.phase2Label.TabIndex = 21;
            this.phase2Label.Text = "Phase 0 Pi";
            this.phase2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phase2TrackBar
            // 
            this.phase2TrackBar.LargeChange = 10;
            this.phase2TrackBar.Location = new System.Drawing.Point(20, 317);
            this.phase2TrackBar.Maximum = 200;
            this.phase2TrackBar.Name = "phase2TrackBar";
            this.phase2TrackBar.Size = new System.Drawing.Size(154, 45);
            this.phase2TrackBar.SmallChange = 10;
            this.phase2TrackBar.TabIndex = 22;
            this.phase2TrackBar.TickFrequency = 20;
            this.phase2TrackBar.Scroll += new System.EventHandler(this.phase2TrackBar_Scroll);
            // 
            // frequency2Label
            // 
            this.frequency2Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frequency2Label.Location = new System.Drawing.Point(26, 217);
            this.frequency2Label.Name = "frequency2Label";
            this.frequency2Label.Size = new System.Drawing.Size(171, 23);
            this.frequency2Label.TabIndex = 19;
            this.frequency2Label.Text = "Frequency: 0";
            this.frequency2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frequency2TrackBar
            // 
            this.frequency2TrackBar.LargeChange = 10;
            this.frequency2TrackBar.Location = new System.Drawing.Point(23, 243);
            this.frequency2TrackBar.Maximum = 100;
            this.frequency2TrackBar.Name = "frequency2TrackBar";
            this.frequency2TrackBar.Size = new System.Drawing.Size(154, 45);
            this.frequency2TrackBar.SmallChange = 10;
            this.frequency2TrackBar.TabIndex = 20;
            this.frequency2TrackBar.TickFrequency = 20;
            this.frequency2TrackBar.Value = 10;
            this.frequency2TrackBar.Scroll += new System.EventHandler(this.frequency2TrackBar_Scroll);
            // 
            // waveLength2Label
            // 
            this.waveLength2Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waveLength2Label.Location = new System.Drawing.Point(29, 143);
            this.waveLength2Label.Name = "waveLength2Label";
            this.waveLength2Label.Size = new System.Drawing.Size(171, 23);
            this.waveLength2Label.TabIndex = 17;
            this.waveLength2Label.Text = "Wavelength: 0";
            this.waveLength2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // waveLength2TrackBar
            // 
            this.waveLength2TrackBar.LargeChange = 10;
            this.waveLength2TrackBar.Location = new System.Drawing.Point(26, 169);
            this.waveLength2TrackBar.Maximum = 100;
            this.waveLength2TrackBar.Name = "waveLength2TrackBar";
            this.waveLength2TrackBar.Size = new System.Drawing.Size(154, 45);
            this.waveLength2TrackBar.SmallChange = 10;
            this.waveLength2TrackBar.TabIndex = 18;
            this.waveLength2TrackBar.TickFrequency = 20;
            this.waveLength2TrackBar.Value = 25;
            this.waveLength2TrackBar.Scroll += new System.EventHandler(this.waveLength2TrackBar_Scroll);
            // 
            // amplitude2Label
            // 
            this.amplitude2Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amplitude2Label.Location = new System.Drawing.Point(26, 69);
            this.amplitude2Label.Name = "amplitude2Label";
            this.amplitude2Label.Size = new System.Drawing.Size(171, 23);
            this.amplitude2Label.TabIndex = 15;
            this.amplitude2Label.Text = "Amplitude: 0";
            this.amplitude2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // amplitude2TrackBar
            // 
            this.amplitude2TrackBar.LargeChange = 10;
            this.amplitude2TrackBar.Location = new System.Drawing.Point(23, 95);
            this.amplitude2TrackBar.Maximum = 100;
            this.amplitude2TrackBar.Name = "amplitude2TrackBar";
            this.amplitude2TrackBar.Size = new System.Drawing.Size(154, 45);
            this.amplitude2TrackBar.SmallChange = 10;
            this.amplitude2TrackBar.TabIndex = 16;
            this.amplitude2TrackBar.TickFrequency = 20;
            this.amplitude2TrackBar.Value = 30;
            this.amplitude2TrackBar.Scroll += new System.EventHandler(this.amplitude2TrackBar_Scroll);
            // 
            // rightPanelTitle
            // 
            this.rightPanelTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightPanelTitle.Location = new System.Drawing.Point(0, 18);
            this.rightPanelTitle.Name = "rightPanelTitle";
            this.rightPanelTitle.Size = new System.Drawing.Size(200, 23);
            this.rightPanelTitle.TabIndex = 0;
            this.rightPanelTitle.Text = "z - Component";
            this.rightPanelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zoomLabel
            // 
            this.zoomLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoomLabel.Location = new System.Drawing.Point(26, 528);
            this.zoomLabel.Name = "zoomLabel";
            this.zoomLabel.Size = new System.Drawing.Size(171, 23);
            this.zoomLabel.TabIndex = 28;
            this.zoomLabel.Text = "zoom:";
            this.zoomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // zoomTrackBar
            // 
            this.zoomTrackBar.LargeChange = 10;
            this.zoomTrackBar.Location = new System.Drawing.Point(23, 554);
            this.zoomTrackBar.Maximum = 20;
            this.zoomTrackBar.Name = "zoomTrackBar";
            this.zoomTrackBar.Size = new System.Drawing.Size(154, 45);
            this.zoomTrackBar.SmallChange = 10;
            this.zoomTrackBar.TabIndex = 29;
            this.zoomTrackBar.TickFrequency = 5;
            this.zoomTrackBar.Value = 10;
            this.zoomTrackBar.Scroll += new System.EventHandler(this.zoomTrackBar_Scroll);
            // 
            // PolarizationLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(946, 625);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "PolarizationLab";
            this.Text = "Polarization Lab";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewFiTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTetaTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewRTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phase1TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequency1TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveLength1TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplitude1TrackBar)).EndInit();
            this.middlePanel.ResumeLayout(false);
            this.middlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeScaleTrackBar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zMaxTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zMinTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phase2TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequency2TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveLength2TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplitude2TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label rightPanelTitle;
        private System.Windows.Forms.Label leftPanelTitle;
        private System.Windows.Forms.Panel middlePanel;
        private System.Windows.Forms.TrackBar timeScaleTrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timeScaleLabel;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label amplitude1Label;
        private System.Windows.Forms.TrackBar amplitude1TrackBar;
        private System.Windows.Forms.Label waveLength1Label;
        private System.Windows.Forms.TrackBar waveLength1TrackBar;
        private System.Windows.Forms.Label phase1Label;
        private System.Windows.Forms.TrackBar phase1TrackBar;
        private System.Windows.Forms.Label frequency1Label;
        private System.Windows.Forms.TrackBar frequency1TrackBar;
        private System.Windows.Forms.Label viewRLabel;
        private System.Windows.Forms.TrackBar viewRTrackBar;
        private System.Windows.Forms.Label viewFiLabel;
        private System.Windows.Forms.TrackBar viewFiTrackBar;
        private System.Windows.Forms.Label viewTetaLabel;
        private System.Windows.Forms.TrackBar viewTetaTrackBar;
        private System.Windows.Forms.Label viewTitle;
        private System.Windows.Forms.Label phase2Label;
        private System.Windows.Forms.TrackBar phase2TrackBar;
        private System.Windows.Forms.Label frequency2Label;
        private System.Windows.Forms.TrackBar frequency2TrackBar;
        private System.Windows.Forms.Label waveLength2Label;
        private System.Windows.Forms.TrackBar waveLength2TrackBar;
        private System.Windows.Forms.Label amplitude2Label;
        private System.Windows.Forms.TrackBar amplitude2TrackBar;
        private System.Windows.Forms.Label axisLimitTitle;
        private System.Windows.Forms.Label zMaxLabel;
        private System.Windows.Forms.TrackBar zMaxTrackBar;
        private System.Windows.Forms.Label zMinLabel;
        private System.Windows.Forms.TrackBar zMinTrackBar;
        private System.Windows.Forms.Label zoomLabel;
        private System.Windows.Forms.TrackBar zoomTrackBar;
    }
}

